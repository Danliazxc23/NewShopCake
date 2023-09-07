﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopTortApp.Storage;

#nullable disable

namespace ShopTortApp.Storage.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230907163626_addfixtip")]
    partial class addfixtip
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Cake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FavoriteId")
                        .HasColumnType("int");

                    b.Property<int>("FavorityId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteId");

                    b.ToTable("cakes");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("contacts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("counterCake")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameCake")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("favorite");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Filling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("fillings");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CakeId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FillingId")
                        .HasColumnType("int");

                    b.Property<int>("counterCake")
                        .HasColumnType("int");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CakeId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FillingId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Cake", b =>
                {
                    b.HasOne("ShopTortApp.Storage.Entities.Favorite", "Favorite")
                        .WithMany("Cakes")
                        .HasForeignKey("FavoriteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Favorite");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Order", b =>
                {
                    b.HasOne("ShopTortApp.Storage.Entities.Cake", "Cake")
                        .WithMany("orders")
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopTortApp.Storage.Entities.Client", "Client")
                        .WithMany("orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopTortApp.Storage.Entities.Filling", "Filling")
                        .WithMany("orders")
                        .HasForeignKey("FillingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cake");

                    b.Navigation("Client");

                    b.Navigation("Filling");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Cake", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Client", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Favorite", b =>
                {
                    b.Navigation("Cakes");
                });

            modelBuilder.Entity("ShopTortApp.Storage.Entities.Filling", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
