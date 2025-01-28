﻿// <auto-generated />
using BusBookingDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusBookingDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250128080826_In1")]
    partial class In1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusBookingDemo.Entity.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SeatDetailId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeatDetailId");

                    b.HasIndex("TripId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BusBookingDemo.Entity.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusNumber = "234AA",
                            SeatsCount = 24
                        },
                        new
                        {
                            Id = 2,
                            BusNumber = "211DA",
                            SeatsCount = 34
                        },
                        new
                        {
                            Id = 3,
                            BusNumber = "232AC",
                            SeatsCount = 20
                        });
                });

            modelBuilder.Entity("BusBookingDemo.Entity.SeatDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("SeatDetals");
                });

            modelBuilder.Entity("BusBookingDemo.Entity.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("Depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Return")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("BusBookingDemo.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "xyz@mail.com",
                            FirstName = "tatiana",
                            LastName = "tat",
                            Password = "1234",
                            Phone = "12345",
                            Username = "tati"
                        },
                        new
                        {
                            Id = 2,
                            Email = "xyz1@mail.com",
                            FirstName = "anna",
                            LastName = "aniina",
                            Password = "1234",
                            Phone = "12345",
                            Username = "anni"
                        });
                });

            modelBuilder.Entity("BusBookingDemo.Entity.Booking", b =>
                {
                    b.HasOne("BusBookingDemo.Entity.SeatDetail", "SeatDetail")
                        .WithMany()
                        .HasForeignKey("SeatDetailId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusBookingDemo.Entity.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusBookingDemo.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SeatDetail");

                    b.Navigation("Trip");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusBookingDemo.Entity.SeatDetail", b =>
                {
                    b.HasOne("BusBookingDemo.Entity.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("BusBookingDemo.Entity.Trip", b =>
                {
                    b.HasOne("BusBookingDemo.Entity.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");
                });
#pragma warning restore 612, 618
        }
    }
}
