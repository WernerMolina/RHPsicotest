using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailUser");

            migrationBuilder.AddColumn<int>(
                name: "IdTest",
                table: "Stall",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    IdPuesto = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Candidate_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidate_Stall_IdPuesto",
                        column: x => x.IdPuesto,
                        principalTable: "Stall",
                        principalColumn: "IdStall",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factor",
                columns: table => new
                {
                    IdFactor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFactor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factor", x => x.IdFactor);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.IdTest);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    IdQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    QuestionNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.IdQuestion);
                    table.ForeignKey(
                        name: "FK_Question_Test_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factor_Question",
                columns: table => new
                {
                    IdFactor = table.Column<int>(type: "int", nullable: false),
                    IdQuestion = table.Column<int>(type: "int", nullable: false),
                    Correct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InCorrect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factor_Question", x => new { x.IdFactor, x.IdQuestion });
                    table.ForeignKey(
                        name: "FK_Factor_Question_Factor_IdFactor",
                        column: x => x.IdFactor,
                        principalTable: "Factor",
                        principalColumn: "IdFactor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factor_Question_Question_IdQuestion",
                        column: x => x.IdQuestion,
                        principalTable: "Question",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stall_IdTest",
                table: "Stall",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IdPuesto",
                table: "Candidate",
                column: "IdPuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IdRole",
                table: "Candidate",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Factor_Question_IdQuestion",
                table: "Factor_Question",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_Question_IdTest",
                table: "Question",
                column: "IdTest");

            migrationBuilder.AddForeignKey(
                name: "FK_Stall_Test_IdTest",
                table: "Stall",
                column: "IdTest",
                principalTable: "Test",
                principalColumn: "IdTest",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stall_Test_IdTest",
                table: "Stall");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Factor_Question");

            migrationBuilder.DropTable(
                name: "Factor");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropIndex(
                name: "IX_Stall_IdTest",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "IdTest",
                table: "Stall");

            migrationBuilder.CreateTable(
                name: "EmailUser",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPuesto = table.Column<int>(type: "int", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailUser", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_EmailUser_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailUser_Stall_IdPuesto",
                        column: x => x.IdPuesto,
                        principalTable: "Stall",
                        principalColumn: "IdStall",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailUser_IdPuesto",
                table: "EmailUser",
                column: "IdPuesto");

            migrationBuilder.CreateIndex(
                name: "IX_EmailUser_IdRole",
                table: "EmailUser",
                column: "IdRole");
        }
    }
}
