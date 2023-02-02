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
    [Migration("20230124212658_UsernameAddMigration")]
    partial class UsernameAddMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RHPsicotest.WebSite.Models.EmailUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPuesto")
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.HasIndex("IdPuesto");

                    b.HasIndex("IdRole");

                    b.ToTable("EmailUser");
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

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Stall", b =>
                {
                    b.Property<int>("IdStall")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StallHigher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StallName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdStall");

                    b.ToTable("Stall");
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

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUser");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            Email = "Wm25@gmail.com",
                            Name = "Werner Molina",
                            Password = "827ccb0eea8a706c4c34a16891f84e7b",
                            RegistrationDate = new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.EmailUser", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Stall", "Stall")
                        .WithMany("Candidates")
                        .HasForeignKey("IdPuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.Role", "Role")
                        .WithMany("Candidates")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Stall");
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

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Stall", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
