using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpHolidayBookingAppData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    HolidayId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HolidayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.HolidayId);
                });

            migrationBuilder.CreateTable(
                name: "HolidayRequestLogs",
                columns: table => new
                {
                    HolidayRequestLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    HolidayId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayRequestLogs", x => x.HolidayRequestLogID);
                    table.ForeignKey(
                        name: "FK_HolidayRequestLogs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HolidayRequestLogs_Holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "Holidays",
                        principalColumn: "HolidayId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolidayRequestLogID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerID);
                    table.ForeignKey(
                        name: "FK_Managers_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Managers_HolidayRequestLogs_HolidayRequestLogID",
                        column: x => x.HolidayRequestLogID,
                        principalTable: "HolidayRequestLogs",
                        principalColumn: "HolidayRequestLogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HolidayRequestLogs_EmployeeID",
                table: "HolidayRequestLogs",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayRequestLogs_HolidayId",
                table: "HolidayRequestLogs",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayRequestLogs_ManagerID",
                table: "HolidayRequestLogs",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_EmployeeID",
                table: "Managers",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_HolidayRequestLogID",
                table: "Managers",
                column: "HolidayRequestLogID");

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayRequestLogs_Managers_ManagerID",
                table: "HolidayRequestLogs",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ManagerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HolidayRequestLogs_Employees_EmployeeID",
                table: "HolidayRequestLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Employees_EmployeeID",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_HolidayRequestLogs_Holidays_HolidayId",
                table: "HolidayRequestLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_HolidayRequestLogs_Managers_ManagerID",
                table: "HolidayRequestLogs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "HolidayRequestLogs");
        }
    }
}
