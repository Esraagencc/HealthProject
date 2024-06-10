using AutoMapper;
using Health.BLL.Abstract;
using Health.BLL.DTOs.DoctorDTO;
using HealthProject.Entity;
using HealthProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailBoxService _mailBoxService;

        public HomeController(IMailBoxService mailBoxService)
        {
            _mailBoxService = mailBoxService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Doctors()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactFormPost(SendMailModel sendMailModel)
        {
            _mailBoxService.AddMailBox(sendMailModel);

            return RedirectToAction("Contact", "Home");
        }
    }
}
