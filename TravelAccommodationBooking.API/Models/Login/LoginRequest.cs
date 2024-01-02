namespace TravelAccommodationBooking.API.Models.User
{
    public record LoginRequest(
        string Username,
        string Password
        );
}
