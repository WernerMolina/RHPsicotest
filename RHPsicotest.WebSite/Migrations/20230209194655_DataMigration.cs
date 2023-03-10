using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Permission",
                columns: table => new
                {
                    IdPermission = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.IdPermission);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IdRole);
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
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Permission_Role",
                columns: table => new
                {
                    IdPermission = table.Column<int>(type: "int", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission_Role", x => new { x.IdPermission, x.IdRole });
                    table.ForeignKey(
                        name: "FK_Permission_Role_Permission_IdPermission",
                        column: x => x.IdPermission,
                        principalTable: "Permission",
                        principalColumn: "IdPermission",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_Role_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionHigher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.IdPosition);
                    table.ForeignKey(
                        name: "FK_Position_Test_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Role_User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_User", x => new { x.IdRole, x.IdUser });
                    table.ForeignKey(
                        name: "FK_Role_User_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_User_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    IdCandidate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    IdPosition = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.IdCandidate);
                    table.ForeignKey(
                        name: "FK_Candidate_Position_IdPosition",
                        column: x => x.IdPosition,
                        principalTable: "Position",
                        principalColumn: "IdPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidate_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    IdFactor = table.Column<int>(type: "int", nullable: false),
                    IdQuestion = table.Column<int>(type: "int", nullable: false),
                    Correct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incorrect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => new { x.IdFactor, x.IdQuestion });
                    table.ForeignKey(
                        name: "FK_Response_Factor_IdFactor",
                        column: x => x.IdFactor,
                        principalTable: "Factor",
                        principalColumn: "IdFactor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Response_Question_IdQuestion",
                        column: x => x.IdQuestion,
                        principalTable: "Question",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expedient",
                columns: table => new
                {
                    IdExpedient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCandidate = table.Column<int>(type: "int", nullable: false),
                    DUI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastnames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivilStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicTraining = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurriculumVitae = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedient", x => x.IdExpedient);
                    table.ForeignKey(
                        name: "FK_Expedient_Candidate_IdCandidate",
                        column: x => x.IdCandidate,
                        principalTable: "Candidate",
                        principalColumn: "IdCandidate",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    IdExpedient = table.Column<int>(type: "int", nullable: false),
                    IdFactor = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<byte>(type: "tinyint", nullable: false),
                    Percentile = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => new { x.IdExpedient, x.IdFactor });
                    table.ForeignKey(
                        name: "FK_Result_Expedient_IdExpedient",
                        column: x => x.IdExpedient,
                        principalTable: "Expedient",
                        principalColumn: "IdExpedient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_Factor_IdFactor",
                        column: x => x.IdFactor,
                        principalTable: "Factor",
                        principalColumn: "IdFactor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Factor",
                columns: new[] { "IdFactor", "NameFactor" },
                values: new object[,]
                {
                    { 1, "Ascendencia" },
                    { 8, "Vitalidad" },
                    { 7, "Comprension" },
                    { 6, "Originalidad" },
                    { 9, "Autoestima" },
                    { 4, "Sociabilidad" },
                    { 3, "Estabilidad Emocional" },
                    { 2, "Responsabilidad" },
                    { 5, "Cautela" }
                });

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
                values: new object[,]
                {
                    { 1, "Super-Admin" },
                    { 2, "Administrador" },
                    { 3, "Candidato" }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "IdTest", "Description", "NameTest" },
                values: new object[] { 1, null, "PPG-IPG" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Email", "Name", "Password", "RegistrationDate" },
                values: new object[] { 1, "Wm25@gmail.com", "Werner Molina", "827ccb0eea8a706c4c34a16891f84e7b", new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                table: "Position",
                columns: new[] { "IdPosition", "CreationDate", "Department", "IdTest", "PositionHigher", "PositionName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Tecnología de la Información", 1, "Encargado de IT", "Desarrollador IT" },
                    { 2, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ventas", 1, "Gerente Comercial", "Asesor de Venta" }
                });

            migrationBuilder.InsertData(
                table: "Role_User",
                columns: new[] { "IdRole", "IdUser" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Candidate",
                columns: new[] { "IdCandidate", "Email", "IdPosition", "IdRole", "Password", "RegistrationDate", "Username" },
                values: new object[] { 1, "ml22002@esfe.agape.edu.sv", 1, 3, "TW15", new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "WerMolina" });

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IdPosition",
                table: "Candidate",
                column: "IdPosition");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IdRole",
                table: "Candidate",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Expedient_IdCandidate",
                table: "Expedient",
                column: "IdCandidate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_Role_IdRole",
                table: "Permission_Role",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Position_IdTest",
                table: "Position",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Question_IdTest",
                table: "Question",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Response_IdQuestion",
                table: "Response",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_Result_IdFactor",
                table: "Result",
                column: "IdFactor");

            migrationBuilder.CreateIndex(
                name: "IX_Role_User_IdUser",
                table: "Role_User",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permission_Role");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Role_User");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Expedient");

            migrationBuilder.DropTable(
                name: "Factor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
