﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesControls.Data;

namespace SalesControls.Migrations
{
    [DbContext(typeof(SalesControlsContext))]
    [Migration("20210425211019_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesControls.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateBuy");

                    b.Property<DateTime?>("DateSale");

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<double?>("PriceBuy");

                    b.Property<double?>("PriceSale");

                    b.Property<string>("ProductDescripton");

                    b.Property<string>("PurchaseEmail");

                    b.Property<string>("TrackingCode");

                    b.HasKey("SaleId");

                    b.ToTable("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}