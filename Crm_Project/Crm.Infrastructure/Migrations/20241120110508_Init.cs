using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98009939-06a2-4cc5-901a-d8fb8a09df07"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 35, 8, 132, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 35, 8, 132, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b8f16428-73c5-4c27-b087-50772880c50a"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 35, 8, 132, DateTimeKind.Local).AddTicks(2661));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98009939-06a2-4cc5-901a-d8fb8a09df07"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b8f16428-73c5-4c27-b087-50772880c50a"),
                column: "CreationData",
                value: new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6555));
        }
    }
}
