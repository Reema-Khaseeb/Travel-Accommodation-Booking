using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces
{
    public interface IBookingService
    {
        Task CancelReservationAsync(int bookingId);
        Task ConfirmBookingAsync(int bookingId);
        Task<Booking> CreatePendingBookingAsync(Booking booking);
        Task<Booking> GetBookingByIdAsync(int bookingId);



        //Task CheckOutBookingAsync(int bookingId);

        //Task<BookingConfirmation> CreateBookingAsync(BookingDto bookingDto);
        //Task<IEnumerable<DateTime>> GetCheckInDateCalendarAsync(); //TODO
        //Task<IEnumerable<DateTime>> GetCheckOutDateCalendarAsync(); //TODO
    }
}
