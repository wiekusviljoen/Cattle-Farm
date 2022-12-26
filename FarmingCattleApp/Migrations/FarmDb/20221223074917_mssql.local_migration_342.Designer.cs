﻿// <auto-generated />
using System;
using FarmingCattleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmingCattleApp.Migrations.FarmDb
{
    [DbContext(typeof(FarmDbContext))]
    [Migration("20221223074917_mssql.local_migration_342")]
    partial class mssqllocal_migration_342
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FarmingCattleApp.Models.CattleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Branded")
                        .HasColumnType("bit");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BullCalf")
                        .HasColumnType("int");

                    b.Property<int>("Bulls")
                        .HasColumnType("int");

                    b.Property<string>("Camp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CowCalf")
                        .HasColumnType("int");

                    b.Property<int>("Cows")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dead")
                        .HasColumnType("int");

                    b.Property<bool>("Dipped")
                        .HasColumnType("bit");

                    b.Property<string>("Feed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FeedPrice")
                        .HasColumnType("float");

                    b.Property<double>("FeedQuantity")
                        .HasColumnType("float");

                    b.Property<bool>("Injected")
                        .HasColumnType("bit");

                    b.Property<int>("Missing")
                        .HasColumnType("int");

                    b.Property<int>("NewCalf")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CattleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
