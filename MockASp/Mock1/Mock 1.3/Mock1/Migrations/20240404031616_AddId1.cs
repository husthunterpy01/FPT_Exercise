using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mock1.Migrations
{
    /// <inheritdoc />
    public partial class AddId1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 16, 15, 615, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 4, 4, 10, 16, 15, 615, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 16, 15, 615, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 4, 4, 10, 16, 15, 615, DateTimeKind.Local).AddTicks(5255) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 4, 3, 10, 52, 1, 922, DateTimeKind.Local).AddTicks(9230) });
        }
    }
}
