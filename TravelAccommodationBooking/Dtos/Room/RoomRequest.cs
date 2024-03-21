using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Room
{
    public record RoomRequest(
        int AdultsCapacity,
        int ChildrenCapacity,
        RoomType RoomType);
}
