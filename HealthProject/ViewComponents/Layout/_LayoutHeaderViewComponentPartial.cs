using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Layout
{
    public class _LayoutHeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
