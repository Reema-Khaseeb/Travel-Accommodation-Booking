using AutoMapper;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.Services.Interfaces;
using Microsoft.Extensions.Logging;
using TravelAccommodationBooking.Dtos.Booking;

namespace TravelAccommodationBooking.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IHotelService _hotelService;
        private readonly IRoomService _roomService;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly IPdfService _pdfService;
        private readonly ILogger<BookingService> _logger;
        private readonly IMapper _mapper;

        public BookingService(
            IBookingRepository bookingrepository,
            IHotelService hotelService,
            IRoomService roomService,
            IUserService userService,
            IEmailService emailService,
            IPdfService pdfService,
            ILogger<BookingService> logger,
            IMapper mapper
            )
        {
            _bookingRepository = bookingrepository;
            _hotelService = hotelService;
            _roomService = roomService;
            _userService = userService;
            _emailService = emailService;
            _pdfService = pdfService;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Booking> CreatePendingBookingAsync(Booking booking)
        {
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

                return createdBooking;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting booking by ID.");
                throw;
            }
        }

        public async Task ConfirmBookingAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
            if (booking == null)
            {
                throw new NotFoundException("Booking not found.");
            }

            booking.Status = BookingStatus.Confirmed;
            booking.UpdatedAt = DateTime.UtcNow;
            await _bookingRepository.UpdateBookingAsync(booking);

            var username = await _userService.GetUsernameByUserIdAsync(booking.UserId);
            var email = await _userService.GetUserEmailByUserIdAsync(booking.UserId);

            var emailSubject = $"Booking Confirmation - Booking ID: {booking.BookingId}";
            var emailBody = $"Hello {username},\n" +
                            $"Your booking is confirmed.\n" +
                            $"Details: Room ID: {booking.RoomId},\n" +
                            $"Check-in: {booking.CheckInDate.ToString("yyyy-MM-dd")}, Check-out: {booking.CheckOutDate.ToString("yyyy-MM-dd")}\n";

            await _emailService.SendEmailAsync(email, emailSubject, emailBody);
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

                return booking;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting booking by ID.");
                throw;
            }
        }

        public async Task<double> GetBookingPriceByBookingId(int bookingId)
        {
            try
            {
                var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
                if (booking == null)
                {
                    _logger.LogWarning("Booking with ID {BookingId} not found.", bookingId);
                    throw new NotFoundException($"Booking with ID {bookingId} not found.");
                }
                return booking.TotalPrice;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the booking price for booking ID {BookingId}.", bookingId);
                throw new ApplicationException("An error occurred while retrieving the booking price. Please try again later.", ex);
            }
        }

        public async Task CancelReservationAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingByIdAsync(bookingId);
            if (booking != null)
            {
                await _bookingRepository.DeleteBookingAsync(booking);
            }
        }
        
        public async Task<byte[]> GenerateBookingConfirmationPdfAsync(int bookingId)
        {
            var bookingDetails = await GetBookingDetailsAsync(bookingId);
            var htmlContent = GenerateBookingConfirmationHtml(bookingDetails);
            return await _pdfService.GeneratePdf(htmlContent);
        }

        private async Task<BookingDetails> GetBookingDetailsAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetBookingDetailsByIdAsync(bookingId)
                ?? throw new NotFoundException("Booking not found");

            return new BookingDetails(
                booking.BookingId,
                booking.Room.Hotel.Address,
                booking.Room.Number,
                booking.Room.RoomType,
                booking.Room.Description,
                booking.CheckInDate,
                booking.CheckOutDate,
                booking.TotalPrice);
        }

        private string GenerateBookingConfirmationHtml(BookingDetails bookingDetails)
        {
            return $@"
            <html>
            <head>
                <title>Booking Confirmation</title>
            </head>
            <body>
                <h1>Booking Confirmation</h1>
                <p>Confirmation Number: {bookingDetails.BookingId}</p>
                <p>Hotel Address: {bookingDetails.HotelAddress}</p>
                <p>Room Number: {bookingDetails.RoomNumber}</p>
                <p>Room Type: {bookingDetails.RoomType}</p>
                <p>Room Description: {bookingDetails.Description}</p>
                <p>Check-in Date: {bookingDetails.CheckInDate:yyyy-MM-dd}</p>
                <p>Check-out Date: {bookingDetails.CheckOutDate:yyyy-MM-dd}</p>
                <p>Total Price: ${bookingDetails.TotalPrice}</p>
            </body>
            </html>";
        }
    }
}
