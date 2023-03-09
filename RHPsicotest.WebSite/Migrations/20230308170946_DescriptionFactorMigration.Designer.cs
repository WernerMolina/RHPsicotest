﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RHPsicotest.WebSite.Data;

namespace RHPsicotest.WebSite.Migrations
{
    [DbContext(typeof(RHPsicotestDbContext))]
    [Migration("20230308170946_DescriptionFactorMigration")]
    partial class DescriptionFactorMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Candidate", b =>
                {
                    b.Property<int>("IdCandidate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPosition")
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCandidate");

                    b.HasIndex("IdPosition");

                    b.HasIndex("IdRole");

                    b.ToTable("Candidate");

                    b.HasData(
                        new
                        {
                            IdCandidate = 1,
                            Email = "ml22002@esfe.agape.edu.sv",
                            IdPosition = 1,
                            IdRole = 3,
                            Password = "TW15",
                            RegistrationDate = "08/03/2023 11:09 AM"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Expedient", b =>
                {
                    b.Property<int>("IdExpedient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AcademicTraining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("Certificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CurriculumVitae")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCandidate")
                        .HasColumnType("int");

                    b.Property<string>("LandlineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastnames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovilePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExpedient");

                    b.HasIndex("IdCandidate")
                        .IsUnique();

                    b.ToTable("Expedient");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Factor", b =>
                {
                    b.Property<int>("IdFactor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescriptionFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFactor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFactor");

                    b.ToTable("Factor");

                    b.HasData(
                        new
                        {
                            IdFactor = 1,
                            DescriptionFactor = "Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo.",
                            NameFactor = "Ascendencia"
                        },
                        new
                        {
                            IdFactor = 2,
                            DescriptionFactor = "Rasgo que alude a la constancia y perseverancia en las tareas propuestas.",
                            NameFactor = "Responsabilidad"
                        },
                        new
                        {
                            IdFactor = 3,
                            DescriptionFactor = "Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa.",
                            NameFactor = "Estabilidad Emocional"
                        },
                        new
                        {
                            IdFactor = 4,
                            DescriptionFactor = "Rasgo que facilita el trato con los demás.",
                            NameFactor = "Sociabilidad"
                        },
                        new
                        {
                            IdFactor = 5,
                            DescriptionFactor = "Es el tipo de conducta caracterizada por prever las situaciones o efectos de una decisión antes de actuar.",
                            NameFactor = "Cautela"
                        },
                        new
                        {
                            IdFactor = 6,
                            DescriptionFactor = "Rango de conducta que se manifiesta por la búsqueda de autenticidad en todo lo que hace.",
                            NameFactor = "Originalidad"
                        },
                        new
                        {
                            IdFactor = 7,
                            DescriptionFactor = "Grado en el cual somos capaces de interpretar o asimilar acontecimientos y hechos particulares o de la vida diaria.",
                            NameFactor = "Comprension"
                        },
                        new
                        {
                            IdFactor = 8,
                            DescriptionFactor = "Se dice de la energía psíquica o física que se agrega a cada actividad que se emprende.",
                            NameFactor = "Vitalidad"
                        },
                        new
                        {
                            IdFactor = 9,
                            DescriptionFactor = "Es la valoración positiva o negativa que uno hace de sí mismo.",
                            NameFactor = "Autoestima"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.Property<int>("IdPermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPermission");

                    b.ToTable("Permission");

                    b.HasData(
                        new
                        {
                            IdPermission = 1,
                            PermissionName = "Lista-Usuarios"
                        },
                        new
                        {
                            IdPermission = 2,
                            PermissionName = "Crear-Usuario"
                        },
                        new
                        {
                            IdPermission = 3,
                            PermissionName = "Editar-Usuario"
                        },
                        new
                        {
                            IdPermission = 4,
                            PermissionName = "Eliminar-Usuario"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission_Role", b =>
                {
                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.HasKey("IdPermission", "IdRole");

                    b.HasIndex("IdRole");

                    b.ToTable("Permission_Role");

                    b.HasData(
                        new
                        {
                            IdPermission = 1,
                            IdRole = 1
                        },
                        new
                        {
                            IdPermission = 2,
                            IdRole = 1
                        },
                        new
                        {
                            IdPermission = 3,
                            IdRole = 1
                        },
                        new
                        {
                            IdPermission = 4,
                            IdRole = 1
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Position", b =>
                {
                    b.Property<int>("IdPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<string>("PositionHigher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPosition");

                    b.HasIndex("IdTest");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            IdPosition = 1,
                            CreationDate = "08/03/2023 11:09 AM",
                            Department = "Tecnología de la Información",
                            IdTest = 1,
                            PositionHigher = "Encargado de IT",
                            PositionName = "Desarrollador IT"
                        },
                        new
                        {
                            IdPosition = 2,
                            CreationDate = "08/03/2023 11:09 AM",
                            Department = "Ventas",
                            IdTest = 1,
                            PositionHigher = "Gerente Comercial",
                            PositionName = "Asesor de Venta"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Question", b =>
                {
                    b.Property<int>("IdQuestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<string>("OptionA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("QuestionNumber")
                        .HasColumnType("tinyint");

                    b.HasKey("IdQuestion");

                    b.HasIndex("IdTest");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Response", b =>
                {
                    b.Property<int>("IdFactor")
                        .HasColumnType("int");

                    b.Property<int>("IdQuestion")
                        .HasColumnType("int");

                    b.Property<string>("Correct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incorrect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFactor", "IdQuestion");

                    b.HasIndex("IdQuestion");

                    b.ToTable("Response");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Result", b =>
                {
                    b.Property<int>("IdExpedient")
                        .HasColumnType("int");

                    b.Property<int>("IdFactor")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Percentile")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Score")
                        .HasColumnType("tinyint");

                    b.HasKey("IdExpedient", "IdFactor");

                    b.HasIndex("IdFactor");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            IdRole = 1,
                            RoleName = "Super-Admin"
                        },
                        new
                        {
                            IdRole = 2,
                            RoleName = "Administrador"
                        },
                        new
                        {
                            IdRole = 3,
                            RoleName = "Candidato"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role_User", b =>
                {
                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdRole", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("Role_User");

                    b.HasData(
                        new
                        {
                            IdRole = 1,
                            IdUser = 1
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test", b =>
                {
                    b.Property<int>("IdTest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTest");

                    b.ToTable("Test");

                    b.HasData(
                        new
                        {
                            IdTest = 1,
                            NameTest = "PPG-IPG"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            Email = "Wm25@gmail.com",
                            Name = "Werner Molina",
                            Password = "827ccb0eea8a706c4c34a16891f84e7b",
                            RegistrationDate = "08/03/2023 11:09 AM"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Candidate", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Position", "Position")
                        .WithMany("Candidates")
                        .HasForeignKey("IdPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Role", "Role")
                        .WithMany("Candidate")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Expedient", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Candidate", "Candidate")
                        .WithOne("Expedient")
                        .HasForeignKey("RHPsicotest.WebSite.Models.Expedient", "IdCandidate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission_Role", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("IdPermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Position", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Test", "Test")
                        .WithMany("Positions")
                        .HasForeignKey("IdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Question", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("IdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Response", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Factor", "Factor")
                        .WithMany("Questions")
                        .HasForeignKey("IdFactor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Question", "Question")
                        .WithMany("Factors")
                        .HasForeignKey("IdQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factor");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Result", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Expedient", "Expedient")
                        .WithMany("Results")
                        .HasForeignKey("IdExpedient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Factor", "Factor")
                        .WithMany("Results")
                        .HasForeignKey("IdFactor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expedient");

                    b.Navigation("Factor");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role_User", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Candidate", b =>
                {
                    b.Navigation("Expedient");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Expedient", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Factor", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Position", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Question", b =>
                {
                    b.Navigation("Factors");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role", b =>
                {
                    b.Navigation("Candidate");

                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test", b =>
                {
                    b.Navigation("Positions");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
