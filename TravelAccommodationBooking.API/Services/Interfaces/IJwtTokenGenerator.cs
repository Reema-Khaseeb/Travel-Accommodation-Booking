using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
        bool ValidateToken(string token);
    }
}