using TravelAccommodationBooking.API.Models.User;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> LoginAsync(LoginRequest loginRequest);
    }
}