﻿namespace TravelAccommodationBooking.Common.Exceptions.UserExceptions;

public class DuplicateEmailException : Exception
{
    public DuplicateEmailException(string email)
        : base($"Email '{email}' is already in use.")
    {
    }
}
