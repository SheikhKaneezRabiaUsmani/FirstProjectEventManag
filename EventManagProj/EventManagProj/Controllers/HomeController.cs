using EventManagProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Event.DOM;
using Event.DAL;

namespace EventManagProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Registration model)
        {
            {
                if (ModelState.IsValid) ;
                RegistrationDAL registrationDAL = new RegistrationDAL();
                registrationDAL.InsertUserData(model);
                return RedirectToAction("Index","Home");
                    //code
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult VenueController()
        {
            return View();
        }

    }
}