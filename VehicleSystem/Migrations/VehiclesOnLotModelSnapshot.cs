﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleSystem.Models;

#nullable disable

namespace VehicleSystem.Migrations
{
    [DbContext(typeof(VehiclesOnLot))]
    partial class VehiclesOnLotModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehicleSystem.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<string>("BodyStyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("VehicleId");

                    b.ToTable("vehicles");

                    b.HasData(
                        new
                        {
                            VehicleId = 1,
                            BodyStyle = "Hatchback",
                            Make = "Honda",
                            Trim = "DX",
                            VehModel = "Civic",
                            Year = 1996
                        },
                        new
                        {
                            VehicleId = 2,
                            BodyStyle = "Coupe",
                            Make = "Honda",
                            Trim = "Si",
                            VehModel = "Civic",
                            Year = 1997
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
