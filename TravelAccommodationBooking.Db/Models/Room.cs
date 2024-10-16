﻿using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Db.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int AdultsCapacity { get; set; }
        public int ChildrenCapacity { get; set; }
        public RoomType RoomType { get; set; }
        public double Price { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime ModificationDate { get; set; }

        // Foreign key
        public int HotelId { get; set; }

        // Navigation property
        public Hotel Hotel { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
    }
}
