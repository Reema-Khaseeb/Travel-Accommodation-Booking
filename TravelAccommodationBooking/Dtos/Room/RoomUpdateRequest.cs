namespace TravelAccommodationBooking.Dtos.Room
{
    public record RoomUpdateRequest(
        int Number,
        int AdultsCapacity,
        int ChildrenCapacity);
}
