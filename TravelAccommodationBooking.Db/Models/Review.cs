namespace TravelAccommodationBooking.Db.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewContent { get; set; }
        public DateTime ReviewDate { get; set; }

        // Foreign keys
        public int HotelId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; }
        public User User { get; set; }
    }
}
