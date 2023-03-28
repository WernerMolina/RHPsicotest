using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class TestCandidateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Test",
                newName: "Time");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Test",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Test_Candidate",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdCandidate = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Candidate", x => new { x.IdCandidate, x.IdTest });
                    table.ForeignKey(
                        name: "FK_Test_Candidate_Candidate_IdCandidate",
                        column: x => x.IdCandidate,
                        principalTable: "Candidate",
                        principalColumn: "IdCandidate",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Candidate_Test_IdTest",
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
                value: "27/03/2023 06:08 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "27/03/2023 06:08 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "27/03/2023 06:08 PM");

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 1,
                columns: new[] { "Link", "Time" },
                values: new object[] { "Test_PPGIPG", "45 min." });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "IdTest", "Link", "NameTest", "Time" },
                values: new object[,]
                {
                    { 1, "Test_PPGIPG", "PPG-IPG", "45 min." },
                    { 2, "Test_OTIS", "OTIS", "45 min." },
                    { 3, "Test_Dominos", "Dominos", "45 min." },
                    { 4, "Test_BFQ", "BFQ", "45 min." }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "27/03/2023 06:08 PM");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Candidate_IdTest",
                table: "Test_Candidate",
                column: "IdTest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test_Candidate");

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Test");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Test",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "17/03/2023 01:29 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "17/03/2023 01:29 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "17/03/2023 01:29 PM");

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "17/03/2023 01:29 PM");
        }
    }
}
