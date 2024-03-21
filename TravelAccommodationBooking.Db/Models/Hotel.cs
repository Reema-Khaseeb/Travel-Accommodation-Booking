using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Db.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public StarRating StarRating { get; set; }
        public string Owner { get; set; }
        public string ThumbnailUrl { get; set; }
        public double Price { get; set; }
        public double DiscountRate { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime ModificationDate { get; set; }

        // Foreign keys
        public int CityId { get; set; }
        public int LocationId { get; set; }

        // Navigation properties
        public City City { get; set; }
        public HotelLocation Location { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<HotelImage> Images { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
