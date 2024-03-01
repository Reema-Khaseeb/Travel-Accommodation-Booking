namespace TravelAccommodationBooking.API.Exceptions
{
    public class RoomNumberNotUniqueException : Exception
    {
        public RoomNumberNotUniqueException() { }

        public RoomNumberNotUniqueException(string message) : base(message) { }

        public RoomNumberNotUniqueException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
