using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class nameupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 14, 59, 8, 876, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "CategoryId");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 13, 40, 16, 600, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
