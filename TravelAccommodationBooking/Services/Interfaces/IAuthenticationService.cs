using TravelAccommodationBooking.Dtos.Login;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IAuthenticationService
{
    Task<string> LoginAsync(LoginRequest loginRequest);
}