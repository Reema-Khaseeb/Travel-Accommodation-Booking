using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Utilities
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
        bool ValidateToken(string token);
    }
}