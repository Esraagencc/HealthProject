using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.LayoutAdmin
{
    public class _AdminFooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}