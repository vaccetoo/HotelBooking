using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "STATIC_CONCURRENCY_STAMP", "admin@hotel.com", true, false, null, "ADMIN@HOTEL.COM", "ADMIN@HOTEL.COM", "AQAAAAIAAYagAAAAEIlzm16lhiKkM8ggu0XMfXXKGYmJcd/tTBk/HrzaUOq3A9eblvEcExAojcD52xL4Yw==", null, false, "STATIC_SECURITY_STAMP", false, "admin@hotel.com" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "CloseAt", "DeletedOn", "IsDeleted", "OpenAt", "PricePerDay", "Type" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000011"), new TimeOnly(22, 0, 0), null, false, new TimeOnly(8, 0, 0), 10m, 1 },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new TimeOnly(20, 0, 0), null, false, new TimeOnly(8, 0, 0), 15m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "PricePerNight", "RoomCapacity", "RoomNumber", "Type" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, false, 50m, 1, "101", 0 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, false, 90m, 2, "102", 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "DeletedOn", "GuestId", "IsDeleted", "Nights", "RoomId", "TotalPrice" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new DateOnly(2025, 3, 1), new DateOnly(2025, 3, 3), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), false, 2, new Guid("00000000-0000-0000-0000-000000000001"), 80m });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedOn", "DeletedOn", "GuestId", "IsDeleted", "Rating" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), null, new DateTime(2025, 2, 11, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedOn", "DeletedOn", "IsDeleted", "ReservationId", "Status" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), 80m, new DateTime(2025, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("00000000-0000-0000-0000-000000000014"), 0 });

            migrationBuilder.InsertData(
                table: "ReservationFacilities",
                columns: new[] { "FacilityId", "ReservationId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000014") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "ReservationFacilities",
                keyColumns: new[] { "FacilityId", "ReservationId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000014") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));
        }
    }
}
