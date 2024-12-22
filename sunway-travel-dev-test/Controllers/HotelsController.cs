using System.Text.Json;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : ControllerBase
    {
        readonly DataLoader dataLoader;

        public HotelsController(DataLoader dataLoader)
        {
            this.dataLoader = dataLoader;
        }

        // GET /api/hotels
        [HttpGet]
        public IActionResult GetHotels()
        {
            var hotels = dataLoader.LoadHotels();
            
            Console.WriteLine(JsonSerializer.Serialize( hotels ));
            return Ok(hotels);
        }

        // GET /api/hotels/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetHotelById(int id)
        {
            var hotels = dataLoader.LoadHotels();
            var hotel = hotels.FirstOrDefault(h => h.Id == id);

            if (hotel == null)
            {
                return NotFound(new { Message = $"Hotel with ID {id} not found." });
            }

            return Ok(hotel);
        }
    }
}
