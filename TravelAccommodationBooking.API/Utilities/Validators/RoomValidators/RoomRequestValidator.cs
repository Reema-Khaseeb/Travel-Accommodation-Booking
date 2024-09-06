using FluentValidation;
using TravelAccommodationBooking.Dtos.Room;
using TravelAccommodationBooking.Common.Constants;

namespace TravelAccommodationBooking.API.Utilities.Validators.RoomValidators
{
    public class RoomRequestValidator : AbstractValidator<RoomRequest>
    {
        public RoomRequestValidator()
        {
            RuleFor(room => room.AdultsCapacity)
                .InclusiveBetween(RoomConstants.MinAdultsCapacity, RoomConstants.MaxAdultsCapacity)
                .WithMessage("Adults capacity must be between 1 and 4");

            RuleFor(room => room.ChildrenCapacity)
                .InclusiveBetween(RoomConstants.MinChildrenCapacity, RoomConstants.DefaultChildrenCapacity)
                .WithMessage("Children capacity must be between 0 and 3");

            RuleFor(room => room.RoomType)
                .IsInEnum()
                .WithMessage("Invalid room type");
        }
    }
}
