namespace TravelAccommodationBooking.Dtos.City
{
    public record CityCreationResponse(
        string Name,
        string Country,
        string PostOffice,
        DateTime CreationDate);
}
