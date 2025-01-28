using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class DatabaseSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Customer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Customer name"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false, comment: "Customer name"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Customer address"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Cars showroom customer");

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Engine identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineType = table.Column<int>(type: "int", nullable: false, comment: "Vehicle engine type"),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                },
                comment: "Vehicle engine");

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Manufacturer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Vehicle manufacturer name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                },
                comment: "Vehicle producer");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Vehicle identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Vehicle model"),
                    Condition = table.Column<int>(type: "int", nullable: true),
                    YearOfProduction = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Vehicle production year"),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Settlement where vehicle is"),
                    Gearbox = table.Column<int>(type: "int", nullable: false, comment: "What type gearbox fitted on the vehicle"),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Vehicle color"),
                    Mileage = table.Column<int>(type: "int", nullable: false, comment: "Total distance driven by car up to now"),
                    Features = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Vehicle additional equipment"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Car price"),
                    ImageUrl = table.Column<string>(type: "nvarchar(2083)", maxLength: 2083, nullable: false, comment: "Vehicle image"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false, comment: "Manufacturer identifier"),
                    EngineId = table.Column<int>(type: "int", nullable: false, comment: "Engine identifier"),
                    CustomerId = table.Column<int>(type: "int", nullable: false, comment: "Customer identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Vehicle to sale");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Appointment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false, comment: "Date of appointment"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Appointment for test drive or inspection");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Sale identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date sale took place"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Customer sales");

            migrationBuilder.CreateTable(
                name: "TestDrives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Test drive identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestStart = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time test drive starts"),
                    TestEnd = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time test drive ends"),
                    TestNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Notes over test drive results"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDrives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestDrives_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestDrives_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestDrives_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                },
                comment: "Customer test drive for particular vehicle");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de", 0, "d1b8410c-8a6a-4da1-a90e-ce0c55923203", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEOJCRtHknrznulxOBELQHqsr9RnQiwhCRoSxM8OSa5W58qFpgKFqdGbuxtlG1eQP5w==", null, false, "52316cee-6897-4ada-a43a-40063b4d7980", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "Displacement", "EngineType", "Power" },
                values: new object[,]
                {
                    { 1, 3000, 2, 306 },
                    { 2, 2200, 2, 197 },
                    { 3, 2200, 1, 150 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Hyundai" },
                    { 3, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Name", "UserId" },
                values: new object[] { 1, "Varna, Pirin Str, 45", new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petar Petrov", "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "CustomerId", "EngineId", "Features", "Gearbox", "ImageUrl", "ManufacturerId", "Mileage", "Model", "Price", "Region", "YearOfProduction" },
                values: new object[] { 1, "Black", 1, 1, 1, "4x4, ABS, ESP, Airbag, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Центр. заключване, Старт-Стоп система, Безключово палене", 3, "https://automoto.bg/listings/media/listing//1709991365_nis5vfph.jpg", 1, 178000, "X5 3.5i Xdrive", 41500.00m, "Plovdiv", "2016" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "CustomerId", "EngineId", "Features", "Gearbox", "ImageUrl", "ManufacturerId", "Mileage", "Model", "Price", "Region", "YearOfProduction" },
                values: new object[] { 2, "Grey metalic", 1, 1, 2, "4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка, Старт-Стоп система, Безключово палене", 2, "https://automoto.bg/listings/media/listing//1720295931_img-209442bc4babdf576e0cf1740ae33342-v.jpg", 2, 174000, "Santa Fe 2.2CRDI - 4WD", 34000.00m, "Lovech", "2014" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "CustomerId", "EngineId", "Features", "Gearbox", "ImageUrl", "ManufacturerId", "Mileage", "Model", "Price", "Region", "YearOfProduction" },
                values: new object[] { 3, "Red", 2, 1, 3, "  4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка", 1, "https://automoto.bg/listings/media/listing//1725859766_uml1.jpg", 3, 209000, "Honda CR-V 2.2", 19000.00m, "Smolyan", "2011" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VehicleId",
                table: "Appointments",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TestDrives_AppointmentId",
                table: "TestDrives",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestDrives_CustomerId",
                table: "TestDrives",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TestDrives_VehicleId",
                table: "TestDrives",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ManufacturerId",
                table: "Vehicles",
                column: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "TestDrives");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de");
        }
    }
}
