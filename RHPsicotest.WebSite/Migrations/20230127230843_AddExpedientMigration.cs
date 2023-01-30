using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class AddExpedientMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Permission_Role",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Role_User",
                keyColumns: new[] { "IdRole", "IdUser" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "IdPermission",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "IdRole",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Expedient",
                columns: table => new
                {
                    IdExpedient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DUI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastnames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivilStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicTraining = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedient", x => x.IdExpedient);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expedient");

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "IdPermission", "PermissionName" },
                values: new object[,]
                {
                    { 1, "Lista-Usuarios" },
                    { 2, "Crear-Usuario" },
                    { 3, "Editar-Usuario" },
                    { 4, "Eliminar-Usuario" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "IdRole", "RoleName" },
                values: new object[] { 1, "Super-Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Email", "Name", "Password", "RegistrationDate" },
                values: new object[] { 1, "Wm25@gmail.com", "Werner Molina", "827ccb0eea8a706c4c34a16891f84e7b", new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Role_User",
                columns: new[] { "IdRole", "IdUser" },
                values: new object[] { 1, 1 });
        }
    }
}
