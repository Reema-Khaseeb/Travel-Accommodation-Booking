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

        //public async Task<IEnumerable<Hotel>> GetRecentHotelBookingsByUserAsync(int userId)
        //{
        //    var currentDate = DateTime.Now;
        //    return await _context.Bookings
        //                         .Where(b => b.UserId == userId && b.CheckInDate <= currentDate)
        //                         .OrderByDescending(b => b.CheckInDate)
        //                         .Take(UserConstants.NumberOfRecentlyVisitedHotelsByUser)
        //                         .Select(b => b.Hotel)
        //                         .Distinct() // To avoid duplicate hotels
        //                         .ToListAsync();
        //}

        //public async Task<IEnumerable<City>> GetTopBookedCitiesAsync()
        //{
        //    return await _context.Bookings
        //        .Select(b => b.Hotel.City)
        //        .GroupBy(city => city)
        //        .OrderByDescending(g => g.Count())
        //        .Take(CityConstants.TopBookedCitiesCount)
        //        .Select(g => g.Key) // get City object
        //        .ToListAsync();
        //}

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }


        //public async Task<IDbContextTransaction> BeginTransactionAsync()
        //{
        //    return await _context.Database.BeginTransactionAsync();
        //}

        public async Task CommitTransactionAsync()
        {
            // save all changes made during the transaction
            await _context.SaveChangesAsync();
            await _currentTransaction.CommitAsync();
        }

        //public async Task RollbackTransactionAsync()
        //{
        //    if (_currentTransaction != null)
        //    {
        //        await _currentTransaction.RollbackAsync();
        //    }
        //}


        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
            }

            _currentTransaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.RollbackAsync();
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }
        }


        //public async Task ProcessExpiredReservationsAsync()
        //{
        //    var expiredReservations = _context.Bookings
        //        .Where(r => r.Status == BookingStatus.Pending && DateTime.UtcNow.Subtract(r.CreatedTime).TotalMinutes > 30)
        //        .ToList();

        //    foreach (var reservation in expiredReservations)
        //    {
        //        reservation.Status = "Cancelled";
        //        // delete it
        //        // Optionally, notify the user that their reservation has expired
        //    }

        //    await _context.SaveChangesAsync();
        //}






        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            return await _context.Bookings.FindAsync(bookingId);
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

        public async Task<IEnumerable<Booking>> ListBookingsByUserAsync(int userId)
        {
            return await _context.Bookings
                .Where(b => b.UserId == userId)
                .ToListAsync();
        }

        //public async Task<IEnumerable<Booking>> ListBookingsByHotelAsync(int hotelId)
        //{
        //    return await _context.Bookings
        //        .Where(b => b.HotelId == hotelId)
        //        .ToListAsync();
        //}

        public Task<IEnumerable<DateTime>> GetAvailableCheckInDatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DateTime>> GetAvailableCheckOutDatesAsync()
        {
            throw new NotImplementedException();
        }


        public async Task<bool> IsRoomAvailableAsync(Booking booking)
        {
            // Check for any bookings that overlap with the requested dates for the specified room
            return !await _context.Bookings.AnyAsync(b =>
                b.RoomId == booking.RoomId
                && b.CheckInDate < booking.CheckOutDate
                && b.CheckOutDate > booking.CheckInDate);
        }


        //public async Task CreateBookingAsync(Booking newBooking)
        //{
        //    // Add the new booking to the context
        //    _context.Bookings.Add(newBooking);

        //    // Mark the relevant days as unavailable
        //    var datesToMarkUnavailable = Enumerable.Range(0, (newBooking.CheckOutDate - newBooking.CheckInDate).Days)
        //                                           .Select(offset => newBooking.CheckInDate.AddDays(offset));

        //    foreach (var date in datesToMarkUnavailable)
        //    {
        //        var availability = await _context.RoomAvailabilities
        //                                         .FirstOrDefaultAsync(ra => ra.RoomId == newBooking.RoomId && ra.Date == date);

        //        if (availability != null)
        //        {
        //            availability.IsAvailable = false;
        //        }
        //        else
        //        {
        //            _context.RoomAvailabilities.Add(new RoomAvailability
        //            {
        //                RoomId = newBooking.RoomId,
        //                Date = date,
        //                IsAvailable = false
        //            });
        //        }
        //    }

        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateBookingAsync(Booking existingBooking, DateTime newCheckIn, DateTime newCheckOut)
        //{
        //    // Update the booking dates
        //    var oldCheckIn = existingBooking.CheckInDate;
        //    var oldCheckOut = existingBooking.CheckOutDate;
        //    existingBooking.CheckInDate = newCheckIn;
        //    existingBooking.CheckOutDate = newCheckOut;

        //    // Update the availability for the old date range
        //    var oldDates = Enumerable.Range(0, (oldCheckOut - oldCheckIn).Days)
        //                             .Select(offset => oldCheckIn.AddDays(offset));
        //    foreach (var date in oldDates)
        //    {
        //        var availability = await _context.RoomAvailabilities
        //                                         .FirstOrDefaultAsync(ra => ra.RoomId == existingBooking.RoomId && ra.Date == date);
        //        if (availability != null)
        //        {
        //            availability.IsAvailable = true;
        //        }
        //    }

        //    // Update the availability for the new date range
        //    var newDates = Enumerable.Range(0, (newCheckOut - newCheckIn).Days)
        //                             .Select(offset => newCheckIn.AddDays(offset));
        //    foreach (var date in newDates)
        //    {
        //        var availability = await _context.RoomAvailabilities
        //                                         .FirstOrDefaultAsync(ra => ra.RoomId == existingBooking.RoomId && ra.Date == date);
        //        if (availability != null)
        //        {
        //            availability.IsAvailable = false;
        //        }
        //        else
        //        {
        //            _context.RoomAvailabilities.Add(new RoomAvailability
        //            {
        //                RoomId = existingBooking.RoomId,
        //                Date = date,
        //                IsAvailable = false
        //            });
        //        }
        //    }

        //    await _context.SaveChangesAsync();
        //}

        public async Task CancelBookingAsync(int bookingId)
        {
            // Find the booking in the database
            var booking = await _context.Bookings.FindAsync(bookingId);

            // Handle the case where the booking does not exist
            if (booking == null)
            {
                // You can handle this in various ways depending on your application's needs:
                // - Throw a custom exception
                // - Log the incident
                // - Return a result or message indicating the booking was not found
                throw new InvalidOperationException($"Booking with ID {bookingId} not found.");
            }

            // Remove the booking from the context
            _context.Bookings.Remove(booking);

            // Mark the dates as available
            var datesToMarkAvailable = Enumerable.Range(0, (booking.CheckOutDate - booking.CheckInDate).Days)
                                                 .Select(offset => booking.CheckInDate.AddDays(offset));

            foreach (var date in datesToMarkAvailable)
            {
                //var availability = await _context.RoomAvailabilities
                //                                 .FirstOrDefaultAsync(ra => ra.RoomId == booking.RoomId && ra.Date == date);
                //if (availability != null)
                //{
                //    availability.IsAvailable = true;
                //}
                //else
                //{
                //    // Optionally handle the case where the RoomAvailability record doesn't exist for a date
                //    // This might indicate an inconsistency in your data
                //    // You could log this incident or take corrective action as needed
                //}
            }

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }

}
