using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class ForeignKeyModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Roles_Permission_IdPermission",
                table: "Permission_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Roles_Role_IdRole",
                table: "Permission_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission_Roles",
                table: "Permission_Roles");

            migrationBuilder.RenameTable(
                name: "Permission_Roles",
                newName: "Permission_Role");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_Roles_IdRole",
                table: "Permission_Role",
                newName: "IX_Permission_Role_IdRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission_Role",
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Role_Permission_IdPermission",
                table: "Permission_Role",
                column: "IdPermission",
                principalTable: "Permission",
                principalColumn: "IdPermission",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Role_Role_IdRole",
                table: "Permission_Role",
                column: "IdRole",
                principalTable: "Role",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Role_Permission_IdPermission",
                table: "Permission_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Role_Role_IdRole",
                table: "Permission_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission_Role",
                table: "Permission_Role");

            migrationBuilder.RenameTable(
                name: "Permission_Role",
                newName: "Permission_Roles");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_Role_IdRole",
                table: "Permission_Roles",
                newName: "IX_Permission_Roles_IdRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission_Roles",
                table: "Permission_Roles",
                columns: new[] { "IdPermission", "IdRole" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Roles_Permission_IdPermission",
                table: "Permission_Roles",
                column: "IdPermission",
                principalTable: "Permission",
                principalColumn: "IdPermission",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Roles_Role_IdRole",
                table: "Permission_Roles",
                column: "IdRole",
                principalTable: "Role",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
