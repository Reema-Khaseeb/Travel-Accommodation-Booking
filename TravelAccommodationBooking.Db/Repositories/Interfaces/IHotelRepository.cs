using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IHotelRepository
    {
        Task<Hotel> CreateHotelAsync(Hotel hotel);
        Task UpdateHotelAsync(Hotel hotel);
        Task DeleteHotelAsync(Hotel hotel);
        Task<Hotel> GetHotelByIdAsync(int hotelId);
        Task<IEnumerable<Hotel>> GetHotelsAsync();
    }
}