using TravelAccommodationBooking.Db.Utilities.Enums;

namespace TravelAccommodationBooking.API.Dtos.User
{
    public record UserRequest(
        string Username,
        string Password,
        UserRole Role,
        string Email);
}
