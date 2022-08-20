﻿// <auto-generated />
using BookTrackingApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackingApp.Migrations
{
    [DbContext(typeof(BookTrackingDataContext))]
    [Migration("20211214082804_BookTrackingAppMigration3")]
    partial class BookTrackingAppMigration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTrackingApp.Models.BookModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("BookId");

                    b.HasIndex("Category");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("NameToken")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("Type");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryTypeModel", b =>
                {
                    b.Property<int>("CategoryTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("CategoryTypeId");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("BookTrackingApp.Models.BookModel", b =>
                {
                    b.HasOne("BookTrackingApp.Models.CategoryModel", "CategoryModel")
                        .WithMany("BookList")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryModel");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryModel", b =>
                {
                    b.HasOne("BookTrackingApp.Models.CategoryTypeModel", "CategoryTypeModel")
                        .WithMany("CategoryList")
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryTypeModel");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryModel", b =>
                {
                    b.Navigation("BookList");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryTypeModel", b =>
                {
                    b.Navigation("CategoryList");
                });
#pragma warning restore 612, 618
        }
    }
}
