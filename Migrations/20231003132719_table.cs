using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidHealthDeclarationForm.Migrations
{
    public partial class table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CvdHealthDeclarationData",
                columns: table => new
                {
                    VisitorID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carpark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lobby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pantry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TravelHistory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SymptomStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VaccinationStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Haveyoutakencovidtest = table.Column<bool>(type: "bit", nullable: false),
                    Haveyoucontactinfppl = table.Column<bool>(type: "bit", nullable: false),
                    TestResult = table.Column<bool>(type: "bit", nullable: false),
                    Areyoufullyrecovered = table.Column<bool>(type: "bit", nullable: false),
                    Areyouinquarantine = table.Column<bool>(type: "bit", nullable: false),
                    Acknowlegetheinformation = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    SensorDataID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvdHealthDeclarationData", x => x.VisitorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CvdHealthDeclarationData");
        }
    }
}
