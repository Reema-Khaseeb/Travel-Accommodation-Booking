using TravelAccommodationBooking.Dtos.Review;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelResponse(
        string Name,
        StarRating StarRating,
        string Description,
        IEnumerable<ReviewDto> Reviews);
}
