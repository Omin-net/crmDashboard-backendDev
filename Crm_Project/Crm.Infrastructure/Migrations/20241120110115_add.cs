using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    ProductSize = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Color", "CreationData", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("98009939-06a2-4cc5-901a-d8fb8a09df07"), "قرمز", new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6723), "کفش مردانه برند فلان خریداری شده از اکبر", 100000, "9 کفش جی اس" },
                    { new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"), "آبی", new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6731), "کفش مردانه برند فلان خریداری شده از محمد", 250000, " 15 کفش جی اس" },
                    { new Guid("b8f16428-73c5-4c27-b087-50772880c50a"), "سبز", new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6555), "کفش مردانه برند فلان خریداری شده از مهدی", 325000, "کفش جی اس" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "ProductCount", "ProductId", "ProductSize" },
                values: new object[,]
                {
                    { new Guid("25d0411a-44d8-4687-9041-1fcda28250de"), 66, new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"), 46 },
                    { new Guid("563d1186-8689-4882-a814-bf9049782175"), 22, new Guid("b8f16428-73c5-4c27-b087-50772880c50a"), 39 },
                    { new Guid("6dd2f615-f77d-4443-9b51-f4a3a7a4d349"), 33, new Guid("b8f16428-73c5-4c27-b087-50772880c50a"), 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
