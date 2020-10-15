﻿// <auto-generated />
using System;
using DanskeBankCodingTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanskeBankCodingTask.Migrations
{
    [DbContext(typeof(MunicipalityTaxContext))]
    partial class MunicipalityTaxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DanskeBankCodingTask.Models.MunicipalityTax", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Municipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TaxRate")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("MunicipalityTaxes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EndDate = new DateTime(2016, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipality = "Copenhagen",
                            Schedule = "Yearly",
                            StartDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxRate = 0.20000000000000001
                        },
                        new
                        {
                            ID = 2,
                            EndDate = new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipality = "Copenhagen",
                            Schedule = "Monthly",
                            StartDate = new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxRate = 0.40000000000000002
                        },
                        new
                        {
                            ID = 3,
                            EndDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipality = "Copenhagen",
                            Schedule = "Daily",
                            StartDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxRate = 0.10000000000000001
                        },
                        new
                        {
                            ID = 4,
                            EndDate = new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipality = "Copenhagen",
                            Schedule = "Daily",
                            StartDate = new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TaxRate = 0.10000000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}