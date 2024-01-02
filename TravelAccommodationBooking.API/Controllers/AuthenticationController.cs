using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.API.Exceptions;
using TravelAccommodationBooking.API.Models.Error;
using TravelAccommodationBooking.API.Models.Login;
using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.Db.Utilities.Exceptions;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IValidator<LoginRequest> _loginValidator;
        private readonly IMapper _mapper;

        public AuthenticationController(
            IAuthenticationService authenticationService,
            IValidator<LoginRequest> loginValidator,
            IMapper mapper
            )
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _loginValidator = loginValidator ?? throw new ArgumentNullException(nameof(loginValidator)); 
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Authenticate user and generate JWT token.
        /// </summary>
        /// <param name="loginRequest">User login credentials.</param>
        /// <returns>A JWT token if authentication is successful.</returns>
        /// <remarks>This method authenticates the user and provides a JWT token for authorized access.</remarks>
        [HttpPost("login")]
        [SwaggerResponse(StatusCodes.Status200OK, "Login successful", typeof(LoginResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Validation error", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "User not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Invalid password", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var validationResult = _loginValidator.Validate(loginRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var token = await _authenticationService.LoginAsync(loginRequest);
                var loginResponse = new LoginResponse { Token = token };
                return Ok(loginResponse);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse { Message = ex.Message });
            }
            catch (InvalidPasswordException ex)
            {
                return Unauthorized(new ErrorResponse { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse
                {
                    Message = "An error occurred during login.",
                    Error = ex.Message
                });
            }
        }
    }
}
