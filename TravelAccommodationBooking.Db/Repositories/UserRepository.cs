using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TravelAccommodationBookingDbContext _dbContext;

        public UserRepository(TravelAccommodationBookingDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _dbContext.Users
                    .SingleOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _dbContext.Users
                    .SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return !await _dbContext.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> IsUsernameUniqueAsync(string username)
        {
            return !await _dbContext.Users.AnyAsync(u => u.Username == username);
        }

        public async Task<string> GetUsernameByUserIdAsync(int userId)
        {
            return await _dbContext.Users
                .Where(u => u.UserId == userId)
                .Select(u => u.Username)
                .FirstOrDefaultAsync();
        }

        public async Task<string> GetUserEmailByUserIdAsync(int userId)
        {
            return await _dbContext.Users
                .Where(u => u.UserId == userId)
                .Select(u => u.Email)
                .SingleOrDefaultAsync();
        }
    }
}
