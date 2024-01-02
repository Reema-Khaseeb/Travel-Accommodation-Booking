using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.API.Models.Error;
using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.API.Services;
using TravelAccommodationBooking.Db.Utilities.Exceptions;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IValidator<UserRequest> _userValidator;

        public UserController(IUserService userService, IValidator<UserRequest> userValidator)
        {
            _userService = userService;
            _userValidator = userValidator
                ?? throw new ArgumentNullException(nameof(userValidator));
        }

        /// <summary>
        /// Register a new user.
        /// </summary>
        /// <param name="userRequest">User registration data.</param>
        /// <returns>A response indicating the result of the user registration process.</returns>
        [HttpPost("register")]
        [SwaggerResponse(StatusCodes.Status200OK, "User registered successfully.", typeof(UserResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid request data", typeof(IEnumerable<string>))]
        [SwaggerResponse(StatusCodes.Status409Conflict, "Username or email already exists", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error occurred", typeof(ErrorResponse))]
        public async Task<IActionResult> RegisterUser([FromBody] UserRequest userRequest)
        {
            var validationResult = _userValidator.Validate(userRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var registeredUser = await _userService.RegisterUserAsync(userRequest);
                return Ok(new { Message = "User registered successfully.", User = registeredUser });
            }
            catch (DuplicateUsernameException ex)
            {
                return Conflict(new ErrorResponse { Message = ex.Message });
            }
            catch (DuplicateEmailException ex)
            {
                return Conflict(new ErrorResponse { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Message = "An error occurred while registering the user.",
                    Error = ex.Message
                });
            }
        }
    }
}
