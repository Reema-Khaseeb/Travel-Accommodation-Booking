using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAccommodationBooking.Db.Migrations
{
    public partial class AddFeaturedDeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "ConfirmationNumber",
            //    table: "Booking",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "SpecialRequests",
            //    table: "Booking",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeaturedDeal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedDeal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeaturedDeal_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN001", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6758), "Late check-in, king size bed" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN002", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6767), "Late check-out" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN003", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6768), "Early check-in" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN004", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6770), "High floor, sea view" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN005", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6865), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 6,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN006", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6873), "High floor" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 7,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN007", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6875), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 8,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN008", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6876), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 9,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN009", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6877), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 10,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN010", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6879), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 11,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN011", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6880), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 12,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN012", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6882), "None" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 13,
                columns: new[] { "ConfirmationNumber", "CreatedAt", "SpecialRequests" },
                values: new object[] { "CN013", new DateTime(2024, 10, 15, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(6883), "None" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 10, 15, 4, 36, 29, 979, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.InsertData(
                table: "FeaturedDeal",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "HotelId", "StartDate" },
                values: new object[,]
                {
                    { 1, 0.20000000000000001, new DateTime(2024, 10, 25, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8812), 1, new DateTime(2024, 10, 5, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8810) },
                    { 2, 0.10000000000000001, new DateTime(2024, 10, 30, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8819), 2, new DateTime(2024, 10, 10, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8818) },
                    { 3, 0.10000000000000001, new DateTime(2024, 10, 22, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8820), 1, new DateTime(2024, 10, 8, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8820) },
                    { 4, 0.5, new DateTime(2024, 10, 29, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8822), 2, new DateTime(2024, 10, 12, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8821) },
                    { 5, 0.40000000000000002, new DateTime(2024, 10, 20, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8823), 1, new DateTime(2024, 9, 30, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8823) },
                    { 6, 0.59999999999999998, new DateTime(2024, 10, 27, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8825), 2, new DateTime(2024, 10, 7, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8825) },
                    { 7, 0.20000000000000001, new DateTime(2024, 10, 23, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8826), 1, new DateTime(2024, 10, 11, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8826) },
                    { 8, 0.20000000000000001, new DateTime(2024, 10, 24, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8828), 2, new DateTime(2024, 10, 13, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8827) },
                    { 9, 0.40000000000000002, new DateTime(2024, 10, 21, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8829), 1, new DateTime(2024, 10, 6, 4, 36, 29, 980, DateTimeKind.Utc).AddTicks(8828) }
                });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 9, 16, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8288), 0.89229371460745577, 46.280096292280575, 119.30424809803452, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8335), 340.78238602154352, 5 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 8, 3, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8348), 0.40369705841581005, -27.171823202383806, 115.2307584401924, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8351), 99.729314955182787, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 8, 7, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8357), 0.3138612482531481, 28.435746699084802, -46.092926969613785, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8365), 445.98151332636485 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 3, new DateTime(2024, 8, 18, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8374), 0.56800531082652006, 50.243103796589509, 119.87301732701656, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8376), 472.65409661685612, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 5,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 8, new DateTime(2024, 8, 8, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8381), 0.42520886893173926, 60.240450133701103, 133.41612043647115, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8383), 451.16791630749742, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 6,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8392), 0.67032165671181387, 27.445522114146243, 169.78308336486481, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8394), 270.16217172406346, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 7,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 6, new DateTime(2024, 8, 30, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8405), 0.71309240537467788, -67.692065306271303, 102.12803879833365, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8407), 469.74861446705808, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 8, 24, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8421), 0.67072233727110464, 56.192714094326504, 113.25777007849808, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8436), 333.92719664963602, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 9,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 7, 26, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8441), 0.48292721280904949, 30.344878962579031, -172.87555641370244, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8443), 77.312042691298544, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 10,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 7, 12, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8449), 0.76897768706678182, -42.575047178581059, 48.429586815731795, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8451), 394.82853594727919, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 11,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 8, 13, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8456), 0.080765355448162102, -52.823017787843966, -175.63702378388513, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8458), 385.93620210563313, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 8, 22, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8463), 0.38760383179528091, 17.928719061314879, 24.30129115089693, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8465), 318.95319005646064, 4 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 13,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 9, 4, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8510), 0.04111186594126226, -57.201168286176291, 52.727852300110072, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8513), 492.184177778606, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 14,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 8, 7, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8518), 0.63069379602754172, -30.985881212272041, -41.458624867043, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8520), 251.02838336026801, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 15,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 9, 14, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8525), 0.85442858771699659, 57.278407606071397, -50.522135972400946, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8530), 499.46173407452824, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 16,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 7, new DateTime(2024, 7, 27, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8559), 0.40555036055823046, -34.481963641367777, 138.650126756487, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8561), 256.83667692990502 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 7, 8, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8566), 0.42876423634041927, -7.4384522922899805, -143.58813101400239, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8568), 65.007273645878001 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 4, new DateTime(2024, 10, 14, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8573), 0.16882543634203495, 47.145966711854413, -151.65127390644676, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8576), 477.04835090525972, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8581), 0.76638957857166412, 51.382324056026704, -154.94390272516779, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8583), 289.26629983730106, 3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 10, 1, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8588), 0.97771915732915871, 75.279213573637747, 125.55805157833396, new DateTime(2024, 10, 15, 7, 36, 29, 979, DateTimeKind.Local).AddTicks(8590), 342.15765228930587 });

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
                values: new object[] { 2, "http://example.com/hotel2_image2.jpg" });

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
                column: "ImageUrl",
                value: "http://example.com/hotel2_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "ImageUrl",
                value: "http://example.com/hotel2_image5.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "ImageUrl",
                value: "http://example.com/hotel3_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 3, "http://example.com/hotel3_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "ImageUrl",
                value: "http://example.com/hotel4_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "ImageUrl",
                value: "http://example.com/hotel4_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "ImageUrl",
                value: "http://example.com/hotel4_image3.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel6_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 19,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 20,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 21,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 7, "http://example.com/hotel7_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 22,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 23,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 24,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 8, "http://example.com/hotel8_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 25,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 26,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 27,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 9, "http://example.com/hotel9_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 28,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 29,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 30,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 10, "http://example.com/hotel10_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 31,
                column: "ImageUrl",
                value: "http://example.com/hotel10_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                column: "ImageUrl",
                value: "http://example.com/hotel10_image5.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 37,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 11, "http://example.com/hotel11_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 38,
                column: "ImageUrl",
                value: "http://example.com/hotel12_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 12, "http://example.com/hotel12_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 44,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 45,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 52,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 53,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 15, "http://example.com/hotel15_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 54,
                column: "ImageUrl",
                value: "http://example.com/hotel16_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                column: "ImageUrl",
                value: "http://example.com/hotel16_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 16, "http://example.com/hotel16_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57,
                column: "ImageUrl",
                value: "http://example.com/hotel17_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58,
                column: "ImageUrl",
                value: "http://example.com/hotel17_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image4.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image5.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62,
                column: "ImageUrl",
                value: "http://example.com/hotel18_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 66, 19, "http://example.com/hotel19_image2.jpg" },
                    { 67, 19, "http://example.com/hotel19_image3.jpg" },
                    { 68, 19, "http://example.com/hotel19_image4.jpg" },
                    { 69, 19, "http://example.com/hotel19_image5.jpg" },
                    { 70, 20, "http://example.com/hotel20_image1.jpg" },
                    { 71, 20, "http://example.com/hotel20_image2.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 463m, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 157m, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 372m, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 594m, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 127m, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 6,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 279m, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 7,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 646m, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 8,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 592m, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 9,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 771m, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 10,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 479m, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 11,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 514m, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 12,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 722m, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 13,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 568m, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 8, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1912), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 5, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1933), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1937), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 9, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1941), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1944), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 8, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1948), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 8, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1951), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1954), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 11, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1957), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 4, 30, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1960), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 11, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1967), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 2, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1970), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1973), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 8, 1, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1976), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 9, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1979), 40 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 4, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1981), 45 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 10, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1984), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1988), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 9, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1991), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 1, 18, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1994), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 6, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(1997), 12 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2023, 11, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2000), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 9, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2004), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 2, 19, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2006), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 1, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2009), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 8, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2012), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 8, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2055), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 7, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2059), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 7, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2062), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 10, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2065), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 1, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2068), 24 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2071), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 6, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2074), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 2, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2078), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 1, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2081), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2083), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 9, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2086), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2089), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2092), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2095), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2098), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 4, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2101), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 5, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2104), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 1, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2107), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 9, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2110), 42 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 8, 19, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2113), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 4, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2115), 51 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2118), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 4, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2121), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 7, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2124), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 3, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2127), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2023, 11, 2, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2131), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 11, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2133), 6 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 11, 1, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2137), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 7, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2140), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 9, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2143), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 10, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2146), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2148), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2152), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 6, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2155), 77 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 2, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2157), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2161), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 6, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2164), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 7, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2166), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 5, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2169), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2023, 11, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2173), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2175), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 3, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2210), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 30, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2214), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 3, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2216), 25 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 7, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2219), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 11, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2222), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 1, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2225), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2023, 10, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2228), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 1, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2231), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 6, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2234), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 9, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2237), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 7, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2240), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2243), 71 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2246), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 6, 10, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2249), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2252), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2255), 21 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 10, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2258), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2261), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 2, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2264), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 9, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2267), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2270), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 1, 10, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 7, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2276), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 9, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2279), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 2, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2283), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2286), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94,
                column: "ReviewDate",
                value: new DateTime(2024, 3, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 2, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2292), 46 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 8, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2295), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 2, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2298), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 8, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2301), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 10, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2304), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 3, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2307), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2310), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 5, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2313), 37 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2316), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 8, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2319), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 1, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2322), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 1, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2325), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 5, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2328), 76 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2024, 6, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2331), 28 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 8, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2334), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 10, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2336), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 11, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2339), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2342), 20 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 10, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2345), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 114,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2348), 65 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 115,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 6, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2351), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 116,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2354), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 117,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 9, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2356), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 118,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 3, 18, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2359), 17 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 119,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 11, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2395), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 120,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2023, 11, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2399), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 121,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 6, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2402), 39 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 122,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 4, 30, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2405), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 123,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 10, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2408), 33 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 124,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2411), 55 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 125,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2023, 12, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2414), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 126,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 4, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2417), 75 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 127,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2419), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 128,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 3, 2, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2422), 15 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 129,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 8, 10, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2425), 27 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 130,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 7, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2429), 36 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 131,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 3, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2432), 18 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 132,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 7, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2435), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 133,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 5, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2438), 56 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 134,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 5, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2441), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 135,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 9, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2443), 29 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 136,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 10, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2446), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 137,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 6, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2449), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 138,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 8, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2452), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 139,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2455), 70 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 140,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2458), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 141,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 8, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2461), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 142,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 4, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2463), 60 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 143,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2467), 72 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 144,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 3, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2469), 44 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 145,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 5, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2472), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 146,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 6, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2475), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 147,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 3, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2478), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 148,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 2, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2481), 66 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 149,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2484), 49 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 150,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2487), 80 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 151,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 8, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2489), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 152,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 8, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2492), 47 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 153,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 5, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2495), 38 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 154,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2498), 32 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 155,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 9, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2501), 31 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 156,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 5, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2504), 30 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 157,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2539), 52 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 158,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 5, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2543), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 159,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2545), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 160,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2024, 9, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2548), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 161,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 7, 27, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2551), 63 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 162,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2024, 10, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2554), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 163,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 9, 13, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2557), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 164,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2023, 11, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2560), 53 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 165,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 7, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2563), 16 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 166,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 2, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2566), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 167,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 6, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2569), 69 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 168,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 9, 19, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2572), 57 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 169,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 6, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2575), 23 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 170,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2024, 2, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2578), 50 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 171,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 6, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2581), 5 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 172,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 1, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2584), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2023, 12, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 174,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 2, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2590), 34 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 175,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 9, 19, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2593), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 176,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2596), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 177,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 3, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2599), 64 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 178,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 16, "This is a review content for Hotel 16", new DateTime(2024, 9, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2602), 61 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 179,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 10, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2605), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 180,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 10, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2608), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 181,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 8, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2611), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 182,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 6, 18, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2613), 35 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 183,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2023, 12, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2616), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 184,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 13, "This is a review content for Hotel 13", new DateTime(2024, 6, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2619), 67 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 185,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 14, "This is a review content for Hotel 14", new DateTime(2024, 7, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2622), 13 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 186,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2024, 9, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2625), 59 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 187,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 8, 7, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2628), 26 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 188,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 7, 19, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2631), 71 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 189,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 8, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2634), 48 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 190,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2024, 2, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2637), 73 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 191,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 5, "This is a review content for Hotel 5", new DateTime(2024, 9, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2640), 68 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 192,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2024, 8, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2642), 19 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 193,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 10, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2646), 3 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 194,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2649), 8 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 195,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 12, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2651), 9 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 196,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2655), 41 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 197,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 4, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2658), 54 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 198,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 9, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2661), 58 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 199,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 4, "This is a review content for Hotel 4", new DateTime(2024, 9, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2664), 14 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 200,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 18, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(2666), 67 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 10, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3590), 11, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3604), 66m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 7, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3620), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3624), 416m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3630), 8, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3633), 324m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 8, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3638), 4, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3641), 299m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 9, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3648), 19, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3651), 140m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 8, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3658), 18, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3666), 206m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 10, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3671), 18, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3673), 105m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 8, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3679), 20, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3682), 424m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 9, 26, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3686), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3688), 200m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 8, 2, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3693), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3695), 371m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 7, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3699), 7, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3701), 124m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 9, 6, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3705), 10, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3707), 485m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 7, 16, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3711), 8, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3713), 357m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 9, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3760), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3762), 427m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 7, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3766), 12, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3768), 337m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 8, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3772), 9, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3774), 80m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 7, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3777), 14, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3779), 303m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 18,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 9, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3784), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3786), 272m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 8, 10, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3790), 1, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3792), 151m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 1, new DateTime(2024, 7, 22, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3796), 5, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3798), 298m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 21,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 8, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3802), 18, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3804), 484m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 22,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 7, 29, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3808), 11, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3810), 84m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 9, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3813), 1, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3815), 482m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 7, 21, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3821), 286m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 7, 11, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3825), 2, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3827), 83m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 9, 25, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3833), 277m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 7, 31, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3837), 11, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3839), 441m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 10, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3842), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3844), 215m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 3, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3848), 1, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3850), 427m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 30,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 8, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3854), 10, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3856), 331m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 31,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 2, new DateTime(2024, 9, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3860), 17, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3862), 175m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 10, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3866), 1, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3868), 346m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 8, 23, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3871), 4, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3873), 60m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 34,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 7, 18, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3878), 11, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3880), 133m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 35,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 8, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3884), 14, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3886), 221m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 7, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3890), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3892), 233m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 7, 20, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3896), 15, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3898), 116m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 8, 4, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3901), 13, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3903), 455m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 9, 5, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3907), 16, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3909), 160m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 7, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3913), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3915), 281m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 41,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 1, new DateTime(2024, 9, 14, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3919), 20, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3921), 240m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 42,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 8, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3925), 17, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3927), 90m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 43,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 9, 2, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3967), 7, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3969), 58m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 0, new DateTime(2024, 8, 30, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3974), 11, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3976), 161m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 9, 24, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3979), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3981), 364m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 10, 12, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3985), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3987), 368m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 47,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 8, 8, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3991), 3, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3993), 345m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 48,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 9, 17, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3997), 6, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(3999), 363m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 1, new DateTime(2024, 7, 9, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(4003), 19, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(4005), 147m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 50,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 7, 28, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(4008), 13, new DateTime(2024, 10, 15, 7, 36, 29, 980, DateTimeKind.Local).AddTicks(4010), 223m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$CWmbNpRQPTtlWD8Zgp5bvePBc2KIrB9kYqpFYq9e8.F6ujt4DdIke");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$R1l4uMV6L8gLuzcfRGSVVOqZsjgP9JwZDL3o5p7DOtpcTTl7MU47S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$9h5KCkrLbFUvWvvM6askHO4meiwdHtEb836ZaHa9yrT2lXwphhcZ6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$ImybZESdMxKcsBu0FX.4OO7Vl.7/jfEkTWEjrCdYHzx9RcT7Akywm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$Q1JlEJTSjtl.yNrmSoJAwOmSqMOFkN5E3eeY/s/JlCuC.EK5yx3Zq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$qt9KVm3Nff07TGd0HqytceRv47jinoSf2wHL84aXkqIvSwLZtqaeG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$elQFKgxnBKfiM76fgGFeiux/izyT7grVjfbEfB3FjQ0ocSJGvg9hW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$lkQqZIuGcL2YdK7SbhDuvO9dYRvZPsp.5lA5QbnRVDYqJzNgEu7iO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$jW4eCD3IRcsEZ0B1UNknBuFjv7wPHjPTvqXiaLHe7km7GW0ABT25u");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 10,
                column: "Password",
                value: "$2a$11$X26GAsKMnn.zy7fQhk1Oiu/4B0CbhqdA0MZrbKnAwOp1E7LcdoXPi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "$2a$11$TqL7GrT6i76A2a40Tnntk.Gjvi.b/b9lO8fktqPverpZVMbCEsV1G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 12,
                column: "Password",
                value: "$2a$11$3iWD2PaB0Cxn8/PXyDPLQO440hiFzG./slE96oEKnu.qKB/y2MEx.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 13,
                column: "Password",
                value: "$2a$11$Nl6Y/TP5GB6JzjKvpv0R9.Sfm6KJZmTjgls0nAFgBzlw5tEeJ7AUm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 14,
                column: "Password",
                value: "$2a$11$i8OLMUmnvKpO1Mm8cg1/j./VvJmVI2q0CM8dZ3mfuMmAuPb6Wxjmq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 15,
                column: "Password",
                value: "$2a$11$dcM.Jr0Prif04QGvUTmw.e7tjTer7.gMtfb2IeYMUnobNSCRwLXZK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 16,
                column: "Password",
                value: "$2a$11$iwcspyqT7iVMzPMZ8pykPOqQtEaCh74wyY0.xtgtuCD0B2NhU20xy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 17,
                column: "Password",
                value: "$2a$11$.wSPXQbWJJ0S0yUg4JZyWeOJZkUKFBtCRnqFtWMC6gmo5lVJuffcq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 18,
                column: "Password",
                value: "$2a$11$J2uoyQ1vkW6upqE5I0hd4.l4uQJnz8be08ag15S.kHsSR4o9/oqO.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 19,
                column: "Password",
                value: "$2a$11$HimZgEFZhsF4pDTJRU9BqeoFGAnqe2t2unzMtbWXRUHSwJn7LlJ3C");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 20,
                column: "Password",
                value: "$2a$11$Iy1f9eqSj9SHP/PQuiehD.0WEm1XMnhgx.nOfoDoOlBXy0IwPMd66");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 21,
                column: "Password",
                value: "$2a$11$FA53Q8k4jQsQjLn9CyesmuyiSJPCd.hdoMaC/Y/bh9Fjp.6ossOLq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 22,
                column: "Password",
                value: "$2a$11$U.xPvBlMlC2qe6.jrVRd..7WSHx79Mcw4j7CrxZ5Y1dhCXwakXlrK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 23,
                column: "Password",
                value: "$2a$11$cVV8bKqYgJx3oUVmGOKvwuaTlZDvinF5xDuJU6w38KD.hacJvr5ta");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 24,
                column: "Password",
                value: "$2a$11$KrpeJpK1l8bEtb4xLfwQnerUFyRa33qXYqi6DYT1jopJjB.y1Pjry");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 25,
                column: "Password",
                value: "$2a$11$T9QdOT03Q9Z0mRkKnginj.4aEp93f1KPDa4I1B6sok5Arp7oKJzWG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 26,
                column: "Password",
                value: "$2a$11$wBUgaGf1Da1bgHEXk/70VOv27qECN7bG7xVuAoCjCqvsMoLnQBVa2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 27,
                column: "Password",
                value: "$2a$11$24qoHdJQI1v5mhc6UCbfJOlkXZaeIJFtmfHNGj9/Np/HF7CcvsU1S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 28,
                column: "Password",
                value: "$2a$11$NKm3q9bqIsV80zzg1pBXzubEaTUBc3I2.7GNppVYOCA1dQAJhfpVa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 29,
                column: "Password",
                value: "$2a$11$woQpXaGVV17NltUWgMCW/elMsyRj/dNohQPwl/ERU63jVgr9g0/M2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 30,
                column: "Password",
                value: "$2a$11$fAMTCkJ29EnfGlJnXC6NiuGzuydtFaSGh4ClSgKj4zQ33LpVGgdx6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 31,
                column: "Password",
                value: "$2a$11$dXqJn8MWLoQG5UY7UPjBTuVE9uqH4jZvDZUo2l2nl5NFFHOtvlbKW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 32,
                column: "Password",
                value: "$2a$11$z8AO7H9XkoCMcXfumBDGZOJVQL1A7DSkUBRiuodFAXq3J./oiFkmy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 33,
                column: "Password",
                value: "$2a$11$LrM69P9bT.2yNtpZzii5F.woaEvBAxM9Db6X5rsprqq/m.5mIBf0m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 34,
                column: "Password",
                value: "$2a$11$PrZzR25sDczTzJvM1jICz.jjrrSaOsZYBPmw.57R.9CSKz0zPvkP.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 35,
                column: "Password",
                value: "$2a$11$Q7AykehUk5OSFWnWwAdw1Olzq.IqCSf2uPdoeY7bZeiGmS7T1I4Ri");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 36,
                column: "Password",
                value: "$2a$11$Vcwo0ioJS1tH5QO3zMJeg.wtJ2UCEXh0mS45cj8Gp8G.kyAS1hgSa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 37,
                column: "Password",
                value: "$2a$11$b/hQ5jFMYEnDVeTmkxvOHOknDgqfJ6iD21VRHxPEnxCKgNlNJ6bfa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 38,
                column: "Password",
                value: "$2a$11$Cxb1Xq/W4ud7p1Co36JzFe5XdytqDLGAqfpyiywrvT9O/lLzE0hju");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 39,
                column: "Password",
                value: "$2a$11$a8qv3DGCOMlUhjSsPZEfjuHaUhNS0sQta2w6rlq7LMuX9tr1hImV2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 40,
                column: "Password",
                value: "$2a$11$/gUNsl4zIPbZ4k9rasi7beTNdFK7G7wPB97Tlr4/YMoRYsIohDU0i");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 41,
                column: "Password",
                value: "$2a$11$PUo9oY0a07m6G0WK4scI4.hYC6aqk1z6.6j62A0lIeOERAvlBYnmi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 42,
                column: "Password",
                value: "$2a$11$YAhm.GSPrmbWA0Oc3teLGOUP4WQVjgLnkE/Qz0QMiFpW45wye2TPm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 43,
                column: "Password",
                value: "$2a$11$Q9pr8CG04pch5wamy0oet.YtxwONeytcssx.2yJ/7xDhemtkwMjde");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 44,
                column: "Password",
                value: "$2a$11$ptbNVg2hfg2CoD.hyq1guOg6OdoZnyysKnxg7aGBmvDnrj11vketi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 45,
                column: "Password",
                value: "$2a$11$Z5189wwXoE5WSuSpRbV1nuE33O.CLSEs/uLdwpFnupq7gKHN7B.Me");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 46,
                column: "Password",
                value: "$2a$11$PIk0GGLVldPlFLoMZAvpJe1tADNgmZiFkwIO1poOpzkFG98OW/9fG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 47,
                column: "Password",
                value: "$2a$11$Z9OXQdqF2.xcnEV4RjRkduOn6R8rMwQIkQkJ9DaQUnKhz9beOHoUy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 48,
                column: "Password",
                value: "$2a$11$YYG4n0iwhW2C/MT8Ws.t9uEv0Om3ish3LtFNsG1IZgUN/OWMIECJW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 49,
                column: "Password",
                value: "$2a$11$DWimnLCjm19QxSeXqxLzTuZtW1vWK63.aeV4khUjkAP/hr9TVIWMm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 50,
                column: "Password",
                value: "$2a$11$TsMgIEhbb9StM3stbFnF6.FU9wtT2HZFA5hfpFwAzcsBv1eEe6J7q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 51,
                column: "Password",
                value: "$2a$11$mRWxJjv43NYm8hfGh.Znw.hFMkrnjfCdYIGIWbzp3gfxEzel6wQIa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 52,
                column: "Password",
                value: "$2a$11$LMy7KU1335SOrCmSDZ6l0e/.7zcjWX96CD8Sgxa2zbMKTKgnyOGP.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 53,
                column: "Password",
                value: "$2a$11$3bp1E6wCo45h1pL2taX3eu7ZFlO3QYM837EBTpmeUDKcKXQUTdnYi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 54,
                column: "Password",
                value: "$2a$11$weRT3z/gMLd85IJOdOtxAe5OV8iM4yU8NgF2hB8GqKRVljKBOUaQO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 55,
                column: "Password",
                value: "$2a$11$7RpS/S7nzZDGuTJe0j34GONhsc85D0DdIkd0WcG9GPAZA/7FuiPuS");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 56,
                column: "Password",
                value: "$2a$11$cgwVo5CaD7oY5JulpT0lO.cfj.Hy6lcBDjagvqGjNs7JS6hNmtI1K");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 57,
                column: "Password",
                value: "$2a$11$QN0Vwjs6/CCXXZn6F.YY0uI8Xy/SHy5T4P4LtMu5.xl1dui7EyNqK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 58,
                column: "Password",
                value: "$2a$11$37MHxCHK4/7x0tSAPOGxgeQuh9jBsbJgWJ9j8XuwHgVEqlzCiwhEG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 59,
                column: "Password",
                value: "$2a$11$T80dNMcY3JNeeKDU7pEfpu6gj3DATmqRDkhXq9I4168E8tZ9dkdx2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 60,
                column: "Password",
                value: "$2a$11$SfItEwhivyyLcXei.vA4CO5Q2lk76E49iFbZlRNfC.cCyOhieakui");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 61,
                column: "Password",
                value: "$2a$11$PN7lR3nBK.VpLXad3oXIeeUN7kB77zWPAI5F0cZJ.vVZQI7ngCrJO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 62,
                column: "Password",
                value: "$2a$11$nbf/PwcZHdPHGdq088pAKeHLeZeVZp0YYglwRcgSOme9UBHkvtPAK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 63,
                column: "Password",
                value: "$2a$11$DaEOWDvAsSAe3eHmKDIqDOJI3qR8RG9FOhXuFcflqUqFY5rQ8r8mG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 64,
                column: "Password",
                value: "$2a$11$IFqO0HTj1HkYHKhoIV8hleZn8v93Pjr4Fcg/mqvM3fV8HP2VQUm0q");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 65,
                column: "Password",
                value: "$2a$11$ApLnGZFHU8sjJLGgIFW7nuCxwmCMUKQIX7mFo.vNFQEmI1qT5NRG.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 66,
                column: "Password",
                value: "$2a$11$D51.VY7AIYNLRGHxkuo23OwqipmG30P3zHvvrF2zvDsnmRDRhRyPO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 67,
                column: "Password",
                value: "$2a$11$zb3a1rygTN.Gc0G7NB2zyu4F.GmGeEcLNO.epc.lT0TebGT1oRSjG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 68,
                column: "Password",
                value: "$2a$11$qwEFAm8tmtHjze.XKg0sn.5DMJFmec1YfXIGtNMW5dqoj5vAtPdHC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 69,
                column: "Password",
                value: "$2a$11$vD7PzbefnXYAcWMeeS91qupqR2ecMakOr8bOmD3XMFEnjhfmCizDK");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 70,
                column: "Password",
                value: "$2a$11$sqxtMdZg5FStVljSqaCeSuYsUpb81vnphppmPJ5JwAOI02vnhuOPO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 71,
                column: "Password",
                value: "$2a$11$lh4NDPbCSFJzsnDuOw41MeMiSoRoKgmfpTXHOk3XBwYObajf1LBJe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 72,
                column: "Password",
                value: "$2a$11$wQ8Iy9XIaarKbygMVyozQ.1RusXOzYbZ5XzA2cSAfRvBhTDzwy06m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 73,
                column: "Password",
                value: "$2a$11$PSvvBBM6zI43r2DzxHBg7ujt9.BLIMgzPG.HFON8Sm4v9UJpi2z52");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 74,
                column: "Password",
                value: "$2a$11$JnQ.zF145yEG3YlAVKsNOeggbC9eB8xA/1HyGMZwRay4LZ0uRUD8O");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 75,
                column: "Password",
                value: "$2a$11$/ieN5V4JUmpSFhyz1t2s8uOVXf2MG4SCuPSThFuoTpPs4jNJPtpWe");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 76,
                column: "Password",
                value: "$2a$11$DwE1P.TZydY04GsQk/5SQuLsvXJusL8DrnNkNVMIb/HrkdgcnFcti");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 77,
                column: "Password",
                value: "$2a$11$v.oLppPMWPTizKNFdtg1YOgWqBCrKYisi774pAIuZkljXKgXmuZou");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 78,
                column: "Password",
                value: "$2a$11$lxkD.78yWNZnRPIrNb5T.eSkj/mf10rCeFHED9XNL3cCeNMdYqhGq");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 79,
                column: "Password",
                value: "$2a$11$i/JeXEiyCJf4M0rX0lGd/eddbxFJsVHiINdNYgrug7G2IFQginw2e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 80,
                column: "Password",
                value: "$2a$11$Me5QZPZKIuKafV0NsQ9pPOjz89xkAjd/A1wFk.aeCG/51YZyV1uqu");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedDeal_HotelId",
                table: "FeaturedDeal",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturedDeal");

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 71);

            migrationBuilder.DropColumn(
                name: "ConfirmationNumber",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SpecialRequests",
                table: "Booking");

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 6, 8, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7486), 0.43454983748324882, -60.306146315234557, -35.235811708103057, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7489), 231.1027163445446, 1 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 6, 16, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7495), 0.52678523104552843, -89.619103465958759, 45.220206549043951, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7503), 87.500646844635042 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 9, new DateTime(2024, 6, 4, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7538), 0.0043835605183621951, -74.533718861622205, -127.04799036297273, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7541), 373.27375880103392, 1 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 4, 15, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7588), 0.28362374463374895, 35.871763574383522, -152.84468418311241, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7590), 480.09755340250103, 4 });

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
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7607), 0.74842079254007199, 47.406234695364105, 77.408201773948406, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7609), 260.46950215158455, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 12,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 5, new DateTime(2024, 4, 28, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7615), 0.086829936536606533, 13.120585167088223, -44.097266030168214, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7617), 1.2269173631159758, 3 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 2, new DateTime(2024, 7, 5, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7683), 0.22860884440699858, 59.55643296196331, 25.299100933561988, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7685), 388.87546242228461, 5 });

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
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 5, 19, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7748), 0.56628825937890181, 71.082376443015136, -94.7323843077303, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7751), 209.32599402896219 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 17,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { 6, new DateTime(2024, 5, 3, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7758), 0.92207913238285932, 38.833801190842735, -103.15170224212604, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7760), 309.53609000999921 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 18,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 7, new DateTime(2024, 5, 1, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7767), 0.96955735464853654, -43.70942233091705, -141.32506144856671, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7769), 427.94752664591977, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 19,
                columns: new[] { "CityId", "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price", "StarRating" },
                values: new object[] { 10, new DateTime(2024, 6, 23, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7775), 0.74711944398085783, -55.184314802700257, 146.14572304947222, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7777), 405.85723217573508, 2 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelId",
                keyValue: 20,
                columns: new[] { "CreationDate", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7784), 0.85785905830133014, -81.077649813952561, 1.3365957849670735, new DateTime(2024, 7, 17, 15, 21, 15, 784, DateTimeKind.Local).AddTicks(7786), 428.00242750007828 });

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
                column: "ImageUrl",
                value: "http://example.com/hotel2_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "ImageUrl",
                value: "http://example.com/hotel2_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "ImageUrl",
                value: "http://example.com/hotel2_image3.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel3_image1.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel4_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "ImageUrl",
                value: "http://example.com/hotel4_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "ImageUrl",
                value: "http://example.com/hotel4_image4.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel6_image1.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel10_image1.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 32,
                column: "ImageUrl",
                value: "http://example.com/hotel10_image2.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel12_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 39,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 40,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 13, "http://example.com/hotel13_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 41,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 42,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 43,
                column: "ImageUrl",
                value: "http://example.com/hotel13_image5.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel14_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 46,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 47,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 48,
                column: "ImageUrl",
                value: "http://example.com/hotel14_image5.jpg");

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
                column: "ImageUrl",
                value: "http://example.com/hotel16_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 55,
                column: "ImageUrl",
                value: "http://example.com/hotel16_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 56,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 17, "http://example.com/hotel17_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 57,
                column: "ImageUrl",
                value: "http://example.com/hotel17_image2.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 58,
                column: "ImageUrl",
                value: "http://example.com/hotel17_image3.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 59,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 60,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 61,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 18, "http://example.com/hotel18_image3.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 62,
                column: "ImageUrl",
                value: "http://example.com/hotel18_image4.jpg");

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 63,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image1.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 64,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 19, "http://example.com/hotel19_image2.jpg" });

            migrationBuilder.UpdateData(
                table: "HotelImage",
                keyColumn: "ImageId",
                keyValue: 65,
                columns: new[] { "HotelId", "ImageUrl" },
                values: new object[] { 20, "http://example.com/hotel20_image1.jpg" });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1918), 60 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 10, "This is a review content for Hotel 10", new DateTime(2024, 1, 3, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1936), 79 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13,
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1940), 28 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 6, "This is a review content for Hotel 6", new DateTime(2024, 5, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1951), 16 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1959), 22 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1966), 65 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 8, "This is a review content for Hotel 8", new DateTime(2023, 9, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(1987), 72 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 2, "This is a review content for Hotel 2", new DateTime(2023, 11, 8, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2081), 43 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2112), 27 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2140), 7 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 11, "This is a review content for Hotel 11", new DateTime(2023, 7, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2199), 52 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2292) });

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
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2309));

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2319), 5 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 8, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2334), 10 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2341), 7 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 9, "This is a review content for Hotel 9", new DateTime(2024, 5, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2359), 14 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2373), 62 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 113,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 20, "This is a review content for Hotel 20", new DateTime(2023, 7, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2377), 11 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2387), 38 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 16, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2416), 3 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2520), 57 });

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
                columns: new[] { "ReviewDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2540), 74 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2582), 74 });

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
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[] { 3, "This is a review content for Hotel 3", new DateTime(2024, 2, 19, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2660), 78 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 173,
                columns: new[] { "HotelId", "ReviewContent", "ReviewDate" },
                values: new object[] { 18, "This is a review content for Hotel 18", new DateTime(2024, 4, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(2663) });

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
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 7, 2, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3757), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3770), 290m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, 2, new DateTime(2024, 7, 10, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3783), 19, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3785), 433m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 4, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3790), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3792), 208m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3797), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3799), 152m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 6, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3803), 16, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3806), 294m });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 5, 30, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3818), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3820), 388m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 2, new DateTime(2024, 5, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3825), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3827), 97m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 4, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3832), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3834), 333m });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3846), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3848), 400m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 6, 6, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3853), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3855), 461m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 4, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3859), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3861), 238m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 6, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3866), 11, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3868), 370m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 7, 7, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3872), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3875), 88m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 6, 22, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3924), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3927), 188m, 2 });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 0, new DateTime(2024, 5, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3939), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3941), 285m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 19,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 6, 24, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3946), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3948), 146m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 20,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, 2, new DateTime(2024, 4, 29, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3952), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3954), 255m, 1 });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 4, 21, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3966), 18, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3968), 337m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 23,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3972), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3974), 382m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 24,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 5, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3981), 487m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 25,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 7, 13, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3985), 8, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3987), 92m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 26,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 2, new DateTime(2024, 4, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3994), 148m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 27,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 2, new DateTime(2024, 6, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(3998), 15, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4001), 436m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 28,
                columns: new[] { "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { new DateTime(2024, 4, 14, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4005), 2, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4007), 119m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 29,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4012), 10, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4014), 287m });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, 0, new DateTime(2024, 5, 12, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4025), 11, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4028), 249m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 32,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, new DateTime(2024, 6, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4032), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4034), 90m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 33,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 4, new DateTime(2024, 7, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4039), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4041), 499m, 3 });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 0, new DateTime(2024, 6, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4053), 13, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4055), 65m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 36,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, new DateTime(2024, 5, 18, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4060), 19, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4062), 486m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 37,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 2, new DateTime(2024, 5, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4066), 3, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4068), 220m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 38,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 4, 2, new DateTime(2024, 4, 9, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4073), 17, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4075), 95m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 39,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, 0, new DateTime(2024, 7, 5, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4080), 8, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4082), 285m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 40,
                columns: new[] { "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 0, new DateTime(2024, 4, 27, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4086), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4089), 184m, 1 });

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
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, 1, new DateTime(2024, 4, 23, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4107), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4109), 405m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 44,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4113), 3, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4116), 342m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 45,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price" },
                values: new object[] { 3, new DateTime(2024, 5, 15, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4157), 3, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4160), 271m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 46,
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 3, new DateTime(2024, 6, 28, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4164), 6, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4167), 218m, 3 });

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
                columns: new[] { "AdultsCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 1, new DateTime(2024, 6, 1, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4178), 5, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4180), 196m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 49,
                columns: new[] { "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "ModificationDate", "Price", "RoomType" },
                values: new object[] { 2, 0, new DateTime(2024, 5, 11, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4185), 7, new DateTime(2024, 7, 17, 15, 21, 15, 785, DateTimeKind.Local).AddTicks(4187), 348m, 3 });

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
    }
}
