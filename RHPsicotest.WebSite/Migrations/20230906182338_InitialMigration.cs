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
                    { 24, "Q2" },
                    { 25, "Q3" },
                    { 26, "Q4" },
                    { 27, "QI" },
                    { 28, "QII" },
                    { 29, "QIII" },
                    { 30, "QIV" },
                    { 31, "Disposición General para la Venta" },
                    { 23, "Q1" },
                    { 32, "Receptividad" },
                    { 34, "I- Compresión" },
                    { 35, "II- Adaptabilidad" },
                    { 36, "III- Control de sí mismo" },
                    { 38, "V- Combatividad" },
                    { 39, "VI- Dominio" },
                    { 40, "VII- Seguridad" },
                    { 41, "VIII- Actividad" },
                    { 42, "IX- Sociabilidad" },
                    { 33, "Agresividad" },
                    { 22, "O" },
                    { 37, "IV- Tolerancia a la frustración" },
                    { 20, "M" },
                    { 21, "N" },
                    { 2, "Responsabilidad" },
                    { 3, "Estabilidad Emocional" },
                    { 4, "Sociabilidad" },
                    { 5, "Cautela" },
                    { 7, "Comprensión" },
                    { 8, "Vitalidad" },
                    { 9, "Autoestima" },
                    { 10, "Inteligencia" },
                    { 6, "Originalidad" },
                    { 12, "B" },
                    { 13, "C" },
                    { 14, "E" },
                    { 15, "F" },
                    { 16, "G" },
                    { 17, "H" },
                    { 18, "I" },
                    { 11, "A" },
                    { 19, "L" }
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
                    { 22, "Candidatos", "Confirmar Políticas", "Confirmar-Politicas" },
                    { 20, "Administradores", "Eliminar Puestos", "Eliminar-Puesto" },
                    { 21, "Candidatos", "Crear Expediente", "Crear-Expediente" },
                    { 14, "Administradores", "Editar Expedientes", "Editar-Expediente" },
                    { 23, "Candidatos", "Pruebas Asignadas", "Pruebas-Asignadas" },
                    { 19, "Administradores", "Editar Puestos", "Editar-Puesto" },
                    { 13, "Administradores", "Ver Lista de Expedientes", "Lista-Expedientes" },
                    { 6, "Administradores", "Crear Roles", "Crear-Rol" },
                    { 11, "Administradores", "Eliminar Candidatos", "Eliminar-Candidato" },
                    { 12, "Administradores", "Reenviar Correos", "Reenviar-Correo" },
                    { 2, "Administradores", "Crear Usuarios", "Crear-Usuario" },
                    { 3, "Administradores", "Editar Usuarios", "Editar-Usuario" },
                    { 4, "Administradores", "Eliminar Usuarios", "Eliminar-Usuario" },
                    { 1, "Administradores", "Ver Lista de Usuarios", "Lista-Usuarios" },
                    { 7, "Administradores", "Editar Roles", "Editar-Rol" },
                    { 8, "Administradores", "Eliminar Roles", "Eliminar-Rol" },
                    { 9, "Administradores", "Ver Lista de Candidatos", "Lista-Candidatos" },
                    { 10, "Administradores", "Crear Candidatos", "Crear-Candidato" },
                    { 5, "Administradores", "Ver Lista de Roles", "Lista-Roles" }
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
                    { 3, "Test_Dominos", "Dominos", "60 min." },
                    { 4, "Test_IPV", "IPV", "45 min." }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Email", "EmailNormalized", "Name", "Password", "RegistrationDate" },
                values: new object[,]
                {
                    { 2, "rosy.vasquez@consulightpf.net", "ROSY.VASQUEZ@CONSULIGHTPF.NET", "Rosy Hernández", "827ccb0eea8a706c4c34a16891f84e7b", "06/09/2023 12:23 PM" },
                    { 1, "Wm25@gmail.com", "WM25@GMAIL.COM", "Werner Molina", "827ccb0eea8a706c4c34a16891f84e7b", "06/09/2023 12:23 PM" },
                    { 3, "roberto.ramirez@consulightpf.net", "ROBERTO.RAMIREZ@CONSULIGHTPF.NET", "Roberto", "827ccb0eea8a706c4c34a16891f84e7b", "06/09/2023 12:23 PM" }
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
