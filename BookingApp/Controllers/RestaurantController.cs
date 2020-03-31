using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookingApp.Models;
using BookingApp.Services;

namespace BookingApp.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly DataContext _context;

        public RestaurantController(DataContext context)
        {
            _context = context;
        }

        // GET: Restaurant
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: Restaurant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.restaurantId == id);
            if (restaurantModel == null)
            {
                return NotFound();
            }

            return View(restaurantModel);
        }

        // GET: Restaurant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("restaurantId,ImgPath,Name")] RestaurantModel restaurantModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurantModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.Restaurants.FindAsync(id);
            if (restaurantModel == null)
            {
                return NotFound();
            }
            return View(restaurantModel);
        }

        // POST: Restaurant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("restaurantId,ImgPath,Name")] RestaurantModel restaurantModel)
        {
            if (id != restaurantModel.restaurantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurantModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantModelExists(restaurantModel.restaurantId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.restaurantId == id);
            if (restaurantModel == null)
            {
                return NotFound();
            }

            return View(restaurantModel);
        }

        // POST: Restaurant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurantModel = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(restaurantModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantModelExists(int id)
        {
            return _context.Restaurants.Any(e => e.restaurantId == id);
        }
    }
}
