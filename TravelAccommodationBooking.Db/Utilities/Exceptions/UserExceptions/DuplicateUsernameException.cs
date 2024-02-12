namespace TravelAccommodationBooking.Db.Utilities.Exceptions
{
    public class DuplicateUsernameException : Exception
    {
        public DuplicateUsernameException(string username)
            : base($"Username '{username}' is already taken.")
        {
        }
    }
}
