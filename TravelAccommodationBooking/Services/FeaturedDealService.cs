using Microsoft.Extensions.Logging;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Dtos.FeaturedDeal;
using TravelAccommodationBooking.Services.Interfaces;

namespace TravelAccommodationBooking.Services;

public class FeaturedDealService : IFeaturedDealService
{
    private readonly IFeaturedDealRepository _featuredDealRepository;
    private readonly ILogger<FeaturedDealService> _logger;

    public FeaturedDealService(
        IFeaturedDealRepository featuredDealRepository,
        ILogger<FeaturedDealService> logger)
    {
        _featuredDealRepository = featuredDealRepository;
        _logger = logger;
    }

    public async Task<IEnumerable<FeaturedDealDto>> GetActiveFeaturedDealsAsync()
    {
        try
        {
            var featuredDeals = await _featuredDealRepository.GetActiveFeaturedDealsAsync();
            _logger.LogInformation("Successfully retrieved {Count} featured deals", featuredDeals.Count());
            return featuredDeals
                .Select(fd => new FeaturedDealDto(
                    HotelName: fd.Hotel.Name,
                    ThumbnailUrl: fd.Hotel.ThumbnailUrl,
                    OriginalPrice: fd.Hotel.Price,
                    DiscountedPrice: fd.Hotel.Price * (1 - fd.DiscountPercentage / 100),
                    StarRating: fd.Hotel.StarRating,
                    Address: fd.Hotel.Address
                ));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred in the FeaturedDealService while retrieving featured deals.");
            throw;
        }
    }
}
