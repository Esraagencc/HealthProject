using AutoMapper;
using Health.BLL.Abstract;
using Health.BLL.DTOs.DoctorDTO;
using HealthProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
