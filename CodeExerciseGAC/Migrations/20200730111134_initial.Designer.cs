﻿// <auto-generated />
using CodeExerciseGAC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeExerciseGAC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200730111134_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeExerciseGAC.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerLocation");

                    b.Property<string>("CustomerName");

                    b.HasKey("Id");

                    b.ToTable("tblCustomers");
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufacLocation");

                    b.Property<string>("ManufacName");

                    b.HasKey("Id");

                    b.ToTable("tblManufacturer");
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dimension");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("tblProducts");
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustRef");

                    b.Property<int>("CustomersId");

                    b.Property<string>("OrderNo");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.ToTable("tblSalesOrder");
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.SalesOrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductsId");

                    b.Property<double>("Qty");

                    b.Property<int>("SalesOrderId");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("tblSalesOrderDetails");
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.SalesOrder", b =>
                {
                    b.HasOne("CodeExerciseGAC.Models.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeExerciseGAC.Models.SalesOrderDetails", b =>
                {
                    b.HasOne("CodeExerciseGAC.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeExerciseGAC.Models.SalesOrder", "SalesOrder")
                        .WithMany()
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
