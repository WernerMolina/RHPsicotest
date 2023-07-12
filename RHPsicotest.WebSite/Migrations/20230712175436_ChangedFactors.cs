using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class ChangedFactors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "12/07/2023 11:54 AM");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 31,
                column: "FactorName",
                value: "Disposición General para la Venta");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 32,
                column: "FactorName",
                value: "Receptividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 33,
                column: "FactorName",
                value: "Agresividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 34,
                column: "FactorName",
                value: "I- Compresión");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 35,
                column: "FactorName",
                value: "II- Adaptabilidad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 36,
                column: "FactorName",
                value: "III- Control de sí mismo");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 37,
                column: "FactorName",
                value: "IV- Tolerancia a la frustración");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 38,
                column: "FactorName",
                value: "V- Combatividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 39,
                column: "FactorName",
                value: "VI- Dominio");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 40,
                column: "FactorName",
                value: "VII- Seguridad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 41,
                column: "FactorName",
                value: "VIII- Actividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 42,
                column: "FactorName",
                value: "IX- Sociabilidad");

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
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "12/07/2023 11:54 AM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "06/07/2023 01:35 PM");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 31,
                column: "FactorName",
                value: "I- Compresión");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 32,
                column: "FactorName",
                value: "II- Adaptabilidad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 33,
                column: "FactorName",
                value: "III- Control de sí mismo");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 34,
                column: "FactorName",
                value: "IV- Tolerancia a la frustración");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 35,
                column: "FactorName",
                value: "V- Combatividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 36,
                column: "FactorName",
                value: "VI- Dominio");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 37,
                column: "FactorName",
                value: "VII- Seguridad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 38,
                column: "FactorName",
                value: "VIII- Actividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 39,
                column: "FactorName",
                value: "IX- Sociabilidad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 40,
                column: "FactorName",
                value: "Disposición General para la Venta");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 41,
                column: "FactorName",
                value: "Receptividad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 42,
                column: "FactorName",
                value: "Agresividad");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "06/07/2023 01:35 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "06/07/2023 01:35 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "06/07/2023 01:35 PM");
        }
    }
}
