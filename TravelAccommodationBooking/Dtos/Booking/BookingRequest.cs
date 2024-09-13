namespace TravelAccommodationBooking.Dtos.Booking
{
    public record BookingRequest(
        int UserId,
        int RoomId,
        DateTime CheckInDate,
        DateTime CheckOutDate
        );
}
