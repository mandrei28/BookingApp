using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.DataModel
{
    public class Administrator
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
        public ICollection<Cinema> Cinemas { get; set; }
        public ICollection<Barbershop> Barbershops { get; set; }
    }
}
