using FluentValidation;
using TravelAccommodationBooking.Dtos.Hotel;

namespace TravelAccommodationBooking.API.Utilities.Validators.HotelValidators
{
    public class HotelUpdateRequestValidator : AbstractValidator<HotelUpdateRequest>
    {
        public HotelUpdateRequestValidator()
        {
            RuleFor(h => h.CityId)
                .GreaterThan(0)
                .WithMessage("City ID must be valid.");
        }
    }
}
