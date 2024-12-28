using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SurvivorWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "ModifiedTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 28, 9, 16, 41, 510, DateTimeKind.Utc).AddTicks(9942), false, new DateTime(2024, 12, 28, 9, 16, 41, 510, DateTimeKind.Utc).AddTicks(9952), "Unluler" },
                    { 2, new DateTime(2024, 12, 28, 9, 16, 41, 510, DateTimeKind.Utc).AddTicks(9966), false, new DateTime(2024, 12, 28, 9, 16, 41, 510, DateTimeKind.Utc).AddTicks(9967), "Gonulluler" }
                });

            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "FirstName", "IsDeleted", "LastName", "ModifiedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(50), "Acun", false, "Ilicali", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(51) },
                    { 2, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(57), "Aleyna", false, "Avci", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(58) },
                    { 3, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(62), "Hadise", false, "Acikgoz", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(63) },
                    { 4, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(66), "Sertan", false, "Bozkus", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(66) },
                    { 5, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(69), "Ozge", false, "Acik", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(69) },
                    { 6, 1, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(79), "Kivanc", false, "Tatlitug", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(80) },
                    { 7, 2, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(82), "Ahmet", false, "Yilmaz", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(83) },
                    { 8, 2, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(85), "Elif", false, "Demirtas", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(86) },
                    { 9, 2, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(89), "Cem", false, "Ozturk", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(89) },
                    { 10, 2, new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(94), "Ayse", false, "Karaca", new DateTime(2024, 12, 28, 9, 16, 41, 511, DateTimeKind.Utc).AddTicks(95) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
