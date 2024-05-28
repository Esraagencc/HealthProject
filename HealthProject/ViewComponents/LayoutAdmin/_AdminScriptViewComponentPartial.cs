using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.LayoutAdmin
{
    public class _AdminScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
