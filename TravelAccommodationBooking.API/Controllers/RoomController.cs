using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Dtos.Room;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Exceptions;

namespace TravelAccommodationBooking.API.Controllers
{
    [Authorize]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        private readonly IValidator<RoomAdminRequest> _roomAdminRequestValidator;
        private readonly IValidator<RoomUpdateRequest> _roomUpdateRequestValidator;
        private readonly IValidator<RoomRequest> _roomRequestValidator;
        
            

        public RoomController(
            IRoomService roomService,
            IMapper mapper,
            IValidator<RoomAdminRequest> roomAdminRequestValidator,
            IValidator<RoomUpdateRequest> roomUpdateRequestValidator,
            IValidator<RoomRequest> roomRequestValidator
            )
        {
            _roomService = roomService;
            _mapper = mapper;
            _roomAdminRequestValidator = roomAdminRequestValidator;
            _roomUpdateRequestValidator = roomUpdateRequestValidator;
            _roomRequestValidator = roomRequestValidator;
        }

        /// <summary>
        /// Creates a new room within a specified hotel.
        /// </summary>
        /// <param name="hotelId">The ID of the hotel where the room will be created.</param>
        /// <param name="roomAdminRequest">The room creation request containing room details.</param>
        /// <returns>A newly created room response.</returns>
        /// <remarks>
        /// This endpoint allows for the creation of a new room under a given hotel. 
        /// It requires admin privileges. The endpoint validates the provided room details before creation.
        /// </remarks>
        [HttpPost("hotels/{hotelId}/rooms")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status201Created, "Successfully created room", typeof(RoomAdminResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Validation error", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Hotel not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status409Conflict, "Room number is not unique for the hotel", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<ActionResult<RoomAdminResponse>> CreateRoom(int hotelId, RoomAdminRequest roomAdminRequest)
        {
            var validationResult = await _roomAdminRequestValidator.ValidateAsync(roomAdminRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var room = _mapper.Map<Room>(roomAdminRequest);
                var newRoom = await _roomService.CreateRoomAsync(hotelId, room);
                var createdRoomDto = _mapper.Map<RoomAdminResponse>(newRoom);

                return CreatedAtAction(nameof(GetRoom),
                new { id = createdRoomDto.RoomId },
                    createdRoomDto);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (RoomNumberNotUniqueException ex)
            {
                return Conflict(new ErrorResponse("Room number conflict", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An internal server error occurred during room creation.",
                    ex.Message
                ));
            }
        }

        /// <summary>
        /// Updates an existing room within a specified hotel.
        /// </summary>
        /// <param name="hotelId">The ID of the hotel to which the room belongs.</param>
        /// <param name="roomId">The ID of the room to be updated.</param>
        /// <param name="roomDto">The room update request containing new room details.</param>
        /// <returns>An ActionResult indicating the result of the operation.</returns>
        /// <remarks>
        /// This endpoint requires admin privileges and validates the update request before applying changes.
        /// </remarks>
        [HttpPatch("hotels/{hotelId}/rooms/{roomId}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully updated the room")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Hotel or room not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status409Conflict, "Room number is not unique for the hotel", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Validation error", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateRoom(int hotelId, int roomId, [FromBody] RoomUpdateRequest roomDto)
        {
            var validationResult = await _roomUpdateRequestValidator.ValidateAsync(roomDto);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                await _roomService.UpdateRoomAsync(hotelId, roomId, roomDto);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (RoomNumberNotUniqueException ex)
            {
                return Conflict(new ErrorResponse("Room number conflict", ex.Message));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An internal server error occurred during room update.",
                    ex.Message
                ));
            }
        }

        /// <summary>
        /// Retrieves all rooms.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a list of rooms.
        /// The response includes different levels of details based on the user's role:
        /// - Admin users receive administrative details about each room.
        /// - Non-admin users receive basic information about each room.
        /// </remarks>
        /// <returns>A list of rooms. The content of the list is role-dependent.</returns>
        /// <response code="200">Successfully retrieved rooms. Response type varies based on user role.</response>
        [HttpGet("rooms")]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved rooms for admin users", typeof(RoomAdminResponse))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved rooms for non-admin users", typeof(RoomResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse), "Unexpected error occurred")]
        public async Task<ActionResult> GetRooms()
        {
            try
            {
                var rooms = await _roomService.GetRoomsAsync();

                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var adminRoomsResponse = _mapper.Map<IEnumerable<RoomAdminResponse>>(rooms);
                    return Ok(adminRoomsResponse);
                }
                var userRoomsResponse = _mapper.Map<IEnumerable<RoomResponse>>(rooms);
                return Ok(userRoomsResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An internal server error occurred during getting rooms.",
                    ex.Message
                ));
            }
        }

        /// <summary>
        /// Retrieves detailed information about a room by its ID.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a room available in the database give its {id}.
        /// The response includes different levels of details based on the user's role:
        /// - Admin users receive administrative details about the room.
        /// - Non-admin users receive basic information about the room.
        /// </remarks>
        /// <param name="id">The ID of the room to retrieve.</param>
        /// <returns>Room information varying by user role.</returns>
        /// <response code="200">Successfully retrieved room. The content returned varies depending on whether the requester is an admin or a regular user.</response>
        /// <response code="404">Room not found. The specified room ID does not exist.</response>
        /// <response code="500">An internal server error occurred while processing the request.</response>
        [HttpGet("rooms/{id}")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved room for admin users", typeof(RoomAdminResponse))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved room for non-admin users", typeof(RoomResponse))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Room not found.", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError,
            "An internal server error occurred while processing the request.", typeof(ErrorResponse))]
        public async Task<ActionResult> GetRoom(int id)
        {
            try
            {
                var room = await _roomService.GetRoomByIdAsync(id);

                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var adminRoomResponse = _mapper.Map<RoomAdminResponse>(room);
                    return Ok(adminRoomResponse);
                }
                var userRoomResponse = _mapper.Map<RoomResponse>(room);
                return Ok(userRoomResponse);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse(
                    "An internal server error occurred while retrieving room with ID {id}.",
                    ex.Message
                ));
            }
        }

        [HttpDelete("rooms/{roomId}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully deleted room.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Room not found.", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid room ID.", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "An error occurred while deleting the room.", typeof(ErrorResponse))]
        public async Task<IActionResult> DeleteRoom(int roomId)
        {
            try
            {
                await _roomService.DeleteRoomAsync(roomId);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("Room not found", ex.Message));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ErrorResponse("Invalid Request", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorResponse("An error occurred", ex.Message));
            }
        }

        //[HttpGet("available")]
        //public async Task<IActionResult> GetAvailableRooms([FromQuery] int hotelId,
        //    [FromQuery] DateTime checkIn, [FromQuery] DateTime checkOut)
        //{
        //    var availableRooms = await _roomService.GetAvailableRooms(hotelId, checkIn, checkOut);
        //    var availableRoomsResponse = _mapper.Map<List<RoomAdminResponse>>(availableRooms);
        //    return Ok(availableRoomsResponse);
        //}
    }
}
