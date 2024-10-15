using Microsoft.AspNetCore.Mvc;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Dtos.Hotel;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Dtos.Searching;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.API.Models.Searching;

namespace TravelAccommodationBooking.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("hotels")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;

        public HotelController(
            IHotelService hotelService,
            IMapper mapper
            )
        {
            _hotelService = hotelService;
            _mapper = mapper;
        }

        /// <summary>
        /// Create a new hotel.
        /// </summary>
        /// <param name="hotelDto">The hotel data transfer object containing information about the hotel to be created.</param>
        /// <returns>A newly created hotel object.</returns>
        [HttpPost]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status201Created, 
            "Successfully created hotel", typeof(HotelAdminResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, 
            "Invalid request data", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, 
            "An internal server error occurred.", typeof(ErrorResponse))]
        public async Task<ActionResult<HotelAdminResponse>> CreateHotel(HotelAdminRequest hotelDto)
        {
            try
            {
                var hotel = _mapper.Map<Hotel>(hotelDto);
                var newHotel = await _hotelService.CreateHotelAsync(hotel);
                var createdHotelDto = _mapper.Map<HotelAdminResponse>(newHotel);

                return CreatedAtAction(nameof(GetHotel),
                    new { id = createdHotelDto.HotelId },
                    createdHotelDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Updates an existing hotel.
        /// </summary>
        /// <param name="hotelId">The ID of the hotel to be updated.</param>
        /// <param name="hotelDto">The hotel update request containing new hotel details.</param>
        /// <returns>An ActionResult indicating the result of the operation.</returns>
        [HttpPut("{hotelId:int}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully updated the hotel")]
        [SwaggerResponse(StatusCodes.Status400BadRequest,"Validation error",
            typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Hotel not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateHotel(int hotelId, [FromBody] HotelUpdateRequest hotelDto)
        {
            try
            {
                await _hotelService.UpdateHotelAsync(hotelId, hotelDto);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Retrieves a list of all hotels.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all hotels available in the database. The response includes different levels of details based on the user's role:
        /// - Admin users receive detailed information about each hotel, including administrative details.
        /// - Non-admin users receive basic information about each hotel.
        /// </remarks>
        /// <returns>A list of hotels with details varying by user role.</returns>
        [HttpGet]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved hotels for admin users.",
            typeof(IEnumerable<HotelAdminResponse>))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved hotels for non-admin users.",
            typeof(IEnumerable<HotelResponse>))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<ActionResult> GetHotels()
        {
            try
            {
                var hotels = await _hotelService.GetHotelsAsync();
                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var adminHotelsResponse = _mapper.Map<IEnumerable<HotelAdminResponse>>(hotels);
                    return Ok(adminHotelsResponse);
                }
                var userHotelsResponse = _mapper.Map<IEnumerable<HotelResponse>>(hotels);
                return Ok(userHotelsResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }


        /// <summary>
        /// Retrieves a hotel by its ID.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a hotel available in the database give its {id}.
        /// The response includes different levels of details based on the user's role:
        /// - Admin users receive administrative details about the hotel.
        /// - Non-admin users receive basic information about each hotel.
        /// </remarks>
        /// <param name="id">The ID of the hotel to retrieve.</param>
        /// <returns>The hotel information varying by user role.</returns>
        [HttpGet("{id:int}")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved hotel for admin users", typeof(HotelAdminResponse))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved hotel for non-admin users", typeof(HotelResponse))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Hotel not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<ActionResult> GetHotel(int id)
        {
            try
            {
                var hotel = await _hotelService.GetHotelByIdAsync(id);

                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var adminHotelResponse = _mapper.Map<HotelAdminResponse>(hotel);
                    return Ok(adminHotelResponse);
                }
                var userHotelResponse = _mapper.Map<HotelResponse>(hotel);
                return Ok(userHotelResponse);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("An error occurred", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Deletes a hotel by its ID.
        /// </summary>
        /// <param name="id">The ID of the hotel to delete.</param>
        /// <returns>A response indicating the outcome of the operation.</returns>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully deleted hotel")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Hotel not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            try
            {
                await _hotelService.DeleteHotelAsync(id);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchMorePaginationDetails([FromQuery] SearchCriteriaRequest criteriaDto)
        {
            var criteria = _mapper.Map<SearchCriteria>(criteriaDto);
            var hotels = await _hotelService.SearchPaginatedAsync(criteria);
            return Ok(hotels);
        }
    }
}
