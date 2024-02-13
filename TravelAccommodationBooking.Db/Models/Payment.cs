using TravelAccommodationBooking.Db.Utilities.Enums;
namespace TravelAccommodationBooking.Db.Models;

public class Payment
{
    public int PaymentId { get; set; }
    public decimal Amount { get; set; }
    public bool IsProcessed { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentStatus Status { get; set; }
    
    // Foreign key
    public int BookingId { get; set; }

    // Navigation Property
    public Booking Booking { get; set; }
}