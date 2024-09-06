using FluentValidation;
using TravelAccommodationBooking.Dtos.Hotel;

namespace TravelAccommodationBooking.API.Utilities.Validators.HotelValidators
{
    public class HotelAdminRequestValidator : AbstractValidator<HotelAdminRequest>
    {
        public HotelAdminRequestValidator()
        {
            RuleFor(h => h.Name)
                .NotEmpty()
                .WithMessage("Hotel name is required.");
            RuleFor(h => h.Owner)
                .NotEmpty()
                .WithMessage("Owner is required.");
            RuleFor(h => h.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than 0.");
            RuleFor(h => h.Description)
                .NotEmpty()
                .WithMessage("Description is required.");
            RuleFor(h => h.CityId)
                .GreaterThan(0)
                .WithMessage("City ID must be valid.");
        }
    }
}
