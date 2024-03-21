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


        /*
        [HttpGet("checkInCalender")]
        public async Task<IActionResult> GetCheckInDateCalender()
        {
            var checkInDateCalender = await _bookingService.GetCheckInDateCalenderAsync();
            return Ok(checkInDateCalender);
        }

        [HttpGet("checkOutCalender")]
        public async Task<IActionResult> GetCheckOutDateCalender()
        {
            var checkInDateCalender = await _bookingService.GetCheckOutDateCalenderAsync();
            return Ok(checkInDateCalender);
        }*/




        /*
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            try
            {
                var bookings = await _bookingService.GetAllBookingsAsync();
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while fetching bookings.");
            }
        }        

        [HttpPut("{bookingId}")]
        public async Task<IActionResult> UpdateBooking(int bookingId, [FromBody] BookingDto updatedBookingDto)
        {
            try
            {
                var updatedBookingModel = _mapper.Map<BookingModel>(updatedBookingDto);
                var result = await _bookingService.UpdateBookingAsync(bookingId, updatedBookingModel);

                if (result == null)
                {
                    return NotFound("Booking not found");
                }

                var updatedBookingResponse = _mapper.Map<BookingDto>(result);
                return Ok(updatedBookingResponse);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while updating the booking.");
            }
        }

        [HttpDelete("{bookingId}")]
        public async Task<IActionResult> DeleteBooking(int bookingId)
        {
            try
            {
                var result = await _bookingService.DeleteBookingAsync(bookingId);

                if (!result)
                {
                    return NotFound("Booking not found");
                }

                return Ok("Booking deleted successfully");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while deleting the booking.");
            }
        }

        */
    }
}
