using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
    bool ValidateToken(string token);
}