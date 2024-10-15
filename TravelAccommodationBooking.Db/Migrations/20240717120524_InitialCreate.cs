using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAccommodationBooking.Db.Migrations
{
    public partial class InitialCreate : Migration
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

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Country", "CreationDate", "ModificationDate", "Name", "PostOffice", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "Country1", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9159), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City1", "PostOffice1", "http://example.com/city1.jpg" },
                    { 2, "Country2", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9193), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City2", "PostOffice2", "http://example.com/city2.jpg" },
                    { 3, "Country3", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9260), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City3", "PostOffice3", "http://example.com/city3.jpg" },
                    { 4, "Country4", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9264), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City4", "PostOffice4", "http://example.com/city4.jpg" },
                    { 5, "Country5", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9267), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City5", "PostOffice5", "http://example.com/city5.jpg" },
                    { 6, "Country6", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9271), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City6", "PostOffice6", "http://example.com/city6.jpg" },
                    { 7, "Country7", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City7", "PostOffice7", "http://example.com/city7.jpg" },
                    { 8, "Country8", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City8", "PostOffice8", "http://example.com/city8.jpg" },
                    { 9, "Country9", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9281), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City9", "PostOffice9", "http://example.com/city9.jpg" },
                    { 10, "Country10", new DateTime(2024, 7, 17, 12, 5, 24, 418, DateTimeKind.Utc).AddTicks(9284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City10", "PostOffice10", "http://example.com/city10.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "Amount", "BookingId", "IsProcessed", "PaymentDate", "Status" },
                values: new object[,]
                {
                    { 1, 375m, 1, true, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, 224m, 2, true, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, 183m, 3, true, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 4, 496m, 4, true, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 5, 526m, 5, true, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 6, 277m, 6, true, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 7, 270m, 7, true, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 8, 288m, 8, true, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 9, 418m, 9, true, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 10, 136m, 10, true, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 11, 953m, 11, true, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 12, 887m, 12, true, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 13, 458m, 13, true, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin1@example.com", "$2a$11$5i9Y5B3S4b..GAJIrnf6XetGGrtOuzxY.XIj1sMZbSFMFOd125gSm", 1, "admin1" },
                    { 2, "admin2@example.com", "$2a$11$XvSdIk/z3.4TgZpCzcIXi.fEP9fap1cRQwzmRexU37cWOpUlOzu5S", 1, "admin2" },
                    { 3, "user3@example.com", "$2a$11$dqeOMG28HhRCpM5Lv1heVOospo6YB8pZugBABp1HRSlO.2F90QIPm", 0, "user3" },
                    { 4, "user4@example.com", "$2a$11$JPDfnTerSlntCxwU3gxffOMTrynEZBQ.Tu55tnFFTc1jAT7qEPdQ.", 0, "user4" },
                    { 5, "user5@example.com", "$2a$11$1uM7Te/0M3n921HZZjNeYODPpS5rMn20yWC4FFx./gfY9p5ik7kBm", 0, "user5" },
                    { 6, "user6@example.com", "$2a$11$M4p90EYMpF7yapszcalg1OyjY/wYC/dOt2/eHqzCZVQNuK5byq77K", 0, "user6" },
                    { 7, "user7@example.com", "$2a$11$Bd9HYYBZdl3yLerQx1JzzOJ0FT2PsLFMsjS5y0n.UTtXHphYQ45VC", 0, "user7" },
                    { 8, "user8@example.com", "$2a$11$CU51KePvO7Ds21mqG63Q/.Nt59FPN66U4/dCn8fTv1SkptvGxl9/e", 0, "user8" },
                    { 9, "user9@example.com", "$2a$11$g/x3Ca3q98Zo.apJYxwbVOjNKlgpqEWVuI73EboyDvPSb9aErt7/y", 0, "user9" },
                    { 10, "user10@example.com", "$2a$11$x0EqjrOMor9zkfMR2KX2z.1jihYeTKrVED8iMqaW0jlWQE/ABXMJS", 0, "user10" },
                    { 11, "user11@example.com", "$2a$11$xPBHHgH//dC0g.ptigot4uyH1JW/F0L3QyvxRQjE68..VnSv5x7.i", 0, "user11" },
                    { 12, "user12@example.com", "$2a$11$SgclntCJLlZlRDz2Rzg99.FOy5KLW0bOh9czD9xG4LgD4VmZ.VB5O", 0, "user12" },
                    { 13, "user13@example.com", "$2a$11$wOL77T0ZmkTmfCV2WkZMlO6vwD9VHneY1xc5rbR9VCIOoh7.SbB2i", 0, "user13" },
                    { 14, "user14@example.com", "$2a$11$mT3cN1oeDJoQbtu/9mOZ.uRMZGIc05XmdTcLnWTr9o4LTDhFGkBxC", 0, "user14" },
                    { 15, "user15@example.com", "$2a$11$zel6kiiQslRIFFxBxXNfNeewMhexmHaPC6Su0nhClSGg2DB2Xjh4y", 0, "user15" },
                    { 16, "user16@example.com", "$2a$11$obH9D7LLCsgJyTMJsNyf6u9ECHqOXUSlNDNj6fKBFNKE3u.6mWzBS", 0, "user16" },
                    { 17, "user17@example.com", "$2a$11$Fibkc4KABgdickU7oMlO/.D9RB8WrO4arHjpd1NLSCEYN4O41FpGe", 0, "user17" },
                    { 18, "user18@example.com", "$2a$11$aavLyRe5BOcP1cEk5wTxEuB0rCdhBUQCC1.oJ.UzxWQTp5UCroJZ2", 0, "user18" },
                    { 19, "user19@example.com", "$2a$11$swsxWgwUntoYW6zZNXzMougizyXjisRryVqYrtT9YcoazwGIMIP6a", 0, "user19" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 20, "user20@example.com", "$2a$11$ZH.DNiu2Q720vTCUHkd29.aZ9lma5oG90.eMaxH7g1v1pp13ruRiq", 0, "user20" },
                    { 21, "user21@example.com", "$2a$11$s8erCVb.6xbbD1RmjZKYz.nHBWI3DHW/B6cb9thdsdDJbc6jO6gLS", 0, "user21" },
                    { 22, "user22@example.com", "$2a$11$f5znwGKlLrdKAMrrbnepPeVAGum1li.Bv8qk43SYND8ToSeqe/4OW", 0, "user22" },
                    { 23, "user23@example.com", "$2a$11$OyOkiO/7zb0/hqM3SLRSwOvJL4.ZpAGpqDvj0xcXDJZETkRaRHSBm", 0, "user23" },
                    { 24, "user24@example.com", "$2a$11$rU0V4oQ4C8PYDaBYpfNwoukJ5qlmgiApKwpav08IEYUxPzpxBmRd6", 0, "user24" },
                    { 25, "user25@example.com", "$2a$11$FogJqaoKaSxbfi.xrF.ne.2iIF2T6K3.SQdfPl6w0qOyLA2mJuFsC", 0, "user25" },
                    { 26, "user26@example.com", "$2a$11$c0moaSGDbKeuhmoh9C2OjewNsqxgnb0bdKGhO9UUz8q9LrLFzWciW", 0, "user26" },
                    { 27, "user27@example.com", "$2a$11$JlkGBf.3X1gGtdaX1FIDMe6RgZVHUE4bF.3RRk8g9juRydyi7DyQ2", 0, "user27" },
                    { 28, "user28@example.com", "$2a$11$vufvriXvKLI8c1GaedoRPuUW9MRxSyp5mn2gkpOZ4WsGx8nQ8MBUS", 0, "user28" },
                    { 29, "user29@example.com", "$2a$11$vJUs5Li02sLwG8YdfRGqy.fvplHV.o9zDDJI7pbwToGT8Fg3koPHS", 0, "user29" },
                    { 30, "user30@example.com", "$2a$11$yvTen6o7tevg.6FTJRpwHeqaK82IH1UIkML6fISzN6s.Kw/2Rjfy.", 0, "user30" },
                    { 31, "user31@example.com", "$2a$11$ynKdRW3.JmKy.tOB1KQO2e37tPAvda8u.74uJrTtmoP0rMik12iIK", 0, "user31" },
                    { 32, "user32@example.com", "$2a$11$Pe5LaBAo94qXpg925.eaj.lzk9wvWN.A2Fi7d5HcOXavx5T1MnpMW", 0, "user32" },
                    { 33, "user33@example.com", "$2a$11$lZ5rZkIBQF.FyLnN53C0GuujIjJPrCwFjtj4yMUq1MvTnMvZ0SOA6", 0, "user33" },
                    { 34, "user34@example.com", "$2a$11$C67tLYqb7PIh9RkHhT9sxu101dD8ePDr5kqmAIYdEhPmlzb5C/M7q", 0, "user34" },
                    { 35, "user35@example.com", "$2a$11$wx1CKKF.KWfA9pgakU76GePBpEnkStCLCYl494APoSJ.jAOCMJWwS", 0, "user35" },
                    { 36, "user36@example.com", "$2a$11$eTw.VvkfdDLf1ZL0xK49feyUQ.wq7H/mf59M1b.hikRoMC3inC3X.", 0, "user36" },
                    { 37, "user37@example.com", "$2a$11$lGuwE63CsIjtSvRjCZkZX.Em6ARbAcqTK8qAxmt2yj7Zmfu9v0q2q", 0, "user37" },
                    { 38, "user38@example.com", "$2a$11$WUT/CvI.kZyu4eV3IC4p4umMrJBZHWoSRSLDAb7AD2TmekYbQBx4a", 0, "user38" },
                    { 39, "user39@example.com", "$2a$11$JUO2ZN5dY9tbEJHF/e/xvuhIspkoGXXYBaqwQ2Z900oVveXKSeZ3e", 0, "user39" },
                    { 40, "user40@example.com", "$2a$11$AWRdUGm55eSzFKmTQz3ugOmm7g15znZLRqvMPq1.XBN2MEgoAvmSi", 0, "user40" },
                    { 41, "user41@example.com", "$2a$11$z/yZnBVN3.xIUPBR/hlZvOHtK6ZWBzB5ZA1gmFArHEvLE1q9eNoY6", 0, "user41" },
                    { 42, "user42@example.com", "$2a$11$ENRFXV2EeeaRRElGUo/acuEerNDoDuRQhLKJSgGluW/9hIqkw.4j2", 0, "user42" },
                    { 43, "user43@example.com", "$2a$11$jOFDUKnPmKPzbiJdVyAFEefSAid5o.eHoj0lZB.cMVdnXRb3dKlbK", 0, "user43" },
                    { 44, "user44@example.com", "$2a$11$y.zrWZwZDUpKGagSASpTEuTQMh.3qW4/llFuqdJfuOYQs.M8Lsj3C", 0, "user44" },
                    { 45, "user45@example.com", "$2a$11$HVCg9dko7L2mbACOpdQ8vOwltl7RX4abo2mEAEzoDGG0HbKOxS9gq", 0, "user45" },
                    { 46, "user46@example.com", "$2a$11$zxZvTKlJ2rXtdFmYgWZU0.1gIVdWCMRKCkHRpuYoZEfu7idMvAgtK", 0, "user46" },
                    { 47, "user47@example.com", "$2a$11$3IsSatVDqLd/kPOerPAnDeQtnjjydIrecrbwH1TSfxa/z3GHSzilu", 0, "user47" },
                    { 48, "user48@example.com", "$2a$11$HwraM4ohISY0k7S31r9PJuUfHvpZionTqm7fwFlZe21Dk24c.oP6m", 0, "user48" },
                    { 49, "user49@example.com", "$2a$11$DeblsZkX8V7lTPJ5L72JhOzj.PHNmDMzdNJVIK88jviMUIcRhVP.y", 0, "user49" },
                    { 50, "user50@example.com", "$2a$11$50VzcA47Nhdv221357Wi7uWPy0LZVVaU8Jl7L.5IwofSBSRxKoKQC", 0, "user50" },
                    { 51, "user51@example.com", "$2a$11$Ca/YF30W7.1I6IBcpUh3AOZNsEsE4M0RP0SiRK5gd0MCt2i451g1y", 0, "user51" },
                    { 52, "user52@example.com", "$2a$11$r0F/zcTzW7JVnIeitmK4UuaU/WO/e9K83iqWA3B20py.T3YrQ3PwK", 0, "user52" },
                    { 53, "user53@example.com", "$2a$11$vhOcRP.5327tN6DlPs.mGuXqeuGYmuKEmPYlG0OvCD2C8Y.OCjiQO", 0, "user53" },
                    { 54, "user54@example.com", "$2a$11$nQRWZP19c2fkdgTmLeK0y.0dqb9nLJLqI0PXq3xOBLD//KAb3voYu", 0, "user54" },
                    { 55, "user55@example.com", "$2a$11$dgASqrnirW0N.PE.Wk67Ye3jlWr4JtxuvQgToK9tNqFMMAAUUtXBS", 0, "user55" },
                    { 56, "user56@example.com", "$2a$11$tyfsCoCabog.COBgvMgIwuFTHhffz9BewlfRoZt78u7gGEP9Kbko.", 0, "user56" },
                    { 57, "user57@example.com", "$2a$11$xrn2b7bM7lwDueVp5Ssdl.UEUA5H9vmLhFwE24QRxzIDq43clpKSi", 0, "user57" },
                    { 58, "user58@example.com", "$2a$11$RWboT6qoXbIgU1qcZoHMyeRlHBUz6I.B91bnjijN0BA7IGlaD7oLC", 0, "user58" },
                    { 59, "user59@example.com", "$2a$11$oqYxF1E1A4aDqeXIPuBmVOBksFqBtCPJiGfuPRJxTbJCOPUaJfIU6", 0, "user59" },
                    { 60, "user60@example.com", "$2a$11$vBGdo8mjXYBEDafO7zyKmOms7UVEpi2IDE6S8LoNLgY7zj5KOu2H.", 0, "user60" },
                    { 61, "user61@example.com", "$2a$11$5uZLCbl7okKPVKQsTc0Q7.OIoBeFgyi3fVMcVnJpWzYIZIQvjBoFq", 0, "user61" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 62, "user62@example.com", "$2a$11$DTSEuHfyQd/IrkK6fmYYe.Cbx5tG1xGczuarvVHeoVWT6Eh1qIiHy", 0, "user62" },
                    { 63, "user63@example.com", "$2a$11$cW5DJFTRckwCPBeRfimSge31gGtc.yu7T.MzUt82FsUeOZk4xVfna", 0, "user63" },
                    { 64, "user64@example.com", "$2a$11$svs2ll2q7ehfTuWIlORLweOwsExHuJxLYvdH1PXzCfN3APD1z14ou", 0, "user64" },
                    { 65, "user65@example.com", "$2a$11$BLAY95cyPRCvXHURj7A2ReN0ZqMMGSMu.XGxNHKvRQVUGvl6pY266", 0, "user65" },
                    { 66, "user66@example.com", "$2a$11$KIeTtGCLV07p6hErIRNpDuY9ejuoqBCdl3Kc5hDgFm6cCTkPX.kxW", 0, "user66" },
                    { 67, "user67@example.com", "$2a$11$meNF9ehDsZgM0MDEfG5PPOxs1VtNnGbUQ9LI7IAQFaKQrCFahsQDC", 0, "user67" },
                    { 68, "user68@example.com", "$2a$11$c4U7S9ZBl2ZL1Jp/kgEx3OnYiQva8DkiC2xXXH221WuFCGeIqYfYG", 0, "user68" },
                    { 69, "user69@example.com", "$2a$11$3J6nL56cYKJmBqj7vToQYeKSEtQIUASLMA1JL.oX911V7AxaGNXW.", 0, "user69" },
                    { 70, "user70@example.com", "$2a$11$8bIHnkBP1xy2HcUeiqvXQOIIpeZOih641IS5NKwG3M0Sw0Lhctxse", 0, "user70" },
                    { 71, "user71@example.com", "$2a$11$u1Jz2cnTDh.hiCFhlUvqf.ti4ix1OLx1eiJvR1tdoffTfKEzghDny", 0, "user71" },
                    { 72, "user72@example.com", "$2a$11$IusqEZTdCd.pbtFqqbSZbejPLqTE/YecIIci4HOjit0ptt21q5LCm", 0, "user72" },
                    { 73, "user73@example.com", "$2a$11$VcMsgmuJ2jFJphgRaKgBUuFa8sbCJydaGyNqR63nTCv/2tJ2VBo0e", 0, "user73" },
                    { 74, "user74@example.com", "$2a$11$WZMKVj1gbN4r5t.MEYkuP.MNlyU3knwsNRm8TKhyraUBB34Vd9svm", 0, "user74" },
                    { 75, "user75@example.com", "$2a$11$CanY7WU5Tz0d3ukYmOHSD.TQQ7ks60jBdhKJpPTNqyW7whtnayVwC", 0, "user75" },
                    { 76, "user76@example.com", "$2a$11$ZZVONSaNxyi5Duuh2dUKHeUB1vhlsQopI1UqdsajEx5I/bwDK5Ox.", 0, "user76" },
                    { 77, "user77@example.com", "$2a$11$ItJz7et1VI1zth5d90A18uV4dXX5DIFatkgZGG3kfqZsF52XvRrKu", 0, "user77" },
                    { 78, "user78@example.com", "$2a$11$6hdw3CEU9Q3Wy/rWM/viUOSwNnn21W8v63Pzhro2/5173XCMQfk/m", 0, "user78" },
                    { 79, "user79@example.com", "$2a$11$D69ePxj5M4EQ.D1gj97Zquxc2lOQTBfOdqlZKmJiAwi6Aolgr.vhW", 0, "user79" },
                    { 80, "user80@example.com", "$2a$11$NSthit/AAXmUDPTBU6esGObqteBHpNNXKQvNNjTxTCXt.rZahOchC", 0, "user80" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "Address", "CityId", "CreationDate", "Description", "DiscountRate", "Latitude", "Longitude", "ModificationDate", "Name", "Owner", "Price", "StarRating", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown, USA", 7, new DateTime(2024, 5, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3190), "Description for Hotel1", 0.51800916370018768, -70.439336725955172, 137.72714571923478, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3255), "Hotel1", "Owner1", 230.81386462086311, 5, "http://example.com/hotel1.jpg" },
                    { 2, "123 Main St, Anytown, USA", 9, new DateTime(2024, 5, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3270), "Description for Hotel2", 0.83456937422949695, -88.700073196745905, 27.641840043648557, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3274), "Hotel2", "Owner2", 99.756606990229756, 1, "http://example.com/hotel2.jpg" },
                    { 3, "123 Main St, Anytown, USA", 3, new DateTime(2024, 4, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3280), "Description for Hotel3", 0.73059229932662673, 84.149020346504358, -29.24468022526969, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3294), "Hotel3", "Owner3", 127.85671113607444, 5, "http://example.com/hotel3.jpg" },
                    { 4, "123 Main St, Anytown, USA", 4, new DateTime(2024, 4, 22, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3304), "Description for Hotel4", 0.77491460176010285, -76.625280045603759, 125.2818515222732, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3306), "Hotel4", "Owner4", 150.61349151895143, 1, "http://example.com/hotel4.jpg" },
                    { 5, "123 Main St, Anytown, USA", 9, new DateTime(2024, 5, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3312), "Description for Hotel5", 0.96125752159977262, -32.019957000546597, 92.854438132909479, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3315), "Hotel5", "Owner5", 276.52206586158951, 1, "http://example.com/hotel5.jpg" },
                    { 6, "123 Main St, Anytown, USA", 9, new DateTime(2024, 5, 9, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3325), "Description for Hotel6", 0.54535261432020521, 63.638012111467219, -157.94276708102271, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3328), "Hotel6", "Owner6", 205.70127874252591, 5, "http://example.com/hotel6.jpg" },
                    { 7, "123 Main St, Anytown, USA", 8, new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3433), "Description for Hotel7", 0.61189041163997759, -53.536610406593915, 128.55821894248635, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3437), "Hotel7", "Owner7", 114.49929451949326, 1, "http://example.com/hotel7.jpg" },
                    { 8, "123 Main St, Anytown, USA", 2, new DateTime(2024, 5, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3451), "Description for Hotel8", 0.80106268963288862, 47.112183870707838, -110.30214237190222, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3463), "Hotel8", "Owner8", 9.4856092397786469, 2, "http://example.com/hotel8.jpg" },
                    { 9, "123 Main St, Anytown, USA", 7, new DateTime(2024, 7, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3469), "Description for Hotel9", 0.13951564440923647, 9.8017952066179674, 178.36302168744669, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3471), "Hotel9", "Owner9", 171.88863890104582, 2, "http://example.com/hotel9.jpg" },
                    { 10, "123 Main St, Anytown, USA", 10, new DateTime(2024, 4, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3478), "Description for Hotel10", 0.69927088719245767, -41.308264067045364, 109.83943793419957, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3480), "Hotel10", "Owner10", 69.727039973705331, 2, "http://example.com/hotel10.jpg" },
                    { 11, "123 Main St, Anytown, USA", 8, new DateTime(2024, 5, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3487), "Description for Hotel11", 0.63202663618148924, 16.839524176180461, -27.789948449285703, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3489), "Hotel11", "Owner11", 269.75676590491588, 4, "http://example.com/hotel11.jpg" },
                    { 12, "123 Main St, Anytown, USA", 2, new DateTime(2024, 4, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3495), "Description for Hotel12", 0.051799024184220666, -65.592177220225949, -115.43894827135603, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3497), "Hotel12", "Owner12", 483.97925897405941, 2, "http://example.com/hotel12.jpg" },
                    { 13, "123 Main St, Anytown, USA", 8, new DateTime(2024, 5, 22, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3503), "Description for Hotel13", 0.19797544901315511, 51.842153747510054, 6.4663605961847566, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3505), "Hotel13", "Owner13", 315.73447339567412, 2, "http://example.com/hotel13.jpg" },
                    { 14, "123 Main St, Anytown, USA", 4, new DateTime(2024, 6, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3511), "Description for Hotel14", 0.69369800064159981, -88.125832182072898, 79.876003077496989, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3513), "Hotel14", "Owner14", 23.878188511227584, 3, "http://example.com/hotel14.jpg" },
                    { 15, "123 Main St, Anytown, USA", 3, new DateTime(2024, 7, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3519), "Description for Hotel15", 0.43675578537710413, 56.546412203729773, -115.15436606221195, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3525), "Hotel15", "Owner15", 131.93578953401237, 2, "http://example.com/hotel15.jpg" },
                    { 16, "123 Main St, Anytown, USA", 4, new DateTime(2024, 6, 9, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3564), "Description for Hotel16", 0.95293347540964124, 87.594757045810269, -80.758759312332614, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3567), "Hotel16", "Owner16", 222.39006461050408, 5, "http://example.com/hotel16.jpg" },
                    { 17, "123 Main St, Anytown, USA", 2, new DateTime(2024, 5, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3573), "Description for Hotel17", 0.2913080232182268, -69.297410177451084, 117.8403952791096, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3575), "Hotel17", "Owner17", 186.05260584200889, 3, "http://example.com/hotel17.jpg" },
                    { 18, "123 Main St, Anytown, USA", 6, new DateTime(2024, 6, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3582), "Description for Hotel18", 0.73052319313963388, 37.770066335471768, -135.53134762588797, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3584), "Hotel18", "Owner18", 340.93063747378159, 1, "http://example.com/hotel18.jpg" },
                    { 19, "123 Main St, Anytown, USA", 7, new DateTime(2024, 6, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3590), "Description for Hotel19", 0.51444291981491708, -17.516400053564482, -175.22640107903121, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3592), "Hotel19", "Owner19", 85.857574747046087, 3, "http://example.com/hotel19.jpg" },
                    { 20, "123 Main St, Anytown, USA", 6, new DateTime(2024, 5, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3598), "Description for Hotel20", 0.69764130578728811, 69.762549018097559, -27.332834603227838, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(3600), "Hotel20", "Owner20", 335.17699829805349, 1, "http://example.com/hotel20.jpg" }
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
                    { 6, 3, "http://example.com/hotel3_image1.jpg" },
                    { 7, 3, "http://example.com/hotel3_image2.jpg" },
                    { 8, 4, "http://example.com/hotel4_image1.jpg" },
                    { 9, 4, "http://example.com/hotel4_image2.jpg" },
                    { 10, 5, "http://example.com/hotel5_image1.jpg" },
                    { 11, 5, "http://example.com/hotel5_image2.jpg" },
                    { 12, 5, "http://example.com/hotel5_image3.jpg" },
                    { 13, 6, "http://example.com/hotel6_image1.jpg" },
                    { 14, 7, "http://example.com/hotel7_image1.jpg" },
                    { 15, 7, "http://example.com/hotel7_image2.jpg" },
                    { 16, 7, "http://example.com/hotel7_image3.jpg" },
                    { 17, 7, "http://example.com/hotel7_image4.jpg" },
                    { 18, 8, "http://example.com/hotel8_image1.jpg" },
                    { 19, 8, "http://example.com/hotel8_image2.jpg" },
                    { 20, 9, "http://example.com/hotel9_image1.jpg" },
                    { 21, 9, "http://example.com/hotel9_image2.jpg" },
                    { 22, 10, "http://example.com/hotel10_image1.jpg" },
                    { 23, 11, "http://example.com/hotel11_image1.jpg" },
                    { 24, 12, "http://example.com/hotel12_image1.jpg" },
                    { 25, 13, "http://example.com/hotel13_image1.jpg" },
                    { 26, 13, "http://example.com/hotel13_image2.jpg" },
                    { 27, 13, "http://example.com/hotel13_image3.jpg" },
                    { 28, 13, "http://example.com/hotel13_image4.jpg" },
                    { 29, 14, "http://example.com/hotel14_image1.jpg" },
                    { 30, 14, "http://example.com/hotel14_image2.jpg" },
                    { 31, 14, "http://example.com/hotel14_image3.jpg" },
                    { 32, 15, "http://example.com/hotel15_image1.jpg" },
                    { 33, 16, "http://example.com/hotel16_image1.jpg" },
                    { 34, 16, "http://example.com/hotel16_image2.jpg" },
                    { 35, 16, "http://example.com/hotel16_image3.jpg" },
                    { 36, 16, "http://example.com/hotel16_image4.jpg" },
                    { 37, 17, "http://example.com/hotel17_image1.jpg" },
                    { 38, 17, "http://example.com/hotel17_image2.jpg" },
                    { 39, 17, "http://example.com/hotel17_image3.jpg" },
                    { 40, 18, "http://example.com/hotel18_image1.jpg" },
                    { 41, 18, "http://example.com/hotel18_image2.jpg" },
                    { 42, 19, "http://example.com/hotel19_image1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HotelImage",
                columns: new[] { "ImageId", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 43, 19, "http://example.com/hotel19_image2.jpg" },
                    { 44, 19, "http://example.com/hotel19_image3.jpg" },
                    { 45, 20, "http://example.com/hotel20_image1.jpg" },
                    { 46, 20, "http://example.com/hotel20_image2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 1, 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 25, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7306), 8 },
                    { 2, 20, "This is a review content for Hotel 20", new DateTime(2024, 5, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7331), 49 },
                    { 3, 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7335), 71 },
                    { 4, 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7338), 16 },
                    { 5, 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7343), 77 },
                    { 6, 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7347), 42 },
                    { 7, 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 26, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7350), 35 },
                    { 8, 3, "This is a review content for Hotel 3", new DateTime(2023, 10, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7354), 44 },
                    { 9, 9, "This is a review content for Hotel 9", new DateTime(2024, 4, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7408), 30 },
                    { 10, 4, "This is a review content for Hotel 4", new DateTime(2023, 9, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7412), 78 },
                    { 11, 4, "This is a review content for Hotel 4", new DateTime(2023, 8, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7418), 72 },
                    { 12, 15, "This is a review content for Hotel 15", new DateTime(2023, 7, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7422), 23 },
                    { 13, 10, "This is a review content for Hotel 10", new DateTime(2023, 11, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7426), 7 },
                    { 14, 14, "This is a review content for Hotel 14", new DateTime(2023, 10, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7429), 53 },
                    { 15, 11, "This is a review content for Hotel 11", new DateTime(2023, 10, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7432), 36 },
                    { 16, 17, "This is a review content for Hotel 17", new DateTime(2024, 7, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7435), 59 },
                    { 17, 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7439), 26 },
                    { 18, 3, "This is a review content for Hotel 3", new DateTime(2023, 10, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7443), 30 },
                    { 19, 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7446), 9 },
                    { 20, 20, "This is a review content for Hotel 20", new DateTime(2024, 6, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7450), 36 },
                    { 21, 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7453), 63 },
                    { 22, 6, "This is a review content for Hotel 6", new DateTime(2023, 7, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7456), 32 },
                    { 23, 16, "This is a review content for Hotel 16", new DateTime(2024, 2, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7460), 62 },
                    { 24, 19, "This is a review content for Hotel 19", new DateTime(2024, 5, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7463), 72 },
                    { 25, 1, "This is a review content for Hotel 1", new DateTime(2023, 11, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7467), 70 },
                    { 26, 10, "This is a review content for Hotel 10", new DateTime(2023, 12, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7470), 65 },
                    { 27, 7, "This is a review content for Hotel 7", new DateTime(2024, 6, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7473), 71 },
                    { 28, 3, "This is a review content for Hotel 3", new DateTime(2023, 7, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7477), 25 },
                    { 29, 6, "This is a review content for Hotel 6", new DateTime(2023, 8, 18, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7480), 24 },
                    { 30, 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7484), 65 },
                    { 31, 15, "This is a review content for Hotel 15", new DateTime(2024, 2, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7487), 44 },
                    { 32, 16, "This is a review content for Hotel 16", new DateTime(2023, 8, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7490), 10 },
                    { 33, 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7494), 69 },
                    { 34, 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7498), 60 },
                    { 35, 12, "This is a review content for Hotel 12", new DateTime(2023, 10, 25, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7501), 29 },
                    { 36, 9, "This is a review content for Hotel 9", new DateTime(2023, 8, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7505), 31 },
                    { 37, 15, "This is a review content for Hotel 15", new DateTime(2023, 8, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7508), 30 },
                    { 38, 6, "This is a review content for Hotel 6", new DateTime(2024, 5, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7511), 53 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 39, 13, "This is a review content for Hotel 13", new DateTime(2023, 9, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7515), 69 },
                    { 40, 9, "This is a review content for Hotel 9", new DateTime(2024, 6, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7518), 23 },
                    { 41, 6, "This is a review content for Hotel 6", new DateTime(2023, 7, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7521), 31 },
                    { 42, 11, "This is a review content for Hotel 11", new DateTime(2023, 11, 22, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7524), 33 },
                    { 43, 19, "This is a review content for Hotel 19", new DateTime(2024, 5, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7528), 57 },
                    { 44, 11, "This is a review content for Hotel 11", new DateTime(2023, 7, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7531), 76 },
                    { 45, 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7535), 50 },
                    { 46, 6, "This is a review content for Hotel 6", new DateTime(2023, 7, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7538), 74 },
                    { 47, 3, "This is a review content for Hotel 3", new DateTime(2024, 7, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7542), 66 },
                    { 48, 17, "This is a review content for Hotel 17", new DateTime(2023, 11, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7545), 47 },
                    { 49, 7, "This is a review content for Hotel 7", new DateTime(2023, 9, 22, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7549), 65 },
                    { 50, 16, "This is a review content for Hotel 16", new DateTime(2024, 5, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7552), 73 },
                    { 51, 14, "This is a review content for Hotel 14", new DateTime(2023, 12, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7555), 30 },
                    { 52, 2, "This is a review content for Hotel 2", new DateTime(2024, 5, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7559), 19 },
                    { 53, 19, "This is a review content for Hotel 19", new DateTime(2024, 5, 18, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7562), 58 },
                    { 54, 11, "This is a review content for Hotel 11", new DateTime(2024, 4, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7605), 57 },
                    { 55, 7, "This is a review content for Hotel 7", new DateTime(2024, 4, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7609), 43 },
                    { 56, 12, "This is a review content for Hotel 12", new DateTime(2023, 8, 6, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7612), 67 },
                    { 57, 20, "This is a review content for Hotel 20", new DateTime(2024, 3, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7616), 74 },
                    { 58, 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7620), 9 },
                    { 59, 16, "This is a review content for Hotel 16", new DateTime(2023, 9, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7623), 30 },
                    { 60, 10, "This is a review content for Hotel 10", new DateTime(2023, 8, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7626), 56 },
                    { 61, 20, "This is a review content for Hotel 20", new DateTime(2024, 6, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7630), 53 },
                    { 62, 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7633), 40 },
                    { 63, 16, "This is a review content for Hotel 16", new DateTime(2023, 11, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7637), 73 },
                    { 64, 20, "This is a review content for Hotel 20", new DateTime(2023, 11, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7640), 5 },
                    { 65, 18, "This is a review content for Hotel 18", new DateTime(2024, 5, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7644), 29 },
                    { 66, 14, "This is a review content for Hotel 14", new DateTime(2023, 9, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7648), 23 },
                    { 67, 9, "This is a review content for Hotel 9", new DateTime(2024, 7, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7651), 70 },
                    { 68, 13, "This is a review content for Hotel 13", new DateTime(2024, 5, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7655), 53 },
                    { 69, 7, "This is a review content for Hotel 7", new DateTime(2024, 7, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7659), 49 },
                    { 70, 14, "This is a review content for Hotel 14", new DateTime(2024, 1, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7662), 48 },
                    { 71, 4, "This is a review content for Hotel 4", new DateTime(2024, 5, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7666), 6 },
                    { 72, 15, "This is a review content for Hotel 15", new DateTime(2024, 1, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7669), 55 },
                    { 73, 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 6, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7672), 31 },
                    { 74, 6, "This is a review content for Hotel 6", new DateTime(2023, 8, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7676), 70 },
                    { 75, 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7679), 49 },
                    { 76, 4, "This is a review content for Hotel 4", new DateTime(2024, 1, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7682), 74 },
                    { 77, 8, "This is a review content for Hotel 8", new DateTime(2024, 6, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7686), 46 },
                    { 78, 5, "This is a review content for Hotel 5", new DateTime(2024, 2, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7690), 62 },
                    { 79, 1, "This is a review content for Hotel 1", new DateTime(2024, 6, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7693), 29 },
                    { 80, 10, "This is a review content for Hotel 10", new DateTime(2024, 4, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7697), 43 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 81, 17, "This is a review content for Hotel 17", new DateTime(2023, 10, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7700), 37 },
                    { 82, 15, "This is a review content for Hotel 15", new DateTime(2024, 6, 18, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7704), 67 },
                    { 83, 12, "This is a review content for Hotel 12", new DateTime(2024, 5, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7707), 75 },
                    { 84, 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7710), 34 },
                    { 85, 19, "This is a review content for Hotel 19", new DateTime(2023, 11, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7714), 73 },
                    { 86, 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7717), 51 },
                    { 87, 16, "This is a review content for Hotel 16", new DateTime(2024, 7, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7720), 20 },
                    { 88, 3, "This is a review content for Hotel 3", new DateTime(2023, 8, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7724), 32 },
                    { 89, 5, "This is a review content for Hotel 5", new DateTime(2024, 1, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7727), 49 },
                    { 90, 2, "This is a review content for Hotel 2", new DateTime(2023, 10, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7731), 41 },
                    { 91, 18, "This is a review content for Hotel 18", new DateTime(2023, 11, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7734), 55 },
                    { 92, 10, "This is a review content for Hotel 10", new DateTime(2024, 1, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7738), 52 },
                    { 93, 2, "This is a review content for Hotel 2", new DateTime(2023, 11, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7741), 54 },
                    { 94, 9, "This is a review content for Hotel 9", new DateTime(2023, 7, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7745), 33 },
                    { 95, 12, "This is a review content for Hotel 12", new DateTime(2023, 10, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7748), 48 },
                    { 96, 10, "This is a review content for Hotel 10", new DateTime(2024, 2, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7752), 52 },
                    { 97, 1, "This is a review content for Hotel 1", new DateTime(2023, 10, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7755), 77 },
                    { 98, 2, "This is a review content for Hotel 2", new DateTime(2024, 3, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7797), 30 },
                    { 99, 13, "This is a review content for Hotel 13", new DateTime(2023, 9, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7801), 9 },
                    { 100, 10, "This is a review content for Hotel 10", new DateTime(2023, 11, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7804), 60 },
                    { 101, 4, "This is a review content for Hotel 4", new DateTime(2024, 7, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7808), 16 },
                    { 102, 3, "This is a review content for Hotel 3", new DateTime(2023, 11, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7812), 77 },
                    { 103, 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7815), 67 },
                    { 104, 14, "This is a review content for Hotel 14", new DateTime(2024, 6, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7819), 67 },
                    { 105, 2, "This is a review content for Hotel 2", new DateTime(2024, 6, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7822), 11 },
                    { 106, 13, "This is a review content for Hotel 13", new DateTime(2024, 6, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7825), 30 },
                    { 107, 7, "This is a review content for Hotel 7", new DateTime(2024, 4, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7829), 4 },
                    { 108, 10, "This is a review content for Hotel 10", new DateTime(2024, 7, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7832), 59 },
                    { 109, 3, "This is a review content for Hotel 3", new DateTime(2024, 3, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7836), 17 },
                    { 110, 11, "This is a review content for Hotel 11", new DateTime(2023, 8, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7839), 74 },
                    { 111, 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7843), 13 },
                    { 112, 18, "This is a review content for Hotel 18", new DateTime(2023, 9, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7846), 43 },
                    { 113, 17, "This is a review content for Hotel 17", new DateTime(2023, 9, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7849), 67 },
                    { 114, 16, "This is a review content for Hotel 16", new DateTime(2024, 2, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7853), 68 },
                    { 115, 19, "This is a review content for Hotel 19", new DateTime(2023, 8, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7856), 51 },
                    { 116, 15, "This is a review content for Hotel 15", new DateTime(2023, 8, 19, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7860), 45 },
                    { 117, 12, "This is a review content for Hotel 12", new DateTime(2024, 7, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7863), 30 },
                    { 118, 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7866), 45 },
                    { 119, 6, "This is a review content for Hotel 6", new DateTime(2023, 7, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7870), 43 },
                    { 120, 5, "This is a review content for Hotel 5", new DateTime(2024, 7, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7873), 48 },
                    { 121, 14, "This is a review content for Hotel 14", new DateTime(2024, 2, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7877), 33 },
                    { 122, 5, "This is a review content for Hotel 5", new DateTime(2024, 5, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7880), 56 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 123, 14, "This is a review content for Hotel 14", new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7884), 20 },
                    { 124, 17, "This is a review content for Hotel 17", new DateTime(2023, 7, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7888), 67 },
                    { 125, 20, "This is a review content for Hotel 20", new DateTime(2024, 4, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7891), 28 },
                    { 126, 16, "This is a review content for Hotel 16", new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7895), 43 },
                    { 127, 3, "This is a review content for Hotel 3", new DateTime(2024, 6, 9, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7898), 26 },
                    { 128, 4, "This is a review content for Hotel 4", new DateTime(2024, 3, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7902), 27 },
                    { 129, 10, "This is a review content for Hotel 10", new DateTime(2024, 5, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7905), 41 },
                    { 130, 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7910), 42 },
                    { 131, 9, "This is a review content for Hotel 9", new DateTime(2024, 3, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7913), 69 },
                    { 132, 18, "This is a review content for Hotel 18", new DateTime(2024, 6, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7917), 10 },
                    { 133, 8, "This is a review content for Hotel 8", new DateTime(2024, 5, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7920), 57 },
                    { 134, 5, "This is a review content for Hotel 5", new DateTime(2024, 4, 19, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7923), 74 },
                    { 135, 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(7927), 19 },
                    { 136, 20, "This is a review content for Hotel 20", new DateTime(2024, 3, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8002), 35 },
                    { 137, 11, "This is a review content for Hotel 11", new DateTime(2024, 2, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8007), 31 },
                    { 138, 3, "This is a review content for Hotel 3", new DateTime(2024, 6, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8010), 29 },
                    { 139, 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8014), 75 },
                    { 140, 20, "This is a review content for Hotel 20", new DateTime(2023, 8, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8017), 8 },
                    { 141, 18, "This is a review content for Hotel 18", new DateTime(2024, 1, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8021), 13 },
                    { 142, 12, "This is a review content for Hotel 12", new DateTime(2024, 6, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8024), 71 },
                    { 143, 19, "This is a review content for Hotel 19", new DateTime(2024, 6, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8027), 24 },
                    { 144, 10, "This is a review content for Hotel 10", new DateTime(2024, 4, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8030), 39 },
                    { 145, 3, "This is a review content for Hotel 3", new DateTime(2023, 10, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8034), 8 },
                    { 146, 6, "This is a review content for Hotel 6", new DateTime(2024, 3, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8037), 77 },
                    { 147, 19, "This is a review content for Hotel 19", new DateTime(2024, 3, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8040), 69 },
                    { 148, 9, "This is a review content for Hotel 9", new DateTime(2024, 3, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8044), 61 },
                    { 149, 9, "This is a review content for Hotel 9", new DateTime(2024, 7, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8047), 23 },
                    { 150, 15, "This is a review content for Hotel 15", new DateTime(2024, 3, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8050), 35 },
                    { 151, 16, "This is a review content for Hotel 16", new DateTime(2023, 10, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8054), 14 },
                    { 152, 6, "This is a review content for Hotel 6", new DateTime(2024, 2, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8057), 48 },
                    { 153, 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8061), 28 },
                    { 154, 2, "This is a review content for Hotel 2", new DateTime(2024, 2, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8064), 78 },
                    { 155, 6, "This is a review content for Hotel 6", new DateTime(2024, 1, 26, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8067), 75 },
                    { 156, 5, "This is a review content for Hotel 5", new DateTime(2024, 3, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8071), 27 },
                    { 157, 14, "This is a review content for Hotel 14", new DateTime(2023, 11, 26, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8074), 10 },
                    { 158, 11, "This is a review content for Hotel 11", new DateTime(2024, 1, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8078), 29 },
                    { 159, 19, "This is a review content for Hotel 19", new DateTime(2024, 3, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8081), 57 },
                    { 160, 8, "This is a review content for Hotel 8", new DateTime(2024, 5, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8084), 30 },
                    { 161, 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8088), 35 },
                    { 162, 1, "This is a review content for Hotel 1", new DateTime(2023, 12, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8091), 10 },
                    { 163, 7, "This is a review content for Hotel 7", new DateTime(2024, 1, 18, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8094), 12 },
                    { 164, 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8098), 28 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "HotelId", "ReviewContent", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 165, 13, "This is a review content for Hotel 13", new DateTime(2023, 7, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8102), 74 },
                    { 166, 14, "This is a review content for Hotel 14", new DateTime(2023, 12, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8105), 10 },
                    { 167, 10, "This is a review content for Hotel 10", new DateTime(2023, 12, 31, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8108), 13 },
                    { 168, 11, "This is a review content for Hotel 11", new DateTime(2023, 9, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8111), 34 },
                    { 169, 12, "This is a review content for Hotel 12", new DateTime(2024, 4, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8115), 40 },
                    { 170, 1, "This is a review content for Hotel 1", new DateTime(2023, 9, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8118), 73 },
                    { 171, 20, "This is a review content for Hotel 20", new DateTime(2023, 10, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8121), 60 },
                    { 172, 20, "This is a review content for Hotel 20", new DateTime(2024, 2, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8125), 80 },
                    { 173, 15, "This is a review content for Hotel 15", new DateTime(2023, 9, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8128), 75 },
                    { 174, 14, "This is a review content for Hotel 14", new DateTime(2024, 7, 6, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8131), 27 },
                    { 175, 7, "This is a review content for Hotel 7", new DateTime(2024, 3, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8135), 6 },
                    { 176, 17, "This is a review content for Hotel 17", new DateTime(2024, 6, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8138), 27 },
                    { 177, 20, "This is a review content for Hotel 20", new DateTime(2023, 8, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8141), 26 },
                    { 178, 5, "This is a review content for Hotel 5", new DateTime(2023, 9, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8145), 21 },
                    { 179, 7, "This is a review content for Hotel 7", new DateTime(2023, 10, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8148), 48 },
                    { 180, 20, "This is a review content for Hotel 20", new DateTime(2024, 6, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8151), 27 },
                    { 181, 1, "This is a review content for Hotel 1", new DateTime(2023, 7, 19, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8154), 45 },
                    { 182, 17, "This is a review content for Hotel 17", new DateTime(2024, 1, 22, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8158), 78 },
                    { 183, 15, "This is a review content for Hotel 15", new DateTime(2024, 5, 26, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8161), 27 },
                    { 184, 7, "This is a review content for Hotel 7", new DateTime(2023, 8, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8165), 56 },
                    { 185, 13, "This is a review content for Hotel 13", new DateTime(2024, 5, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8168), 75 },
                    { 186, 12, "This is a review content for Hotel 12", new DateTime(2023, 10, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8171), 17 },
                    { 187, 2, "This is a review content for Hotel 2", new DateTime(2024, 4, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8213), 40 },
                    { 188, 1, "This is a review content for Hotel 1", new DateTime(2024, 6, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8216), 54 },
                    { 189, 15, "This is a review content for Hotel 15", new DateTime(2024, 6, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8220), 33 },
                    { 190, 9, "This is a review content for Hotel 9", new DateTime(2024, 1, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8223), 66 },
                    { 191, 16, "This is a review content for Hotel 16", new DateTime(2024, 2, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8226), 59 },
                    { 192, 14, "This is a review content for Hotel 14", new DateTime(2024, 4, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8230), 32 },
                    { 193, 15, "This is a review content for Hotel 15", new DateTime(2024, 7, 3, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8233), 28 },
                    { 194, 7, "This is a review content for Hotel 7", new DateTime(2024, 7, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8237), 78 },
                    { 195, 7, "This is a review content for Hotel 7", new DateTime(2023, 12, 19, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8240), 16 },
                    { 196, 7, "This is a review content for Hotel 7", new DateTime(2024, 5, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8244), 11 },
                    { 197, 5, "This is a review content for Hotel 5", new DateTime(2023, 11, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8247), 68 },
                    { 198, 10, "This is a review content for Hotel 10", new DateTime(2024, 5, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8250), 78 },
                    { 199, 4, "This is a review content for Hotel 4", new DateTime(2023, 9, 9, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8253), 30 },
                    { 200, 8, "This is a review content for Hotel 8", new DateTime(2023, 10, 10, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(8257), 66 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTime(2024, 6, 23, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9247), "Description for Room1", 14, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9259), 1, 246m, 3, "http://example.com/room1.jpg" },
                    { 2, 3, 0, new DateTime(2024, 5, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9273), "Description for Room2", 1, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9275), 2, 322m, 1, "http://example.com/room2.jpg" },
                    { 3, 1, 1, new DateTime(2024, 4, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9280), "Description for Room3", 14, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9282), 3, 226m, 3, "http://example.com/room3.jpg" },
                    { 4, 1, 0, new DateTime(2024, 5, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9286), "Description for Room4", 9, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9288), 4, 402m, 1, "http://example.com/room4.jpg" },
                    { 5, 1, 1, new DateTime(2024, 6, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9293), "Description for Room5", 8, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9295), 5, 493m, 3, "http://example.com/room5.jpg" },
                    { 6, 3, 2, new DateTime(2024, 5, 5, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9301), "Description for Room6", 15, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9303), 6, 447m, 2, "http://example.com/room6.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 7, 4, 0, new DateTime(2024, 5, 4, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9307), "Description for Room7", 9, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9309), 7, 144m, 3, "http://example.com/room7.jpg" },
                    { 8, 2, 1, new DateTime(2024, 5, 1, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9314), "Description for Room8", 20, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9316), 8, 281m, 2, "http://example.com/room8.jpg" },
                    { 9, 1, 0, new DateTime(2024, 5, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9321), "Description for Room9", 11, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9323), 9, 313m, 3, "http://example.com/room9.jpg" },
                    { 10, 4, 2, new DateTime(2024, 4, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9328), "Description for Room10", 9, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9330), 10, 213m, 1, "http://example.com/room10.jpg" },
                    { 11, 3, 0, new DateTime(2024, 6, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9335), "Description for Room11", 18, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9337), 11, 193m, 2, "http://example.com/room11.jpg" },
                    { 12, 4, 1, new DateTime(2024, 5, 21, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9341), "Description for Room12", 15, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9343), 12, 400m, 1, "http://example.com/room12.jpg" },
                    { 13, 3, 0, new DateTime(2024, 4, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9348), "Description for Room13", 7, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9350), 13, 330m, 3, "http://example.com/room13.jpg" },
                    { 14, 3, 1, new DateTime(2024, 4, 18, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9354), "Description for Room14", 20, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9356), 14, 380m, 1, "http://example.com/room14.jpg" },
                    { 15, 1, 2, new DateTime(2024, 6, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9361), "Description for Room15", 12, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9364), 15, 153m, 3, "http://example.com/room15.jpg" },
                    { 16, 3, 1, new DateTime(2024, 6, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9368), "Description for Room16", 18, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9370), 16, 439m, 3, "http://example.com/room16.jpg" },
                    { 17, 2, 1, new DateTime(2024, 6, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9374), "Description for Room17", 7, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9376), 17, 71m, 3, "http://example.com/room17.jpg" },
                    { 18, 2, 1, new DateTime(2024, 6, 9, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9382), "Description for Room18", 18, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9384), 18, 368m, 1, "http://example.com/room18.jpg" },
                    { 19, 3, 2, new DateTime(2024, 4, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9388), "Description for Room19", 18, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9390), 19, 376m, 2, "http://example.com/room19.jpg" },
                    { 20, 1, 1, new DateTime(2024, 5, 29, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9395), "Description for Room20", 3, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9397), 20, 356m, 3, "http://example.com/room20.jpg" },
                    { 21, 1, 1, new DateTime(2024, 6, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9401), "Description for Room21", 3, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9404), 21, 330m, 3, "http://example.com/room21.jpg" },
                    { 22, 4, 2, new DateTime(2024, 4, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9408), "Description for Room22", 10, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9410), 22, 160m, 1, "http://example.com/room22.jpg" },
                    { 23, 3, 2, new DateTime(2024, 4, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9415), "Description for Room23", 1, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9417), 23, 258m, 3, "http://example.com/room23.jpg" },
                    { 24, 3, 0, new DateTime(2024, 5, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9421), "Description for Room24", 10, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9423), 24, 192m, 3, "http://example.com/room24.jpg" },
                    { 25, 1, 1, new DateTime(2024, 5, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9428), "Description for Room25", 17, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9430), 25, 480m, 3, "http://example.com/room25.jpg" },
                    { 26, 3, 2, new DateTime(2024, 5, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9434), "Description for Room26", 14, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9437), 26, 425m, 3, "http://example.com/room26.jpg" },
                    { 27, 4, 2, new DateTime(2024, 4, 11, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9441), "Description for Room27", 13, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9444), 27, 416m, 3, "http://example.com/room27.jpg" },
                    { 28, 2, 1, new DateTime(2024, 6, 25, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9448), "Description for Room28", 10, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9450), 28, 445m, 2, "http://example.com/room28.jpg" },
                    { 29, 1, 2, new DateTime(2024, 4, 26, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9454), "Description for Room29", 7, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9456), 29, 466m, 2, "http://example.com/room29.jpg" },
                    { 30, 4, 2, new DateTime(2024, 5, 12, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9506), "Description for Room30", 20, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9509), 30, 301m, 2, "http://example.com/room30.jpg" },
                    { 31, 3, 2, new DateTime(2024, 6, 7, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9513), "Description for Room31", 4, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9515), 31, 422m, 1, "http://example.com/room31.jpg" },
                    { 32, 1, 0, new DateTime(2024, 6, 25, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9520), "Description for Room32", 14, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9522), 32, 219m, 2, "http://example.com/room32.jpg" },
                    { 33, 4, 1, new DateTime(2024, 5, 24, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9526), "Description for Room33", 1, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9528), 33, 388m, 1, "http://example.com/room33.jpg" },
                    { 34, 2, 2, new DateTime(2024, 5, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9533), "Description for Room34", 16, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9535), 34, 63m, 3, "http://example.com/room34.jpg" },
                    { 35, 3, 0, new DateTime(2024, 5, 28, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9540), "Description for Room35", 1, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9542), 35, 123m, 1, "http://example.com/room35.jpg" },
                    { 36, 1, 2, new DateTime(2024, 7, 16, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9546), "Description for Room36", 13, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9548), 36, 388m, 1, "http://example.com/room36.jpg" },
                    { 37, 4, 0, new DateTime(2024, 5, 14, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9553), "Description for Room37", 3, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9555), 37, 171m, 1, "http://example.com/room37.jpg" },
                    { 38, 1, 1, new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9559), "Description for Room38", 19, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9561), 38, 144m, 2, "http://example.com/room38.jpg" },
                    { 39, 2, 2, new DateTime(2024, 6, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9565), "Description for Room39", 9, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9568), 39, 345m, 1, "http://example.com/room39.jpg" },
                    { 40, 4, 1, new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9572), "Description for Room40", 11, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9574), 40, 120m, 1, "http://example.com/room40.jpg" },
                    { 41, 2, 1, new DateTime(2024, 7, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9579), "Description for Room41", 2, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9581), 41, 79m, 1, "http://example.com/room41.jpg" },
                    { 42, 2, 0, new DateTime(2024, 6, 13, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9585), "Description for Room42", 4, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9588), 42, 485m, 1, "http://example.com/room42.jpg" },
                    { 43, 3, 0, new DateTime(2024, 5, 15, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9592), "Description for Room43", 7, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9594), 43, 456m, 2, "http://example.com/room43.jpg" },
                    { 44, 1, 1, new DateTime(2024, 4, 27, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9598), "Description for Room44", 8, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9601), 44, 256m, 2, "http://example.com/room44.jpg" },
                    { 45, 1, 2, new DateTime(2024, 5, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9605), "Description for Room45", 2, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9607), 45, 157m, 2, "http://example.com/room45.jpg" },
                    { 46, 2, 1, new DateTime(2024, 5, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9612), "Description for Room46", 16, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9614), 46, 147m, 1, "http://example.com/room46.jpg" },
                    { 47, 2, 0, new DateTime(2024, 5, 2, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9618), "Description for Room47", 9, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9621), 47, 372m, 1, "http://example.com/room47.jpg" },
                    { 48, 4, 2, new DateTime(2024, 7, 8, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9625), "Description for Room48", 10, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9627), 48, 458m, 3, "http://example.com/room48.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[] { 49, 3, 2, new DateTime(2024, 6, 30, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9631), "Description for Room49", 8, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9633), 49, 65m, 2, "http://example.com/room49.jpg" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "Description", "HotelId", "ModificationDate", "Number", "Price", "RoomType", "ThumbnailUrl" },
                values: new object[] { 50, 1, 2, new DateTime(2024, 4, 20, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9638), "Description for Room50", 18, new DateTime(2024, 7, 17, 15, 5, 24, 419, DateTimeKind.Local).AddTicks(9640), 50, 463m, 3, "http://example.com/room50.jpg" });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreatedAt", "RoomId", "Status", "TotalPrice", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3562), 1, 2, 770m, null, 3 },
                    { 2, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3647), 2, 2, 539m, null, 3 },
                    { 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3649), 49, 2, 655m, null, 49 },
                    { 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3650), 50, 2, 796m, null, 50 },
                    { 5, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3761), 3, 2, 341m, null, 3 },
                    { 6, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3771), 4, 2, 297m, null, 4 },
                    { 7, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3772), 3, 2, 300m, null, 3 },
                    { 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3773), 3, 2, 300m, null, 4 },
                    { 9, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3775), 5, 2, 200m, null, 2 },
                    { 10, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3777), 4, 2, 450m, null, 4 },
                    { 11, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3778), 4, 2, 400m, null, 5 },
                    { 12, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3779), 9, 2, 500m, null, 6 },
                    { 13, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 12, 5, 24, 420, DateTimeKind.Utc).AddTicks(3781), 10, 2, 550m, null, 7 }
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
                name: "IX_HotelImage_HotelId",
                table: "HotelImage",
                column: "HotelId");

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
            migrationBuilder.Sql(@"DROP VIEW CityWithHotelsCountView");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "HotelImage");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
