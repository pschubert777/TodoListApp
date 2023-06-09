﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoListApp.Data;

#nullable disable

namespace TodoListApp.Migrations
{
    [DbContext(typeof(TodoListDbContext))]
    [Migration("20230505024745_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoListApp.Data.TodoData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Todo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6cd25b50-ee4c-4fe0-a0eb-4df276d1f9fc"),
                            Description = "Clean up your room before your friends come over - Granny",
                            DueDate = new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Clean up Room"
                        },
                        new
                        {
                            Id = new Guid("f5e51c5c-868e-4beb-8b12-eb79b3cc7dd3"),
                            Description = "Destroy AAli and Edward at Settler's of Catan",
                            DueDate = new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Name = "Play board games w/ Ali and Edward"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
