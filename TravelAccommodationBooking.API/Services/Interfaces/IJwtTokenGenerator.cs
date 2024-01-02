using TravelAccommodationBooking.API.Models.User;

namespace TravelAccommodationBooking.API.Utilities
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(UserResponse user);
        bool ValidateToken(string token);
    }
}