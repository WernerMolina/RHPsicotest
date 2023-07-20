using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewChangesNormalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionFactor",
                table: "Factor");

            migrationBuilder.AddColumn<string>(
                name: "EmailNormalized",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleNameNormalized",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailNormalized",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                columns: new[] { "EmailNormalized", "RegistrationDate" },
                values: new object[] { "ML22002@ESFE.AGAPE.EDU.SV", "20/07/2023 04:45 PM" });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "20/07/2023 04:45 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "20/07/2023 04:45 PM");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 1,
                column: "RoleNameNormalized",
                value: "SUPER-ADMIN");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 2,
                columns: new[] { "RoleName", "RoleNameNormalized" },
                values: new object[] { "Candidato", "CANDIDATO" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 3,
                columns: new[] { "RoleName", "RoleNameNormalized" },
                values: new object[] { "Administrador", "ADMINISTRADOR" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "EmailNormalized", "RegistrationDate" },
                values: new object[] { "WM25@GMAIL.COM", "20/07/2023 04:45 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailNormalized",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleNameNormalized",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "EmailNormalized",
                table: "Candidate");

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
                value: "12/07/2023 11:54 AM");

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
                value: "Cautela: Es el tipo de conducta caracterizada por prever las situaciones o efectos de una decisión antes de actuar.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 6,
                column: "DescriptionFactor",
                value: "Originalidad: Rango de conducta que se manifiesta por la búsqueda de autenticidad en todo lo que hace.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 7,
                column: "DescriptionFactor",
                value: "Comprensión: Grado en el cual somos capaces de interpretar o asimilar acontecimientos y hechos particulares o de la vida diaria.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 8,
                column: "DescriptionFactor",
                value: "Vitalidad: Se dice de la energía psíquica o física que se agrega a cada actividad que se emprende.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 9,
                column: "DescriptionFactor",
                value: "Autoestima: Es la valoración positiva o negativa que uno hace de sí mismo.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 10,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 11,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 12,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 13,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 14,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 15,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 16,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 17,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 18,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 19,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 20,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 21,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 22,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 23,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 24,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 25,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 26,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 27,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 28,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 29,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 30,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 31,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 32,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 33,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 34,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 35,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 36,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 37,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 38,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 39,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 40,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 41,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 42,
                column: "DescriptionFactor",
                value: "");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "12/07/2023 11:54 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "12/07/2023 11:54 AM");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 2,
                column: "RoleName",
                value: "Administrador");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 3,
                column: "RoleName",
                value: "Candidato");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "12/07/2023 11:54 AM");
        }
    }
}
