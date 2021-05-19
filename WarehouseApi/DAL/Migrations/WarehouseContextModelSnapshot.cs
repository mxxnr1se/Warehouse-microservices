﻿// <auto-generated />
using System;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DAL.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Sandora"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "OKZDP"
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "PepsiCo"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Coca-Cola Company"
                        },
                        new
                        {
                            Id = 5,
                            BrandName = "Guinness"
                        },
                        new
                        {
                            Id = 6,
                            BrandName = "Hoegaarden"
                        },
                        new
                        {
                            Id = 7,
                            BrandName = "Morshynska"
                        },
                        new
                        {
                            Id = 8,
                            BrandName = "Jameson"
                        },
                        new
                        {
                            Id = 9,
                            BrandName = "Jack Daniel's"
                        },
                        new
                        {
                            Id = 10,
                            BrandName = "French rose"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Juice",
                            Description = "Description how to store juice..."
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Water",
                            Description = "Description how to store water..."
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Soda",
                            Description = "Description how to store soda..."
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Beer",
                            Description = "Description how to store beer..."
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Wine",
                            Description = "Description how to store wine..."
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Whiskey",
                            Description = "Description how to store whiskey..."
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 5,
                            BrandId = 1,
                            CategoryId = 1,
                            Price = 210m,
                            ProductName = "Apple juice 0,5lx12",
                            SupplierId = 4
                        },
                        new
                        {
                            Id = 2,
                            Amount = 4,
                            BrandId = 2,
                            CategoryId = 1,
                            Price = 220m,
                            ProductName = "Tomato juice 0,5lx12",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 3,
                            BrandId = 2,
                            CategoryId = 1,
                            Price = 310m,
                            ProductName = "Apple juice 1lx12",
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 14,
                            BrandId = 1,
                            CategoryId = 1,
                            Price = 340m,
                            ProductName = "Tomato juice 1lx12",
                            SupplierId = 2
                        },
                        new
                        {
                            Id = 5,
                            Amount = 10,
                            BrandId = 1,
                            CategoryId = 1,
                            Price = 480m,
                            ProductName = "Apple juice 1,5lx12",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 6,
                            Amount = 21,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 180m,
                            ProductName = "Coca-cola 0,5lx12",
                            SupplierId = 2
                        },
                        new
                        {
                            Id = 7,
                            Amount = 5,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 230m,
                            ProductName = "Coca-cola 1lx12",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 8,
                            Amount = 16,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 250m,
                            ProductName = "Coca-cola 1,5lx12",
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 9,
                            Amount = 12,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 270m,
                            ProductName = "Coca-cola 2lx12",
                            SupplierId = 4
                        },
                        new
                        {
                            Id = 10,
                            Amount = 21,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 180m,
                            ProductName = "Pepsi 0,5lx12",
                            SupplierId = 2
                        },
                        new
                        {
                            Id = 11,
                            Amount = 5,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 230m,
                            ProductName = "Pepsi 1lx12",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 12,
                            Amount = 16,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 250m,
                            ProductName = "Pepsi 1,5lx12",
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 13,
                            Amount = 12,
                            BrandId = 4,
                            CategoryId = 3,
                            Price = 270m,
                            ProductName = "Pepsi 2lx12",
                            SupplierId = 4
                        },
                        new
                        {
                            Id = 14,
                            Amount = 14,
                            BrandId = 7,
                            CategoryId = 2,
                            Price = 120m,
                            ProductName = "Morshynska 0,5lx12",
                            SupplierId = 3
                        },
                        new
                        {
                            Id = 15,
                            Amount = 3,
                            BrandId = 10,
                            CategoryId = 5,
                            Price = 600m,
                            ProductName = "Mansion No.9",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 16,
                            Amount = 6,
                            BrandId = 6,
                            CategoryId = 4,
                            Price = 480m,
                            ProductName = "Hoegaarden 0,5lx12",
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 17,
                            Amount = 13,
                            BrandId = 6,
                            CategoryId = 4,
                            Price = 680m,
                            ProductName = "Hoegaarden 1lx12",
                            SupplierId = 2
                        },
                        new
                        {
                            Id = 18,
                            Amount = 8,
                            BrandId = 5,
                            CategoryId = 4,
                            Price = 800m,
                            ProductName = "Guinness 0,435lx12",
                            SupplierId = 1
                        });
                });

            modelBuilder.Entity("DAL.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Sidorov company",
                            FirstName = "Nikita",
                            PhoneNumber = "050-111-11-11",
                            Surname = "Sidorov"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Stepaniuk warehouse",
                            FirstName = "Ira",
                            PhoneNumber = "050-222-22-22",
                            Surname = "Stepaniuk"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Fedorenko storage",
                            FirstName = "Danial",
                            PhoneNumber = "050-333-33-33",
                            Surname = "Fedorenko"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Dolid delivery",
                            FirstName = "Vova",
                            PhoneNumber = "050-444-44-44",
                            Surname = "Dolid"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.HasOne("DAL.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DAL.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DAL.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
