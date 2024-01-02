﻿namespace TravelAccommodationBooking.Db.Utilities.Exceptions
{
    public class DuplicateEmailException : Exception
    {
        public DuplicateEmailException(string email)
            : base($"Email '{email}' is already in use.")
        {
        }
    }
}