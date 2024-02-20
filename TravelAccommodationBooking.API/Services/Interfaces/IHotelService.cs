using TravelAccommodationBooking.API.Dtos.Hotel;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface IHotelService
    {
        Task<Hotel> CreateHotelAsync(Hotel hotel);
        Task UpdateHotelAsync(int hotelId, HotelUpdateRequest hotelRequest);
        Task DeleteHotelAsync(int hotelId);
        Task<Hotel> GetHotelByIdAsync(int hotelId);
        Task<IEnumerable<Hotel>> GetHotelsAsync();
    }
}