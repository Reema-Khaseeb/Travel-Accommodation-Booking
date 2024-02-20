using AutoMapper;
using TravelAccommodationBooking.API.Dtos.Room;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Db.Utilities.Exceptions;

namespace TravelAccommodationBooking.API.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;
        private readonly ILogger<RoomService> _logger;

        public RoomService(IRoomRepository roomRepository,
            IHotelService hotelService,
            IMapper mapper,
            ILogger<RoomService> logger
            )
        {
            _roomRepository = roomRepository;
            _hotelService = hotelService;
            _mapper = mapper;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Room> CreateRoomAsync(int hotelId, Room room)
        {
            var hotel = await _hotelService.GetHotelByIdAsync(hotelId);            
            room.HotelId = hotelId;

            var newRoom = await _roomRepository.CreateRoomAsync(room);
            _logger.LogInformation($"City {room.Number} created successfully.");
            return newRoom;
        }

        public async Task UpdateRoomAsync(int hotelId, int roomId, RoomUpdateRequest roomRequest)
        {
            var existedRoom = await _roomRepository.GetRoomByIdAsync(roomId);
            _mapper.Map(roomRequest, existedRoom);

            var hotel = await _hotelService.GetHotelByIdAsync(hotelId);
            if (existedRoom.HotelId != hotelId)
            {
                _logger.LogWarning($"Room with ID {existedRoom.RoomId} does not belong to hotel with ID {hotelId}.");
                throw new ArgumentException($"Room with ID {existedRoom.RoomId} does not belong to hotel with ID {hotelId}.");
            }

            existedRoom.ModificationDate = DateTime.UtcNow;
            await _roomRepository.UpdateRoomAsync(existedRoom);
            _logger.LogInformation($"Room-{existedRoom.Number} updated successfully.");
        }

        public async Task DeleteRoomAsync(int roomId)
        {
            if (roomId <= 0)
            {
                _logger.LogWarning("Attempted to delete a room with invalid ID: {RoomId}", roomId);
                throw new ArgumentException("Room ID must be positive.", nameof(roomId));
            }

            var room = await _roomRepository.GetRoomByIdAsync(roomId);
            await _roomRepository.DeleteRoomAsync(room);
            _logger.LogInformation("Room with ID: {RoomId} was successfully deleted.", roomId);
        }

        public async Task<Room> GetRoomByIdAsync(int roomId)
        {
            var room = await _roomRepository.GetRoomByIdAsync(roomId);

            if (room == null)
            {
                _logger.LogWarning($"Room with ID {roomId} not found.");
                throw new NotFoundException($"Room with ID {roomId} not found.");
            }

            _logger.LogInformation($"Room with ID {roomId} successfully retrieved.");
            return room;
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync()
        {
            var rooms = await _roomRepository.GetRoomsAsync();
            _logger.LogInformation("All Rooms successfully retrieved.");
            return rooms;
        }
    }
}
