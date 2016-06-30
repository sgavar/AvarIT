using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvarIT.Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerCasegs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CPUFrequency = table.Column<string>(nullable: true),
                    CPUType = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    HDDSize = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    LaptopScreenSize = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OEMLicense = table.Column<string>(nullable: true),
                    OEMOperatingSystem = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    UpgradeLicense = table.Column<string>(nullable: true),
                    UpgradedTo = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCasegs", x => x.ID);
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
                    Cost = table.Column<decimal>(nullable: false),
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
                    PurchaseDate = table.Column<DateTime>(nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerCasegs");

            migrationBuilder.DropTable(
                name: "MiscellaneousItems");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "NetWorks");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Issues");
        }
    }
}
