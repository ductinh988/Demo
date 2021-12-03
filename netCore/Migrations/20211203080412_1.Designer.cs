﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netCore.Data;

namespace netCore.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211203080412_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("netCore.Models.Account", b =>
                {
                    b.Property<string>("AccountID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.HasKey("AccountID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("netCore.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("netCore.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("netCore.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("netCore.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("netCore.Models.Employee", b =>
                {
                    b.HasBaseType("netCore.Models.Movie");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("netCore.Models.Student", b =>
                {
                    b.HasBaseType("netCore.Models.Person");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("netCore.Models.Account", b =>
                {
                    b.HasOne("netCore.Models.Category", "Category")
                        .WithMany("Accounts")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("netCore.Models.Product", b =>
                {
                    b.HasOne("netCore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("netCore.Models.Employee", b =>
                {
                    b.HasOne("netCore.Models.Movie", null)
                        .WithOne()
                        .HasForeignKey("netCore.Models.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("netCore.Models.Student", b =>
                {
                    b.HasOne("netCore.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("netCore.Models.Student", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("netCore.Models.Category", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
