using AutoMapper;
using TravelAccommodationBooking.Dtos.User;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.Common.Exceptions.UserExceptions;
using TravelAccommodationBooking.Common.UserExceptions.Exceptions;
using Microsoft.Extensions.Logging;

namespace TravelAccommodationBooking.Services;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthenticationService _authService;
    private readonly IPasswordHasher _passwordHasher;
    private readonly ILogger<UserService> _logger;
    private readonly IMapper _mapper;

    public UserService(
        IUserRepository userRepository,
        IPasswordHasher passwordHasher,
        ILogger<UserService> logger,
        IMapper mapper
        )
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher
            ?? throw new ArgumentNullException(nameof(passwordHasher));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mapper = mapper;
    }

    public async Task<UserResponse> RegisterUserAsync(UserRequest userRequest)
    {
        var user = _mapper.Map<User>(userRequest);
        try
        {
            if (user == null)
            {
                _logger.LogError("User is null.");
                ArgumentNullException.ThrowIfNull(user);
            }

            if (!await IsUsernameUniqueAsync(user.Username))
            {
                _logger.LogError("Username {Username} already exists.", user.Username);
                throw new DuplicateUsernameException(user.Username);
            }

            if (!await IsEmailUniqueAsync(user.Email))
            {
                _logger.LogError("Email {Email} already exists.", user.Email);
                throw new DuplicateEmailException(user.Email);
            }

            user.Password = _passwordHasher.HashPassword(user.Password);
            var registeredUser = await _userRepository.CreateUserAsync(user);

            _logger.LogInformation("User {Username} registered successfully.", user.Username);

            return _mapper.Map<UserResponse>(registeredUser);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error registering user.");
            throw;
        }
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        try
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                _logger.LogWarning("User with ID {UserId} not found.", userId);
                throw new NotFoundException($"User with ID {userId} not found.");
            }

            return user;
        }

        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting user by ID.");
            throw;
        }
    }

    public async Task<User> GetUserByUsernameAsync(string username)
    {
        try
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);

            if (user == null)
            {
                _logger.LogWarning("User '{Username}' not found.", username);
                throw new NotFoundException($"User '{username}' not found.");
            }

            return user;
        }

        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting user by Username.");
            throw;
        }
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        try
        {
            var user = await _userRepository.GetUserByEmailAsync(email);

            if (user == null)
            {
                _logger.LogWarning("User with Email {Email} not found.", email);
                throw new NotFoundException($"User with Email: '{email}' not found.");
            }

            return user;
        }

        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting user by Email.");
            throw;
        }
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        try
        {
            return await _userRepository.GetUsersAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting users.");
            throw;
        }
    }

    public async Task<bool> IsEmailUniqueAsync(string email)
    {
        return await _userRepository.IsEmailUniqueAsync(email);
    }

    public async Task<bool> IsUsernameUniqueAsync(string username)
    {
        return await _userRepository.IsUsernameUniqueAsync(username);
    }

    public async Task<string> GetUsernameByUserIdAsync(int userId)
    {
        _logger.LogInformation("Retrieving username for user ID {UserId}", userId);

        var username = await _userRepository.GetUsernameByUserIdAsync(userId);

        if (username == null)
        {
            _logger.LogWarning("User with ID {UserId} not found.", userId);
            throw new NotFoundException("User not found.");
        }

        _logger.LogInformation("Successfully retrieved username for user ID {UserId}", userId);
        return username;
    }

    public async Task<string> GetUserEmailByUserIdAsync(int userId)
    {
        _logger.LogInformation("Retrieving email for user ID {UserId}", userId);

        var email = await _userRepository.GetUserEmailByUserIdAsync(userId);

        if (email == null)
        {
            _logger.LogWarning("User with ID {UserId} not found.", userId);
            throw new NotFoundException("User not found.");
        }

        _logger.LogInformation("Successfully retrieved email for user ID {UserId}", userId);
        return email;
    }
}
