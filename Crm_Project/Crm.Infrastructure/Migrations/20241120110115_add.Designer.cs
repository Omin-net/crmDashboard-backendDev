﻿// <auto-generated />
using System;
using Crm.Infrastructure.Persestent.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crm.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241120110115_add")]
    partial class add
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Crm.Domain.Products.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("b8f16428-73c5-4c27-b087-50772880c50a"),
                            Color = "سبز",
                            CreationData = new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6555),
                            Description = "کفش مردانه برند فلان خریداری شده از مهدی",
                            Price = 325000,
                            ProductName = "کفش جی اس"
                        },
                        new
                        {
                            ProductId = new Guid("98009939-06a2-4cc5-901a-d8fb8a09df07"),
                            Color = "قرمز",
                            CreationData = new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6723),
                            Description = "کفش مردانه برند فلان خریداری شده از اکبر",
                            Price = 100000,
                            ProductName = "9 کفش جی اس"
                        },
                        new
                        {
                            ProductId = new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"),
                            Color = "آبی",
                            CreationData = new DateTime(2024, 11, 20, 14, 31, 12, 477, DateTimeKind.Local).AddTicks(6731),
                            Description = "کفش مردانه برند فلان خریداری شده از محمد",
                            Price = 250000,
                            ProductName = " 15 کفش جی اس"
                        });
                });

            modelBuilder.Entity("Crm.Domain.Products.ProductDetail", b =>
                {
                    b.Property<Guid>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProductSize")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");

                    b.HasData(
                        new
                        {
                            ProductDetailId = new Guid("563d1186-8689-4882-a814-bf9049782175"),
                            ProductCount = 22,
                            ProductId = new Guid("b8f16428-73c5-4c27-b087-50772880c50a"),
                            ProductSize = 39
                        },
                        new
                        {
                            ProductDetailId = new Guid("6dd2f615-f77d-4443-9b51-f4a3a7a4d349"),
                            ProductCount = 33,
                            ProductId = new Guid("b8f16428-73c5-4c27-b087-50772880c50a"),
                            ProductSize = 40
                        },
                        new
                        {
                            ProductDetailId = new Guid("25d0411a-44d8-4687-9041-1fcda28250de"),
                            ProductCount = 66,
                            ProductId = new Guid("abe4dd6c-e0d0-44f0-bc5b-f5962e37f5e5"),
                            ProductSize = 46
                        });
                });

            modelBuilder.Entity("Crm.Domain.Products.ProductDetail", b =>
                {
                    b.HasOne("Crm.Domain.Products.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Crm.Domain.Products.Product", b =>
                {
                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
