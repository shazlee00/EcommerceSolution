using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class addnavprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 17, 58, 2, 738, DateTimeKind.Local).AddTicks(9436));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
