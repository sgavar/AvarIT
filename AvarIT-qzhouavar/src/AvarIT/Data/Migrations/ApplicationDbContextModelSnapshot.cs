using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AvarIT.Data;

namespace AvarIT.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-preview1-22509")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvarIT.Models.AccountingViewModels.Computer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("ItemName");

                    b.Property<string>("Note");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("AvarIT.Models.AccountingViewModels.OfficeEquipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("ItemName");

                    b.Property<string>("Note");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("OfficeEquipments");
                });

            modelBuilder.Entity("AvarIT.Models.AccountingViewModels.OfficeFurniture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("ItemName");

                    b.Property<string>("Note");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("OfficeFurnitures");
                });

            modelBuilder.Entity("AvarIT.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.ComputerCase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvarTagNumber")
                        .IsRequired();

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<string>("CPUFrequency")
                        .IsRequired();

                    b.Property<string>("CPUType")
                        .IsRequired();

                    b.Property<decimal?>("Cost");

                    b.Property<string>("HDDSize")
                        .IsRequired();

                    b.Property<string>("LANMAC");

                    b.Property<string>("LaptopScreenSize");

                    b.Property<string>("MachineName");

                    b.Property<string>("MemorySize")
                        .IsRequired();

                    b.Property<string>("ModelNo")
                        .IsRequired();

                    b.Property<string>("ModelSeries")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("OEMLicense");

                    b.Property<string>("OEMOperatingSystem")
                        .IsRequired();

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("UpgradeLicense");

                    b.Property<string>("UpgradedTo")
                        .IsRequired();

                    b.Property<string>("User")
                        .IsRequired();

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.ToTable("ComputerCases");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Miscellaneous", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<decimal?>("Cost");

                    b.Property<string>("ItemType");

                    b.Property<string>("LANMAC");

                    b.Property<string>("License");

                    b.Property<string>("MachineName");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("User");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.ToTable("MiscellaneousItems");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Monitor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<decimal?>("Cost");

                    b.Property<bool>("DVI");

                    b.Property<bool>("HDMI");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<string>("ScreenSize");

                    b.Property<string>("ScreenType");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("User");

                    b.Property<bool>("VGA");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.NetWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AccessPoint");

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<bool>("Cabel");

                    b.Property<decimal?>("Cost");

                    b.Property<string>("DeviceType");

                    b.Property<bool>("Firewall");

                    b.Property<string>("LANMAC");

                    b.Property<string>("LANPorts");

                    b.Property<string>("LANSpeed");

                    b.Property<bool>("Managed");

                    b.Property<string>("MemorySize");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<bool>("Modem");

                    b.Property<string>("NameOrSSID");

                    b.Property<string>("Notes");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<bool>("Router");

                    b.Property<string>("SerialNumber");

                    b.Property<bool>("Switch");

                    b.Property<string>("User");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.Property<string>("WirelessType");

                    b.HasKey("ID");

                    b.ToTable("NetWorks");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Printer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<bool>("Color");

                    b.Property<bool>("CopyScan");

                    b.Property<decimal?>("Cost");

                    b.Property<bool>("Dublix");

                    b.Property<bool>("Fax");

                    b.Property<bool>("LAN");

                    b.Property<string>("LANMAC");

                    b.Property<string>("MachineName");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<string>("PrinterType");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<bool>("USB");

                    b.Property<string>("User");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.Property<bool>("Wireless");

                    b.HasKey("ID");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.WebCompatibilityIssues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ControlName");

                    b.Property<string>("ControlType");

                    b.Property<string>("Description");

                    b.Property<string>("ElementName");

                    b.Property<string>("ElementType");

                    b.Property<string>("IssueType");

                    b.Property<string>("IssueTypeID");

                    b.Property<string>("PropertyName");

                    b.Property<string>("Url");

                    b.HasKey("ID");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
