using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services
{
    public interface IUserService
    {
        Task<UserResponse> RegisterUserAsync(UserRequest userRequest);
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> IsEmailUniqueAsync(string email);
        Task<bool> IsUsernameUniqueAsync(string username);
    }
}
