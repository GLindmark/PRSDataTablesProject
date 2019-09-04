﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRSDataTablesProject.Models;

namespace PRSDataTablesProject.Migrations
{
    [DbContext(typeof(PRSdb))]
    [Migration("20190904234009_Request")]
    partial class Request
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PRSDataTablesProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PartNbr")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Photopath")
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(11, 2)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("PartNbr")
                        .IsUnique();

                    b.HasIndex("VendorId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryMode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Justification")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int?>("ProductId");

                    b.Property<string>("RejectionReason")
                        .HasMaxLength(80);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(11, 2)");

                    b.Property<int>("UserId");

                    b.Property<int?>("vendorId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.HasIndex("vendorId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.RequestLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductIdId");

                    b.Property<int>("Quantity");

                    b.Property<int>("RequestIdId");

                    b.HasKey("Id");

                    b.HasIndex("ProductIdId");

                    b.HasIndex("RequestIdId");

                    b.ToTable("RequestLines");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsReviewer");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasMaxLength(12);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasMaxLength(12);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.Product", b =>
                {
                    b.HasOne("PRSDataTablesProject.Models.Vendor", "Vendor")
                        .WithOne("PartNbr")
                        .HasForeignKey("PRSDataTablesProject.Models.Product", "VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.Request", b =>
                {
                    b.HasOne("PRSDataTablesProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("PRSDataTablesProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PRSDataTablesProject.Models.Vendor", "vendor")
                        .WithMany()
                        .HasForeignKey("vendorId");
                });

            modelBuilder.Entity("PRSDataTablesProject.Models.RequestLine", b =>
                {
                    b.HasOne("PRSDataTablesProject.Models.Product", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PRSDataTablesProject.Models.Request", "RequestId")
                        .WithMany()
                        .HasForeignKey("RequestIdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
