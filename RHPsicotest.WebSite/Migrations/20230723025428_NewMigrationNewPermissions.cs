using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class NewMigrationNewPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:54 PM");

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "IdPermission", "Assigned", "PermissionName", "PermissionNamePolicy" },
                values: new object[] { 24, "Administradores", "Acceso a Dashboard", "Dashboard" });

            migrationBuilder.InsertData(
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" },
                values: new object[,]
                {
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 08:54 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 08:54 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:54 PM");

            migrationBuilder.InsertData(
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" },
                values: new object[] { 24, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Candidate",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:30 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 1,
                column: "CreationDate",
                value: "22/07/2023 08:30 PM");

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "IdPosition",
                keyValue: 2,
                column: "CreationDate",
                value: "22/07/2023 08:30 PM");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: "22/07/2023 08:30 PM");
        }
    }
}
