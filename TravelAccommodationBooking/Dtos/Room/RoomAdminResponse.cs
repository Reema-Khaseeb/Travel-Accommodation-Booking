namespace TravelAccommodationBooking.Dtos.Room
{
    public record RoomAdminResponse(
        int RoomId,
        int Number,
        int AdultsCapacity,
        int ChildrenCapacity,
        DateTime CreationDate,
        DateTime ModificationDate);
}
