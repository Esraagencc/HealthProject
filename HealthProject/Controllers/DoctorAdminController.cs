using Health.BLL.Abstract;
using Health.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var doctors = _doctorService.GetAllDoctors();

            dynamic myModel = new ExpandoObject();
            myModel.Doctors = doctors;

            return View(myModel);
        }

        public IActionResult Create()
        {
            var branches = _branchService.GetAll();

            //ViewBag.Branches = new SelectList(branches, "Id", "Name");

            dynamic myModel = new ExpandoObject();
            myModel.Branches = branches;

            return View(myModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Doctor doctor, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Dosya bulunamadı.");
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

            var branches = _branchService.GetAll();
            ViewBag.Branches = new SelectList(branches, "Id", "Name");
            return View(doctor);
        }

        public IActionResult Edit(int id)
        {
            var doctor = _doctorService.GetDoctor(id);
            if (doctor == null)
            {
                return NotFound();
            }

            var branches = _branchService.GetAll();

            dynamic myModel = new ExpandoObject();
            myModel.Doctor = doctor;
            myModel.Branches = branches;


            //ViewBag.Branches = new SelectList(branches, "Id", "Name", doctor.BranchId);

            return View(myModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Doctor doctor, IFormFile file)
        {
            var existingDoctor = _doctorService.ExistingDoctor(doctor.Id);

            if (existingDoctor == null)
                return NotFound();

            try
            {
                if (file != null && file.Length > 0)
                {
                    var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                    if (!Directory.Exists(uploadsFolderPath))
                    {
                        Directory.CreateDirectory(uploadsFolderPath);
                    }

                    var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
                    var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    existingDoctor.ImagePath = uniqueFileName;
                }

               
                existingDoctor.Name = doctor.Name;
                existingDoctor.Status = true;
                existingDoctor.BranchId = doctor.BranchId;

                _doctorService.UpdateDoctor(existingDoctor);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
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
