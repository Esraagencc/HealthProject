
using Health.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Dashboard
{
    public class _DashboardStatisticViewComponentPartial:ViewComponent
    {
        private readonly IDoctorService _doctorService;

        public _DashboardStatisticViewComponentPartial(IDoctorService service)
        {
            _doctorService = service;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.DoctorCount = _doctorService.GetAllDoctors().Count();
            return View();
        }
    }
}
