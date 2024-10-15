using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.FeaturedDeal
{
    public record FeaturedDealDto(
        string HotelName,
        string ThumbnailUrl,
        double OriginalPrice,
        double DiscountedPrice,
        StarRating StarRating,
        string Address);
}
