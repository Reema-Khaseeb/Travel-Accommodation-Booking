using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Dtos.FeaturedDeal;
using TravelAccommodationBooking.Services.Interfaces;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("api/v1/home")]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IFeaturedDealService _featuredDealService;

        public HomeController(IFeaturedDealService featuredDealService)
        {
            _featuredDealService = featuredDealService;
        }

        [HttpGet("featured-deals")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved featured deals", typeof(FeaturedDealDto))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> GetFeaturedDeals()
        {
            try
            {
                var featuredDealDtos = await _featuredDealService.GetActiveFeaturedDealsAsync();
                return Ok(featuredDealDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred while retrieving featured deals.",
                    ex.Message));
            }
        }
    }
}
