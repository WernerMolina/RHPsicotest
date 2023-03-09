using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class DescriptionFactorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionFactor",
                table: "Factor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "08/03/2023 11:09 AM");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 1,
                column: "DescriptionFactor",
                value: "Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 2,
                column: "DescriptionFactor",
                value: "Rasgo que alude a la constancia y perseverancia en las tareas propuestas.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 3,
                column: "DescriptionFactor",
                value: "Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 4,
                column: "DescriptionFactor",
                value: "Rasgo que facilita el trato con los demás.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 5,
                column: "DescriptionFactor",
                value: "Es el tipo de conducta caracterizada por prever las situaciones o efectos de una decisión antes de actuar.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 6,
                column: "DescriptionFactor",
                value: "Rango de conducta que se manifiesta por la búsqueda de autenticidad en todo lo que hace.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 7,
                column: "DescriptionFactor",
                value: "Grado en el cual somos capaces de interpretar o asimilar acontecimientos y hechos particulares o de la vida diaria.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 8,
                column: "DescriptionFactor",
                value: "Se dice de la energía psíquica o física que se agrega a cada actividad que se emprende.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 9,
                column: "DescriptionFactor",
                value: "Es la valoración positiva o negativa que uno hace de sí mismo.");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "08/03/2023 11:09 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "08/03/2023 11:09 AM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "08/03/2023 11:09 AM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionFactor",
                table: "Factor");

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "05/03/2023 09:12 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "05/03/2023 09:12 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "05/03/2023 09:12 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "05/03/2023 09:12 PM");
        }
    }
}
