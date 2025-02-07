using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class DataBaseChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c9639d0-c908-4803-958f-a502d802d883", "AQAAAAEAACcQAAAAED/1D5lHKys87n55hMACVI2WSrjJtWYZWNsPGYYPwGHmRSssZijwsacYiZmi2ec/kg==", "36ed7444-ef15-4b7e-92dc-3a227e13dcfd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0031abdc-2f86-4744-b7f9-ebca9c83490d", "AQAAAAEAACcQAAAAEBFFQSakOACTZapMegohT7KYAfS2hsYX98+hFi+MINpK5tWMJhezZEZvYX6UhcEFZg==", "2cf92dc6-5ac3-48c8-af0a-e9a99399283e" });
        }
    }
}
