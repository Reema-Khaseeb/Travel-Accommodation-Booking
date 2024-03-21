using AutoMapper;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace TravelAccommodationBooking.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly ILogger<BookingService> _logger;
        private readonly IMapper _mapper;
        //private readonly IPaymentService _paymentService;
        private readonly IRoomService _roomService;
        private readonly IEmailService _emailService;
        private readonly IUserService _userService;

        public BookingService(
            IBookingRepository bookingrepository,
            ILogger<BookingService> logger,
            IMapper mapper,
            //IPaymentService paymentService,
            IRoomService roomService,
            IEmailService emailService,
            IUserService userService
            )
        {
            _bookingRepository = bookingrepository;
            _logger = logger;
            _mapper = mapper;
            //_paymentService = paymentService;
            _roomService = roomService;
            _emailService = emailService;
            _userService = userService;
        }

        public async Task<Booking> CreatePendingBookingAsync(Booking booking)
        {
            //using var transaction = await _bookingRepository.BeginTransactionAsync();

            try
            {
                if (!await _bookingRepository.IsRoomAvailableAsync(booking))
                {
                    throw new InvalidOperationException("The room is not available for the selected dates.");
                }

                booking.CreatedAt = DateTime.UtcNow;
                booking.Status = BookingStatus.Pending;

                var room = await _roomService.GetRoomByIdAsync(booking.RoomId);
                booking.TotalPrice = room.Price;

                var createdBooking = await _bookingRepository.CreateBookingAsync(booking);

                //await _bookingRepository.CommitTransactionAsync();

                return createdBooking;
            }
            catch
            {
                //await _bookingRepository.RollbackTransactionAsync();
                throw;
            }
        }

        //public async Task<Booking> CreatePendingBookingAsync(Booking booking)
        //{
        //    using (var transaction = await _context.Database.BeginTransactionAsync())
        //    {
        //        try
        //        {
        //            await _context.SaveChangesAsync();

        //            // If all operations were successful, commit the transaction
        //            await transaction.CommitAsync();
        //        }
        //        catch
        //        {
        //            // If there is an exception, rollback the transaction
        //            await transaction.RollbackAsync();
        //            throw; // Rethrow the exception to be handled elsewhere
        //        }
        //    }
        //}


        public async Task ConfirmBookingAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
            if (booking == null)
            {
                throw new NotFoundException("Booking not found.");
            }

            //if (!await _roomAvailabilityService.IsRoomAvailableAsync(booking))
            //{
            //    throw new InvalidOperationException("The room is not available for the selected dates.");
            //}
            booking.Status = BookingStatus.Confirmed;
            booking.UpdatedAt = DateTime.UtcNow;
            await _bookingRepository.UpdateBookingAsync(booking);

            var user = booking.User ?? await _userService.GetUserByIdAsync(booking.UserId);
            if (user == null)
            {
                throw new InvalidOperationException("User not found for the booking.");
            }

            var emailSubject = $"Booking Confirmation - Booking ID: {booking.BookingId}";
            var emailBody = $"Hello {user.Username},\n" +
                            $"Your booking is confirmed.\n" +
                            $"Details: Room ID: {booking.RoomId},\n" +
                            $"Check-in: {booking.CheckInDate.ToString("yyyy-MM-dd")}, Check-out: {booking.CheckOutDate.ToString("yyyy-MM-dd")}\n";

            await _emailService.SendEmailAsync(user.Email, emailSubject, emailBody);
        }

        public async Task<Booking> GetBookingByIdAsync(int bookingId)
        {
            try
            {
                var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
                if (booking == null)
                {
                    _logger.LogWarning("Booking with ID {bookingId} not found.", bookingId);
                    throw new NotFoundException($"Booking with ID {bookingId} not found.");
                }


                //var user = booking.User;
                var emailSubject = $"Booking Confirmation - \n";
                var emailBody = $"Hello, your Login for ----- is confirmed. \n" +
                                $"Details: Room, \n" +
                                $"Check-in: , Check-out: \n";

                await _emailService.SendEmailAsync("hello.world.hw987@gmail.com", emailSubject, emailBody);

                return booking;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting booking by ID.");
                throw;
            }
        }

        public async Task CancelReservationAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
            if (booking != null)
            {
                //await _roomAvailabilityService.UpdateRoomAvailabilityAsync(booking, true);
                await _bookingRepository.DeleteBookingAsync(booking);
            }
        }



        //public async Task<BookingConfirmation> CreateBookingAsync(BookingDto bookingDto)
        //{
        //    // Process payment
        //    _paymentService.ProcessPayment(bookingDto.PaymentDetails);

        //    var booking = _mapper.Map<Booking>(bookingDto);

        //    // Save booking to database
        //    await _bookingRepository.CreateBookingAsync(booking);

        //    // Generate confirmation details
        //    var confirmation = GenerateBookingConfirmation(booking);

        //    // Send confirmation email
        //    await _emailService.SendConfirmationEmailAsync(booking.UserEmail, confirmation);

        //    return confirmation;
        //}



        //public async Task CheckOutBookingAsync(int bookingId)
        //{
        //    var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
        //    if (booking == null)
        //    {
        //        throw new InvalidOperationException("Booking not found.");
        //    }

        //    //// Subtract current date frmo booking.CheckOutDate, if > 0 ==> adjust room availabilty for the days left to be available
        //    //await _roomAvailabilityService.UpdateRoomAvailabilityAsync(booking, true);
        //    await _bookingRepository.UpdateBookingAsync(booking);
        //}
    }
}
