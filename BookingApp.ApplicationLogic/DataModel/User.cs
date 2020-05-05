using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.DataModel
{
    public class User : IdentityUser
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public byte[] ImageData { get; set; }
        public ICollection<RestaurantReservation> RestaurantReservations { get; set; }
        public ICollection<CinemaReservation> CinemaReservations { get; set; }
        public ICollection<BarbershopReservation> BarbershopReservations { get; set; }
    }
}
