using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index() // Return Values are placeholders; this is unfinished
        {
            return View();
        }

        [HttpGet("/Events")]
        public IActionResult GetEvents()
        {
            return View();
        }

        [HttpPost("/Events/:EventId/tags")]
        public IActionResult RetrieveTags()
        {
            return View();
        }

        [HttpPost("/Events")]
        public IActionResult PostEvent()
        {
            return View();
        }
    }
}
