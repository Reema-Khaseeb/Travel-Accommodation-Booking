using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.User
{
    public record UserRequest(
        string Username,
        string Password,
        UserRole Role,
        string Email);
}
