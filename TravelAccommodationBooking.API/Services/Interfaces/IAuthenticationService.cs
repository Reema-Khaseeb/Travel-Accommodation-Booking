using TravelAccommodationBooking.API.Dtos.Login;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> LoginAsync(LoginRequest loginRequest);
    }
}