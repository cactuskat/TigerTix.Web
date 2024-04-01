using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IndexViewModel model) {

            return RedirectToAction("Homepage","Home");
        }

        public IActionResult Signup() {
            return View("SignUp");
        }

        public IActionResult CustomerSupport()
        {
            return View("CustomerSupport");
        }

    }
}
