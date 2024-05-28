using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Health.DAL.Concrete.EFCore;
using Health.Entity;
using Health.BLL.Abstract;

namespace HealthProject.Controllers
{
    public class DoctorAdminController : Controller
    {
        private readonly IDoctorService _doctorService;

        public DoctorAdminController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }


        public IActionResult Index()
        {
            return View(_doctorService.GetAllDoctors());
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _doctorService.AddDoctor(doctor);
                return RedirectToAction(nameof(Index));
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
        public IActionResult Edit(int id, Doctor doctor)
        {
            if (id != doctor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _doctorService.UpdateDoctor(doctor);

                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
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
            var doctor =  _doctorService.FindDoctors(x=>x.Id == id);
            if (doctor != null)
            {
                _doctorService.DeleteDoctor(doctor.FirstOrDefault());
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
