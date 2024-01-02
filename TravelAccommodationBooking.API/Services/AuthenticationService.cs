using TravelAccommodationBooking.API.Exceptions;
using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.API.Utilities;

namespace TravelAccommodationBooking.API.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ILogger<AuthenticationService> _logger;
        private readonly IJwtTokenGenerator _tokenGenerator;

        public AuthenticationService(
            IUserService userService,
            IPasswordHasher passwordHasher,
            JwtTokenGenerator tokenGenerator,
            ILogger<AuthenticationService> logger
            )
        {
            _userService = userService;
            _passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
            _tokenGenerator = tokenGenerator ?? throw new ArgumentNullException(nameof(tokenGenerator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<string> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userService.GetUserByUsernameAsync(loginRequest.Username);
            VerifyUserPassword(loginRequest, user);
            return _tokenGenerator.GenerateToken(user);
        }

        private void VerifyUserPassword(LoginRequest login, UserResponse userResponse)
        {
            if (!_passwordHasher.VerifyPassword(login.Password, userResponse.Password))
            {
                _logger.LogWarning("Authentication failed: Invalid password for user {Username}.", login.Username);
                throw new InvalidPasswordException("Invalid password.");
            }

            _logger.LogInformation("User {Username} authenticated successfully.", login.Username);
        }
    }
}
