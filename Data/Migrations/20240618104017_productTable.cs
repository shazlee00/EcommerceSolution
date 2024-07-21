using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class productTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(110));
        }
    }
}
