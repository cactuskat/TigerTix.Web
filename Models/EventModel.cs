﻿namespace TigerTix.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }  

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public bool inCart { get; set; }

    }
}
