using FluentValidation;
using TravelAccommodationBooking.Dtos.City;

namespace TravelAccommodationBooking.API.Utilities.Validators
{
    public class CityValidator : AbstractValidator<CityAdminRequest>
    {
        public CityValidator()
        {
            RuleFor(city => city.Name)
                .NotEmpty().WithMessage("City name is required.")
                .Length(2, 100).WithMessage("City name must be between 2 and 100 characters.");

            RuleFor(city => city.Country)
                .NotEmpty().WithMessage("Country name is required.")
                .Length(2, 100).WithMessage("Country name must be between 2 and 100 characters.");

            RuleFor(city => city.PostOffice)
                .Length(0, 20).When(city => !string.IsNullOrEmpty(city.PostOffice))
                .WithMessage("Post office code must be less than 20 characters.");
        }
    }
}
