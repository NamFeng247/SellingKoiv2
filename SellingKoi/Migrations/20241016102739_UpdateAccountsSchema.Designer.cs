﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SellingKoi.Data;

#nullable disable

namespace SellingKoi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241016102739_UpdateAccountsSchema")]
    partial class UpdateAccountsSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CartKOI", b =>
                {
                    b.Property<Guid>("CartsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KOIsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartsId", "KOIsId");

                    b.HasIndex("KOIsId");

                    b.ToTable("CartKOI");
                });

            modelBuilder.Entity("FarmRoute", b =>
                {
                    b.Property<Guid>("FarmsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoutesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FarmsId", "RoutesId");

                    b.HasIndex("RoutesId");

                    b.ToTable("FarmRoute");
                });

            modelBuilder.Entity("SellingKoi.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Registration_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SellingKoi.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RouteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("SellingKoi.Models.Farm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("SellingKoi.Models.KOI", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("FarmID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Registration_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FarmID");

                    b.HasIndex("OrderId");

                    b.ToTable("KOIs");
                });

            modelBuilder.Entity("SellingKoi.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Registration_date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RouteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SellingKoi.Models.OrderShorten", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Registration_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("koisid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("koisname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("routeid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("routename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrtherShortens");
                });

            modelBuilder.Entity("SellingKoi.Models.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<DateTime>("Registration_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("CartKOI", b =>
                {
                    b.HasOne("SellingKoi.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingKoi.Models.KOI", null)
                        .WithMany()
                        .HasForeignKey("KOIsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmRoute", b =>
                {
                    b.HasOne("SellingKoi.Models.Farm", null)
                        .WithMany()
                        .HasForeignKey("FarmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingKoi.Models.Route", null)
                        .WithMany()
                        .HasForeignKey("RoutesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SellingKoi.Models.Cart", b =>
                {
                    b.HasOne("SellingKoi.Models.Account", "Account")
                        .WithOne("Cart")
                        .HasForeignKey("SellingKoi.Models.Cart", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingKoi.Models.Route", "Route")
                        .WithMany("Carts")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("SellingKoi.Models.KOI", b =>
                {
                    b.HasOne("SellingKoi.Models.Farm", "Farm")
                        .WithMany("KOIs")
                        .HasForeignKey("FarmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingKoi.Models.Order", null)
                        .WithMany("Kois")
                        .HasForeignKey("OrderId");

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("SellingKoi.Models.Order", b =>
                {
                    b.HasOne("SellingKoi.Models.Route", "Route")
                        .WithMany("Orders")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("SellingKoi.Models.Account", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });

            modelBuilder.Entity("SellingKoi.Models.Farm", b =>
                {
                    b.Navigation("KOIs");
                });

            modelBuilder.Entity("SellingKoi.Models.Order", b =>
                {
                    b.Navigation("Kois");
                });

            modelBuilder.Entity("SellingKoi.Models.Route", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
