using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
