namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelUpdateRequest
        (
        string? Name,
        int? LocationId,
        string? Owner,
        int? CityId);
}
