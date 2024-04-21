using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TigerTix.Web.Models;


namespace TigerTix.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<Event> events;
        private static List<Event> cart = new List<Event>();

        public HomeController()
        {
            events = new List<Event>
            {
                new Event { Id = 1, Name = "Soccer Game", Date = new DateTime(2024, 5, 3), Price = 30 },
                new Event { Id = 2, Name = "Basketball Game", Date = new DateTime(2024, 4, 10), Price = 20 }
            };
        }

        public IActionResult Homepage()
        {
            return View(events);
        }

        public IActionResult Payment()
        {
            return View();
        }
        
        public IActionResult Confirm()
        {
            return View();
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
            var selectedEvent = events.Find(e => e.Id == eventId);
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

        public IActionResult RemoveFromCart(int eventId) {
            var selectedEvent = events.Find(e => e.Id == eventId);
            if (selectedEvent != null)
            {
                selectedEvent.inCart = false;
                cart.Remove(selectedEvent);
            }
            return RedirectToAction("ViewCart");
        }

    }
}
