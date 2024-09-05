using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Room
{
    public record RoomAdminRequest(
        int Number,
        int AdultsCapacity,
        int ChildrenCapacity,
        RoomType RoomType,
        double Price,
        string ThumbnailUrl,
        string Description);
}
