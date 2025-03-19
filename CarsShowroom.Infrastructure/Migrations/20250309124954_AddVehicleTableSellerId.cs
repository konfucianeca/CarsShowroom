using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class AddVehicleTableSellerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SellerId",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47f48c0-92d7-4bbd-8a0a-4350ae7e7a4d", "AQAAAAEAACcQAAAAEE844pP61/Eh5m7V1HL8cq7nsIqy/He5Qp+r7dYVFOiAct1QpmesZuGeTXgdwd4HtA==", "742023d8-38ad-4f75-8206-31dadb62ea1c" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellerId",
                value: "guest@mail.com");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellerId",
                value: "guest@mail.com");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellerId",
                value: "guest@mail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e9d2c1-0108-43dd-a8cf-ec678ee13d35", "AQAAAAEAACcQAAAAECZ8MnLTJ1isDc10OJmKoJN5/oidEzwrQPefdx1xzPVX7aVujE78I6AKXQEz2tnZIA==", "3b611b5d-3e85-4e85-b0e0-7f43de8fe5c1" });
        }
    }
}
