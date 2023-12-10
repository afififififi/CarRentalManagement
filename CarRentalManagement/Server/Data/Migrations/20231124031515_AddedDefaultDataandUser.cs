using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "90ebaf45-f380-4c36-a302-ea0e53709666", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJJTqOC5AvuTdmN3/nwXlIwezHrBaLJzTen1prXVgfqVQscQll9g8X7FVv1uz5rlLg==", null, false, "e99d7d8e-ba1a-490b-ab8c-b9f938e87d32", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9573), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9576), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9576), "Blue", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9578), "Green", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9579), "Red", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9915), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 11, 24, 11, 15, 15, 61, DateTimeKind.Local).AddTicks(9917), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(116), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(117), new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(118), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(119), new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(119), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(153), new DateTime(2023, 11, 24, 11, 15, 15, 62, DateTimeKind.Local).AddTicks(154), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
