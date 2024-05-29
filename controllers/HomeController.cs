using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the Hotel Booking API");
        }
    }
}
