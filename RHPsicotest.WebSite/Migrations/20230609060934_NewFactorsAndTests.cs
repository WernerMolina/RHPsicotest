using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewFactorsAndTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 12:09 AM");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 1,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo.", "Ascendencia" });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 2,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Rasgo que alude a la constancia y perseverancia en las tareas propuestas.", "Responsabilidad" });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 3,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa.", "Estabilidad Emocional" });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 4,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Rasgo que facilita el trato con los demás.", "Sociabilidad" });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 5,
                column: "FactorName",
                value: "Cautela");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 6,
                column: "FactorName",
                value: "Originalidad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 7,
                column: "FactorName",
                value: "Comprensión");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 8,
                column: "FactorName",
                value: "Vitalidad");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 9,
                column: "FactorName",
                value: "Autoestima");

            migrationBuilder.InsertData(
                table: "Factor",
                columns: new[] { "IdFactor", "DescriptionFactor", "FactorName" },
                values: new object[,]
                {
                    { 11, "", "A" },
                    { 25, "", "Q3" },
                    { 24, "", "Q2" },
                    { 26, "", "Q4" },
                    { 22, "", "O" },
                    { 12, "", "B" },
                    { 13, "", "C" },
                    { 14, "", "E" },
                    { 15, "", "F" },
                    { 23, "", "Q1" },
                    { 17, "", "H" },
                    { 16, "", "G" },
                    { 19, "", "L" },
                    { 20, "", "M" },
                    { 21, "", "N" },
                    { 18, "", "I" }
                });

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
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 5,
                columns: new[] { "Link", "NameTest", "Time" },
                values: new object[] { "Test_16PF_A", "16PF Forma B", "60 min." });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "IdTest", "Link", "NameTest", "Time" },
                values: new object[] { 6, "Test_16PF_B", "16PF Forma A", "60 min." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "09/06/2023 12:09 AM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "13/05/2023 06:05 PM");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 1,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Ascendencia: Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo.", "Asc." });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 2,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Responsabilidad: Rasgo que alude a la constancia y perseverancia en las tareas propuestas.", "Resp." });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 3,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Estabilidad Emocional: Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa.", "Estab." });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 4,
                columns: new[] { "DescriptionFactor", "FactorName" },
                values: new object[] { "Sociabilidad: Rasgo que facilita el trato con los demás.", "Soc." });

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 5,
                column: "FactorName",
                value: "Caut.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 6,
                column: "FactorName",
                value: "Orig.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 7,
                column: "FactorName",
                value: "Comp.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 8,
                column: "FactorName",
                value: "Vital.");

            migrationBuilder.UpdateData(
                table: "Factor",
                keyColumn: "IdFactor",
                keyValue: 9,
                column: "FactorName",
                value: "Autoest.");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "13/05/2023 06:05 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "13/05/2023 06:05 PM");

            migrationBuilder.UpdateData(
                table: "Test",
                keyColumn: "IdTest",
                keyValue: 5,
                columns: new[] { "Link", "NameTest", "Time" },
                values: new object[] { "Test_16PF", "16PF", "45 min." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "13/05/2023 06:05 PM");
        }
    }
}
