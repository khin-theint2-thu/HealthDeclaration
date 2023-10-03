using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidHealthDeclarationForm.Migrations
{
    public partial class bugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLog",
                columns: table => new
                {
                    ActivityLogID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLog", x => x.ActivityLogID);
                });

            migrationBuilder.CreateTable(
                name: "HealthDeclarationData",
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
                    table.PrimaryKey("PK_HealthDeclarationData", x => x.VisitorID);
                });

            migrationBuilder.CreateTable(
                name: "SensorData",
                columns: table => new
                {
                    SensorDataID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeviceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeviceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Humidity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Occupancy = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorData", x => x.SensorDataID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLog");

            migrationBuilder.DropTable(
                name: "HealthDeclarationData");

            migrationBuilder.DropTable(
                name: "SensorData");
        }
    }
}
