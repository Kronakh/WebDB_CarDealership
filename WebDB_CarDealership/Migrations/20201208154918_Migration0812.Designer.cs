﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDB_CarDealership.Data;

namespace WebDB_CarDealership.Migrations
{
    [DbContext(typeof(WebDB_CarDealershipContext))]
    [Migration("20201208154918_Migration0812")]
    partial class Migration0812
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AdditionalEquipmentAuto", b =>
                {
                    b.Property<long>("AdditionalEquipmentID")
                        .HasColumnType("bigint");

                    b.Property<long>("AutoID")
                        .HasColumnType("bigint");

                    b.HasKey("AdditionalEquipmentID", "AutoID");

                    b.HasIndex("AutoID");

                    b.ToTable("AdditionalEquipmentAuto");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.AdditionalEquipment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AdditionalEquipment");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Auto", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("AE1")
                        .HasColumnType("bigint");

                    b.Property<long?>("AE2")
                        .HasColumnType("bigint");

                    b.Property<long?>("AE3")
                        .HasColumnType("bigint");

                    b.Property<long?>("BTID")
                        .HasColumnType("bigint");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COLOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateManufacture")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ManufID")
                        .HasColumnType("bigint");

                    b.Property<string>("NumBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumEngine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("BTID");

                    b.HasIndex("ManufID");

                    b.HasIndex("StaffID");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.BodyType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BodyType");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Customers", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSale")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MarkCompletion")
                        .HasColumnType("bit");

                    b.Property<bool>("MarkPrice")
                        .HasColumnType("bit");

                    b.Property<string>("PassData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int>("PrecPrePlay")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("AutoID");

                    b.HasIndex("StaffID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Manufacturers", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<long?>("PositionID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PositionID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("AdditionalEquipmentAuto", b =>
                {
                    b.HasOne("WebDB_CarDealership.Models.AdditionalEquipment", null)
                        .WithMany()
                        .HasForeignKey("AdditionalEquipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebDB_CarDealership.Models.Auto", null)
                        .WithMany()
                        .HasForeignKey("AutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Auto", b =>
                {
                    b.HasOne("WebDB_CarDealership.Models.BodyType", "BT")
                        .WithMany("Auto")
                        .HasForeignKey("BTID");

                    b.HasOne("WebDB_CarDealership.Models.Manufacturers", "Manuf")
                        .WithMany("Auto")
                        .HasForeignKey("ManufID");

                    b.HasOne("WebDB_CarDealership.Models.Staff", "Staff")
                        .WithMany("Auto")
                        .HasForeignKey("StaffID");

                    b.Navigation("BT");

                    b.Navigation("Manuf");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Customers", b =>
                {
                    b.HasOne("WebDB_CarDealership.Models.Auto", "Auto")
                        .WithMany("Customers")
                        .HasForeignKey("AutoID");

                    b.HasOne("WebDB_CarDealership.Models.Staff", "Staff")
                        .WithMany("Customers")
                        .HasForeignKey("StaffID");

                    b.Navigation("Auto");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Manufacturers", b =>
                {
                    b.HasOne("WebDB_CarDealership.Models.Staff", "Staff")
                        .WithMany("Manufacturers")
                        .HasForeignKey("StaffID");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Staff", b =>
                {
                    b.HasOne("WebDB_CarDealership.Models.Position", "Position")
                        .WithMany("Staff")
                        .HasForeignKey("PositionID");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Auto", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.BodyType", b =>
                {
                    b.Navigation("Auto");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Manufacturers", b =>
                {
                    b.Navigation("Auto");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Position", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("WebDB_CarDealership.Models.Staff", b =>
                {
                    b.Navigation("Auto");

                    b.Navigation("Customers");

                    b.Navigation("Manufacturers");
                });
#pragma warning restore 612, 618
        }
    }
}