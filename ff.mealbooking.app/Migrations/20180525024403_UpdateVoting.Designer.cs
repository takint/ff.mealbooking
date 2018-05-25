﻿// <auto-generated />
using ff.mealbooking.app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ff.mealbooking.app.Migrations
{
    [DbContext(typeof(MealBookingDbContext))]
    [Migration("20180525024403_UpdateVoting")]
    partial class UpdateVoting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ff.mealbooking.app.Data.DataModels.DemandOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(512);

                    b.Property<string>("DishName")
                        .HasMaxLength(1024);

                    b.Property<string>("Notes")
                        .HasMaxLength(2048);

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("VendorName")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.ToTable("DemandOrders");
                });

            modelBuilder.Entity("ff.mealbooking.app.Data.DataModels.MealVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(512);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("VendorName")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("MealVotes");
                });
#pragma warning restore 612, 618
        }
    }
}
