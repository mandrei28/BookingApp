using BookingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.Models;

namespace BookingApp.DataAccess
{
    public class RestaurantDataAccess : IRestaurantDataAccess
    {
        private DataContext _context;

        public RestaurantDataAccess(DataContext context)
        {
            this._context = context;
        }

        public async Task<RestaurantModel> Add(string restaurantName)
        {
            var restaurantModel = new RestaurantModel() { Name = restaurantName, ImgPath = "s" };
            await _context.Restaurants.AddAsync(restaurantModel);
            await _context.SaveChangesAsync();

            return restaurantModel;
        }
    }
}
