﻿// <auto-generated />
using System;
using BookingApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingApp.DataAccess.Migrations
{
    [DbContext(typeof(BookingAppDbContext))]
    [Migration("20200413174519_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Administrator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Barbershop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Barbershops");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.BarbershopReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BarbershopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BarbershopId");

                    b.HasIndex("UserId");

                    b.ToTable("BarbershopReservations");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Cinema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.CinemaReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CinemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("UserId");

                    b.ToTable("CinemaReservations");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactMessages");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.RestaurantReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StartHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("RestaurantReservations");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Barbershop", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Administrator", null)
                        .WithMany("Barbershops")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.BarbershopReservation", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Barbershop", "Barbershop")
                        .WithMany()
                        .HasForeignKey("BarbershopId");

                    b.HasOne("BookingApp.ApplicationLogic.DataModel.User", null)
                        .WithMany("BarbershopReservations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Cinema", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Administrator", null)
                        .WithMany("Cinemas")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.CinemaReservation", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId");

                    b.HasOne("BookingApp.ApplicationLogic.DataModel.User", null)
                        .WithMany("CinemaReservations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.Restaurant", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Administrator", null)
                        .WithMany("Restaurants")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("BookingApp.ApplicationLogic.DataModel.RestaurantReservation", b =>
                {
                    b.HasOne("BookingApp.ApplicationLogic.DataModel.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId");

                    b.HasOne("BookingApp.ApplicationLogic.DataModel.User", null)
                        .WithMany("RestaurantReservations")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
