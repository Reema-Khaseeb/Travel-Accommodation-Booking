using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.API.Dtos.User;
using TravelAccommodationBooking.API.Dtos.Error;
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
            IMapper mapper
            )
        {
            _userService = userService;
            _mapper = mapper;
        }
    }
}
