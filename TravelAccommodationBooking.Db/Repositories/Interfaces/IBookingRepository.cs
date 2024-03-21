using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        //Task<IEnumerable<Hotel>> GetRecentHotelBookingsByUserAsync(int userId);
        //Task<IEnumerable<City>> GetTopBookedCitiesAsync();
        Task<Booking> CreateBookingAsync(Booking booking);        
        Task<Booking> GetBookingByIdAsync(int bookingId);
        Task UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(Booking booking);


        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();

        Task<bool> IsRoomAvailableAsync(Booking booking);


        Task<IEnumerable<Booking>> ListBookingsByUserAsync(int userId);
        //Task<IEnumerable<Booking>> ListBookingsByHotelAsync(int hotelId);
        Task<IEnumerable<DateTime>> GetAvailableCheckInDatesAsync();
        Task<IEnumerable<DateTime>> GetAvailableCheckOutDatesAsync();
    }
}
