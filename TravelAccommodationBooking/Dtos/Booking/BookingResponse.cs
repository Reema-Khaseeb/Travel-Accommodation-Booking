namespace TravelAccommodationBooking.Dtos.Booking
{
    public record BookingResponse(
        DateTime CheckInDate,
        DateTime CheckOutDate,
        double TotalPrice);
}
