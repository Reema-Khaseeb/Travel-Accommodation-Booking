namespace TravelAccommodationBooking.Db.Models
{
    public class HotelImage
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
