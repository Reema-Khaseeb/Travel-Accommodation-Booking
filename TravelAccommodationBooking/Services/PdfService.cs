using NReco.PdfGenerator;
using TravelAccommodationBooking.Services.Interfaces;

namespace TravelAccommodationBooking.Services;

public class PdfService : IPdfService
{
    public PdfService()
    {
    }

    public async Task<byte[]> GeneratePdf(string html)
    {
        var htmlToPdfConverter = new HtmlToPdfConverter();
        return await Task.FromResult(htmlToPdfConverter.GeneratePdf(html));
    }
}
