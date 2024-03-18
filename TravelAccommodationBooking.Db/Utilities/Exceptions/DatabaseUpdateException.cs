namespace TravelAccommodationBooking.Db.Utilities.Exceptions
{
    public class DatabaseUpdateException : Exception
    {
        public DatabaseUpdateException() : base() { }

        public DatabaseUpdateException(string message) : base(message) { }

        public DatabaseUpdateException(string message, Exception innerException) : base(message, innerException) { }
    }
}
