using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IHotelLocationRepository
    {
        Task<HotelLocation> GetLocationByIdAsync(int locationId);
    }
}