using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class AddNewsPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Assigned",
                table: "Permission",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 11:55 AM");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 1,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 2,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 3,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 4,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "IdPermission", "Assigned", "PermissionName" },
                values: new object[,]
                {
                    { 23, "Candidatos", "Pruebas-Asignadas" },
                    { 22, "Candidatos", "Confirmar-Politicas" },
                    { 21, "Candidatos", "Crear-Expediente" },
                    { 20, "Adminitradores", "Eliminar-Puesto" },
                    { 19, "Adminitradores", "Editar-Puesto" },
                    { 17, "Adminitradores", "Lista-Puestos" },
                    { 18, "Adminitradores", "Crear-Puesto" },
                    { 15, "Adminitradores", "Ver-Curriculums" },
                    { 14, "Adminitradores", "Editar-Expediente" },
                    { 13, "Adminitradores", "Lista-Expedientes" },
                    { 12, "Adminitradores", "Reenviar-Correo" },
                    { 11, "Adminitradores", "Eliminar-Candidato" },
                    { 10, "Adminitradores", "Crear-Candidato" },
                    { 9, "Adminitradores", "Lista-Candidatos" },
                    { 8, "Adminitradores", "Eliminar-Rol" },
                    { 7, "Adminitradores", "Editar-Role" },
                    { 6, "Adminitradores", "Crear-Rol" },
                    { 16, "Adminitradores", "Ver-Reportes" },
                    { 5, "Adminitradores", "Lista-Roles" }
                });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 11:55 AM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 11:55 AM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 11:55 AM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "Assigned",
                table: "Permission");

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "20/07/2023 04:45 PM");

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
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "20/07/2023 04:45 PM");
        }
    }
}
