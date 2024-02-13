namespace TravelAccommodationBooking.Db.Models
{
    public class HotelLocation
    {
        public int LocationId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; }
    }
}
