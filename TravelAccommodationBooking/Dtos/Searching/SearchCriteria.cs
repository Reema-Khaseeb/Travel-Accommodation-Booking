using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.API.Models.Searching
{
    public class SearchCriteria
    {
        public int? CityId { get; set; }
        public DateTime? CheckInDate { get; set; } = DateTime.Today;
        public DateTime? CheckOutDate { get; set; } = DateTime.Today.AddDays(1);
        public RoomType? RoomType { get; set; }
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public StarRating? StarRating { get; set; }
        public StarRating? MinStarRating { get; set; }
        public StarRating? MaxStarRating { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
