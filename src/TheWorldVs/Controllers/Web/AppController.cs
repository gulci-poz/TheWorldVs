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
            // walidacja modelu po stronie serwera
            if (ModelState.IsValid)
            {
                // dost�p do danych z config.json
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                // dodatkowo po stronie klienta, sprawdzenie warto�ci z konfiguracji
                if(string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email, configuration problem.");
                }

                if(_mailService.SendMail(email,
                    email,
                    $"Contact Page from {model.Name} ({model.Email})",
                    model.Message))
                {
                    // czy�cimy nie tylko stan walidacji, ale r�wnie� model (formularz)
                    ModelState.Clear();

                    ViewBag.Message = "Mail sent. Thanks!";
                }

            }
            return View();
        }
    }
}
