﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignmentConsultTik.Models;

#nullable disable

namespace assignmentConsultTik.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assignmentConsultTik.Models.Currency", b =>
                {
                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CurrencyCode");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.PurchaseOrderHeader", b =>
                {
                    b.Property<string>("PurchId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PurchId");

                    b.HasIndex("CurrencyCode");

                    b.HasIndex("Vendor");

                    b.ToTable("PurchaseOrderHeaders");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.PurchaseOrderLine", b =>
                {
                    b.Property<string>("PurchId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ItemId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchId");

                    b.ToTable("PurchaseOrderLines");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.Vendor", b =>
                {
                    b.Property<string>("VendorId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.PurchaseOrderHeader", b =>
                {
                    b.HasOne("assignmentConsultTik.Models.Currency", "CurrencyDetails")
                        .WithMany("PurchaseOrderHeaders")
                        .HasForeignKey("CurrencyCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignmentConsultTik.Models.Vendor", "VendorDetails")
                        .WithMany("PurchaseOrderHeaders")
                        .HasForeignKey("Vendor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrencyDetails");

                    b.Navigation("VendorDetails");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.PurchaseOrderLine", b =>
                {
                    b.HasOne("assignmentConsultTik.Models.PurchaseOrderHeader", "PurchaseOrderHeader")
                        .WithMany("PurchaseOrderLines")
                        .HasForeignKey("PurchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrderHeader");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.Currency", b =>
                {
                    b.Navigation("PurchaseOrderHeaders");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.PurchaseOrderHeader", b =>
                {
                    b.Navigation("PurchaseOrderLines");
                });

            modelBuilder.Entity("assignmentConsultTik.Models.Vendor", b =>
                {
                    b.Navigation("PurchaseOrderHeaders");
                });
#pragma warning restore 612, 618
        }
    }
}
