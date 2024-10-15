using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Db.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double TotalPrice { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string SpecialRequests { get; set; }
        public string ConfirmationNumber { get; set; }

        // Foreign keys
        public int UserId { get; set; }
        public int RoomId { get; set; }

        // Navigation
        public Room Room { get; set; }
    }
}
