using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Home
{
    public class _HomeHeaderViewComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
