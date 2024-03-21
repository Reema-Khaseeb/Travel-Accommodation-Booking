using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelAdminResponse(
        int HotelId,
        string Name,
        string Owner,
        StarRating StarRating,
        DateTime CreationDate,
        DateTime ModificationDate);
}
