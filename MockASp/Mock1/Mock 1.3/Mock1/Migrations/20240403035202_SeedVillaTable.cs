using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mock1.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Private pool, ocean view", new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9211), "This villa offers breathtaking views of the ocean and comes with a private pool.", "https://example.com/villa1.jpg", "Luxury Villa", 8, 500.0, new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9226) },
                    { 2, "Mountain view, fireplace", new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9229), "Escape to this cozy villa nestled in the mountains, perfect for a romantic getaway.", "https://example.com/villa2.jpg", "Cozy Retreat", 4, 300.0, new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9230) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
