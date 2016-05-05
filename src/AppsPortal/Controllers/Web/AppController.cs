using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Linq;
using AppsPortal.Models;
using AppsPortal.Services;
using AppsPortal.ViewModels;

namespace AppsPortal.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        private IAppsRepository _appsRepository;

        public AppController(IMailService service, IAppsRepository appsRepository)
        {
            _mailService = service;
            _appsRepository = appsRepository;
        }

        public IActionResult Index()
        {
            var apps = _appsRepository.GetAllApplication();
            return View(apps);
        }

        [Authorize]
        public IActionResult Trips()
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
            if(ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if(string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email, configuration problem");
                }

                if(_mailService.SendMail(email,
                    email,
                    $"Contact Page from {model.Name} ({model.Email})",
                    model.Message))
                {
                    ModelState.Clear();

                    ViewBag.Message = "Mail Sent";
                }
            }
            return View();
        }

        public IActionResult Download()
        {

            return View();
        }
    }
}
