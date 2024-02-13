﻿using TravelAccommodationBooking.Db.Utilities.Enums;

namespace TravelAccommodationBooking.Db.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public string Email { get; set; }

        // Navigation properties
        public IEnumerable<Review> Reviews { get; set; }
    }
}
