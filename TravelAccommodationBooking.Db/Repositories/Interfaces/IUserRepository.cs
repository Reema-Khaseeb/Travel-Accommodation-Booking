using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByIdAsync(int userId);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> IsEmailUniqueAsync(string email);
        Task<bool> IsUsernameUniqueAsync(string username);
        Task<User> GetUserByEmailAsync(string email);
    }
}