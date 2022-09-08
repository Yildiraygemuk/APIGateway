using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDrink()
        {
            List<string> drinks = new() { "Vodka", "Raki", "Beer", "Coke", "Tea", "Tequila" };
            Random rand = new Random();
            var drink = drinks[rand.Next(drinks.Count)];
            return Ok("Hello, today's drink is " + drink);
        }
    }
}
