using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Layout
{
    public class _LayoutFooterViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
