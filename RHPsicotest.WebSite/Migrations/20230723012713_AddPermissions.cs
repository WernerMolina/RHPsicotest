using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class AddPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PermissionNamePolicy",
                table: "Permission",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 07:27 PM");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 1,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Lista de Usuarios", "Lista-Usuarios" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 2,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Crear Usuarios", "Crear-Usuario" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 3,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Editar Usuarios", "Editar-Usuario" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 4,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Eliminar Usuarios", "Eliminar-Usuario" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 5,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Lista de Roles", "Lista-Roles" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 6,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Crear Roles", "Crear-Rol" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 7,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Editar Roles", "Editar-Role" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 8,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Eliminar Roles", "Eliminar-Rol" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 9,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Lista de Candidatos", "Lista-Candidatos" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 10,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Crear Candidatos", "Crear-Candidato" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 11,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Eliminar Candidatos", "Eliminar-Candidato" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 12,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Reenviar Correos", "Reenviar-Correo" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 13,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Lista de Expedientes", "Lista-Expedientes" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 14,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Editar Expedientes", "Editar-Expediente" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 15,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Curriculums", "Ver-Curriculums" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 16,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Reportes", "Ver-Reportes" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 17,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Ver Lista de Puestos", "Lista-Puestos" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 18,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Crear Puestos", "Crear-Puesto" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 19,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Editar Puestos", "Editar-Puesto" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 20,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Eliminar Puestos", "Eliminar-Puesto" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 21,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Crear Expediente", "Crear-Expediente" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 22,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Confirmar Políticas", "Confirmar-Politicas" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 23,
                columns: new[] { "PermissionName", "PermissionNamePolicy" },
                values: new object[] { "Pruebas Asignadas", "Pruebas-Asignadas" });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 07:27 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 07:27 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 07:27 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissionNamePolicy",
                table: "Permission");

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 05:57 PM");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 1,
                column: "PermissionName",
                value: "Lista-Usuarios");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 2,
                column: "PermissionName",
                value: "Crear-Usuario");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 3,
                column: "PermissionName",
                value: "Editar-Usuario");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 4,
                column: "PermissionName",
                value: "Eliminar-Usuario");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 5,
                column: "PermissionName",
                value: "Lista-Roles");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 6,
                column: "PermissionName",
                value: "Crear-Rol");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 7,
                column: "PermissionName",
                value: "Editar-Role");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 8,
                column: "PermissionName",
                value: "Eliminar-Rol");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 9,
                column: "PermissionName",
                value: "Lista-Candidatos");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 10,
                column: "PermissionName",
                value: "Crear-Candidato");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 11,
                column: "PermissionName",
                value: "Eliminar-Candidato");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 12,
                column: "PermissionName",
                value: "Reenviar-Correo");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 13,
                column: "PermissionName",
                value: "Lista-Expedientes");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 14,
                column: "PermissionName",
                value: "Editar-Expediente");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 15,
                column: "PermissionName",
                value: "Ver-Curriculums");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 16,
                column: "PermissionName",
                value: "Ver-Reportes");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 17,
                column: "PermissionName",
                value: "Lista-Puestos");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 18,
                column: "PermissionName",
                value: "Crear-Puesto");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 19,
                column: "PermissionName",
                value: "Editar-Puesto");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 20,
                column: "PermissionName",
                value: "Eliminar-Puesto");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 21,
                column: "PermissionName",
                value: "Crear-Expediente");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 22,
                column: "PermissionName",
                value: "Confirmar-Politicas");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 23,
                column: "PermissionName",
                value: "Pruebas-Asignadas");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 05:57 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 05:57 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 05:57 PM");
        }
    }
}
