namespace TravelAccommodationBooking.Db.Models;

public class FeaturedDeal
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }
    public double DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
