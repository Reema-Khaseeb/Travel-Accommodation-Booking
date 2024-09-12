using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Dtos.Booking;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Controllers
{

    [ApiController]
    [Route("bookings")]
    [Authorize]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        private readonly IValidator<BookingRequest> _bookingValidator;

        public BookingController(IBookingService bookingService, IMapper mapper, IValidator<BookingRequest> bookingValidator)
        {
            _bookingService = bookingService;
            _mapper = mapper;
            _bookingValidator = bookingValidator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] BookingRequest bookingRequest)
        {
            var validationResult = _bookingValidator.Validate(bookingRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var booking = _mapper.Map<Booking>(bookingRequest);
                var createdBooking = await _bookingService.CreatePendingBookingAsync(booking);

                var createdBookingDto = _mapper.Map<BookingRequest>(createdBooking);
                return CreatedAtAction(nameof(GetBooking), new
                {
                    bookingId = createdBooking.BookingId
                }, createdBookingDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the booking. {ex.Message}");
            }
        }

        [HttpGet("{bookingId}")]
        public async Task<IActionResult> GetBooking(int bookingId)
        {
            try
            {
                var booking = await _bookingService.GetBookingByIdAsync(bookingId);
                var bookingResponse = _mapper.Map<BookingResponse>(booking);
                return booking == null ? NotFound("Booking not found") : Ok(bookingResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching the booking.");
            }
        }
    }
}
