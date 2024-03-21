using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Services.Interfaces;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("Home")]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("featured-deals")]
        public async Task<IActionResult> GetFeaturedDeals()
        {
            var featuredDeals = await _homeService.GetFeaturedDealsAsync();
            return Ok(featuredDeals);
        }
    }
}
