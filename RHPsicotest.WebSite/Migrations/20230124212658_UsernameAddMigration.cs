using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class UsernameAddMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailUser_Stalls_IdPuesto",
                table: "EmailUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stalls",
                table: "Stalls");

            migrationBuilder.RenameTable(
                name: "Stalls",
                newName: "Stall");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "EmailUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stall",
                table: "Stall",
                column: "IdStall");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_EmailUser_Stall_IdPuesto",
                table: "EmailUser",
                column: "IdPuesto",
                principalTable: "Stall",
                principalColumn: "IdStall",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailUser_Stall_IdPuesto",
                table: "EmailUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stall",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "EmailUser");

            migrationBuilder.RenameTable(
                name: "Stall",
                newName: "Stalls");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stalls",
                table: "Stalls",
                column: "IdStall");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_EmailUser_Stalls_IdPuesto",
                table: "EmailUser",
                column: "IdPuesto",
                principalTable: "Stalls",
                principalColumn: "IdStall",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
