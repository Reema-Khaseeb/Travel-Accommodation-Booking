using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities.Enums;

namespace TravelAccommodationBooking.Db.Utilities
{
    public static class SeedData
    {
        public static List<City> SeedCities()
        {
            var cities = new List<City>();

            for (int i = 1; i <= 50; i++)
            {
                cities.Add(new City
                {
                    CityId = i,
                    Name = $"City{i}",
                    Country = $"Country{i}",
                    PostOffice = $"PostOffice{i}",
                    ThumbnailUrl = $"http://example.com/city{i}.jpg"
                });
            }

            return cities;
        }

        public static List<HotelImage> SeedHotelImages()
        {
            var hotelImages = new List<HotelImage>();
            Random rand = new Random();
            var imageCounter = 1; // Counter for unique ImageId
            var numberOfHotels = 50;

            for (int hotelId = 1; hotelId <= numberOfHotels; hotelId++)
            {
                var imagesPerHotel = rand.Next(1, 6);

                for (int imageIndex = 1; imageIndex <= imagesPerHotel; imageIndex++)
                {
                    var imageUrl = $"http://example.com/hotel{hotelId}_image{imageIndex}.jpg";
                    hotelImages.Add(new HotelImage
                    {
                        ImageId = imageCounter++,
                        ImageUrl = imageUrl,
                        HotelId = hotelId
                    });
                }
            }

            return hotelImages;
        }

        public static List<Hotel> SeedHotels()
        {
            var hotels = new List<Hotel>();
            Random rand = new Random();

            for (int i = 1; i <= 50; i++)
            {
                hotels.Add(new Hotel
                {
                    HotelId = i,
                    Name = $"Hotel{i}",
                    StarRating = (StarRating)rand.Next(1, 6),
                    Owner = $"Owner{i}",
                    LocationId = i,
                    ThumbnailUrl = $"http://example.com/hotel{i}.jpg",
                    Price = rand.NextDouble() * 500,
                    Description = $"Description for Hotel{i}",
                    CreationDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                    ModificationDate = DateTime.Now,
                    DiscountRate = rand.NextDouble(),
                    CityId = rand.Next(1, 11)
                });
            }

            return hotels;
        }

        public static List<HotelLocation> SeedLocations()
        {
            var locations = new List<HotelLocation>();
            Random rand = new Random();

            for (int i = 1; i <= 50; i++)
            {
                locations.Add(new HotelLocation
                {
                    LocationId = i,
                    Latitude = rand.NextDouble() * 180 - 90, // between -90 and 90
                    Longitude = rand.NextDouble() * 360 - 180 // between -180 and 180
                });
            }

            return locations;
        }

        public static List<Review> SeedReviews()
        {
            var reviewList = new List<Review>();
            Random rand = new Random();

            for (int i = 1; i <= 200; i++)
            {
                var hotelId = rand.Next(1, 51);
                var userId = rand.Next(3, 301);
                reviewList.Add(new Review
                {
                    ReviewId = i,
                    ReviewContent = $"This is a review content for Hotel {hotelId}",
                    ReviewDate = DateTime.Now.AddDays(-rand.Next(0, 365)),
                    HotelId = hotelId,
                    UserId = userId
                });
            }

            return reviewList;
        }

        public static List<Room> SeedRooms()
        {
            var rooms = new List<Room>();
            Random rand = new Random();

            for (int i = 1; i <= 150; i++)
            {
                rooms.Add(new Room
                {
                    RoomId = i,
                    Number = i,
                    AdultsCapacity = rand.Next(1, 5),
                    ChildrenCapacity = rand.Next(0, 3),
                    RoomType = (RoomType)rand.Next(1, 4),
                    Price = rand.Next(50, 500),
                    ThumbnailUrl = $"http://example.com/room{i}.jpg",
                    HotelId = rand.Next(1, 51),
                    CreationDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                    ModificationDate = DateTime.Now,
                    Description = $"Description for Room{i}",
                });
            }

            return rooms;
        }

