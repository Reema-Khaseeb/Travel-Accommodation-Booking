using TravelAccommodationBooking.Dtos.Room;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IRoomService
{
    Task<Room> CreateRoomAsync(int hotelId, Room room);
    Task UpdateRoomAsync(int hotelId, int roomId, RoomUpdateRequest roomRequest);
    Task DeleteRoomAsync(int roomId);
    Task<Room> GetRoomByIdAsync(int roomId);
    Task<IEnumerable<Room>> GetRoomsAsync();
}