using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CreatedTime", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(50), "Electronic Items", "Electronics" },
                    { 2, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(98), "Food Items", "Food" },
                    { 3, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(100), "Books and Magazines", "Books" },
                    { 4, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(102), "Apparel and Accessories", "Clothing" },
                    { 5, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(103), "Toys and Games", "Toys" },
                    { 6, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(104), "Home and Office Furniture", "Furniture" },
                    { 7, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(106), "Tools and Hardware", "Tools" },
                    { 8, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(107), "Sporting Goods", "Sports" },
                    { 9, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(108), "Beauty and Personal Care", "Beauty" },
                    { 11, new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(110), "Automotive Parts and Accessories", "Automotive" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 11);
        }
    }
}
