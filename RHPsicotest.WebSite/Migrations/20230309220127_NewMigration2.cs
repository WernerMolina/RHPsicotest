using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Position_Test_IdTest",
                table: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Position_IdTest",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "IdTest",
                table: "Position");

            migrationBuilder.CreateTable(
                name: "Test_Position",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Position", x => new { x.IdTest, x.IdPosition });
                    table.ForeignKey(
                        name: "FK_Test_Position_Position_IdPosition",
                        column: x => x.IdPosition,
                        principalTable: "Position",
                        principalColumn: "IdPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Position_Test_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/03/2023 04:01 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "09/03/2023 04:01 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "09/03/2023 04:01 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/03/2023 04:01 PM");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Position_IdPosition",
                table: "Test_Position",
                column: "IdPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test_Position");

            migrationBuilder.AddColumn<int>(
                name: "IdTest",
                table: "Position",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "08/03/2023 11:09 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                columns: new[] { "CreationDate", "IdTest" },
                values: new object[] { "08/03/2023 11:09 AM", 1 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                columns: new[] { "CreationDate", "IdTest" },
                values: new object[] { "08/03/2023 11:09 AM", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "08/03/2023 11:09 AM");

            migrationBuilder.CreateIndex(
                name: "IX_Position_IdTest",
                table: "Position",
                column: "IdTest");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Test_IdTest",
                table: "Position",
                column: "IdTest",
                principalTable: "Test",
                principalColumn: "IdTest",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
