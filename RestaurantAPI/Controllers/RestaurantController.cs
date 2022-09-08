using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFood()
        {
            List<string> drinks = new() { "Pizza", "Hamburger", "Pasta", "Meat", "Chicken", "Salad" };
            Random rand = new Random();
            var drink = drinks[rand.Next(drinks.Count)];
            return Ok("Hello, today's food is " + drink);
        }
    }
}
