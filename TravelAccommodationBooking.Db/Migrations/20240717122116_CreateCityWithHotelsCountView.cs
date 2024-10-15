using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAccommodationBooking.Db.Migrations
{
    public partial class CreateCityWithHotelsCountView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW CityWithHotelsCountView AS
                SELECT
                    c.CityId,
                    c.Name,
                    c.Country,
                    c.PostOffice,
                    COUNT(h.HotelId) AS NumberOfHotels,
                    c.CreationDate,
                    c.ModificationDate
                FROM
                    City c
                LEFT JOIN
                    Hotel h ON c.CityId = h.CityId
                GROUP BY
                    c.CityId, c.Name, c.Country, c.PostOffice, c.CreationDate, c.ModificationDate;
            "); 
            
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 785, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 21, 15, 784, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 7, 6, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7422), 0.74224981685952973, 24.668252186576893, -110.21701398189316, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7470), 404.53311787609755, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7486), 0.43454983748324882, -60.306146315234557, -35.235811708103057, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7489), 231.1027163445446, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 6, 16, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7495), 0.52678523104552843, -89.619103465958759, 45.220206549043951, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7503), 87.500646844635042, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 7, 12, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7516), 0.71508762796816538, -75.992025149835754, 159.12403645166978, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7519), 401.1119778550871, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 6, 9, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7525), 0.80454180074073578, 14.803768699577205, 50.641858993010743, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7527), 357.05285303835291, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 9, new DateTime(2024, 6, 4, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7538), 0.0043835605183621951, -74.533718861622205, -127.04799036297273, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7541), 373.27375880103392 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 4, 21, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7553), 0.82189195682986516, 69.633182367441748, -177.60241610295697, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7555), 397.32548836068605, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 7, 1, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7567), 0.60157787591544387, -86.06425470416508, -52.218260766194007, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7582), 499.54729204596731, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7588), 0.28362374463374895, 35.871763574383522, -152.84468418311241, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7590), 480.09755340250103, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7598), 0.58800610201370307, -54.387258496578369, -31.356359879334235, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7601), 99.622480920435464, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 6, 27, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7607), 0.74842079254007199, 47.406234695364105, 77.408201773948406, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7609), 260.46950215158455, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 4, 28, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7615), 0.086829936536606533, 13.120585167088223, -44.097266030168214, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7617), 1.2269173631159758 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 4, 27, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7673), 0.76936303863985456, -85.988445835528523, 71.630954450403721, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7676), 251.97365653421051, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 7, 5, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7683), 0.22860884440699858, 59.55643296196331, 25.299100933561988, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7685), 388.87546242228461 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 7, 7, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7691), 0.97217690025485115, -77.746604555515148, 127.9929333103002, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7696), 26.065846480379349, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 5, 19, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7748), 0.56628825937890181, 71.082376443015136, -94.7323843077303, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7751), 209.32599402896219, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 5, 3, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7758), 0.92207913238285932, 38.833801190842735, -103.15170224212604, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7760), 309.53609000999921, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 7, new DateTime(2024, 5, 1, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7767), 0.96955735464853654, -43.70942233091705, -141.32506144856671, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7769), 427.94752664591977 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7775), 0.74711944398085783, -55.184314802700257, 146.14572304947222, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7777), 405.85723217573508, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 6, 25, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7784), 0.85785905830133014, -81.077649813952561, 1.3365957849670735, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7786), 428.00242750007828, 2 });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 1, "http://example.com/hotel1_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 1, "http://example.com/hotel1_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 13,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 14,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 15,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 16,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 17,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 18,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 28,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 29,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 30,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 33,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 35,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 36,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 38,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 49,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 50,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 51,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 53,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 54,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 57, 17, "http://example.com/hotel17_image2.jpg" },
                    { 58, 17, "http://example.com/hotel17_image3.jpg" },
                    { 59, 18, "http://example.com/hotel18_image1.jpg" },
                    { 60, 18, "http://example.com/hotel18_image2.jpg" },
                    { 61, 18, "http://example.com/hotel18_image3.jpg" },
                    { 62, 18, "http://example.com/hotel18_image4.jpg" },
                    { 63, 19, "http://example.com/hotel19_image1.jpg" },
                    { 64, 19, "http://example.com/hotel19_image2.jpg" },
                    { 65, 20, "http://example.com/hotel20_image1.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 870m, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 345m, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 829m, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 614m, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 131m, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 824m, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 407m, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 200m, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 108m, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 196m, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 532m, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 104m, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 172m, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1871), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 10, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1895), 30 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 12, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1900), 4 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 12, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1903), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1907), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 2, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1912), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 12, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1915), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 1, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1922), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 3, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1926), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 3, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1932), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 1, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1936), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 4, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1940), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1944), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1947), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1951), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 4, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1955), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1959), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 5, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1963), 71 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1966), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 3, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1970), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 7, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1973), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 1, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1977), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 6, 20, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1980), 30 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 3, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1984), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1987), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1991), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 4, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1994), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 8, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1998), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 4, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2002), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 7, 20, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2005), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 20, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2009), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 9, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2059), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 2, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2064), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 10, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2067), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2070), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2074), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 3, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2077), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 8, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2081), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 12, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2084), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 8, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2088), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 10, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2091), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2095), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 7, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2098), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2102), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2106), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2109), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 7, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2112), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 9, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2116), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 1, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2119), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 7, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2123), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 5, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2126), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 6, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2130), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2133), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 6, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2137), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2140), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2144), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 10, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2147), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 12, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2150), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 7, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2154), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2157), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 10, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2161), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 6, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2164), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 5, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2167), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 3, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2171), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2175), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 1, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2178), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 7, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2182), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 10, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2185), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 12, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2188), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 2, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2192), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 11, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2196), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2199), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 11, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2203), 6 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2244), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 5, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2248), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 8, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2251), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2255), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 4, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2259), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 31, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2262), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2265), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 8, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2268), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 2, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2272), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 7, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2275), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 7, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2279), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 3, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2282), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2285), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2289), 4 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2292), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2296), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 9, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2299), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 9, 9, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2302), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 4, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2306), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 7, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2309), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2312), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2316), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2319), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 10, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2323), 6 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2326), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 8, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2330), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 8, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2334), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2337), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2341), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2345), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2348), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2352), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 10, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2356), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2359), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 12, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2363), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 4, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2366), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2370), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 3, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2373), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2377), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 11, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2380), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 9, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2384), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 9, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2387), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 6, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2391), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2394), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 6, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2397), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2401), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 1, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2405), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 11, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2408), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 7, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2412), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 9, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2416), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 11, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2420), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2460), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2463), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2467), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 4, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2470), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 10, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2475), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 1, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2478), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 8, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2481), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2485), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2489), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2492), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 12, 31, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2496), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 8, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2499), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 5, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2502), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 5, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2506), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2509), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 7, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2513), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 8, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2516), 24 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2520), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 9, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2523), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 8, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2527), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2530), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 1, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2533), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2537), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2540), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 5, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2544), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 4, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2547), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 8, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2551), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2554), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 6, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2558), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 7, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2561), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2565), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2568), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 3, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2572), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 3, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2575), 24 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 8, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2578), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2582), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 7, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2585), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 20, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2589), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2632), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2635), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 7, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2638), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2642), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 1, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2646), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 9, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2649), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 12, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2652), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2656), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 4, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2663), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2667), 71 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 7, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2670), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 7, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2673), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 6, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2677), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 7, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2680), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2684), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2687), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2690), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2694), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 11, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2697), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2701), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2704), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2707), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2710), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 12, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2714), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 5, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2718), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2721), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2725), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 6, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2728), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2732), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 3, 31, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2735), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 2, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2738), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 7, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2742), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 9, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2745), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 4, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2748), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2752), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 8, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2755), 25 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3757), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3770), 290m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 7, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3783), 19, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3785), 433m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 4, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3790), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3792), 208m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 6, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3797), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3799), 152m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 6, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3803), 16, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3806), 294m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 4, 9, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3811), 14, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3814), 134m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 5, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3818), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3820), 388m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 5, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3825), new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3827), 97m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3832), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3834), 333m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 5, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3839), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3841), 74m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 4, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3846), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3848), 400m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 6, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3853), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3855), 461m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3859), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3861), 238m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3866), 11, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3868), 370m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 7, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3872), new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3875), 88m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3924), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3927), 188m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3931), 19, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3933), 373m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 5, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3939), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3941), 285m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3946), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3948), 146m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3952), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3954), 255m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 5, 25, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3959), 14, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3961), 342m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 4, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3966), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3968), 337m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 7, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3972), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3974), 382m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 5, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3979), 15, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3981), 487m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 7, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3985), 8, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3987), 92m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 4, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3992), 4, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3994), 148m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 6, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3998), 15, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4001), 436m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 4, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4005), 2, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4007), 119m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4012), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4014), 287m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 5, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4019), 9, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4021), 472m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 5, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4025), 11, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4028), 249m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 6, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4032), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4034), 90m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 7, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4039), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4041), 499m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 4, 20, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4047), 12, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4049), 264m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 6, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4053), 13, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4055), 65m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 5, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4060), 19, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4062), 486m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 5, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4068), 220m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 4, 9, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4073), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4075), 95m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 7, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4080), 8, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4082), 285m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 4, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4086), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4089), 184m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 4, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4093), 4, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4095), 339m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 5, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4100), 2, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4102), 61m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 4, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4107), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4109), 405m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 6, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4113), 3, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4116), 342m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 5, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4157), 3, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4160), 271m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4164), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4167), 218m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 6, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4171), 15, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4173), 425m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4178), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4180), 196m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 5, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4185), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4187), 348m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4191), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4194), 383m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$jLeXtFyqoCdNiV7Fd/qSWu0dFy/kSkX1VmBiWhEfC55uFnDTSeRa2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$5Wy/SSOPdNvjUxfpYmLtNueEEPGr9RlqJrTcgRnjkQYRZSXVaJmrm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$KIKb18.pAZXlcAamvIYZ4u8s6qKtdtsBY.N5sPcNIGWfEc60IIJvq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$X/lViKTrYDN39Wd0hGzLCO6IIC.zI/5i2SlHfPGjApxYLPkDMy6vO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$mi4wmD3CLyIHjLesBgl/8.XFC1PRqdZ0CmNljm4A5KPqkaVuczgEK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$bQ7TWPZuIVRz6bMSC0.x5uMbvTgIY68NQjmNSfvIrUUHU86cBVt6O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$JA44SdmAr5ZUVX/ylgr6PePmy7ztDdvWOU/S/UmCmd5LYMNpBfGqO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$w6AQMTbW6WhzC95BvPVEy.jaY58XriufzcVPiFr9jJV1Oaa6/QJ8K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$jdrxBuBmvnzke0ghU136TuEAuC0Wt16quGpFDmJaxLNB7Euw88AOu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$8RWi.dEeRJzi.CmCYnHPZOkOVmccPqB320qQcm0sKrea/OYuGiooy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$6CoyVfuBCnM3YpHqvjZyE.1lsyBLZRRWIoNI5U8w8fFUU9qSnQb92");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$4N3Yh4tqJqK1vkBbXBlPuO820iQ8S/KbAKSAk13lwY0Mhkyv4Tjbe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$3Y4BpTJ01TsNUWBa7dLxRuRAn/xI3T6ajLvLq4IiGbFGIecWkYmUi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$W4WsIkASc7oeGMPG42VwIeZp6fmsRSEMj4C3Ie1pQDd7PQmDGRFJG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$JASIs1qjdYT1X1SFljzW2uVZQm4DJJhOtO0joJc8AZQHeC9.lVVum");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$WrNivF40yIbgItI/wfuGR.pqg88.qKbzRoOxOVkewnqZhYPn0faA.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$OyGkn9dkWk7xd/.sZk3z7eyq2ojZaizxDgeh2.H1walLuG0VatM6e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$HS3U8MSM32uiTfpk19Gj7uXxtRFjquVtl/ZKAiKhsoazBq8aZoYCO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$mfFwRE9OTyrIQkEII/fjduL2P7nkS384lurSeBdb91ydn//Rmj77e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$1CRAEjoLCRZFG/SvXTkP3ulYQA7M3CgoADzdaqBFeigq.e3JBqzPC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$haNd7prY2CksLZyHUQn.LeFZTFyF1g4QiA/x/ZW/4glyAySYyDUNi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$NSOmuGqm8BUoG7U/IMkGTO35JnfyDVIeueM52bUn9hCcxrJxs8nV.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$totpUG5znr5jsch2UnnRauAW45qs8cs0F0CG9x8Ai8XJefEQuEfZO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$3GvF3gjIgfZL2wXCY2C6pO4NH0gqq5yH2daz0kDFMIT1kR5dGNZni");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$136tsvPNreVQFAGwOxcrGubyJAdWkUbjRDIxkYHFhE4/QP9toU13K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$G.2xpwM0tx9xDzl/RDUkIONIx7PYdxSYD.V33uvRubSDDB9THhL2i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$0KklRHR/ko5X7QUAe4ZyQOgJlxDZ73vfRFRx0gddyixFMa8jdC9ha");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$g/5/UZMMhPp6pCe5J1Fcx.bQoM3V63wts4K9WUrsMCIRqoiJV4KAm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$rrV8qOtcL9CF5qRe2LNtuuMd53mMwbBOw.v9B01DH4fV5dQ98GP8e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$xUYTVCZFpHdxkhRizh8HT.ZjaKJ5qphRHxgaWxQOmmW1Lnsa9NjTG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$HSQTYSNUWJ.BqOdkKK1C9OaaeUlb2tsNYgOmCG5oSZ.j0mIzLYdBe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$cMuaZWoYG35msNgRIqhQX.IGoBrAzZFYhn7dnoZ0GFMDmTA3rFDlu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$i10LElfkwIYW0OTCEsmD.Or93A7669QOY7GQ..09o9e4HVV6SzD82");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$TzrrNCyP4jxfHUQSUuTVtOl3atW0HTYE/2jFAuzp4V8VpnkaXj8DK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$pCpaGCJNgR7e3YYwC2HWvOfMVMjSAofNV2AFWzyfGw7J87z157c/a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$dAN74X7aDnOzDNCsL7ahluXj8m8QLK53Nx5zNIbwKh6gEzv.6kQNy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$8K3RCo7BmyPD9kyZgosAnuBJzOl6ZclvJL8HKyvxK1FJsHL3cXxVG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$.ywPQCRZwF11KYPYEWNrS.rA/W/vIi7lV3crEyaEqPIMdk0LMM4i2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$gH0MEQ6gw0YY27FupgV3L.F8.uzcFB5w0ns9smD4qZfln2BqIvBSm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$kOtDBbpO1bTE9Pz2Q3dHUe/w/IDhczgzq.8jI6.RFcOjh0SoLpbH2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$FREN.qTxJtt5TGrV7RFHHuBsu3R.yPxmLon6Wp/pgrDbg1SbzkRji");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$1PcDE.084CMY0kWmHheYCO7znqweWbM0kdgcfomrVxdpWmsqxR0aS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$yG8Bk8swtmlDVwmTeQAmzeWey1aDyejwFIC4MvPvb/lh6MOWvu7De");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$KQlCCu4UCp5YkdB9.SMX2OKZ25V8z8ZADk0hnkmCnTeAo3EhnHIsq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$vx004US08yP9opircqHyt.QsT5xIf.HmxslHlyHgs3lfjVPecgHHS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$kesoHS0ctAkHAtTlstsR4.K4E7PAJTkS1FaFp0JYadZufTMn0LnkO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$El1qKReAk/orQas.xz3t8exPawaBVKfOJJjG.JiEjbE0dwP8Rqlum");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$Tk/b8dXp9paJ8mbjClXZgupJm6lKVXJqKIH0RThXkuVKs8vkaUHCC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$vwt39Frft106TfCmjH4VXue0zJkEmNraEdMNAGplHN5ue3RFmjySe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$ITpuXvz6j.nyCE7ZCYVIgukyzRQp8Ndrxw/Y8N4ovHzY4Vr0n70eS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$hFnUMbCn4.rmpgmo0fs9R.Up.rDbTOkaLSSD1Qd/2MkI95fZTSqr.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$pLyHWFdw2Z8HBTF9SbyhMe2IGmlREnCP38.FfK6cpmtIU05cG0/pi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$MORnyVMfpCtDoZaK9NslYOx6NY7HFAOfHK0rDSSsYV7ycwIUQiki.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$2GCCJ2PCPvbs9Gu50EWYY.HMJVeOR0PRyOoex.Zg8rnp/9w/s2ZvW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$WnzRSnxp5p84hQPghYBrcORaKEHlm2.WvO/8Hpk3WV3EGaTDBIJUa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$vgqB2zF7hPp0weNRtg4CuOzAxCytiNQUhzeYeQRpl35Ocs9Q4YbgW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$mtGzV20khnYOko5fgGW3jezrlQj0e/DnDoMjOTMTK4pBKjgPRRJK2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$t6IztJfiT0JVE3u3LN8SnOr9rysjKsXe44b81NbNOzMxwI3tsQTpO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$n0/pJRfhDP9cnCcFonh6LuALi1x.op57o1udG037KGrJV0tmby7Ki");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$xUFBLQUYLhZ9PNiTLORop.U1qg4xgCgCNr3hgikIJrCksPKJsVDkC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$94ezcsBukDZCty/XGGcO0ecOlz4WuwmWjxQdECVDU4aU0J1hMAX9K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$qZnzqpcjlnlfxcjvyuD.auq2j.ym68l3a2GXGwSlkaAikAjArtdcO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$3VtVxPbKHiOo1iUByVBjD.e2Ix59/yBKtTZNcz144ug2ttpww0bWm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$F4H9.7XJcAddHYGIqFbE6OuLke5aagqo4DWgx8BcGCMfXknJtuwtW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$4XSPy2o8WuSpy1heFhU82e6nkUbEKgLfOJVNWk2hFiAD5R.17AYiG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$NGNuUb48soaJ3Kl/QFEFk.sxV54FltlivxMpIxMmkoIMgyOMdP5tS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$fMAaQkaKc7e7CxDdUGMdPuwGjQfsAdD0qbRb/bBv1hqMrWlMc6ghq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$xj33bFn5sOPBy20DkS.NuOucVr5I499v9NUmjQbFTZc30PYJBIzlO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$8SCkVtsmrow3Uz.vgOrkl.W70sGB.s76BqJ23MoN2Hjl79kymQnGu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$dw7TZuiuZl/BNuXG8QoeW.oeQXf1TqWeLd1.0G9n3gUPpQ4nxst0G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$U2EVWzvFfZHuxuRzR0bkzOCsZD/MTmx/XL2Vv46lfcMUoMz0D5IH2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$vhPP3m/AgQxFXGpg9h7dhew2Np9eLShVfmB0LBRRQuX6PQ5ZnSuUe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$E05KWEE4G/0nBqimScjzH.XOtkl0JF2qz8JZ5DtsEbb8DOIE4yruG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$baxh5dFkxJq/C.SDlrmaOOiYIr1GOTAwzGjVsaBOoABakLOjc3f0K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$AbWrvSizjNZER3lfMb.l1uPJCQ0T/.02MdUxSTKDIEq.0t9e7QXa2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$rsHL85uCATW9hxKRttPkceiA2GzuaFaXbqleVbeE7pRWhF9scpRry");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$vHzXbL3ElM2yZdiSyMcemuOQmye9LLEhNrLrcTKL7EyPkp.Pd8Jc.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$sM0axNGl1eKeO2FXUIwOrOc8QYQWqyqAh3fuBuNMh5VBwFtGTF8SG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$E3t6Amx2MJCUW4KUtOAkwO/wGXs4RzrkjedN.zNGdP6s5rXNbq2ke");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$nBw9aXdT82b97uMdHlB0f.eXWGPBqcKiWr0xnJUaZJqTE.b9O3fy6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW CityWithHotelsCountView;");

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 879, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 12, 16, 58, 878, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4432), 0.54187358297284349, -73.439359019753908, 132.499573658614, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4476), 17.537112787935015, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4489), 0.72071847734267369, 4.5903147072519772, -178.91090980741225, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4491), 408.6262242183825, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 4, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4496), 0.55915001685310106, 5.5678106691130012, -88.023026556951393, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4504), 348.4038695976484, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 6, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4512), 0.9761272157468831, -38.683479513122769, -78.766828854225395, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4514), 358.62141095235091, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 5, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4519), 0.40103554665263219, -19.673971454190152, 7.2723449893031216, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4521), 293.98661685297708, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 6, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4530), 0.70715843239989817, -16.87329677772027, 46.652569357650748, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4532), 488.23785826760667 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 5, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4542), 0.35429449858981177, -53.447174092716587, -161.39501571941838, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4544), 275.56613646022475, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 7, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4555), 0.0028477289949424556, 78.021559446664583, 33.381504547610831, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4569), 179.29667327859389, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4574), 0.40622836845110422, -8.4981532150616488, 121.22897573710168, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4576), 66.31453610142718, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 7, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4582), 0.42281478794595773, -84.006362170992077, 71.147458591269839, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4584), 213.35860334308231, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 5, 12, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4589), 0.95988726779578759, 42.056477679151442, 179.68749966608902, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4591), 37.649807212214725, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4596), 0.76552062859683223, 86.33660178073751, 130.21818428780853, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4598), 112.37283949481119 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 5, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4645), 0.71592858361487999, 30.473579487191685, 78.917612641585663, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4647), 241.47584601910626, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 5, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4652), 0.0055012418824158527, -60.39019243519634, -85.872512731601631, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4654), 71.137051237495413 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 5, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4659), 0.41194693893505685, -56.277968045924815, 179.81302480343868, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4663), 490.05532017056072, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 6, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4696), 0.94284841994875679, -3.711288250270627, 108.18105493930926, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4698), 119.80773245456345, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 7, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4703), 0.41649320244504417, 34.19548836901015, -120.42301736951944, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4705), 189.64474902924789, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 6, new DateTime(2024, 6, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4711), 0.80671683972545505, 68.761105812077062, -78.24089707689626, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4712), 456.86948085093002 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4717), 0.24092542703637532, -25.881199932425659, 172.40391194718143, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4719), 22.102489911368096, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 6, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4724), 0.84164405559311339, 78.771881753362806, -7.0024998858004892, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(4726), 319.07432390472491, 1 });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 13,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 14,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 15,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 16,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 17,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 18,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 28,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 29,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 30,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 33,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 35,
                column: "ImageUrl",
                value: "http://example.com/hotel11_image5.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 36,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 38,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 49,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 50,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 51,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 53,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 54,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 342m, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 312m, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 421m, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 301m, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 829m, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 722m, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 233m, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 543m, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 702m, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 676m, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 560m, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 746m, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 643m, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 7, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8094), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 11, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8113), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8117), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 5, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8120), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8122), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8167), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 10, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8171), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 7, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8177), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 10, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8180), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 6, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8185), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8188), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 4, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8190), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 5, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8193), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 9, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8196), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8199), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 9, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8202), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8205), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 5, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8208), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 1, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8211), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 11, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8213), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 8, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8216), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8219), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 3, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8222), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 10, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8224), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 8, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8227), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 1, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8230), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8233), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8235), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8238), 4 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8241), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 8, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8244), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 3, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8247), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 1, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8250), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 4, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8253), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 3, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8255), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 5, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8258), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 7, 30, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8261), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8264), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 2, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8267), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 10, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8269), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 9, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8272), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 1, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8275), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8278), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 6, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8280), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8283), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8286), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8289), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 5, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8291), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8294), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 3, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8354), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 10, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8358), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8361), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 6, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8364), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8366), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8369), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 12, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8372), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 12, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8375), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 6, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8378), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 3, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8381), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 2, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8383), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8386), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 9, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8389), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8392), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8395), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8398), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 4, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8401), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 2, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8403), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 6, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8406), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 8, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8409), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 4, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8412), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 9, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8414), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8417), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8420), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 5, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8423), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 3, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8425), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 6, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8428), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8431), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 9, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8434), 24 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 6, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8437), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 5, 30, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8439), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 4, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8442), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 3, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8445), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 9, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8448), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 5, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8451), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8453), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8456), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8459), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 9, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8462), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 10, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8464), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 3, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8467), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 12, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8470), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 10, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8473), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 11, 12, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8475), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8511), 30 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8515), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8517), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8520), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 6, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8523), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 6, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8526), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8528), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 6, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8531), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8534), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8537), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 1, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8539), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 11, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8542), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8545), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8547), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8550), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 3, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8553), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 7, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8556), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8558), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8561), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 7, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8564), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8566), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 10, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8569), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 10, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8572), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 8, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8574), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 7, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8577), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 10, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8580), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 3, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8582), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8585), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8588), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 7, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8591), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 9, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8594), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8596), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8599), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8602), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 9, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8605), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 9, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8608), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8611), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 8, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8614), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 9, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8647), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 3, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8650), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 12, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8653), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 11, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8656), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8659), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 7, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8661), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8664), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 3, 2, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8667), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 11, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8669), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8672), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8675), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8678), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 3, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8680), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8683), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 11, 2, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8686), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 10, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8688), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 5, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8691), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8694), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 11, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8697), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 4, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8699), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 9, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8702), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 4, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8705), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 4, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8707), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8710), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 2, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8713), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 6, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8715), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 7, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8718), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 7, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8721), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8724), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 10, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8726), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 5, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8729), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 11, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8732), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8734), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 10, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8737), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8740), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 1, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8743), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8746), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 9, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8749), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 9, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8751), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 10, 12, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 5, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8757), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 9, 2, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8760), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 11, 29, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8762), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 8, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8765), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8768), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 12, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8771), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 5, 30, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8774), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 11, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8777), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 7, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8779), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 6, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8782), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8784), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 7, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8818), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 2, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8821), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 10, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8824), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 5, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8826), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 8, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8829), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8832), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 5, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8835), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 3, 22, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8837), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8840), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 6, 19, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8843), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 3, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8846), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 31, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8849), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 5, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8851), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 11, 24, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8854), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 5, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8857), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 8, 3, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8859), 30 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 7, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(8862), 20 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9678), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9687), 459m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9698), 2, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9700), 228m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 6, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9703), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9705), 87m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 4, 9, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9708), 14, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9710), 463m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 5, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9713), 14, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9715), 415m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 7, 11, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9720), 3, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9722), 132m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 5, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9725), 3, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9727), 476m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 7, 16, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9731), new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9733), 205m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 4, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9736), 1, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9738), 467m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 5, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9742), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9744), 130m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 6, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9747), 8, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9749), 154m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 4, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9753), 1, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9755), 463m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 7, 12, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9758), 4, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9760), 97m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 4, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9764), 7, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9765), 374m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9771), 298m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9774), 13, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9776), 469m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 4, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9779), 13, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9781), 326m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 6, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9785), 18, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9787), 351m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 4, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9791), 8, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9792), 202m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 5, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9796), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9797), 55m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 6, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9801), 17, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9803), 244m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 7, 3, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9807), 9, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9808), 168m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 7, 8, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9812), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9813), 248m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 4, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9817), 14, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9819), 351m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 5, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9822), 12, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9824), 217m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 4, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9828), 20, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9829), 342m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 6, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9833), 5, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9835), 121m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 7, 1, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9875), 7, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9877), 88m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 6, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9880), 15, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9882), 324m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9886), 11, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9888), 376m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 7, 15, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9891), 14, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9893), 103m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 4, 26, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9897), 10, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9898), 490m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9902), 12, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9904), 425m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 7, 4, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9908), 16, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9910), 72m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 5, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9913), 5, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9915), 225m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 6, 7, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9919), 16, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9921), 59m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 5, 23, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9926), 170m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 6, 18, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9929), 2, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9931), 322m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 6, 6, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9935), 20, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9937), 165m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 2, new DateTime(2024, 6, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9940), 5, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9942), 258m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 5, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9945), 19, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9947), 176m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 5, 20, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9951), 5, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9953), 185m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 5, 25, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9956), 13, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9958), 65m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 4, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9962), 16, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9963), 338m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 6, 14, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9967), 15, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9969), 141m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9972), 18, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9974), 172m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 6, 28, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9978), 18, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9980), 254m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 6, 27, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9983), 8, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9985), 158m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 4, 10, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9989), 9, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9990), 296m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 6, 21, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9994), 1, new DateTime(2024, 7, 17, 15, 16, 58, 878, DateTimeKind.Local).AddTicks(9995), 381m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$qhXBKaykR74Q6Z0m5yu/QunKWc3ftzT12IxcAAqcbcx.Jbs5Z.802");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$WF738yPZ2bYs9TcA5a474.wJcBb0IbOqDgP3isJQpBGLn87r0e6zS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$qKoNyrGcgsKy02fw6aF1WOnBbfdwdkWh.63aOJUdX5/KwjXbxKlbq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$5.o9jZ8sFIJE5OfTXk4w/uhjLT/MkLtxQSv00C3GDb99DED6iFsem");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$Z0pP3RFKtlFctrjrFUprMuPjzaionfv2vl33o0iINxCEmKUF3Vxe2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$SK80MLaaTXOHimwuX1U13uTPdpSyeCP/bZmzpuxiihxvWm18OPmBG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$T99bkNfpLvZHEiQ3zNsx5OAHYzy4nJ46zAdg2cA3zqoHCXL/NP.oG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$ECememmfsqaegQbAo2dm7.iKmCAcfcDCV3wczWOYpon08SXpbwrC6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$mqitG72jYkfOrhY0aOIUDOE0eFwqWUWFg./K/BxE95dsqMfGOgVBS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$is5lgK8s.RDDwd7MD6IPVeED5Kfsc1e7qYDt.ugC9GPcmtUdPmste");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$uDfu5uLkyceWkOv/3PIjo.lmIY4hYTUPGZKbiueGgd3y3kvq98lpO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$0Mcqt5Cn9W1bjYW2mvEqHOjZaL/sXk0U9o5HvYtlPK/Mz2Xbbkw4u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$bnlzSYhK7a4rbsLC8pmvxOzOXHhg54VKyLOcS1nIvXDgF7oAMo/nW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$j8IYylCTyJ.hqlau2CfB9O7DXQe/Ch.zHwN1cFNom6OMO133XkS9q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$/tTEXRIR4s6nmwOjFjqWZ.G3DaRT/rxMseM2YS2zyb81e/50B0P0a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$.nGmFCWfmUtf./tWiIEbKuaTpvy11CyG4GG1F5nJQVLtN9KY.ifVK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$0ZVgELAZmcgC7sGRmxCupuoKrf0xUcxDcDln3ZLN1NmmI54COGm4y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$YpCCV/GxBFUBq7Bhla6FjOjWDpdYrXO4/iOTJ9RUTAbsxqGPr51Wq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$tECLercKmFiLUi464e9Xheq/dGHU0pJ8AE68SGc62tDvOWLvGxX8K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$7F.zkqmRlF7YEolHMhhCwe6TziJ61YV81oP5.koBnJkNsjvDcvXGa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$.f8AIZ.LkTyA.tkTDY9NeOP0CsEoj02DKRSUPDGSELhRy.NITjmSa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$P3vBrEY1492VhwQaYn08qe97XDSfsG0Y1GDGDYYpfeSpUXQL3xgMe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$L7RmHovvXbKSO8W9WJ8A4.l2DWV0wpOTH6Gu0unV/5o.aphZ7VSm2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$9Q67TB9L.Edt6wOuQ9fbsOiCQVV3KzDVB0Ua4a3Rer9YlxFc5eU86");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$OHcgW9rgqOBhGjHJDJS2ieJIK.bMtLGGFpXgJ.agUrcEimF1iwViu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$rf/H6PnyoCg2QUxGxTZLx.F8U5BRwl3oFZPkSSXbjJSOar1sGdp4u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$DUUoI3TMkq7NiPusRPo5wO4t6I1tJZLnorGwlOTUMyCpjh2ctXBUS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$SRha6hizYxGX881a7OyBWeS/SCVv/MJz5JpQuzSxOI5lah/TFQKti");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$U8GTIMnWe3BfqrCYEciAvecskaI7z6v9vMAUNwBe9DGoHzkGtiPVG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$hIblGhvFBVrWigDkcZRj1OzY8/T.5iPmLii4SKWE2BqEmFyBHeNZy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$9VVQdJEQXexwv/fEYgnv/.32gdUg5nF4VKq5OLJIy5xzg47O2wdf2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$yNTia3T1eVWFglWy1g4vbu8LQt5BYf0nAgKDLTFWYSKIytqectk5C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$YP0D0bsyWhxbmmKZn8uGOuQJ3KAQiDrlGRVJres7cpzZKdv2Q8iiy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$WeeVgYVbklUC5opmi1Ir5.9iE9VNEwChvn0gwk.2fAXYrZsSqO23G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$Gu74mrbUzT6YUOCoeo5W/eCDf/lSOz/OFCoaNUmDzLq0wo/NoS9Ay");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$m3fozfOTsyWh7edTthJ7yOTyaXY5CGApkag9ed9TaVe0HYIIFf3Ue");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$HnuS3cdx6rjHDVLCR1p.4OG/OdPZymD7x0W5Tr97RMMlfIQCeIWXO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$TkpA63fwYFfqIEZAFgHUUuquYtqRRAnz5XIJiKGRitE4I/GcUxbmS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$9fZGfzAvqUML4sgu5fVem.zmr464AQlvYvNwMqJosNCaoQ333FH4W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$oQbMTxcJGGFWfBsOmzmEheYC0WOsFM7TmTST4tL2mCt1jb8kHXT/C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$bSFxlRwepJLHlrPI2S4ZaeMV3A.LEWjgiRadX7Tr/JvQxqFs0mkFq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$x8/JRVukutIXPocFwKa9UOsisaPjqjmqkv2rW6XYxwKdhx.I8hGWi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$MktTRU0Cyzz0Xqb8SK1pLOQQ6vt6lW2c3BrFpwlKZtqNz90kKRbay");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$jY/b.aG8WVNj5vRGPz92KechBlUEnVrWwScEdol8dWn1w/98Yl15G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$dLVNgTZT.W5NFEzZnHX.yer6MmhS8GjLfkJfMZsSjRKsbmL8yKEMq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$rGw06C9EEu8s9Ep6bRyEHe/rz3/fqKOwCVDAOmFrnjM.zK2IDVkhC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$ArHUlH5NvfqGJBfx./v2.Oz4pit.5/fHBg1RrtDtZYBDS.HvAfsCy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$Y5PMZiVu6mzxmXJV31Jqr.d9hq2ma9pvgcI8IidQJ3b8kvGL4x66K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$CsEgH0zUaiK0e98ufZITmO1K3h3fS3dAfogD3ymSNhBG1dleB4/oG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$dCuCLqZtOihmqeZDK2C4t.yI/BytiBs0Y9QWUm3puxGWaMBZVNkjy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$kDM6WdNqgpSfhDWZ4GqqWu9/WXQjyycxxLIeaGaGB11YP1Cs9QQiO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$53Gw1XS0qkrc37HstskIL.KR4b9In9afA6rE5CGx3.n18Wo9F.Pci");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$5mJsmZ8JDniYSwS5nKI7G.Y4QW9nh.96RAxDjoZV3pzhy39lWQGka");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$uLAMAS0rKdVtD6uX1sLUOOs09IYrILTu6WNRC60OvfNtfSfXlgN5.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$3rtw7dv/ud4RrSnR0E2P5Oqsgu0Hv23LakY6trbVvgdjlSSxcJfPa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$jMo1aVFWxjhL9pzrgJuGK.Vhgs8Jl7Dvf40f54/lucSN5S3UFKLmS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$zxqviVec0rsNsQmPEDxJ7..UYI9QDO4yQGbWmz/ccciftJyGSv5hK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$xzmkSO4uwv9ZzppC3Wn3wu6rU3OK3ZenYRfcAIntWyVcwDF3RovVq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$7rrnaE1.VRYmirVzHtgdFOOh5WwWDby0ILwnQc8Z5xfAp2jyCuLgK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$MpwEIwwsz5d3AmLfxBmANuR6u2Iuc6VmUnwErRcOjIqcCKAEhahsm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$./w4JDvooaIoKKL7oQ2fc.mQcOG9iRI9Q4UT80ci1cMBySlqteGTu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$bIDDjQhSFY23UafURXP7B.JGbUw8QjUyzQtjkDtRjEzNNOu4cuFxu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$T5zuWNzAndfRw99bLM6xfePJGxSSUIYMtOAXxxo006qIM5wLC1NPm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$8r8QQi8DdcAm7g0X.yQ6iegZQWyvN7WIuLIxy191Mfz3JIN08SWuO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$LzkYSad8ECHSBSsfUwZy0.mKEkTKMP31MsuwYRfqh9MEQy7lB0zeW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$FCMssp02C4o6VhSHMAUvceq2p/jkrYscQO4C0dSDps0j2SdSCe8Fq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$pB1JMRO2d46f1KXNDJfJGueMAd6mCn5aQ0ylfG66mJHTNq/92WnBu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$2uurJL7yhKqNKF91Xb7rf.P7LgCe7BDTccFn9RiEVMh5ZAhfkNigi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$eKfJJ8P.WfeyoVZ6M4ROwOMbIOE4fj9shscyqFTanIeAtEZe5ltKm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$2hQYaKtp7Uv8bTPiwoqjPObJj3xc6wmGRNNLQVL6oxSrc2vWvNnNS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$vZays7Osj4i29Vp784ywJ.XempR7fZxdQyswoeagxZEm7RsM1Tb46");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$uMWBmDX4qmy1kobfSrT87e5Gn3oG9VX5pAYoQLM2Z4EJYxIYWIZrq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$BRioEXe7QsddZpsZCnZv4eLb8GOkvoJQ6fWpTgraD8/kXp56sJNnO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$/Zpic/p1BuZZvknpHK1fJuIuh4hNdC2SOBHr4j9aOTB7k9huDGEgm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$iC23R8No5hAgEVW0Po4QluhOVYMCZLOq9c7GATMw7Rb9Bxc10quWK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$Fxwuazqreo9flb7q4PqJT.qObOSLx4EHm0SqU.91htF0JM3mawh1a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$GbulQ1tQPSzxrrzYeyV92O97L0dj875mKnz/5gNnjaWVdWEKltSgi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$o2s.382Ms8KmjiithPjWPO.VRjrUM0OP1jCyXjK6wx6DUxZVU8ki2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$3ATqSrH.YGFAlWVcbOlbZ.aaP4cbRN3/ZQ4sGibtfCDKeKfrBHnl2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$QCNIBwuXo4jGI6tunUgQveiAIcTd6joO/dpkXkh5gv7TKAYhB2gvG");
        }
    }
}
