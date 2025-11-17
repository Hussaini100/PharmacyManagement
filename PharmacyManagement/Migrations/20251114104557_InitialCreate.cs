using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmacyManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ExpiryDate", "Manufacturer", "Name", "Price", "ProductionDate", "StockQuantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "مسکن", new DateTime(2025, 11, 14, 15, 15, 56, 759, DateTimeKind.Local).AddTicks(5179), "مسکن و تب‌بر", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "داروسازی سبحان", "پاراستامول", 5000m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new DateTime(2025, 11, 14, 15, 15, 56, 759, DateTimeKind.Local).AddTicks(5180) },
                    { 2, "آنتی بیوتیک", new DateTime(2025, 11, 14, 15, 15, 56, 759, DateTimeKind.Local).AddTicks(5185), "آنتی بیوتیک", new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "داروسازی کیمیدارو", "آموکسی سیلین", 15000m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new DateTime(2025, 11, 14, 15, 15, 56, 759, DateTimeKind.Local).AddTicks(5185) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
