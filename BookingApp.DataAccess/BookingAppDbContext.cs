using BookingApp.ApplicationLogic.DataModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.DataAccess
{
    public class BookingAppDbContext : IdentityDbContext<IdentityUser>
    {
        public BookingAppDbContext(DbContextOptions<BookingAppDbContext> options) : base(options)
        {
        }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Barbershop> Barbershops { get; set; }
        public DbSet<BarbershopReservation> BarbershopReservations { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaReservation> CinemaReservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReservation> RestaurantReservations { get; set; }
        public DbSet<Contact> ContactMessages { get; set; }
        public IEnumerable<object> Contact { get; internal set; }
    }
}
