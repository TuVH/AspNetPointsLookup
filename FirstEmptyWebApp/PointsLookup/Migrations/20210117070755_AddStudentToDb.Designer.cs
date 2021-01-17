﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PointsLookup.Data;

namespace PointsLookup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210117070755_AddStudentToDb")]
    partial class AddStudentToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PointsLookup.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("BiologicalScores")
                        .HasColumnType("float");

                    b.Property<double>("ChemiscalScores")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<double>("EnglishScores")
                        .HasColumnType("float");

                    b.Property<string>("IdentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LiteratureScores")
                        .HasColumnType("float");

                    b.Property<double>("MathScores")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PhysicalScores")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
