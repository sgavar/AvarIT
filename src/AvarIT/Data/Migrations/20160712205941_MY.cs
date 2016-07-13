using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvarIT.Data.Migrations
{
    public partial class MY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MiscellaneousItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    ItemType = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscellaneousItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    DVI = table.Column<string>(nullable: true),
                    HDMI = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    VGA = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NetWorks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessPoint = table.Column<string>(nullable: true),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cabel = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    Firewall = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    LANPorts = table.Column<string>(nullable: true),
                    LANSpeed = table.Column<string>(nullable: true),
                    Managed = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Modem = table.Column<string>(nullable: true),
                    NameOrSSID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<string>(nullable: true),
                    Router = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Switch = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    WirelessType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetWorks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CopyScan = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    Dublix = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    LAN = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PrinterType = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    USB = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    Wireless = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlName = table.Column<string>(nullable: true),
                    ControlType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ElementName = table.Column<string>(nullable: true),
                    ElementType = table.Column<string>(nullable: true),
                    IssueType = table.Column<string>(nullable: true),
                    IssueTypeID = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerCases",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CPUFrequency = table.Column<string>(nullable: true),
                    CPUType = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    HDDSize = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    LaptopScreenSize = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OEMLicense = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    UpgradeLicense = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCases", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComputerCases_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationSystems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComputerCaseID = table.Column<int>(nullable: true),
                    ComputerCaseID1 = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSystems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OperationSystems_ComputerCases_ComputerCaseID",
                        column: x => x.ComputerCaseID,
                        principalTable: "ComputerCases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationSystems_ComputerCases_ComputerCaseID1",
                        column: x => x.ComputerCaseID1,
                        principalTable: "ComputerCases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerCases_EmployeeId",
                table: "ComputerCases",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSystems_ComputerCaseID",
                table: "OperationSystems",
                column: "ComputerCaseID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSystems_ComputerCaseID1",
                table: "OperationSystems",
                column: "ComputerCaseID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiscellaneousItems");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "NetWorks");

            migrationBuilder.DropTable(
                name: "OperationSystems");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "ComputerCases");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
