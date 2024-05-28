using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.LayoutAdmin
{
    public class _AdminNavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}