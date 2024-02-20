namespace TravelAccommodationBooking.Db.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string PostOffice { get; set; }
        public string ThumbnailUrl { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime ModificationDate { get; set; }

        // Navigation property
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}
