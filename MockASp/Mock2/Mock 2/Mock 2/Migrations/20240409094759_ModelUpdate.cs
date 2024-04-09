using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mock_2.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adddresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictID);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    CampusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.CampusID);
                    table.ForeignKey(
                        name: "FK_Campuses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    CommunesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommuneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.CommunesId);
                    table.ForeignKey(
                        name: "FK_Communes_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "DistrictID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookUserID = table.Column<int>(type: "int", nullable: true),
                    GoogleUserID = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ProfileImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityCardFrontSideImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityCardBackSideImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "UserRoles",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Users_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Villages",
                columns: table => new
                {
                    VillageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VillageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommuneID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villages", x => x.VillageId);
                    table.ForeignKey(
                        name: "FK_Villages_Communes_CommuneID",
                        column: x => x.CommuneID,
                        principalTable: "Communes",
                        principalColumn: "CommunesId");
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    HouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerPrice = table.Column<int>(type: "int", nullable: true),
                    WaterPrice = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VillageID = table.Column<int>(type: "int", nullable: true),
                    CampusID = table.Column<int>(type: "int", nullable: true),
                    LandlordID = table.Column<int>(type: "int", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.HouseID);
                    table.ForeignKey(
                        name: "FK_Houses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_Houses_Campuses_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campuses",
                        principalColumn: "CampusID");
                    table.ForeignKey(
                        name: "FK_Houses_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Houses_Users_LandlordID",
                        column: x => x.LandlordID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Houses_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Houses_Villages_VillageID",
                        column: x => x.VillageID,
                        principalTable: "Villages",
                        principalColumn: "VillageId");
                });

            migrationBuilder.CreateTable(
                name: "HouseImages",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HousesHouseID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseImages", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_HouseImages_Houses_HousesHouseID",
                        column: x => x.HousesHouseID,
                        principalTable: "Houses",
                        principalColumn: "HouseID");
                    table.ForeignKey(
                        name: "FK_HouseImages_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_HouseImages_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandLordReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HouseID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.RateID);
                    table.ForeignKey(
                        name: "FK_Rates_Houses_HouseID",
                        column: x => x.HouseID,
                        principalTable: "Houses",
                        principalColumn: "HouseID");
                    table.ForeignKey(
                        name: "FK_Rates_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Rates_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Rates_Users_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Report_Houses_HouseID",
                        column: x => x.HouseID,
                        principalTable: "Houses",
                        principalColumn: "HouseID");
                    table.ForeignKey(
                        name: "FK_Report_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Report_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Report_Users_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RooomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Airon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<float>(type: "real", nullable: true),
                    MaxAmountOfPeople = table.Column<int>(type: "int", nullable: true),
                    CurrentAmountOfPeople = table.Column<int>(type: "int", nullable: true),
                    BuildingNumber = table.Column<int>(type: "int", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: true),
                    HouseID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RooomID);
                    table.ForeignKey(
                        name: "FK_Rooms_Houses_HouseID",
                        column: x => x.HouseID,
                        principalTable: "Houses",
                        principalColumn: "HouseID");
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomType",
                        column: x => x.RoomType,
                        principalTable: "RoomTypes",
                        principalColumn: "RoomTypeId");
                    table.ForeignKey(
                        name: "FK_Rooms_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Rooms_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RoomHistory",
                columns: table => new
                {
                    RoomHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoomID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomHistory", x => x.RoomHistoryID);
                    table.ForeignKey(
                        name: "FK_RoomHistory_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RooomID");
                    table.ForeignKey(
                        name: "FK_RoomHistory_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_RoomHistory_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RoomImages",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoomID = table.Column<int>(type: "int", nullable: true),
                    CreatedByID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_RoomImages_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RooomID");
                    table.ForeignKey(
                        name: "FK_RoomImages_Users_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_RoomImages_Users_LastModifiedByID",
                        column: x => x.LastModifiedByID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleID", "CreatedDate", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4514), "John" },
                    { 2, new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4559), "Mark" },
                    { 3, new DateTime(2024, 4, 9, 16, 47, 58, 360, DateTimeKind.Local).AddTicks(4572), "Lmao" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campuses_AddressID",
                table: "Campuses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Communes_DistrictID",
                table: "Communes",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImages_CreatedByID",
                table: "HouseImages",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImages_HousesHouseID",
                table: "HouseImages",
                column: "HousesHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImages_LastModifiedByID",
                table: "HouseImages",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_AddressID",
                table: "Houses",
                column: "AddressID",
                unique: true,
                filter: "[AddressID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_CampusID",
                table: "Houses",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_CreatedByID",
                table: "Houses",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_LandlordID",
                table: "Houses",
                column: "LandlordID");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_LastModifiedByID",
                table: "Houses",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_VillageID",
                table: "Houses",
                column: "VillageID");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_CreatedByID",
                table: "Rates",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_HouseID",
                table: "Rates",
                column: "HouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_LastModifiedByID",
                table: "Rates",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_StudentID",
                table: "Rates",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_CreatedByID",
                table: "Report",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_HouseID",
                table: "Report",
                column: "HouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_LastModifiedByID",
                table: "Report",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_StudentID",
                table: "Report",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomHistory_CreatedByID",
                table: "RoomHistory",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomHistory_LastModifiedByID",
                table: "RoomHistory",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomHistory_RoomID",
                table: "RoomHistory",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_CreatedByID",
                table: "RoomImages",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_LastModifiedByID",
                table: "RoomImages",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_RoomID",
                table: "RoomImages",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CreatedByID",
                table: "Rooms",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HouseID",
                table: "Rooms",
                column: "HouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_LastModifiedByID",
                table: "Rooms",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomType",
                table: "Rooms",
                column: "RoomType");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StatusID",
                table: "Rooms",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressID",
                table: "Users",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedByID",
                table: "Users",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LastModifiedByID",
                table: "Users",
                column: "LastModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Villages_CommuneID",
                table: "Villages",
                column: "CommuneID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseImages");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "RoomHistory");

            migrationBuilder.DropTable(
                name: "RoomImages");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Campuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Villages");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
