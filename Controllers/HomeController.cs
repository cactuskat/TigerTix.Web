using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TigerTix.Web.Models;


namespace TigerTix.Web.Controllers
{
    public class HomeController : Controller
    {
        private static List<Event> events = new List<Event>();
        private static List<Event> cart = new List<Event>();
        public IActionResult Homepage()
        {
            events.Add(new Event { Id = 1,Name = "Soccer Game", Date = new DateTime(2024, 5, 3), Price = 30 });
            events.Add(new Event { Id = 2,Name = "Basketball Game", Date = new DateTime(2024, 4, 10), Price = 20 });
            /*
            var events = new List<Event>
            {
            new Event { Name = "Soccer Game", Date = new DateTime(2024, 5, 3), Price = 30 },
            new Event { Name = "Basketball Game", Date = new DateTime(2024, 4, 10), Price = 20 }
            };
            */
            return View(events);
        }

        public IActionResult EventDetails(string eventName)
        {
            // Fetch event details based on eventName
            // For simplicity, I'll just return a view with the event name
            return View((object)eventName);
        }

        public IActionResult AddToCart(int eventId)
        {
            // Add the event to the cart (you can implement this logic)
            var selectedEvent = events.FirstOrDefault(e => e.Id == eventId);
            if (selectedEvent != null && !selectedEvent.inCart)
            {
                selectedEvent.inCart = true;
                cart.Add(selectedEvent);
            }
            return RedirectToAction("Homepage");
        }

        public IActionResult ViewCart() {
            return View(cart);
        }

    }
}
