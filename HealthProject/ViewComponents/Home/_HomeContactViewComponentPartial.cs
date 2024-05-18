using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Home
{
    public class _HomeContactViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
