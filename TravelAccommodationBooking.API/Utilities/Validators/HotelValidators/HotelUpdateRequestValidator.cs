using FluentValidation;
using TravelAccommodationBooking.Dtos.Hotel;

namespace TravelAccommodationBooking.API.Utilities.Validators.HotelValidators
{
    public class HotelUpdateRequestValidator : AbstractValidator<HotelUpdateRequest>
    {
        public HotelUpdateRequestValidator()
        {
            //RuleFor(h => h.Name)
            //    .NotEmpty()
            //    .WithMessage("Hotel name is required.");
            //RuleFor(h => h.Owner)
            //    .NotEmpty()
            //    .WithMessage("Owner is required.");
            RuleFor(h => h.CityId)
                .GreaterThan(0)
                .WithMessage("City ID must be valid.");
            RuleFor(h => h.LocationId)
                .GreaterThan(0)
                .WithMessage("Location ID must be valid.");
        }
    }
}
