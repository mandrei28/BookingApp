using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.DataModel
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<RestaurantReservation> RestaurantReservations { get; set; }
        public ICollection<CinemaReservation> CinemaReservations { get; set; }
        public ICollection<BarbershopReservation> BarbershopReservations { get; set; }
    }
}
