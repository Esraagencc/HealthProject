
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
            //ViewBag.LastProductPrice = _statisticService.LastProductPrice();
            //ViewBag.TopCityByProductCount = _statisticService.TopCityByProductCount();
            //ViewBag.TopProductTypeByProductCount = _statisticService.TopProductTypeByProductCount();
            return View();
        }
    }
}
