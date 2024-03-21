namespace TravelAccommodationBooking.Dtos.Booking
{
    public record BookingResponse(
        //confirmation number,
        //hotel address,
        //room details,
        DateTime CheckInDate,
        DateTime CheckOutDate,
        double TotalPrice);
}
