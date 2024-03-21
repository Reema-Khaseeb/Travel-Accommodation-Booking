using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelSearchResponse(
        string Name,
        string ThumbnailUrl,
        double Price,
        StarRating StarRating,
        string Description);
}
