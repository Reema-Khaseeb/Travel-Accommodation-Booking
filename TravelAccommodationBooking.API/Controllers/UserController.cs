using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Dtos.User;
using TravelAccommodationBooking.Services;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(
            IUserService userService,
            IMapper mapper
            )
        {
            _userService = userService;
            _mapper = mapper;
        }

        //[HttpGet("{userId}/recent-visited-hotels")]
        //public async Task<ActionResult<IEnumerable<HotelResponse>>> GetRecentBookings(int userId)
        //{
        //    var hotels = await _userService.GetRecentHotelBookingsAsync(userId);
        //    return Ok(hotels);
        //}




        // TODO: might delete it. no need
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(userId);

                if (user == null)
                {
                    return NotFound(new { Message = $"User with ID {userId} not found." });
                }

                var userResponse = _mapper.Map<UserResponse>(user);
                return Ok(userResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An error occurred while fetching the user.",
                    ex.Message));
            }
        }
    }
}
