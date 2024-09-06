using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TravelAccommodationBooking.Dtos.City;
using TravelAccommodationBooking.Dtos.Error;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Exceptions;

namespace TravelAccommodationBooking.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("cities")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CityController(
            ICityService cityService,
            IMapper mapper,
            IValidator<CityAdminRequest> cityValidator)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        /// <summary>
        /// Create a new city.
        /// </summary>
        /// <param name="cityDto">The city data transfer object containing information about the city to be created.</param>
        /// <returns>A newly created city object.</returns>
        [HttpPost]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status201Created, "Successfully created city.", typeof(CityCreationResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid request data", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "An internal server error occurred.", typeof(ErrorResponse))]
        public async Task<ActionResult<CityCreationResponse>> CreateCity(CityAdminRequest cityDto)
        {
            try
            {
                var city = _mapper.Map<City>(cityDto);
                var newCity = await _cityService.CreateCityAsync(city);
                var createdCityDto = _mapper.Map<CityCreationResponse>(newCity);

                return CreatedAtAction(nameof(GetCity),
                    new { id = newCity.CityId },
                    createdCityDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Updates an existing city.
        /// </summary>
        /// <param name="cityId">The ID of the city to be updated.</param>
        /// <param name="cityDto">The city update request containing new city details.</param>
        /// <returns>An ActionResult indicating the result of the operation.</returns>
        [HttpPatch("{cityId:int}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully updated the city")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Validation error", typeof(FluentValidation.Results.ValidationResult))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "City not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateCity(int cityId, [FromBody] CityAdminRequest cityDto)
        {
            try
            {
                await _cityService.UpdateCityAsync(cityId, cityDto);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse("City not found", ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Retrieves a list of all cities.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all cities available in the database. The response includes different levels of details based on the user's role:
        /// - Admin users receive detailed information about each city, including administrative details.
        /// - Non-admin users receive basic information about each city.
        /// </remarks>
        /// <returns>A list of cities with details varying by user role.</returns>
        [HttpGet]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved cities for admin users.",
            typeof(IEnumerable<CityAdminResponse>))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved cities for non-admin users.",
            typeof(IEnumerable<CityUserResponse>))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<ActionResult> GetCities()
        {
            try
            {
                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var citiesWithHotelsCount = await _cityService.GetCitiesWithHotelsCountViewAsync();
                    var adminCitiesResponse = _mapper
                        .Map<IEnumerable<CityAdminResponse>>(citiesWithHotelsCount);
                    return Ok(adminCitiesResponse);
                }
                var cities = await _cityService.GetCitiesAsync();
                var userCitiesResponse = _mapper.Map<IEnumerable<CityUserResponse>>(cities);
                return Ok(userCitiesResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new ErrorResponse("An internal server error occurred.",
                    ex.Message));
            }
        }

        /// <summary>
        /// Retrieves a city by its ID.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves a city available in the database give its {id}.
        /// The response includes different levels of details based on the user's role:
        /// - Admin users receive administrative details about the city.
        /// - Non-admin users receive basic information about each city.
        /// </remarks>
        /// <param name="id">The ID of the city to retrieve.</param>
        /// <returns>The city information varying by user role.</returns>
        [HttpGet("{id:int}")]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved city for admin users", typeof(CityAdminResponse))]
        [SwaggerResponse(StatusCodes.Status200OK,
            "Successfully retrieved city for non-admin users", typeof(CityUserResponse))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "City not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<ActionResult> GetCity(int id)
        {
            try
            {
                if (User.IsInRole(nameof(UserRole.Admin)))
                {
                    var cityWithHotelsCount = await _cityService.GetCityByIdWithHotelsCountViewAsync(id);
                    var adminCityResponse = _mapper.Map<CityAdminResponse>(cityWithHotelsCount);
                    return Ok(adminCityResponse);
                }
                var city = await _cityService.GetCityByIdAsync(id);
                var userCityResponse = _mapper.Map<CityUserResponse>(city);
                return Ok(userCityResponse);
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
        /// Deletes a city by its ID.
        /// </summary>
        /// <param name="id">The ID of the city to delete.</param>
        /// <returns>A response indicating the outcome of the operation.</returns>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = nameof(UserRole.Admin))]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Successfully deleted city")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "City not found", typeof(ErrorResponse))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal server error", typeof(ErrorResponse))]
        public async Task<IActionResult> DeleteCity(int id)
        {
            try
            {
                await _cityService.DeleteCityAsync(id);
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
    }
}
