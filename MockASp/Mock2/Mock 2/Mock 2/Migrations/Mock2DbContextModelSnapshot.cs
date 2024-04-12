﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mock_2.Data;

#nullable disable

namespace Mock_2.Migrations
{
    [DbContext(typeof(HouseRentalDbContext))]
    partial class Mock2DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mock_2.Model.Entity.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("Adddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoogleMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifieddate")
                        .HasColumnType("datetime2");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Campus", b =>
                {
                    b.Property<int>("CampusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampusID"));

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("CampusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CampusID");

                    b.HasIndex("AddressID");

                    b.ToTable("Campuses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Commune", b =>
                {
                    b.Property<int>("CommunesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommunesId"));

                    b.Property<string>("CommuneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DistrictID")
                        .HasColumnType("int");

                    b.HasKey("CommunesId");

                    b.HasIndex("DistrictID");

                    b.ToTable("Communes");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.District", b =>
                {
                    b.Property<int>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictID");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.House", b =>
                {
                    b.Property<int>("HouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseID"));

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("CampusID")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LandlordID")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PowerPrice")
                        .HasColumnType("int");

                    b.Property<int?>("VillageID")
                        .HasColumnType("int");

                    b.Property<int?>("WaterPrice")
                        .HasColumnType("int");

                    b.HasKey("HouseID");

                    b.HasIndex("AddressID")
                        .IsUnique()
                        .HasFilter("[AddressID] IS NOT NULL");

                    b.HasIndex("CampusID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("LandlordID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("VillageID");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.HouseImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HousesHouseID")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("HousesHouseID");

                    b.HasIndex("LastModifiedByID");

                    b.ToTable("HouseImages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Rate", b =>
                {
                    b.Property<int>("RateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateID"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HouseID")
                        .HasColumnType("int");

                    b.Property<string>("LandLordReply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Star")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("RateID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("StudentID");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Report", b =>
                {
                    b.Property<int?>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ReportID"));

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HouseID")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ReportID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("StudentID");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Room", b =>
                {
                    b.Property<int>("RooomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RooomID"));

                    b.Property<string>("Airon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Area")
                        .HasColumnType("real");

                    b.Property<int?>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrentAmountOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<int?>("HouseID")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaxAmountOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomType")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("RooomID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("HouseID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("RoomType");

                    b.HasIndex("StatusID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomHistory", b =>
                {
                    b.Property<int>("RoomHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomHistoryID"));

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("RoomHistoryID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomHistory");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("ImageID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomImages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeId"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacebookUserID")
                        .HasColumnType("int");

                    b.Property<int?>("GoogleUserID")
                        .HasColumnType("int");

                    b.Property<string>("IdentityCardBackSideImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardFrontSideImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LastModifiedByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProfileImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("LastModifiedByID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.UserRole", b =>
                {
                    b.Property<int?>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("RoleID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            CreatedDate = new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4514),
                            RoleName = "John"
                        },
                        new
                        {
                            RoleID = 2,
                            CreatedDate = new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4559),
                            RoleName = "Mark"
                        },
                        new
                        {
                            RoleID = 3,
                            CreatedDate = new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4572),
                            RoleName = "Lmao"
                        });
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Village", b =>
                {
                    b.Property<int>("VillageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VillageId"));

                    b.Property<int?>("CommuneID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VillageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VillageId");

                    b.HasIndex("CommuneID");

                    b.ToTable("Villages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Campus", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.Address", "Addresses")
                        .WithMany("Campuses")
                        .HasForeignKey("AddressID");

                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Commune", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.District", "Districts")
                        .WithMany("Communes")
                        .HasForeignKey("DistrictID");

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.House", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.Address", "Addresses")
                        .WithOne("Houses")
                        .HasForeignKey("Mock_2.Model.Entity.House", "AddressID");

                    b.HasOne("Mock_2.Model.Entity.Campus", "Campuses")
                        .WithMany("Houses")
                        .HasForeignKey("CampusID");

                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "Landlord")
                        .WithMany()
                        .HasForeignKey("LandlordID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.Village", "Villages")
                        .WithMany("Houses")
                        .HasForeignKey("VillageID");

                    b.Navigation("Addresses");

                    b.Navigation("Campuses");

                    b.Navigation("CreatedBy");

                    b.Navigation("Landlord");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Villages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.HouseImage", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.House", "Houses")
                        .WithMany("HouseImages")
                        .HasForeignKey("HousesHouseID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.Navigation("CreatedBy");

                    b.Navigation("Houses");

                    b.Navigation("LastModifiedBy");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Rate", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.House", "House")
                        .WithMany("Rate")
                        .HasForeignKey("HouseID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID");

                    b.Navigation("CreatedBy");

                    b.Navigation("House");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Report", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.House", "House")
                        .WithMany("Reports")
                        .HasForeignKey("HouseID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID");

                    b.Navigation("CreatedBy");

                    b.Navigation("House");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Room", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.House", "Houses")
                        .WithMany("Rooms")
                        .HasForeignKey("HouseID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.RoomType", "RoomTypes")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomType");

                    b.HasOne("Mock_2.Model.Entity.Status", "Statuses")
                        .WithMany("Rooms")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Houses");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("RoomTypes");

                    b.Navigation("Statuses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomHistory", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.Room", "Rooms")
                        .WithMany("RoomHistories")
                        .HasForeignKey("RoomID");

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomImage", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.Room", "Rooms")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomID");

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.User", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.Address", "Addresses")
                        .WithMany("Users")
                        .HasForeignKey("AddressID");

                    b.HasOne("Mock_2.Model.Entity.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("Mock_2.Model.Entity.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByID");

                    b.HasOne("Mock_2.Model.Entity.UserRole", "UserRoles")
                        .WithMany("Users")
                        .HasForeignKey("RoleID");

                    b.Navigation("Addresses");

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Village", b =>
                {
                    b.HasOne("Mock_2.Model.Entity.Commune", "Communes")
                        .WithMany("Villages")
                        .HasForeignKey("CommuneID");

                    b.Navigation("Communes");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Address", b =>
                {
                    b.Navigation("Campuses");

                    b.Navigation("Houses");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Campus", b =>
                {
                    b.Navigation("Houses");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Commune", b =>
                {
                    b.Navigation("Villages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.District", b =>
                {
                    b.Navigation("Communes");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.House", b =>
                {
                    b.Navigation("HouseImages");

                    b.Navigation("Rate");

                    b.Navigation("Reports");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Room", b =>
                {
                    b.Navigation("RoomHistories");

                    b.Navigation("RoomImages");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Status", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.UserRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Mock_2.Model.Entity.Village", b =>
                {
                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}