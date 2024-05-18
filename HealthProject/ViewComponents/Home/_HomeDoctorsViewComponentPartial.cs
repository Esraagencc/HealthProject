using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Home
{
    public class _HomeDoctorsViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
