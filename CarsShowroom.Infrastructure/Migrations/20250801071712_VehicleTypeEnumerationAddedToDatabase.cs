using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class VehicleTypeEnumerationAddedToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Vehicle type");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b67b70c7-2eb7-4de5-af9e-57c921de8060", "AQAAAAEAACcQAAAAEMkCgQ4cem3eYdDbvrzitoYGXJ7Lpr3Uv2sRbKlQOmQ4WpLWxUl2MW31NDjetlX6OA==", "04d02211-e6d6-4738-bac5-d1249678f0dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd569380-47ed-4211-b866-48a968134a2e", "AQAAAAEAACcQAAAAEH+PmKVtLNCfpeczNJ32lqVnCi3Pta/gnIxDaKR5dxZppU+gj0J7OG703vCfqad7ag==", "eeb16140-a135-490a-b398-5b6dfd58c2a2" });
        }
    }
}
