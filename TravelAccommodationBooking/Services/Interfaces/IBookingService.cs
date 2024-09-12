using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces;

public interface IBookingService
{
    Task ConfirmBookingAsync(int bookingId);
    Task<Booking> CreatePendingBookingAsync(Booking booking);
    Task<Booking> GetBookingByIdAsync(int bookingId);
    Task<double> GetBookingPriceByBookingId(int bookingId);
    Task CancelReservationAsync(int bookingId);
}
