﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RHPsicotest.WebSite.Data;

namespace RHPsicotest.WebSite.Migrations
{
    [DbContext(typeof(RHPsicotestDbContext))]
    partial class RHPsicotestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("EmailNormalized")
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
                            EmailNormalized = "ML22002@ESFE.AGAPE.EDU.SV",
                            IdPosition = 1,
                            IdRole = 3,
                            Password = "TW15",
                            RegistrationDate = "20/07/2023 04:45 PM"
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

                    b.Property<string>("FactorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFactor");

                    b.ToTable("Factor");

                    b.HasData(
                        new
                        {
                            IdFactor = 1,
                            FactorName = "Ascendencia"
                        },
                        new
                        {
                            IdFactor = 2,
                            FactorName = "Responsabilidad"
                        },
                        new
                        {
                            IdFactor = 3,
                            FactorName = "Estabilidad Emocional"
                        },
                        new
                        {
                            IdFactor = 4,
                            FactorName = "Sociabilidad"
                        },
                        new
                        {
                            IdFactor = 5,
                            FactorName = "Cautela"
                        },
                        new
                        {
                            IdFactor = 6,
                            FactorName = "Originalidad"
                        },
                        new
                        {
                            IdFactor = 7,
                            FactorName = "Comprensión"
                        },
                        new
                        {
                            IdFactor = 8,
                            FactorName = "Vitalidad"
                        },
                        new
                        {
                            IdFactor = 9,
                            FactorName = "Autoestima"
                        },
                        new
                        {
                            IdFactor = 10,
                            FactorName = "Inteligencia"
                        },
                        new
                        {
                            IdFactor = 11,
                            FactorName = "A"
                        },
                        new
                        {
                            IdFactor = 12,
                            FactorName = "B"
                        },
                        new
                        {
                            IdFactor = 13,
                            FactorName = "C"
                        },
                        new
                        {
                            IdFactor = 14,
                            FactorName = "E"
                        },
                        new
                        {
                            IdFactor = 15,
                            FactorName = "F"
                        },
                        new
                        {
                            IdFactor = 16,
                            FactorName = "G"
                        },
                        new
                        {
                            IdFactor = 17,
                            FactorName = "H"
                        },
                        new
                        {
                            IdFactor = 18,
                            FactorName = "I"
                        },
                        new
                        {
                            IdFactor = 19,
                            FactorName = "L"
                        },
                        new
                        {
                            IdFactor = 20,
                            FactorName = "M"
                        },
                        new
                        {
                            IdFactor = 21,
                            FactorName = "N"
                        },
                        new
                        {
                            IdFactor = 22,
                            FactorName = "O"
                        },
                        new
                        {
                            IdFactor = 23,
                            FactorName = "Q1"
                        },
                        new
                        {
                            IdFactor = 24,
                            FactorName = "Q2"
                        },
                        new
                        {
                            IdFactor = 25,
                            FactorName = "Q3"
                        },
                        new
                        {
                            IdFactor = 26,
                            FactorName = "Q4"
                        },
                        new
                        {
                            IdFactor = 27,
                            FactorName = "QI"
                        },
                        new
                        {
                            IdFactor = 28,
                            FactorName = "QII"
                        },
                        new
                        {
                            IdFactor = 29,
                            FactorName = "QIII"
                        },
                        new
                        {
                            IdFactor = 30,
                            FactorName = "QIV"
                        },
                        new
                        {
                            IdFactor = 31,
                            FactorName = "Disposición General para la Venta"
                        },
                        new
                        {
                            IdFactor = 32,
                            FactorName = "Receptividad"
                        },
                        new
                        {
                            IdFactor = 33,
                            FactorName = "Agresividad"
                        },
                        new
                        {
                            IdFactor = 34,
                            FactorName = "I- Compresión"
                        },
                        new
                        {
                            IdFactor = 35,
                            FactorName = "II- Adaptabilidad"
                        },
                        new
                        {
                            IdFactor = 36,
                            FactorName = "III- Control de sí mismo"
                        },
                        new
                        {
                            IdFactor = 37,
                            FactorName = "IV- Tolerancia a la frustración"
                        },
                        new
                        {
                            IdFactor = 38,
                            FactorName = "V- Combatividad"
                        },
                        new
                        {
                            IdFactor = 39,
                            FactorName = "VI- Dominio"
                        },
                        new
                        {
                            IdFactor = 40,
                            FactorName = "VII- Seguridad"
                        },
                        new
                        {
                            IdFactor = 41,
                            FactorName = "VIII- Actividad"
                        },
                        new
                        {
                            IdFactor = 42,
                            FactorName = "IX- Sociabilidad"
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

                    b.Property<string>("PositionHigher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPosition");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            IdPosition = 1,
                            CreationDate = "20/07/2023 04:45 PM",
                            Department = "Tecnología de la Información",
                            PositionHigher = "Encargado de IT",
                            PositionName = "Desarrollador IT"
                        },
                        new
                        {
                            IdPosition = 2,
                            CreationDate = "20/07/2023 04:45 PM",
                            Department = "Ventas",
                            PositionHigher = "Gerente Comercial",
                            PositionName = "Asesor de Venta"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Result", b =>
                {
                    b.Property<int>("IdExpedient")
                        .HasColumnType("int");

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<int>("IdFactor")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Percentile")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Score")
                        .HasColumnType("tinyint");

                    b.HasKey("IdExpedient", "IdTest", "IdFactor");

                    b.HasIndex("IdFactor");

                    b.HasIndex("IdTest");

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

                    b.Property<string>("RoleNameNormalized")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            IdRole = 1,
                            RoleName = "Super-Admin",
                            RoleNameNormalized = "SUPER-ADMIN"
                        },
                        new
                        {
                            IdRole = 2,
                            RoleName = "Candidato",
                            RoleNameNormalized = "CANDIDATO"
                        },
                        new
                        {
                            IdRole = 3,
                            RoleName = "Administrador",
                            RoleNameNormalized = "ADMINISTRADOR"
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

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTest");

                    b.ToTable("Test");

                    b.HasData(
                        new
                        {
                            IdTest = 1,
                            Link = "Test_PPGIPG",
                            NameTest = "PPG-IPG",
                            Time = "45 min."
                        },
                        new
                        {
                            IdTest = 2,
                            Link = "Test_OTIS",
                            NameTest = "OTIS",
                            Time = "45 min."
                        },
                        new
                        {
                            IdTest = 3,
                            Link = "Test_Dominos",
                            NameTest = "Dominos",
                            Time = "45 min."
                        },
                        new
                        {
                            IdTest = 4,
                            Link = "Test_BFQ",
                            NameTest = "BFQ",
                            Time = "45 min."
                        },
                        new
                        {
                            IdTest = 5,
                            Link = "Test_16PF_A",
                            NameTest = "16PF Forma A",
                            Time = "60 min."
                        },
                        new
                        {
                            IdTest = 6,
                            Link = "Test_16PF_B",
                            NameTest = "16PF Forma B",
                            Time = "60 min."
                        },
                        new
                        {
                            IdTest = 7,
                            Link = "Test_IPV",
                            NameTest = "IPV",
                            Time = "60 min."
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test_Candidate", b =>
                {
                    b.Property<int>("IdCandidate")
                        .HasColumnType("int");

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdCandidate", "IdTest");

                    b.HasIndex("IdTest");

                    b.ToTable("Test_Candidate");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test_Position", b =>
                {
                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<int>("IdPosition")
                        .HasColumnType("int");

                    b.HasKey("IdTest", "IdPosition");

                    b.HasIndex("IdPosition");

                    b.ToTable("Test_Position");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailNormalized")
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
                            EmailNormalized = "WM25@GMAIL.COM",
                            Name = "Werner Molina",
                            Password = "827ccb0eea8a706c4c34a16891f84e7b",
                            RegistrationDate = "20/07/2023 04:45 PM"
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

                    b.HasOne("RHPsicotest.WebSite.Models.Test", "Test")
                        .WithMany("Results")
                        .HasForeignKey("IdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expedient");

                    b.Navigation("Factor");

                    b.Navigation("Test");
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

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test_Candidate", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Candidate", "Candidate")
                        .WithMany("Tests")
                        .HasForeignKey("IdCandidate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Test", "Test")
                        .WithMany("Candidates")
                        .HasForeignKey("IdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test_Position", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Position", "Position")
                        .WithMany("Tests")
                        .HasForeignKey("IdPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Test", "Test")
                        .WithMany("Positions")
                        .HasForeignKey("IdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Candidate", b =>
                {
                    b.Navigation("Expedient");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Expedient", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Factor", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Position", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role", b =>
                {
                    b.Navigation("Candidate");

                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Test", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Positions");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
