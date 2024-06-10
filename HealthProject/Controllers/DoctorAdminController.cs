using Health.BLL.Abstract;
using Health.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace HealthProject.Controllers
{
    public class DoctorAdminController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IBranchService _branchService;

        public DoctorAdminController(IDoctorService doctorService, IBranchService branchService)
        {
            _doctorService = doctorService;
            _branchService = branchService;
        }


        public IActionResult Index()
        {
            var doctor = _doctorService.GetAllDoctors();

            return View(doctor);
        }


        public IActionResult Create()
        {
            var branchs = _branchService.GetAllBrach();
            var doctor = new Doctor();

            dynamic myModel = new ExpandoObject();
            myModel.Branches = branchs; 
            myModel.Doctor = doctor;
            return View(myModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Doctor doctor, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
            var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                doctor.ImagePath = uniqueFileName; // Save only the file name, not the full path
                doctor.Status = true;

                _doctorService.AddDoctor(doctor);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                // Log the error (uncomment the line below after adding a logger)
                // _logger.LogError(ex, "File upload failed.");
                ModelState.AddModelError("", "An error occurred while uploading the file. Please try again.");
            }

            return View(doctor);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = _doctorService.GetDoctor(id.Value);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormFile file)
        {

            var existingDoctor = _doctorService.GetDoctor(id);

            if (existingDoctor == null)
            {
                return NotFound();
            }

            if (file != null && file.Length > 0)
            {
                var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

                if (!Directory.Exists(uploadsFolderPath))
                {
                    Directory.CreateDirectory(uploadsFolderPath);
                }

                var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
                var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

                try
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    // Set the new file path
                    existingDoctor.ImagePath = uniqueFileName;
                }
                catch (Exception ex)
                {
                    // Log the error (uncomment the line below after adding a logger)
                    // _logger.LogError(ex, "File upload failed.");
                    ModelState.AddModelError("", "An error occurred while uploading the file. Please try again.");
                    return View(existingDoctor);
                }
            }
            else
            {
                // Retain the existing image path if no new file is uploaded
                existingDoctor.ImagePath = existingDoctor.ImagePath;
            }

            existingDoctor.Status = true;

            try
            {
                _doctorService.UpdateDoctor(existingDoctor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Handle exceptions if any
                // _logger.LogError(ex, "Update failed.");
                ModelState.AddModelError("", "An error occurred while updating the doctor. Please try again.");
            }


            return View(existingDoctor);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = _doctorService.FindDoctors(x => x.Id == id.Value);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor.FirstOrDefault());
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var doctor = _doctorService.FindDoctors(x => x.Id == id);
            if (doctor != null)
            {
                _doctorService.DeleteDoctor(doctor.FirstOrDefault());
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
