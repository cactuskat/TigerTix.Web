using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Homepage()
        {
            //currently hardcoded
            var events = new List<EventModel>(
                new EventModel { Name = "Event 1", Date = DateTime.Now.AddDays(1), Description = "Description 1" },
        new EventModel { Name = "Event 2", Date = DateTime.Now.AddDays(2), Description = "Description 2" },
        new EventModel { Name = "Event 3", Date = DateTime.Now.AddDays(3), Description = "Description 3" }
            );
            return View(events);
        }
    }
}
