using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Homepage()
        {
            return View();
        }
    }
}
