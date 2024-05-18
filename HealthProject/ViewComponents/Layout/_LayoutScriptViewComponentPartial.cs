using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Layout
{
    public class _LayoutScriptViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