        public static List<Booking> SeedBookings()
        {
            return new List<Booking>
            {
                new Booking { BookingId = 1, UserId = 3, RoomId = 1, CheckInDate = new DateTime(2024, 1, 25), CheckOutDate = new DateTime(2024, 2, 1), TotalPrice = 770, Status = BookingStatus.Confirmed, CreatedAt = DateTime.UtcNow },
                new Booking { BookingId = 2, UserId = 3, RoomId = 2, CheckInDate = new DateTime(2024, 3, 10), CheckOutDate = new DateTime(2024, 3, 23), TotalPrice = 539, Status = BookingStatus.Confirmed, CreatedAt = DateTime.UtcNow },
                new Booking { BookingId = 3, UserId = 49, RoomId = 49, CheckInDate = new DateTime(2024, 2, 20), CheckOutDate = new DateTime(2024, 3, 5), TotalPrice = 655, Status = BookingStatus.Confirmed, CreatedAt = DateTime.UtcNow },
                new Booking { BookingId = 4, UserId = 50, RoomId = 50, CheckInDate = new DateTime(2024, 1, 24), CheckOutDate = new DateTime(2024, 2, 8), TotalPrice = 796, Status = BookingStatus.Confirmed, CreatedAt = DateTime.UtcNow },
                new Booking
                {
                    BookingId = 5,
                    UserId = 3,
                    RoomId = 3,
                    CheckInDate = DateTime.Parse("2024-02-03"),
                    CheckOutDate = DateTime.Parse("2024-02-08"),
                    TotalPrice = 341,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 6,
                    UserId = 4,
                    RoomId = 4,
                    CheckInDate = DateTime.Parse("2024-03-01"),
                    CheckOutDate = DateTime.Parse("2024-03-12"),
                    TotalPrice = 297,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 7,
                    UserId = 3,
                    RoomId = 3,
                    CheckInDate = new DateTime(2024, 3, 1),
                    CheckOutDate = new DateTime(2024, 3, 4),
                    TotalPrice = 300.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 8,
                    UserId = 4,
                    RoomId = 3,
                    CheckInDate = new DateTime(2024, 3, 5),
                    CheckOutDate = new DateTime(2024, 3, 8),
                    TotalPrice = 300.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 9,
                    UserId = 2,
                    RoomId = 5,
                    CheckInDate = new DateTime(2024, 2, 1),
                    CheckOutDate = new DateTime(2024, 2, 3),
                    TotalPrice = 200.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 10,
                    UserId = 4,
                    RoomId = 4,
                    CheckInDate = new DateTime(2024, 3, 14),
                    CheckOutDate = new DateTime(2024, 3, 16),
                    TotalPrice = 450.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 11,
                    UserId = 5,
                    RoomId = 4,
                    CheckInDate = new DateTime(2024, 3, 17),
                    CheckOutDate = new DateTime(2024, 3, 20),
                    TotalPrice = 400.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 12,
                    UserId = 6,
                    RoomId = 9,
                    CheckInDate = new DateTime(2024, 4, 1),
                    CheckOutDate = new DateTime(2024, 4, 5),
                    TotalPrice = 500.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                },
                new Booking
                {
                    BookingId = 13,
                    UserId = 7,
                    RoomId = 10,
                    CheckInDate = new DateTime(2024, 4, 6),
                    CheckOutDate = new DateTime(2024, 4, 10),
                    TotalPrice = 550.00,
                    Status = BookingStatus.Confirmed,
                    CreatedAt = DateTime.UtcNow
                }
            };
        }

        public static List<Payment> SeedPayments()
            {
                var payments = new List<Payment>();
                Random rand = new Random();
                DateTime today = DateTime.Today;

                for (int i = 1; i <= 13; i++)
                {
                    payments.Add(new Payment
                    {
                        PaymentId = i,
                        BookingId = i,
                        Amount = rand.Next(100, 1000),
                        IsProcessed = true,
                        PaymentDate = today.AddDays(-rand.Next(0, 30)), // in the past 30 days
                        Status = PaymentStatus.Success
                    });
                }

                return payments;
            }

        public static List<User> SeedUsers()
        {
            var users = new List<User>();
            for (int i = 3; i <= 300; i++)
            {
                users.Add(new User
                {
                    UserId = i,
                    Username = $"user{i}",
                    Password = HashPassword($"password{i}"),
                    Role = UserRole.User,
                    Email = $"user{i}@example.com"
                });
            }
            users.AddRange(SeedAdminUsers());
            return users;
        }

        private static List<User> SeedAdminUsers()
        {
            return new List<User>
            {
                new User
                {
                    UserId = 1,
                    Username = "admin1",
                    Password = HashPassword("adminpassword1"),
                    Role = UserRole.Admin,
                    Email = "admin1@example.com"
                },
                new User
                {
                    UserId = 2,
                    Username = "admin2",
                    Password = HashPassword("adminpassword2"),
                    Role = UserRole.Admin,
                    Email = "admin2@example.com"
                }
            };
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
