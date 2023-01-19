using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly RestaurantDbContext _context;


        public RestaurantsController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET: api/Restaurants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurants>>> GetAll()
        {
            var rest_cuisine = await _context.Cuisines.FromSqlRaw("EXECUTE dbo.get_restaurant_info").ToListAsync();
            var value = await _context.Restaurants.FromSqlRaw("EXECUTE dbo.get_restaurant_info").ToListAsync();
            int length = value.Count();
            for (int i = 0; i < length; i++)
            {
                value[i].Cuisine.Add(rest_cuisine[i]);
            }
            var return_value = value.Distinct().ToList();
            return return_value;
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurants>> GetRestaurant(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return restaurant;
        }

        // PUT: api/Restaurants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurants restaurant)
        {
            if (id != restaurant.id)
            {
                return BadRequest();
            }

            _context.Entry(restaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Restaurants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Restaurants>> PostRestaurant(Restaurants restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestaurant", new { id = restaurant.id }, restaurant);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(e => e.id == id);
        }
    }
}
