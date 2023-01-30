using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class FieldCVMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "CurriculumVitae",
                table: "Expedient",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurriculumVitae",
                table: "Expedient");
        }
    }
}
