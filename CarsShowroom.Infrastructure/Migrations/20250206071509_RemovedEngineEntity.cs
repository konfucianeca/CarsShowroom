using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class RemovedEngineEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Engines_EngineId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "Displacement",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Vehicle engine type");

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0031abdc-2f86-4744-b7f9-ebca9c83490d", "AQAAAAEAACcQAAAAEBFFQSakOACTZapMegohT7KYAfS2hsYX98+hFi+MINpK5tWMJhezZEZvYX6UhcEFZg==", "2cf92dc6-5ac3-48c8-af0a-e9a99399283e" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Displacement", "EngineType", "Power" },
                values: new object[] { 3000, 2, 306 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Displacement", "EngineType", "Power" },
                values: new object[] { 2200, 2, 197 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Displacement", "EngineType", "Power" },
                values: new object[] { 2200, 1, 150 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Displacement",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EngineType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Engine identifier");

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Engine identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    EngineType = table.Column<int>(type: "int", nullable: false, comment: "Vehicle engine type"),
                    Power = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                },
                comment: "Vehicle engine");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1b8410c-8a6a-4da1-a90e-ce0c55923203", "AQAAAAEAACcQAAAAEOJCRtHknrznulxOBELQHqsr9RnQiwhCRoSxM8OSa5W58qFpgKFqdGbuxtlG1eQP5w==", "52316cee-6897-4ada-a43a-40063b4d7980" });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "Displacement", "EngineType", "Power" },
                values: new object[,]
                {
                    { 1, 3000, 2, 306 },
                    { 2, 2200, 2, 197 },
                    { 3, 2200, 1, 150 }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "EngineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "EngineId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "EngineId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Engines_EngineId",
                table: "Vehicles",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
