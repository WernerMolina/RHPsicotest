using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewsFactors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 02:34 PM");

            migrationBuilder.InsertData(
                table: "Factor",
                columns: new[] { "IdFactor", "DescriptionFactor", "FactorName" },
                values: new object[,]
                {
                    { 27, "", "QI" },
                    { 28, "", "QII" },
                    { 29, "", "QIII" },
                    { 30, "", "QIV" }
                });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "09/06/2023 02:34 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "09/06/2023 02:34 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 02:34 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 12:09 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "09/06/2023 12:09 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "09/06/2023 12:09 AM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 12:09 AM");
        }
    }
}
