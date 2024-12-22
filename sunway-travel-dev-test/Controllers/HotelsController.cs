using Microsoft.AspNetCore.Mvc;
using sunway_travel_dev_test.Services;

namespace sunway_travel_dev_test.Controllers
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
            try
            {
                var hotels = dataLoader.LoadHotels();
                return Ok(hotels);
            }
            catch (Exception ex)
            {
                // Log error (optional)
                return StatusCode(500, new { Message = "An error occurred while retrieving hotel data.", Details = ex.Message });
            }
        }

        // GET /api/hotels/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetHotelById(int id)
        {
            try
            {
                var hotels = dataLoader.LoadHotels();
                var hotel = hotels.FirstOrDefault(h => h.Id == id);

                if (hotel == null)
                {
                    return NotFound(new { Message = $"Hotel with ID {id} not found." });
                }

                return Ok(hotel);
            }
            catch (Exception ex)
            {
                // Log error (optional)
                return StatusCode(500, new { Message = "An error occurred while retrieving hotel data.", Details = ex.Message });
            }
        }
    }
}