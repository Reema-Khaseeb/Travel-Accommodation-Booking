using System;
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
            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 156);

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 3, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5881), 0.13578736877273778, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5932), 391.09269105635633 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 1, 17, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5968), 0.71715809682639675, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(5970), 63.21583018677196, 1 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6013), 0.23486167218480547, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6015), 77.387719294194028, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2023, 12, 24, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6020), 0.37752061152419092, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6040), 46.274205392734416, 4 });

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6153), 0.2463723779978908, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6156), 218.01610038497239, 4 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 26, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6191), 0.012421167863192251, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6193), 97.090673217651684, 5 });

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6213), 0.38426657807503561, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6214), 492.48075753882688, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 25,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2023, 12, 5, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6220), 0.74120763180308602, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6222), 176.70036508841713 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6242), 0.39407272885459832, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6243), 453.12920553612184, 1 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 3, 1, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6256), 0.54439825754079407, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6260), 167.70498889440287, 2 });

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 9, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6290), 0.25280196548524358, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6292), 222.63846863796545, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 34,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 20, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6298), 0.95405976285232841, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6300), 60.327920436095084, 4 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2023, 12, 2, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6335), 0.973232342393202, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6336), 354.35322785530906, 3 });

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 2, 4, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6349), 0.3472833194393572, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6351), 301.07089755170722, 2 });

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
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6378), 0.64719963583542572, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6379), 411.84321007130876, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 46,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 7, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6385), 0.61201181498538804, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6387), 409.29115009104999, 3 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 11, 25, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6407), 0.6168586627193664, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6408), 312.50039727113347, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 50,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2023, 12, 26, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6414), 0.73818373832723283, new DateTime(2024, 3, 3, 14, 19, 31, 768, DateTimeKind.Local).AddTicks(6416), 348.90915932941368, 4 });

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
                column: "ImageUrl",
                value: "http://example.com/hotel2_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "ImageUrl",
                value: "http://example.com/hotel2_image2.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel3_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image4.jpg");

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image4.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 38,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image1.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 24, "http://example.com/hotel24_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 24, "http://example.com/hotel24_image3.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 26, "http://example.com/hotel26_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 70,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 71,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 72,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 73,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 74,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 75,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image3.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image5.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image4.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image3.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 114,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 115,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image3.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image2.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image2.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 45, "http://example.com/hotel45_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 124,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 45, "http://example.com/hotel45_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 125,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 46, "http://example.com/hotel46_image1.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 128,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 129,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 47, "http://example.com/hotel47_image3.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 49, "http://example.com/hotel49_image1.jpg" });

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
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 138,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 139,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 140,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 141,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 50, "http://example.com/hotel50_image5.jpg" });

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
                column: "Amount",
                value: 225m);

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2150), 179 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2354), 85 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 7, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2392), 149 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 6, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2441), 224 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 10, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2476) });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2569), 35 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 9, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(2589) });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3595), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3597), 169m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3602), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3603), 427m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3608), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3609), 125m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3613), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3615), 290m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2023, 12, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3632), 47, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3634), 474m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3638), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3640), 227m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3643), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3645), 238m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3649), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3651), 490m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3656), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3658), 253m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3662), 45, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3664), 456m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 11, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3667), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3669), 160m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3673), 18, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3675), 249m, 2 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3689), 10, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3691), 459m });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3712), 32, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3714), 398m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 2, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3718), 29, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3719), 437m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3723), 12, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3725), 384m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3740), 31, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3742), 268m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3745), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3747), 308m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3751), 31, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3753), 420m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3756), 44, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3758), 141m });

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
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3767), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3769), 242m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3773), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3775), 113m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3778), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3780), 53m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3784), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3786), 127m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3790), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3792), 132m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3806), 15, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3807), 187m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3811), 37, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3813), 484m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 23, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3817), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3819), 56m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3822), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3824), 478m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3828), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3829), 477m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3833), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3835), 170m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3839), 33, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3840), 257m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3844), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3846), 78m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3855), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3857), 271m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3861), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3862), 71m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3866), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3868), 253m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3872), 4, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3873), 321m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3877), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3879), 330m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3883), 12, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3884), 133m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3888), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3890), 430m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 51,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 2, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3894), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3895), 499m, 1 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 20, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3904), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3906), 492m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 54,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3910), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3912), 354m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 55,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3915), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3917), 297m, 3 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3926), 16, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3928), 80m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 58,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3932), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3934), 369m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 59,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3937), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3939), 53m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 60,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3943), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3945), 262m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3954), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3955), 118m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 63,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3959), 19, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3961), 370m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 64,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3965), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3967), 94m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 65,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2023, 12, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3970), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3972), 485m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 66,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3987), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3989), 385m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 67,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3993), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3994), 423m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 68,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(3998), 32, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4000), 486m, 2 });

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
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4009), 1, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4011), 55m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 71,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4014), 36, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4016), 372m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 72,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4020), 3, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4021), 452m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 73,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 2, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4025), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4027), 254m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 74,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 31, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4030), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4032), 490m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 75,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4036), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4038), 188m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 76,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4043), 98m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 77,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4047), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4048), 209m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 78,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4052), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4054), 458m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 79,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4057), 24, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4059), 273m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 80,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 28, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4063), 47, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4064), 180m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 81,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4068), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4070), 469m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 82,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4073), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4075), 226m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 83,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2023, 12, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4079), 50, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4081), 128m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 84,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4085), 48, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4086), 266m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 85,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4090), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4092), 138m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 86,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4095), 10, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4097), 100m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 87,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4101), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4102), 389m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 88,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4106), 42, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4108), 417m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 89,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4111), 43, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4113), 184m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 90,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4117), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4119), 464m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 91,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4122), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4124), 315m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 92,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4128), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4129), 355m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4139), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4141), 117m, 3 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 2, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4165), 39, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4167), 245m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 98,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4171), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4172), 393m, 3 });

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
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4182), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4184), 116m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 101,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4188), 34, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4189), 346m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2023, 11, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4199), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4201), 119m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 104,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4205), 2, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4206), 355m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 105,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4210), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4212), 159m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 106,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4216), 14, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4217), 233m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 107,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4221), 38, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4223), 268m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 108,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2023, 12, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4227), 5, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4229), 338m });

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
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 29, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4238), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4239), 198m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 111,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 9, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4243), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4245), 116m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 112,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4249), 26, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4250), 301m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 113,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 1, 27, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4254), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4256), 332m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 114,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 2, 5, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4260), 50, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4261), 183m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 115,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 7, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4265), 20, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4267), 161m, 3 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 21, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4276), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4278), 161m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 118,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 2, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4282), 17, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4283), 338m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 119,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 8, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4287), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4289), 370m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 120,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4293), 28, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4294), 84m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2023, 12, 11, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4304), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4305), 448m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 123,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 17, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4309), 23, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4311), 367m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 124,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2023, 11, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4315), 3, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4316), 444m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 125,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 12, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4320), 37, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4322), 308m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 126,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 16, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4326), new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4327), 447m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 127,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4331), 46, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4333), 238m, 2 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2023, 11, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4358), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4360), 61m, 2 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 13, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4369), 40, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4371), 406m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 133,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 14, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4374), 30, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4376), 263m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 134,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 3, 1, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4380), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4382), 345m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 135,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 26, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4385), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4387), 131m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 136,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 10, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4391), 35, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4392), 169m, 2 });

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
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 11, 30, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4407), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4409), 445m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 140,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 2, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4412), 14, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4414), 465m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 141,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 25, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4418), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4419), 416m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 142,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 12, 6, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4423), 25, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4425), 262m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 143,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 22, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4429), 27, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4430), 461m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 144,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 2, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4434), 33, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4436), 314m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 145,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 15, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4439), 9, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4441), 472m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 146,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 19, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4444), 41, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4446), 495m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 147,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 18, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4450), 22, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4452), 245m, 2 });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 24, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4461), 21, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4463), 376m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 150,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 4, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4466), 7, new DateTime(2024, 3, 3, 14, 19, 31, 769, DateTimeKind.Local).AddTicks(4468), 124m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW CityWithHotelsCountView;");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 13, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9050), 0.26607703703040675, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9106), 207.62662892835166 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 1, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9119), 0.31104552488511694, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9121), 419.89926066259238, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9125), 0.34375592893847184, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9127), 160.78603247741685, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 2, 17, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9137), 0.81300788740028163, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9138), 246.3995317731007, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9156), 0.53542674031254922, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9158), 418.15359739165871, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 9, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9167), 0.1269895251785832, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9169), 347.84512797119652, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 3, 1, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9181), 0.36443835264551272, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9182), 284.18018656580489, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 1, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9187), 0.61649908133488274, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9199), 53.571169054523473, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2023, 11, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9203), 0.37903679643108878, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9204), 63.014785329155941, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 1, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9210), 0.014799077548337647, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9212), 251.26473078253065, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 1, 2, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9216), 0.068749572399941949, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9218), 83.547330918057156, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 2, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9222), 0.0040684021320935848, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9224), 458.58049003731105, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2023, 12, 12, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9228), 0.61698067479168039, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9230), 488.99166711151679, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 2, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9234), 0.70775628727454021, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9236), 182.1924570334954, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 19, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9240), 0.98676087201457663, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9247), 457.55252201662159, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9287), 0.96034293278532201, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9288), 297.52947190853649, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 9, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9293), 0.31462598875022496, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9294), 291.98308593824203, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 1, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9299), 0.16304992015180286, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9301), 82.410094102683516, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 1, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9305), 0.50047726173240337, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9307), 27.365656017701966, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 1, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9311), 0.66864781713809085, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9312), 324.23933613374044, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 21,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9317), 0.93535868045704773, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9318), 143.82076359881617, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 22,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 1, 4, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9328), 0.89434298025659309, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9330), 130.47043415689913, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 23,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 12, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9334), 0.27812415698039905, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9335), 163.37808989501491, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 24,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 1, 21, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9339), 0.95712812341751341, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9341), 419.77050925882418, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 25,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price" },
                values: new object[] { 7, new DateTime(2024, 1, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9345), 0.071540492504341358, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9346), 334.61520626962675 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 26,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 2, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9351), 0.48295718420337252, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9352), 375.7098860001596, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 27,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2023, 12, 15, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9356), 0.81983172667731219, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9358), 166.69148800383732, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 28,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 12, 4, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9362), 0.12011449427748488, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9363), 144.49140093531764, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 29,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 17, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9368), 0.056684722791614628, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9369), 434.40684687391825, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 30,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 11, 26, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9373), 0.62913536724868158, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9380), 206.32641326471185, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 31,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 1, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9385), 0.7544351129247846, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9387), 267.86929687869247, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 32,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2023, 12, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9391), 0.34782127536085106, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9393), 423.04577880643649, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 33,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9397), 0.33029485938421432, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9398), 206.32910273291915, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 34,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 12, 30, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9403), 0.62818545164068962, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9405), 317.00601811301931, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 35,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2023, 11, 28, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9409), 0.99119696581329797, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9411), 496.92017591467521, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 36,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 1, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9415), 0.25714609027592972, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9417), 377.42328210700475, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 37,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 2, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9421), 0.058177838476916044, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9423), 172.76051916923291, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 38,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 1, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9427), 0.45139379777436106, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9429), 299.12994389281249, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 39,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2023, 12, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9433), 0.65855247917477189, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9434), 387.43166825383332, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 40,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2023, 11, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9438), 0.95836666671121573, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9440), 307.1046870106544, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 41,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 11, 25, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9444), 0.83957864276462091, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9445), 403.24621625019472, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 42,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 1, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9453), 0.26666158009501773, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9455), 213.9155727936361, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 43,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 2, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9459), 0.33487938440345655, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9461), 82.587825475299198, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 44,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 12, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9465), 0.3012979657415964, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9467), 228.45926642693547, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 45,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2023, 12, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9471), 0.48192930590233496, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9473), 483.67146008983423, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 46,
                columns: new[] { "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9477), 0.6082468248398234, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9478), 92.62996335183071, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 47,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 12, 2, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9483), 0.16145323270673562, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9484), 452.15316611299949, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 48,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 1, 28, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9488), 0.33158335675268658, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9490), 215.48774378435155, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 49,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9494), 0.57105885958489933, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9496), 54.898867069570869, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 50,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2023, 12, 10, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9500), 0.074460205571621918, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9502), 123.44581081397077, 1 });

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
                column: "ImageUrl",
                value: "http://example.com/hotel2_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "ImageUrl",
                value: "http://example.com/hotel2_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 2, "http://example.com/hotel2_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image4.jpg");

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
                values: new object[] { 4, "http://example.com/hotel4_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 15,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 16,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 17,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 18,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 5, "http://example.com/hotel5_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 6, "http://example.com/hotel6_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image4.jpg" });

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
                values: new object[] { 8, "http://example.com/hotel8_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 30,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 33,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 34,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 35,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 36,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 38,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 14, "http://example.com/hotel14_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 49,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 50,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 51,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image2.jpg" });

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
                values: new object[] { 18, "http://example.com/hotel18_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 66,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 21, "http://example.com/hotel21_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 67,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 22, "http://example.com/hotel22_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 68,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 23, "http://example.com/hotel23_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 69,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 24, "http://example.com/hotel24_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 70,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 71,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 72,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 73,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 74,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 25, "http://example.com/hotel25_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 75,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 26, "http://example.com/hotel26_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 76,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 26, "http://example.com/hotel26_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 77,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 78,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 79,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 80,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 81,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 27, "http://example.com/hotel27_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 82,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 83,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 84,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 28, "http://example.com/hotel28_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 85,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 86,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 87,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 29, "http://example.com/hotel29_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 88,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 89,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 90,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 91,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 92,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 30, "http://example.com/hotel30_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 93,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 94,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 31, "http://example.com/hotel31_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 95,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 96,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 97,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 98,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 99,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 32, "http://example.com/hotel32_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 100,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 101,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 102,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 33, "http://example.com/hotel33_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 103,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 104,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 34, "http://example.com/hotel34_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 105,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 106,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 107,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 35, "http://example.com/hotel35_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 108,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 109,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 110,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 36, "http://example.com/hotel36_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 111,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 112,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 113,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 37, "http://example.com/hotel37_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 114,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 115,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 116,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 38, "http://example.com/hotel38_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 117,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 118,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 119,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 120,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 121,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 39, "http://example.com/hotel39_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 122,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 123,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 124,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 40, "http://example.com/hotel40_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 125,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 41, "http://example.com/hotel41_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 126,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 127,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 128,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 129,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 130,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 42, "http://example.com/hotel42_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 131,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 132,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 133,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 134,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 135,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 43, "http://example.com/hotel43_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 136,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 137,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 138,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 139,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 44, "http://example.com/hotel44_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 140,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 45, "http://example.com/hotel45_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 141,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 45, "http://example.com/hotel45_image2.jpg" });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[] { 142, 45, "http://example.com/hotel45_image3.jpg" });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 143, 46, "http://example.com/hotel46_image1.jpg" },
                    { 144, 46, "http://example.com/hotel46_image2.jpg" },
                    { 145, 46, "http://example.com/hotel46_image3.jpg" },
                    { 146, 47, "http://example.com/hotel47_image1.jpg" },
                    { 147, 47, "http://example.com/hotel47_image2.jpg" },
                    { 148, 47, "http://example.com/hotel47_image3.jpg" },
                    { 149, 47, "http://example.com/hotel47_image4.jpg" },
                    { 150, 48, "http://example.com/hotel48_image1.jpg" },
                    { 151, 49, "http://example.com/hotel49_image1.jpg" },
                    { 152, 49, "http://example.com/hotel49_image2.jpg" },
                    { 153, 49, "http://example.com/hotel49_image3.jpg" },
                    { 154, 49, "http://example.com/hotel49_image4.jpg" },
                    { 155, 50, "http://example.com/hotel50_image1.jpg" },
                    { 156, 50, "http://example.com/hotel50_image2.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 85.8024679340843m, -138.208683985617m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 8.55542497490222m, -171.061129108214m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 81.4594556078252m, -34.5147731670494m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -58.776346195188m, -117.951796197454m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -85.3979937574516m, 112.641061609543m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -27.1214291554759m, 110.278087108883m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 7.23342953400964m, -166.348134749565m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 49.5053498785352m, 92.1670240571938m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -53.8878235886015m, -150.612335639289m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 62.8616854458104m, -59.1553027416941m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -77.086283804493m, 28.923973004108m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 64.7325434832294m, -48.2063697634899m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -14.4881423763072m, -33.6754472911387m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 63.2317769059417m, 37.899279928778m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 23.110087076312m, -151.942353689593m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -71.0060777591846m, 66.8288008265577m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.9588025245278m, 135.677048435792m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 63.9209038999888m, -10.2552245353875m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 23.7281829307532m, 169.162329654773m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 11.6564462954913m, 11.2360810142307m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -4.74062412073451m, -59.8778189640918m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -18.2303406528032m, 52.235101124933m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -43.3437607964408m, 169.722358020117m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -17.760213038939m, -65.2172708162773m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 9.12792423876407m, -119.885264643174m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 2.03049069640805m, 157.117375064798m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 33.3697022886335m, -28.0890369478986m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -45.7460488876885m, 146.081760805698m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 88.9904159920879m, -153.407527002541m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -58.1542139992436m, -131.461398891199m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -40.3346855709098m, -124.147866710628m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -70.2810655754534m, 79.8957771587884m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -72.5339543791696m, 16.5960893124869m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -33.8650672893478m, 62.3039405000338m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 42.2470354530479m, 118.274802324295m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 29.2360047302244m, -155.064878762701m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -36.6287050709068m, 179.488175770125m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -1.83961320213282m, -41.7938364360086m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -67.2458150695726m, -103.940352125044m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -35.599628841896m, 173.320002264374m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -75.8697314807792m, 97.822305247337m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -28.0075287760311m, -58.8327126143721m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -87.0091252168118m, 33.4015804623353m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.7240971656796m, -136.56813983242m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 11.0527157281335m, 89.5254398070488m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 46,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 81.306719786481m, 56.3673656247751m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 25.9759654682543m, -50.6541732539197m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 48,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -67.2900718010915m, 17.958386199973m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 49,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -2.29527509777898m, -16.3638089532744m });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 50,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -33.5830444791717m, -19.1571494613769m });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 223m, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 736m, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 761m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                column: "Amount",
                value: 913m);

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 833m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 150m, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 516m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 377m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 915m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 911m, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 619m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 225m, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 997m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3971), 183 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3988), 102 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3991), 148 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3995), 114 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 6, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3997), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4001), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 4, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4004), 163 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 8, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4006), 252 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 5, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4009), 127 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4012), 133 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 4, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4014), 260 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 5, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4017), 227 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 9, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4019), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4022), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4025), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2024, 2, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4027), 191 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 3, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4030), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4033), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4036), 215 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 4, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4038), 199 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4040), 109 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 12, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4043), 157 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4045), 107 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 10, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4048), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 6, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4050), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 8, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4053), 223 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 4, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4055), 169 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 8, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4058), 83 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 7, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4060), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4063), 136 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 7, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4065), 122 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2024, 2, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4067), 162 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 12, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4070), 262 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4073), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 11, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4075), 148 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 12, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4078), 256 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4080), 275 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 48, "This is a review content for Hotel 48", new DateTime(2023, 8, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4083), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2023, 6, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4085), 227 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 10, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4093), 121 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 6, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4095), 179 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 3, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4097), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2024, 2, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4100), 86 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 5, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4102), 140 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 6, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4105), 119 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 3, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4108), 90 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 7, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4111), 107 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 5, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4113), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 6, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4116), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 9, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4118), 137 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4121), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 5, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4124), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 12, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4126), 84 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 3, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4129), 232 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 6, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4131), 218 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4134), 144 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4137), 84 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2024, 2, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4139), 208 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4142), 247 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 4, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4144), 133 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4147), 86 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2024, 1, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4149), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4152), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 10, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4154), 208 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 7, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4157), 212 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 11, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4160), 132 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 8, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4162), 205 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4165), 141 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4168), 11 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 5, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4170), 112 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4172), 268 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 5, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4175), 185 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4177), 231 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 2, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4179), 82 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 7, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4182), 91 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 12, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4184), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4187), 87 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4189), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4192), 186 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 5, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4194), 223 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 49, "This is a review content for Hotel 49", new DateTime(2023, 11, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4197), 102 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4199), 291 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 12, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4201), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 7, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4204), 122 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 8, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4211), 240 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 5, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4214), 160 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4217), 163 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4219), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4222), 178 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4224), 111 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4227), 141 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 5, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4230), 185 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4232), 252 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 4, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4235), 120 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4237), 120 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4239), 154 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4242), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 1, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4245), 98 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 8, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4247), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 6, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4250), 180 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 3, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4252), 156 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4255), 229 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2023, 12, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4257), 184 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4260), 202 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 3, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4262), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 3, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4265), 228 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 3, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4267), 272 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 41, "This is a review content for Hotel 41", new DateTime(2023, 6, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4269), 135 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 12, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4272), 155 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 3, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4274), 85 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4277), 287 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4279), 202 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 4, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4282), 264 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4284), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4287), 142 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 9, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4289), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4292), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 9, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4294), 276 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2024, 2, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4297), 180 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 4, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4299), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4302), 128 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4304), 141 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4307), 204 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 31, "This is a review content for Hotel 31", new DateTime(2023, 6, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4309), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 7, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4312), 277 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 3, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4314), 114 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 4, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4317), 260 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4319), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 38, "This is a review content for Hotel 38", new DateTime(2023, 8, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4322), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 8, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4329), 86 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 5, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4332), 7 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 10, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4334), 247 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4337), 81 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 39, "This is a review content for Hotel 39", new DateTime(2023, 4, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4339), 206 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4342), 291 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4344), 243 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4347), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 9, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4349), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 11, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4352), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2024, 1, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4354), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 6, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4357), 155 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4359), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2023, 3, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4362), 176 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4364), 181 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4367), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4369), 107 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 4, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4372), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 23, "This is a review content for Hotel 23", new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4375), 104 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 3, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4377), 167 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 10, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 3, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4382), 203 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4384), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 9, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4387), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 8, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4389), 149 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4392), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4394), 10 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 4, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4397), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 9, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4399), 148 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 44, "This is a review content for Hotel 44", new DateTime(2023, 6, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4402), 290 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4404), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 47, "This is a review content for Hotel 47", new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4407), 198 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 8, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4410), 248 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 6, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4412), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4415), 114 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 12, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4417), 74 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 9, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4420), 242 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4423), 126 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4425), 128 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 43, "This is a review content for Hotel 43", new DateTime(2023, 3, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4428), 229 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 5, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4430), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 9, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4433), 287 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 30, "This is a review content for Hotel 30", new DateTime(2023, 5, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4435), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 12, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4438), 133 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 33, "This is a review content for Hotel 33", new DateTime(2023, 10, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4444), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 27, "This is a review content for Hotel 27", new DateTime(2023, 3, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4446), 249 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 37, "This is a review content for Hotel 37", new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4449), 250 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 4, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4451), 145 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 50, "This is a review content for Hotel 50", new DateTime(2023, 9, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4454), 108 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 46, "This is a review content for Hotel 46", new DateTime(2023, 11, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4456), 187 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 36, "This is a review content for Hotel 36", new DateTime(2023, 7, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4458), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4461), 82 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 22, "This is a review content for Hotel 22", new DateTime(2023, 11, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4464), 122 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4466), 263 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 3, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4469), 100 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 6, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4471), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 40, "This is a review content for Hotel 40", new DateTime(2023, 4, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4473), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4476), 226 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 29, "This is a review content for Hotel 29", new DateTime(2023, 8, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 9, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4481), 238 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 35, "This is a review content for Hotel 35", new DateTime(2023, 8, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4484), 145 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4486), 99 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4488), 109 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 21, "This is a review content for Hotel 21", new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4491), 125 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 34, "This is a review content for Hotel 34", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4493), 204 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 3, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4496), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 42, "This is a review content for Hotel 42", new DateTime(2023, 3, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4499), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 32, "This is a review content for Hotel 32", new DateTime(2023, 7, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4501), 164 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 45, "This is a review content for Hotel 45", new DateTime(2023, 5, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4504), 156 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4506), 157 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 25, "This is a review content for Hotel 25", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4509), 87 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5212), 8, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5220), 134m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5231), 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5233), 402m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5236), 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5238), 191m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5241), 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5242), 394m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5246), 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5247), 345m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5251), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5253), 487m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5256), 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5258), 169m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5261), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5263), 318m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5266), 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5268), 131m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5272), 28, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5273), 457m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5277), 48, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5279), 149m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5282), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5283), 89m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5287), 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5289), 260m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5292), 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5293), 144m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5297), 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5298), 331m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5301), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5303), 234m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5306), 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5308), 127m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5318), 44, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5319), 130m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5322), 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5324), 383m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5327), 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5329), 173m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5332), 33, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5334), 225m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 2, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5337), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5338), 117m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5342), 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5343), 339m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2023, 12, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5347), 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5348), 316m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5352), 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5353), 110m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5357), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5358), 451m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5362), 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5363), 343m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5366), 40, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5368), 348m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5371), 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5373), 141m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5376), 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5377), 230m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5381), 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5382), 90m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5385), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5387), 264m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5390), 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5392), 223m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5396), 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5397), 143m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5401), 3, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5402), 270m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 2, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5405), 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5407), 278m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5410), 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5412), 330m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 2, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5415), 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5417), 240m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5420), 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5422), 462m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5425), 6, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5427), 417m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5430), 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5432), 264m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5435), 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5437), 229m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5440), 20, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5441), 296m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5445), 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5446), 463m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5450), 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5451), 317m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5455), 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5456), 156m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5460), 18, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5461), 304m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5464), 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5466), 282m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5473), 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5475), 403m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 1, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5478), 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5480), 231m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 51,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5483), 14, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5485), 218m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 52,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5488), 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5489), 421m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 53,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5493), 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5494), 351m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 54,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5497), 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5499), 460m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 55,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5502), 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5504), 127m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 56,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5507), 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5509), 340m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 57,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2023, 12, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5512), 39, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5514), 164m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 58,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 2, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5517), 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5519), 133m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 59,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5522), 15, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5523), 295m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 60,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5527), 3, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5528), 456m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 61,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5531), 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5533), 411m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 62,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5536), 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5538), 209m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 63,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5541), 18, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5543), 333m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 64,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5546), 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5547), 127m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 65,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5551), 2, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5552), 245m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 66,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5556), 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5558), 366m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 67,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5561), 48, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5563), 287m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 68,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5566), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5568), 199m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 69,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5571), 13, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5573), 277m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 70,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5576), 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5578), 411m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 71,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5581), 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5582), 267m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 72,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5586), 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5587), 89m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 73,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5590), 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5592), 216m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 74,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5595), 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5597), 112m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 75,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5600), 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5602), 300m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 76,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5606), 269m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 77,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5610), 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5611), 298m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 78,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5619), 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5620), 143m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 79,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 2, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5624), 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5625), 115m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 80,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5628), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5630), 80m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 81,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2023, 12, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5633), 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5635), 69m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 82,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 1, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5638), 29, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5640), 191m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 83,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5643), 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5644), 135m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 84,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5648), 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5649), 458m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 85,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5652), 15, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5654), 481m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 86,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5657), 9, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5659), 205m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 87,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5662), 24, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5664), 166m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 88,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5667), 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5669), 187m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 89,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5672), 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5673), 246m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 90,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5677), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5678), 360m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 91,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5682), 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5683), 412m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 92,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2023, 12, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5687), 24, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5688), 224m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 93,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2023, 12, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5691), 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5693), 352m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 94,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5696), 40, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5698), 64m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 95,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5701), 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5703), 63m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 96,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5706), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5708), 301m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 97,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5711), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5712), 71m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 98,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5716), 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5717), 408m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 99,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 2, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5720), 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5722), 219m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 100,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 11, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5726), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5727), 175m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 101,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5731), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5732), 54m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 102,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 1, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5736), 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5737), 299m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 103,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5740), 28, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5742), 386m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 104,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5745), 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5747), 331m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 105,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5750), 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5751), 464m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 106,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5755), 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5756), 65m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 107,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5760), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5762), 158m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 108,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5765), 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5767), 314m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 109,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5770), 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5771), 73m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 110,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 0, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5778), 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5780), 450m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 111,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5783), 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5784), 491m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 112,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5788), 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5789), 69m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 113,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 1, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5793), 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5794), 236m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 114,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5798), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5799), 94m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 115,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5803), 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5804), 449m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 116,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5808), 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5809), 334m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 117,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5812), 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5814), 191m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 118,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 3, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5817), 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5819), 222m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 119,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5822), 38, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5824), 269m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 120,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5827), 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5829), 377m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 121,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 3, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5832), 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5834), 283m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 122,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 1, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5837), 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5839), 170m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 123,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 2, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5842), 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5844), 388m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 124,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5847), 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5848), 157m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 125,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 1, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5852), 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5853), 486m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 126,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 3, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5858), 289m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 127,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2023, 12, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5861), 13, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5863), 99m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 128,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5866), 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5868), 439m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 129,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5871), 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5873), 354m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 130,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 12, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5877), 7, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5878), 191m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 131,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5882), 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5883), 152m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 132,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5887), 7, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5888), 265m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 133,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5892), 29, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5893), 137m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 134,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5900), 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5902), 395m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 135,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 1, new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5905), 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5907), 323m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 136,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5910), 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5912), 174m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 137,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2023, 12, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5915), 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5917), 240m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 138,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5920), 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5921), 400m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 139,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5925), 49, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5926), 301m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 140,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2023, 12, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5929), 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5931), 257m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 141,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5934), 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5936), 388m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 142,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5939), 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5941), 499m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 143,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5944), 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5946), 354m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 144,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5949), 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5951), 206m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 145,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2023, 12, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5954), 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5956), 422m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 146,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5959), 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5961), 226m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 147,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5964), 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5965), 349m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 148,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 1, new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5969), 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5970), 95m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 149,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5974), 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5975), 97m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 150,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5979), 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5980), 316m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$hee6L3q0sDAUoAd8yeMZ9ucCiDpa6YmD.CPp1PWBQOz.m1F88HhLm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$WTPFRcnN0R0aXsSh/v9S3e5j4/UPkuj/DmM81SA2d7akvh55Wzh9m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$zaj3V8kKbKNin.lb.f8Ia.JLTBambLXYGQ1HqO38RIi2kVRhrgOEG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$thpLN4ul0Tsu9WCbIuKTROOQEXPLC2nwdczHm4aSoOBqMZ0acM9me");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$nzi2JXwVKhXPip3.7WmPced7HNgHYVGvHk0LA8ICZBC9NIyxIrEne");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$UHojYP4pkXyGOPEreqfsxOrexgs9AkvJoYJx/HL2YKJMLV7M7Sa3.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$pNS28Zz9XXvyvtK3yp2khuXGryKLW79tJ1/BZuQgQ74EU6blW6xXG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$vH0csvEOAhUtGTsSx/82w.K/V.EtA9aLI5B7v6so3z8dqxTi5h8De");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$LVlNh4UFub2utoQYDgQzNOzr8e5pENIByf0stUnW9Lyvtp2A84sh6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$1Cc0dJpSJk/yFLHNnAYiJ.VSrUWriOOrqjkmgm2tMOAz7gMno3HJm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$InCZ.bfSwdq3F.ze26DJYuNmHceBYvAHA6uNqsLWkkeLUNtpnQac2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$WjI.iX3eZf2Gdj1CMAk.6uMT40IDqhTF2DoVpK2yO6EMIg2lXxk/y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$MmpynU19FXUOWdH/1qQENOha.bGGKFdrccjaxf/qPwUVW5DpGDC2i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$S86SyMyaGD6t6Q1X7S0hL.7nK0.CYSLwQJ43F4BLsFNPsD219t11.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$/MZ6YEQPy4pkBtPD3a6ZSewN1bhPKF8.6dThEQDZLiffzj19kuhaO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$dWdpGfGTvnrmrru/4fzHPuOxGbH83mW8p6M7aGARoDgOD5DBEnnPu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$G1oLuEGiqnQkb3TVR.8GQOCQxgh8Vp0NKrSd2Z1c0AHiohuI9qgCS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$fIxwY/rUofhVVVyCnHGBwux9c4nkMfgsV4VxfvG0nmTxJS5SJVz8a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$O5sfjmR/yIhuKHqDKQpKc.ybgbCFalx6I0dPlUZ/v25NlVYPdHFSi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$badzSboxGfAPM/KJAy/D4OUhuStOT1Uk7WjYukXMjPR0HeC5agvo.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$5/R8eXuyndbrZrYAtoxhbuMC8GuEzh5anDyVnSb5PGlnsDQdS9a0G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$u97TGlQPFCZan3FQBeZITuN9SwoQz8xYCvbd0jqEU7Km.BMSdAkUi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$XeziXzkZuErlveMZx3YOg.qn0hNFjchR4OqKYHX5qU3WY29j2Asv6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$V1u5l2tzUUAZeuQrHu2Q.OcZg.7wppH.yTEQj9CsvDmcCCs6DiXxK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$ugBcZKuzJpj8ZY12OzApi.jxjo3LrzM4H1U3.qdr1Hh/eaCTqf.AK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$ZHha1YMVMRud/PYlrh6hF.FbKNtUzcFCqt6bXx1JGSLgb7Hgd.Us6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$cH3WIJV8qIvozn6uDzjl0OPR4ULFWlkF49i/cZ.EE2IBakLgnUWHu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$7We5pDcJJ/IwsIlmRz6v9e1IQX56hSXjC0d6F5cdS79z5WWQrxEUG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$qSw39k9BXUrBbe7sITlbPOx.XCpASrlYHN3D2KJOfZz4ICaPdh7F2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$Ir/4yrnLDzoSF4sVrWCbTugP2Te5IEL173KM8YiUd11IJghf64ZqC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$fXvDTxoDsLuoeKb3aOuH9egRZpw7fKlCDZD33WyfwkZtXklP7BDA2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$4/cS5FuBUMIj75h0hjGM9Or0OYGTvVamnPSXx0NOj6sOc4O6xJ4ii");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$1psK6pkne/au4HHSKRF5qufukZB3GyBLU47MfJJbGNkNP8FD33AsG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$XlWtf2xJblOlbCgnGWjt5O2r/ONAJvZccv6eJ0PELNp.TKumBxzXa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$G7Al187H2VXsnHeiGYIsa.HTwOUtjG7kGTqlsrtVQVIQ6bk729Xzm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$ou8ZErjj09ZGDzqcxaokJ.CVBwp.ohvDWeeD2PA6gAkPIzNu5yQe2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$d5CqExeVQCJATTL7ga1Pz.ghPp38I17J8LkS9bv1rBmB0mRa.NpUG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$cCzz856lcuZIZHeIYQgdH.JE6KCcSV3Z/ECprucPWLn18e32JSoEu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$Lh6/YZILI6UqbWm2kgvPdeyCW4VErK9MJOzTsR1GzrJThSwNfEQVu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$g3X2fFXQOGhOoF1X52HTK.4TZoWtgQthluY8NudmKEpUSzbLqCtv2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$tQULv9L1aheOk88o7W.oq.ER7Hi6TFhjBmWADDS.3RK3hjr3fIlxS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$BKo2JKfFYcL6nRjKdjqy3OjlL4zuG7WdWTdQcac19uOnXbbV0PumC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$bRck5CxDImHwrIDqQksriOgOMYEdfu3qRqe1/Jy4QlAAjNlXzYrB.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$iBaK8PcvH446GO4lxQVM0uUcppz9sjA/HpJjZLX46eb4jVgciQkMm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$4.DY7P8XGKYTFuI5hQmIh.2VuDxHMTRL/im8sZ9v7bG9gpoTAiKJ6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$w9pehMPAtzEH2q2YR4FKCuQA6rdFlCDj9MZ8cAkaYm5Rf2L/lL5Q6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$/GCbW5o7lnVxLWCTD3WVnuoV9ISV1oIHvBk5XbLWAlIU3u8cLKf0C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$041wEr/vR5rJzY/q9YUv2OjFFbHiRRvPv7FSA8s.QcJjie.o2k8gq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$mE9Q4CNR86iv8ehQo5Sj0.m0XApVq1K94YsfaD/q9cdO88Mm/528m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$Dnm8bAs8eVpadXwUZOj.NugfVFOIWS2wlT5jBn9ZRn5D.Z/U76Z9W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$6DG4eDLCC71Oxbe9zwT0s.eTbFCZFsllFqL4Wy9/pHK8QpmzA.jt6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$vilmCbxKSTt.Bv9Rfxu4lO8oKaevCBxARBL2ie1VfUzvDzjqEIMIK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$7imET4yUlt9K/RMvqrX1/eX2pFW2kNzMbVZTQk5b7E1PyWeeJzrxu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$eMI7tLiC1/Lq.98Uztt0eOAbA2jl60U5MrBcVG4aU9C4VofrsUDgW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$4.XLt.Tsn/aQJdiyVLwSuehJJ2vFRdyaabpifK/2A6Pix/917JcdS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$1B8IOdEslCIu.nYU50YNhOKeGgiBm7VoELUOkaKqcRxNGOJSBxwgO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$5A/T/1P4YLz1K9cv1E82NeTm1XAzMtZGSUb7h3HLfaVuEQnS9y/Q.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$crTOgjAFK/CtUheeQDoe3eDiKkuT6KoB6yorgG8iFgn0R0kleqR7.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$VAVebUcev3YG8s7kV9M5oONHLSXijgO86wUu8FPpczy/rmMU0tzw.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$D.hLfdchLUx3yGxEUuPEwOQPTOM4Q10o2GF8OElOOm.vr8AgoJlN6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$kWekGPCHFNgtbEyBpnJr2utwUzzqgh.cwmhlIu/J12zZGZWL9ShX2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$5z86yu4070QrFjUmM9dp8eCdlJ/7hOpUxiNdueTKOkAuwPRVQy57S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$IH1rgAo8GSO1QMF2kJSHpuEmRUftwGMpWmQOfuxjVsNPz9fIrlrh2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$nulo3cUJD5x90RicZxdW0O2YLx5ziGrKTt2rbBCJhOdOmuODvs6cm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$flVH54QgenUUnRX5At69Lui5EBfkZX6m7BCnfPlriC32EF1YZaH26");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$q7A2cOLwnWYJmQnZjsEUnufzK27rjpDBK6ZWrFmlNRQbibS6ko7sK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$VhVhvH0maVnrZzQOWBTi0.f1wTvsxszs/RKfvPhdbgP.bE7.tZab.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$8KlVFOYtbgAO6PYVOhcz4OaaORW9Htnk7jY2zW9z24gffkK20KabW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$fTa4.NJ.ePZGa8OUYINK9.m.mag/b2AeparmxYHSMj.51qgbJ3UJO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$Ylr0SGcpOMLg/hgLEKZir.n6B9aboBalldO/zGGrk0ckukczdchKa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$PtnloJUcVgN4og..pZOJ3.5LhcKo.jSXJJkhb1gh.WaQBIh9MxMvW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$NbhjVgQoP.J5/o234kh8yeW6ZSGUVN6vuEoL3M1JtxaCOIV2s09Ka");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$b2ib.0e.e8.c.iPb2dkDjuas8vwyqKMk3/XPYzDOs.6XsS4AWX0.6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$BuKJ1jJBKsQBm6NsZQrNze5CPJoY3mvEq1xZkOd1BlP8GNBWUu9Qq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$y1qcJi1tKym61Wglpr359ePto7WU8gLB4rv/jhhQ6UsS.M6sHPDdq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$nsGqc9ypVs.gix2cMegehOz6COFvTO3xa2TAnhK5D83CIzH8h9C9O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$51URkeNYEptHOdkb.T1KPemPGPC6BeGbMpc1diqMh2.3cUDsAkjB6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$28siIQsWE9Y8XgIwNuNrseg5TkfM/GoAry762LJjv4Q99w7r3EIam");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$SyHz9BejFUIAa1/zKPQTTeW2kRR5ZJKiJp99AMaQMdeUzUL3MdYV.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$PO9GKZFSOVqi0r1M/r1Beea2QhRDjRTcDsV/UMyyJG2N4AVvQ8LcW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 81,
                column: "Password",
                value: "$2a$11$lW9ADQhLBwKGNpjNe3Eve.wXl360b1/Vqio8LXU08C4xyExIgrICe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 82,
                column: "Password",
                value: "$2a$11$6Epf3FVy9/a7Uzt9xcUeUu8tgJNhf8hl3cQVh7LkuCiXibUbrcFdu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 83,
                column: "Password",
                value: "$2a$11$nvcB5k2UGafqNXGN4jq1euv1bxiey/i1IGih4zjH4IvupLgCrEUXm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 84,
                column: "Password",
                value: "$2a$11$AaipNJorZNjtHtRoKX3yP.9iUAgy6mMGG.H7Nn0aSWfArgxMM2q/C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 85,
                column: "Password",
                value: "$2a$11$wXFn6yWsJXueIoakTjnXs..p1iGYcyML2lXxctehx2T5YlmzD0u9y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 86,
                column: "Password",
                value: "$2a$11$OeWLIkHzd9/.hoKPhJve.uMYutmKmD4.IQy0ZYoo2msNIY44GwrM6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 87,
                column: "Password",
                value: "$2a$11$2cmxcK/NJcxRfM6MFmUICOs0P9q1tM5xQh70kjw1tVcwW/.sns1JW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 88,
                column: "Password",
                value: "$2a$11$zMMdP7/thSOW.K5A6wdH.uIQitecfoUW/bOnDhZUD4nCVPuHIcy7S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 89,
                column: "Password",
                value: "$2a$11$VfuJr.o2ksM05twgNIzqLuwge6KtinGHQkxmnJ0Nu/VQ5KE8UwL82");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 90,
                column: "Password",
                value: "$2a$11$6csXlDHzYMLv2NeZrQDMZOyXjI.XKRVduvL.lV1zYEWGMZgi7DXq6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 91,
                column: "Password",
                value: "$2a$11$1oxZEm78qJkA6jWCH5hxXOOQ3mqrvsgms14jlDOWoBJnRLJtmHa9O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 92,
                column: "Password",
                value: "$2a$11$uoPSTdoF8xSdlW2o/TmdEuwGivoGmxtq4UI7xfay47z.hG.vDEI2G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 93,
                column: "Password",
                value: "$2a$11$/rUYYpRKq2Xc0YE2ZXmoxO9SkrD7PfTBoNcfsnVzmsu1m/xej.5pW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 94,
                column: "Password",
                value: "$2a$11$ZxvNmaAj1ly54yHSrHaFdeROwv3vF16C4ZVlTKfd9as0k8JvF1vNC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 95,
                column: "Password",
                value: "$2a$11$0YVkD.pjfjGs4uYtaGPwvOKU.6ZXwETjlQBs/rlmv5aYg88oDHtR.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 96,
                column: "Password",
                value: "$2a$11$Xlk1hayr7CElvZcBWOpZcuy/69/gVusTUoUW4G/lVFpG7vmqtZ6I6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 97,
                column: "Password",
                value: "$2a$11$IPcpnKKVKV9oql0cljZx7OepsLdwWqGBRUnFp9X37g5WjbKVNBMIe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 98,
                column: "Password",
                value: "$2a$11$fHQvuoglOtkJXW3PieyZEe59Tzs3IBOlQB1/N3tEQ18OVaj5BD8Fe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 99,
                column: "Password",
                value: "$2a$11$1T4Aa45.xJ1pge/Lq7mkO.0TUmL/xkUIHeWQ4bxrVGyZTpTU0wyBG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 100,
                column: "Password",
                value: "$2a$11$qr5JsWF4oTl32/syivpx2O3IGYz5XtsSVlABDTLW2PdoQVzra9mGC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 101,
                column: "Password",
                value: "$2a$11$307cDVgbYtVgaNTWpC5YdOAHYSGskriHZuF0u0BCiuT.o0e0hpgx2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 102,
                column: "Password",
                value: "$2a$11$jWe5UeiLfhzjylKmEswOieMl17MApIIrJBroOlqm7ttSKfMVsXYBW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 103,
                column: "Password",
                value: "$2a$11$y5JLGN1p2ziazF6bKngwRONaqJjQgBxtN1WupPpu3iK90moTX/pCu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 104,
                column: "Password",
                value: "$2a$11$WXF95NYZ5kQsiGErR0W4PuC/RzyzYGwiHw0sH0YhtJpaxA1gUH1NS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 105,
                column: "Password",
                value: "$2a$11$IgKWsej2TD0jPZBGlmQ1rOu9I.D4ZqxyHjOB6Cr/SoNSSA3SBidkW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 106,
                column: "Password",
                value: "$2a$11$141W5gAavWxdTrwXyV8w/u4hirTuGorBED.dfNXuRvwwKDqXxbZXO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 107,
                column: "Password",
                value: "$2a$11$EaA2IAl7aIAVlSOfnbwSMOiWIaUywVmu4j31RrIZQM3kjL7ujAuXS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 108,
                column: "Password",
                value: "$2a$11$H8LrgVShepEYjoEXrzXiM.JHRiE1/YdZJwB3hbdh/JUyUaqFAtIiC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 109,
                column: "Password",
                value: "$2a$11$RH.QrtD4Hxg/rlGIzG0hzOFdCWXuwdRBUb8W8dXWvGys0/BQqmP4m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 110,
                column: "Password",
                value: "$2a$11$SG0JmzLNEaOepuyKRVeu6OOcVC.l5kjknMAo1rzngtupLprBFjzkm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 111,
                column: "Password",
                value: "$2a$11$RD4b4cIKI5kP.s8PXizKCeGLHi8c7LXTsQJn/WsHi/9linBSZLXdu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 112,
                column: "Password",
                value: "$2a$11$R8ZO0c61iP15GSAvuFEzZuh9aRwGdAEhxy5f68oRNLHR9CFz/XSlC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 113,
                column: "Password",
                value: "$2a$11$KQkdQ1bh7T52xfgvcXux4etgTLBT0WIX0I.yWRA3/vNMAeMUm1rx2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 114,
                column: "Password",
                value: "$2a$11$9UXNILHf.BM7J9RaWnyWSuXl5GJbLB1.k5FRcT.XR7Uf3D5qSJVG.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 115,
                column: "Password",
                value: "$2a$11$4mUD6lX2mZNNQSmr6OXq9O28RTKu3CVgZghVh6WqYCG4MVa.09sjG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 116,
                column: "Password",
                value: "$2a$11$edbpziKCF8wZolyOF1eTmevZ0uhggg9dQsZNQ1jVr8g.chhtSZl.O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 117,
                column: "Password",
                value: "$2a$11$WIeC9yULIXY81lmdJx8AH.wwwTvIg1bSKZ5Bf0RN6Yoo24Rvk4B1K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 118,
                column: "Password",
                value: "$2a$11$gEH2UPphUF5l3S6e5RXND.z3vKFImd6DKvKp2HjQ.Mj6gFEnZd7Yy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 119,
                column: "Password",
                value: "$2a$11$T7fvXg7ec2ZEBjCJKNhn5OWsTRq4jIHQoi/Z0EAbOHyKVIN8GJxVO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 120,
                column: "Password",
                value: "$2a$11$XBOtIickkDoiU4/OqN6xd.lbhqRecNNAiRAsicqeemXPFCQmKYBq6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 121,
                column: "Password",
                value: "$2a$11$W9q.bzZwCSnqgdDPsgl03O4DN2PhjLOc3Elw0ufQkqZDYocrtN2U6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 122,
                column: "Password",
                value: "$2a$11$CCj9K0ROb2bwKmwLfbANxOmOCYel9opvUXr7wtNBiedjzrTgMyrim");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 123,
                column: "Password",
                value: "$2a$11$gkAx21zTEYQ9THEw6GXBU.KNdn2aXKAWf4LjYU0P/6TWDCuDXH9J.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 124,
                column: "Password",
                value: "$2a$11$80mYKBwClRVhdmsQqaeZM.7PuvRwUvyEj8IzXm3gOWNcUWfGv7/l.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 125,
                column: "Password",
                value: "$2a$11$j3/VG1e80eCshZqkUWPe4u9INp/DHFJrQNXBrvvXufh/N.azWQgei");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 126,
                column: "Password",
                value: "$2a$11$IbHZ2tfsuVOvdJgaeJw2Aeg7Id5yxwy3LLm67RjBozBguaiZRBqhW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 127,
                column: "Password",
                value: "$2a$11$WEiMOKotuDlnd1ppwEVwFuojpy3jb70a/OBUGr8eQ/xAAX9Gjtuge");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 128,
                column: "Password",
                value: "$2a$11$nEx/zXLZJ//2Z8QddPSoMOL8MPXRZUTmL4gzMufz6knMwf7TUk6Da");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 129,
                column: "Password",
                value: "$2a$11$vuEpiLsZTuSSMBapOc6B4OZnYiDtoBAePyAt7ulok9jHZk8a5bW9W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 130,
                column: "Password",
                value: "$2a$11$hcd/YGNsV4eN4ORWa3/cte/TlszkFihf/3hLuYggkxCUnI65.glzK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 131,
                column: "Password",
                value: "$2a$11$yX0BdVeZY/4cjPuVO52c8u4EsjvgvoWcRZfSV90GkY94uAL4FXO6K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 132,
                column: "Password",
                value: "$2a$11$Y.RwnNbmPO3tqzT5Slxch.avAA7UnG9hZSJr6IxR7W6eI9iDF/oTu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 133,
                column: "Password",
                value: "$2a$11$hwcZDj2UwwLLXf8EyC2ViOpPskdh93P7MQjHyvNYQPLOJqTFP1mEe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 134,
                column: "Password",
                value: "$2a$11$DZMdz/dcTfGxZaYW8c47L./XrCjEKWHQiPBWQNJFtMcEYwPQLsXYO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 135,
                column: "Password",
                value: "$2a$11$duO3xvxJ/HikUYvdRtmAB.2JkxidcTkDC9Jk0v4keYFaDgWDyfAu6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 136,
                column: "Password",
                value: "$2a$11$3BnSuBpUKOnYecgf/ad4E.QkLySL/5zCbdLrAf7lYt753Yy9Viv26");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 137,
                column: "Password",
                value: "$2a$11$9CXdkU7VrtRKNUYpSLZC5uW9.RIu3Hhf2Gio7zI7bS3jZ4IU.T/y2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 138,
                column: "Password",
                value: "$2a$11$3Az0yoR9P4hKwuFiBpSnvetxrivsTeNiaUbEIncwBHvR4aROKauwG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 139,
                column: "Password",
                value: "$2a$11$PTUTX2rxLc/qmOffU/s02ublB6FQHWLnGfLxaevQ4zLxELhkKPBjq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 140,
                column: "Password",
                value: "$2a$11$srTahthMxBHkYiMiYnZRIeLKoRHscIf8OUV9Jsdo7i2fdWQK2nHem");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 141,
                column: "Password",
                value: "$2a$11$bFfDGQH1hmYnPUqD5w/lnuE0q2W9x54GHTj.F0gMj5Jy6MBZF2yI2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 142,
                column: "Password",
                value: "$2a$11$OxIMOo5oMSP4diMPRS2b8uMeKQZlNd1gjFSdnCiLh823tSK/ndr0i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 143,
                column: "Password",
                value: "$2a$11$7fZmjw0EdTOCGDjnm06J3uXhPE86O7CBt5JfCiOmuPga9ZhBM8rIi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 144,
                column: "Password",
                value: "$2a$11$35oJKNbRK.hzCnHJsezGFu/lq66sECVXS25.Nfcc6hj68tzIQSQ2e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 145,
                column: "Password",
                value: "$2a$11$GLrCwId4iMmPuoxKJANHFe/PsXT83AU76eps.xqk7SmZsY5mP3uQG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 146,
                column: "Password",
                value: "$2a$11$IHaD8GWDnl6X0AR9tQwPd.2gPkzinPY35S4FEprgToSRxL.isTYfK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 147,
                column: "Password",
                value: "$2a$11$yklZE9WVAcFtakqfHF0b6u0cCKtbKmxkhIKAOrBa.AgXDQ5T3LSBG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 148,
                column: "Password",
                value: "$2a$11$WeDzZoknE1XBLF5iIiiM9.QX6MMexgE7iPX2EQmtYzQclNPlcDZqS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 149,
                column: "Password",
                value: "$2a$11$G.1G.6PQK/LOIkW45DH4Degc85Qy8xZihUgsX04LpXQ.n0mYCh6XO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 150,
                column: "Password",
                value: "$2a$11$y9V9M/Lq2zFVxfkzMePPH.7DVVCwEETmDTaUgV6I2QcKIF5v0Qzmy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 151,
                column: "Password",
                value: "$2a$11$Ph7PwdAWOsxygDcvFU26FeSzvpYix8JrrgYTxCbCbqqNBqS6mycna");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 152,
                column: "Password",
                value: "$2a$11$NgPmKeMmJUGuJZIy5lupZOz/czw3.s0u1xJ1w5Eoc9qFFpCsmLt1u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 153,
                column: "Password",
                value: "$2a$11$Vc6mERHVWCCiu6akfP0wQOD4nx6LhVGgkT6RH0WQnXt170O8jkzsK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 154,
                column: "Password",
                value: "$2a$11$Ik022PJLfKZKxsIzIZzqZOIJ/3oQjq42yUUjc0CWKZSXsE4EoeNrW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 155,
                column: "Password",
                value: "$2a$11$ATFPz75ELP2kCG6TrV4TFezJyo0YJ5LpZomh8WzYkWbCp8Y301bjS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 156,
                column: "Password",
                value: "$2a$11$PRy0YM/HuytzOcnKPXT5xOwPmZh5E3PtWyHScgDJaltXqZlX5pJPy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 157,
                column: "Password",
                value: "$2a$11$KNXNxLIeUUrEmV0sPWXSS.lysp5/w5fR5sKKD5iPuy0r4ry/u.Wmu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 158,
                column: "Password",
                value: "$2a$11$VbzEdLXp.0cwkDW2nteZq.Yn5abNnL7NVXplaTkDD3w9WzvtHGRrq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 159,
                column: "Password",
                value: "$2a$11$V3TJYhfVeRWFXHVXfJeliO.rGrjvazuLeDoOeZ/g.rwFen4EcZTT.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 160,
                column: "Password",
                value: "$2a$11$wQ59NAEiAsATM/g5WC44den8jU6.OVUBr3AEdpb1KerAwoSvxqQZ.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 161,
                column: "Password",
                value: "$2a$11$gNw0zfa9ZsM1MhQmbxy3qulNPDke7uhICMJQvobhUzD0I2OJl9Jb6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 162,
                column: "Password",
                value: "$2a$11$gYVkr6sYZceywkGD6rR1sOiV9NaOKBhxSGKxkW3ktqd5fxqq8D4Ku");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 163,
                column: "Password",
                value: "$2a$11$JuBtPwKInGq4CGwVJ/afrO2r70591zXZFxLONhneHcBR9rOV8NLBK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 164,
                column: "Password",
                value: "$2a$11$lvhURDp3U85N5l7wuutVkOgtThnUsuZUF4KOcNDzkcuAtzLGxKcHW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 165,
                column: "Password",
                value: "$2a$11$JSshcZRziYL0BAlbHUL33.cBN71cNgororjNm7DNJBPYuigqHWwGe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 166,
                column: "Password",
                value: "$2a$11$f/JkfGucR1ZmyGemyl/DWeIdqgFpSaFBl1HyFQeyirpWuouoaZ6DG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 167,
                column: "Password",
                value: "$2a$11$qOYM9b7fqlPjHt1W76beDuPOAFmg9VA5K3XLSN1U1KLSDrbccsHEi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 168,
                column: "Password",
                value: "$2a$11$oVGtnSkNlzFs/lQ2dLa.F.mcFzAeD.pWTnTT8YimiSvRwA4.FewOK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 169,
                column: "Password",
                value: "$2a$11$qyHjgINiIyQYV.cLEmBX7OeJQsuFlNEKe1CWHKXnx1/cSzn7KW.Cu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 170,
                column: "Password",
                value: "$2a$11$JfNtXOq3ZOWhlIuDF51k0OraERbt5v0WEpvefKWLIsHhpIlKjkI/G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 171,
                column: "Password",
                value: "$2a$11$sfgs2VYKz0coSRe00/457eVpeWZEXGK5kQkohuzRXD8ERDLiqMiLK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 172,
                column: "Password",
                value: "$2a$11$Lw8jciGReNcH7H2x8vv7Ze1hXJWpqEGOprkxhQmaonsroAPVuNjLG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 173,
                column: "Password",
                value: "$2a$11$3UL18Oc0PwuxPXdCmmqME.5HQytYTqiHvFzmsXwcFGjQ0vYMPDa6y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 174,
                column: "Password",
                value: "$2a$11$PVwZqIa2NUmwTbiBYUszwu9Z4mZC14jlkG1sN8fPUlZly24dMSEru");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 175,
                column: "Password",
                value: "$2a$11$UXm4RIG//GMZCQNWt.YADuPNhOQVHNgJX1YqllkYBF32qCbfrQJNi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 176,
                column: "Password",
                value: "$2a$11$ObJ8Gkd1c2WvdJgV8mlWv.fLYu.zcmBlNiktPQNZKvhc0JPZ0E3LK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 177,
                column: "Password",
                value: "$2a$11$QZYMiCIYj4BHGMTXS7aKCOIdoL.K6sNV7NHrut/Q29HLFRXdSCJXK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 178,
                column: "Password",
                value: "$2a$11$0XdOUzdNxXqQ47b0XaPYDOYfmXev6EIV6zl6FI/8naHLXqqBmgi4q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 179,
                column: "Password",
                value: "$2a$11$qnSc9/lSvB9fgrsbDyIrke0JTySd.bU7FGNeCUs1nzx.ug1Q2sJBW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 180,
                column: "Password",
                value: "$2a$11$YmaKHT1bn57YibnBZpi3Eu7dUZp.dELq3C/h1f915j/2DiKQ.bm6C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 181,
                column: "Password",
                value: "$2a$11$ZR6lt5U5rZeRn16zDYIlgOBJ8rutprxUVDiQNIJqWCz4jSpUvM3me");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 182,
                column: "Password",
                value: "$2a$11$E5Jk14KmVfkU4y8nYrGCX.qHiBqRuReNDNgcqyqE1ecaLZkdNxH02");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 183,
                column: "Password",
                value: "$2a$11$ngzp7cNzGnNfj0LcOAB2peuaOZj5V.qobyGlEwULeB4k.BCzOZgEq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 184,
                column: "Password",
                value: "$2a$11$fT2W73XoVsJQa8UuMOHK5O9xIJoXlb0qf9KxrYGtIonxKlwhtRjIq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 185,
                column: "Password",
                value: "$2a$11$T3EykMkCATeOqoDZJfTAau6o7vSoRKRNLsESuhQmdPmDSkAzseZn6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 186,
                column: "Password",
                value: "$2a$11$bqBZhwqJLb13HXv7Y/9Xse47mhlachiqCrbaFpGYLWT8nNiveG1kG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 187,
                column: "Password",
                value: "$2a$11$dTOUu8ItC2sHfL0tCfPgDuc3G6jNtfk/G9pvh1S9/q8fl7Vp/.V7G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 188,
                column: "Password",
                value: "$2a$11$lrqBd.CyAvgRCZFi0O7D.OrmCXbF0xVmVaw8i2WqsUQtOhQAVdBi.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 189,
                column: "Password",
                value: "$2a$11$zwXMyiK6gwFwsG5JFMuQrOip5FaonCBALs5YIfGdxJxYFH3/F2WzW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 190,
                column: "Password",
                value: "$2a$11$0sgePlzMnfXT.rI0XJxeIueHP2YcsAU8t.SvcWHqXW4mC/ys50fn6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 191,
                column: "Password",
                value: "$2a$11$X5C71bTI5nAiEoK11uASy..r2F3DKO1fUwTsm7fBaxpQd8Kq0Gcsi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 192,
                column: "Password",
                value: "$2a$11$lKb4LAJH2.5pbXHGMz7J1Oe9DDMXdvrgAPAfIvEDO66/fC/545fKi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 193,
                column: "Password",
                value: "$2a$11$szhhCEFOKr8/qa5WV0Wd/.4qcLjyEnds78ZybEGQAuybbOJff2K9.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 194,
                column: "Password",
                value: "$2a$11$WegHZmwqrl3vvipr669z4.plT04twhou5Cb4IzsPsSHJ8fHfcEw1K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 195,
                column: "Password",
                value: "$2a$11$GBF0coyZLpUzL8pZSxR7ne1tC0bbMLvbsnH5yWL8YwnU.Plr1wpzq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 196,
                column: "Password",
                value: "$2a$11$7KE3nDRCppTjJ0crJVCPfursKB8ZESu6GFVUv361HMBP7htOLZxvC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 197,
                column: "Password",
                value: "$2a$11$oypTiT/wGohm4kKS1INum.ZOnaIK/ntrDiHvbZYUNamGc/.YhM8UG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 198,
                column: "Password",
                value: "$2a$11$t18mPXIDWyJYrPfI2DRR2e26.XBlF3JGOIeeAVVyhcVYAPsBUmOQ2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 199,
                column: "Password",
                value: "$2a$11$wQOGq5kx62gunGNgu2nS0.rXpdQXFbKcaz9JClKnGSfh/uomqLkD2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 200,
                column: "Password",
                value: "$2a$11$nHqeZugeBxvTdtEQAK.L7.E08QKoshYx9CFWYfEOFxDun2fdS/KnC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 201,
                column: "Password",
                value: "$2a$11$SFS1DCuih8RrryjyJmKgf.xm/NcoU1KcR5eJTRYqOkbqo.MrrmRPe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 202,
                column: "Password",
                value: "$2a$11$QT2kcrYsi4iyja4w/HGCNeJzPgI7R.VRZ29Y28fQH.EtCmsILvRCq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 203,
                column: "Password",
                value: "$2a$11$6VLvHE5PWC6iSdH0cmVsRueiQMPrZBuWGJ2M0AbL0c6JKKwp2X6De");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 204,
                column: "Password",
                value: "$2a$11$zfBt5nS.nCU1iXb80oJAoePKPh8V691erpXP1QqVLMfVCgNSM9XQi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 205,
                column: "Password",
                value: "$2a$11$kNjg3n8yrWqfnNqYUI3VH.VJcFa4hM35.nIflOe1zxqUVfvAsMRaO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 206,
                column: "Password",
                value: "$2a$11$QirJ3080MoMF0AK3JOl3n.hhNZMhY9SYMSjga/aeERiVqs7wbh5qi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 207,
                column: "Password",
                value: "$2a$11$Zy6i4b0Cm2WjOl.6rbEXx.jztwR/6Pdo/MTjwIMrUD0O68s5gFAiC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 208,
                column: "Password",
                value: "$2a$11$1qImbSeFblES2yTcm7N3UeX3Q1u3SIM8sDNp/629Na1YDPAF5oca.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 209,
                column: "Password",
                value: "$2a$11$U6STsxRG2SlcyQz9gSwC2eE/nM1K.gZVKYjSWHe9TEzUniV1Ox62u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 210,
                column: "Password",
                value: "$2a$11$LqCM5JXrzi/8wEbxvS2yBesXiScXqjkIQw7x0Oh37975DgFTOmnbG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 211,
                column: "Password",
                value: "$2a$11$YaEP41u0BGVaD.jWcPTWluImHgiFRDZdzHRDe6mnqVT.oDlcylJVe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 212,
                column: "Password",
                value: "$2a$11$4JjmVcF7Vz4Wa58DX6EE3e58hxLG4GyfDF5x4qADv.3Js3X5zBcOC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 213,
                column: "Password",
                value: "$2a$11$2O1ZVrtvkvlTu0UOdpUPB.N2Y/0OTsF5VxO4AKJp1pEYbdTne5OlS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 214,
                column: "Password",
                value: "$2a$11$zuc7U.UUp2f/AcHM.9vy1uhd.znsz2eIRmaPiiO1u1LnAflg/dasG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 215,
                column: "Password",
                value: "$2a$11$lRuWZVb8aFPLWFh5HhV1lut91pWtj3huqrJDP0Li3d4ZjpJOhTdAS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 216,
                column: "Password",
                value: "$2a$11$9EYeT8ZioCTnsbjNOiqUNO0KMBik3IQ5ZIAVCPl0j3u/eet18.t.m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 217,
                column: "Password",
                value: "$2a$11$oOoxpBGOlQbWcj/ZqiTNfe9YtxbqkJN4WdMiFUlgvQzemGlCnczy6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 218,
                column: "Password",
                value: "$2a$11$03WL.JOmr604YZXBjz6Lhuo35ioL5Wf53OivffbTT3Z1vMvoE91TC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 219,
                column: "Password",
                value: "$2a$11$tssb25I8BQK0h.6adTUaUOeK6yV0DEwHlZpQVRRQ4mfhIpqnYQY86");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 220,
                column: "Password",
                value: "$2a$11$CvyUowTHdU2JXQcRbk9/y.4yL4.qGsppGomwvXXoQMIF5MsbUDyjy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 221,
                column: "Password",
                value: "$2a$11$.pHNBsoa6bTYwt0yQb1pLOAOrU5E2HvlHgo5IHJvdFdwos8Q3cLEq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 222,
                column: "Password",
                value: "$2a$11$pyQxtKnl3/SkxNbceb8C2OWIFJ.JDvVwA3A/Dtb.Yw0TcRWYHIARm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 223,
                column: "Password",
                value: "$2a$11$RQsWVjgsKTiLSEhgUbMkKuzgAtK9dm8guHgGOx3tnxoXUKQNFvy2m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 224,
                column: "Password",
                value: "$2a$11$vq3VbX34b/GIlLfGtfEEvuQBNbx7XU0xXONwFKnyh5jjv20qEWbBm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 225,
                column: "Password",
                value: "$2a$11$0/Q1jcNPpWWzNEZoI10Dl.tY1P90ZLHz.bqw.vuN5oaw2cTk7QFuO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 226,
                column: "Password",
                value: "$2a$11$4P6N/.088nMYcjyDlFWNguWYPz92TW4G7kGUI..HlLPIxK6RzYYgi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 227,
                column: "Password",
                value: "$2a$11$.oU.egMdD5RaHi2D9fYJY.jZvh10yZ59b88mC4WMga1C1uh/JCQeO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 228,
                column: "Password",
                value: "$2a$11$GAFE1XL4q.TrOd7HX2ghnOCH7gX7azB2Njzeit9ha8x/k0wWbNRQe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 229,
                column: "Password",
                value: "$2a$11$PfJ.dQ.THLupGgnMnGm7veIAinCYPc4C/XuIF50oRxawq/64trdii");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 230,
                column: "Password",
                value: "$2a$11$GGKAAhDpTO2sDKYZWPEoPemUvF0kTaNoobOOKnYjRCTFU/qFWnn1G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 231,
                column: "Password",
                value: "$2a$11$ei/EESLVf6CuvrfeR12s5.yH1PvE3qkFzmp0M2Wn9vVrSGj579.wq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 232,
                column: "Password",
                value: "$2a$11$DMvr7dQzfVoJGitFkuVFNe5mPznA5Ra04053VhR4HfeHgia/SttL2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 233,
                column: "Password",
                value: "$2a$11$YSW4.9hE5KZ8QwwZ/5KiO.yGg4Hs3z8rYemO8RkVCL1FEKJ7oWdnC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 234,
                column: "Password",
                value: "$2a$11$SU5aBC/rYQt1f2s9V5DD4OBEAcrnHKTNbyW0eFx8zQTnZSmO8m4t2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 235,
                column: "Password",
                value: "$2a$11$rwfVDfHOaY3oT6hhqxBAtel8VtCupZwEqXfscnqTZtvmumXywjHQy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 236,
                column: "Password",
                value: "$2a$11$2yyA6XDeuprIlflFiYMkAeAFYXN9MF0bQGJkIVvzaStTyJsmbSyLu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 237,
                column: "Password",
                value: "$2a$11$e6i5oBe06uQbNaaEIJSJwuPs83Gi0OKah/EBlReC2JQ5jyuJ9Ii0C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 238,
                column: "Password",
                value: "$2a$11$yDim3GJVubJfodgZDbrhRewWU4DHhweVT1nZj3qeWpyuceIML73kC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 239,
                column: "Password",
                value: "$2a$11$rnn3cWQ91YGO1x8hnY78.On74kmDSCQWeFSRbSbChJlsyp95melkS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 240,
                column: "Password",
                value: "$2a$11$gQNqAeyRhKnXfucxeB3wHOyuT8DuvjmRIRdxn8i9f7SzJFkoamH/K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 241,
                column: "Password",
                value: "$2a$11$GbKcbf4JRPY9RlXe21ssW.G1mcw.1PlTcbSGasFC8ZSpg5w6pcW9q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 242,
                column: "Password",
                value: "$2a$11$bfLRRCTiRBQ1aq24w.FIp.apIFEl5wkdp4ZNI3/B2qAw8x4rqB4ZS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 243,
                column: "Password",
                value: "$2a$11$S/b6LRHD/SBZ5zD1g.lGUu69Hfm.sUg57DkDBTuprDACUW4sYu5.C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 244,
                column: "Password",
                value: "$2a$11$kZiV5AHIimzERfKJ/AN9U.IaFT73/GOul.l1JLQ67FtZsrMe6I.Oy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 245,
                column: "Password",
                value: "$2a$11$YN88FXcKchTsecOnFbMYOeP3/2ERU2o9CdZPxnTyhNl/US.5gW8/e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 246,
                column: "Password",
                value: "$2a$11$UIM/VGixcXSygSe0aS81OeGuRI02uOfqMMm5Lw0tWIw6P6pxiP09W");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 247,
                column: "Password",
                value: "$2a$11$PitocIr5F.dWDqwGH2nm8uFI3/aXh2QKoUxOcK2JpzjljKvefk8eW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 248,
                column: "Password",
                value: "$2a$11$qiV5mQNiaY7JYfaGL1zQdOQKVNvWXle3ee.gi8eDO54am7UMkRYoy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 249,
                column: "Password",
                value: "$2a$11$JYNNlIkMdLKM.CU3puAa2ODiepOH3f19TO3ohHU9YRMB2mrp8gex6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 250,
                column: "Password",
                value: "$2a$11$IJBjXiE/eonC.BP7bhyXNetR95XMGxc4MXqFcjbtDfNGfc8XNzrfe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 251,
                column: "Password",
                value: "$2a$11$tWvoQ8bFRAcfcFSyqxPic.9mJTxQVR6vYcGHHX6S6C0Qu0yItikIC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 252,
                column: "Password",
                value: "$2a$11$QJl5YmME.wQ0c2rlB/1Q/OCarIOXBBblCqKjthcdcZDMYI/09Mxie");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 253,
                column: "Password",
                value: "$2a$11$fRcS5jodGCdEkIDwoKb02OOPX/UkR3Wh70mWqHWq7eOW2fPOpV6f6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 254,
                column: "Password",
                value: "$2a$11$zJswte9HPGbO3lDzqu2qP.ApPgaI3wg6RgROz9GmhQZMmpiwTrBM6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 255,
                column: "Password",
                value: "$2a$11$62ii5namc0ksoBewsQbjhuPfdWtsZlsbPlNcJ4pN1Wjoexy1d8yhq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 256,
                column: "Password",
                value: "$2a$11$7ciaAOV50Ni0o41wsbhPdOMNKULxTYu2AflS0FB3c7Dx1JFNk.RoK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 257,
                column: "Password",
                value: "$2a$11$zDQqaiOczwS/2xrSPBurm.ZRSkDh0B27rU579.93PMEJP03xWGCFu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 258,
                column: "Password",
                value: "$2a$11$lPclL9gzeqCOOzIoxRVHjuKENwd2Wu5DF/lfPYIKUAsf.EYImalNa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 259,
                column: "Password",
                value: "$2a$11$wrTQPIvDJ8Md5dM5fD6dJuSiJ2oV667a90cJs1tyilGmzPNGTU/Ti");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 260,
                column: "Password",
                value: "$2a$11$PjD8ItLivt6wsKd/muMxJeIzAge9Hbax3OQHxWz8b9O0bTo46pnJe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 261,
                column: "Password",
                value: "$2a$11$Q395QmEqOXTbufpOn38cquxnljpVVhfFKt/uBmv4KR1OmVdd/DHVi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 262,
                column: "Password",
                value: "$2a$11$yw10nV8vFFBieSAOgkWKmu7F62I1eOh9hCYiXjWZB75kGeteGAXUu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 263,
                column: "Password",
                value: "$2a$11$EDwcSdqXb8RXvJl7w9WBh.rnYdVAbqDciPbevgpI5xf04b.3BBvsO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 264,
                column: "Password",
                value: "$2a$11$LCNWDQN9mheoDwvqkxYZrOnx29wAJCWK3/L9EGSOe6PE4hCvkKeQu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 265,
                column: "Password",
                value: "$2a$11$nzK/ZjuYcXwm8Ywe82zl7uFQA1je2GkIP89VVATGJoCEJq9UVosjK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 266,
                column: "Password",
                value: "$2a$11$98b0uo8y5xXQdKElgLy/3eqDYMgsL7QePV5PEmyhaKAgly3v8eyki");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 267,
                column: "Password",
                value: "$2a$11$wSgZH0GSxphg3cG/sSfj5.MjV/0RUOdO6Pkko02IqyGaRsVDFN7Za");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 268,
                column: "Password",
                value: "$2a$11$m.MHSdsrR3oU6g9gpq5x1engtlX7eCDKWdc6xT4bXXmzsRFm0JKvS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 269,
                column: "Password",
                value: "$2a$11$QvBJ5PtTO1.Wo0d5hpXDNezyglsYIGznEXonN9FtgkjrEzi.TGT8y");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 270,
                column: "Password",
                value: "$2a$11$uMFScqcTxeccgCsJKS4qFur99Hcs20uSKY4vbllXas9FcEezwJIRi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 271,
                column: "Password",
                value: "$2a$11$RZh4JMj5YUxdl5mBL9WC6.rAgvaGC1RS3GGcg6Z5OzQmbpJ0KGHBG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 272,
                column: "Password",
                value: "$2a$11$1h6QzGF4kZvSPn4vSl7nkuuk.oOKBLCjmG/rL6fuK6zGsYSoAHBEa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 273,
                column: "Password",
                value: "$2a$11$99nZvdp.MkhWdoUGSuwe.ed9uec3HrB1CdwaXu6MOwBtNvc4QPhOu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 274,
                column: "Password",
                value: "$2a$11$udczl2ea0lyJ1qU2Ht9UhumwG1fDS9x9g862Bu7GzqWwAV55lRTfO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 275,
                column: "Password",
                value: "$2a$11$lK/u5PKrJBsnZN5LioIYAuqtYkXzJeT/endK8EcRIR./khKkbOhzK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 276,
                column: "Password",
                value: "$2a$11$GwxZhfFuarYpJZHrO8hT4.BDmsGdhzRIBJV8m9icUpaBoY0fnqJ/O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 277,
                column: "Password",
                value: "$2a$11$bZkCA51SMZhKNnz7ZpX4VeQeB348e3DxVBBGzYCJ3hHAh42gFrI7e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 278,
                column: "Password",
                value: "$2a$11$gu0uOV4SvKGDz414uc1cRunWdpILfa0G3W1MpFCebw8WMDawBtMmm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 279,
                column: "Password",
                value: "$2a$11$n1rQgvjdsWxrEFHFWfACEuqwY0v87MU0e8JdEpJlON.9rwQmj3jWG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 280,
                column: "Password",
                value: "$2a$11$X1FU2/kt2HP2SOpuek9RN.SccXPIeSFcFwHvdI67Do12roLMIG90K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 281,
                column: "Password",
                value: "$2a$11$eVJKbCYpGGP6Vl6YNRnHz./6qhenTxUf6hCTnPIZaRJTdRwei/Jza");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 282,
                column: "Password",
                value: "$2a$11$o9vgjqcODRrphw1BeSAsY.B9oHDscnOIRfZTHmAp2qNoPuHzXduXe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 283,
                column: "Password",
                value: "$2a$11$/Q101PRPkCgyJBn6VQ.mQ.Etu1F56k1touiIB4BPKGp0jOh1XjbjK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 284,
                column: "Password",
                value: "$2a$11$CPcit0qmyNxEWvqvEhhfVeyjkGGmJLqFA/GAAbkYrT1uCJNER/HW2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 285,
                column: "Password",
                value: "$2a$11$Y3UY3vVYFyera75LwhI/cebEuILe2980bxtdesOr5cqAo3xENn/vm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 286,
                column: "Password",
                value: "$2a$11$ahlYtzJHUxwSRSx/Z1QkLuX5CLLj57QLsQzjrbIoCN5CR3NZYA6Ii");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 287,
                column: "Password",
                value: "$2a$11$W5z8EsO4/G2TaG0/t6Pd1uwRTBy/.2S.vmxylUug2SORe8XEDL1Q6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 288,
                column: "Password",
                value: "$2a$11$RLeScsUq6oKv0ACg63e0Hepvu/fR7/S3XlLB0Xq440PNQzgBbD0I2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 289,
                column: "Password",
                value: "$2a$11$F0tawogDpE3i0WRszp8PUu.bqZc9OfRvovhYZSKCT0Z9MTgjF70i.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 290,
                column: "Password",
                value: "$2a$11$2/fep5mCrzsnlznACDp94O1LnHrPinyZKWknqP7ujEPcOsgGkprwm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 291,
                column: "Password",
                value: "$2a$11$7CTK1pFpswl/tWyVb/6XyObipLTPJqfyAJEZ6AQ8aVfS0ERNtG/ES");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 292,
                column: "Password",
                value: "$2a$11$c43Z7OIAscEy55dsbzY/Re3f/IFLSQkqpyT1QpSSzdbkbuigAUeK2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 293,
                column: "Password",
                value: "$2a$11$9vJcBM6BwOM9AjfSl08xrOYvbBbCbKNxrWk2vTlYHuPVYModsEmpq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 294,
                column: "Password",
                value: "$2a$11$0Ca7KY6druGbexF/Heys.e9F5QKrKZwj47AXWU1yLJXGdWiOfcJVG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 295,
                column: "Password",
                value: "$2a$11$4HSumG1u5nMGaouFYDoTrOv3hzCBjFAT/3BMoQdG6iUq19JnhOkaS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 296,
                column: "Password",
                value: "$2a$11$/yweUWPQElB.c6w6vLXxjeddxNnSkQFsSCqeMIgYNBE98Es.TkuZu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 297,
                column: "Password",
                value: "$2a$11$5E5BImz.N8HE6RMFAGO8mOcbLRn/OdxJUkb7aeZc1iYdnu2AuNyjq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 298,
                column: "Password",
                value: "$2a$11$hpHe.jIB00np1L8KvC2yI.gKkbYaEP9sES/Mvy3Xa1nJsuHj/L.zS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 299,
                column: "Password",
                value: "$2a$11$4S.TCXwV1iwrR.05mQJ2de84M7.V4BkA7.hZTv7.f4Re2P1qEduhq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 300,
                column: "Password",
                value: "$2a$11$8NR9JbWUURrY/E5CWGUEL.lCmufnU6DISVnUAGGgvzcnGCIcbO3P2");
        }
    }
}
