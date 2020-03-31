using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.Models;

namespace BookingApp.Services
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<RestaurantModel> Restaurants { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }
    }
}

