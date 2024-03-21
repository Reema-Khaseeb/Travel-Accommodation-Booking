using AutoMapper;
using TravelAccommodationBooking.Dtos.Hotel;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace TravelAccommodationBooking.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ILogger<HotelService> _logger;
        private readonly IMapper _mapper;

        public HomeService(
            IHotelRepository hotelRepository,
            ILogger<HotelService> logger,
            IMapper mapper
            )
        {
            _hotelRepository = hotelRepository;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper;
        }

        public async Task<IEnumerable<FeaturedDeal>> GetFeaturedDealsAsync()
        {
            var hotels = await _hotelRepository.GetFeaturedDealsHotelsAsync();
            return _mapper.Map<IEnumerable<FeaturedDeal>>(hotels);
        }
    }
}
