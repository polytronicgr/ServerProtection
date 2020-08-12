﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SP.API;

namespace SP.API.Migrations
{
    [DbContext(typeof(Db))]
    partial class DbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SP.Models.Blocks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirewallRuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hostname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IpAddress1")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress2")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress3")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress4")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsBlocked")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("SP.Models.LoginAttempts", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IpAddress1")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress2")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress3")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IpAddress4")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Login.Attempts");
                });

            modelBuilder.Entity("SP.Models.StatisticsBlocks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Attempts")
                        .HasColumnType("bigint");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statistics.Blocks");
                });
#pragma warning restore 612, 618
        }
    }
}
