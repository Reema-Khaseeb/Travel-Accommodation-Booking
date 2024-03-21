using FluentValidation;
using TravelAccommodationBooking.Dtos.Booking;

namespace TravelAccommodationBooking.API.Utilities.Validators
{
    public class BookingValidator : AbstractValidator<BookingRequest>
    {
        public BookingValidator()
        {
            RuleFor(booking => booking.CheckInDate)
                .NotEmpty().WithMessage("Check-In date is required.")
                .GreaterThanOrEqualTo(DateTime.UtcNow).WithMessage("Check-In date must be in the future.");

            RuleFor(booking => booking.CheckOutDate)
                .NotEmpty().WithMessage("Check-Out date is required.")
                .GreaterThan(booking => booking.CheckInDate).WithMessage("Check-Out date must be after Check-In date.");
        }
    }
}
