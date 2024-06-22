﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationProfiles.Data;

#nullable disable

namespace WebApplicationProfiles.Migrations.AlignerDb
{
    [DbContext(typeof(AlignerDbContext))]
    [Migration("20240622073442_addAlignerTableToDb")]
    partial class addAlignerTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3");

            modelBuilder.Entity("WebApplicationProfiles.Models.Aligner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubstrateSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Aligners");
                });
#pragma warning restore 612, 618
        }
    }
}
