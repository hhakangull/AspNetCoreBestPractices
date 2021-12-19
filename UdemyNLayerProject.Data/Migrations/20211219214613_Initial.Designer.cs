﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyNLayerProject.Data;

namespace UdemyNLayerProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211219214613_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Kalemler Description",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Pilot Kalem",
                            Price = 12.50m,
                            Stock = 400
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Kalemler Description 2 kurşun kalem",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Kurşun Kalem",
                            Price = 4.30m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Kalemler Description 3 Tükenmez kalem",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Tükenmez Kalem",
                            Price = 34.30m,
                            Stock = 550
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Küçük defter Description 1",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Küçük boy defter",
                            Price = 22.50m,
                            Stock = 410
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Orta defter Description 2",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Orta boy defter",
                            Price = 22.50m,
                            Stock = 420
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Büyük defter Description 2",
                            InnerBarcode = "12312",
                            IsDeleted = false,
                            Name = "Büyük boy defter",
                            Price = 22.50m,
                            Stock = 120
                        });
                });

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Product", b =>
                {
                    b.HasOne("UdemyNLayerProject.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}