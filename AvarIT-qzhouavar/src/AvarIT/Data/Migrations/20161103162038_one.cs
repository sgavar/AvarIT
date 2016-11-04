using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvarIT.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OfficeEquipments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeEquipments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OfficeFurnitures",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeFurnitures", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerCases",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvarTagNumber = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    CPUFrequency = table.Column<string>(nullable: false),
                    CPUType = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(nullable: true),
                    HDDSize = table.Column<string>(nullable: false),
                    LANMAC = table.Column<string>(nullable: true),
                    LaptopScreenSize = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: false),
                    ModelNo = table.Column<string>(nullable: false),
                    ModelSeries = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    OEMLicense = table.Column<string>(nullable: true),
                    OEMOperatingSystem = table.Column<string>(nullable: false),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    UpgradeLicense = table.Column<string>(nullable: true),
                    UpgradedTo = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCases", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MiscellaneousItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    ItemType = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
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
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    DVI = table.Column<bool>(nullable: false),
                    HDMI = table.Column<bool>(nullable: false),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    ScreenSize = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    VGA = table.Column<bool>(nullable: false),
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
                    AccessPoint = table.Column<bool>(nullable: false),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cabel = table.Column<bool>(nullable: false),
                    Cost = table.Column<decimal>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    Firewall = table.Column<bool>(nullable: false),
                    LANMAC = table.Column<string>(nullable: true),
                    LANPorts = table.Column<string>(nullable: true),
                    LANSpeed = table.Column<string>(nullable: true),
                    Managed = table.Column<bool>(nullable: false),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Modem = table.Column<bool>(nullable: false),
                    NameOrSSID = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    Router = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    Switch = table.Column<bool>(nullable: false),
                    User = table.Column<string>(nullable: true),
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
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<bool>(nullable: false),
                    CopyScan = table.Column<bool>(nullable: false),
                    Cost = table.Column<decimal>(nullable: true),
                    Dublix = table.Column<bool>(nullable: false),
                    Fax = table.Column<bool>(nullable: false),
                    LAN = table.Column<bool>(nullable: false),
                    LANMAC = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PrinterType = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    USB = table.Column<bool>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    Wireless = table.Column<bool>(nullable: false)
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
                    PropertyName = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "OfficeEquipments");

            migrationBuilder.DropTable(
                name: "OfficeFurnitures");

            migrationBuilder.DropTable(
                name: "ComputerCases");

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");
        }
    }
}
