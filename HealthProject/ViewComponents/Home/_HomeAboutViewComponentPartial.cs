using AutoMapper;
using Health.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.About
{
    public class _HomeAboutViewComponentPartial : ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
         
            return View();
        }
    }
}
