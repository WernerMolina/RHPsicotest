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

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Module", b =>
                {
                    b.Property<int>("IdModule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ModuleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdModule");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.Property<int>("IdPermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdModule")
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPermission");

                    b.HasIndex("IdModule");

                    b.ToTable("Permission");
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
                            RoleName = "Administrador"
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.HasIndex("IdUser");

                    b.ToTable("Role_User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdRole = 1,
                            IdUser = 3
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

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

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
                            IdUser = 3,
                            Email = "Wm25@gmail.com",
                            IdRole = 1,
                            Name = "Werner Molina",
                            Password = "827ccb0eea8a706c4c34a16891f84e7b",
                            RegistrationDate = new DateTime(2023, 1, 3, 18, 19, 27, 644, DateTimeKind.Local).AddTicks(3404)
                        });
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Permission", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Module", "Module")
                        .WithMany("Permissions")
                        .HasForeignKey("IdModule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role_User", b =>
                {
                    b.HasOne("RHPsicotest.WebSite.Models.Role", "Role")
                        .WithMany("Role_Users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RHPsicotest.WebSite.Models.User", "User")
                        .WithMany("Role_Users")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Module", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.Role", b =>
                {
                    b.Navigation("Role_Users");
                });

            modelBuilder.Entity("RHPsicotest.WebSite.Models.User", b =>
                {
                    b.Navigation("Role_Users");
                });
#pragma warning restore 612, 618
        }
    }
}
