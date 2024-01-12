using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.API.Models.Error;
using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.API.Services;

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
            )
        {
            _userService = userService;
            _mapper = mapper;
        }
    }
}
