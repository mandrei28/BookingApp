using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookingApp.ApplicationLogic.DataModel;
using Microsoft.AspNetCore.Identity;

namespace BookingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserManager<User> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Restaurant()
        {
            return View();
        }
        public IActionResult Cinema()
        {
            return View();
        }
        public IActionResult Barbershop()
        {
            return View();
        }
        public IActionResult RestaurantReservation()
        {
            return View(new RestaurantReservation());
        }
        public async Task<FileContentResult> Photo()
        {
            var user = await userManager.GetUserAsync(User);
            if (user.ImageData != null)
                return new FileContentResult(user.ImageData, "image/jpeg");
            else
                return new FileContentResult(new byte[0], "image/jpeg");
        }
    }
}
