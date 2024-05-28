using AutoMapper;
using Health.BLL.Abstract;
using Health.BLL.DTOs.DoctorDTO;
using HealthProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthProject.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Doctor()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
