﻿using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.LayoutAdmin
{
    public class _AdminSidebarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}