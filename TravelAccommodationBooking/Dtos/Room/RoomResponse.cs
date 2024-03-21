using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Room
{
    public record RoomResponse(
        RoomType RoomType,
        string Description,
        decimal Price,
        string ThumbnailUrl);
}
