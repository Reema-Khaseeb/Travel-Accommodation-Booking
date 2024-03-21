using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record FeaturedDeal(
        string Name,
        string ThumbnailUrl,
        double Price,
        double DiscountedPrice,
        StarRating StarRating,
        HotelLocation Location);
}
