using TravelAccommodationBooking.API.Utilities.Constants;
using TravelAccommodationBooking.Common.Enums;
using TravelAccommodationBooking.Common.Constants;

namespace TravelAccommodationBooking.API.Models.Searching
{
    /// <summary>
    /// Represents the search criteria for finding hotels.
    /// </summary>
    public record SearchCriteriaRequest(
        /// <summary>Optional city ID for filtering hotels by city.</summary>
        int? CityId,

        /// <summary>Optional check-in date for availability.</summary>
        DateTime? CheckInDate,

        /// <summary>Optional check-out date for availability.</summary>
        DateTime? CheckOutDate,

        /// <summary>Optional room type for filtering hotels.</summary>
        RoomType? RoomType,

        /// <summary>Optional minimum price filter for hotels.</summary>
        double? MinPrice,

        /// <summary>Optional maximum price filter for hotels.</summary>
        double? MaxPrice,

        /// <summary>Optional specific star rating to filter hotels.</summary>
        StarRating? StarRating,

        /// <summary>Optional minimum star rating for filtering hotels.</summary>
        StarRating? MinStarRating,

        /// <summary>Optional maximum star rating for filtering hotels.</summary>
        StarRating? MaxStarRating,

        /// <summary>Number of adults, defaulting to a standard capacity.</summary>
        int NumberOfAdults = RoomConstants.DefaultAdultsCapacity,

        /// <summary>Number of children, defaulting to a standard capacity.</summary>
        int NumberOfChildren = RoomConstants.DefaultChildrenCapacity,

        /// <summary>Page number for pagination, defaulting to the first page.</summary>
        int PageNumber = PaginationConstants.DefaultPageNumber,

        /// <summary>Page size for pagination, defaulting to a standard size.</summary>
        int PageSize = PaginationConstants.DefaultPageSize);
}

