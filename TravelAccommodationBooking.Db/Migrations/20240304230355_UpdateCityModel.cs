using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAccommodationBooking.Db.Migrations
{
    public partial class UpdateCityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 141);

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailUrl",
                table: "City",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 971, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2024, 3, 4, 23, 3, 54, 969, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9567), 0.89345670382143094, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9617), 356.26662480185155, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2023, 12, 15, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9631), 0.45394728139893781, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9633), 140.51971005014906, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 2, 26, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9638), 0.97636070418988008, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9640), 66.264879727117417, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 6, new DateTime(2024, 2, 25, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9651), 0.26951609891425554, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9653), 113.29116349207003 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2023, 12, 15, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9667), 0.87323571502822794, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9668), 409.64440039629761, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 2, 19, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9678), 0.067162462748156404, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9680), 392.13282292094379, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 8, new DateTime(2024, 1, 15, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9693), 0.70612982542998726, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9695), 107.98667999034816 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 12, 3, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9700), 0.036224878373355196, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9720), 169.32881967492276 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 8, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9725), 0.48747695031311633, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9727), 451.90627814425881, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 1, 10, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9733), 0.65072707589645762, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9735), 195.32617612979232, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 12, 14, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9740), 0.62595194461047132, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9742), 329.31557773959833, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 2, 6, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9747), 0.97703597392823993, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9749), 379.80271985356217, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 19, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9753), 0.69562972198057282, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9755), 77.955958399807841, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 2, 24, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9760), 0.65357525702114827, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9762), 290.49965239745956, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2023, 12, 9, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9767), 0.57716043275047735, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9771), 279.42226641150472, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 2, 21, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9816), 0.97689782075419029, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9818), 271.03711086015556, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 11, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9823), 0.88905455396301292, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9825), 115.53375691741851, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 14, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9830), 0.069983484768699533, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9832), 8.5928076461239122, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 2, 24, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9838), 0.85377274228630162, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9839), 402.64757052149338, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 2, 2, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9844), 0.73194755232471065, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9846), 348.42936318073362, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 21,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 2, 28, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9851), 0.25976087688523808, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9853), 471.15713872007217, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 22,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9869), 0.92280378682408959, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9871), 209.68999542041615, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 23,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 12, 1, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9876), 0.34040722769264031, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9878), 209.2917723217937, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 24,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 1, 1, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9883), 0.59907605390076735, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9885), 227.05243801255358, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 25,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 29, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9889), 0.075680125429476552, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9891), 222.28028279836809, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 26,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 1, 12, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9896), 0.90118840647088694, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9898), 26.804223383377845, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 27,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 2, 3, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9903), 0.33050721001678651, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9904), 144.42320738592173, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 28,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 19, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9909), 0.42007737410450041, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9911), 318.94967493759668, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 29,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 2, 9, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9915), 0.59951408413923468, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9917), 199.08993673306085, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 30,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 3, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9922), 0.40357766438965226, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9926), 134.40933588829586 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 31,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 1, 8, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9931), 0.20156287323083621, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9933), 485.07784986626331, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 32,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 9, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9937), 0.88856391847126992, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9939), 67.570754414609027, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 33,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 2, 7, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9944), 0.51614360513704083, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9946), 475.93575641177893, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 34,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 31, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9951), 0.61853159427381144, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9953), 282.90751560405067 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 35,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2023, 12, 19, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9958), 0.6389818436039475, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9960), 225.37852662465869, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 36,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 1, 12, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9964), 0.42919142378805653, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9966), 397.39473931921702, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 37,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 2, 23, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9971), 0.15451366690429769, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9972), 77.359757580759137, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 38,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2023, 12, 7, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9977), 0.40193976729953673, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9979), 414.79771031616019, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 39,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 12, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9984), 0.79895189649477727, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9985), 282.95840981195647 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 40,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 11, 29, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9990), 0.24786251150058436, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9992), 375.22196226095701, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 41,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 3, 4, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9997), 0.91613801496540914, new DateTime(2024, 3, 5, 1, 3, 54, 969, DateTimeKind.Local).AddTicks(9998), 68.205963858074867, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 42,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 1, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(15), 0.83506916290807842, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(17), 224.59280955494341, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 43,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2023, 12, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(21), 0.63251240438658007, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(23), 474.01536694209523, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 44,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(28), 0.51532053586152748, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(30), 227.3353098366762, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 45,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 2, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(35), 0.63043492229548614, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(37), 369.03981138987837, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 46,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 10, new DateTime(2024, 2, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(41), 0.26607178209612814, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(43), 162.67573336915021 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 47,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(48), 0.028989801934940607, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(50), 362.28483525870843, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 48,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 2, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(55), 0.92456712086588833, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(56), 335.62583677064845, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 49,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 6, new DateTime(2024, 1, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(61), 0.25309418526777683, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(63), 19.083234059624143 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 50,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(68), 0.87320304374958502, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(70), 214.6315334422093, 3 });

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
                values: new object[] { 1, "http://example.com/hotel1_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 13,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 4, "http://example.com/hotel4_image3.jpg" });

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
                values: new object[] { 6, "http://example.com/hotel6_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 18,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 28,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

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
                values: new object[] { 11, "http://example.com/hotel11_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 33,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 35,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 36,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 49,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 50,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 51,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 53,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 54,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 23, "http://example.com/hotel23_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64,
                column: "ImageUrl",
                value: "http://example.com/hotel24_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                column: "ImageUrl",
                value: "http://example.com/hotel24_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 66,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 24, "http://example.com/hotel24_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 67,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 68,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 69,
                column: "ImageUrl",
                value: "http://example.com/hotel26_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 76,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 77,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 78,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 79,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 80,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 81,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 82,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 83,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 84,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 85,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 86,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 87,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 88,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 89,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 90,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 91,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 92,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 93,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 94,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 95,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 96,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 97,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 98,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 99,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 100,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 101,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 102,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 103,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 104,
                column: "ImageUrl",
                value: "http://example.com/hotel38_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 105,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 106,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 107,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 108,
                column: "ImageUrl",
                value: "http://example.com/hotel39_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 109,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 110,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 111,
                column: "ImageUrl",
                value: "http://example.com/hotel40_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 112,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 113,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 114,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 115,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 116,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 117,
                column: "ImageUrl",
                value: "http://example.com/hotel42_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 118,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 119,
                column: "ImageUrl",
                value: "http://example.com/hotel43_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 120,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 121,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 122,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 45, "http://example.com/hotel45_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 123,
                column: "ImageUrl",
                value: "http://example.com/hotel45_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 124,
                column: "ImageUrl",
                value: "http://example.com/hotel45_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 126,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 127,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 128,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 129,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 130,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 48, "http://example.com/hotel48_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 131,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 48, "http://example.com/hotel48_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 132,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 49, "http://example.com/hotel49_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 133,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 49, "http://example.com/hotel49_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 134,
                column: "ImageUrl",
                value: "http://example.com/hotel49_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 135,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 136,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 137,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 138,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 139,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image5.jpg");

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 38.6464205426813m, 144.906154106339m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -31.3198746835922m, 0.649306305191175m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 81.8708333509736m, -94.8876745392807m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 31.5013759160218m, -34.5289776136663m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -38.1761692169847m, 167.691405203523m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -35.3953114180828m, -119.476201763083m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 21.6178223143363m, 75.339622025615m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -67.5110415283927m, 152.615960462831m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -26.2184893943129m, 89.6027822162548m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -8.94620482873968m, -174.515204397694m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 42.4725438051385m, -113.386328287553m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -42.1992419625047m, 172.599287211796m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.4731305892486m, 60.3297593586419m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 7.10300621241073m, -44.304971572675m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -1.01086016979018m, 151.494053847609m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 7.79642539029866m, 130.99454530104m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -31.264891434823m, 166.391245344158m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.3929146458936m, 34.0591975673751m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 16.0409708049363m, 57.4772870289947m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 63.4073804191542m, -90.3641961637172m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 2.9915559338413m, 152.29236514237m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 16.3230683824819m, -168.883765359113m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 66.1598953678988m, 48.6126814492611m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 63.7303188193894m, -140.70562778806m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -5.13774504682587m, 121.045313227334m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 49.0982730658476m, 88.5218223908157m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -22.7637321405903m, 176.932038939667m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -67.1579381228188m, -48.9172448661135m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.967464624636207m, 90.4331620056638m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 76.180228688092m, 32.3376638575194m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 17.3045141846641m, -39.8533512653779m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -46.8358738021981m, 115.420628522215m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 18.1079364965898m, -117.984499402902m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -84.4140298117752m, 63.7721674022797m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -59.5927601790714m, 178.804057770494m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -47.1988322719943m, 151.676805659537m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -79.8313704017873m, -100.622554276712m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -68.2491966303847m, -52.6176469796022m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 48.1256544391718m, -33.1972220872357m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 6.35562511106014m, 87.3131180490242m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 5.51021854149758m, 67.9783733012091m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -65.7113911940939m, -137.401744235612m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -76.0562961882252m, -157.577851088511m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 9.57294243270726m, -146.842792703635m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -8.68460485430172m, 104.905071339814m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 46,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 19.8480756220937m, 118.655296229456m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -61.944237783124m, 119.570379240297m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 48,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -24.8850964917917m, 136.349046954482m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 49,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 34.5444745553746m, 78.0378064132664m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 50,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -21.0076178163454m, 30.3868000048948m });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 460m, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 996m, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 379m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 741m, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 631m, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 808m, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 227m, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 707m, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 809m, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 639m, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 603m, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 524m, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 943m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 11, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5308), 200 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 7, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5330), 265 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 10, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5334), 236 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 8, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5337), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2024, 2, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5340), 96 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 2, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5344), 135 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2024, 1, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5347), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5349), 214 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2023, 6, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5352), 216 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 3, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5356), 148 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 8, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5359), 215 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 3, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5361), 100 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 6, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5365), 272 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5367), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 11, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5370), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 6, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5373), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 10, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5376), 194 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 6, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5379), 201 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2024, 1, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5382), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 11, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5385), 118 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 8, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5388), 203 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 4, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5390), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2024, 2, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5393), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 10, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5396), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 10, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5399), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 3, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5402), 84 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 11, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5405), 225 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 1, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5408), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 5, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5410), 115 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 10, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5413), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 3, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5416), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 9, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5419), 169 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 6, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5422), 213 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 6, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5425), 146 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 6, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5428), 43 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 8, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5430), 119 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 10, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5433), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 10, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5436), 245 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5439), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 12, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5455), 207 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 4, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5458), 213 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 4, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5460), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 7, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5463), 120 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 6, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5466), 222 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 10, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5469), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5472), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2024, 1, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5475), 285 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 5, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5478), 4 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 5, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5481), 144 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 3, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5483), 230 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5486), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 1, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 3, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5492), 136 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 5, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5495), 83 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 12, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5497), 101 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 9, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5500), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 8, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5503), 282 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 7, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5506), 191 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 5, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5508), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5512), 116 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5514), 224 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 7, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5517), 71 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 11, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5520), 230 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 6, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5523), 255 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 2, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5526), 241 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 11, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5529), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2024, 1, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5532), 102 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2024, 1, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5535), 227 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 10, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5538), 242 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 7, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5541), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 10, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5544), 129 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 11, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5546), 276 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2023, 3, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5549), 244 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 5, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5552), 113 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 6, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5555), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 10, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5558), 243 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5560), 166 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 10, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5563), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5566), 82 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 10, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5569), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5571), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 11, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5574), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5577), 173 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 12, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5580), 282 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 9, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5594), 209 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 4, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5597), 297 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 6, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5600), 244 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2024, 2, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5602), 243 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5605), 241 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 11, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5608), 175 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5611), 271 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 3, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5613), 178 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2023, 9, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5616), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2024, 2, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5619), 169 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 10, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5622), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 5, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5625), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 9, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5627), 120 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 5, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5631), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2023, 4, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5634), 134 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 12, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5636), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 12, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5639), 266 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5641), 213 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 4, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5645), 167 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 5, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5648), 197 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 11, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5650), 171 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 8, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5653), 282 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 8, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5656), 224 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 4, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5658), 142 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 4, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5661), 261 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 8, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5664), 264 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 3, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5667), 179 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 9, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5670), 112 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 3, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5673), 150 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 12, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5676), 193 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 7, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5678), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 10, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5681), 185 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 6, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5684), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 9, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5687), 152 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5689), 198 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5692), 137 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 4, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5695), 297 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 9, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5698), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 5, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5701), 208 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 8, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5703), 217 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 4, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5706), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5709), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 7, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5712), 93 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 6, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5715), 225 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 10, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5717), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 9, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5732), 249 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5735), 245 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 6, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5738), 265 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2024, 2, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5741), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 8, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5744), 155 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 7, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5746), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 3, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5749), 236 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5752), 129 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 4, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5755), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 3, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5757), 106 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5760), 156 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5763), 153 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 12, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5766), 181 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 5, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5768), 101 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 8, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5771), 99 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 6, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5774), 143 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5777), 188 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 2, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5780), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5783), 200 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 3, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5785), 95 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 4, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5788), 209 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 9, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5791), 204 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2024, 1, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5794), 108 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 8, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5796), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 6, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5799), 110 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 7, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5802), 293 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 4, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5805), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5808), 265 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 1, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5811), 161 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2024, 1, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5813), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 8, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5816), 189 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 9, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5819), 281 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 7, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5822), 216 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 9, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5824), 147 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2024, 2, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5827), 108 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2024, 2, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5830), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 6, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5833), 168 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 4, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5836), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 11, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5839), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 7, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5841), 264 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2024, 2, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5844), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 1, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5847), 103 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 6, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5850), 171 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5853), 230 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 4, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5866), 129 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5869), 279 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 11, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5871), 99 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 11, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5874), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 7, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5877), 237 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2024, 2, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5880), 144 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 7, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5882), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 10, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5885), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2024, 2, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5888), 224 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2024, 2, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5891), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 1, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5893), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 9, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5897), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 5, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5899), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 3, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5902), 104 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5905), 166 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 4, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5908), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 3, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5910), 96 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 4, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5913), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 4, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5916), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 3, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5919), 179 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 4, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5922), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5924), 295 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 7, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5927), 91 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 4, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5930), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5933), 115 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 9, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5936), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 7, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(5938), 69 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6684), 38, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6695), 299m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6707), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6708), 255m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 3, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6712), 27, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6714), 249m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 3, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6718), 20, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6719), 150m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6723), 47, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6725), 58m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6730), 14, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6731), 467m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6735), 42, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6737), 170m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6742), 315m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6746), 8, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6747), 485m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6752), 41, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6754), 135m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6757), 30, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6759), 409m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6763), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6765), 308m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6769), 44, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6771), 85m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6774), 21, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6776), 351m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6780), 4, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6782), 297m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6785), 43, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6787), 79m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6791), 29, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6793), 393m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 3, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6797), 46, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6799), 337m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6802), 21, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6804), 58m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6808), 41, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6810), 278m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6826), 43, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6828), 349m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 3, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6832), 11, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6834), 265m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6837), 13, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6839), 312m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6843), 42, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6844), 237m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6848), 39, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6850), 370m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6853), 33, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6855), 269m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6859), 12, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6861), 58m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6864), 40, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6866), 223m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6870), 21, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6871), 437m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6875), 17, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6877), 64m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6880), 6, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6882), 377m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6886), 47, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6888), 460m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2023, 12, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6891), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6893), 291m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6897), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6899), 405m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6903), 21, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6904), 61m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6908), 48, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6910), 455m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6914), 44, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6915), 197m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6919), 12, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6921), 203m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6925), 5, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6926), 172m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6930), 12, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6931), 250m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6935), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6937), 425m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 2, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6941), 16, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6943), 431m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6946), 7, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6948), 431m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6952), 8, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6954), 396m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6957), 50, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6959), 302m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6963), 3, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6965), 348m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 1, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6969), 22, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6970), 110m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 6, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6974), 6, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6976), 389m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6979), 24, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6981), 81m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6985), 16, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6987), 261m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 51,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6990), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(6992), 190m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 52,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7008), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7010), 399m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 53,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7013), 28, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7015), 482m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 54,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7019), 31, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7021), 122m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 55,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 24, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7024), 38, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7026), 152m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 56,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 3, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7030), 29, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7032), 282m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 57,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7036), 40, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7037), 354m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 58,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7041), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7043), 82m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 59,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7047), 22, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7048), 269m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 60,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 3, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7052), 25, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7054), 471m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 61,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7058), 4, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7060), 492m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 62,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 3, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7063), 9, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7065), 201m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 63,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 11, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7069), 50, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7070), 121m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 64,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 11, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7074), 32, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7076), 266m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 65,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7079), 1, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7081), 236m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 66,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7086), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7087), 380m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 67,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7091), 19, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7093), 160m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 68,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 15, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7096), 5, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7098), 278m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 69,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7102), 14, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7104), 269m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 70,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7107), 24, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7109), 384m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 71,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7113), 22, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7114), 467m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 72,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7118), 17, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7120), 464m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 73,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 2, new DateTime(2023, 11, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7123), 48, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7125), 197m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 74,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 3, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7129), 39, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7130), 215m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 75,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7134), 23, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7136), 482m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 76,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 2, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7139), 42, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7141), 324m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 77,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7145), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7147), 411m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 78,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7153), 398m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 79,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7156), 6, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7158), 391m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 80,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 3, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7162), 23, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7163), 235m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 81,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7179), 27, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7180), 59m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 82,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7184), 2, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7186), 180m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 83,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7189), 29, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7191), 136m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 84,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7195), 27, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7196), 89m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 85,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7200), 34, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7202), 128m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 86,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7206), 49, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7207), 212m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 87,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7211), 31, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7213), 263m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 88,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 16, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7216), 12, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7218), 155m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 89,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 11, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7222), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7224), 486m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 90,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 2, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7228), 31, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7229), 255m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 91,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 26, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7233), 5, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7235), 306m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 92,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7239), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7240), 279m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 93,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7244), 38, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7246), 341m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 94,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 2, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7250), 31, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7251), 476m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 95,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7255), 43, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7257), 275m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 96,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7261), 4, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7262), 428m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 97,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 1, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7266), 24, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7268), 376m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 98,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7271), 9, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7273), 218m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 99,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7277), 30, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7279), 297m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 100,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 10, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7282), 40, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7284), 406m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 101,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7288), 21, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7290), 439m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 102,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2023, 12, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7294), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7296), 214m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 103,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7300), 11, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7301), 274m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 104,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7305), 15, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7307), 394m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 105,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7310), 35, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7312), 382m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 106,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 1, 12, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7316), 41, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7318), 215m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 107,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 1, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7321), 27, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7323), 476m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 108,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 13, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7327), 33, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7329), 322m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 109,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 27, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7332), 4, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7334), 274m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 110,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 3, 3, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7338), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7340), 273m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 111,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7344), 36, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7345), 189m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 112,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 3, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7349), 11, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7351), 286m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 113,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7365), 3, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7366), 218m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 114,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 31, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7372), 201m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 115,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 1, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7375), 11, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7377), 206m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 116,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7381), 44, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7383), 68m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 117,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7386), 48, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7388), 76m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 118,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7392), 3, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7393), 95m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 119,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7397), 37, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7399), 320m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 120,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7402), 17, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7404), 487m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 121,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 17, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7408), 12, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7410), 120m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 122,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7415), 119m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 123,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7419), 2, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7421), 457m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 124,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7424), 40, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7426), 233m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 125,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 3, 4, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7430), 23, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7432), 249m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 126,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7435), 14, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7437), 455m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 127,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 2, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7441), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7443), 101m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 128,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 18, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7446), 25, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7448), 172m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 129,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 7, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7452), 18, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7454), 259m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 130,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7458), 30, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7460), 93m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 131,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7464), 20, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7465), 222m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 132,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 3, 1, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7469), 38, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7471), 151m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 133,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7475), 20, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7476), 432m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 134,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 30, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7480), 8, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7482), 496m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 135,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7486), 13, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7488), 356m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 136,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 21, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7492), 13, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7493), 314m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 137,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7508), 27, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7510), 336m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 138,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 2, 22, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7513), 35, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7515), 89m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 139,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7519), 40, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7521), 203m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 140,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 23, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7525), 30, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7526), 262m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 141,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 28, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7531), 59m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 142,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 25, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7535), 38, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7537), 69m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 143,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7541), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7543), 253m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 144,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 9, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7547), 45, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7549), 155m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 145,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 19, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7552), 36, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7554), 393m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 146,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 20, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7558), 8, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7559), 448m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 147,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 29, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7563), 48, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7565), 491m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 148,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 14, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7569), 42, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7570), 176m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 149,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 8, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7574), 10, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7576), 451m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 150,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7579), 48, new DateTime(2024, 3, 5, 1, 3, 54, 970, DateTimeKind.Local).AddTicks(7581), 307m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$qAKhZA2HwfJM7YvdKsWud.Ln53Wv/BMU/Oa5V1VBZzSXQs2qH7TQO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$tzNlNfjfDKB/7K6zE3SEM.tqK9PnHcnL8z20tSKP7chpnNA9g.VEa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$m02XxH8RpDkWFYaHpBaml.f2lKerUUI9V/JsQDeu5vmNbFWFvdb3K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$mwaG7SVIqmR/nHzpd/nYYuXqLpY2T9ClpXgLtFcgBH/f5Pc4p.l76");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$klRZMX2LNzRuK44/Yve8VOBmi3dUdjmj0rNqW7bHUX7YQly4nsWw.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$5FFzpt2LtN1MDvuJ9SozTeuOCLyL2JNM.ok5XA.KwduwbHrl75AyG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$iQhhdPNNZlpV4/5V6sMkRuZkliMiHsWD0QcwL76DnEYGDmi6SuIn2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$dsHAFDANOx2pPpOY5iCeDukBRVj8W56K.qClMGMzCyD2AhVsHVYdG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$ODmF1GMz8a5qKNxYOLYpc.ePWxkv2Y6nMkQQS3VDiGgboQdwEJSwC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$Pk8x6YwfvybxSwY/B317.uclwnAQc7kai8atBdpsak0YbxuWggDjm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$h04qxJ8XdbJ5iBPKn4yWrefu/9262KkEvz73tR9VVnU7MmT9U43V2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$Z0rRiFO0tqtakWhol/l8NuJ.rTapOf7QkOLzzrA4n9UQa6iGQoh9u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$dY0y833yqcTKujNvCR5tG.m7nyxMvwqsM56D6slKXdGj5RW6s4n3y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$PcQIF5GrhDbMvkHOmBK2YOHpD8Dw9nzF4DXqok4g4Vgu2QvRTFMTC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$sswBLFlvtimiMf9OPHW44u1oZF8lgDP06GuBHBCcY5WV1QqroTh3q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$kco/t3M4RWO2xuOs9ls7QO7WdxkwPFFUfle.t4Tznr7gn4twrH68u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$6VVZOkYkCPEK27wwYNgyR.JC/7kPHbd0o1Uuq0o9V.hFHLoPk/nKi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$x5k5LWUyopl/Peir3sNMhOmPnx2n9qErGojIW5qPavpy9l3r6ghje");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$AroIrY3zku5zjUjkOJbaF.6gCzLaBeX9nbp2TuFytD3PUbSd2ZC6G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$YMbrw2drE9cQR/uAHzG0TuvQt3ESMuSJCl.jhTuaPXcEegdw0D7SS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$Cf0rWR0z2whzdFLXAeYhy.BXRK/ddbo5rBSOXcKLjcjcNu.bFJxn6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$vs6thxDsUrwxcNIA7e2UJ.G94slzGvWeDrwbHb4vk9zbg3w01jL.2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$Fbqu.vNcOGY5bQHgzi3JDOh89WlQDJ/B2tNZ3XTHV3HEGmCfRZuT2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$1EIrUPwJ2APpC0aJeu7nGOLM7rsc7LTfc7IMT8oTn5/b4N9yIcG9G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$6CgPOkf3fIfRNIuans0u2uLUbODij5pcQu2RZ58ytPPTi0iZTlyiO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$M56Y.tbkPQ/RGnizovHIZujp6vRBhTqrogHj0iz/jAaYW4Td2i2Ya");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$x23HcHW5L0jlxMHz7fYucOdZ3ag7I9Q4Zntaa5HvQBqRkTlW4qbG2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$5aRske0r2PMNYM77zTjDS.16kBIC6HJraCpH0k1KuAT6FywXhahTW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$0Oo1bFk3rQ8Y6A1/sOrL.e/afSLItlWYZvSZnxIhwx04f.VVoy9Ni");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$U0Z50leBBZorP9KnJBwA/uxvJlvQhbJYTqsaW93h/6XPPiyQHVRwi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$.oS/tRj4nuJt7gKPV4d5iejaVjnknqESN.9II98DHfMwrJyYvqqZq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$Fd7H7IdPJirfhxzA7YE61O9AVUg0EamEaGYBhRwyhF7nyOzk5RcZy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$G7DrYWERhri4n8eLcD7QBeoqdk.47UDtaFTWTNLuRujvaBKZV.u0O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$Jo9LkFlCkqCHL8kYBtL6suQybSDUcg1fN/KMt.fhPzgq8FQv8/wwm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$QROnF0LQV.Sq2HTDwoKLD.HA1f1n.lEbwlMc7HmzfAyqtTABj9AZO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$kByrDNNyiAbFmYagEhA82uXG1X/JsqsCLXZElEV6msmDEyneS/WvC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$qjlRq92BfFNaxKs/bo0GJeAaABKx5ZVhJxK3jCB1O6BOSCG7KE90q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$YPXAVVE5GmnERSZLLPCxn.o0k464/qLItqj27QpRiP4sG/JMJQxuu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$/9lOcoD5U16SET.cIObIcelbgr0ymTQqGy/yrhuYpKqC6ve0phJ/q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$A9OKefB1xDrLEhIB0WPG.u1VUDtYE5vPktbN9dOFz84Aw6V0NlBZW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$WME.Ua9MqU5QJfA6C7HoxOd.7eBTkKlyJae7SqJS9bYpL5RoA0qDy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$AE2z8tU1VAEVZQEHqxiz8eYAf0jWjPI6SPOWdHkIGToSgyz2d7qH.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$AeGW0QLT6K5yrp4lqxcKHe.mt3LjlGYvUTV57akqT71Zwr43QS0mK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$Q5qqQeEezAoIYET9tIRL6Ob8Kn.La.ykh.NnwqSTglJ9Ixo0MM3QW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$nFWJSvk9uHgwQHFgi7Mj3Olerxu0LVwAeEiaNxAZNXG1Y4kzxR7w2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$36aHhPrSw9Ls4jJY5kAgd.K1RmOErOmM1VmVblw20lCn7hdp7VJlq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$tJSTK18i1VmAxVUU7kaCSuNRgFlIKt7erYGrCoY8QTArZN4ttPVVC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$.f1nU3CALrWqHIh675OvI.mooLjbVOtBKrR8p4zKdg3WacS.CHe6a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$zQWbxB3Nhcc3iARvNcXv0epIo4H1nzzSquaoGcbyqm8.FkPe6DIQK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$o94ysQuTHx1RR99PHcgR6OtF6GDo2F/CQWwUUDxfUf9xSFgp/m2WS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$lYHAl2VqABvmvIGpNhDDEubcBOGhfhb.TK9MQDKqtONnkqzIsQ0A2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$2YzUcFaKgc6sM0ZhsXhWfu6hWWA.lkMV2tlw/2V3jbBs6DJ87bf/2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$MMEDKdNWrpe9LcSOCgiyGeRiZ2w9NxK9g4GtMNxZErcX8dls070Ie");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$2ZhYZEXazHivxIIbC7cgK.QT7MpadAB6CDfNUW.d0/Bus5b20hTfm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$ShZy/.aYXcog5hUAWcwPxegdq7K.THAZnkeAL26ccFOcvbhLQsbym");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$PVQ7U1ldx3jbv7/iJFjqgeQS/0aQXzWx4KIA4r6AeIQE.AFyUoKCC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$AfSKZzv/o7WwAc3Rz7AAFePxb6BokWyDErLUhfMtgllsenpeOPEQm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$7SzXc7DMjuekg6g9ciKcheVZkHU7M9Q7qiFdVyDCfvMf.NAkpPzV.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$pLmPNAmIuBeAZZy0ikgXyePkpKpUTuoazff/ZV56lrbmtVyNtM5Dq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$anQ0iKVC68VxEGF4f1BB4.l4HIMxa74rbjyGxYqJexXDmGcaXu78y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$7qehnMqKBkeSuPeSjSnumu.u3zyDo2ysfEgDWd8qzT/arKhoP84Ny");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$2yHxJU5Kzqmmlvip8d44ze7bcufwtR1TuZ.VhBPgGDw.MqD4wtF/m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$6CCDED8XqmV.7ompeocJr.coFQzL8w5X3lFm8R04bcsx41rq4Fdba");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$Vr3dC.OwT4iuSguAFGIIPemWtRPFuD4qJOVlMZMCIjQpyuTSRTQmK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$96p6O3KdUA7XQzboshr9te3Dz0wiZ7VHcl18eOBbxfoi4hRHqvBmC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$HrVKTvdid4rxgC83bQ.lWuO2lLc8SYfdNiea/c42uwDAqGuQ7NjXu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$dglzX9ZmziEHF7LuYhA/YeqXoP3G9bkY/HFOZszywLbdxLpubPs/W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$CEqWcqPUwsnPjah7PSfQYeTyKNjxmvlmd3XUarvDgu31Zd0QvxeLi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$B91Tlmmr./1IcBwn1eh/Det.hvi5H6ZZqB6Mw7rZT4baHg4s22/um");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$vzwTp1.LgIUSlzLY6XIg8u4iA.LunD/QHNdY2m/hxpCjQima7wttC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$a.SMlBvFH68Rboz4UaIoxuX4iZdUj6RcGJPFFBVheVEJ7ae6ZWc8.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$hLwDc6kCBc05ceDKXCvqVuS31ZjqhfPa8gF1wY9KtpRiivtLMkII2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$rq3os8vj.YTFayvxqZkGBe/HCYj8sT7BXuqLt7Ckb7w6k1ePfqG.K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$BCXixz1kNYPsI3BAePgvmu5czeWrA1f01ykPYZHL/5.dG7FE7m0Lu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$0YWR8LD6zKG3cYx.HzVIi.6JUNNJI2Sz9ReHnyLeZkYZ11EXrsNti");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$XV5qlxvQgHL17aErllAmp.5q0zfH8IohAjOM8ftwr7cEwde3cJgO2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$/xplI0tmpPO0bgfbxrX4ieJC9ag8Sanz1SUwv9Ns.LjrHus03.rii");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$rteHoq1PXfE8KNRsVHs8J.OT6Zi3bLxKQ18IQ7JFZvP8i6nzMp0mK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$fjgaC83NHwz/WlFVCK6DcuFWg7pMoi.vwtqxIKqeB8bhSQBvwJlue");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$E//mQ/78MQl1te3kUE15a.X2X5NARfTcuCtKc5lyLBwUbBnRRWU.e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 81,
                column: "Password",
                value: "$2a$11$UwYI8Ea1l3w9CKzNjI/lne9zxm.BBszWsgykkPE77BD92H8Aicne2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 82,
                column: "Password",
                value: "$2a$11$yz4.T7SXUv/eBIb5ex2k1OSIQnevTilowf26sT7rdkxo3kAPe/T0i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 83,
                column: "Password",
                value: "$2a$11$6oF4oHM1fR6kK6PSRAoisOa/a1KNqUfgIx9JuBkfGnIzeOO/9kf0C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 84,
                column: "Password",
                value: "$2a$11$.53b7m9Qp.PUR6U677qQEu96b4HCFYSdj937rnH4W0UZCKSDml2cy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 85,
                column: "Password",
                value: "$2a$11$FesfncBVBFa2EQc4EkvrEuBeYdXYIJIghB1/YNlKZL46eG0cU5VWW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 86,
                column: "Password",
                value: "$2a$11$FBBQ8v073FG4ZzD4BIRcQeg3hE94CU4IRttpdLZWaflNAteLtQdk2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 87,
                column: "Password",
                value: "$2a$11$nFmVg.YMl.D9bzTsxtlLC.4oa2nm/wxL1c7.EDCZDYFCmKl2CXgei");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 88,
                column: "Password",
                value: "$2a$11$o0z/JGWrt1I2teAX97ZkS.9qKLHRIANd4iXDYYUF2RZygdgUKBN7O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 89,
                column: "Password",
                value: "$2a$11$wGcloQDNdbyZbyESDsRNy.N/ak5piVaHd6wKIxcMHeh3c7UpDIer.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 90,
                column: "Password",
                value: "$2a$11$JVXzPELWjTW75VDJFo7eh.SsQi8QylpqJowrxtH5w2l0Q77DhLNh.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 91,
                column: "Password",
                value: "$2a$11$QKvuEVI3VjUU6cgTTDD5Eu5jCVmfddv2PX/hFj9gdVnGj.2jrFhO2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 92,
                column: "Password",
                value: "$2a$11$nBNQDvS4Xuy0OSxpuaga5Oy77NGpW5tHLOhRBo/CHaH9TB6JBulEm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 93,
                column: "Password",
                value: "$2a$11$Rs2ERsS9ZQ2KqZnNx0JMeuMMIj742nV1.5p1adyPVQkVMUVY6.i6K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 94,
                column: "Password",
                value: "$2a$11$v7O.ttkzsaZ8LoxUpAwyIe/HKobTNqFOW1gtphskfsXUJsi5Nn9cC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 95,
                column: "Password",
                value: "$2a$11$goX2ql8xOEnvyQMjgTNI/OKnIvHuOtZlOoqcIlkG0WTY3OJL3s3s6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 96,
                column: "Password",
                value: "$2a$11$J5nU0XSZ5gniJMklgVhS8.cJfVWseGCsAfjLc5gNEXU1637w.Re7y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 97,
                column: "Password",
                value: "$2a$11$9m/0EluNWNW4b.8cDqcGw.oNCadbkVF5iNttyajnXCif5MEZoRozq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 98,
                column: "Password",
                value: "$2a$11$XjDvei5d3tnC10aQFWnK/O/qmIWCwKw73JWgrSt/RSOTelTVAuRbe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 99,
                column: "Password",
                value: "$2a$11$EwSMvwnxBtXiP.TTO1Hhx.PEw8Q0o3ljrSHNUHvoQsRbKihoc0G3i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 100,
                column: "Password",
                value: "$2a$11$qUGBlcMjCOigdmcntBm8uuHxrVJ5l6JrTPJvhpA7TjOHUSC/6WLPm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 101,
                column: "Password",
                value: "$2a$11$dWIeItlw6fULFa7DSgBPsuP/1G6OhC81xuRi4rtnAWpFZ/HPtVE/K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 102,
                column: "Password",
                value: "$2a$11$XY0/fbWwBlCbjzPe32r/aOZWsE4qX/96U97drodGpT3FHCjeTpTb2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 103,
                column: "Password",
                value: "$2a$11$aOM/zYjBLXI1rduCAp74ZuDu/g.c2uakrNcGjxxoMFhOtNCOMl4py");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 104,
                column: "Password",
                value: "$2a$11$qPNIM1Dm/n0pvuGVtpxscO0tXmlqmv26PJoygpIm8l6JphnNvP1na");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 105,
                column: "Password",
                value: "$2a$11$mt0F9XdS3N.OhDuyFUNKAOGArmeldEX/TpGTRzRo.Q6TExieKJrEC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 106,
                column: "Password",
                value: "$2a$11$YA.K4n.rogTmIyXHD13cguBSPqp//84HxnMiJSZ/KXdkOMX7owUSq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 107,
                column: "Password",
                value: "$2a$11$E0nMCQ22/M5tPusOr.4Age2qElnyL29tZWfUMVaoT6wI0EbnSsEKm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 108,
                column: "Password",
                value: "$2a$11$t/18NZgjuiZi0OyNOy8cBe0XsF5iWgS/FBrM7gQ.zVDyhtrU9zpom");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 109,
                column: "Password",
                value: "$2a$11$MD2nMHhmq9tWjCgEXIpTXuuNguRx1gJ85Wy..UBzAwNydNQgWayRO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 110,
                column: "Password",
                value: "$2a$11$.2PjynJjZEUxS3YoRc9eAuUFG7hCQzsS1CZ4vIhSObdCW7emXBAjC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 111,
                column: "Password",
                value: "$2a$11$OEYTMGyujzYvJ8zAtpcaMO9yJZ6CZ1L40fvFobE.1JNTQz6K1hCai");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 112,
                column: "Password",
                value: "$2a$11$XG8LSUBCE1zboG4HlxmMXeAkqdxUlsGutZcweSik6iJ0tGhdOAKuW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 113,
                column: "Password",
                value: "$2a$11$nUp4C9Owrtjv57CLpgwRk.74oXzd3tHoppAHTrap3JEbfhc3KeZnq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 114,
                column: "Password",
                value: "$2a$11$38PQ7Jm0Ymgj4L1QsNUjHOdnpV.e9B2DXdgKpiO2SHBQ8HGGPynOu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 115,
                column: "Password",
                value: "$2a$11$tZ251H0VEceF01SK/haCHeed2HADr3Sq4lTyJs3leRRPbL2jzyBHW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 116,
                column: "Password",
                value: "$2a$11$oPahL6K1NxrBmmf4Bf9Squ8CpL4dJdEB8k0cjFVHlXJFP0Ypx483m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 117,
                column: "Password",
                value: "$2a$11$cpxIlb32kmTTDp/06N4Il.X/EtCwULXbMY21pP/xaFS15H5h8anzS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 118,
                column: "Password",
                value: "$2a$11$WB/uFMAPNDvu4/nzHJt0oenEHYG4G1TBuJxLf/byofJvedrnzLW7q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 119,
                column: "Password",
                value: "$2a$11$hoVe5Ic7WUCCHxaB7P4l3.BszdEYczfshls1uCHd3WsBloD2kOgb2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 120,
                column: "Password",
                value: "$2a$11$mIX1KDVzSY84dBI1Pi8nqOnmgyBnKCz14NUCiV/u3R40P8HKzejp6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 121,
                column: "Password",
                value: "$2a$11$d5QD5WPUgS2b4C43FmpQ8uIzaGuGYs/f4EyGRgdv4xlLnuD5ACklm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 122,
                column: "Password",
                value: "$2a$11$ezFiVFGtbEVXhk78ASykJOSx1GWjjU5SvMAjsZeUbdkRE7SYkjxqO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 123,
                column: "Password",
                value: "$2a$11$DPUW27RdtBF2aynBB94NEeFicpPfr/yH0leGjxP9eGvqTdXxjY/Em");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 124,
                column: "Password",
                value: "$2a$11$hwPKpxhpnzBzzkiJemHK8e3agYkUS6eiAEKksu/nSVD2SQjypRIWS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 125,
                column: "Password",
                value: "$2a$11$Y19E1p7L.9hH8.nAIYKfAeLue4zmp4Gush.bMzY1pdHDF1yFfIIea");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 126,
                column: "Password",
                value: "$2a$11$Ff2L0Lq2RFj06aVRdSNDc.T2p4Xf2tfvOd93uL18LyN79GbB6tPUG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 127,
                column: "Password",
                value: "$2a$11$HbFcHjQWOcBsL3Q9lignBu7nZSK/jwHV05MUyzvA0bUTi3goB3usW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 128,
                column: "Password",
                value: "$2a$11$ABFDjpRSAU9Jv1c9Z89HcOZhkrUkPnotlYUU9PBRtVNXoArHdfc/W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 129,
                column: "Password",
                value: "$2a$11$KGkLsyshj25KtrdS/.NbEOXPSu0mO.yO.Dxgzyt2wtljjU01l0Fnu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 130,
                column: "Password",
                value: "$2a$11$tQxvOIpNYR/kNpfggBFbLe4GlIx.MCaWoYMHd1TRpSPeSmrX3rKf6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 131,
                column: "Password",
                value: "$2a$11$xC3njeQ3YhyIQUrWV6QRQ.4Ri5qrOERZifdy6x5UD.WYO04gi17pu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 132,
                column: "Password",
                value: "$2a$11$oMg0XimFQMyMga4wRVaxN.Hp9B.QMgmuc2VADvCPPLHtuTMdsgQ3O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 133,
                column: "Password",
                value: "$2a$11$IcUQo8SLQixx65baCyl91OloxCqyE/KXyUXiIGqZ8iZ8aFyZpvbhK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 134,
                column: "Password",
                value: "$2a$11$0Cn/BbWaS/.Z/7TXjuVmYuxnPW4bErXZv2Wz8KaNiNWEhCw35dAEG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 135,
                column: "Password",
                value: "$2a$11$XlcLNW0BhIKOV0qQFfAtDe1VBi9..OVZoRXS8ieznuXnWf1Pn.ddS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 136,
                column: "Password",
                value: "$2a$11$CMcilzPmcy7qnnCkEi7rWeGNMhVi1ASxVQ164kKALXUWpOGBnu21y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 137,
                column: "Password",
                value: "$2a$11$todw/gKHa208yppWZ.dN1upJF8Bebm0TGe2HgsvEQvtpu40N9Cdni");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 138,
                column: "Password",
                value: "$2a$11$.zuRjJSxaYEj3MsfbSMAmunLwhb4YlRP7L.hWQ0xjyGmn34UP6sD6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 139,
                column: "Password",
                value: "$2a$11$ewPoEDcVSSVjyxtopjVnjOBrJQKd9FcEUfsH7RGyZL01GIszTjHIe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 140,
                column: "Password",
                value: "$2a$11$kNfkBK8rMCsHhLvGBWc2ou4nXcSgIwTv1kAmCiqtCICtdXoe6vVJm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 141,
                column: "Password",
                value: "$2a$11$rJjOieGmFlbHrOHRyaZJmulgrfylO7CUCP76n229Tr/YzDAQu2E6a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 142,
                column: "Password",
                value: "$2a$11$b1bRdtehMVdN1AZ3lIY8WOmEVPHojZ9GG42GYtTR1t3MD9atmzHha");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 143,
                column: "Password",
                value: "$2a$11$7meIU/bnb3sEiJaaWImVz.MTPfuXADEUKD0YYhIIzHf/Su3a8jSuK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 144,
                column: "Password",
                value: "$2a$11$WbjMNnz116RPn47b7MWXBepKGQbqvhY8rTpg86xl9U1Jp6Nfr3eBu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 145,
                column: "Password",
                value: "$2a$11$J2tnSp0y3OPAtR2imLJdmOvEF6IbvVyhQH0xEy.MydyCBnQ054EAK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 146,
                column: "Password",
                value: "$2a$11$Oj1KRi0l3D9BFml8Js1ToOeBX6n84ohTeA.N5FEvPs6MtxxaHd.JS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 147,
                column: "Password",
                value: "$2a$11$BFuSJAl3Htevb5UXs/cNPeuyQjneoUKeERLn3NVAPgYBGryMG7p/W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 148,
                column: "Password",
                value: "$2a$11$Ll8vLo0p4j5qN5cU.PDD.OeE7GeoME4PtubvYWaHc0N2F5FpbdV5W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 149,
                column: "Password",
                value: "$2a$11$m.ZedZXwqFbU2.NWu0kBC.UCDOWO6yI5dClm9vCCkj3f5yJ8hqDSy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 150,
                column: "Password",
                value: "$2a$11$4QRaKnFCjZ07kyapBiuNHewlvE42ZP0hh6aEqb5nz2EsvaCivGTvG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 151,
                column: "Password",
                value: "$2a$11$g0DyNlmbcqUYOlose/QLAewCQsvdYKnHyT4YWKvXQ3YSCOlgMB5hi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 152,
                column: "Password",
                value: "$2a$11$glG.3xx/MmdfcXnWVdEKD.1oyJBONbPO7RiYhFUssJcG30FMSVcI6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 153,
                column: "Password",
                value: "$2a$11$UwzvvpTRPPQSJfYamMlwiuIArG2lYQ8pjkR3aD9J0RSwWuzOSNTlC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 154,
                column: "Password",
                value: "$2a$11$vPOSZNKXUaGOw7JhfI6NfOLYHYcQLk5kfSzQmntxH/qYE/WsM13um");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 155,
                column: "Password",
                value: "$2a$11$T4NKjvXFJnLiFLvurexc4.XnzcVurKELNjJ0QlF/qTfZtG3e5SJEG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 156,
                column: "Password",
                value: "$2a$11$pvWjFZO28o0VbdatoURdDegXzOKsSqrQK9p.VU4xwram.ql8.oo.i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 157,
                column: "Password",
                value: "$2a$11$E7pTM1Fn5p6iNYF.kzeY9.uNJcUvP5nPmM43ZPOAMWhRJ1jYJjaF.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 158,
                column: "Password",
                value: "$2a$11$uYW8czT8YhFBOkJjiWIqgeX97CFOtj8A6P1m0HVHyDTAJZsdYoT8W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 159,
                column: "Password",
                value: "$2a$11$g//rVJxnOt5vq5ejYXqvtOnhMSshkF9xruhOsCYW0TOLRtbHS4k/S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 160,
                column: "Password",
                value: "$2a$11$ITSMe1EuOFRemmEQV9Y2kenWhKqtd0u.UzdPLzduHgF/46PjMo8vm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 161,
                column: "Password",
                value: "$2a$11$075GjdJONeCgsvX5QfK8/eeRQp3v/AU9xSE4/pFC7GBdj24e1i8W6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 162,
                column: "Password",
                value: "$2a$11$..lwvQnG1XzOLrOwQJA5/.5Vbne1W3mxPoVsHB3iXz6sFNH4DoZXK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 163,
                column: "Password",
                value: "$2a$11$5Yn1Wi2m7DZcT1XjBNCkY.hMEA/nbIepKYNSfdvPcnjWe01rTqLnm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 164,
                column: "Password",
                value: "$2a$11$jZZAWm0R.OxOZmzcg9KT3uDCuN2cL4YBX8LImw0jr.BkVKmIV5Ebi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 165,
                column: "Password",
                value: "$2a$11$p97ki885NGQ2gTz4Ll/Yv.De4WDufIWN3Su9Q360Rv2i.S2JfWMcq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 166,
                column: "Password",
                value: "$2a$11$BjDBN6bA9ql6gscGWkBvie7AZImoceOpYITVCispO5ZdTsw/QoAFK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 167,
                column: "Password",
                value: "$2a$11$6/yr00Y9uqVD0E7G0jwqRug1kJ97Ksr1qamB2CTwiE3adp7Q4ZuYi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 168,
                column: "Password",
                value: "$2a$11$1xpizKk9JEbBJH92DwGQIeRx87LQU1tyfZeyaseIfL4Q3qzwnSON.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 169,
                column: "Password",
                value: "$2a$11$ZHGGg9sjTu2DIGPUC5CoVudFe3y49Z2m19F/UuXm/acfyqK2csmSe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 170,
                column: "Password",
                value: "$2a$11$ED01/bKfphBbdJGL/ZNVPuj9zZDi5.m3P0IzLItU.lE.DnXZFeDvC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 171,
                column: "Password",
                value: "$2a$11$Dkbqeo42eb4hgrvX3R4PfOh4FQud8ExwkW/CYmyz4Q0lq2K6vif8i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 172,
                column: "Password",
                value: "$2a$11$ORlXAd36mcIRDIeZc.HWOuwcXmiH4/q1/r2iat0ZmaHl3R4/4/mNa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 173,
                column: "Password",
                value: "$2a$11$7pXZmAYdYsjCCIDbbG8hquegEoZb1uAsIPy7.cg.cCtkaYK/GTz82");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 174,
                column: "Password",
                value: "$2a$11$0cB5LpFrJl6oH5LaDfhrPOCXKWd0b311xVB.gDCmY53yZeCsSW/Oe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 175,
                column: "Password",
                value: "$2a$11$PFc8QDpm2hC30nlpCHSDpOcGgjmYpuDvnDwnPjX9nu9ZxAMc/9NLi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 176,
                column: "Password",
                value: "$2a$11$BfmSwQmnOQyaeVjNWudPSOwnnYkE6sCaXnBgCq4jdv5KBZ3QunWgK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 177,
                column: "Password",
                value: "$2a$11$EYe9IYa1eKt37ZyohPljeOW4gEhtZYhn6cG4bFGjDS35qFHU3YHoW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 178,
                column: "Password",
                value: "$2a$11$cE0/mIsTWUbGM4C40QnyBeqasopfhVOyVu2wzXbrD6Nn33IPLNhGy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 179,
                column: "Password",
                value: "$2a$11$RoSyXwg6jAzZWlpg6e5ydOwajj3URb1llZhXcLpaserfJ4ftA70kK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 180,
                column: "Password",
                value: "$2a$11$ZayWHxdGbngjc4jj6qz5sOnkFMfrjM39ZBW6DJcyhlJgKxZCb1fVC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 181,
                column: "Password",
                value: "$2a$11$G.HE2ggDo4.iOUIYW.CZ8u9yAaewsazlDuPxa68fo4/lhBKUwfUcu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 182,
                column: "Password",
                value: "$2a$11$Rbxs3mgBm3WIxr4rPIHXQOLspy6Lm3XgE60j17AtSPB3J2OszO6xi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 183,
                column: "Password",
                value: "$2a$11$puWVcYTfMtk5.qOHgrokU./bXnop68pBbpJWh7/bK.bGoA4C6Hf96");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 184,
                column: "Password",
                value: "$2a$11$AvIbIqoPgnlpoG8DdDrlKet68s3NbXyZ4r1zO6jkfSya/qeuJiqDq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 185,
                column: "Password",
                value: "$2a$11$nXrwhtNHcKzOxBn119MVHesOPT9cJqlwHID7.xstqAbCq.cfE5p/i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 186,
                column: "Password",
                value: "$2a$11$eNz6EbcjmPiJx4RN7e0hDOJrz9J08lTooW77ZREBRAg1g3aZqtu2u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 187,
                column: "Password",
                value: "$2a$11$UEc2cqFmFxMfOcZiryO5Z.aPg.t79SFzs8c7stroVGTrwES7cqCES");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 188,
                column: "Password",
                value: "$2a$11$rgTntrq50NDTwKyj4dwG3Oacy2X3OgJvVW8cDNw5Geyy6BRbUs17u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 189,
                column: "Password",
                value: "$2a$11$ZYNAnSPBsfRXs7bA9SGUWO8x7Ne8DBZpL1rDyTklohbKimLF/CEmq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 190,
                column: "Password",
                value: "$2a$11$II8r1SS04wgT8JXMzos3r.CAAjeOAPQVLcNxC0v2O2ATnseJWwb7K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 191,
                column: "Password",
                value: "$2a$11$Aprg1OHc8FTNc5Mq/IuZiOAXklDZxR0619hVD.ZetbVYBuQ5smhVa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 192,
                column: "Password",
                value: "$2a$11$ZgWWh51zLhx1yUDrshJr..14qIYKOFeO/whlele3H4irPe/pn79Zu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 193,
                column: "Password",
                value: "$2a$11$ZRVXAEW831cYf93dPJ/i8.UdpsGqJn31qRNwd9U80YLxxEgU5cAlW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 194,
                column: "Password",
                value: "$2a$11$k0FpWcyrtOBBg5EAnEY9H.fLjPm2BrCnwkixnM5LImG3lmlfrG9E2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 195,
                column: "Password",
                value: "$2a$11$zeWKokF2psNSRg8yQfW3CuChr7A08fg78BGORxfYMAV8XHp/Ubs6W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 196,
                column: "Password",
                value: "$2a$11$GF1mJBXHcbKc78y61qy9U.TkZodM/L3Qv3AQZvb9fr/Ss6XqTwqZW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 197,
                column: "Password",
                value: "$2a$11$pkcDo3BxjqpjgI/NXyZPLOZCrQM47nNyV.tU9d0QohQMPezrlkEKy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 198,
                column: "Password",
                value: "$2a$11$IXnl3tmKcdyDe8/Ex3eVOeoau3eVzrAr4lGT2SBzoov6ILGezOtuS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 199,
                column: "Password",
                value: "$2a$11$Elqf.TlIWwtBQwuwQR2YyO76XGzCCBHWUaDniacRu88MUacJ22eFa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 200,
                column: "Password",
                value: "$2a$11$xdF3C4g8mdZ3LILd4.sxues1PwWBAPQG1iW4C6PNP21AYRvFf0dRa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 201,
                column: "Password",
                value: "$2a$11$BoZQiS/iL8Tn7Cve5bUviulFQmz9InNZO1bvkvp./8F0hYm3oROva");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 202,
                column: "Password",
                value: "$2a$11$JMYUCCEgcVUcMjsRTMK5W.M/4Kqbf5kf/t3fpGaOtI1LvKh0TQ5oe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 203,
                column: "Password",
                value: "$2a$11$1pW1JYNOc9CdAGC3PTahiO90XA2neTKtAysYM99O7qi4QobqGoWYu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 204,
                column: "Password",
                value: "$2a$11$TFREx0vJsdzyau21kwJhFO8MstASJxm.1lHlUXYYAZQbd0j89sqSK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 205,
                column: "Password",
                value: "$2a$11$RCuDFytTrQUvu7XsRZt3oe5PcUs/qfcA2Zu10oxdaVOsYvhD.3Gr2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 206,
                column: "Password",
                value: "$2a$11$tKhoTMYDXVmbsS271uAlDer2WmiKUBsMBbAv.rmhW2X6nAFbAe47e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 207,
                column: "Password",
                value: "$2a$11$1dYFAoF1bC2w2kITpU0HhOLt4CaG0ouVjXkf5m0vLL4tqG2DNJttO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 208,
                column: "Password",
                value: "$2a$11$CHeeu1wkHrfm1ingfdlkzOarUe8FgIa.lB8mHSqgDi1ay2brqAdP2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 209,
                column: "Password",
                value: "$2a$11$ekbzblx3eSToOJT74kiOMuoQ1S5C7s7y0xSFyNCR.gAUpYqAGY0cO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 210,
                column: "Password",
                value: "$2a$11$wgMlqVNEYCzfefYN5RfXA./uood/FNRRlLtSsrv9BjA2eK.DlSVTy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 211,
                column: "Password",
                value: "$2a$11$lc4fVI5OxE7j4NvkjLEUUu1tbrOmHZYMJZct69jn6G7Zl4DYWsC3C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 212,
                column: "Password",
                value: "$2a$11$yVoo63ddh1fhk33kBTjAyO7yDDpILDce.bc0322UGJo.vMTWBc5yy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 213,
                column: "Password",
                value: "$2a$11$hRQ14n3cmelD379FCnNMpu7QRIazn7k29USidpM3s5Bf47AyrhHGq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 214,
                column: "Password",
                value: "$2a$11$DHP.SkcYSJ7TkXLAFSm15uo6Q39igysPOWb3JGqBV6FTk5YuMA2Gu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 215,
                column: "Password",
                value: "$2a$11$vw0UgN.ws8wVj5rSTYpNbOVpBp7tK/vH1wvn9/m0MMbqoHCdVTwaO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 216,
                column: "Password",
                value: "$2a$11$mccMEpvldlgQFFN4gIKWe.LZD3UXD3WyDSHYaK8RbKuMNTjR1yx.C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 217,
                column: "Password",
                value: "$2a$11$PyYW1OdS19ei1d4Th2qlCOcQcEhOm22PUN6tA/8j38jhLBTFk22wu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 218,
                column: "Password",
                value: "$2a$11$g9GQyL/wAlfSH3ADsTqUSOMpfAX6jPr1.ns/J3WJrgg5XsRXhfBR.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 219,
                column: "Password",
                value: "$2a$11$CSUKu8Rao5e0sfxoYjCureUfpGpwSLQpENzM3wD2reyn8vy89D4bi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 220,
                column: "Password",
                value: "$2a$11$enmB5kwLxHtvGQ7hLtsgeOS2vso3ozU.73S2uAGf5AlXA6R/lPGva");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 221,
                column: "Password",
                value: "$2a$11$ixBdez7vvFm.BDZFgdFrGO8SU7VWGGhs8Y/jUedHxmZGnnKMpP3C6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 222,
                column: "Password",
                value: "$2a$11$IN3/FgcVnL0LA.ZycsZjo.AUzjaLByoiIXDJbALat.4igdP2rjhGK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 223,
                column: "Password",
                value: "$2a$11$6g76NxgfR7boNRNVrffWl.n0.wo91QeQMdmOgoeaQ2NM5DqcCrCKG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 224,
                column: "Password",
                value: "$2a$11$HWd.qrzArs3puLZQL1L80.x45eYtssViTc/UAv2Qy0dWH3xJW0n2.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 225,
                column: "Password",
                value: "$2a$11$ff.EBGlSg5qo6jvSjScJMeqeCd16mu3ATcj.29RwXy7lrzIeCzkgi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 226,
                column: "Password",
                value: "$2a$11$V8h6NIHpouPJ3WvfKsfLTO8JR4XgqxZ2UTEWD4sf.bGvuEjyGeL2G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 227,
                column: "Password",
                value: "$2a$11$O93SCbjP/Owo12IIJoTSJeUeTVncbwA1.1FMzcdILsovRlfAMXGPq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 228,
                column: "Password",
                value: "$2a$11$oA3joUn..5EEjCxDLxCla.iMEwV6EAW/SIOUoh6gTo/AWkEflMR7S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 229,
                column: "Password",
                value: "$2a$11$jssgTD8aX4UWIQBkZzht2e8mKwaGLoI9UaL3ZVdan11JQLXPVXxoa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 230,
                column: "Password",
                value: "$2a$11$/LW4lPsRjKVGEr0Mnea90eGWvMdFA6X8qI7vl7QCOnt8ALKQkC/za");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 231,
                column: "Password",
                value: "$2a$11$bps0kPlI3DPdYsBILQ3fPuKgMDHJ5I65jS1rxyUcNjFLWFQyHnq.a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 232,
                column: "Password",
                value: "$2a$11$Ajrfx8k72a0O8nOW5Wgd2.jJ0wphD4gP75qjgkaNSdzAV1/Z5pRqS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 233,
                column: "Password",
                value: "$2a$11$E67Snbl9APgsWlzCDggHXuKEqqXBLg8.WC2ro3ZV3lWeNdH/LcCPu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 234,
                column: "Password",
                value: "$2a$11$mnHYR6j7fQVfjKSMJmim/Oulb1eACS0sQ2mFYgshyeCL4SB84Lmgq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 235,
                column: "Password",
                value: "$2a$11$ws5Ret2bKJfWawLJKofG4eJzJL1amKPqUGdbRFhXbUDHS01xtkQKW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 236,
                column: "Password",
                value: "$2a$11$FPJZ1BjAr9Ru8FQG50HnpOSNkjdGs6pJEZasQvAi7.vSF76Llc0SS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 237,
                column: "Password",
                value: "$2a$11$5swjmYXYOPxkaZXpkKoQFuS0meNofAd05DzU2kkNPaNJzi8XG2UcC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 238,
                column: "Password",
                value: "$2a$11$EHUsjF98X7vwg6kUgLXzkuLEL6/NMIiSJG4.Xl4vpv1N8DdUYVU5m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 239,
                column: "Password",
                value: "$2a$11$2HlwCpxu79kG4KokQmHZi.NKSbehiV.28W3s8bCccw3p4DMZfGRR6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 240,
                column: "Password",
                value: "$2a$11$.5prYEJb5b0YtCZNsS5sQuwpdJHXlv7P46xTTKYe0N2Zues0KJJgO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 241,
                column: "Password",
                value: "$2a$11$7.rCWwOZwtPgSbATRPsvauhN14LJYlM7MlzdcVEzkWxw0tyZZVVeG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 242,
                column: "Password",
                value: "$2a$11$lE10vOjJHfpD8wNLVxC1pONqx.FdtMXSiLI2jPJQGKxRGxSMWrs.S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 243,
                column: "Password",
                value: "$2a$11$zyOQvz0esGXjaC7A5hb9cuVdgh87MS7/0zuoD/p0n9soGYJoiXbqa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 244,
                column: "Password",
                value: "$2a$11$0clqammoelAZNZ6nh06zHOGDuwYyHVCz.UPd1i1yC8s9zQzzgO0HO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 245,
                column: "Password",
                value: "$2a$11$m7p9UqXp91oBD7YaqXlSMup9VnVXzoj76blE71mXBdE0UwCcvWirC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 246,
                column: "Password",
                value: "$2a$11$.1G/Htc6KvPWOd2zDrS.k.3dPvvJ5QFf/.bDChKKM9XkIZ/9yYjd.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 247,
                column: "Password",
                value: "$2a$11$hZoYWtNi0.TTC3ru4gmQe.4zcRZf0Pi7qGZENrC6uu.ADecP1vU82");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 248,
                column: "Password",
                value: "$2a$11$1LY7CCQX2lW3RbKRl4TjxufDz1AE18b5jYQlC0S92zdMFvdONQHsO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 249,
                column: "Password",
                value: "$2a$11$4P7yBStSxBSyC91X9R/qwOlkF6n8gSheYU8B8qjPoF6h8.DIZoKHy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 250,
                column: "Password",
                value: "$2a$11$If/a/HYX4b7HxZnOHyb1p.fbYkBMwdbLfs3FDPsXnioYhvxonUg9.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 251,
                column: "Password",
                value: "$2a$11$55agF7HmlPEx0V/qg24OvejjsyJAMhNIkQDH35jW/0ylF3.8d6I6i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 252,
                column: "Password",
                value: "$2a$11$bHVXvAvlXnyJ87wCf39uzei1f9UPLmN6Zg2AQudGUjP8DVxi9xCJe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 253,
                column: "Password",
                value: "$2a$11$T.ECCWDZtCGG7F11L/q9Z.Luxd02GLdcDaJtoOoHOLTEsn.XfXgcG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 254,
                column: "Password",
                value: "$2a$11$xqfnOgkcM.ZqajR6P94Bne3FIuGUpdPr87Ok3S9T3u1OJLnlpIpNO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 255,
                column: "Password",
                value: "$2a$11$gpuRc87WmMgCF1V7zwaHuuGU77zOmBHDpfzZIbBGfZG.p4Uh03RIS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 256,
                column: "Password",
                value: "$2a$11$Q5GfVmMHkNDLgfeankZj5.dKcBgfRXLBfCTaKSl0tDHLDP72BhhAS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 257,
                column: "Password",
                value: "$2a$11$vmlLgpWJQtUq2lNFUyfAXOsYYaNz6Bn3h.Y.2RjY439xkVEnOsISW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 258,
                column: "Password",
                value: "$2a$11$r9/lBP57O2oFH3rmZoidy.xzdHOF2bCHwBFo2MmSe4NwmQFoNgYjO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 259,
                column: "Password",
                value: "$2a$11$vTRNuLuW1hp8jWd43EYm2ubQeI0OItpB3uGhOJEkmLSqjoWMxI2ua");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 260,
                column: "Password",
                value: "$2a$11$t68mphgYCvp6kwtGZZvir.idCpB8kleR4DJ/L5TB6h5Pk4.v/GYVa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 261,
                column: "Password",
                value: "$2a$11$lKrHRYQoFcC8A.jm.mCfSOjj9sww88pIui44xrLC4cty8d0RATX.O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 262,
                column: "Password",
                value: "$2a$11$GY1tEKajsJ7knUbrYd0MYO83QS6ScSdoGVSfLTdZIKwFuJCTdkblu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 263,
                column: "Password",
                value: "$2a$11$6LDq01kdIO4sCrJrOLQp0O9ST8Q2a7mqEzWTbLCWPpNK6HU8tDrDu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 264,
                column: "Password",
                value: "$2a$11$S08pFooNAoWMpNOI8inBcOmgdUXjtPyZEtRCjoyAtyvHH8Ev8JoW2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 265,
                column: "Password",
                value: "$2a$11$NyZcHq./07nB7i1LN0hL4u60PQKZnMxotIndkbVfVF6P490igFcVS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 266,
                column: "Password",
                value: "$2a$11$nqdhJW/lD1bM/Or3hXvsB.kfU0J.vr.LjLnT9w9pY3rGHq98mvAZe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 267,
                column: "Password",
                value: "$2a$11$blbqHIre5MuNYCqDHZWMQOppZ6jss6e1v41Z0KQt2Sgo7KQO4CJ1G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 268,
                column: "Password",
                value: "$2a$11$2dXXUD56xgimeEUcM5UfPujNlfd32KTBnFwpgJsWWx2hb7Pnu7Lw.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 269,
                column: "Password",
                value: "$2a$11$cSrdAL25dQJ5m.GCPQJ3zeaSGe2HEjO/WGrUosbQV8P5bY8fF9mom");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 270,
                column: "Password",
                value: "$2a$11$ncbMNdkSCHkjpDqlrp.1Q.QloC0ZaOE5o3xraViOg2snWqCcfnRbO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 271,
                column: "Password",
                value: "$2a$11$LSJJlnZhlREMsqY4RLTwxem0ci8uxVuYTRo1fks4pC.3moRhuTJdC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 272,
                column: "Password",
                value: "$2a$11$/7HyJMh1FA7ypN6lviHFtOfP2xEDtf184o2.ZXw/tCcTglLSsexsG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 273,
                column: "Password",
                value: "$2a$11$QQL3IxDR/sM0RDCHSNU0BO7Zrqn.6g//5/8xkiLoCvE5IbbaCcOTW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 274,
                column: "Password",
                value: "$2a$11$7P4CDp8PA4Qk8s1R../IAOW9vbs5KjO/icmbBhVJtSgq15wZbTKG2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 275,
                column: "Password",
                value: "$2a$11$be.3kqtfkslL12P9fyFeeuaGowLNMJUnXcvxpWoVrSBIVcowZ7Jcm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 276,
                column: "Password",
                value: "$2a$11$G8ZLjuIr9UAtW/Gzsp0Z7Ob9O1QoHFdgF2zs6.bAj3zTlJPsnFu2m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 277,
                column: "Password",
                value: "$2a$11$23IDB4GvhwNw/OKIH5paROFyQ4MM68QR8SuTOPgKeEhNXrmOrEx/u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 278,
                column: "Password",
                value: "$2a$11$QPYnXRAotQeXhh5qpN4s6u2fKytEQDuRz1/BfsATiee.Hjyw5qZfy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 279,
                column: "Password",
                value: "$2a$11$Qb.71YLaeiBd9WlQVPQTielT51EsGbG14zzmAfae7QnalhHxAoWhS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 280,
                column: "Password",
                value: "$2a$11$Rk2862e1.dL3jnuGRctVze.9LBHsSbxtBluN/cqHfXZ4TBrJ9XD96");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 281,
                column: "Password",
                value: "$2a$11$etXx1BsMctfG9jb3UhRWKuicjVkopZC/xT5eYPRkxUZLNhRlKe5sS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 282,
                column: "Password",
                value: "$2a$11$v9HC9gvMopT84l5IvOX2m.zELANJmfpRUEbBN40jeYVsXhLV5ZsWC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 283,
                column: "Password",
                value: "$2a$11$UA3zLk66j4lkIwe02TImb.eerbs1.rktkv8ZsYK7brk9.DZZf2W2e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 284,
                column: "Password",
                value: "$2a$11$6teAj6bFnyJarbfK2.BHcufbDxpN4SDL.NbZx0hva.ghcVmikg4FG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 285,
                column: "Password",
                value: "$2a$11$WiKtlC8wjGNtr/DUBUthN.0rx1HSTwLa2XqBohfWtN2uGUsc1PRuK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 286,
                column: "Password",
                value: "$2a$11$QJfqtmDXDOtO/h2s7lmjkeeR59FfsfgObelUH0iiEUGtgYbh611jW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 287,
                column: "Password",
                value: "$2a$11$DDmOdNmHiB/0GW/a4Z2WduJT3.yH/xb1DI08GWCU/7pIc9elJ9bCW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 288,
                column: "Password",
                value: "$2a$11$ep3EYcP8DbD6lvIbpc1KVeOdj2L9AyH4EdBsfmvczXzhnCLOvorzS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 289,
                column: "Password",
                value: "$2a$11$qM/xhmaxKTI3k72.qwT1iulbY7XRrGkFQARuU8RWh5SBYdV33ekcu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 290,
                column: "Password",
                value: "$2a$11$6YOwECyJmmGnJGo1tEc58eRUS11PAC/W.6/isQD.JfHEauwuj2uj2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 291,
                column: "Password",
                value: "$2a$11$yhM7S9wfRwxyqEM0LMrPI.gQTx0qUdafAnTc2VNlkanrgLJ91ZWIS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 292,
                column: "Password",
                value: "$2a$11$WTv07/YusMCAZdjGy4XkquSX1n2l/Y0D4UO1xBq8Rfpp7YCDCqlQ6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 293,
                column: "Password",
                value: "$2a$11$bwedoYgOL68/xwftY2e5kOKdj/DGNXASPIk7KsQu8BJWCG35duTHy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 294,
                column: "Password",
                value: "$2a$11$bBbG2eP.cKJdNcDphDyEwuyxzwJqms72KQZiqLQTzy90lBdlC8GVi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 295,
                column: "Password",
                value: "$2a$11$Ym5VNpFdwgC.OV1dCWEe4unO8J0y70ktUWnVj/ytMNka5nFdLTcxa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 296,
                column: "Password",
                value: "$2a$11$9hVjeRs/6TS82kDuwkvDmO73rZhzgEoDWkFgVP5TMPo0LwGVQUxn6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 297,
                column: "Password",
                value: "$2a$11$D4ZG981aG3Q0kWq5zymyEuYzep00T5EOhy9fhU6twqIvvbbarAdfu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 298,
                column: "Password",
                value: "$2a$11$uMxq0Bx1f2on.0mSSLBnbO1VOost0SFRsF8eLhLyk8mml5dSxWelu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 299,
                column: "Password",
                value: "$2a$11$AiZmE.8lkxg31MSLlEVEzO4ZyQukyjekXN40WarDWkBop20SOpaOW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 300,
                column: "Password",
                value: "$2a$11$fWkLZFNNiGaK1cjNcH5RHeCrIJEQuP0q4T8HJZY0eIdx67eSwLRf6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailUrl",
                table: "City",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 770, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 19, 31, 768, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 3, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5881), 0.13578736877273778, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5932), 391.09269105635633, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 30, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5947), 0.9668989403419711, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5949), 491.55999459208027, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 2, 16, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5955), 0.48460918702238842, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5957), 122.20572397592566, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 17, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5968), 0.71715809682639675, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5970), 63.21583018677196 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 1, 4, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5984), 0.83458941484420601, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5985), 51.05498604296799, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2023, 12, 7, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5997), 0.41446371677328142, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5999), 27.577462216344827, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6013), 0.23486167218480547, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6015), 77.387719294194028 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 10, new DateTime(2023, 12, 24, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6020), 0.37752061152419092, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6040), 46.274205392734416 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 2, 13, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6045), 0.96783302500613477, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6047), 14.105885285875308, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 2, 1, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6055), 0.0052570909676293853, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6057), 232.80618089883353, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 2, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6062), 0.71151437287947417, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6064), 82.007308063972488, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6083), 0.077009339659317777, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6085), 355.20490942130436, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6090), 0.26618560129876156, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6092), 228.52786072970804, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 12, 9, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6098), 0.64373139386409839, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6100), 305.20269617437339, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 1, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6105), 0.37238219125861904, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6110), 44.101225061509375, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6153), 0.2463723779978908, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6156), 218.01610038497239, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 21, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6161), 0.51525630426533042, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6163), 57.321871564134987, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 2, 29, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6169), 0.20751113722650505, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6171), 300.95763753656331, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 19, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6177), 0.73367370105978669, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6179), 300.7770340717359, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 3, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6184), 0.33321364876192661, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6186), 300.11338861716382, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 21,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 26, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6191), 0.012421167863192251, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6193), 97.090673217651684, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 22,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 15, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6198), 0.82212879273647044, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6200), 130.57996431898727, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 23,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 2, 4, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6205), 0.93915064627090494, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6207), 330.13324445588131, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 24,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 2, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6213), 0.38426657807503561, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6214), 492.48075753882688, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 25,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 12, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6220), 0.74120763180308602, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6222), 176.70036508841713, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 26,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 28, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6227), 0.33005605844431829, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6229), 115.06726318342886, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 27,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 12, 28, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6234), 0.70450028602304371, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6236), 193.2180336892142, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 28,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6242), 0.39407272885459832, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6243), 453.12920553612184, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 29,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 1, 31, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6249), 0.11293783482535757, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6251), 444.91481784812339, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 30,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 1, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6256), 0.54439825754079407, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6260), 167.70498889440287 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 31,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 11, 28, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6265), 0.13259086737554227, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6267), 304.35066405181573, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 32,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 2, 25, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6273), 0.60094057132985401, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6275), 220.57604599285364, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 33,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2023, 12, 9, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6290), 0.25280196548524358, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6292), 222.63846863796545, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 34,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 20, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6298), 0.95405976285232841, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6300), 60.327920436095084 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 35,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 1, 6, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6306), 0.98455087468744407, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6308), 402.31585126615204, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 36,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 2, 18, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6313), 0.68042927673911158, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6315), 99.635597360417378, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 37,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 1, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6320), 0.089954640164082056, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6322), 163.27874590557434, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 38,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 1, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6327), 0.54752701577285856, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6329), 247.23557922368801, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 39,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6335), 0.973232342393202, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6336), 354.35322785530906 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 40,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 2, 23, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6342), 0.7478232826476322, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6343), 9.8226823125623923, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 41,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 2, 4, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6349), 0.3472833194393572, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6351), 301.07089755170722, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 42,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 2, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6356), 0.89510804337770289, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6358), 70.347329452198679, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 43,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 2, 4, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6363), 0.2746010937191784, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6365), 27.576873119567413, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 44,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2023, 11, 29, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6371), 0.96823860249188842, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6372), 303.49252797098092, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 45,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 1, 15, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6378), 0.64719963583542572, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6379), 411.84321007130876, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 46,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 5, new DateTime(2023, 12, 7, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6385), 0.61201181498538804, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6387), 409.29115009104999 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 47,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6392), 0.33266872614889076, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6394), 354.72665245380205, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 48,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 1, 29, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6399), 0.27979994946108944, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6401), 47.953485926642948, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 49,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 11, 25, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6407), 0.6168586627193664, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6408), 312.50039727113347 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 50,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 26, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6414), 0.73818373832723283, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6416), 348.90915932941368, 4 });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image5.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image1.jpg" });

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
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 17,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 18,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 28,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 29,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 30,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 33,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 35,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 36,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 49,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 50,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 51,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 53,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 54,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 23, "http://example.com/hotel23_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 23, "http://example.com/hotel23_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 23, "http://example.com/hotel23_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 24, "http://example.com/hotel24_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64,
                column: "ImageUrl",
                value: "http://example.com/hotel24_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                column: "ImageUrl",
                value: "http://example.com/hotel24_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 66,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 67,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 26, "http://example.com/hotel26_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 68,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 26, "http://example.com/hotel26_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 69,
                column: "ImageUrl",
                value: "http://example.com/hotel26_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 76,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 77,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 78,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 79,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 80,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 81,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 82,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 83,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 84,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 85,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 86,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 87,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 88,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 89,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 90,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 91,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 92,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 93,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 94,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 95,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 96,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 97,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 98,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 99,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 100,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 101,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 102,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 103,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 104,
                column: "ImageUrl",
                value: "http://example.com/hotel38_image5.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 105,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 106,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 107,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 108,
                column: "ImageUrl",
                value: "http://example.com/hotel39_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 109,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 110,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 111,
                column: "ImageUrl",
                value: "http://example.com/hotel40_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 112,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 113,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 114,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 115,
                column: "ImageUrl",
                value: "http://example.com/hotel41_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 116,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 117,
                column: "ImageUrl",
                value: "http://example.com/hotel42_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 118,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 119,
                column: "ImageUrl",
                value: "http://example.com/hotel43_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 120,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 121,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 122,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 123,
                column: "ImageUrl",
                value: "http://example.com/hotel45_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 124,
                column: "ImageUrl",
                value: "http://example.com/hotel45_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 126,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 46, "http://example.com/hotel46_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 127,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 128,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 129,
                column: "ImageUrl",
                value: "http://example.com/hotel47_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 130,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 131,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 132,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 48, "http://example.com/hotel48_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 133,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 48, "http://example.com/hotel48_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 134,
                column: "ImageUrl",
                value: "http://example.com/hotel49_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 135,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 49, "http://example.com/hotel49_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 136,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 49, "http://example.com/hotel49_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 137,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 138,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 139,
                column: "ImageUrl",
                value: "http://example.com/hotel50_image3.jpg");

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 140, 50, "http://example.com/hotel50_image4.jpg" },
                    { 141, 50, "http://example.com/hotel50_image5.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 72.1331195012196m, -78.6748847051612m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -57.3773062746083m, -112.80534096871m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 60.92180492293m, 9.2471177028419m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -27.3698225923456m, 50.4717767057131m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 63.2247668674878m, 168.133479133392m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 33.0218975602651m, 93.0954867487058m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -39.9600668833969m, -85.4951012427584m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 0.687049917526963m, -64.0338704298856m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 31.0110407720245m, 77.7853116526748m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -8.3715230965354m, 122.269908497224m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 68.3701549473088m, -128.039809503519m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 13.3420980264062m, 153.015857232939m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -51.0222917724351m, 35.4897762384808m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -35.3359029841588m, -109.114455961651m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 21.4017901883085m, 114.888437087304m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 34.6025508674305m, 24.4909794376188m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -42.4565175948011m, 120.196677598804m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 58.0990426760671m, 103.14185590124m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -25.018850595311m, 81.7046744524254m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -46.1659262779557m, 97.7770774905397m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -38.2477502086806m, 3.40319806706736m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 9.88202984961076m, -115.769858506265m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 37.9180045166429m, -128.015120418831m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 6.7263478559334m, -129.901891714591m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 81.3262566831281m, 75.3208122264625m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 12.3533244876141m, 42.3359281294672m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -80.0987032829182m, -47.7668557972578m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -64.5565830546863m, 7.55701004260754m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -12.8605242564831m, -76.7432996737542m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -12.2316042228546m, 47.1063521494192m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -6.2684096696496m, 162.611817023261m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 23.7753041804629m, 129.321134102806m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -1.76231217062906m, 95.1638884594809m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 75.7529134626708m, 89.1118544366294m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -0.0630350311388668m, 78.4537406986412m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -80.2928154070578m, 11.0811274425363m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 40.6564038866879m, 89.5985878811971m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 62.6522211816477m, -69.9704769329041m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 77.1673744577183m, -179.254115112518m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.1345690169411m, 167.451427847623m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -23.936712675656m, -60.3673556548558m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 29.9023039692668m, 130.607084164493m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -34.5183961202332m, 32.0150266424406m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 30.8739227435698m, 46.9532557889493m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 42.8635846810582m, -109.574403167239m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 46,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -57.8019877402924m, 83.6650764913565m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -21.9949481846597m, -116.765663972743m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 48,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -64.687750010761m, 35.0299753505602m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 49,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -3.91464375025384m, 49.2969473768366m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 50,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -68.339967270773m, 51.767746428579m });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 701m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 963m, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 245m, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 225m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 420m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 372m, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 761m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 969m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 456m, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 425m, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 343m, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 677m, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 444m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 3, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(1965), 259 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 6, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(1988), 182 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 10, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(1992), 24 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 8, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(1995), 117 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2024, 2, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(1998), 174 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 10, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2002), 152 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 7, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2006), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2009), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 12, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2012), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 3, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2016), 130 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 8, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2019), 169 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2024, 2, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2022), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 4, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2025), 293 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 5, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2028), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2031), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 8, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2034), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2036), 195 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 6, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2048), 227 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 3, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2051), 127 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2024, 1, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2053), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 7, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2057), 144 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2059), 267 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 10, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2062), 142 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 5, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2066), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2069), 184 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 8, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2071), 165 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 5, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2075), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2024, 1, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2077), 198 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 12, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2080), 90 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 8, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2083), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 9, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2086), 139 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 7, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2089), 91 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2092), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 11, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2096), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 7, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2098), 181 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2102), 102 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 7, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2105), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2108), 207 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 6, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2111), 244 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 4, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2114), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 4, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2117), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 6, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2120), 230 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2024, 1, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2123), 286 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 11, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2126), 131 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 9, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2129), 88 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 11, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2132), 252 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2135), 172 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2023, 7, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2138), 136 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 3, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2141), 207 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2023, 5, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2144), 22 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2147), 246 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2023, 8, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2153), 174 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 4, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2156), 147 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2024, 1, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2159), 193 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 4, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2162), 97 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2165), 259 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 5, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2167), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 5, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2170), 203 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 4, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2173), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2176), 118 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 12, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2179), 117 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2182), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 7, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2185), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 6, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2201), 185 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2023, 11, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2204), 6 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2208), 219 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 7, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2211), 86 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 6, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2213), 165 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 8, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2216), 277 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2219), 274 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2222), 244 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 10, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2225), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2228), 214 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 7, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2231), 95 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 8, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2234), 179 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 5, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2237), 249 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2240), 211 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 10, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2243), 187 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 1, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2246), 167 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 7, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2248), 244 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 9, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2251), 104 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 12, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2254), 238 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 7, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2257), 120 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 6, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2260), 191 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 5, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2263), 294 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 10, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2267), 257 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 6, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2270), 211 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 3, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2273), 89 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 10, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2276), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2279), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2282), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 5, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2285), 119 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2023, 10, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2288), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 7, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2291), 153 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 6, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2294), 82 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 10, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2297), 268 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2024, 2, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2299), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2302), 222 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2305), 107 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 9, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2308), 157 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 5, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2311), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2024, 2, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2314), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2317), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2320), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 9, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2323), 170 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 5, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2326), 158 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2329), 165 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 4, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2342), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 7, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2345), 205 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 9, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2348), 210 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 3, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2351), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 6, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2354), 85 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 9, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2357), 151 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2360), 193 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 1, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2363), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 3, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2366), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 3, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2369), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 8, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2371), 128 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 12, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2375), 225 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 5, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2378), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2380), 118 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 10, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2383), 203 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 12, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2386), 134 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 8, 28, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2389), 231 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2392), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 10, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2395), 136 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 9, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2398), 205 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 10, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2401), 166 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 5, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2405), 146 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 6, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2408), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 9, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2411), 299 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 9, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2414), 281 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 10, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2417), 240 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 4, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2420), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 4, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2423), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 8, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2426), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 11, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2429), 143 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 6, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2432), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 4, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2435), 191 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2438), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 6, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2441), 224 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 9, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2444), 178 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 7, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2447), 139 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 12, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2450), 117 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 7, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2453), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 11, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2456), 101 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 5, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2470), 118 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 7, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2473), 298 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 10, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2476), 88 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2479), 98 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 8, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2482), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 11, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2485), 294 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2023, 9, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2488), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2491), 159 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 5, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2494), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 4, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2497), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 9, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2500), 102 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 3, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2503), 130 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 12, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2506), 254 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 10, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2509), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 5, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2512), 290 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2515), 95 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2024, 2, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2518), 178 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 10, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2521), 165 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 10, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2524), 222 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2023, 6, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2527), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 11, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2530), 130 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 12, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2533), 190 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2024, 2, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2536), 221 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2539), 188 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 4, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2542), 147 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 9, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2545), 272 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2548), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 7, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2550), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2553), 144 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 3, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2556), 216 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 10, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2560), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2563), 166 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 3, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2566), 115 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2569), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2023, 8, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2572), 153 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 12, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2575), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 10, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2577), 155 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 11, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2580), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 8, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2583), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 24, "This is a review content for Hotel 24", new DateTime(2023, 8, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2586), 290 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 9, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2589), 136 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2024, 2, 28, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2592), 262 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2595), 114 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 7, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2598), 202 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 4, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2601), 121 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 8, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2604), 225 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2024, 2, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2607), 188 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 3, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2609), 278 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 5, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2612), 210 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 7, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2615), 128 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 11, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2618), 113 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2024, 1, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2632), 190 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 11, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2635), 263 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3574), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3584), 223m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3595), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3597), 169m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3602), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3603), 427m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3608), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3609), 125m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3613), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3615), 290m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3632), 47, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3634), 474m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3638), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3640), 227m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3645), 238m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3649), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3651), 490m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3656), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3658), 253m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3662), 45, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3664), 456m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3667), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3669), 160m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3673), 18, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3675), 249m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3678), 9, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3680), 425m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3684), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3685), 207m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3689), 10, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3691), 459m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3695), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3697), 192m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3701), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3703), 164m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3707), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3708), 399m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3712), 32, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3714), 398m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 2, new DateTime(2024, 2, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3718), 29, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3719), 437m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3723), 12, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3725), 384m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 28, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3729), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3730), 409m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3734), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3736), 323m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3740), 31, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3742), 268m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3745), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3747), 308m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3751), 31, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3753), 420m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3756), 44, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3758), 141m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3762), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3763), 158m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3767), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3769), 242m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3773), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3775), 113m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3778), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3780), 53m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3784), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3786), 127m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 12, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3790), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3792), 132m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3806), 15, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3807), 187m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3811), 37, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3813), 484m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2023, 12, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3817), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3819), 56m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3822), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3824), 478m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3828), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3829), 477m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3833), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3835), 170m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3839), 33, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3840), 257m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3844), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3846), 78m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3850), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3852), 234m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3855), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3857), 271m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3861), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3862), 71m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3866), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3868), 253m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3872), 4, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3873), 321m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3877), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3879), 330m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3883), 12, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3884), 133m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3888), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3890), 430m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 51,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 2, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3894), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3895), 499m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 52,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3899), 32, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3901), 70m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 53,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3904), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3906), 492m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 54,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3910), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3912), 354m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 55,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3915), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3917), 297m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 56,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3921), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3923), 209m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 57,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3926), 16, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3928), 80m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 58,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3932), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3934), 369m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 59,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3937), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3939), 53m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 60,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3943), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3945), 262m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 61,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3948), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3950), 406m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 62,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3954), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3955), 118m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 63,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3959), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3961), 370m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 64,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3965), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3967), 94m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 65,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3970), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3972), 485m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 66,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3987), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3989), 385m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 67,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 2, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3993), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3994), 423m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 68,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2023, 12, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3998), 32, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4000), 486m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 69,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4004), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4005), 457m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 70,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4009), 1, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4011), 55m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 71,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4014), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4016), 372m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 72,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4020), 3, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4021), 452m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 73,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4025), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4027), 254m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 74,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4030), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4032), 490m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 75,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4036), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4038), 188m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 76,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4041), 29, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4043), 98m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 77,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4047), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4048), 209m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 78,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4054), 458m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 79,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4057), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4059), 273m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 80,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 28, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4063), 47, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4064), 180m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 81,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4068), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4070), 469m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 82,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4073), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4075), 226m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 83,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4079), 50, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4081), 128m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 84,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4085), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4086), 266m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 85,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4090), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4092), 138m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 86,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4095), 10, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4097), 100m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 87,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4101), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4102), 389m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 88,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4106), 42, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4108), 417m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 89,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4111), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4113), 184m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 90,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4117), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4119), 464m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 91,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4122), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4124), 315m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 92,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4128), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4129), 355m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 93,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4133), 49, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4135), 239m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 94,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4139), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4141), 117m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 95,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 2, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4144), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4146), 87m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 96,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4150), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4152), 484m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 97,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4165), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4167), 245m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 98,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4171), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4172), 393m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 99,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4176), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4178), 215m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 100,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2023, 12, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4182), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4184), 116m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 101,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4188), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4189), 346m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 102,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4193), 8, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4195), 275m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 103,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 11, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4199), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4201), 119m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 104,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4205), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4206), 355m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 105,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4210), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4212), 159m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 106,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4216), 14, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4217), 233m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 107,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4221), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4223), 268m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 108,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4227), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4229), 338m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 109,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4232), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4234), 431m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 110,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4238), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4239), 198m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 111,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4243), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4245), 116m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 112,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4249), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4250), 301m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 113,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4254), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4256), 332m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 114,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4261), 183m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 115,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4265), 20, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4267), 161m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 116,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4271), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4273), 230m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 117,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4276), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4278), 161m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 118,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4282), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4283), 338m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 119,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4287), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4289), 370m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 120,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4293), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4294), 84m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 121,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4298), 10, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4300), 64m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 122,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4304), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4305), 448m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 123,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4309), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4311), 367m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 124,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 11, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4315), 3, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4316), 444m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 125,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4320), 37, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4322), 308m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 126,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4326), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4327), 447m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 127,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4331), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4333), 238m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 128,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4337), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4338), 453m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 129,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4352), 45, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4354), 478m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 130,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 11, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4358), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4360), 61m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 131,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4364), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4365), 166m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 132,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4369), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4371), 406m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 133,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4374), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4376), 263m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 134,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4380), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4382), 345m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 135,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4385), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4387), 131m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 136,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4391), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4392), 169m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 137,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4396), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4398), 383m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 138,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4402), 44, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4403), 423m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 139,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4407), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4409), 445m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 140,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4412), 14, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4414), 465m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 141,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4419), 416m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 142,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4423), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4425), 262m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 143,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4429), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4430), 461m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 144,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4434), 33, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4436), 314m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 145,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4439), 9, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4441), 472m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 146,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4444), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4446), 495m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 147,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4450), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4452), 245m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 148,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 11, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4456), 15, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4457), 140m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 149,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4461), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4463), 376m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 150,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4466), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4468), 124m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$fGZf3R4p4cjNmffkqmWr2.CSMyQCl9F.KJRMii3AWFMHHIH5w.85a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$vGTsSfeUg7Hacl3MinoeGeBOJsK80bLPjiwWxsry512i0dsZ.RI66");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$peJld4J5Ff71OYyI.xrwceoKl/5Cb7R4mUAvNUcyAHXqnZNFVdm5O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$OTe/IH1nU1VIkWjcCsnuneLtxyLOgVGWx8YoYcLa0zW3ks8p5jHjy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$xvwJrFjE8niR2KqUNoqxjugaGWn86PmgIR3fWmbH1RlfzEgVqAr6.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$4AZlCdRyXFgWTumGicRPUOfdAq2XPsS7mvTogeWJJigom5ivy1h66");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$P5ikqZMqcgZ54bvuug..5uVox.g5fWglv041Bdjp3dqWecddD6EyG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$SZ9XOkc4qFWWamYk0gVSJeWI84kmKw.6gp5dQy1dhaTd2zpOQQcuS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$kiqtuHnR.vwposCxIRR1TeYAeNgm0om/7tGKQKrP0xVvRYcwu48Cq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$jwnTkvQ0/FOD7ENu7lNgbOAoryvpp.JrAepOTcKHx6nXZ8PQq.18y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$jBKOJGUTvRyMGEkvgrcvC.qADYvWwjcbKb.o4rsRjtZ6gW.VkkPIS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$1fgeFzc9WOB9x/Wc4TrCAeoTITs/99UwUaDG5UkNpKqDOsDtv4ylq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$/8SMRkHpwqhPHxwMOVz/ge/UnHSCAwL8HVetvrptdu..tmqo0FWaO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$Qz2NVVPi5.pRaLNrFqtJPeZmmH.OgyA6RrXyttDlcGKKVi8g1jte.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$t21H0F/jltqjmlxBvPsii.jhqg.fwel15gOTxVY.rWEVlA4miM3RC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$Dtc/E196P2i2AvWythZOxe9eNmDrRSEoMNraWsJ.AXRO1eys4WfvG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$erGin8FT76gwoiXiTPhGRO/rZGcp7ce7sGLSIEFLCHr6LRoI1wmGG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$6G/azeKBNSk2cBVgknZtDOHIL1r3sErHBG.llwgoSgb1/p4/cyspa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$QD6OI/NRpQoXWXqlyUh2luWAs/TGM7PPIaQBIFcZjEAekZasbnXX6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$O/NADmjYHEqimmXgCpWjmey24ihKagyPgS2aU6y9U24DR1mMNRZBC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$a5liAThHau7TXWoWsf1fYe3omqBI37LneI5CgpRRQDH5YpX6X66bq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$al7W3GCCiDzGMV.qRyag7.vJ8.SXVzM2PD0rbB10aqIEYw2CVSeJK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$LNv9LMQvZfrM/r7dNXir/eaTIU95RK51Hov5UK4/9vIUcN6UPJKKu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$BBHar5KE/s.2pnfwcTXfIO1vZFZ0jEJIYsI.c7N69cqPl9omkv3le");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$3JG8Bf0CAvPySGUlWN7ZNOz3nUm3M00AQegAO3.kMmKmu3ZovZHFy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$sfYpWxc2RM1Dwb5Gs3fsA.W.k3yIY753xg6dEi2Y9difOEbcQS0ZS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$II1/dVfzGmarU0wem8xOuum6BILLa8RTq4FFt5bqnvqQaBJG.jteK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$/gD9WDsOn28NdyLcKNAoN.HAPC52YMV4eYvFiGHHs.9oHMiBcHTYC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$BSM6lJT5zieAMWng61T4meN.O..eDavAdYAxcjALSjXq9O4/3Wm92");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$orQS0SI9xMrXXc4enIQbjeRTTlG3WU3yGitrkZVnOSiQ25acnw3Hq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$YKFsjM2VKvECCQFMLpU2UuHTuw2V/9qUMSUNCC0BbYhbTo5Rw30Xa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$J/XxxPLT6tPHeDA5lJvrieoXwBTR8gXSjC90Mn096qkEGJ9.Tjtua");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$Cf6b9Oc8pA9zJGjQCDOyhujfgZ/w2W6TsjrJc0gZQq.mbGpTlv9IC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$ccg9OTuxRe4w3TNwcUAH9ugmBF59X05k5It5alhAut1t34CAuL35q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$.RNRhiAipMKztf.jwnoOLuHg6T1xde7mX/MscXwgNx.c9h4TAroQG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$1X31EhiBG3nBV.Tgejlj8.DRMZ27vJNi.dHnOskGRX5drIfGzKpBC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$PyOYnlHh/K1yYBHvhRlPeeiOKMH1Aj7.ngQ.muzk5KetuC7VX7uQ6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$ZKVVvsCibU1MQYxFRvEi.uKwpb423AJt6PIbSZsx5RJQhhbU0xxYy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$.wBsksi9DTLhPuG7kavgzOBTDIzMu9h5Lpm2.IjNb3./lwZHi8b.m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$tTvIEFZ5NRETIl/5D6rYbetceK0TkidOQsqXIEjEkpJxPDEJoACqu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$dyv2riS3XiaSDIBCZBJX.esC9MZWnR92E7zEm2r2fjDdQnVBoO8rO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$6nSbRKiGzWckPzkkrVb27.In.NBxDlZ4Zk5.j8fK4UX9jAODcmmv2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$zWcl0ONOPm4JI8ow7eTeNuMCfyMea5xamdcfodZoL87W8GqcvPUH6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$aFWkBkXJoei69EBOr7CpUOn4.pqfpvmwLB5aq2yPaDg8GvJNfcFtO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$8MpOI89fJ6Vz/bO4QWwiQeqtQoAoA7q/BxWTeFMic0C7HB/lFAely");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$AU0z4/majjGt3ZXvbMWzwefraLd5jCnh1pyahYdYEtLRst9Iqlk.e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$PNllnw2fbPHe2srQpMGtUORKKYV1N7OCGdx6PJBK9kSEBcBtBfnTK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$KP1aVWXiMeslvt7aP1sK2eWRbw2gk4i6Vb0wGgMMpkLTub3nzUuPm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$UThFI4E3DoVZA.EErBYFqOWmLEjh3WHc9O0eGcsV1rQaoqs6L4vgK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$9nfPXUrwpQJ.sWd/yTthQOiADpk7WXqnJLXu5CqGVeSXt5YN.D6ly");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$0ymcGefa.uTvTAzaSmKzGOza6J4CPdTmgkBHYjjlKke1Ju3W0MItu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$wx9GCnh0yfA2zFtzxBTI5OnDf0dcvk5XIImVHd/FTG0HNrkLnL6V.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$MdTZI6J9uRyut87Um1UGueZWTXu9xfuu2yMq0PYDbYoME/4Vsl4sq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$qgXEJSEyCXA1hwerjEXt0en.QijfJ/em3/X9NCHDjND3VD3JWidOG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$nOJrjxR42nuJSYgftYtJFO59yECT2Cu7nkD9G2YwPZPJKlAeRqg4G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$ccb.uPS0877vp183A0HyseRIfo7lAfrAIzz9RhhmILIF13gjZbbgW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$pU2/JjEVW19y6y2hw575DuYeZs4c/jUjmYjCTw/2ZNaJO3gBVTuAy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$WA25WSaZE/C6ukmX2D/APe0N0w7u9tpCSERYp0gsu3zzhPxKmRS9.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$pi1FRBTjv5NApCwhdpIcQ.M3nV8sdDCxgFhNGmcUlA3R2R0uhfiou");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$4Efc11hkov5QwzXiaAy34.ZHmdIO4dR5/9QY88MJdOMVeZ8v8WO52");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$ZPrchY.VRQTyxLacKNGnpuqkid9VT8UUB5cF2RBh4x.OI3QRKWaqm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$xnmHzfTX.IYcmHtbfC1O5u.hw7BnZG524hYvMXTO4RdjsOwk0qrCu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$iaCA/0PyWh5WBdkuZJTHT.Io5sq1/BCrNB6bGtwsykgbUSeIPG.MW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$6vUDsmH.O49zij9bSNjDe.rpCxdxrJ7CnDYP2vQsLbvZ4npKYWpdu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$5GT2Oyhb9KKnkfj4MYjT7OG2SI9kmCR5fBFG8tBqWQfWmaS4Yn7IW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$YqxWpbCmfnXhkqjHF7cPDeO7KnI7vHeSQNQy97ZJTTZpD7tlWyxiW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$PNQP5xq17p94vZ.ctejYneLBE2GYzGSgP9./FSaAYRtiUgvN0CMmy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$EIPtcvxyOAG67XHHd15olu7lXLw5mVAuQQMgs5vQXCaTXhG71IY36");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$VyAeKf7QgW1M803EjoIM2OzYeLPBM8MzTx1CrtO/cXGLSxN1x342a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$ZdvLke5jcIqlA67/ZdeOk.toGRJvGonHSglB1TcZ8K4fCz3CujN3G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$TBq9PIwtArnVDQInj1jxheHud/gQX9tENox4Jl0FZqG577ytzwbL2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$Omr/69942KcJWZxnpGJDAurp/VX/rRZKzMAm1HiPFB/pwah8kxQOW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$3xNHFt5tuJjY6.r3cYGcguGhxZuNUEvFvnb7Ht58kFB5.UGxf0pc2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$mmsmW6MtmTCBQjSjNb/YquAlMLfjLlP5SSHxVfvZWXw9t1Ig7g8dC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$pWmNlDw.8ZHMrAAGHE4HAuUMRWzLK9U0dJrXhh76mCflYXnAy/oPW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$SV24cmeDc17Ic4eDBpDSTOh8855Nq3Nx5/lRj7GG6bvoFN5J3JEa6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$AG1xl/HKJ4yn/aioH1XhYO8BEhMtECDIolXbnP10d9WI10mNir7.2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$rTVowVJ4E2/MzTblJCZIFebJBYBFxNaECeTy8L13BWmye.P2QA61i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$8VXVWmHwCoRD.mJnkSlLIuR8aDj7IT.dQ./8ST.uU9Kl1Rl0BfsNi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$FmAr5mzxyu0IwFLDXZ.XRe35ThKfIzE6cv1CRMvTqoME7IYuyERTi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 81,
                column: "Password",
                value: "$2a$11$iK5fGMcnVc7qC4WIqe5x5.O9yg.maL/qtpMP4MDahnR0t.mW.A3LC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 82,
                column: "Password",
                value: "$2a$11$Qz8FURWKddCQGeUbr3kUSO5xNYZMW1/ZxEMB1j50sGJ81nrpUynFC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 83,
                column: "Password",
                value: "$2a$11$099mlg96eCs7dPeS9HLyfeTARQYS127C9QX95heWLSMAPG/ZrVYmO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 84,
                column: "Password",
                value: "$2a$11$IqivQpWuZPkDcuiqQIWa5OUY6twlqsBmlcgoaX.vhm8Gj4p/AdMl2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 85,
                column: "Password",
                value: "$2a$11$CaLJHAGXbqFJenOXOAu1re93t5VbP3v8BhKLiom6zOw26VvtBrZkC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 86,
                column: "Password",
                value: "$2a$11$rjZnZ063uOjl5YJzVLcvXukkQVdeTRtwOOBpMysa0Gkxc.RaycnZG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 87,
                column: "Password",
                value: "$2a$11$Au4HgLiwwA1okltqe/HaCeWvL1E/1xaVp5INLpr2pvNHTmdEACU6.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 88,
                column: "Password",
                value: "$2a$11$C6wOU3wBpA7pZH7vaeiuU.tnDh.gIxnqNY4yLapUadTcTacIDO222");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 89,
                column: "Password",
                value: "$2a$11$eIMNcXnF4EYT6RFaeZvY0OqQ3VXm0byZtCsmEswgFV.qio5uza08O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 90,
                column: "Password",
                value: "$2a$11$/NjBLpzuiX6FMeh.Zf0lcexOJiGJnKmGYJ7/9QMVgEYcS2e4lNUNy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 91,
                column: "Password",
                value: "$2a$11$OVlnZGYBn7fB4nsHwGwiweyGRVeeaawGmbAeRDupvtNGy0Ct6ChkC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 92,
                column: "Password",
                value: "$2a$11$J0eJr8JSTnpeF2nb0h7SPOspU0E88WpO/oFIVR/hP6RfSB1T1Z/sS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 93,
                column: "Password",
                value: "$2a$11$FSLqYjlni09O36Xal/3CJuTTuuq2okKg/0oBvP.9psNsISdpvNYuG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 94,
                column: "Password",
                value: "$2a$11$SzRFBNhR3FS3cKreyqHXFu2yAejHZfTPHN86xGnceR2cfD5zo.jyC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 95,
                column: "Password",
                value: "$2a$11$i36iBe1V66XTNjWcUHwgXeqIim9qK30gHOh/bW.kyv3izPAnGPzv.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 96,
                column: "Password",
                value: "$2a$11$N671T35L5phyxBX9FtpGFeeZdGrRc3sBrg28.LuZNVaogL5utlDHS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 97,
                column: "Password",
                value: "$2a$11$Jfg2ziLn6ocNn5s2KmiTpeoEVqEgOUjPTbdtbUXqTqg.1honmhWRe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 98,
                column: "Password",
                value: "$2a$11$lZJWUMYpJV/Xw8kYMRdCmO7uVcNpyJjQZKMtn2r3LFZxmdMGhI66C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 99,
                column: "Password",
                value: "$2a$11$jFpknAtly4Bdai9WD5SQnOWfflEgul0wnl6bexGyPDO1EXXIAFLuW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 100,
                column: "Password",
                value: "$2a$11$8/raaz3FgKMxlyoaSAt41Ozc.r4Uy9aV2B/Yv5eaqIsRuGjL9Pd32");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 101,
                column: "Password",
                value: "$2a$11$v2td5Q1QR4tBjWnOCco8au0aLM.k6cmRxBMLwllbj8U8WQSTm5fWu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 102,
                column: "Password",
                value: "$2a$11$Ahe9StOr04kE2mQb06zr6OrgidaTklR6OA6F8piofLKx9oRTPMYB2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 103,
                column: "Password",
                value: "$2a$11$RwyJwL71sJnltsVFk5c4YegC0QUD1NSj4.EPWMH1rVjK4C0L6BQ3K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 104,
                column: "Password",
                value: "$2a$11$dALeC/ycTDAfFze/RXImlOFJnmnR6hkziII60YTCt6bgxZADn93Qe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 105,
                column: "Password",
                value: "$2a$11$cKXQ6R6uKYYTlVeh1mj3Pevq2iA0Oyawjl23URuGrNfg03HiNmhTi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 106,
                column: "Password",
                value: "$2a$11$LbilUNZfzBHqXMhR89UmBeK5tMVGUQlCojR17EaW3GI4Yjxm2/MsO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 107,
                column: "Password",
                value: "$2a$11$vjmd0yceJbzUpEDmno5IqeAWy2HzwdCY9ZGHOqlaN5ddprp3QAFba");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 108,
                column: "Password",
                value: "$2a$11$MeLtuz9To0llqF.rajP1M.uSYp0WKIshHpn6HDh58WU8vpIycexUm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 109,
                column: "Password",
                value: "$2a$11$fGjzO/5rgTIBMOJ0V9dUJuIqqZBSuqe8jan1ZXBhuTOerz3ImyBxe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 110,
                column: "Password",
                value: "$2a$11$J3tEGhdJO.5VHjt71L1C6eG.ELh5WUkwH9LxoU4u4Hxjjuvsxbcua");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 111,
                column: "Password",
                value: "$2a$11$3sKutJt.K7Q4XrS1ViYKUey7AmBB3nZ6QAnCVaOpmFjlMKdEjeY5K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 112,
                column: "Password",
                value: "$2a$11$m.D3JPPD0qrAnc29hxjuWuYhih6jOC9HVii4rkRVKjfALE9gF7CyO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 113,
                column: "Password",
                value: "$2a$11$/txk9A7pYRQrQcaLDp0a1..st/AdSFlVIPLPtug0CfQwF/uvLPfzW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 114,
                column: "Password",
                value: "$2a$11$xfqn0xJ3Knyu5pbq1WwRw..G3trRyVW7aEU0OCE2nv3wtxyppPCq2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 115,
                column: "Password",
                value: "$2a$11$EM0a5xqCWSUiGzSHLqZ50ukSdDXeUeXL3hEQXPkaPZ7yTidDFgrpS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 116,
                column: "Password",
                value: "$2a$11$ZglruZWLi8GOSw7uHVxuc.IUgynfYKB.bXb5tCANb7..Bz/qGDfHu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 117,
                column: "Password",
                value: "$2a$11$yl5Hiy8AKe5xUHDWJgufYe9uFRu3TXibnZ0PXmIlz4BengtrE/Jwa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 118,
                column: "Password",
                value: "$2a$11$bJ1MW0GfhIZuQ/PGOluqxuXtm7htae7kaoOsKHZQuyS7Ca4HND2HG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 119,
                column: "Password",
                value: "$2a$11$0pi.hDc3AGhULg9NO6XV7OEtRYEhvWC1XOGq9AvU22sp6UtQTZEU6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 120,
                column: "Password",
                value: "$2a$11$ytCwb2cxevUrZf1GQjBEcOsdjDLenITwpdPSqOlCN2pQqvnTdD/v6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 121,
                column: "Password",
                value: "$2a$11$xFWXfeKTlpFR/dJ2M66KPuo0t/5oyxt7wLe0..5TkoBBGAP1Ze4/O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 122,
                column: "Password",
                value: "$2a$11$5x9aFO2ZHEChfGcCPDkFH.5BPxd9Gf8e/Ea.kunpuXnKxMNl1uF8G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 123,
                column: "Password",
                value: "$2a$11$HbNQp8MbsPoRBQ4DwEjaheCOKR84q4yrmg/Nk9c/458HGSRYc53am");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 124,
                column: "Password",
                value: "$2a$11$1g0KF0csk9QuRwm4lgWsF.f7bqN/jecoJCHrAQdkr.C6BiOB.plD6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 125,
                column: "Password",
                value: "$2a$11$wGul.TZ3H3DNBYRO/32aae8Erad77eNNbMXzkerLMFmL4SLGlv9MG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 126,
                column: "Password",
                value: "$2a$11$64hqJIET6A5Grj/81AgB0uczd5tENstB00WVkZJoohhWgrrcDPKUy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 127,
                column: "Password",
                value: "$2a$11$TksYSvRGJNHi1dPXop2RpO6.5EGIX2/8.2Bz9n7NGSt8sszKn9wau");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 128,
                column: "Password",
                value: "$2a$11$qp0Hh9Duw21KXYm/5lPmQupriPfmGZgirxxJU1Ra0YiWqMar33l5i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 129,
                column: "Password",
                value: "$2a$11$alIZlkutBbmt5bS4sQyC9.P1wLp13S9NkZCWNtvegUdQ2mgV4YDE2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 130,
                column: "Password",
                value: "$2a$11$xDqMU4BQJA1pghw0VVsXyel4XZK7T8hZbSYFC1UCjEa4VUdxzpF0q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 131,
                column: "Password",
                value: "$2a$11$pWBiC/Mgrx.Na6fsuKmGpe.rZRRnQrExfK7IHWinilNEkxwjldlOG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 132,
                column: "Password",
                value: "$2a$11$MJBPAixVNQHwNGZhcrU4ou6nD7P25sX45H9Ply0HwIVxJM21mA9aK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 133,
                column: "Password",
                value: "$2a$11$WOHf20UFMlIhrsWbY9mp6u69hEgrEwnAHaDuAwpG4xth5rT7oEGjW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 134,
                column: "Password",
                value: "$2a$11$fdnjSEiYRiZApwZxyBSHCexDSltogU.Sx23WzN06vvwV/dSg2LgKO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 135,
                column: "Password",
                value: "$2a$11$JF0X6wsnr4Yr2OmAED25NeR5xaPQYSwIi2HKGL2jA2ktaztXlXRWu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 136,
                column: "Password",
                value: "$2a$11$ohYlHk557A.d0rudBuUO5OOVlgIqaQYEqhyAt5I4WBdlHl5dNn3gC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 137,
                column: "Password",
                value: "$2a$11$C9Ajd3UZ/IXAdaXXsT3nZ.ONHn.66AHNvcaPKm0gks9fjfcgXoi/W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 138,
                column: "Password",
                value: "$2a$11$66aaZvk2B4FEd5he1NsdQeXQaQzkdpgDb5cGpq5ieVPmAFmz.jL.O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 139,
                column: "Password",
                value: "$2a$11$2VjuHPGzMH85LfD7fHWvyuFDjH.e67tJijg7KA1fHWsuMAD.oWKEK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 140,
                column: "Password",
                value: "$2a$11$gRbwKgkzqxRtcPWDp/.Wt.RAAjfJL.5/sUJLh7Ux55HE5Bt7V2wTi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 141,
                column: "Password",
                value: "$2a$11$HxaQdYULQbX01dQYMvtmYu7CFIx5nuDgppQMmhqEUejNyyOXGUmxm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 142,
                column: "Password",
                value: "$2a$11$fpFMiR/XD1zhcqzEgTpIGenAhfoIFLMjL66O76Hsxtv0SCirj0CY.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 143,
                column: "Password",
                value: "$2a$11$rcFdb07RUKF1greigL.NrO1q//7MIUiCPgrVvhhLdXlZ5YcwCk2eC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 144,
                column: "Password",
                value: "$2a$11$7YaR8PwuDaPh3AvsaAz58uR2oI1US8t0LvrSJ666OfMUgbyB9okhy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 145,
                column: "Password",
                value: "$2a$11$P1Pw7KCyFExTieJxLc2z2e9mFH3vnjvH6VvBHt7XIpWmqBMUtPNte");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 146,
                column: "Password",
                value: "$2a$11$x1Tua2nmlvnDBCn33yUEFORHriQ3/fZfOCrpmyT4gjNLZFOGAb7H2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 147,
                column: "Password",
                value: "$2a$11$mNWKkXyPGeiunX6ROdqt/.6d93urlVc7CaBcM1vbYxfBo3qYH8hFS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 148,
                column: "Password",
                value: "$2a$11$Mk5jAlWK4Ga2buyAFZBRP.xyVNh4Ic9qDAbwhz49WDgY/JTypZUle");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 149,
                column: "Password",
                value: "$2a$11$t78F4SXYWfkdK6rG1o7k3.oLWhwRP6hXUEwJuhoKKUJEr/Kw5eTC.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 150,
                column: "Password",
                value: "$2a$11$ljsdK3Di58D1SEB2JVHMGutxblFY0BtbZHuEIJhBdYYic9XRN9Fpy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 151,
                column: "Password",
                value: "$2a$11$Em.vMeuWbaYL8doSB3Y51ONJGeGV3DKDuuRKbRuMqwjF2dZnHtM/C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 152,
                column: "Password",
                value: "$2a$11$erEASdZvR6P7GVMQMlnXKuRjCjREdgHSLbJQKQt.Ac8dsAgm8pkle");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 153,
                column: "Password",
                value: "$2a$11$AK2s6qRYETDEZewK.RqDj.qPMGG1iyhtbmCt4cFB2ygPeCJzo3ONG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 154,
                column: "Password",
                value: "$2a$11$GU3MBT8tt1JpYWQPlU3Q9u1jy78YrQpJpv0g63oCSXZfLycN8EQke");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 155,
                column: "Password",
                value: "$2a$11$aqq2dlk6LRrj4QXa1Rs86uzAbZXmkm/eMgxMC4chHREz8KkrUZLFu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 156,
                column: "Password",
                value: "$2a$11$dcOb0jPmc6pXb7OMYASpUuOTBsp7TNzynMl0Mj.VYt35Luc/z1koq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 157,
                column: "Password",
                value: "$2a$11$9K4Xcg1zxisgH0MdTDwz.enXarwkbPNDFe..WbYlJjk18bAKkSLIm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 158,
                column: "Password",
                value: "$2a$11$fIa.TujINkTjEd6Wx4s5B.DUnbfH/HnZ9LG3W5fglZGND0N8KC5jK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 159,
                column: "Password",
                value: "$2a$11$DdNuxVWodMB0xDu6LUlbWOYpJqk.saQQZ91W4HKw1przPPbaFHxT6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 160,
                column: "Password",
                value: "$2a$11$/kTFhPy0AjgZDj/sjDk4eul7WE50XzWKwsqBypjRafKXMgWeB0Leu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 161,
                column: "Password",
                value: "$2a$11$TqhgjKz7eBg6lF7GyBnrne5ttU.HDwTCd2EwHn4kU/gDZdkGj/5U2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 162,
                column: "Password",
                value: "$2a$11$u6qKmgVrEtiJwOi/OglsJuskmY5QWjdpz4UpV4xY6CAnMkL/CGffS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 163,
                column: "Password",
                value: "$2a$11$9gAUD0rCZorDs5iTf3RIpOtdTO.S6tOrG4XOdoxDhVq4ilFdMrifC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 164,
                column: "Password",
                value: "$2a$11$6gPbJ6RdfphfG309omaQJueI/gsYwczCHxkbq3zwfBUQnSi7VCI5.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 165,
                column: "Password",
                value: "$2a$11$nBeg5NynobDD80gv30x7we6/znVW2e3RgsqavyAhfAzoTlAMl0qKm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 166,
                column: "Password",
                value: "$2a$11$nxYU13gCp8.mnPUEuU/uT.66N1XfwMCiBxv4mMJzMhEGSZuH1wvTy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 167,
                column: "Password",
                value: "$2a$11$jCf9mNDFNVIMCdoKPQef.ux4PbPeac/o1YLfMyw/9AJX2ayZ.RiG.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 168,
                column: "Password",
                value: "$2a$11$VxG4hMTa1phK6Jr7BciDle72mhd.j3/Omyx2cwhYIdOgmJSeDjaXW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 169,
                column: "Password",
                value: "$2a$11$AckSq50xJdPoaKHv9Y.GpuDY/ztDAz.Y2d/ruT2oOHqIAxNT0GwMy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 170,
                column: "Password",
                value: "$2a$11$EH0vb0kj7OZ0Leyb4tw8xeEIecWxsCtlyKT08T2.S3pLKCCgkQjDy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 171,
                column: "Password",
                value: "$2a$11$FiuQkt2dZpee1Vf2XuO99.knDAWhEqLM4B1LMK5FjcL8HrwNIHyya");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 172,
                column: "Password",
                value: "$2a$11$iOagbSjKGjOVm.Eisxga/.gCdOu8teV.Irie/YxApifmbVy4AZdom");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 173,
                column: "Password",
                value: "$2a$11$iCN.HTc1ewZsz8lR2mOXM.cSTtsBJc9N2Gj1w3cPPHcrVodQNdf96");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 174,
                column: "Password",
                value: "$2a$11$yp1MRvj2SA3AohXVytaf7eOJRG8fmnF.vkl1PU0mSfILg0X/2TqqS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 175,
                column: "Password",
                value: "$2a$11$TtMt.8wrKIWPXGLyOU/XSONcGwUo97sDuNuls2B91W2e1MYjOzlbq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 176,
                column: "Password",
                value: "$2a$11$jN1xKuBw/CRrGZTyE6tx7OLeOs7yZ0AWrboZdIJ//PmO18CvhzKri");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 177,
                column: "Password",
                value: "$2a$11$dijkcP9uHVGlo8ph4CC3KeQd.qEp/Ftaluw7WyRf3x4VsCI2JmPry");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 178,
                column: "Password",
                value: "$2a$11$MI.MhJSYXOjpcisYzqq89u8osy3WGZB2vImblZLAoNh.uWTRMBgnq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 179,
                column: "Password",
                value: "$2a$11$btjGEMEp/YaVLHWrBvgMpuMzg3I.cP1fMhrgiXykN.WFwTkMUklD.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 180,
                column: "Password",
                value: "$2a$11$Ym73TCPWmtXu7xqpFBLH7e/.wYZaCbEYvAa0fPsXkq380saCWoNqC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 181,
                column: "Password",
                value: "$2a$11$Ub.0tzD2R1q.gdpo/hZGBuri3D5xmTnT27ppPmpZCnb0nzmwGSwLK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 182,
                column: "Password",
                value: "$2a$11$1Y1n/p6IebANWq.FLLlmkOJpag3ulV0m/Lj2exlIarfccpCq3Gh4C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 183,
                column: "Password",
                value: "$2a$11$0kd6YKpJim16xaHONH7KLeEJen0FGvYCz/pRkjaVNYrsgm0nFtZB.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 184,
                column: "Password",
                value: "$2a$11$5ZTEkjhjqqSuzcPC0mg7BuJIeYOJ7QYR2rMxJPJAixPXIvfxDMEdG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 185,
                column: "Password",
                value: "$2a$11$QF9LsMVlnC52iM42wwKl9e6DacHjmLbw.Ah5Z7KILjZpjKzcCOir.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 186,
                column: "Password",
                value: "$2a$11$3bq6rhOq9Qc.YwtngkBoRuMbUwnW1A5DAwtO6dOnHzEKHmoLpazR.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 187,
                column: "Password",
                value: "$2a$11$iVOigdvwdbU7ZJlsyJc7yeVbul2f3Of4ERegVbo03urKP9mo2ph/m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 188,
                column: "Password",
                value: "$2a$11$kKeWwcc3CsVnnvoXsrRUfugslW.EhG8UFFBXuGvbIAnGSPBib7ra2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 189,
                column: "Password",
                value: "$2a$11$tKnfg9k9wKWdMroaUFWhBuCx7mIDNkk8AL/mFZCYXAo5XJUjgttVi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 190,
                column: "Password",
                value: "$2a$11$zHHBVxeiTLx1iIzTP2/1CeJTgHxsH7hXPrm4rNRDj9NkAZNNdyB0G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 191,
                column: "Password",
                value: "$2a$11$wgCI0LwBmBQZ1hxOW/b9oureWBUEB5DBu4IxrnAC.9ou1nSb8QikG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 192,
                column: "Password",
                value: "$2a$11$7.HL8voIaVFiak9tJGOJHuF1Au4oAj6PHgw0tv4G0J5CJLCkN2s.W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 193,
                column: "Password",
                value: "$2a$11$gRAI2CSWfz846YVAafU3XO62AmXOnzmCJC4.TC/8HlgTFdQVIudde");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 194,
                column: "Password",
                value: "$2a$11$kWui1PsefoRNNdZ0ig.prO1GcEpmJtJkPguJVbpoYDA50Itw2N7XG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 195,
                column: "Password",
                value: "$2a$11$fsEZa4oKz0UnBMo4MFouUOQ8SJnS.LYZVDhU5LAoT7Lrfl.5dHgi6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 196,
                column: "Password",
                value: "$2a$11$DiLWlI/44OONn2iSDvYrH.N9Bd5iA1eVCRQq/yfH68n.qyfH/jHLS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 197,
                column: "Password",
                value: "$2a$11$gI05/TVvUVIGm6Ppn.Bqg.h5LmM6wMC2INMwYAFz4DNxgk3anvedi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 198,
                column: "Password",
                value: "$2a$11$Bbfk0jyypM46ShHs2yjwU.h3CylihcFAXFvwW/i5wtAanwd3U6vkm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 199,
                column: "Password",
                value: "$2a$11$v0DYeX5pG7u5ISmFSe/qJuFuUwawdNRNBm5FFJP5H78CedOBHXWv.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 200,
                column: "Password",
                value: "$2a$11$Rtrr9K.pBA0Vut2Phdaun.fIeSpyAcLm1bg1OH8FUnJOfNiqnwcoa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 201,
                column: "Password",
                value: "$2a$11$dYeMzrtEgrxRGdXTPuBC7uxLMyEoyezHdNy1dFn2sLumhUf2tA41K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 202,
                column: "Password",
                value: "$2a$11$XUFd9/fYZ6cXSIfrIXS8Uu6Z2E/GA1mkYSACjFRIYGg.7AJS/BkNS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 203,
                column: "Password",
                value: "$2a$11$7oNTBYq9F/aqWU4wGy2/Zuv69Eyrct9ZzaL4WSeM0Zj38eVhOcriK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 204,
                column: "Password",
                value: "$2a$11$gei.KURAZsHZW4NlZ67J7ekyJ7PM3ZFPwJhi5oE3uqhGmWLnSy0Ta");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 205,
                column: "Password",
                value: "$2a$11$gWlcfd/ZMz1/uZb7IHK9POZzuDWTr81OfDDwC4XjNugDQ/pdR6fIG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 206,
                column: "Password",
                value: "$2a$11$4ASFPv.PzkfiiugKYZ47qOZ1I9tr7/eje4TiRK4hHxTSt/On.uGTy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 207,
                column: "Password",
                value: "$2a$11$jLGf1mwPSBToj6.EkiMrT.plW0SI2.4yvztf0LZsH3lzshvs3sAXq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 208,
                column: "Password",
                value: "$2a$11$OVQCmetDEba4210w.FNJYew6e.1vGxCTXu/ZYjmLZvAUj8GI1ZOEO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 209,
                column: "Password",
                value: "$2a$11$O06STdna7Xr491Wgs7KMgej97Bh3j1z1PmhAOCnG7FjAO686qzGsm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 210,
                column: "Password",
                value: "$2a$11$Vq2SFCRcM83QBalwp22E/Oz3V7Y9X0V8osbADYzy8JTzCWuJvPlU.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 211,
                column: "Password",
                value: "$2a$11$YQ1Ly.xq3wBlDE7bF2F10.bMyP.5V5WT2.TS3MyVs0tdEjOjMocuK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 212,
                column: "Password",
                value: "$2a$11$JVsvwOH0O5QYMiTpqerrg.o2VnSmKXuATQKYnQyVmHeDkcoqAHBGW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 213,
                column: "Password",
                value: "$2a$11$gY6fXxze7dX12dzZfNRWye53e0xNmgnsR72LsjRSc6bAaev7Esii6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 214,
                column: "Password",
                value: "$2a$11$CoywC79In9DH1LJsW4lZY.iVoeXxSdI68gUaTmsftVuFH6gVGw8UW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 215,
                column: "Password",
                value: "$2a$11$Fon22ugwn1gO0JlTnrCMu.fpi/XFbX0nFiH62lJR3ato9xa5y4Vk.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 216,
                column: "Password",
                value: "$2a$11$NkaGCPxcy/1cldJ46r68LOb.bJD23iTFrcJk4FBprPpLumbNJb20S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 217,
                column: "Password",
                value: "$2a$11$Hg.GcqRN89AwmoXoT9/QnO46Cp11ZF42UgSCjxOmz0c/EJ0X5TWku");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 218,
                column: "Password",
                value: "$2a$11$fmac4XdL0thsNZKzdVPtmubH3CXDJtOkiHziji3fg4XOcmFcm0tha");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 219,
                column: "Password",
                value: "$2a$11$nH4Ml75JM7KwsZ/hC60oa.ugCQF/WAhhSSxtf/uTcO9a1L4ldqd8m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 220,
                column: "Password",
                value: "$2a$11$F0BIRLVcPYtM7TZQHXOH4uO6orB4tI6OYACooJ6Aho.Sk6KH5cvJy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 221,
                column: "Password",
                value: "$2a$11$D0vzcUHZtvBz0cH7cFFEVe.myRP9uhzt.T.TzAkMTKYmIFQIoVcfe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 222,
                column: "Password",
                value: "$2a$11$P0ZvNMUzopIjKK5he3bldOoRe5C2UQl2Dn9Ay7FiudK.FeNTNxGKK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 223,
                column: "Password",
                value: "$2a$11$m2cTOO17IaTo7ra1/x5rNOEDgJmMeHwobbaKwwZ77zyxIHb68jiji");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 224,
                column: "Password",
                value: "$2a$11$awh4TEZLQgSd5Eve2HlcCOE3Z4mslUjExLLi2KC5K7ZsakkqIfeG2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 225,
                column: "Password",
                value: "$2a$11$.0etbdzAasNkyznFN8U9rOE8BRAOLGI6Niyu3n3f0Rz9ZcqThAjzW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 226,
                column: "Password",
                value: "$2a$11$TOZPOTue7/U5R5s3tD62tejKDirWv1fBYRnpZKTx/5O7s7UkXRnXy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 227,
                column: "Password",
                value: "$2a$11$RY/NNkXE6MlMpYAN.IWGj..2DXfMSiLaDd9l/zoYGxG/o0EvHcC3O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 228,
                column: "Password",
                value: "$2a$11$zoGCTLXXGU69x0JTndKHDe8QBzSZ..cacTslC1sLeFTHVz2Nv3gIK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 229,
                column: "Password",
                value: "$2a$11$BXPzvxSAJxD5eNIT2SV.kuOQJwNK4YRvuSlaeugUhVpcIJ8jnxcse");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 230,
                column: "Password",
                value: "$2a$11$a4eY7Uy9lngA.8k63ab71.cqD53Du1cn4MCtIDqQ6tPKLsBKPN59W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 231,
                column: "Password",
                value: "$2a$11$UU0HJwR15SSi2b2B4coQPOVaPNcegFUgFyrTQ3Hstl0WfjLbsWc4y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 232,
                column: "Password",
                value: "$2a$11$1vRj1BfsBFGfY/lD9zrviOutAXTGcVMST.IsDxE9kUd9bu0kzJQoa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 233,
                column: "Password",
                value: "$2a$11$bXrWRebfV/Jk3WFClb4MzOLJurdK2oiz7TAA1/qceoekN3hmc7N4K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 234,
                column: "Password",
                value: "$2a$11$hZFIFD83vT4rD6sxC5IhXuFLpRfzYaVUXzOt94GbOmv31vRNP9SWy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 235,
                column: "Password",
                value: "$2a$11$2omQAGcM4gSbZ3gzXiR3JOSc4BHvrsQUNUO7H60OTbMnJOQR5y/cC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 236,
                column: "Password",
                value: "$2a$11$VmHU4rH7AGUElLQmDnDXwu74Ph3Xj.fTimvKPp5m.6MCkeBS/B8aa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 237,
                column: "Password",
                value: "$2a$11$fw/1458uFv5PxOgUSvzhW.oqkre90/.gLjKi0hXYmPV/Gx.8dP.mC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 238,
                column: "Password",
                value: "$2a$11$as2pZF1kkXkXz1J3wFfheOrrniCa/VSI93C5FMIT2JzRaFVE1Cmfq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 239,
                column: "Password",
                value: "$2a$11$gAxBOV6ESaFs4VSRFHt.5uz1U4w3E4HfOyPCmZhUoP.YeTXevI9VW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 240,
                column: "Password",
                value: "$2a$11$d9z5rw4s8OC.TRgDmJ0qyOQMmmW9VVb/eucs/08IX4DeKduvZ.FDy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 241,
                column: "Password",
                value: "$2a$11$IQIGQrnfsisSfVwyjNnx9.W6fwpUgSCuVyXv.ph0ihiv7VZTLAxP2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 242,
                column: "Password",
                value: "$2a$11$fZ4BXyULDU5stTwE4RM5.OiV7ka1YUoPm3v1wmHGFx/IT5L0/8rqS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 243,
                column: "Password",
                value: "$2a$11$Hr7iVSkjCKaeY9ZLaY2Db.Y9GFF664wXJMFSmfC60ikvE6d2OPHui");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 244,
                column: "Password",
                value: "$2a$11$ZFuPW6aBup2BVwxdnRgOl.lrsxBospd9FEl7prL42ASUCDOtt9niy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 245,
                column: "Password",
                value: "$2a$11$XxSYcInAhcLy.XT.K16/Vu3iva/QMUKpeuSqMe.cctKrxXShaPiym");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 246,
                column: "Password",
                value: "$2a$11$ddwEAcedOBXR9vNZvAkKpuMkNaq0nB/owgASM7S3AFyQt34lnZwJi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 247,
                column: "Password",
                value: "$2a$11$uldGwYc.TafzLyRsgSdlYuFO6xmXJb8dNBcfXMOFjj4plvrVUkR6i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 248,
                column: "Password",
                value: "$2a$11$qqW1ZT2614LtpW6hjy/OguA/KoEXz5s27QhCO.XyAJi8oWmQYLR/m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 249,
                column: "Password",
                value: "$2a$11$4krZzzaKI5axPNtZOk9kpeDlnXd0AYLaRL8mJw/S8.SLctDJJ2Fn.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 250,
                column: "Password",
                value: "$2a$11$U5FMPjsU5ewdgbiaDSQAi.r/d4UPkwj4zr1qE0G/Q./9JrBlT4546");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 251,
                column: "Password",
                value: "$2a$11$twFCjOuxTLL1ruslvfGjHOuuyTeW3e03/Zzw3pJyvCUi6WMPRvZnq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 252,
                column: "Password",
                value: "$2a$11$GE8/VnjUMEAiaYHuZeR20e4YoBI272pCMH.ty29REA7bgcQ7ZNuEa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 253,
                column: "Password",
                value: "$2a$11$wTVSmsbvKpYNgl70JylciusqetHdcklFpICsW0l.N3Jt7F8nJV8Nq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 254,
                column: "Password",
                value: "$2a$11$7j10bo.s.9SBlXHGpu7PD.fAW/3pB3MXTvHTqVsRcKGrOc9f/gbWO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 255,
                column: "Password",
                value: "$2a$11$z10mnq1.QSfGIR/XeV52qOA5tly.o588Isuha5SrhZOiRFjaZo/pe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 256,
                column: "Password",
                value: "$2a$11$.AM0IDt2XLaVqBPUBv9Idesb3SWIm3R06.9wcmPB6BhqYNyfhZLz.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 257,
                column: "Password",
                value: "$2a$11$IT7owf9pDZcSTxLg61nO1ecTYqryraQ0yAVsuvsvP4SnWT4KB9Zc2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 258,
                column: "Password",
                value: "$2a$11$o.quHpRf35I.klQh45gZ5.JSm11GiXaEVREFhsyNn1l4f9BOMRtSq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 259,
                column: "Password",
                value: "$2a$11$l6HcbQfwQvhhzDKQg258aOvsY9cN.zGB3ygdTA3.xunceAWFEZWWe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 260,
                column: "Password",
                value: "$2a$11$laqwX9aKt65ixVXN2nrLCOr13EDlDBvKpI0v.aSF64Ml2q1eUzmhy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 261,
                column: "Password",
                value: "$2a$11$/.xYESPSq6rxlytE0dYF9OZnMGUNe9eOE9S7qN5tWzw0.jesTrllO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 262,
                column: "Password",
                value: "$2a$11$7jv1egcraACqJ6g7bpdlnuUMk3l2zOEdIz4dxNnxfNQLJd0RN359y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 263,
                column: "Password",
                value: "$2a$11$O7OOjBQo6ntCKVUIzavmcevW0YWMrAZoW/hYg7UOGAze3Naqy6lHO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 264,
                column: "Password",
                value: "$2a$11$36dWiHFAP6pmbdvJ.uDm7er.8ZmRZh9k5wiYfrulugtFfk9RwbEre");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 265,
                column: "Password",
                value: "$2a$11$r4aU2iWp8KaQmu.ia4Uvaeovk6TZErlNNAxl7GdyJC1Krrsu4jAWu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 266,
                column: "Password",
                value: "$2a$11$fQyzBRSYQRZcyxygm7DPIOCggHET9TWl.58u51g7CFro3esW.jQP2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 267,
                column: "Password",
                value: "$2a$11$HFzOZTCxtyDvarvE5qF5QORbEtcWpItfLciCvnOdCjUK2zo2Iae5G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 268,
                column: "Password",
                value: "$2a$11$6cH9vDMFc979eIm5GpCbOudx02azeyUw1nxgg1CLtzol5V1ABK.Zi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 269,
                column: "Password",
                value: "$2a$11$Z6k4htmZsuTAP0oH1JiUQeugl8uF30B1bsRqTtYj2Mg/mvLXwHX3W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 270,
                column: "Password",
                value: "$2a$11$9Aj2cFGvqE86CklRcKbHAOHEK2FFYiogrYcaA8hGwFYkRd9S11nDS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 271,
                column: "Password",
                value: "$2a$11$M8r556n/2jpRhS8gtwvgC.li7RWkXYmVGyl3GmTfoU5WAdlk/i2Ee");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 272,
                column: "Password",
                value: "$2a$11$yhWWn0kK/Psv0CEL8p0YJea8/Jg2N0i.oNaW6SKwYlknnZ9zbOZim");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 273,
                column: "Password",
                value: "$2a$11$2UTuMFngNV8HLa3p6wdioe.Yhy9K91g.Ev6gQJCmPONCXqYHC2mum");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 274,
                column: "Password",
                value: "$2a$11$VYuEvV.fETEm0ZG7dBFcpOULnsY1hbTRhH86KLQ1gNLtShB3zVa1u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 275,
                column: "Password",
                value: "$2a$11$hcVjR2YzVCn/D5MvGXOwi.ahgKiHIF61Xl69yzNgPyWWYR.WkKH9.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 276,
                column: "Password",
                value: "$2a$11$f2p/Cmf2LvYYrpI/zl01tulhdNvkv3BPQAHXGxRLbWBc5O42923ES");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 277,
                column: "Password",
                value: "$2a$11$.Anu1MuSuPzfxdP8Atwn7uB9mVFmv340C6V.z26qLqaCDz3PzARWO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 278,
                column: "Password",
                value: "$2a$11$/0MeIk3wrBuODPX3fhuuI.NXY2yRgI2cxfOMj1BMcghL3UYS5msPy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 279,
                column: "Password",
                value: "$2a$11$XxOtYTrG7p5LrelZuxwrmewRFCKmAmG0xIaeNGxoZygogTEh9KU2e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 280,
                column: "Password",
                value: "$2a$11$xsXhiR0oa16LW3Jy2zqlh.054kwieiuCTsnw2kHgVPsBQ8vtRclKq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 281,
                column: "Password",
                value: "$2a$11$vW.lXcbJIgRHBz1fZwc04e72Dr19ftlWw2oW1IrU0x/o4p5jXGBwm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 282,
                column: "Password",
                value: "$2a$11$uJTjYZe95nwbbaU.4mH0iubPi2AtvP4pqJBvRIMTKHsrNOAOhIBgy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 283,
                column: "Password",
                value: "$2a$11$EQG5n4mKceTeUnEWZWY9qu/cMWkxQM9v0YgbB0mnsL8ftxfdr6IhS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 284,
                column: "Password",
                value: "$2a$11$ftvxk1ECNmdNYxGceli/jOO.LYg0nixVugXvoHWOGFMc1S6uVIdZK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 285,
                column: "Password",
                value: "$2a$11$cWbKA4Px0WjTPdae/4uMSODHTCHEeZa0hftVZ9W6dDgADkKll0oTy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 286,
                column: "Password",
                value: "$2a$11$.HK4FbfXkvgT5TXETvJPZOa7Uf9oJjjsJwrtt1qvMYNSatYZeXnL.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 287,
                column: "Password",
                value: "$2a$11$kgwe8vx.AufZFxysea5oqO42Gonsra0xcn2a6qS572IoCNJ16NIfe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 288,
                column: "Password",
                value: "$2a$11$PBvipU96g7SbfQbuEjtohex0SGDyfvswgwy3ErwH9TKVulk7jmKra");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 289,
                column: "Password",
                value: "$2a$11$YCPz0wq6uzwcqe/Y929VNOcr/F3LVYoOSC51c1tcTbFZmKwt.thvW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 290,
                column: "Password",
                value: "$2a$11$d1oMDB3MbDb/Af2vafvNvuphSXRUiOiHwmZTJIOy2IBhuxVzJpm.i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 291,
                column: "Password",
                value: "$2a$11$ucwGwUayD.GDBwnBvpqz7Os17hW4aW95V3WXO47U9.et.3f6uX0ju");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 292,
                column: "Password",
                value: "$2a$11$3NKOJopDJ7fUOiomWB1DAOU9bWM1sVmH6WNm7AQAjCgq5kk4BCT7q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 293,
                column: "Password",
                value: "$2a$11$4awiSXIOyByr9t.s4.Kb1.RlqD9VNV5fgn.WrXiNOk9j5i3wDjvM2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 294,
                column: "Password",
                value: "$2a$11$4F1lNOT6VyQ3IO1IdXTrJ.6APRRNeOxLagCvJuR9KctMbeDL5ou2e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 295,
                column: "Password",
                value: "$2a$11$qSuBfUjArfDXQOGmXCTIGOfwIl24xtuJ3Z8vViVjwM2qHWDtXachq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 296,
                column: "Password",
                value: "$2a$11$EJMt6.Pf8lohZnznj1AaYO9eWhbTAqhpRvE.DFGo91qHO0Dlz/gBu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 297,
                column: "Password",
                value: "$2a$11$CA3d2ca7QpRQG70ngFD/a.V7gyy5TWfj4azWFSnrlHWVeCLbRsQGa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 298,
                column: "Password",
                value: "$2a$11$EfcGGctWywgW5yG7jIwF2.V5waOjSMKK8otakKW5kTd/N2J5PTMxu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 299,
                column: "Password",
                value: "$2a$11$vOIC/FudOX9picmF8KL3rups4Egce818U1WLe5UysCQMqwR32fGKy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 300,
                column: "Password",
                value: "$2a$11$6y7YGeM4eM/3eJEBJ8Q3N.7Zw2u2LPPv5kjMYfHhy6iapo1PSXWSa");
        }
    }
}
