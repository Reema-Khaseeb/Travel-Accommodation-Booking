using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAccommodationBooking.Db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<decimal>(type: "decimal(10,8)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(11,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotel_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelImage",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImage", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_HotelImage_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewContent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AdultsCapacity = table.Column<int>(type: "int", nullable: false),
                    ChildrenCapacity = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.CheckConstraint("CK_Room_AdultsCapacity", "[AdultsCapacity] BETWEEN 1 AND 4");
                    table.CheckConstraint("CK_Room_ChildrenCapacity", "[ChildrenCapacity] BETWEEN 0 AND 2");
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.CheckConstraint("CK_Booking_CheckOutDate_After_CheckInDate", "[CheckOutDate] > [CheckInDate]");
                    table.ForeignKey(
                        name: "FK_Booking_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Country", "CreationDate", "ModificationDate", "Name", "PostOffice", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "Country1", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City1", "PostOffice1", "http://example.com/city1.jpg" },
                    { 2, "Country2", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5752), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City2", "PostOffice2", "http://example.com/city2.jpg" },
                    { 3, "Country3", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City3", "PostOffice3", "http://example.com/city3.jpg" },
                    { 4, "Country4", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5758), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City4", "PostOffice4", "http://example.com/city4.jpg" },
                    { 5, "Country5", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City5", "PostOffice5", "http://example.com/city5.jpg" },
                    { 6, "Country6", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5763), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City6", "PostOffice6", "http://example.com/city6.jpg" },
                    { 7, "Country7", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5766), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City7", "PostOffice7", "http://example.com/city7.jpg" },
                    { 8, "Country8", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5768), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City8", "PostOffice8", "http://example.com/city8.jpg" },
                    { 9, "Country9", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5770), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City9", "PostOffice9", "http://example.com/city9.jpg" },
                    { 10, "Country10", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5779), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City10", "PostOffice10", "http://example.com/city10.jpg" },
                    { 11, "Country11", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5782), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City11", "PostOffice11", "http://example.com/city11.jpg" },
                    { 12, "Country12", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5784), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City12", "PostOffice12", "http://example.com/city12.jpg" },
                    { 13, "Country13", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5786), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City13", "PostOffice13", "http://example.com/city13.jpg" },
                    { 14, "Country14", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5789), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City14", "PostOffice14", "http://example.com/city14.jpg" },
                    { 15, "Country15", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5791), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City15", "PostOffice15", "http://example.com/city15.jpg" },
                    { 16, "Country16", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5793), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City16", "PostOffice16", "http://example.com/city16.jpg" },
                    { 17, "Country17", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City17", "PostOffice17", "http://example.com/city17.jpg" },
                    { 18, "Country18", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City18", "PostOffice18", "http://example.com/city18.jpg" },
                    { 19, "Country19", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City19", "PostOffice19", "http://example.com/city19.jpg" },
                    { 20, "Country20", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City20", "PostOffice20", "http://example.com/city20.jpg" },
                    { 21, "Country21", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City21", "PostOffice21", "http://example.com/city21.jpg" },
                    { 22, "Country22", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City22", "PostOffice22", "http://example.com/city22.jpg" },
                    { 23, "Country23", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City23", "PostOffice23", "http://example.com/city23.jpg" },
                    { 24, "Country24", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City24", "PostOffice24", "http://example.com/city24.jpg" },
                    { 25, "Country25", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City25", "PostOffice25", "http://example.com/city25.jpg" },
                    { 26, "Country26", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5816), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City26", "PostOffice26", "http://example.com/city26.jpg" },
                    { 27, "Country27", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5818), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City27", "PostOffice27", "http://example.com/city27.jpg" },
                    { 28, "Country28", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City28", "PostOffice28", "http://example.com/city28.jpg" },
                    { 29, "Country29", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City29", "PostOffice29", "http://example.com/city29.jpg" },
                    { 30, "Country30", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City30", "PostOffice30", "http://example.com/city30.jpg" },
                    { 31, "Country31", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5826), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City31", "PostOffice31", "http://example.com/city31.jpg" },
                    { 32, "Country32", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City32", "PostOffice32", "http://example.com/city32.jpg" },
                    { 33, "Country33", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5831), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City33", "PostOffice33", "http://example.com/city33.jpg" },
                    { 34, "Country34", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City34", "PostOffice34", "http://example.com/city34.jpg" },
                    { 35, "Country35", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City35", "PostOffice35", "http://example.com/city35.jpg" },
                    { 36, "Country36", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5843), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City36", "PostOffice36", "http://example.com/city36.jpg" },
                    { 37, "Country37", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City37", "PostOffice37", "http://example.com/city37.jpg" },
                    { 38, "Country38", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5848), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City38", "PostOffice38", "http://example.com/city38.jpg" },
                    { 39, "Country39", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City39", "PostOffice39", "http://example.com/city39.jpg" },
                    { 40, "Country40", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City40", "PostOffice40", "http://example.com/city40.jpg" },
                    { 41, "Country41", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City41", "PostOffice41", "http://example.com/city41.jpg" },
                    { 42, "Country42", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5856), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City42", "PostOffice42", "http://example.com/city42.jpg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Country", "CreationDate", "ModificationDate", "Name", "PostOffice", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 43, "Country43", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City43", "PostOffice43", "http://example.com/city43.jpg" },
                    { 44, "Country44", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City44", "PostOffice44", "http://example.com/city44.jpg" },
                    { 45, "Country45", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5863), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City45", "PostOffice45", "http://example.com/city45.jpg" },
                    { 46, "Country46", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5865), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City46", "PostOffice46", "http://example.com/city46.jpg" },
                    { 47, "Country47", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City47", "PostOffice47", "http://example.com/city47.jpg" },
                    { 48, "Country48", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5869), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City48", "PostOffice48", "http://example.com/city48.jpg" },
                    { 49, "Country49", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5871), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City49", "PostOffice49", "http://example.com/city49.jpg" },
                    { 50, "Country50", new DateTime(2024, 3, 3, 12, 13, 24, 547, DateTimeKind.Utc).AddTicks(5874), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City50", "PostOffice50", "http://example.com/city50.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 85.8024679340843m, -138.208683985617m },
                    { 2, 8.55542497490222m, -171.061129108214m },
                    { 3, 81.4594556078252m, -34.5147731670494m },
                    { 4, -58.776346195188m, -117.951796197454m },
                    { 5, -85.3979937574516m, 112.641061609543m },
                    { 6, -27.1214291554759m, 110.278087108883m },
                    { 7, 7.23342953400964m, -166.348134749565m },
                    { 8, 49.5053498785352m, 92.1670240571938m },
                    { 9, -53.8878235886015m, -150.612335639289m },
                    { 10, 62.8616854458104m, -59.1553027416941m },
                    { 11, -77.086283804493m, 28.923973004108m },
                    { 12, 64.7325434832294m, -48.2063697634899m },
                    { 13, -14.4881423763072m, -33.6754472911387m },
                    { 14, 63.2317769059417m, 37.899279928778m },
                    { 15, 23.110087076312m, -151.942353689593m },
                    { 16, -71.0060777591846m, 66.8288008265577m },
                    { 17, 47.9588025245278m, 135.677048435792m },
                    { 18, 63.9209038999888m, -10.2552245353875m },
                    { 19, 23.7281829307532m, 169.162329654773m },
                    { 20, 11.6564462954913m, 11.2360810142307m },
                    { 21, -4.74062412073451m, -59.8778189640918m },
                    { 22, -18.2303406528032m, 52.235101124933m },
                    { 23, -43.3437607964408m, 169.722358020117m },
                    { 24, -17.760213038939m, -65.2172708162773m },
                    { 25, 9.12792423876407m, -119.885264643174m },
                    { 26, 2.03049069640805m, 157.117375064798m },
                    { 27, 33.3697022886335m, -28.0890369478986m },
                    { 28, -45.7460488876885m, 146.081760805698m },
                    { 29, 88.9904159920879m, -153.407527002541m },
                    { 30, -58.1542139992436m, -131.461398891199m },
                    { 31, -40.3346855709098m, -124.147866710628m },
                    { 32, -70.2810655754534m, 79.8957771587884m },
                    { 33, -72.5339543791696m, 16.5960893124869m },
                    { 34, -33.8650672893478m, 62.3039405000338m }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 35, 42.2470354530479m, 118.274802324295m },
                    { 36, 29.2360047302244m, -155.064878762701m },
                    { 37, -36.6287050709068m, 179.488175770125m },
                    { 38, -1.83961320213282m, -41.7938364360086m },
                    { 39, -67.2458150695726m, -103.940352125044m },
                    { 40, -35.599628841896m, 173.320002264374m },
                    { 41, -75.8697314807792m, 97.822305247337m },
                    { 42, -28.0075287760311m, -58.8327126143721m },
                    { 43, -87.0091252168118m, 33.4015804623353m },
                    { 44, 47.7240971656796m, -136.56813983242m },
                    { 45, 11.0527157281335m, 89.5254398070488m },
                    { 46, 81.306719786481m, 56.3673656247751m },
                    { 47, 25.9759654682543m, -50.6541732539197m },
                    { 48, -67.2900718010915m, 17.958386199973m },
                    { 49, -2.29527509777898m, -16.3638089532744m },
                    { 50, -33.5830444791717m, -19.1571494613769m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin1@example.com", "$2a$11$hee6L3q0sDAUoAd8yeMZ9ucCiDpa6YmD.CPp1PWBQOz.m1F88HhLm", 1, "admin1" },
                    { 2, "admin2@example.com", "$2a$11$WTPFRcnN0R0aXsSh/v9S3e5j4/UPkuj/DmM81SA2d7akvh55Wzh9m", 1, "admin2" },
                    { 3, "user3@example.com", "$2a$11$zaj3V8kKbKNin.lb.f8Ia.JLTBambLXYGQ1HqO38RIi2kVRhrgOEG", 0, "user3" },
                    { 4, "user4@example.com", "$2a$11$thpLN4ul0Tsu9WCbIuKTROOQEXPLC2nwdczHm4aSoOBqMZ0acM9me", 0, "user4" },
                    { 5, "user5@example.com", "$2a$11$nzi2JXwVKhXPip3.7WmPced7HNgHYVGvHk0LA8ICZBC9NIyxIrEne", 0, "user5" },
                    { 6, "user6@example.com", "$2a$11$UHojYP4pkXyGOPEreqfsxOrexgs9AkvJoYJx/HL2YKJMLV7M7Sa3.", 0, "user6" },
                    { 7, "user7@example.com", "$2a$11$pNS28Zz9XXvyvtK3yp2khuXGryKLW79tJ1/BZuQgQ74EU6blW6xXG", 0, "user7" },
                    { 8, "user8@example.com", "$2a$11$vH0csvEOAhUtGTsSx/82w.K/V.EtA9aLI5B7v6so3z8dqxTi5h8De", 0, "user8" },
                    { 9, "user9@example.com", "$2a$11$LVlNh4UFub2utoQYDgQzNOzr8e5pENIByf0stUnW9Lyvtp2A84sh6", 0, "user9" },
                    { 10, "user10@example.com", "$2a$11$1Cc0dJpSJk/yFLHNnAYiJ.VSrUWriOOrqjkmgm2tMOAz7gMno3HJm", 0, "user10" },
                    { 11, "user11@example.com", "$2a$11$InCZ.bfSwdq3F.ze26DJYuNmHceBYvAHA6uNqsLWkkeLUNtpnQac2", 0, "user11" },
                    { 12, "user12@example.com", "$2a$11$WjI.iX3eZf2Gdj1CMAk.6uMT40IDqhTF2DoVpK2yO6EMIg2lXxk/y", 0, "user12" },
                    { 13, "user13@example.com", "$2a$11$MmpynU19FXUOWdH/1qQENOha.bGGKFdrccjaxf/qPwUVW5DpGDC2i", 0, "user13" },
                    { 14, "user14@example.com", "$2a$11$S86SyMyaGD6t6Q1X7S0hL.7nK0.CYSLwQJ43F4BLsFNPsD219t11.", 0, "user14" },
                    { 15, "user15@example.com", "$2a$11$/MZ6YEQPy4pkBtPD3a6ZSewN1bhPKF8.6dThEQDZLiffzj19kuhaO", 0, "user15" },
                    { 16, "user16@example.com", "$2a$11$dWdpGfGTvnrmrru/4fzHPuOxGbH83mW8p6M7aGARoDgOD5DBEnnPu", 0, "user16" },
                    { 17, "user17@example.com", "$2a$11$G1oLuEGiqnQkb3TVR.8GQOCQxgh8Vp0NKrSd2Z1c0AHiohuI9qgCS", 0, "user17" },
                    { 18, "user18@example.com", "$2a$11$fIxwY/rUofhVVVyCnHGBwux9c4nkMfgsV4VxfvG0nmTxJS5SJVz8a", 0, "user18" },
                    { 19, "user19@example.com", "$2a$11$O5sfjmR/yIhuKHqDKQpKc.ybgbCFalx6I0dPlUZ/v25NlVYPdHFSi", 0, "user19" },
                    { 20, "user20@example.com", "$2a$11$badzSboxGfAPM/KJAy/D4OUhuStOT1Uk7WjYukXMjPR0HeC5agvo.", 0, "user20" },
                    { 21, "user21@example.com", "$2a$11$5/R8eXuyndbrZrYAtoxhbuMC8GuEzh5anDyVnSb5PGlnsDQdS9a0G", 0, "user21" },
                    { 22, "user22@example.com", "$2a$11$u97TGlQPFCZan3FQBeZITuN9SwoQz8xYCvbd0jqEU7Km.BMSdAkUi", 0, "user22" },
                    { 23, "user23@example.com", "$2a$11$XeziXzkZuErlveMZx3YOg.qn0hNFjchR4OqKYHX5qU3WY29j2Asv6", 0, "user23" },
                    { 24, "user24@example.com", "$2a$11$V1u5l2tzUUAZeuQrHu2Q.OcZg.7wppH.yTEQj9CsvDmcCCs6DiXxK", 0, "user24" },
                    { 25, "user25@example.com", "$2a$11$ugBcZKuzJpj8ZY12OzApi.jxjo3LrzM4H1U3.qdr1Hh/eaCTqf.AK", 0, "user25" },
                    { 26, "user26@example.com", "$2a$11$ZHha1YMVMRud/PYlrh6hF.FbKNtUzcFCqt6bXx1JGSLgb7Hgd.Us6", 0, "user26" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 27, "user27@example.com", "$2a$11$cH3WIJV8qIvozn6uDzjl0OPR4ULFWlkF49i/cZ.EE2IBakLgnUWHu", 0, "user27" },
                    { 28, "user28@example.com", "$2a$11$7We5pDcJJ/IwsIlmRz6v9e1IQX56hSXjC0d6F5cdS79z5WWQrxEUG", 0, "user28" },
                    { 29, "user29@example.com", "$2a$11$qSw39k9BXUrBbe7sITlbPOx.XCpASrlYHN3D2KJOfZz4ICaPdh7F2", 0, "user29" },
                    { 30, "user30@example.com", "$2a$11$Ir/4yrnLDzoSF4sVrWCbTugP2Te5IEL173KM8YiUd11IJghf64ZqC", 0, "user30" },
                    { 31, "user31@example.com", "$2a$11$fXvDTxoDsLuoeKb3aOuH9egRZpw7fKlCDZD33WyfwkZtXklP7BDA2", 0, "user31" },
                    { 32, "user32@example.com", "$2a$11$4/cS5FuBUMIj75h0hjGM9Or0OYGTvVamnPSXx0NOj6sOc4O6xJ4ii", 0, "user32" },
                    { 33, "user33@example.com", "$2a$11$1psK6pkne/au4HHSKRF5qufukZB3GyBLU47MfJJbGNkNP8FD33AsG", 0, "user33" },
                    { 34, "user34@example.com", "$2a$11$XlWtf2xJblOlbCgnGWjt5O2r/ONAJvZccv6eJ0PELNp.TKumBxzXa", 0, "user34" },
                    { 35, "user35@example.com", "$2a$11$G7Al187H2VXsnHeiGYIsa.HTwOUtjG7kGTqlsrtVQVIQ6bk729Xzm", 0, "user35" },
                    { 36, "user36@example.com", "$2a$11$ou8ZErjj09ZGDzqcxaokJ.CVBwp.ohvDWeeD2PA6gAkPIzNu5yQe2", 0, "user36" },
                    { 37, "user37@example.com", "$2a$11$d5CqExeVQCJATTL7ga1Pz.ghPp38I17J8LkS9bv1rBmB0mRa.NpUG", 0, "user37" },
                    { 38, "user38@example.com", "$2a$11$cCzz856lcuZIZHeIYQgdH.JE6KCcSV3Z/ECprucPWLn18e32JSoEu", 0, "user38" },
                    { 39, "user39@example.com", "$2a$11$Lh6/YZILI6UqbWm2kgvPdeyCW4VErK9MJOzTsR1GzrJThSwNfEQVu", 0, "user39" },
                    { 40, "user40@example.com", "$2a$11$g3X2fFXQOGhOoF1X52HTK.4TZoWtgQthluY8NudmKEpUSzbLqCtv2", 0, "user40" },
                    { 41, "user41@example.com", "$2a$11$tQULv9L1aheOk88o7W.oq.ER7Hi6TFhjBmWADDS.3RK3hjr3fIlxS", 0, "user41" },
                    { 42, "user42@example.com", "$2a$11$BKo2JKfFYcL6nRjKdjqy3OjlL4zuG7WdWTdQcac19uOnXbbV0PumC", 0, "user42" },
                    { 43, "user43@example.com", "$2a$11$bRck5CxDImHwrIDqQksriOgOMYEdfu3qRqe1/Jy4QlAAjNlXzYrB.", 0, "user43" },
                    { 44, "user44@example.com", "$2a$11$iBaK8PcvH446GO4lxQVM0uUcppz9sjA/HpJjZLX46eb4jVgciQkMm", 0, "user44" },
                    { 45, "user45@example.com", "$2a$11$4.DY7P8XGKYTFuI5hQmIh.2VuDxHMTRL/im8sZ9v7bG9gpoTAiKJ6", 0, "user45" },
                    { 46, "user46@example.com", "$2a$11$w9pehMPAtzEH2q2YR4FKCuQA6rdFlCDj9MZ8cAkaYm5Rf2L/lL5Q6", 0, "user46" },
                    { 47, "user47@example.com", "$2a$11$/GCbW5o7lnVxLWCTD3WVnuoV9ISV1oIHvBk5XbLWAlIU3u8cLKf0C", 0, "user47" },
                    { 48, "user48@example.com", "$2a$11$041wEr/vR5rJzY/q9YUv2OjFFbHiRRvPv7FSA8s.QcJjie.o2k8gq", 0, "user48" },
                    { 49, "user49@example.com", "$2a$11$mE9Q4CNR86iv8ehQo5Sj0.m0XApVq1K94YsfaD/q9cdO88Mm/528m", 0, "user49" },
                    { 50, "user50@example.com", "$2a$11$Dnm8bAs8eVpadXwUZOj.NugfVFOIWS2wlT5jBn9ZRn5D.Z/U76Z9W", 0, "user50" },
                    { 51, "user51@example.com", "$2a$11$6DG4eDLCC71Oxbe9zwT0s.eTbFCZFsllFqL4Wy9/pHK8QpmzA.jt6", 0, "user51" },
                    { 52, "user52@example.com", "$2a$11$vilmCbxKSTt.Bv9Rfxu4lO8oKaevCBxARBL2ie1VfUzvDzjqEIMIK", 0, "user52" },
                    { 53, "user53@example.com", "$2a$11$7imET4yUlt9K/RMvqrX1/eX2pFW2kNzMbVZTQk5b7E1PyWeeJzrxu", 0, "user53" },
                    { 54, "user54@example.com", "$2a$11$eMI7tLiC1/Lq.98Uztt0eOAbA2jl60U5MrBcVG4aU9C4VofrsUDgW", 0, "user54" },
                    { 55, "user55@example.com", "$2a$11$4.XLt.Tsn/aQJdiyVLwSuehJJ2vFRdyaabpifK/2A6Pix/917JcdS", 0, "user55" },
                    { 56, "user56@example.com", "$2a$11$1B8IOdEslCIu.nYU50YNhOKeGgiBm7VoELUOkaKqcRxNGOJSBxwgO", 0, "user56" },
                    { 57, "user57@example.com", "$2a$11$5A/T/1P4YLz1K9cv1E82NeTm1XAzMtZGSUb7h3HLfaVuEQnS9y/Q.", 0, "user57" },
                    { 58, "user58@example.com", "$2a$11$crTOgjAFK/CtUheeQDoe3eDiKkuT6KoB6yorgG8iFgn0R0kleqR7.", 0, "user58" },
                    { 59, "user59@example.com", "$2a$11$VAVebUcev3YG8s7kV9M5oONHLSXijgO86wUu8FPpczy/rmMU0tzw.", 0, "user59" },
                    { 60, "user60@example.com", "$2a$11$D.hLfdchLUx3yGxEUuPEwOQPTOM4Q10o2GF8OElOOm.vr8AgoJlN6", 0, "user60" },
                    { 61, "user61@example.com", "$2a$11$kWekGPCHFNgtbEyBpnJr2utwUzzqgh.cwmhlIu/J12zZGZWL9ShX2", 0, "user61" },
                    { 62, "user62@example.com", "$2a$11$5z86yu4070QrFjUmM9dp8eCdlJ/7hOpUxiNdueTKOkAuwPRVQy57S", 0, "user62" },
                    { 63, "user63@example.com", "$2a$11$IH1rgAo8GSO1QMF2kJSHpuEmRUftwGMpWmQOfuxjVsNPz9fIrlrh2", 0, "user63" },
                    { 64, "user64@example.com", "$2a$11$nulo3cUJD5x90RicZxdW0O2YLx5ziGrKTt2rbBCJhOdOmuODvs6cm", 0, "user64" },
                    { 65, "user65@example.com", "$2a$11$flVH54QgenUUnRX5At69Lui5EBfkZX6m7BCnfPlriC32EF1YZaH26", 0, "user65" },
                    { 66, "user66@example.com", "$2a$11$q7A2cOLwnWYJmQnZjsEUnufzK27rjpDBK6ZWrFmlNRQbibS6ko7sK", 0, "user66" },
                    { 67, "user67@example.com", "$2a$11$VhVhvH0maVnrZzQOWBTi0.f1wTvsxszs/RKfvPhdbgP.bE7.tZab.", 0, "user67" },
                    { 68, "user68@example.com", "$2a$11$8KlVFOYtbgAO6PYVOhcz4OaaORW9Htnk7jY2zW9z24gffkK20KabW", 0, "user68" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 69, "user69@example.com", "$2a$11$fTa4.NJ.ePZGa8OUYINK9.m.mag/b2AeparmxYHSMj.51qgbJ3UJO", 0, "user69" },
                    { 70, "user70@example.com", "$2a$11$Ylr0SGcpOMLg/hgLEKZir.n6B9aboBalldO/zGGrk0ckukczdchKa", 0, "user70" },
                    { 71, "user71@example.com", "$2a$11$PtnloJUcVgN4og..pZOJ3.5LhcKo.jSXJJkhb1gh.WaQBIh9MxMvW", 0, "user71" },
                    { 72, "user72@example.com", "$2a$11$NbhjVgQoP.J5/o234kh8yeW6ZSGUVN6vuEoL3M1JtxaCOIV2s09Ka", 0, "user72" },
                    { 73, "user73@example.com", "$2a$11$b2ib.0e.e8.c.iPb2dkDjuas8vwyqKMk3/XPYzDOs.6XsS4AWX0.6", 0, "user73" },
                    { 74, "user74@example.com", "$2a$11$BuKJ1jJBKsQBm6NsZQrNze5CPJoY3mvEq1xZkOd1BlP8GNBWUu9Qq", 0, "user74" },
                    { 75, "user75@example.com", "$2a$11$y1qcJi1tKym61Wglpr359ePto7WU8gLB4rv/jhhQ6UsS.M6sHPDdq", 0, "user75" },
                    { 76, "user76@example.com", "$2a$11$nsGqc9ypVs.gix2cMegehOz6COFvTO3xa2TAnhK5D83CIzH8h9C9O", 0, "user76" },
                    { 77, "user77@example.com", "$2a$11$51URkeNYEptHOdkb.T1KPemPGPC6BeGbMpc1diqMh2.3cUDsAkjB6", 0, "user77" },
                    { 78, "user78@example.com", "$2a$11$28siIQsWE9Y8XgIwNuNrseg5TkfM/GoAry762LJjv4Q99w7r3EIam", 0, "user78" },
                    { 79, "user79@example.com", "$2a$11$SyHz9BejFUIAa1/zKPQTTeW2kRR5ZJKiJp99AMaQMdeUzUL3MdYV.", 0, "user79" },
                    { 80, "user80@example.com", "$2a$11$PO9GKZFSOVqi0r1M/r1Beea2QhRDjRTcDsV/UMyyJG2N4AVvQ8LcW", 0, "user80" },
                    { 81, "user81@example.com", "$2a$11$lW9ADQhLBwKGNpjNe3Eve.wXl360b1/Vqio8LXU08C4xyExIgrICe", 0, "user81" },
                    { 82, "user82@example.com", "$2a$11$6Epf3FVy9/a7Uzt9xcUeUu8tgJNhf8hl3cQVh7LkuCiXibUbrcFdu", 0, "user82" },
                    { 83, "user83@example.com", "$2a$11$nvcB5k2UGafqNXGN4jq1euv1bxiey/i1IGih4zjH4IvupLgCrEUXm", 0, "user83" },
                    { 84, "user84@example.com", "$2a$11$AaipNJorZNjtHtRoKX3yP.9iUAgy6mMGG.H7Nn0aSWfArgxMM2q/C", 0, "user84" },
                    { 85, "user85@example.com", "$2a$11$wXFn6yWsJXueIoakTjnXs..p1iGYcyML2lXxctehx2T5YlmzD0u9y", 0, "user85" },
                    { 86, "user86@example.com", "$2a$11$OeWLIkHzd9/.hoKPhJve.uMYutmKmD4.IQy0ZYoo2msNIY44GwrM6", 0, "user86" },
                    { 87, "user87@example.com", "$2a$11$2cmxcK/NJcxRfM6MFmUICOs0P9q1tM5xQh70kjw1tVcwW/.sns1JW", 0, "user87" },
                    { 88, "user88@example.com", "$2a$11$zMMdP7/thSOW.K5A6wdH.uIQitecfoUW/bOnDhZUD4nCVPuHIcy7S", 0, "user88" },
                    { 89, "user89@example.com", "$2a$11$VfuJr.o2ksM05twgNIzqLuwge6KtinGHQkxmnJ0Nu/VQ5KE8UwL82", 0, "user89" },
                    { 90, "user90@example.com", "$2a$11$6csXlDHzYMLv2NeZrQDMZOyXjI.XKRVduvL.lV1zYEWGMZgi7DXq6", 0, "user90" },
                    { 91, "user91@example.com", "$2a$11$1oxZEm78qJkA6jWCH5hxXOOQ3mqrvsgms14jlDOWoBJnRLJtmHa9O", 0, "user91" },
                    { 92, "user92@example.com", "$2a$11$uoPSTdoF8xSdlW2o/TmdEuwGivoGmxtq4UI7xfay47z.hG.vDEI2G", 0, "user92" },
                    { 93, "user93@example.com", "$2a$11$/rUYYpRKq2Xc0YE2ZXmoxO9SkrD7PfTBoNcfsnVzmsu1m/xej.5pW", 0, "user93" },
                    { 94, "user94@example.com", "$2a$11$ZxvNmaAj1ly54yHSrHaFdeROwv3vF16C4ZVlTKfd9as0k8JvF1vNC", 0, "user94" },
                    { 95, "user95@example.com", "$2a$11$0YVkD.pjfjGs4uYtaGPwvOKU.6ZXwETjlQBs/rlmv5aYg88oDHtR.", 0, "user95" },
                    { 96, "user96@example.com", "$2a$11$Xlk1hayr7CElvZcBWOpZcuy/69/gVusTUoUW4G/lVFpG7vmqtZ6I6", 0, "user96" },
                    { 97, "user97@example.com", "$2a$11$IPcpnKKVKV9oql0cljZx7OepsLdwWqGBRUnFp9X37g5WjbKVNBMIe", 0, "user97" },
                    { 98, "user98@example.com", "$2a$11$fHQvuoglOtkJXW3PieyZEe59Tzs3IBOlQB1/N3tEQ18OVaj5BD8Fe", 0, "user98" },
                    { 99, "user99@example.com", "$2a$11$1T4Aa45.xJ1pge/Lq7mkO.0TUmL/xkUIHeWQ4bxrVGyZTpTU0wyBG", 0, "user99" },
                    { 100, "user100@example.com", "$2a$11$qr5JsWF4oTl32/syivpx2O3IGYz5XtsSVlABDTLW2PdoQVzra9mGC", 0, "user100" },
                    { 101, "user101@example.com", "$2a$11$307cDVgbYtVgaNTWpC5YdOAHYSGskriHZuF0u0BCiuT.o0e0hpgx2", 0, "user101" },
                    { 102, "user102@example.com", "$2a$11$jWe5UeiLfhzjylKmEswOieMl17MApIIrJBroOlqm7ttSKfMVsXYBW", 0, "user102" },
                    { 103, "user103@example.com", "$2a$11$y5JLGN1p2ziazF6bKngwRONaqJjQgBxtN1WupPpu3iK90moTX/pCu", 0, "user103" },
                    { 104, "user104@example.com", "$2a$11$WXF95NYZ5kQsiGErR0W4PuC/RzyzYGwiHw0sH0YhtJpaxA1gUH1NS", 0, "user104" },
                    { 105, "user105@example.com", "$2a$11$IgKWsej2TD0jPZBGlmQ1rOu9I.D4ZqxyHjOB6Cr/SoNSSA3SBidkW", 0, "user105" },
                    { 106, "user106@example.com", "$2a$11$141W5gAavWxdTrwXyV8w/u4hirTuGorBED.dfNXuRvwwKDqXxbZXO", 0, "user106" },
                    { 107, "user107@example.com", "$2a$11$EaA2IAl7aIAVlSOfnbwSMOiWIaUywVmu4j31RrIZQM3kjL7ujAuXS", 0, "user107" },
                    { 108, "user108@example.com", "$2a$11$H8LrgVShepEYjoEXrzXiM.JHRiE1/YdZJwB3hbdh/JUyUaqFAtIiC", 0, "user108" },
                    { 109, "user109@example.com", "$2a$11$RH.QrtD4Hxg/rlGIzG0hzOFdCWXuwdRBUb8W8dXWvGys0/BQqmP4m", 0, "user109" },
                    { 110, "user110@example.com", "$2a$11$SG0JmzLNEaOepuyKRVeu6OOcVC.l5kjknMAo1rzngtupLprBFjzkm", 0, "user110" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 111, "user111@example.com", "$2a$11$RD4b4cIKI5kP.s8PXizKCeGLHi8c7LXTsQJn/WsHi/9linBSZLXdu", 0, "user111" },
                    { 112, "user112@example.com", "$2a$11$R8ZO0c61iP15GSAvuFEzZuh9aRwGdAEhxy5f68oRNLHR9CFz/XSlC", 0, "user112" },
                    { 113, "user113@example.com", "$2a$11$KQkdQ1bh7T52xfgvcXux4etgTLBT0WIX0I.yWRA3/vNMAeMUm1rx2", 0, "user113" },
                    { 114, "user114@example.com", "$2a$11$9UXNILHf.BM7J9RaWnyWSuXl5GJbLB1.k5FRcT.XR7Uf3D5qSJVG.", 0, "user114" },
                    { 115, "user115@example.com", "$2a$11$4mUD6lX2mZNNQSmr6OXq9O28RTKu3CVgZghVh6WqYCG4MVa.09sjG", 0, "user115" },
                    { 116, "user116@example.com", "$2a$11$edbpziKCF8wZolyOF1eTmevZ0uhggg9dQsZNQ1jVr8g.chhtSZl.O", 0, "user116" },
                    { 117, "user117@example.com", "$2a$11$WIeC9yULIXY81lmdJx8AH.wwwTvIg1bSKZ5Bf0RN6Yoo24Rvk4B1K", 0, "user117" },
                    { 118, "user118@example.com", "$2a$11$gEH2UPphUF5l3S6e5RXND.z3vKFImd6DKvKp2HjQ.Mj6gFEnZd7Yy", 0, "user118" },
                    { 119, "user119@example.com", "$2a$11$T7fvXg7ec2ZEBjCJKNhn5OWsTRq4jIHQoi/Z0EAbOHyKVIN8GJxVO", 0, "user119" },
                    { 120, "user120@example.com", "$2a$11$XBOtIickkDoiU4/OqN6xd.lbhqRecNNAiRAsicqeemXPFCQmKYBq6", 0, "user120" },
                    { 121, "user121@example.com", "$2a$11$W9q.bzZwCSnqgdDPsgl03O4DN2PhjLOc3Elw0ufQkqZDYocrtN2U6", 0, "user121" },
                    { 122, "user122@example.com", "$2a$11$CCj9K0ROb2bwKmwLfbANxOmOCYel9opvUXr7wtNBiedjzrTgMyrim", 0, "user122" },
                    { 123, "user123@example.com", "$2a$11$gkAx21zTEYQ9THEw6GXBU.KNdn2aXKAWf4LjYU0P/6TWDCuDXH9J.", 0, "user123" },
                    { 124, "user124@example.com", "$2a$11$80mYKBwClRVhdmsQqaeZM.7PuvRwUvyEj8IzXm3gOWNcUWfGv7/l.", 0, "user124" },
                    { 125, "user125@example.com", "$2a$11$j3/VG1e80eCshZqkUWPe4u9INp/DHFJrQNXBrvvXufh/N.azWQgei", 0, "user125" },
                    { 126, "user126@example.com", "$2a$11$IbHZ2tfsuVOvdJgaeJw2Aeg7Id5yxwy3LLm67RjBozBguaiZRBqhW", 0, "user126" },
                    { 127, "user127@example.com", "$2a$11$WEiMOKotuDlnd1ppwEVwFuojpy3jb70a/OBUGr8eQ/xAAX9Gjtuge", 0, "user127" },
                    { 128, "user128@example.com", "$2a$11$nEx/zXLZJ//2Z8QddPSoMOL8MPXRZUTmL4gzMufz6knMwf7TUk6Da", 0, "user128" },
                    { 129, "user129@example.com", "$2a$11$vuEpiLsZTuSSMBapOc6B4OZnYiDtoBAePyAt7ulok9jHZk8a5bW9W", 0, "user129" },
                    { 130, "user130@example.com", "$2a$11$hcd/YGNsV4eN4ORWa3/cte/TlszkFihf/3hLuYggkxCUnI65.glzK", 0, "user130" },
                    { 131, "user131@example.com", "$2a$11$yX0BdVeZY/4cjPuVO52c8u4EsjvgvoWcRZfSV90GkY94uAL4FXO6K", 0, "user131" },
                    { 132, "user132@example.com", "$2a$11$Y.RwnNbmPO3tqzT5Slxch.avAA7UnG9hZSJr6IxR7W6eI9iDF/oTu", 0, "user132" },
                    { 133, "user133@example.com", "$2a$11$hwcZDj2UwwLLXf8EyC2ViOpPskdh93P7MQjHyvNYQPLOJqTFP1mEe", 0, "user133" },
                    { 134, "user134@example.com", "$2a$11$DZMdz/dcTfGxZaYW8c47L./XrCjEKWHQiPBWQNJFtMcEYwPQLsXYO", 0, "user134" },
                    { 135, "user135@example.com", "$2a$11$duO3xvxJ/HikUYvdRtmAB.2JkxidcTkDC9Jk0v4keYFaDgWDyfAu6", 0, "user135" },
                    { 136, "user136@example.com", "$2a$11$3BnSuBpUKOnYecgf/ad4E.QkLySL/5zCbdLrAf7lYt753Yy9Viv26", 0, "user136" },
                    { 137, "user137@example.com", "$2a$11$9CXdkU7VrtRKNUYpSLZC5uW9.RIu3Hhf2Gio7zI7bS3jZ4IU.T/y2", 0, "user137" },
                    { 138, "user138@example.com", "$2a$11$3Az0yoR9P4hKwuFiBpSnvetxrivsTeNiaUbEIncwBHvR4aROKauwG", 0, "user138" },
                    { 139, "user139@example.com", "$2a$11$PTUTX2rxLc/qmOffU/s02ublB6FQHWLnGfLxaevQ4zLxELhkKPBjq", 0, "user139" },
                    { 140, "user140@example.com", "$2a$11$srTahthMxBHkYiMiYnZRIeLKoRHscIf8OUV9Jsdo7i2fdWQK2nHem", 0, "user140" },
                    { 141, "user141@example.com", "$2a$11$bFfDGQH1hmYnPUqD5w/lnuE0q2W9x54GHTj.F0gMj5Jy6MBZF2yI2", 0, "user141" },
                    { 142, "user142@example.com", "$2a$11$OxIMOo5oMSP4diMPRS2b8uMeKQZlNd1gjFSdnCiLh823tSK/ndr0i", 0, "user142" },
                    { 143, "user143@example.com", "$2a$11$7fZmjw0EdTOCGDjnm06J3uXhPE86O7CBt5JfCiOmuPga9ZhBM8rIi", 0, "user143" },
                    { 144, "user144@example.com", "$2a$11$35oJKNbRK.hzCnHJsezGFu/lq66sECVXS25.Nfcc6hj68tzIQSQ2e", 0, "user144" },
                    { 145, "user145@example.com", "$2a$11$GLrCwId4iMmPuoxKJANHFe/PsXT83AU76eps.xqk7SmZsY5mP3uQG", 0, "user145" },
                    { 146, "user146@example.com", "$2a$11$IHaD8GWDnl6X0AR9tQwPd.2gPkzinPY35S4FEprgToSRxL.isTYfK", 0, "user146" },
                    { 147, "user147@example.com", "$2a$11$yklZE9WVAcFtakqfHF0b6u0cCKtbKmxkhIKAOrBa.AgXDQ5T3LSBG", 0, "user147" },
                    { 148, "user148@example.com", "$2a$11$WeDzZoknE1XBLF5iIiiM9.QX6MMexgE7iPX2EQmtYzQclNPlcDZqS", 0, "user148" },
                    { 149, "user149@example.com", "$2a$11$G.1G.6PQK/LOIkW45DH4Degc85Qy8xZihUgsX04LpXQ.n0mYCh6XO", 0, "user149" },
                    { 150, "user150@example.com", "$2a$11$y9V9M/Lq2zFVxfkzMePPH.7DVVCwEETmDTaUgV6I2QcKIF5v0Qzmy", 0, "user150" },
                    { 151, "user151@example.com", "$2a$11$Ph7PwdAWOsxygDcvFU26FeSzvpYix8JrrgYTxCbCbqqNBqS6mycna", 0, "user151" },
                    { 152, "user152@example.com", "$2a$11$NgPmKeMmJUGuJZIy5lupZOz/czw3.s0u1xJ1w5Eoc9qFFpCsmLt1u", 0, "user152" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 153, "user153@example.com", "$2a$11$Vc6mERHVWCCiu6akfP0wQOD4nx6LhVGgkT6RH0WQnXt170O8jkzsK", 0, "user153" },
                    { 154, "user154@example.com", "$2a$11$Ik022PJLfKZKxsIzIZzqZOIJ/3oQjq42yUUjc0CWKZSXsE4EoeNrW", 0, "user154" },
                    { 155, "user155@example.com", "$2a$11$ATFPz75ELP2kCG6TrV4TFezJyo0YJ5LpZomh8WzYkWbCp8Y301bjS", 0, "user155" },
                    { 156, "user156@example.com", "$2a$11$PRy0YM/HuytzOcnKPXT5xOwPmZh5E3PtWyHScgDJaltXqZlX5pJPy", 0, "user156" },
                    { 157, "user157@example.com", "$2a$11$KNXNxLIeUUrEmV0sPWXSS.lysp5/w5fR5sKKD5iPuy0r4ry/u.Wmu", 0, "user157" },
                    { 158, "user158@example.com", "$2a$11$VbzEdLXp.0cwkDW2nteZq.Yn5abNnL7NVXplaTkDD3w9WzvtHGRrq", 0, "user158" },
                    { 159, "user159@example.com", "$2a$11$V3TJYhfVeRWFXHVXfJeliO.rGrjvazuLeDoOeZ/g.rwFen4EcZTT.", 0, "user159" },
                    { 160, "user160@example.com", "$2a$11$wQ59NAEiAsATM/g5WC44den8jU6.OVUBr3AEdpb1KerAwoSvxqQZ.", 0, "user160" },
                    { 161, "user161@example.com", "$2a$11$gNw0zfa9ZsM1MhQmbxy3qulNPDke7uhICMJQvobhUzD0I2OJl9Jb6", 0, "user161" },
                    { 162, "user162@example.com", "$2a$11$gYVkr6sYZceywkGD6rR1sOiV9NaOKBhxSGKxkW3ktqd5fxqq8D4Ku", 0, "user162" },
                    { 163, "user163@example.com", "$2a$11$JuBtPwKInGq4CGwVJ/afrO2r70591zXZFxLONhneHcBR9rOV8NLBK", 0, "user163" },
                    { 164, "user164@example.com", "$2a$11$lvhURDp3U85N5l7wuutVkOgtThnUsuZUF4KOcNDzkcuAtzLGxKcHW", 0, "user164" },
                    { 165, "user165@example.com", "$2a$11$JSshcZRziYL0BAlbHUL33.cBN71cNgororjNm7DNJBPYuigqHWwGe", 0, "user165" },
                    { 166, "user166@example.com", "$2a$11$f/JkfGucR1ZmyGemyl/DWeIdqgFpSaFBl1HyFQeyirpWuouoaZ6DG", 0, "user166" },
                    { 167, "user167@example.com", "$2a$11$qOYM9b7fqlPjHt1W76beDuPOAFmg9VA5K3XLSN1U1KLSDrbccsHEi", 0, "user167" },
                    { 168, "user168@example.com", "$2a$11$oVGtnSkNlzFs/lQ2dLa.F.mcFzAeD.pWTnTT8YimiSvRwA4.FewOK", 0, "user168" },
                    { 169, "user169@example.com", "$2a$11$qyHjgINiIyQYV.cLEmBX7OeJQsuFlNEKe1CWHKXnx1/cSzn7KW.Cu", 0, "user169" },
                    { 170, "user170@example.com", "$2a$11$JfNtXOq3ZOWhlIuDF51k0OraERbt5v0WEpvefKWLIsHhpIlKjkI/G", 0, "user170" },
                    { 171, "user171@example.com", "$2a$11$sfgs2VYKz0coSRe00/457eVpeWZEXGK5kQkohuzRXD8ERDLiqMiLK", 0, "user171" },
                    { 172, "user172@example.com", "$2a$11$Lw8jciGReNcH7H2x8vv7Ze1hXJWpqEGOprkxhQmaonsroAPVuNjLG", 0, "user172" },
                    { 173, "user173@example.com", "$2a$11$3UL18Oc0PwuxPXdCmmqME.5HQytYTqiHvFzmsXwcFGjQ0vYMPDa6y", 0, "user173" },
                    { 174, "user174@example.com", "$2a$11$PVwZqIa2NUmwTbiBYUszwu9Z4mZC14jlkG1sN8fPUlZly24dMSEru", 0, "user174" },
                    { 175, "user175@example.com", "$2a$11$UXm4RIG//GMZCQNWt.YADuPNhOQVHNgJX1YqllkYBF32qCbfrQJNi", 0, "user175" },
                    { 176, "user176@example.com", "$2a$11$ObJ8Gkd1c2WvdJgV8mlWv.fLYu.zcmBlNiktPQNZKvhc0JPZ0E3LK", 0, "user176" },
                    { 177, "user177@example.com", "$2a$11$QZYMiCIYj4BHGMTXS7aKCOIdoL.K6sNV7NHrut/Q29HLFRXdSCJXK", 0, "user177" },
                    { 178, "user178@example.com", "$2a$11$0XdOUzdNxXqQ47b0XaPYDOYfmXev6EIV6zl6FI/8naHLXqqBmgi4q", 0, "user178" },
                    { 179, "user179@example.com", "$2a$11$qnSc9/lSvB9fgrsbDyIrke0JTySd.bU7FGNeCUs1nzx.ug1Q2sJBW", 0, "user179" },
                    { 180, "user180@example.com", "$2a$11$YmaKHT1bn57YibnBZpi3Eu7dUZp.dELq3C/h1f915j/2DiKQ.bm6C", 0, "user180" },
                    { 181, "user181@example.com", "$2a$11$ZR6lt5U5rZeRn16zDYIlgOBJ8rutprxUVDiQNIJqWCz4jSpUvM3me", 0, "user181" },
                    { 182, "user182@example.com", "$2a$11$E5Jk14KmVfkU4y8nYrGCX.qHiBqRuReNDNgcqyqE1ecaLZkdNxH02", 0, "user182" },
                    { 183, "user183@example.com", "$2a$11$ngzp7cNzGnNfj0LcOAB2peuaOZj5V.qobyGlEwULeB4k.BCzOZgEq", 0, "user183" },
                    { 184, "user184@example.com", "$2a$11$fT2W73XoVsJQa8UuMOHK5O9xIJoXlb0qf9KxrYGtIonxKlwhtRjIq", 0, "user184" },
                    { 185, "user185@example.com", "$2a$11$T3EykMkCATeOqoDZJfTAau6o7vSoRKRNLsESuhQmdPmDSkAzseZn6", 0, "user185" },
                    { 186, "user186@example.com", "$2a$11$bqBZhwqJLb13HXv7Y/9Xse47mhlachiqCrbaFpGYLWT8nNiveG1kG", 0, "user186" },
                    { 187, "user187@example.com", "$2a$11$dTOUu8ItC2sHfL0tCfPgDuc3G6jNtfk/G9pvh1S9/q8fl7Vp/.V7G", 0, "user187" },
                    { 188, "user188@example.com", "$2a$11$lrqBd.CyAvgRCZFi0O7D.OrmCXbF0xVmVaw8i2WqsUQtOhQAVdBi.", 0, "user188" },
                    { 189, "user189@example.com", "$2a$11$zwXMyiK6gwFwsG5JFMuQrOip5FaonCBALs5YIfGdxJxYFH3/F2WzW", 0, "user189" },
                    { 190, "user190@example.com", "$2a$11$0sgePlzMnfXT.rI0XJxeIueHP2YcsAU8t.SvcWHqXW4mC/ys50fn6", 0, "user190" },
                    { 191, "user191@example.com", "$2a$11$X5C71bTI5nAiEoK11uASy..r2F3DKO1fUwTsm7fBaxpQd8Kq0Gcsi", 0, "user191" },
                    { 192, "user192@example.com", "$2a$11$lKb4LAJH2.5pbXHGMz7J1Oe9DDMXdvrgAPAfIvEDO66/fC/545fKi", 0, "user192" },
                    { 193, "user193@example.com", "$2a$11$szhhCEFOKr8/qa5WV0Wd/.4qcLjyEnds78ZybEGQAuybbOJff2K9.", 0, "user193" },
                    { 194, "user194@example.com", "$2a$11$WegHZmwqrl3vvipr669z4.plT04twhou5Cb4IzsPsSHJ8fHfcEw1K", 0, "user194" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 195, "user195@example.com", "$2a$11$GBF0coyZLpUzL8pZSxR7ne1tC0bbMLvbsnH5yWL8YwnU.Plr1wpzq", 0, "user195" },
                    { 196, "user196@example.com", "$2a$11$7KE3nDRCppTjJ0crJVCPfursKB8ZESu6GFVUv361HMBP7htOLZxvC", 0, "user196" },
                    { 197, "user197@example.com", "$2a$11$oypTiT/wGohm4kKS1INum.ZOnaIK/ntrDiHvbZYUNamGc/.YhM8UG", 0, "user197" },
                    { 198, "user198@example.com", "$2a$11$t18mPXIDWyJYrPfI2DRR2e26.XBlF3JGOIeeAVVyhcVYAPsBUmOQ2", 0, "user198" },
                    { 199, "user199@example.com", "$2a$11$wQOGq5kx62gunGNgu2nS0.rXpdQXFbKcaz9JClKnGSfh/uomqLkD2", 0, "user199" },
                    { 200, "user200@example.com", "$2a$11$nHqeZugeBxvTdtEQAK.L7.E08QKoshYx9CFWYfEOFxDun2fdS/KnC", 0, "user200" },
                    { 201, "user201@example.com", "$2a$11$SFS1DCuih8RrryjyJmKgf.xm/NcoU1KcR5eJTRYqOkbqo.MrrmRPe", 0, "user201" },
                    { 202, "user202@example.com", "$2a$11$QT2kcrYsi4iyja4w/HGCNeJzPgI7R.VRZ29Y28fQH.EtCmsILvRCq", 0, "user202" },
                    { 203, "user203@example.com", "$2a$11$6VLvHE5PWC6iSdH0cmVsRueiQMPrZBuWGJ2M0AbL0c6JKKwp2X6De", 0, "user203" },
                    { 204, "user204@example.com", "$2a$11$zfBt5nS.nCU1iXb80oJAoePKPh8V691erpXP1QqVLMfVCgNSM9XQi", 0, "user204" },
                    { 205, "user205@example.com", "$2a$11$kNjg3n8yrWqfnNqYUI3VH.VJcFa4hM35.nIflOe1zxqUVfvAsMRaO", 0, "user205" },
                    { 206, "user206@example.com", "$2a$11$QirJ3080MoMF0AK3JOl3n.hhNZMhY9SYMSjga/aeERiVqs7wbh5qi", 0, "user206" },
                    { 207, "user207@example.com", "$2a$11$Zy6i4b0Cm2WjOl.6rbEXx.jztwR/6Pdo/MTjwIMrUD0O68s5gFAiC", 0, "user207" },
                    { 208, "user208@example.com", "$2a$11$1qImbSeFblES2yTcm7N3UeX3Q1u3SIM8sDNp/629Na1YDPAF5oca.", 0, "user208" },
                    { 209, "user209@example.com", "$2a$11$U6STsxRG2SlcyQz9gSwC2eE/nM1K.gZVKYjSWHe9TEzUniV1Ox62u", 0, "user209" },
                    { 210, "user210@example.com", "$2a$11$LqCM5JXrzi/8wEbxvS2yBesXiScXqjkIQw7x0Oh37975DgFTOmnbG", 0, "user210" },
                    { 211, "user211@example.com", "$2a$11$YaEP41u0BGVaD.jWcPTWluImHgiFRDZdzHRDe6mnqVT.oDlcylJVe", 0, "user211" },
                    { 212, "user212@example.com", "$2a$11$4JjmVcF7Vz4Wa58DX6EE3e58hxLG4GyfDF5x4qADv.3Js3X5zBcOC", 0, "user212" },
                    { 213, "user213@example.com", "$2a$11$2O1ZVrtvkvlTu0UOdpUPB.N2Y/0OTsF5VxO4AKJp1pEYbdTne5OlS", 0, "user213" },
                    { 214, "user214@example.com", "$2a$11$zuc7U.UUp2f/AcHM.9vy1uhd.znsz2eIRmaPiiO1u1LnAflg/dasG", 0, "user214" },
                    { 215, "user215@example.com", "$2a$11$lRuWZVb8aFPLWFh5HhV1lut91pWtj3huqrJDP0Li3d4ZjpJOhTdAS", 0, "user215" },
                    { 216, "user216@example.com", "$2a$11$9EYeT8ZioCTnsbjNOiqUNO0KMBik3IQ5ZIAVCPl0j3u/eet18.t.m", 0, "user216" },
                    { 217, "user217@example.com", "$2a$11$oOoxpBGOlQbWcj/ZqiTNfe9YtxbqkJN4WdMiFUlgvQzemGlCnczy6", 0, "user217" },
                    { 218, "user218@example.com", "$2a$11$03WL.JOmr604YZXBjz6Lhuo35ioL5Wf53OivffbTT3Z1vMvoE91TC", 0, "user218" },
                    { 219, "user219@example.com", "$2a$11$tssb25I8BQK0h.6adTUaUOeK6yV0DEwHlZpQVRRQ4mfhIpqnYQY86", 0, "user219" },
                    { 220, "user220@example.com", "$2a$11$CvyUowTHdU2JXQcRbk9/y.4yL4.qGsppGomwvXXoQMIF5MsbUDyjy", 0, "user220" },
                    { 221, "user221@example.com", "$2a$11$.pHNBsoa6bTYwt0yQb1pLOAOrU5E2HvlHgo5IHJvdFdwos8Q3cLEq", 0, "user221" },
                    { 222, "user222@example.com", "$2a$11$pyQxtKnl3/SkxNbceb8C2OWIFJ.JDvVwA3A/Dtb.Yw0TcRWYHIARm", 0, "user222" },
                    { 223, "user223@example.com", "$2a$11$RQsWVjgsKTiLSEhgUbMkKuzgAtK9dm8guHgGOx3tnxoXUKQNFvy2m", 0, "user223" },
                    { 224, "user224@example.com", "$2a$11$vq3VbX34b/GIlLfGtfEEvuQBNbx7XU0xXONwFKnyh5jjv20qEWbBm", 0, "user224" },
                    { 225, "user225@example.com", "$2a$11$0/Q1jcNPpWWzNEZoI10Dl.tY1P90ZLHz.bqw.vuN5oaw2cTk7QFuO", 0, "user225" },
                    { 226, "user226@example.com", "$2a$11$4P6N/.088nMYcjyDlFWNguWYPz92TW4G7kGUI..HlLPIxK6RzYYgi", 0, "user226" },
                    { 227, "user227@example.com", "$2a$11$.oU.egMdD5RaHi2D9fYJY.jZvh10yZ59b88mC4WMga1C1uh/JCQeO", 0, "user227" },
                    { 228, "user228@example.com", "$2a$11$GAFE1XL4q.TrOd7HX2ghnOCH7gX7azB2Njzeit9ha8x/k0wWbNRQe", 0, "user228" },
                    { 229, "user229@example.com", "$2a$11$PfJ.dQ.THLupGgnMnGm7veIAinCYPc4C/XuIF50oRxawq/64trdii", 0, "user229" },
                    { 230, "user230@example.com", "$2a$11$GGKAAhDpTO2sDKYZWPEoPemUvF0kTaNoobOOKnYjRCTFU/qFWnn1G", 0, "user230" },
                    { 231, "user231@example.com", "$2a$11$ei/EESLVf6CuvrfeR12s5.yH1PvE3qkFzmp0M2Wn9vVrSGj579.wq", 0, "user231" },
                    { 232, "user232@example.com", "$2a$11$DMvr7dQzfVoJGitFkuVFNe5mPznA5Ra04053VhR4HfeHgia/SttL2", 0, "user232" },
                    { 233, "user233@example.com", "$2a$11$YSW4.9hE5KZ8QwwZ/5KiO.yGg4Hs3z8rYemO8RkVCL1FEKJ7oWdnC", 0, "user233" },
                    { 234, "user234@example.com", "$2a$11$SU5aBC/rYQt1f2s9V5DD4OBEAcrnHKTNbyW0eFx8zQTnZSmO8m4t2", 0, "user234" },
                    { 235, "user235@example.com", "$2a$11$rwfVDfHOaY3oT6hhqxBAtel8VtCupZwEqXfscnqTZtvmumXywjHQy", 0, "user235" },
                    { 236, "user236@example.com", "$2a$11$2yyA6XDeuprIlflFiYMkAeAFYXN9MF0bQGJkIVvzaStTyJsmbSyLu", 0, "user236" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 237, "user237@example.com", "$2a$11$e6i5oBe06uQbNaaEIJSJwuPs83Gi0OKah/EBlReC2JQ5jyuJ9Ii0C", 0, "user237" },
                    { 238, "user238@example.com", "$2a$11$yDim3GJVubJfodgZDbrhRewWU4DHhweVT1nZj3qeWpyuceIML73kC", 0, "user238" },
                    { 239, "user239@example.com", "$2a$11$rnn3cWQ91YGO1x8hnY78.On74kmDSCQWeFSRbSbChJlsyp95melkS", 0, "user239" },
                    { 240, "user240@example.com", "$2a$11$gQNqAeyRhKnXfucxeB3wHOyuT8DuvjmRIRdxn8i9f7SzJFkoamH/K", 0, "user240" },
                    { 241, "user241@example.com", "$2a$11$GbKcbf4JRPY9RlXe21ssW.G1mcw.1PlTcbSGasFC8ZSpg5w6pcW9q", 0, "user241" },
                    { 242, "user242@example.com", "$2a$11$bfLRRCTiRBQ1aq24w.FIp.apIFEl5wkdp4ZNI3/B2qAw8x4rqB4ZS", 0, "user242" },
                    { 243, "user243@example.com", "$2a$11$S/b6LRHD/SBZ5zD1g.lGUu69Hfm.sUg57DkDBTuprDACUW4sYu5.C", 0, "user243" },
                    { 244, "user244@example.com", "$2a$11$kZiV5AHIimzERfKJ/AN9U.IaFT73/GOul.l1JLQ67FtZsrMe6I.Oy", 0, "user244" },
                    { 245, "user245@example.com", "$2a$11$YN88FXcKchTsecOnFbMYOeP3/2ERU2o9CdZPxnTyhNl/US.5gW8/e", 0, "user245" },
                    { 246, "user246@example.com", "$2a$11$UIM/VGixcXSygSe0aS81OeGuRI02uOfqMMm5Lw0tWIw6P6pxiP09W", 0, "user246" },
                    { 247, "user247@example.com", "$2a$11$PitocIr5F.dWDqwGH2nm8uFI3/aXh2QKoUxOcK2JpzjljKvefk8eW", 0, "user247" },
                    { 248, "user248@example.com", "$2a$11$qiV5mQNiaY7JYfaGL1zQdOQKVNvWXle3ee.gi8eDO54am7UMkRYoy", 0, "user248" },
                    { 249, "user249@example.com", "$2a$11$JYNNlIkMdLKM.CU3puAa2ODiepOH3f19TO3ohHU9YRMB2mrp8gex6", 0, "user249" },
                    { 250, "user250@example.com", "$2a$11$IJBjXiE/eonC.BP7bhyXNetR95XMGxc4MXqFcjbtDfNGfc8XNzrfe", 0, "user250" },
                    { 251, "user251@example.com", "$2a$11$tWvoQ8bFRAcfcFSyqxPic.9mJTxQVR6vYcGHHX6S6C0Qu0yItikIC", 0, "user251" },
                    { 252, "user252@example.com", "$2a$11$QJl5YmME.wQ0c2rlB/1Q/OCarIOXBBblCqKjthcdcZDMYI/09Mxie", 0, "user252" },
                    { 253, "user253@example.com", "$2a$11$fRcS5jodGCdEkIDwoKb02OOPX/UkR3Wh70mWqHWq7eOW2fPOpV6f6", 0, "user253" },
                    { 254, "user254@example.com", "$2a$11$zJswte9HPGbO3lDzqu2qP.ApPgaI3wg6RgROz9GmhQZMmpiwTrBM6", 0, "user254" },
                    { 255, "user255@example.com", "$2a$11$62ii5namc0ksoBewsQbjhuPfdWtsZlsbPlNcJ4pN1Wjoexy1d8yhq", 0, "user255" },
                    { 256, "user256@example.com", "$2a$11$7ciaAOV50Ni0o41wsbhPdOMNKULxTYu2AflS0FB3c7Dx1JFNk.RoK", 0, "user256" },
                    { 257, "user257@example.com", "$2a$11$zDQqaiOczwS/2xrSPBurm.ZRSkDh0B27rU579.93PMEJP03xWGCFu", 0, "user257" },
                    { 258, "user258@example.com", "$2a$11$lPclL9gzeqCOOzIoxRVHjuKENwd2Wu5DF/lfPYIKUAsf.EYImalNa", 0, "user258" },
                    { 259, "user259@example.com", "$2a$11$wrTQPIvDJ8Md5dM5fD6dJuSiJ2oV667a90cJs1tyilGmzPNGTU/Ti", 0, "user259" },
                    { 260, "user260@example.com", "$2a$11$PjD8ItLivt6wsKd/muMxJeIzAge9Hbax3OQHxWz8b9O0bTo46pnJe", 0, "user260" },
                    { 261, "user261@example.com", "$2a$11$Q395QmEqOXTbufpOn38cquxnljpVVhfFKt/uBmv4KR1OmVdd/DHVi", 0, "user261" },
                    { 262, "user262@example.com", "$2a$11$yw10nV8vFFBieSAOgkWKmu7F62I1eOh9hCYiXjWZB75kGeteGAXUu", 0, "user262" },
                    { 263, "user263@example.com", "$2a$11$EDwcSdqXb8RXvJl7w9WBh.rnYdVAbqDciPbevgpI5xf04b.3BBvsO", 0, "user263" },
                    { 264, "user264@example.com", "$2a$11$LCNWDQN9mheoDwvqkxYZrOnx29wAJCWK3/L9EGSOe6PE4hCvkKeQu", 0, "user264" },
                    { 265, "user265@example.com", "$2a$11$nzK/ZjuYcXwm8Ywe82zl7uFQA1je2GkIP89VVATGJoCEJq9UVosjK", 0, "user265" },
                    { 266, "user266@example.com", "$2a$11$98b0uo8y5xXQdKElgLy/3eqDYMgsL7QePV5PEmyhaKAgly3v8eyki", 0, "user266" },
                    { 267, "user267@example.com", "$2a$11$wSgZH0GSxphg3cG/sSfj5.MjV/0RUOdO6Pkko02IqyGaRsVDFN7Za", 0, "user267" },
                    { 268, "user268@example.com", "$2a$11$m.MHSdsrR3oU6g9gpq5x1engtlX7eCDKWdc6xT4bXXmzsRFm0JKvS", 0, "user268" },
                    { 269, "user269@example.com", "$2a$11$QvBJ5PtTO1.Wo0d5hpXDNezyglsYIGznEXonN9FtgkjrEzi.TGT8y", 0, "user269" },
                    { 270, "user270@example.com", "$2a$11$uMFScqcTxeccgCsJKS4qFur99Hcs20uSKY4vbllXas9FcEezwJIRi", 0, "user270" },
                    { 271, "user271@example.com", "$2a$11$RZh4JMj5YUxdl5mBL9WC6.rAgvaGC1RS3GGcg6Z5OzQmbpJ0KGHBG", 0, "user271" },
                    { 272, "user272@example.com", "$2a$11$1h6QzGF4kZvSPn4vSl7nkuuk.oOKBLCjmG/rL6fuK6zGsYSoAHBEa", 0, "user272" },
                    { 273, "user273@example.com", "$2a$11$99nZvdp.MkhWdoUGSuwe.ed9uec3HrB1CdwaXu6MOwBtNvc4QPhOu", 0, "user273" },
                    { 274, "user274@example.com", "$2a$11$udczl2ea0lyJ1qU2Ht9UhumwG1fDS9x9g862Bu7GzqWwAV55lRTfO", 0, "user274" },
                    { 275, "user275@example.com", "$2a$11$lK/u5PKrJBsnZN5LioIYAuqtYkXzJeT/endK8EcRIR./khKkbOhzK", 0, "user275" },
                    { 276, "user276@example.com", "$2a$11$GwxZhfFuarYpJZHrO8hT4.BDmsGdhzRIBJV8m9icUpaBoY0fnqJ/O", 0, "user276" },
                    { 277, "user277@example.com", "$2a$11$bZkCA51SMZhKNnz7ZpX4VeQeB348e3DxVBBGzYCJ3hHAh42gFrI7e", 0, "user277" },
                    { 278, "user278@example.com", "$2a$11$gu0uOV4SvKGDz414uc1cRunWdpILfa0G3W1MpFCebw8WMDawBtMmm", 0, "user278" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 279, "user279@example.com", "$2a$11$n1rQgvjdsWxrEFHFWfACEuqwY0v87MU0e8JdEpJlON.9rwQmj3jWG", 0, "user279" },
                    { 280, "user280@example.com", "$2a$11$X1FU2/kt2HP2SOpuek9RN.SccXPIeSFcFwHvdI67Do12roLMIG90K", 0, "user280" },
                    { 281, "user281@example.com", "$2a$11$eVJKbCYpGGP6Vl6YNRnHz./6qhenTxUf6hCTnPIZaRJTdRwei/Jza", 0, "user281" },
                    { 282, "user282@example.com", "$2a$11$o9vgjqcODRrphw1BeSAsY.B9oHDscnOIRfZTHmAp2qNoPuHzXduXe", 0, "user282" },
                    { 283, "user283@example.com", "$2a$11$/Q101PRPkCgyJBn6VQ.mQ.Etu1F56k1touiIB4BPKGp0jOh1XjbjK", 0, "user283" },
                    { 284, "user284@example.com", "$2a$11$CPcit0qmyNxEWvqvEhhfVeyjkGGmJLqFA/GAAbkYrT1uCJNER/HW2", 0, "user284" },
                    { 285, "user285@example.com", "$2a$11$Y3UY3vVYFyera75LwhI/cebEuILe2980bxtdesOr5cqAo3xENn/vm", 0, "user285" },
                    { 286, "user286@example.com", "$2a$11$ahlYtzJHUxwSRSx/Z1QkLuX5CLLj57QLsQzjrbIoCN5CR3NZYA6Ii", 0, "user286" },
                    { 287, "user287@example.com", "$2a$11$W5z8EsO4/G2TaG0/t6Pd1uwRTBy/.2S.vmxylUug2SORe8XEDL1Q6", 0, "user287" },
                    { 288, "user288@example.com", "$2a$11$RLeScsUq6oKv0ACg63e0Hepvu/fR7/S3XlLB0Xq440PNQzgBbD0I2", 0, "user288" },
                    { 289, "user289@example.com", "$2a$11$F0tawogDpE3i0WRszp8PUu.bqZc9OfRvovhYZSKCT0Z9MTgjF70i.", 0, "user289" },
                    { 290, "user290@example.com", "$2a$11$2/fep5mCrzsnlznACDp94O1LnHrPinyZKWknqP7ujEPcOsgGkprwm", 0, "user290" },
                    { 291, "user291@example.com", "$2a$11$7CTK1pFpswl/tWyVb/6XyObipLTPJqfyAJEZ6AQ8aVfS0ERNtG/ES", 0, "user291" },
                    { 292, "user292@example.com", "$2a$11$c43Z7OIAscEy55dsbzY/Re3f/IFLSQkqpyT1QpSSzdbkbuigAUeK2", 0, "user292" },
                    { 293, "user293@example.com", "$2a$11$9vJcBM6BwOM9AjfSl08xrOYvbBbCbKNxrWk2vTlYHuPVYModsEmpq", 0, "user293" },
                    { 294, "user294@example.com", "$2a$11$0Ca7KY6druGbexF/Heys.e9F5QKrKZwj47AXWU1yLJXGdWiOfcJVG", 0, "user294" },
                    { 295, "user295@example.com", "$2a$11$4HSumG1u5nMGaouFYDoTrOv3hzCBjFAT/3BMoQdG6iUq19JnhOkaS", 0, "user295" },
                    { 296, "user296@example.com", "$2a$11$/yweUWPQElB.c6w6vLXxjeddxNnSkQFsSCqeMIgYNBE98Es.TkuZu", 0, "user296" },
                    { 297, "user297@example.com", "$2a$11$5E5BImz.N8HE6RMFAGO8mOcbLRn/OdxJUkb7aeZc1iYdnu2AuNyjq", 0, "user297" },
                    { 298, "user298@example.com", "$2a$11$hpHe.jIB00np1L8KvC2yI.gKkbYaEP9sES/Mvy3Xa1nJsuHj/L.zS", 0, "user298" },
                    { 299, "user299@example.com", "$2a$11$4S.TCXwV1iwrR.05mQJ2de84M7.V4BkA7.hZTv7.f4Re2P1qEduhq", 0, "user299" },
                    { 300, "user300@example.com", "$2a$11$8NR9JbWUURrY/E5CWGUEL.lCmufnU6DISVnUAGGgvzcnGCIcbO3P2", 0, "user300" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "CityId", "CreationDate", "Description", "DiscountRate", "LocationId", "ModificationDate", "Name", "Owner", "Price", "StarRating", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 12, 13, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9050), "Description for Hotel1", 0.26607703703040675, 1, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9106), "Hotel1", "Owner1", 207.62662892835166, 4, "http://example.com/hotel1.jpg" },
                    { 2, 10, new DateTime(2024, 1, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9119), "Description for Hotel2", 0.31104552488511694, 2, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9121), "Hotel2", "Owner2", 419.89926066259238, 1, "http://example.com/hotel2.jpg" },
                    { 3, 8, new DateTime(2023, 12, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9125), "Description for Hotel3", 0.34375592893847184, 3, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9127), "Hotel3", "Owner3", 160.78603247741685, 3, "http://example.com/hotel3.jpg" },
                    { 4, 4, new DateTime(2024, 2, 17, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9137), "Description for Hotel4", 0.81300788740028163, 4, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9138), "Hotel4", "Owner4", 246.3995317731007, 4, "http://example.com/hotel4.jpg" },
                    { 5, 2, new DateTime(2024, 2, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9156), "Description for Hotel5", 0.53542674031254922, 5, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9158), "Hotel5", "Owner5", 418.15359739165871, 5, "http://example.com/hotel5.jpg" },
                    { 6, 5, new DateTime(2024, 1, 9, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9167), "Description for Hotel6", 0.1269895251785832, 6, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9169), "Hotel6", "Owner6", 347.84512797119652, 4, "http://example.com/hotel6.jpg" },
                    { 7, 2, new DateTime(2024, 3, 1, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9181), "Description for Hotel7", 0.36443835264551272, 7, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9182), "Hotel7", "Owner7", 284.18018656580489, 5, "http://example.com/hotel7.jpg" },
                    { 8, 1, new DateTime(2024, 1, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9187), "Description for Hotel8", 0.61649908133488274, 8, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9199), "Hotel8", "Owner8", 53.571169054523473, 3, "http://example.com/hotel8.jpg" },
                    { 9, 6, new DateTime(2023, 11, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9203), "Description for Hotel9", 0.37903679643108878, 9, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9204), "Hotel9", "Owner9", 63.014785329155941, 2, "http://example.com/hotel9.jpg" },
                    { 10, 4, new DateTime(2024, 1, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9210), "Description for Hotel10", 0.014799077548337647, 10, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9212), "Hotel10", "Owner10", 251.26473078253065, 3, "http://example.com/hotel10.jpg" },
                    { 11, 10, new DateTime(2024, 1, 2, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9216), "Description for Hotel11", 0.068749572399941949, 11, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9218), "Hotel11", "Owner11", 83.547330918057156, 5, "http://example.com/hotel11.jpg" },
                    { 12, 6, new DateTime(2024, 2, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9222), "Description for Hotel12", 0.0040684021320935848, 12, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9224), "Hotel12", "Owner12", 458.58049003731105, 4, "http://example.com/hotel12.jpg" },
                    { 13, 7, new DateTime(2023, 12, 12, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9228), "Description for Hotel13", 0.61698067479168039, 13, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9230), "Hotel13", "Owner13", 488.99166711151679, 4, "http://example.com/hotel13.jpg" },
                    { 14, 5, new DateTime(2024, 2, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9234), "Description for Hotel14", 0.70775628727454021, 14, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9236), "Hotel14", "Owner14", 182.1924570334954, 5, "http://example.com/hotel14.jpg" },
                    { 15, 5, new DateTime(2024, 1, 19, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9240), "Description for Hotel15", 0.98676087201457663, 15, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9247), "Hotel15", "Owner15", 457.55252201662159, 4, "http://example.com/hotel15.jpg" },
                    { 16, 2, new DateTime(2024, 2, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9287), "Description for Hotel16", 0.96034293278532201, 16, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9288), "Hotel16", "Owner16", 297.52947190853649, 1, "http://example.com/hotel16.jpg" },
                    { 17, 2, new DateTime(2024, 1, 9, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9293), "Description for Hotel17", 0.31462598875022496, 17, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9294), "Hotel17", "Owner17", 291.98308593824203, 3, "http://example.com/hotel17.jpg" },
                    { 18, 2, new DateTime(2024, 1, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9299), "Description for Hotel18", 0.16304992015180286, 18, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9301), "Hotel18", "Owner18", 82.410094102683516, 3, "http://example.com/hotel18.jpg" },
                    { 19, 8, new DateTime(2024, 1, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9305), "Description for Hotel19", 0.50047726173240337, 19, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9307), "Hotel19", "Owner19", 27.365656017701966, 4, "http://example.com/hotel19.jpg" },
                    { 20, 10, new DateTime(2024, 1, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9311), "Description for Hotel20", 0.66864781713809085, 20, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9312), "Hotel20", "Owner20", 324.23933613374044, 4, "http://example.com/hotel20.jpg" },
                    { 21, 8, new DateTime(2023, 12, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9317), "Description for Hotel21", 0.93535868045704773, 21, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9318), "Hotel21", "Owner21", 143.82076359881617, 1, "http://example.com/hotel21.jpg" },
                    { 22, 4, new DateTime(2024, 1, 4, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9328), "Description for Hotel22", 0.89434298025659309, 22, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9330), "Hotel22", "Owner22", 130.47043415689913, 3, "http://example.com/hotel22.jpg" },
                    { 23, 3, new DateTime(2023, 12, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9334), "Description for Hotel23", 0.27812415698039905, 23, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9335), "Hotel23", "Owner23", 163.37808989501491, 5, "http://example.com/hotel23.jpg" },
                    { 24, 7, new DateTime(2024, 1, 21, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9339), "Description for Hotel24", 0.95712812341751341, 24, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9341), "Hotel24", "Owner24", 419.77050925882418, 1, "http://example.com/hotel24.jpg" },
                    { 25, 7, new DateTime(2024, 1, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9345), "Description for Hotel25", 0.071540492504341358, 25, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9346), "Hotel25", "Owner25", 334.61520626962675, 1, "http://example.com/hotel25.jpg" },
                    { 26, 2, new DateTime(2024, 2, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9351), "Description for Hotel26", 0.48295718420337252, 26, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9352), "Hotel26", "Owner26", 375.7098860001596, 3, "http://example.com/hotel26.jpg" },
                    { 27, 2, new DateTime(2023, 12, 15, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9356), "Description for Hotel27", 0.81983172667731219, 27, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9358), "Hotel27", "Owner27", 166.69148800383732, 5, "http://example.com/hotel27.jpg" },
                    { 28, 1, new DateTime(2023, 12, 4, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9362), "Description for Hotel28", 0.12011449427748488, 28, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9363), "Hotel28", "Owner28", 144.49140093531764, 5, "http://example.com/hotel28.jpg" },
                    { 29, 9, new DateTime(2024, 1, 17, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9368), "Description for Hotel29", 0.056684722791614628, 29, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9369), "Hotel29", "Owner29", 434.40684687391825, 5, "http://example.com/hotel29.jpg" },
                    { 30, 4, new DateTime(2023, 11, 26, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9373), "Description for Hotel30", 0.62913536724868158, 30, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9380), "Hotel30", "Owner30", 206.32641326471185, 3, "http://example.com/hotel30.jpg" },
                    { 31, 5, new DateTime(2024, 1, 14, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9385), "Description for Hotel31", 0.7544351129247846, 31, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9387), "Hotel31", "Owner31", 267.86929687869247, 2, "http://example.com/hotel31.jpg" },
                    { 32, 9, new DateTime(2023, 12, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9391), "Description for Hotel32", 0.34782127536085106, 32, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9393), "Hotel32", "Owner32", 423.04577880643649, 2, "http://example.com/hotel32.jpg" },
                    { 33, 5, new DateTime(2023, 12, 23, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9397), "Description for Hotel33", 0.33029485938421432, 33, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9398), "Hotel33", "Owner33", 206.32910273291915, 2, "http://example.com/hotel33.jpg" },
                    { 34, 1, new DateTime(2023, 12, 30, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9403), "Description for Hotel34", 0.62818545164068962, 34, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9405), "Hotel34", "Owner34", 317.00601811301931, 5, "http://example.com/hotel34.jpg" },
                    { 35, 9, new DateTime(2023, 11, 28, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9409), "Description for Hotel35", 0.99119696581329797, 35, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9411), "Hotel35", "Owner35", 496.92017591467521, 1, "http://example.com/hotel35.jpg" },
                    { 36, 9, new DateTime(2024, 1, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9415), "Description for Hotel36", 0.25714609027592972, 36, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9417), "Hotel36", "Owner36", 377.42328210700475, 2, "http://example.com/hotel36.jpg" },
                    { 37, 4, new DateTime(2024, 2, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9421), "Description for Hotel37", 0.058177838476916044, 37, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9423), "Hotel37", "Owner37", 172.76051916923291, 4, "http://example.com/hotel37.jpg" },
                    { 38, 3, new DateTime(2024, 1, 16, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9427), "Description for Hotel38", 0.45139379777436106, 38, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9429), "Hotel38", "Owner38", 299.12994389281249, 1, "http://example.com/hotel38.jpg" },
                    { 39, 8, new DateTime(2023, 12, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9433), "Description for Hotel39", 0.65855247917477189, 39, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9434), "Hotel39", "Owner39", 387.43166825383332, 4, "http://example.com/hotel39.jpg" },
                    { 40, 3, new DateTime(2023, 11, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9438), "Description for Hotel40", 0.95836666671121573, 40, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9440), "Hotel40", "Owner40", 307.1046870106544, 1, "http://example.com/hotel40.jpg" },
                    { 41, 9, new DateTime(2023, 11, 25, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9444), "Description for Hotel41", 0.83957864276462091, 41, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9445), "Hotel41", "Owner41", 403.24621625019472, 5, "http://example.com/hotel41.jpg" },
                    { 42, 8, new DateTime(2024, 1, 8, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9453), "Description for Hotel42", 0.26666158009501773, 42, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9455), "Hotel42", "Owner42", 213.9155727936361, 1, "http://example.com/hotel42.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "CityId", "CreationDate", "Description", "DiscountRate", "LocationId", "ModificationDate", "Name", "Owner", "Price", "StarRating", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 43, 9, new DateTime(2024, 2, 7, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9459), "Description for Hotel43", 0.33487938440345655, 43, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9461), "Hotel43", "Owner43", 82.587825475299198, 3, "http://example.com/hotel43.jpg" },
                    { 44, 4, new DateTime(2023, 12, 24, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9465), "Description for Hotel44", 0.3012979657415964, 44, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9467), "Hotel44", "Owner44", 228.45926642693547, 3, "http://example.com/hotel44.jpg" },
                    { 45, 10, new DateTime(2023, 12, 29, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9471), "Description for Hotel45", 0.48192930590233496, 45, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9473), "Hotel45", "Owner45", 483.67146008983423, 1, "http://example.com/hotel45.jpg" },
                    { 46, 5, new DateTime(2024, 2, 5, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9477), "Description for Hotel46", 0.6082468248398234, 46, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9478), "Hotel46", "Owner46", 92.62996335183071, 4, "http://example.com/hotel46.jpg" },
                    { 47, 4, new DateTime(2023, 12, 2, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9483), "Description for Hotel47", 0.16145323270673562, 47, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9484), "Hotel47", "Owner47", 452.15316611299949, 3, "http://example.com/hotel47.jpg" },
                    { 48, 6, new DateTime(2024, 1, 28, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9488), "Description for Hotel48", 0.33158335675268658, 48, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9490), "Hotel48", "Owner48", 215.48774378435155, 3, "http://example.com/hotel48.jpg" },
                    { 49, 1, new DateTime(2023, 11, 27, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9494), "Description for Hotel49", 0.57105885958489933, 49, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9496), "Hotel49", "Owner49", 54.898867069570869, 4, "http://example.com/hotel49.jpg" },
                    { 50, 4, new DateTime(2023, 12, 10, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9500), "Description for Hotel50", 0.074460205571621918, 50, new DateTime(2024, 3, 3, 14, 13, 24, 547, DateTimeKind.Local).AddTicks(9502), "Hotel50", "Owner50", 123.44581081397077, 1, "http://example.com/hotel50.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "http://example.com/hotel1_image1.jpg" },
                    { 2, 1, "http://example.com/hotel1_image2.jpg" },
                    { 3, 2, "http://example.com/hotel2_image1.jpg" },
                    { 4, 2, "http://example.com/hotel2_image2.jpg" },
                    { 5, 2, "http://example.com/hotel2_image3.jpg" },
                    { 6, 2, "http://example.com/hotel2_image4.jpg" },
                    { 7, 3, "http://example.com/hotel3_image1.jpg" },
                    { 8, 3, "http://example.com/hotel3_image2.jpg" },
                    { 9, 3, "http://example.com/hotel3_image3.jpg" },
                    { 10, 3, "http://example.com/hotel3_image4.jpg" },
                    { 11, 4, "http://example.com/hotel4_image1.jpg" },
                    { 12, 4, "http://example.com/hotel4_image2.jpg" },
                    { 13, 4, "http://example.com/hotel4_image3.jpg" },
                    { 14, 4, "http://example.com/hotel4_image4.jpg" },
                    { 15, 5, "http://example.com/hotel5_image1.jpg" },
                    { 16, 5, "http://example.com/hotel5_image2.jpg" },
                    { 17, 5, "http://example.com/hotel5_image3.jpg" },
                    { 18, 5, "http://example.com/hotel5_image4.jpg" },
                    { 19, 5, "http://example.com/hotel5_image5.jpg" },
                    { 20, 6, "http://example.com/hotel6_image1.jpg" },
                    { 21, 6, "http://example.com/hotel6_image2.jpg" },
                    { 22, 6, "http://example.com/hotel6_image3.jpg" },
                    { 23, 6, "http://example.com/hotel6_image4.jpg" },
                    { 24, 7, "http://example.com/hotel7_image1.jpg" },
                    { 25, 7, "http://example.com/hotel7_image2.jpg" },
                    { 26, 7, "http://example.com/hotel7_image3.jpg" },
                    { 27, 7, "http://example.com/hotel7_image4.jpg" },
                    { 28, 8, "http://example.com/hotel8_image1.jpg" },
                    { 29, 8, "http://example.com/hotel8_image2.jpg" },
                    { 30, 8, "http://example.com/hotel8_image3.jpg" },
                    { 31, 8, "http://example.com/hotel8_image4.jpg" },
                    { 32, 8, "http://example.com/hotel8_image5.jpg" },
                    { 33, 9, "http://example.com/hotel9_image1.jpg" },
                    { 34, 9, "http://example.com/hotel9_image2.jpg" },
                    { 35, 9, "http://example.com/hotel9_image3.jpg" },
                    { 36, 9, "http://example.com/hotel9_image4.jpg" },
                    { 37, 9, "http://example.com/hotel9_image5.jpg" },
                    { 38, 10, "http://example.com/hotel10_image1.jpg" },
                    { 39, 10, "http://example.com/hotel10_image2.jpg" },
                    { 40, 10, "http://example.com/hotel10_image3.jpg" },
                    { 41, 11, "http://example.com/hotel11_image1.jpg" },
                    { 42, 11, "http://example.com/hotel11_image2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 43, 12, "http://example.com/hotel12_image1.jpg" },
                    { 44, 13, "http://example.com/hotel13_image1.jpg" },
                    { 45, 14, "http://example.com/hotel14_image1.jpg" },
                    { 46, 14, "http://example.com/hotel14_image2.jpg" },
                    { 47, 15, "http://example.com/hotel15_image1.jpg" },
                    { 48, 16, "http://example.com/hotel16_image1.jpg" },
                    { 49, 16, "http://example.com/hotel16_image2.jpg" },
                    { 50, 16, "http://example.com/hotel16_image3.jpg" },
                    { 51, 17, "http://example.com/hotel17_image1.jpg" },
                    { 52, 17, "http://example.com/hotel17_image2.jpg" },
                    { 53, 18, "http://example.com/hotel18_image1.jpg" },
                    { 54, 18, "http://example.com/hotel18_image2.jpg" },
                    { 55, 19, "http://example.com/hotel19_image1.jpg" },
                    { 56, 19, "http://example.com/hotel19_image2.jpg" },
                    { 57, 19, "http://example.com/hotel19_image3.jpg" },
                    { 58, 19, "http://example.com/hotel19_image4.jpg" },
                    { 59, 20, "http://example.com/hotel20_image1.jpg" },
                    { 60, 20, "http://example.com/hotel20_image2.jpg" },
                    { 61, 20, "http://example.com/hotel20_image3.jpg" },
                    { 62, 21, "http://example.com/hotel21_image1.jpg" },
                    { 63, 21, "http://example.com/hotel21_image2.jpg" },
                    { 64, 21, "http://example.com/hotel21_image3.jpg" },
                    { 65, 21, "http://example.com/hotel21_image4.jpg" },
                    { 66, 21, "http://example.com/hotel21_image5.jpg" },
                    { 67, 22, "http://example.com/hotel22_image1.jpg" },
                    { 68, 23, "http://example.com/hotel23_image1.jpg" },
                    { 69, 24, "http://example.com/hotel24_image1.jpg" },
                    { 70, 25, "http://example.com/hotel25_image1.jpg" },
                    { 71, 25, "http://example.com/hotel25_image2.jpg" },
                    { 72, 25, "http://example.com/hotel25_image3.jpg" },
                    { 73, 25, "http://example.com/hotel25_image4.jpg" },
                    { 74, 25, "http://example.com/hotel25_image5.jpg" },
                    { 75, 26, "http://example.com/hotel26_image1.jpg" },
                    { 76, 26, "http://example.com/hotel26_image2.jpg" },
                    { 77, 27, "http://example.com/hotel27_image1.jpg" },
                    { 78, 27, "http://example.com/hotel27_image2.jpg" },
                    { 79, 27, "http://example.com/hotel27_image3.jpg" },
                    { 80, 27, "http://example.com/hotel27_image4.jpg" },
                    { 81, 27, "http://example.com/hotel27_image5.jpg" },
                    { 82, 28, "http://example.com/hotel28_image1.jpg" },
                    { 83, 28, "http://example.com/hotel28_image2.jpg" },
                    { 84, 28, "http://example.com/hotel28_image3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 85, 29, "http://example.com/hotel29_image1.jpg" },
                    { 86, 29, "http://example.com/hotel29_image2.jpg" },
                    { 87, 29, "http://example.com/hotel29_image3.jpg" },
                    { 88, 30, "http://example.com/hotel30_image1.jpg" },
                    { 89, 30, "http://example.com/hotel30_image2.jpg" },
                    { 90, 30, "http://example.com/hotel30_image3.jpg" },
                    { 91, 30, "http://example.com/hotel30_image4.jpg" },
                    { 92, 30, "http://example.com/hotel30_image5.jpg" },
                    { 93, 31, "http://example.com/hotel31_image1.jpg" },
                    { 94, 31, "http://example.com/hotel31_image2.jpg" },
                    { 95, 32, "http://example.com/hotel32_image1.jpg" },
                    { 96, 32, "http://example.com/hotel32_image2.jpg" },
                    { 97, 32, "http://example.com/hotel32_image3.jpg" },
                    { 98, 32, "http://example.com/hotel32_image4.jpg" },
                    { 99, 32, "http://example.com/hotel32_image5.jpg" },
                    { 100, 33, "http://example.com/hotel33_image1.jpg" },
                    { 101, 33, "http://example.com/hotel33_image2.jpg" },
                    { 102, 33, "http://example.com/hotel33_image3.jpg" },
                    { 103, 34, "http://example.com/hotel34_image1.jpg" },
                    { 104, 34, "http://example.com/hotel34_image2.jpg" },
                    { 105, 35, "http://example.com/hotel35_image1.jpg" },
                    { 106, 35, "http://example.com/hotel35_image2.jpg" },
                    { 107, 35, "http://example.com/hotel35_image3.jpg" },
                    { 108, 36, "http://example.com/hotel36_image1.jpg" },
                    { 109, 36, "http://example.com/hotel36_image2.jpg" },
                    { 110, 36, "http://example.com/hotel36_image3.jpg" },
                    { 111, 37, "http://example.com/hotel37_image1.jpg" },
                    { 112, 37, "http://example.com/hotel37_image2.jpg" },
                    { 113, 37, "http://example.com/hotel37_image3.jpg" },
                    { 114, 38, "http://example.com/hotel38_image1.jpg" },
                    { 115, 38, "http://example.com/hotel38_image2.jpg" },
                    { 116, 38, "http://example.com/hotel38_image3.jpg" },
                    { 117, 39, "http://example.com/hotel39_image1.jpg" },
                    { 118, 39, "http://example.com/hotel39_image2.jpg" },
                    { 119, 39, "http://example.com/hotel39_image3.jpg" },
                    { 120, 39, "http://example.com/hotel39_image4.jpg" },
                    { 121, 39, "http://example.com/hotel39_image5.jpg" },
                    { 122, 40, "http://example.com/hotel40_image1.jpg" },
                    { 123, 40, "http://example.com/hotel40_image2.jpg" },
                    { 124, 40, "http://example.com/hotel40_image3.jpg" },
                    { 125, 41, "http://example.com/hotel41_image1.jpg" },
                    { 126, 42, "http://example.com/hotel42_image1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 127, 42, "http://example.com/hotel42_image2.jpg" },
                    { 128, 42, "http://example.com/hotel42_image3.jpg" },
                    { 129, 42, "http://example.com/hotel42_image4.jpg" },
                    { 130, 42, "http://example.com/hotel42_image5.jpg" },
                    { 131, 43, "http://example.com/hotel43_image1.jpg" },
                    { 132, 43, "http://example.com/hotel43_image2.jpg" },
                    { 133, 43, "http://example.com/hotel43_image3.jpg" },
                    { 134, 43, "http://example.com/hotel43_image4.jpg" },
                    { 135, 43, "http://example.com/hotel43_image5.jpg" },
                    { 136, 44, "http://example.com/hotel44_image1.jpg" },
                    { 137, 44, "http://example.com/hotel44_image2.jpg" },
                    { 138, 44, "http://example.com/hotel44_image3.jpg" },
                    { 139, 44, "http://example.com/hotel44_image4.jpg" },
                    { 140, 45, "http://example.com/hotel45_image1.jpg" },
                    { 141, 45, "http://example.com/hotel45_image2.jpg" },
                    { 142, 45, "http://example.com/hotel45_image3.jpg" },
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

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "This is a review content for Hotel 1", new DateTime(2023, 8, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3971), 183 },
                    { 2, 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3988), 102 },
                    { 3, 22, "This is a review content for Hotel 22", new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3991), 148 },
                    { 4, 45, "This is a review content for Hotel 45", new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3995), 114 },
                    { 5, 41, "This is a review content for Hotel 41", new DateTime(2023, 6, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(3997), 72 },
                    { 6, 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4001), 11 },
                    { 7, 12, "This is a review content for Hotel 12", new DateTime(2023, 4, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4004), 163 },
                    { 8, 8, "This is a review content for Hotel 8", new DateTime(2023, 8, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4006), 252 },
                    { 9, 49, "This is a review content for Hotel 49", new DateTime(2023, 5, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4009), 127 },
                    { 10, 26, "This is a review content for Hotel 26", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4012), 133 },
                    { 11, 3, "This is a review content for Hotel 3", new DateTime(2023, 4, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4014), 260 },
                    { 12, 47, "This is a review content for Hotel 47", new DateTime(2023, 5, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4017), 227 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 13, 36, "This is a review content for Hotel 36", new DateTime(2023, 9, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4019), 26 },
                    { 14, 39, "This is a review content for Hotel 39", new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4022), 52 },
                    { 15, 25, "This is a review content for Hotel 25", new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4025), 18 },
                    { 16, 48, "This is a review content for Hotel 48", new DateTime(2024, 2, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4027), 191 },
                    { 17, 23, "This is a review content for Hotel 23", new DateTime(2023, 3, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4030), 60 },
                    { 18, 33, "This is a review content for Hotel 33", new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4033), 79 },
                    { 19, 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4036), 215 },
                    { 20, 23, "This is a review content for Hotel 23", new DateTime(2023, 4, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4038), 199 },
                    { 21, 25, "This is a review content for Hotel 25", new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4040), 109 },
                    { 22, 13, "This is a review content for Hotel 13", new DateTime(2023, 12, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4043), 157 },
                    { 23, 2, "This is a review content for Hotel 2", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4045), 107 },
                    { 24, 46, "This is a review content for Hotel 46", new DateTime(2023, 10, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4048), 51 },
                    { 25, 45, "This is a review content for Hotel 45", new DateTime(2023, 6, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4050), 3 },
                    { 26, 39, "This is a review content for Hotel 39", new DateTime(2023, 8, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4053), 223 },
                    { 27, 50, "This is a review content for Hotel 50", new DateTime(2023, 4, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4055), 169 },
                    { 28, 21, "This is a review content for Hotel 21", new DateTime(2023, 8, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4058), 83 },
                    { 29, 42, "This is a review content for Hotel 42", new DateTime(2023, 7, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4060), 256 },
                    { 30, 35, "This is a review content for Hotel 35", new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4063), 136 },
                    { 31, 28, "This is a review content for Hotel 28", new DateTime(2023, 7, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4065), 122 },
                    { 32, 32, "This is a review content for Hotel 32", new DateTime(2024, 2, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4067), 162 },
                    { 33, 33, "This is a review content for Hotel 33", new DateTime(2023, 12, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4070), 262 },
                    { 34, 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4073), 5 },
                    { 35, 27, "This is a review content for Hotel 27", new DateTime(2023, 11, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4075), 148 },
                    { 36, 26, "This is a review content for Hotel 26", new DateTime(2023, 12, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4078), 256 },
                    { 37, 46, "This is a review content for Hotel 46", new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4080), 275 },
                    { 38, 48, "This is a review content for Hotel 48", new DateTime(2023, 8, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4083), 232 },
                    { 39, 10, "This is a review content for Hotel 10", new DateTime(2023, 6, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4085), 227 },
                    { 40, 46, "This is a review content for Hotel 46", new DateTime(2023, 10, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4093), 121 },
                    { 41, 21, "This is a review content for Hotel 21", new DateTime(2023, 6, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4095), 179 },
                    { 42, 47, "This is a review content for Hotel 47", new DateTime(2023, 3, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4097), 33 },
                    { 43, 47, "This is a review content for Hotel 47", new DateTime(2024, 2, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4100), 86 },
                    { 44, 9, "This is a review content for Hotel 9", new DateTime(2023, 5, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4102), 140 },
                    { 45, 28, "This is a review content for Hotel 28", new DateTime(2023, 6, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4105), 119 },
                    { 46, 47, "This is a review content for Hotel 47", new DateTime(2023, 3, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4108), 90 },
                    { 47, 9, "This is a review content for Hotel 9", new DateTime(2023, 7, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4111), 107 },
                    { 48, 19, "This is a review content for Hotel 19", new DateTime(2023, 5, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4113), 60 },
                    { 49, 15, "This is a review content for Hotel 15", new DateTime(2023, 6, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4116), 78 },
                    { 50, 27, "This is a review content for Hotel 27", new DateTime(2023, 9, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4118), 137 },
                    { 51, 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4121), 111 },
                    { 52, 13, "This is a review content for Hotel 13", new DateTime(2023, 5, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4124), 226 },
                    { 53, 31, "This is a review content for Hotel 31", new DateTime(2023, 12, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4126), 84 },
                    { 54, 19, "This is a review content for Hotel 19", new DateTime(2023, 3, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4129), 232 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 55, 23, "This is a review content for Hotel 23", new DateTime(2023, 6, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4131), 218 },
                    { 56, 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4134), 144 },
                    { 57, 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4137), 84 },
                    { 58, 40, "This is a review content for Hotel 40", new DateTime(2024, 2, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4139), 208 },
                    { 59, 33, "This is a review content for Hotel 33", new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4142), 247 },
                    { 60, 25, "This is a review content for Hotel 25", new DateTime(2023, 4, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4144), 133 },
                    { 61, 19, "This is a review content for Hotel 19", new DateTime(2024, 1, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4147), 86 },
                    { 62, 29, "This is a review content for Hotel 29", new DateTime(2024, 1, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4149), 60 },
                    { 63, 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4152), 60 },
                    { 64, 49, "This is a review content for Hotel 49", new DateTime(2023, 10, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4154), 208 },
                    { 65, 14, "This is a review content for Hotel 14", new DateTime(2023, 7, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4157), 212 },
                    { 66, 31, "This is a review content for Hotel 31", new DateTime(2023, 11, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4160), 132 },
                    { 67, 16, "This is a review content for Hotel 16", new DateTime(2023, 8, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4162), 205 },
                    { 68, 21, "This is a review content for Hotel 21", new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4165), 141 },
                    { 69, 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4168), 11 },
                    { 70, 1, "This is a review content for Hotel 1", new DateTime(2023, 5, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4170), 112 },
                    { 71, 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4172), 268 },
                    { 72, 33, "This is a review content for Hotel 33", new DateTime(2023, 5, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4175), 185 },
                    { 73, 46, "This is a review content for Hotel 46", new DateTime(2023, 8, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4177), 231 },
                    { 74, 23, "This is a review content for Hotel 23", new DateTime(2024, 2, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4179), 82 },
                    { 75, 22, "This is a review content for Hotel 22", new DateTime(2023, 7, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4182), 91 },
                    { 76, 44, "This is a review content for Hotel 44", new DateTime(2023, 12, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4184), 41 },
                    { 77, 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4187), 87 },
                    { 78, 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4189), 12 },
                    { 79, 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4192), 186 },
                    { 80, 6, "This is a review content for Hotel 6", new DateTime(2023, 5, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4194), 223 },
                    { 81, 49, "This is a review content for Hotel 49", new DateTime(2023, 11, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4197), 102 },
                    { 82, 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4199), 291 },
                    { 83, 30, "This is a review content for Hotel 30", new DateTime(2023, 12, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4201), 45 },
                    { 84, 9, "This is a review content for Hotel 9", new DateTime(2023, 7, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4204), 122 },
                    { 85, 36, "This is a review content for Hotel 36", new DateTime(2023, 8, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4211), 240 },
                    { 86, 44, "This is a review content for Hotel 44", new DateTime(2023, 5, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4214), 160 },
                    { 87, 14, "This is a review content for Hotel 14", new DateTime(2023, 4, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4217), 163 },
                    { 88, 28, "This is a review content for Hotel 28", new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4219), 46 },
                    { 89, 23, "This is a review content for Hotel 23", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4222), 178 },
                    { 90, 36, "This is a review content for Hotel 36", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4224), 111 },
                    { 91, 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4227), 141 },
                    { 92, 14, "This is a review content for Hotel 14", new DateTime(2023, 5, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4230), 185 },
                    { 93, 38, "This is a review content for Hotel 38", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4232), 252 },
                    { 94, 20, "This is a review content for Hotel 20", new DateTime(2023, 4, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4235), 120 },
                    { 95, 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4237), 120 },
                    { 96, 27, "This is a review content for Hotel 27", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4239), 154 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 97, 9, "This is a review content for Hotel 9", new DateTime(2024, 2, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4242), 58 },
                    { 98, 23, "This is a review content for Hotel 23", new DateTime(2024, 1, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4245), 98 },
                    { 99, 18, "This is a review content for Hotel 18", new DateTime(2023, 8, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4247), 14 },
                    { 100, 31, "This is a review content for Hotel 31", new DateTime(2023, 6, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4250), 180 },
                    { 101, 36, "This is a review content for Hotel 36", new DateTime(2023, 3, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4252), 156 },
                    { 102, 47, "This is a review content for Hotel 47", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4255), 229 },
                    { 103, 23, "This is a review content for Hotel 23", new DateTime(2023, 12, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4257), 184 },
                    { 104, 30, "This is a review content for Hotel 30", new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4260), 202 },
                    { 105, 22, "This is a review content for Hotel 22", new DateTime(2023, 3, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4262), 47 },
                    { 106, 11, "This is a review content for Hotel 11", new DateTime(2023, 3, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4265), 228 },
                    { 107, 12, "This is a review content for Hotel 12", new DateTime(2023, 3, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4267), 272 },
                    { 108, 41, "This is a review content for Hotel 41", new DateTime(2023, 6, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4269), 135 },
                    { 109, 15, "This is a review content for Hotel 15", new DateTime(2023, 12, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4272), 155 },
                    { 110, 50, "This is a review content for Hotel 50", new DateTime(2023, 3, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4274), 85 },
                    { 111, 16, "This is a review content for Hotel 16", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4277), 287 },
                    { 112, 7, "This is a review content for Hotel 7", new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4279), 202 },
                    { 113, 29, "This is a review content for Hotel 29", new DateTime(2023, 4, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4282), 264 },
                    { 114, 38, "This is a review content for Hotel 38", new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4284), 39 },
                    { 115, 27, "This is a review content for Hotel 27", new DateTime(2024, 1, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4287), 142 },
                    { 116, 35, "This is a review content for Hotel 35", new DateTime(2023, 9, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4289), 52 },
                    { 117, 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4292), 7 },
                    { 118, 42, "This is a review content for Hotel 42", new DateTime(2023, 9, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4294), 276 },
                    { 119, 22, "This is a review content for Hotel 22", new DateTime(2024, 2, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4297), 180 },
                    { 120, 29, "This is a review content for Hotel 29", new DateTime(2023, 4, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4299), 61 },
                    { 121, 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4302), 128 },
                    { 122, 17, "This is a review content for Hotel 17", new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4304), 141 },
                    { 123, 4, "This is a review content for Hotel 4", new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4307), 204 },
                    { 124, 31, "This is a review content for Hotel 31", new DateTime(2023, 6, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4309), 64 },
                    { 125, 4, "This is a review content for Hotel 4", new DateTime(2023, 7, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4312), 277 },
                    { 126, 45, "This is a review content for Hotel 45", new DateTime(2023, 3, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4314), 114 },
                    { 127, 5, "This is a review content for Hotel 5", new DateTime(2023, 4, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4317), 260 },
                    { 128, 34, "This is a review content for Hotel 34", new DateTime(2023, 10, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4319), 47 },
                    { 129, 38, "This is a review content for Hotel 38", new DateTime(2023, 8, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4322), 7 },
                    { 130, 13, "This is a review content for Hotel 13", new DateTime(2023, 8, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4329), 86 },
                    { 131, 9, "This is a review content for Hotel 9", new DateTime(2023, 5, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4332), 7 },
                    { 132, 42, "This is a review content for Hotel 42", new DateTime(2023, 10, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4334), 247 },
                    { 133, 8, "This is a review content for Hotel 8", new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4337), 81 },
                    { 134, 39, "This is a review content for Hotel 39", new DateTime(2023, 4, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4339), 206 },
                    { 135, 33, "This is a review content for Hotel 33", new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4342), 291 },
                    { 136, 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4344), 243 },
                    { 137, 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4347), 33 },
                    { 138, 6, "This is a review content for Hotel 6", new DateTime(2023, 9, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4349), 226 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 139, 50, "This is a review content for Hotel 50", new DateTime(2023, 11, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4352), 69 },
                    { 140, 25, "This is a review content for Hotel 25", new DateTime(2024, 1, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4354), 42 },
                    { 141, 40, "This is a review content for Hotel 40", new DateTime(2023, 6, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4357), 155 },
                    { 142, 37, "This is a review content for Hotel 37", new DateTime(2023, 7, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4359), 28 },
                    { 143, 18, "This is a review content for Hotel 18", new DateTime(2023, 3, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4362), 176 },
                    { 144, 7, "This is a review content for Hotel 7", new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4364), 181 },
                    { 145, 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4367), 72 },
                    { 146, 30, "This is a review content for Hotel 30", new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4369), 107 },
                    { 147, 27, "This is a review content for Hotel 27", new DateTime(2023, 4, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4372), 29 },
                    { 148, 23, "This is a review content for Hotel 23", new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4375), 104 },
                    { 149, 4, "This is a review content for Hotel 4", new DateTime(2023, 3, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4377), 167 },
                    { 150, 17, "This is a review content for Hotel 17", new DateTime(2023, 10, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4379), 88 },
                    { 151, 1, "This is a review content for Hotel 1", new DateTime(2023, 3, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4382), 203 },
                    { 152, 20, "This is a review content for Hotel 20", new DateTime(2024, 1, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4384), 80 },
                    { 153, 47, "This is a review content for Hotel 47", new DateTime(2023, 9, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4387), 32 },
                    { 154, 22, "This is a review content for Hotel 22", new DateTime(2023, 8, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4389), 149 },
                    { 155, 44, "This is a review content for Hotel 44", new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4392), 40 },
                    { 156, 21, "This is a review content for Hotel 21", new DateTime(2023, 10, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4394), 10 },
                    { 157, 28, "This is a review content for Hotel 28", new DateTime(2023, 4, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4397), 66 },
                    { 158, 34, "This is a review content for Hotel 34", new DateTime(2023, 9, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4399), 148 },
                    { 159, 44, "This is a review content for Hotel 44", new DateTime(2023, 6, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4402), 290 },
                    { 160, 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4404), 23 },
                    { 161, 47, "This is a review content for Hotel 47", new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4407), 198 },
                    { 162, 16, "This is a review content for Hotel 16", new DateTime(2023, 8, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4410), 248 },
                    { 163, 35, "This is a review content for Hotel 35", new DateTime(2023, 6, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4412), 125 },
                    { 164, 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4415), 114 },
                    { 165, 5, "This is a review content for Hotel 5", new DateTime(2023, 12, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4417), 74 },
                    { 166, 30, "This is a review content for Hotel 30", new DateTime(2023, 9, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4420), 242 },
                    { 167, 12, "This is a review content for Hotel 12", new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4423), 126 },
                    { 168, 21, "This is a review content for Hotel 21", new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4425), 128 },
                    { 169, 43, "This is a review content for Hotel 43", new DateTime(2023, 3, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4428), 229 },
                    { 170, 4, "This is a review content for Hotel 4", new DateTime(2023, 5, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4430), 15 },
                    { 171, 36, "This is a review content for Hotel 36", new DateTime(2023, 9, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4433), 287 },
                    { 172, 30, "This is a review content for Hotel 30", new DateTime(2023, 5, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4435), 36 },
                    { 173, 15, "This is a review content for Hotel 15", new DateTime(2023, 12, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4438), 133 },
                    { 174, 33, "This is a review content for Hotel 33", new DateTime(2023, 10, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4444), 20 },
                    { 175, 27, "This is a review content for Hotel 27", new DateTime(2023, 3, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4446), 249 },
                    { 176, 37, "This is a review content for Hotel 37", new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4449), 250 },
                    { 177, 46, "This is a review content for Hotel 46", new DateTime(2023, 4, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4451), 145 },
                    { 178, 50, "This is a review content for Hotel 50", new DateTime(2023, 9, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4454), 108 },
                    { 179, 46, "This is a review content for Hotel 46", new DateTime(2023, 11, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4456), 187 },
                    { 180, 36, "This is a review content for Hotel 36", new DateTime(2023, 7, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4458), 15 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 181, 2, "This is a review content for Hotel 2", new DateTime(2023, 7, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4461), 82 },
                    { 182, 22, "This is a review content for Hotel 22", new DateTime(2023, 11, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4464), 122 },
                    { 183, 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4466), 263 },
                    { 184, 40, "This is a review content for Hotel 40", new DateTime(2023, 3, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4469), 100 },
                    { 185, 6, "This is a review content for Hotel 6", new DateTime(2023, 6, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4471), 38 },
                    { 186, 40, "This is a review content for Hotel 40", new DateTime(2023, 4, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4473), 49 },
                    { 187, 26, "This is a review content for Hotel 26", new DateTime(2023, 9, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4476), 226 },
                    { 188, 29, "This is a review content for Hotel 29", new DateTime(2023, 8, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4479), 136 },
                    { 189, 12, "This is a review content for Hotel 12", new DateTime(2023, 9, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4481), 238 },
                    { 190, 35, "This is a review content for Hotel 35", new DateTime(2023, 8, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4484), 145 },
                    { 191, 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4486), 99 },
                    { 192, 28, "This is a review content for Hotel 28", new DateTime(2023, 11, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4488), 109 },
                    { 193, 21, "This is a review content for Hotel 21", new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4491), 125 },
                    { 194, 34, "This is a review content for Hotel 34", new DateTime(2023, 5, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4493), 204 },
                    { 195, 19, "This is a review content for Hotel 19", new DateTime(2023, 3, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4496), 68 },
                    { 196, 42, "This is a review content for Hotel 42", new DateTime(2023, 3, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4499), 55 },
                    { 197, 32, "This is a review content for Hotel 32", new DateTime(2023, 7, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4501), 164 },
                    { 198, 45, "This is a review content for Hotel 45", new DateTime(2023, 5, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4504), 156 },
                    { 199, 1, "This is a review content for Hotel 1", new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4506), 157 },
                    { 200, 25, "This is a review content for Hotel 25", new DateTime(2023, 7, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(4509), 87 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, 3, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5212), "Description for Room1", 8, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5220), 1, 134m, 1, "http://example.com/room1.jpg" },
                    { 2, 4, 0, new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5231), "Description for Room2", 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5233), 2, 402m, 1, "http://example.com/room2.jpg" },
                    { 3, 1, 1, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5236), "Description for Room3", 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5238), 3, 191m, 3, "http://example.com/room3.jpg" },
                    { 4, 1, 0, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5241), "Description for Room4", 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5242), 4, 394m, 1, "http://example.com/room4.jpg" },
                    { 5, 1, 2, new DateTime(2023, 12, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5246), "Description for Room5", 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5247), 5, 345m, 2, "http://example.com/room5.jpg" },
                    { 6, 2, 2, new DateTime(2024, 2, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5251), "Description for Room6", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5253), 6, 487m, 3, "http://example.com/room6.jpg" },
                    { 7, 2, 2, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5256), "Description for Room7", 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5258), 7, 169m, 2, "http://example.com/room7.jpg" },
                    { 8, 2, 2, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5261), "Description for Room8", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5263), 8, 318m, 1, "http://example.com/room8.jpg" },
                    { 9, 1, 1, new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5266), "Description for Room9", 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5268), 9, 131m, 1, "http://example.com/room9.jpg" },
                    { 10, 1, 1, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5272), "Description for Room10", 28, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5273), 10, 457m, 1, "http://example.com/room10.jpg" },
                    { 11, 1, 2, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5277), "Description for Room11", 48, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5279), 11, 149m, 2, "http://example.com/room11.jpg" },
                    { 12, 1, 2, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5282), "Description for Room12", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5283), 12, 89m, 3, "http://example.com/room12.jpg" },
                    { 13, 1, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5287), "Description for Room13", 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5289), 13, 260m, 3, "http://example.com/room13.jpg" },
                    { 14, 3, 2, new DateTime(2024, 1, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5292), "Description for Room14", 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5293), 14, 144m, 2, "http://example.com/room14.jpg" },
                    { 15, 1, 0, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5297), "Description for Room15", 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5298), 15, 331m, 2, "http://example.com/room15.jpg" },
                    { 16, 4, 0, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5301), "Description for Room16", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5303), 16, 234m, 1, "http://example.com/room16.jpg" },
                    { 17, 3, 2, new DateTime(2024, 1, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5306), "Description for Room17", 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5308), 17, 127m, 1, "http://example.com/room17.jpg" },
                    { 18, 1, 2, new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5318), "Description for Room18", 44, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5319), 18, 130m, 3, "http://example.com/room18.jpg" },
                    { 19, 1, 0, new DateTime(2024, 2, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5322), "Description for Room19", 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5324), 19, 383m, 3, "http://example.com/room19.jpg" },
                    { 20, 1, 0, new DateTime(2023, 12, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5327), "Description for Room20", 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5329), 20, 173m, 3, "http://example.com/room20.jpg" },
                    { 21, 3, 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5332), "Description for Room21", 33, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5334), 21, 225m, 1, "http://example.com/room21.jpg" },
                    { 22, 3, 0, new DateTime(2024, 2, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5337), "Description for Room22", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5338), 22, 117m, 1, "http://example.com/room22.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 23, 4, 2, new DateTime(2024, 2, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5342), "Description for Room23", 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5343), 23, 339m, 3, "http://example.com/room23.jpg" },
                    { 24, 4, 2, new DateTime(2023, 12, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5347), "Description for Room24", 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5348), 24, 316m, 3, "http://example.com/room24.jpg" },
                    { 25, 3, 1, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5352), "Description for Room25", 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5353), 25, 110m, 3, "http://example.com/room25.jpg" },
                    { 26, 1, 2, new DateTime(2023, 12, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5357), "Description for Room26", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5358), 26, 451m, 3, "http://example.com/room26.jpg" },
                    { 27, 1, 2, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5362), "Description for Room27", 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5363), 27, 343m, 1, "http://example.com/room27.jpg" },
                    { 28, 2, 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5366), "Description for Room28", 40, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5368), 28, 348m, 2, "http://example.com/room28.jpg" },
                    { 29, 4, 0, new DateTime(2024, 1, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5371), "Description for Room29", 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5373), 29, 141m, 2, "http://example.com/room29.jpg" },
                    { 30, 4, 1, new DateTime(2023, 12, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5376), "Description for Room30", 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5377), 30, 230m, 3, "http://example.com/room30.jpg" },
                    { 31, 2, 0, new DateTime(2023, 12, 7, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5381), "Description for Room31", 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5382), 31, 90m, 1, "http://example.com/room31.jpg" },
                    { 32, 3, 0, new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5385), "Description for Room32", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5387), 32, 264m, 1, "http://example.com/room32.jpg" },
                    { 33, 3, 0, new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5390), "Description for Room33", 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5392), 33, 223m, 3, "http://example.com/room33.jpg" },
                    { 34, 2, 0, new DateTime(2024, 1, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5396), "Description for Room34", 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5397), 34, 143m, 3, "http://example.com/room34.jpg" },
                    { 35, 3, 2, new DateTime(2023, 12, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5401), "Description for Room35", 3, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5402), 35, 270m, 1, "http://example.com/room35.jpg" },
                    { 36, 4, 0, new DateTime(2024, 2, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5405), "Description for Room36", 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5407), 36, 278m, 3, "http://example.com/room36.jpg" },
                    { 37, 1, 2, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5410), "Description for Room37", 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5412), 37, 330m, 3, "http://example.com/room37.jpg" },
                    { 38, 1, 0, new DateTime(2024, 2, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5415), "Description for Room38", 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5417), 38, 240m, 1, "http://example.com/room38.jpg" },
                    { 39, 1, 0, new DateTime(2023, 12, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5420), "Description for Room39", 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5422), 39, 462m, 1, "http://example.com/room39.jpg" },
                    { 40, 4, 0, new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5425), "Description for Room40", 6, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5427), 40, 417m, 2, "http://example.com/room40.jpg" },
                    { 41, 2, 0, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5430), "Description for Room41", 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5432), 41, 264m, 1, "http://example.com/room41.jpg" },
                    { 42, 4, 2, new DateTime(2023, 12, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5435), "Description for Room42", 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5437), 42, 229m, 2, "http://example.com/room42.jpg" },
                    { 43, 1, 0, new DateTime(2023, 12, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5440), "Description for Room43", 20, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5441), 43, 296m, 1, "http://example.com/room43.jpg" },
                    { 44, 4, 2, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5445), "Description for Room44", 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5446), 44, 463m, 3, "http://example.com/room44.jpg" },
                    { 45, 4, 2, new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5450), "Description for Room45", 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5451), 45, 317m, 3, "http://example.com/room45.jpg" },
                    { 46, 4, 2, new DateTime(2024, 2, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5455), "Description for Room46", 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5456), 46, 156m, 3, "http://example.com/room46.jpg" },
                    { 47, 3, 0, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5460), "Description for Room47", 18, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5461), 47, 304m, 3, "http://example.com/room47.jpg" },
                    { 48, 3, 1, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5464), "Description for Room48", 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5466), 48, 282m, 1, "http://example.com/room48.jpg" },
                    { 49, 2, 0, new DateTime(2023, 12, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5473), "Description for Room49", 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5475), 49, 403m, 2, "http://example.com/room49.jpg" },
                    { 50, 2, 0, new DateTime(2024, 1, 16, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5478), "Description for Room50", 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5480), 50, 231m, 2, "http://example.com/room50.jpg" },
                    { 51, 3, 2, new DateTime(2024, 2, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5483), "Description for Room51", 14, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5485), 51, 218m, 2, "http://example.com/room51.jpg" },
                    { 52, 1, 1, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5488), "Description for Room52", 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5489), 52, 421m, 2, "http://example.com/room52.jpg" },
                    { 53, 2, 1, new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5493), "Description for Room53", 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5494), 53, 351m, 2, "http://example.com/room53.jpg" },
                    { 54, 2, 1, new DateTime(2024, 2, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5497), "Description for Room54", 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5499), 54, 460m, 3, "http://example.com/room54.jpg" },
                    { 55, 3, 0, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5502), "Description for Room55", 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5504), 55, 127m, 2, "http://example.com/room55.jpg" },
                    { 56, 2, 0, new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5507), "Description for Room56", 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5509), 56, 340m, 3, "http://example.com/room56.jpg" },
                    { 57, 3, 0, new DateTime(2023, 12, 14, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5512), "Description for Room57", 39, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5514), 57, 164m, 1, "http://example.com/room57.jpg" },
                    { 58, 3, 2, new DateTime(2024, 2, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5517), "Description for Room58", 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5519), 58, 133m, 2, "http://example.com/room58.jpg" },
                    { 59, 2, 1, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5522), "Description for Room59", 15, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5523), 59, 295m, 2, "http://example.com/room59.jpg" },
                    { 60, 2, 0, new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5527), "Description for Room60", 3, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5528), 60, 456m, 1, "http://example.com/room60.jpg" },
                    { 61, 2, 1, new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5531), "Description for Room61", 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5533), 61, 411m, 3, "http://example.com/room61.jpg" },
                    { 62, 3, 1, new DateTime(2023, 12, 17, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5536), "Description for Room62", 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5538), 62, 209m, 3, "http://example.com/room62.jpg" },
                    { 63, 1, 1, new DateTime(2023, 12, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5541), "Description for Room63", 18, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5543), 63, 333m, 1, "http://example.com/room63.jpg" },
                    { 64, 2, 0, new DateTime(2024, 2, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5546), "Description for Room64", 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5547), 64, 127m, 1, "http://example.com/room64.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 65, 1, 1, new DateTime(2024, 2, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5551), "Description for Room65", 2, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5552), 65, 245m, 3, "http://example.com/room65.jpg" },
                    { 66, 1, 1, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5556), "Description for Room66", 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5558), 66, 366m, 2, "http://example.com/room66.jpg" },
                    { 67, 4, 0, new DateTime(2024, 1, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5561), "Description for Room67", 48, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5563), 67, 287m, 1, "http://example.com/room67.jpg" },
                    { 68, 3, 0, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5566), "Description for Room68", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5568), 68, 199m, 3, "http://example.com/room68.jpg" },
                    { 69, 2, 2, new DateTime(2023, 12, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5571), "Description for Room69", 13, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5573), 69, 277m, 1, "http://example.com/room69.jpg" },
                    { 70, 4, 0, new DateTime(2023, 11, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5576), "Description for Room70", 30, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5578), 70, 411m, 2, "http://example.com/room70.jpg" },
                    { 71, 2, 2, new DateTime(2023, 12, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5581), "Description for Room71", 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5582), 71, 267m, 1, "http://example.com/room71.jpg" },
                    { 72, 4, 2, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5586), "Description for Room72", 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5587), 72, 89m, 3, "http://example.com/room72.jpg" },
                    { 73, 4, 1, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5590), "Description for Room73", 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5592), 73, 216m, 2, "http://example.com/room73.jpg" },
                    { 74, 1, 1, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5595), "Description for Room74", 43, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5597), 74, 112m, 2, "http://example.com/room74.jpg" },
                    { 75, 4, 2, new DateTime(2024, 1, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5600), "Description for Room75", 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5602), 75, 300m, 2, "http://example.com/room75.jpg" },
                    { 76, 3, 0, new DateTime(2024, 1, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5605), "Description for Room76", 29, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5606), 76, 269m, 2, "http://example.com/room76.jpg" },
                    { 77, 1, 1, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5610), "Description for Room77", 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5611), 77, 298m, 1, "http://example.com/room77.jpg" },
                    { 78, 1, 2, new DateTime(2023, 12, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5619), "Description for Room78", 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5620), 78, 143m, 3, "http://example.com/room78.jpg" },
                    { 79, 2, 0, new DateTime(2024, 2, 18, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5624), "Description for Room79", 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5625), 79, 115m, 1, "http://example.com/room79.jpg" },
                    { 80, 3, 1, new DateTime(2024, 1, 9, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5628), "Description for Room80", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5630), 80, 80m, 2, "http://example.com/room80.jpg" },
                    { 81, 4, 0, new DateTime(2023, 12, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5633), "Description for Room81", 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5635), 81, 69m, 3, "http://example.com/room81.jpg" },
                    { 82, 3, 1, new DateTime(2024, 1, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5638), "Description for Room82", 29, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5640), 82, 191m, 3, "http://example.com/room82.jpg" },
                    { 83, 2, 2, new DateTime(2024, 2, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5643), "Description for Room83", 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5644), 83, 135m, 3, "http://example.com/room83.jpg" },
                    { 84, 1, 1, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5648), "Description for Room84", 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5649), 84, 458m, 1, "http://example.com/room84.jpg" },
                    { 85, 1, 0, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5652), "Description for Room85", 15, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5654), 85, 481m, 1, "http://example.com/room85.jpg" },
                    { 86, 2, 0, new DateTime(2024, 2, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5657), "Description for Room86", 9, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5659), 86, 205m, 2, "http://example.com/room86.jpg" },
                    { 87, 4, 1, new DateTime(2024, 1, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5662), "Description for Room87", 24, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5664), 87, 166m, 1, "http://example.com/room87.jpg" },
                    { 88, 4, 0, new DateTime(2024, 2, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5667), "Description for Room88", 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5669), 88, 187m, 3, "http://example.com/room88.jpg" },
                    { 89, 4, 2, new DateTime(2024, 2, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5672), "Description for Room89", 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5673), 89, 246m, 3, "http://example.com/room89.jpg" },
                    { 90, 3, 0, new DateTime(2024, 1, 13, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5677), "Description for Room90", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5678), 90, 360m, 1, "http://example.com/room90.jpg" },
                    { 91, 1, 2, new DateTime(2023, 12, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5682), "Description for Room91", 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5683), 91, 412m, 3, "http://example.com/room91.jpg" },
                    { 92, 4, 1, new DateTime(2023, 12, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5687), "Description for Room92", 24, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5688), 92, 224m, 1, "http://example.com/room92.jpg" },
                    { 93, 1, 0, new DateTime(2023, 12, 8, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5691), "Description for Room93", 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5693), 93, 352m, 1, "http://example.com/room93.jpg" },
                    { 94, 3, 1, new DateTime(2024, 2, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5696), "Description for Room94", 40, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5698), 94, 64m, 1, "http://example.com/room94.jpg" },
                    { 95, 1, 0, new DateTime(2023, 12, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5701), "Description for Room95", 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5703), 95, 63m, 2, "http://example.com/room95.jpg" },
                    { 96, 2, 2, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5706), "Description for Room96", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5708), 96, 301m, 2, "http://example.com/room96.jpg" },
                    { 97, 2, 2, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5711), "Description for Room97", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5712), 97, 71m, 1, "http://example.com/room97.jpg" },
                    { 98, 1, 2, new DateTime(2024, 2, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5716), "Description for Room98", 25, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5717), 98, 408m, 2, "http://example.com/room98.jpg" },
                    { 99, 4, 2, new DateTime(2024, 2, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5720), "Description for Room99", 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5722), 99, 219m, 1, "http://example.com/room99.jpg" },
                    { 100, 4, 2, new DateTime(2023, 11, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5726), "Description for Room100", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5727), 100, 175m, 1, "http://example.com/room100.jpg" },
                    { 101, 1, 0, new DateTime(2024, 1, 31, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5731), "Description for Room101", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5732), 101, 54m, 2, "http://example.com/room101.jpg" },
                    { 102, 4, 2, new DateTime(2024, 1, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5736), "Description for Room102", 45, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5737), 102, 299m, 3, "http://example.com/room102.jpg" },
                    { 103, 1, 1, new DateTime(2023, 12, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5740), "Description for Room103", 28, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5742), 103, 386m, 3, "http://example.com/room103.jpg" },
                    { 104, 2, 0, new DateTime(2024, 1, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5745), "Description for Room104", 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5747), 104, 331m, 1, "http://example.com/room104.jpg" },
                    { 105, 2, 0, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5750), "Description for Room105", 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5751), 105, 464m, 1, "http://example.com/room105.jpg" },
                    { 106, 1, 0, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5755), "Description for Room106", 10, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5756), 106, 65m, 2, "http://example.com/room106.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 107, 3, 0, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5760), "Description for Room107", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5762), 107, 158m, 2, "http://example.com/room107.jpg" },
                    { 108, 1, 2, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5765), "Description for Room108", 16, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5767), 108, 314m, 2, "http://example.com/room108.jpg" },
                    { 109, 2, 0, new DateTime(2023, 12, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5770), "Description for Room109", 21, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5771), 109, 73m, 3, "http://example.com/room109.jpg" },
                    { 110, 1, 0, new DateTime(2024, 1, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5778), "Description for Room110", 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5780), 110, 450m, 1, "http://example.com/room110.jpg" },
                    { 111, 1, 1, new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5783), "Description for Room111", 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5784), 111, 491m, 2, "http://example.com/room111.jpg" },
                    { 112, 4, 0, new DateTime(2023, 11, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5788), "Description for Room112", 19, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5789), 112, 69m, 1, "http://example.com/room112.jpg" },
                    { 113, 2, 2, new DateTime(2024, 1, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5793), "Description for Room113", 5, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5794), 113, 236m, 3, "http://example.com/room113.jpg" },
                    { 114, 3, 0, new DateTime(2023, 11, 30, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5798), "Description for Room114", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5799), 114, 94m, 1, "http://example.com/room114.jpg" },
                    { 115, 3, 1, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5803), "Description for Room115", 37, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5804), 115, 449m, 1, "http://example.com/room115.jpg" },
                    { 116, 2, 0, new DateTime(2024, 1, 26, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5808), "Description for Room116", 35, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5809), 116, 334m, 1, "http://example.com/room116.jpg" },
                    { 117, 3, 0, new DateTime(2023, 12, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5812), "Description for Room117", 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5814), 117, 191m, 3, "http://example.com/room117.jpg" },
                    { 118, 1, 2, new DateTime(2024, 3, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5817), "Description for Room118", 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5819), 118, 222m, 2, "http://example.com/room118.jpg" },
                    { 119, 2, 1, new DateTime(2023, 12, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5822), "Description for Room119", 38, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5824), 119, 269m, 2, "http://example.com/room119.jpg" },
                    { 120, 1, 1, new DateTime(2024, 1, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5827), "Description for Room120", 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5829), 120, 377m, 3, "http://example.com/room120.jpg" },
                    { 121, 3, 1, new DateTime(2024, 3, 2, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5832), "Description for Room121", 46, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5834), 121, 283m, 2, "http://example.com/room121.jpg" },
                    { 122, 3, 2, new DateTime(2024, 1, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5837), "Description for Room122", 11, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5839), 122, 170m, 2, "http://example.com/room122.jpg" },
                    { 123, 1, 2, new DateTime(2024, 2, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5842), "Description for Room123", 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5844), 123, 388m, 3, "http://example.com/room123.jpg" },
                    { 124, 1, 1, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5847), "Description for Room124", 12, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5848), 124, 157m, 3, "http://example.com/room124.jpg" },
                    { 125, 4, 1, new DateTime(2024, 1, 5, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5852), "Description for Room125", 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5853), 125, 486m, 3, "http://example.com/room125.jpg" },
                    { 126, 4, 2, new DateTime(2024, 3, 1, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5856), "Description for Room126", 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5858), 126, 289m, 1, "http://example.com/room126.jpg" },
                    { 127, 4, 1, new DateTime(2023, 12, 21, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5861), "Description for Room127", 13, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5863), 127, 99m, 1, "http://example.com/room127.jpg" },
                    { 128, 3, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5866), "Description for Room128", 26, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5868), 128, 439m, 1, "http://example.com/room128.jpg" },
                    { 129, 1, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5871), "Description for Room129", 47, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5873), 129, 354m, 2, "http://example.com/room129.jpg" },
                    { 130, 1, 2, new DateTime(2023, 12, 22, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5877), "Description for Room130", 7, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5878), 130, 191m, 3, "http://example.com/room130.jpg" },
                    { 131, 2, 0, new DateTime(2023, 12, 28, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5882), "Description for Room131", 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5883), 131, 152m, 2, "http://example.com/room131.jpg" },
                    { 132, 3, 2, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5887), "Description for Room132", 7, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5888), 132, 265m, 2, "http://example.com/room132.jpg" },
                    { 133, 3, 2, new DateTime(2023, 12, 19, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5892), "Description for Room133", 29, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5893), 133, 137m, 3, "http://example.com/room133.jpg" },
                    { 134, 4, 0, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5900), "Description for Room134", 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5902), 134, 395m, 1, "http://example.com/room134.jpg" },
                    { 135, 4, 1, new DateTime(2024, 2, 23, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5905), "Description for Room135", 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5907), 135, 323m, 3, "http://example.com/room135.jpg" },
                    { 136, 4, 1, new DateTime(2024, 1, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5910), "Description for Room136", 41, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5912), 136, 174m, 1, "http://example.com/room136.jpg" },
                    { 137, 3, 1, new DateTime(2023, 12, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5915), "Description for Room137", 27, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5917), 137, 240m, 1, "http://example.com/room137.jpg" },
                    { 138, 2, 0, new DateTime(2024, 1, 6, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5920), "Description for Room138", 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5921), 138, 400m, 2, "http://example.com/room138.jpg" },
                    { 139, 1, 0, new DateTime(2024, 1, 15, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5925), "Description for Room139", 49, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5926), 139, 301m, 1, "http://example.com/room139.jpg" },
                    { 140, 2, 0, new DateTime(2023, 12, 11, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5929), "Description for Room140", 22, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5931), 140, 257m, 1, "http://example.com/room140.jpg" },
                    { 141, 4, 0, new DateTime(2023, 12, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5934), "Description for Room141", 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5936), 141, 388m, 2, "http://example.com/room141.jpg" },
                    { 142, 1, 1, new DateTime(2024, 1, 24, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5939), "Description for Room142", 42, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5941), 142, 499m, 2, "http://example.com/room142.jpg" },
                    { 143, 2, 0, new DateTime(2024, 1, 25, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5944), "Description for Room143", 34, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5946), 143, 354m, 3, "http://example.com/room143.jpg" },
                    { 144, 1, 2, new DateTime(2024, 2, 20, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5949), "Description for Room144", 1, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5951), 144, 206m, 3, "http://example.com/room144.jpg" },
                    { 145, 3, 2, new DateTime(2023, 12, 12, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5954), "Description for Room145", 31, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5956), 145, 422m, 2, "http://example.com/room145.jpg" },
                    { 146, 1, 2, new DateTime(2023, 11, 27, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5959), "Description for Room146", 4, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5961), 146, 226m, 1, "http://example.com/room146.jpg" },
                    { 147, 1, 1, new DateTime(2024, 1, 10, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5964), "Description for Room147", 36, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5965), 147, 349m, 3, "http://example.com/room147.jpg" },
                    { 148, 1, 1, new DateTime(2023, 11, 29, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5969), "Description for Room148", 32, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5970), 148, 95m, 1, "http://example.com/room148.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[] { 149, 1, 2, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5974), "Description for Room149", 23, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5975), 149, 97m, 3, "http://example.com/room149.jpg" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[] { 150, 2, 0, new DateTime(2024, 2, 4, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5979), "Description for Room150", 50, new DateTime(2024, 3, 3, 14, 13, 24, 548, DateTimeKind.Local).AddTicks(5980), 150, 316m, 2, "http://example.com/room150.jpg" });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreatedAt", "RoomId", "Status", "TotalPrice", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9335), 1, 2, 770m, null, 3 },
                    { 2, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9343), 2, 2, 539m, null, 3 },
                    { 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9344), 49, 2, 655m, null, 49 },
                    { 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9346), 50, 2, 796m, null, 50 },
                    { 5, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9438), 3, 2, 341m, null, 3 },
                    { 6, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9446), 4, 2, 297m, null, 4 },
                    { 7, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9447), 3, 2, 300m, null, 3 },
                    { 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9448), 3, 2, 300m, null, 4 },
                    { 9, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9449), 5, 2, 200m, null, 2 },
                    { 10, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9451), 4, 2, 450m, null, 4 },
                    { 11, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9452), 4, 2, 400m, null, 5 },
                    { 12, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9453), 9, 2, 500m, null, 6 },
                    { 13, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 13, 24, 548, DateTimeKind.Utc).AddTicks(9454), 10, 2, 550m, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "Amount", "BookingId", "IsProcessed", "PaymentDate", "Status" },
                values: new object[,]
                {
                    { 1, 223m, 1, true, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, 736m, 2, true, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, 761m, 3, true, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 4, 913m, 4, true, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 5, 833m, 5, true, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 6, 150m, 6, true, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 7, 516m, 7, true, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 8, 377m, 8, true, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 9, 915m, 9, true, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 10, 911m, 10, true, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 11, 619m, 11, true, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 12, 225m, 12, true, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 13, 997m, 13, true, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId_CheckInDate_CheckOutDate",
                table: "Booking",
                columns: new[] { "RoomId", "CheckInDate", "CheckOutDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityId",
                table: "Hotel",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_LocationId",
                table: "Hotel",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingId",
                table: "Payment",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_HotelId",
                table: "Review",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelImage");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
