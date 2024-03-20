using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IHotelLocationService
{
    Task<HotelLocation> GetLocationByIdAsync(int locationId);
}