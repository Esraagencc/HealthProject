using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Layout
{
    public class _LayoutNavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
