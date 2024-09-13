namespace TravelAccommodationBooking.Services.Interfaces;

public interface IPdfService
{
    Task<byte[]> GeneratePdf(string html);
}