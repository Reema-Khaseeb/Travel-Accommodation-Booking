using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Dtos.Login;
using TravelAccommodationBooking.Dtos.User;
using TravelAccommodationBooking.Services;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.Common.Exceptions.UserExceptions;

namespace TravelAccommodationBooking.API.Controllers
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly IValidator<LoginRequest> _loginValidator;
        private readonly IValidator<UserRequest> _userValidator;
        private readonly IMapper _mapper;

        public AuthenticationController(
            IAuthenticationService authenticationService,
            IUserService userService,
            IValidator<LoginRequest> loginValidator,
            IValidator<UserRequest> userValidator,
            IMapper mapper
            )
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _loginValidator = loginValidator ?? throw new ArgumentNullException(nameof(loginValidator));
            _userValidator = userValidator
                ?? throw new ArgumentNullException(nameof(userValidator));
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
                var loginResponse = new LoginResponse(token);
                return Ok(loginResponse);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (InvalidPasswordException ex)
            {
                return Unauthorized(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An error occurred during login.",
                    ex.Message
                ));
            }
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
                var userRequestWithRole = userRequest with { Role = UserRole.User };
                var registeredUser = await _userService.RegisterUserAsync(userRequestWithRole);
                return Ok(new { Message = "User registered successfully.", User = registeredUser });
            }
            catch (DuplicateUsernameException ex)
            {
                return Conflict(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (DuplicateEmailException ex)
            {
                return Conflict(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An error occurred while registering the user.",
                    ex.Message
                ));
            }
        }

        /// <summary>
        /// Register a new admin user.
        /// </summary>
        /// <param name="userRequest">User registration data.</param>
        /// <returns>A response indicating the result of the user registration process.</returns>
        [HttpPost("register-admin")]
        [SwaggerResponse(StatusCodes.Status200OK, "User registered successfully.", typeof(UserResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid request data", typeof(IEnumerable<string>))]
        [SwaggerResponse(StatusCodes.Status409Conflict, "Username or email already exists", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error occurred", typeof(ErrorResponse))]
        public async Task<IActionResult> RegisterAdmin([FromBody] UserRequest userRequest)
        {
            var validationResult = _userValidator.Validate(userRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var userRequestWithRole = userRequest with { Role = UserRole.Admin };
                var registeredUser = await _userService.RegisterUserAsync(userRequestWithRole);
                return Ok(new { Message = "Admin user registered successfully.", User = registeredUser });
            }
            catch (DuplicateUsernameException ex)
            {
                return Conflict(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (DuplicateEmailException ex)
            {
                return Conflict(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An error occurred while registering the admin user.",
                    ex.Message
                ));
            }
        }

    }
}
