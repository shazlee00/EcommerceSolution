using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class nullimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 18, 18, 5, 33, 573, DateTimeKind.Local).AddTicks(8061));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
