using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelDto(
    string Name,
    StarRating StarRating,
    string Description);
}
