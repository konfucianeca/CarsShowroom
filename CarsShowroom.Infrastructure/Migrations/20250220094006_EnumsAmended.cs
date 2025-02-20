using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class EnumsAmended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Condition",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e9d2c1-0108-43dd-a8cf-ec678ee13d35", "AQAAAAEAACcQAAAAECZ8MnLTJ1isDc10OJmKoJN5/oidEzwrQPefdx1xzPVX7aVujE78I6AKXQEz2tnZIA==", "3b611b5d-3e85-4e85-b0e0-7f43de8fe5c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Condition",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4008d68-4762-40de-9961-a29aff7ecc52", "AQAAAAEAACcQAAAAENDhPlyejNc1uJUEM8g2DtecV1ibKVVo8o5zKWPseUsKSeCRqIbkFV+Ud7W9YXQx3w==", "b255ebac-d256-4ed0-9245-a60e3a8fd5d8" });
        }
    }
}
