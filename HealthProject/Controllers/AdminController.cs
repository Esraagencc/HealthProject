using Health.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HealthProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMailBoxService _mailBoxService;
        private readonly IDoctorService _doctorService;

        public AdminController(IMailBoxService mailBoxService, IDoctorService doctorService)
        {
            _mailBoxService = mailBoxService;
            _doctorService = doctorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MailBox()
        {

            return View(_mailBoxService.GetMailBoxes());
        }
       
    }
}
