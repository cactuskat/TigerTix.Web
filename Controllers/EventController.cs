using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class EventController : Controller
    {
        public IActionResult EventPage() // Return Values are placeholders; this is unfinished
        {
            return View();
        }

        [HttpGet("/Events")]
        public IActionResult GetEvents(DateTime start,DateTime end)
        {
            return View();
        }

        [HttpGet("/Events/:EventId")]
        public IActionResult GetEventData(EventModel model)
        {
            return View();
        }

        [HttpPut("/Events/:EventId")]
        public IActionResult UpdEventData(EventModel model)
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

        [HttpDelete("/Events/:id")]
        public IActionResult DeleteEvent()
        {
            return View();
        }
    }
}
