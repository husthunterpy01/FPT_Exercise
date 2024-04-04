﻿// <auto-generated />
using Demo1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo1.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DepartmentId = 1,
                            Email = "Stalin123@gmail.com",
                            FirstName = "Jospeh",
                            LastName = "Stalin",
                            PhotoPath = ":C/Image/1"
                        },
                        new
                        {
                            StudentId = 2,
                            DepartmentId = 1,
                            Email = "Lenin23@gmail.com",
                            FirstName = "Vladimir",
                            LastName = "Lenin",
                            PhotoPath = ":C/Image/1"
                        },
                        new
                        {
                            StudentId = 3,
                            DepartmentId = 1,
                            Email = "Kruchev123@gmail.com",
                            FirstName = "Nikita",
                            LastName = "Kruchev",
                            PhotoPath = ":C/Image/1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}