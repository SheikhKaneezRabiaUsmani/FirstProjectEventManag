using Microsoft.AspNetCore.Mvc;

namespace EventManagProj.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
