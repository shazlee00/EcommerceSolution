using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateIdentitySchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedTime", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(489), "Electronic Items", "Electronics" },
                    { 2, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(541), "Food Items", "Food" },
                    { 3, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(543), "Books and Magazines", "Books" },
                    { 4, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(545), "Apparel and Accessories", "Clothing" },
                    { 5, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(547), "Toys and Games", "Toys" },
                    { 6, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(548), "Home and Office Furniture", "Furniture" },
                    { 7, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(550), "Tools and Hardware", "Tools" },
                    { 8, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(552), "Sporting Goods", "Sports" },
                    { 9, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(553), "Beauty and Personal Care", "Beauty" },
                    { 11, new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(555), "Automotive Parts and Accessories", "Automotive" }
                });
        }
    }
}
