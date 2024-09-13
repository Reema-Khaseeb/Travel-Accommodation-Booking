using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly TravelAccommodationBookingDbContext _context;
        private IDbContextTransaction _currentTransaction;

        public BookingRepository(TravelAccommodationBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            return await _context.Bookings.FindAsync(bookingId);
        }

        public async Task<Booking> GetBookingDetailsByIdAsync(int bookingId)
        {
            return await _context.Bookings
                .Include(b => b.Room)
                .ThenInclude(r => r.Hotel)
                .FirstOrDefaultAsync(b => b.BookingId == bookingId);
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(Booking booking)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsRoomAvailableAsync(Booking booking)
        {
            // Check for any bookings that overlap with the requested dates for the specified room
            return !await _context.Bookings.AnyAsync(b =>
                b.RoomId == booking.RoomId
                && b.CheckInDate < booking.CheckOutDate
                && b.CheckOutDate > booking.CheckInDate);
        }
    }

}
