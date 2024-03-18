using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface IHotelLocationService
    {
        Task<HotelLocation> GetLocationByIdAsync(int locationId);
    }
}