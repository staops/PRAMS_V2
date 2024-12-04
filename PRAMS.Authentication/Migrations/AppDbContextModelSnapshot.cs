﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRAMS.Authentication.Data;

#nullable disable

namespace PRAMS.Authentication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d0c5ab97-e957-44b1-a060-c791c2a6c600",
                            Name = "SU",
                            NormalizedName = "SU"
                        },
                        new
                        {
                            Id = "ae38c61c-eb79-4f0d-9dc7-f7f0756867f2",
                            Name = "Administrador Auxiliar",
                            NormalizedName = "ADMINISTRADOR AUXILIAR"
                        },
                        new
                        {
                            Id = "feb8594f-e247-4840-95fb-d061a8b0eec4",
                            Name = "Oficial Administrativo",
                            NormalizedName = "OFICIAL ADMINISTRATIVO"
                        },
                        new
                        {
                            Id = "d8f77203-1535-4c43-a170-e6add93f53d7",
                            Name = "Supervisor Regional",
                            NormalizedName = "SUPERVISOR REGIONAL"
                        },
                        new
                        {
                            Id = "3b3a99f2-d240-4dd0-bf06-59d21ae37469",
                            Name = "Supervisor de oficina local",
                            NormalizedName = "SUPERVISOR DE OFICINA LOCAL"
                        },
                        new
                        {
                            Id = "89bc12fd-c1b0-44dc-9d7b-aa1c08ed938b",
                            Name = "Trabajador Social",
                            NormalizedName = "TRABAJADOR SOCIAL"
                        },
                        new
                        {
                            Id = "71c424a5-f0e8-4d8e-812b-2933d9cdbff1",
                            Name = "Director Regional",
                            NormalizedName = "DIRECTOR REGIONAL"
                        },
                        new
                        {
                            Id = "d345e149-a42a-4535-b62f-75554c00326b",
                            Name = "Director Asociado",
                            NormalizedName = "DIRECTOR ASOCIADO"
                        },
                        new
                        {
                            Id = "9072c61f-c994-4602-a975-7c4799a32c24",
                            Name = "Tecnico de Servicios a la Familia",
                            NormalizedName = "TECNICO DE SERVICIOS A LA FAMILIA"
                        },
                        new
                        {
                            Id = "7cf26328-f1e0-48ef-9618-a969fc762136",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "a5ec2f90-f06b-4388-a597-119ee5173360",
                            Name = "Sub-Administrador",
                            NormalizedName = "SUB-ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "f37bfa85-c44c-4bfc-a6c4-37b4b2621031",
                            Name = "Especialista Trabajador Social",
                            NormalizedName = "ESPECIALISTA TRABAJADOR SOCIAL"
                        },
                        new
                        {
                            Id = "23119a6b-ce86-43ea-b292-fc6aba327306",
                            Name = "Asistente de Servicio",
                            NormalizedName = "ASISTENTE DE SERVICIO"
                        },
                        new
                        {
                            Id = "a96d4963-584d-4ab4-8cf0-bea6c3bb5de7",
                            Name = "Supervisor UIE",
                            NormalizedName = "SUPERVISOR UIE"
                        },
                        new
                        {
                            Id = "2c614cc4-18bf-4f7f-afc4-d8c9a895bcee",
                            Name = "Investigadores UIE",
                            NormalizedName = "INVESTIGADORES UIE"
                        },
                        new
                        {
                            Id = "6f2aeece-a234-42cb-a8e6-cf5ae105f7d6",
                            Name = "Director de Programa",
                            NormalizedName = "DIRECTOR DE PROGRAMA"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PRAMS.Authentication.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Initial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "118fb076-affa-4fda-8617-e6c39b7e53c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                            Email = "admin1@sta.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN1@STA.COM",
                            NormalizedUserName = "ADMIN1@STA.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                            PhoneNumber = "7875555555",
                            PhoneNumberConfirmed = false,
                            SecondLastName = "One",
                            SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                            TwoFactorEnabled = false,
                            UserName = "admin1@sta.com"
                        },
                        new
                        {
                            Id = "b4cbb14e-bb75-4143-b530-ec5d8bad55f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                            Email = "admin@sta.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@STA.COM",
                            NormalizedUserName = "ADMIN@STA.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                            PhoneNumber = "7875555555",
                            PhoneNumberConfirmed = false,
                            SecondLastName = "Two",
                            SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                            TwoFactorEnabled = false,
                            UserName = "admin@sta.com"
                        },
                        new
                        {
                            Id = "03334448-73b4-438f-8fdf-784dbab58150",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                            Email = "dummy@dummy.com",
                            EmailConfirmed = false,
                            FirstName = "Dummy",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@DUMMY.COM",
                            NormalizedUserName = "DUMMY@DUMMY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a4+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                            PhoneNumber = "7875555555",
                            PhoneNumberConfirmed = false,
                            SecondLastName = "One",
                            SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                            TwoFactorEnabled = false,
                            UserName = "dummy@dummy.com"
                        },
                        new
                        {
                            Id = "69e6dd63-c624-4c4a-8bf4-c910148367ad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5a499d0-52da-42e4-aa60-06170e7c5000",
                            Email = "dummy2@dummy.com",
                            EmailConfirmed = false,
                            FirstName = "Dummy",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN2@DUMMY.COM",
                            NormalizedUserName = "DUMMY2@DUMMY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a3+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==",
                            PhoneNumber = "7875555555",
                            PhoneNumberConfirmed = false,
                            SecondLastName = "Two",
                            SecurityStamp = "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC",
                            TwoFactorEnabled = false,
                            UserName = "dummy2@dummy.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PRAMS.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PRAMS.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRAMS.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PRAMS.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
