﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 21, 5, 44, 14, 976, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
