﻿// <auto-generated />
using System;
using Ecommerce.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240611113107_seeddata")]
    partial class seeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Web.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(50),
                            Description = "Electronic Items",
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(98),
                            Description = "Food Items",
                            Name = "Food"
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(100),
                            Description = "Books and Magazines",
                            Name = "Books"
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(102),
                            Description = "Apparel and Accessories",
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(103),
                            Description = "Toys and Games",
                            Name = "Toys"
                        },
                        new
                        {
                            CategoryId = 6,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(104),
                            Description = "Home and Office Furniture",
                            Name = "Furniture"
                        },
                        new
                        {
                            CategoryId = 7,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(106),
                            Description = "Tools and Hardware",
                            Name = "Tools"
                        },
                        new
                        {
                            CategoryId = 8,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(107),
                            Description = "Sporting Goods",
                            Name = "Sports"
                        },
                        new
                        {
                            CategoryId = 9,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(108),
                            Description = "Beauty and Personal Care",
                            Name = "Beauty"
                        },
                        new
                        {
                            CategoryId = 11,
                            CreatedTime = new DateTime(2024, 6, 11, 14, 31, 7, 761, DateTimeKind.Local).AddTicks(110),
                            Description = "Automotive Parts and Accessories",
                            Name = "Automotive"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
