using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewsFactors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "06/07/2023 01:35 PM");

            migrationBuilder.InsertData(
                table: "Factor",
                columns: new[] { "IdFactor", "DescriptionFactor", "FactorName" },
                values: new object[,]
                {
                    { 31, "", "I- Compresión" },
                    { 42, "", "Agresividad" },
                    { 41, "", "Receptividad" },
                    { 39, "", "IX- Sociabilidad" },
                    { 38, "", "VIII- Actividad" },
                    { 40, "", "Disposición General para la Venta" },
                    { 36, "", "VI- Dominio" },
                    { 35, "", "V- Combatividad" },
                    { 34, "", "IV- Tolerancia a la frustración" },
                    { 33, "", "III- Control de sí mismo" },
                    { 32, "", "II- Adaptabilidad" },
                    { 37, "", "VII- Seguridad" }
                });

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
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 5,
                column: "NameTest",
                value: "16PF Forma A");

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 6,
                column: "NameTest",
                value: "16PF Forma B");

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "IdTest", "Link", "NameTest", "Time" },
                values: new object[] { 7, "Test_IPV", "IPV", "60 min." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "06/07/2023 01:35 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 02:34 PM");

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
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 5,
                column: "NameTest",
                value: "16PF Forma B");

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 6,
                column: "NameTest",
                value: "16PF Forma A");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 02:34 PM");
        }
    }
}
