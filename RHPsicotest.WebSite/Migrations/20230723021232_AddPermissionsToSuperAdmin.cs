using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class AddPermissionsToSuperAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:12 PM");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 1,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 2,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 3,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 4,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 5,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 6,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 7,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 8,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 9,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 10,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 11,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 12,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 13,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 14,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 15,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 16,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 17,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 18,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 19,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 20,
                column: "Assigned",
                value: "Administradores");

            migrationBuilder.InsertData(
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 23, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 14, 1 },
                    { 13, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 15, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 08:12 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 08:12 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:12 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 23, 1 });

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

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 5,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 6,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 7,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 8,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 9,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 10,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 11,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 12,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 13,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 14,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 15,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 16,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 17,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 18,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 19,
                column: "Assigned",
                value: "Adminitradores");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 20,
                column: "Assigned",
                value: "Adminitradores");

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
    }
}
