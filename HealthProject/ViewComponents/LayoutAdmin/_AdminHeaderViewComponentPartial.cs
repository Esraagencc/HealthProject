using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.LayoutAdmin
{
    public class _AdminHeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
