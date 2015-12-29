using Microsoft.AspNet.Mvc;
using System;
using TheWorldVs.Services;
using TheWorldVs.ViewModels;

namespace TheWorldVs.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService service)
        {
            _mailService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            _mailService.SendMail("",
                "",
                $"Contact Page from {model.Name} ({model.Email})",
                model.Message);
            return View();
        }
    }
}
