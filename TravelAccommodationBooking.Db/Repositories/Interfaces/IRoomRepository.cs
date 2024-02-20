using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room> CreateRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(Room room);
        Task<Room> GetRoomByIdAsync(int roomId);
        Task<IEnumerable<Room>> GetRoomsAsync();
    }
}