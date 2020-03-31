using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.DataAccess
{
    public interface IRestaurantDataAccess
    {
        Task<RestaurantModel> Add(string restaurantName);
    }
}
