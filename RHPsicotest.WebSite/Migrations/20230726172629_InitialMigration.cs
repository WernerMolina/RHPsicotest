using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RHPsicotest.WebSite.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factor",
                columns: table => new
                {
                    IdFactor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionNamePolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.IdPermission);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionHigher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.IdPosition);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleNameNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    EmailNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
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
                    EmailNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Test_Position",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Position", x => new { x.IdTest, x.IdPosition });
                    table.ForeignKey(
                        name: "FK_Test_Position_Position_IdPosition",
                        column: x => x.IdPosition,
                        principalTable: "Position",
                        principalColumn: "IdPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Position_Test_IdTest",
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
                name: "Expedient",
                columns: table => new
                {
                    IdExpedient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCandidate = table.Column<int>(type: "int", nullable: false),
                    DUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastnames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandlineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicTraining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurriculumVitae = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Test_Candidate",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdCandidate = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Candidate", x => new { x.IdCandidate, x.IdTest });
                    table.ForeignKey(
                        name: "FK_Test_Candidate_Candidate_IdCandidate",
                        column: x => x.IdCandidate,
                        principalTable: "Candidate",
                        principalColumn: "IdCandidate",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Candidate_Test_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    IdExpedient = table.Column<int>(type: "int", nullable: false),
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    IdFactor = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<byte>(type: "tinyint", nullable: false),
                    Percentile = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => new { x.IdExpedient, x.IdTest, x.IdFactor });
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
                    table.ForeignKey(
                        name: "FK_Result_Test_IdTest",
                        column: x => x.IdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Factor",
                columns: new[] { "IdFactor", "FactorName" },
                values: new object[,]
                {
                    { 1, "Ascendencia" },
                    { 2, "Responsabilidad" },
                    { 3, "Estabilidad Emocional" },
                    { 4, "Sociabilidad" },
                    { 5, "Cautela" },
                    { 6, "Originalidad" },
                    { 7, "Comprensión" },
                    { 8, "Vitalidad" },
                    { 9, "Autoestima" },
                    { 10, "Inteligencia" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "IdPermission", "Assigned", "PermissionName", "PermissionNamePolicy" },
                values: new object[,]
                {
                    { 15, "Administradores", "Ver Curriculums", "Ver-Curriculums" },
                    { 16, "Administradores", "Ver Reportes", "Ver-Reportes" },
                    { 17, "Administradores", "Ver Lista de Puestos", "Lista-Puestos" },
                    { 18, "Administradores", "Crear Puestos", "Crear-Puesto" },
                    { 23, "Candidatos", "Pruebas Asignadas", "Pruebas-Asignadas" },
                    { 20, "Administradores", "Eliminar Puestos", "Eliminar-Puesto" },
                    { 21, "Candidatos", "Crear Expediente", "Crear-Expediente" },
                    { 22, "Candidatos", "Confirmar Políticas", "Confirmar-Politicas" },
                    { 14, "Administradores", "Editar Expedientes", "Editar-Expediente" },
                    { 19, "Administradores", "Editar Puestos", "Editar-Puesto" },
                    { 13, "Administradores", "Ver Lista de Expedientes", "Lista-Expedientes" },
                    { 11, "Administradores", "Eliminar Candidatos", "Eliminar-Candidato" },
                    { 2, "Administradores", "Crear Usuarios", "Crear-Usuario" },
                    { 10, "Administradores", "Crear Candidatos", "Crear-Candidato" },
                    { 9, "Administradores", "Ver Lista de Candidatos", "Lista-Candidatos" },
                    { 8, "Administradores", "Eliminar Roles", "Eliminar-Rol" },
                    { 7, "Administradores", "Editar Roles", "Editar-Rol" },
                    { 6, "Administradores", "Crear Roles", "Crear-Rol" },
                    { 5, "Administradores", "Ver Lista de Roles", "Lista-Roles" },
                    { 4, "Administradores", "Eliminar Usuarios", "Eliminar-Usuario" },
                    { 3, "Administradores", "Editar Usuarios", "Editar-Usuario" },
                    { 12, "Administradores", "Reenviar Correos", "Reenviar-Correo" },
                    { 1, "Administradores", "Ver Lista de Usuarios", "Lista-Usuarios" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "IdRole", "RoleName", "RoleNameNormalized" },
                values: new object[,]
                {
                    { 1, "Super-Admin", "SUPER-ADMIN" },
                    { 2, "Candidato", "CANDIDATO" }
                });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "IdTest", "Link", "NameTest", "Time" },
                values: new object[,]
                {
                    { 1, "Test_PPGIPG", "PPG-IPG", "45 min." },
                    { 2, "Test_OTIS", "OTIS", "45 min." },
                    { 3, "Test_Dominos", "Dominos", "60 min." }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Email", "EmailNormalized", "Name", "Password", "RegistrationDate" },
                values: new object[,]
                {
                    { 2, "rosy.vasquez@consulightpf.net", "ROSY.VASQUEZ@CONSULIGHTPF.NET", "Rosy Hernández", "827ccb0eea8a706c4c34a16891f84e7b", "26/07/2023 11:26 AM" },
                    { 1, "Wm25@gmail.com", "WM25@GMAIL.COM", "Werner Molina", "827ccb0eea8a706c4c34a16891f84e7b", "26/07/2023 11:26 AM" },
                    { 3, "roberto.ramirez@consulightpf.net", "ROBERTO.RAMIREZ@CONSULIGHTPF.NET", "Roberto", "827ccb0eea8a706c4c34a16891f84e7b", "26/07/2023 11:26 AM" }
                });

            migrationBuilder.InsertData(
                table: "Permission_Role",
                columns: new[] { "IdPermission", "IdRole" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 23, 2 },
                    { 22, 2 },
                    { 21, 2 },
                    { 20, 1 },
                    { 19, 1 },
                    { 18, 1 },
                    { 17, 1 },
                    { 16, 1 },
                    { 15, 1 },
                    { 14, 1 },
                    { 13, 1 },
                    { 11, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 8, 1 },
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 12, 1 }
                });

            migrationBuilder.InsertData(
                table: "Role_User",
                columns: new[] { "IdRole", "IdUser" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 1 },
                    { 1, 3 }
                });

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
                name: "IX_Result_IdFactor",
                table: "Result",
                column: "IdFactor");

            migrationBuilder.CreateIndex(
                name: "IX_Result_IdTest",
                table: "Result",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Role_User_IdUser",
                table: "Role_User",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Candidate_IdTest",
                table: "Test_Candidate",
                column: "IdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Position_IdPosition",
                table: "Test_Position",
                column: "IdPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permission_Role");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Role_User");

            migrationBuilder.DropTable(
                name: "Test_Candidate");

            migrationBuilder.DropTable(
                name: "Test_Position");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Expedient");

            migrationBuilder.DropTable(
                name: "Factor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
