using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class ChangedDataConstantsItemValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "Vehicles",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "Vehicle additional equipment",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Vehicle additional equipment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd569380-47ed-4211-b866-48a968134a2e", "AQAAAAEAACcQAAAAEH+PmKVtLNCfpeczNJ32lqVnCi3Pta/gnIxDaKR5dxZppU+gj0J7OG703vCfqad7ag==", "eeb16140-a135-490a-b398-5b6dfd58c2a2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "Vehicles",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Vehicle additional equipment",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Vehicle additional equipment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47f48c0-92d7-4bbd-8a0a-4350ae7e7a4d", "AQAAAAEAACcQAAAAEE844pP61/Eh5m7V1HL8cq7nsIqy/He5Qp+r7dYVFOiAct1QpmesZuGeTXgdwd4HtA==", "742023d8-38ad-4f75-8206-31dadb62ea1c" });
        }
    }
}
