using FluentValidation;
using TravelAccommodationBooking.Dtos.Room;
using TravelAccommodationBooking.Common.Constants;

namespace TravelAccommodationBooking.API.Utilities.Validators.RoomValidators
{
    public class RoomAdminRequestValidator : AbstractValidator<RoomAdminRequest>
    {
        public RoomAdminRequestValidator()
        {
            RuleFor(room => room.Number)
                .GreaterThan(0)
                .WithMessage("Room number must be greater than 0");

            RuleFor(room => room.AdultsCapacity)
                .InclusiveBetween(RoomConstants.MinAdultsCapacity, RoomConstants.MaxAdultsCapacity)
                .WithMessage("Adults capacity must be between 1 and 4");

            RuleFor(room => room.ChildrenCapacity)
                .InclusiveBetween(RoomConstants.MinChildrenCapacity, RoomConstants.MaxChildrenCapacity)
                .WithMessage("Children capacity must be between 0 and 3");

            RuleFor(room => room.RoomType)
                .IsInEnum()
                .WithMessage("Invalid room type");

            RuleFor(room => room.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than 0");

            RuleFor(room => room.ThumbnailUrl)
                .Matches(@"^(https?:\/\/).+")
                .WithMessage("Thumbnail URL must be a valid URL");
        }
    }
}