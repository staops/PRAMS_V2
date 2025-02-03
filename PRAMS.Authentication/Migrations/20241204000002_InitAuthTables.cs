using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Authentication.Migrations
{
    /// <inheritdoc />
    public partial class InitAuthTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Initial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23119a6b-ce86-43ea-b292-fc6aba327306", null, "Asistente de Servicio", "ASISTENTE DE SERVICIO" },
                    { "2c614cc4-18bf-4f7f-afc4-d8c9a895bcee", null, "Investigadores UIE", "INVESTIGADORES UIE" },
                    { "3b3a99f2-d240-4dd0-bf06-59d21ae37469", null, "Supervisor de oficina local", "SUPERVISOR DE OFICINA LOCAL" },
                    { "6f2aeece-a234-42cb-a8e6-cf5ae105f7d6", null, "Director de Programa", "DIRECTOR DE PROGRAMA" },
                    { "71c424a5-f0e8-4d8e-812b-2933d9cdbff1", null, "Director Regional", "DIRECTOR REGIONAL" },
                    { "7cf26328-f1e0-48ef-9618-a969fc762136", null, "Administrador", "ADMINISTRADOR" },
                    { "89bc12fd-c1b0-44dc-9d7b-aa1c08ed938b", null, "Trabajador Social", "TRABAJADOR SOCIAL" },
                    { "9072c61f-c994-4602-a975-7c4799a32c24", null, "Tecnico de Servicios a la Familia", "TECNICO DE SERVICIOS A LA FAMILIA" },
                    { "a5ec2f90-f06b-4388-a597-119ee5173360", null, "Sub-Administrador", "SUB-ADMINISTRADOR" },
                    { "a96d4963-584d-4ab4-8cf0-bea6c3bb5de7", null, "Supervisor UIE", "SUPERVISOR UIE" },
                    { "ae38c61c-eb79-4f0d-9dc7-f7f0756867f2", null, "Administrador Auxiliar", "ADMINISTRADOR AUXILIAR" },
                    { "d0c5ab97-e957-44b1-a060-c791c2a6c600", null, "SU", "SU" },
                    { "d345e149-a42a-4535-b62f-75554c00326b", null, "Director Asociado", "DIRECTOR ASOCIADO" },
                    { "d8f77203-1535-4c43-a170-e6add93f53d7", null, "Supervisor Regional", "SUPERVISOR REGIONAL" },
                    { "f37bfa85-c44c-4bfc-a6c4-37b4b2621031", null, "Especialista Trabajador Social", "ESPECIALISTA TRABAJADOR SOCIAL" },
                    { "feb8594f-e247-4840-95fb-d061a8b0eec4", null, "Oficial Administrativo", "OFICIAL ADMINISTRATIVO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Initial", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03334448-73b4-438f-8fdf-784dbab58150", 0, "e5a499d0-52da-42e4-aa60-06170e7c5000", "dummy@dummy.com", false, "Dummy", null, "User", true, null, "ADMIN@DUMMY.COM", "DUMMY@DUMMY.COM", "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a4+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==", "7875555555", false, "One", "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC", false, "dummy@dummy.com" },
                    { "118fb076-affa-4fda-8617-e6c39b7e53c2", 0, "e5a499d0-52da-42e4-aa60-06170e7c5000", "admin1@sta.com", false, "Admin", null, "User", true, null, "ADMIN1@STA.COM", "ADMIN1@STA.COM", "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==", "7875555555", false, "One", "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC", false, "admin1@sta.com" },
                    { "69e6dd63-c624-4c4a-8bf4-c910148367ad", 0, "e5a499d0-52da-42e4-aa60-06170e7c5000", "dummy2@dummy.com", false, "Dummy", null, "User", true, null, "ADMIN2@DUMMY.COM", "DUMMY2@DUMMY.COM", "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a3+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==", "7875555555", false, "Two", "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC", false, "dummy2@dummy.com" },
                    { "b4cbb14e-bb75-4143-b530-ec5d8bad55f7", 0, "e5a499d0-52da-42e4-aa60-06170e7c5000", "admin@sta.com", false, "Admin", null, "User", true, null, "ADMIN@STA.COM", "ADMIN@STA.COM", "AQAAAAIAAYagAAAAEL8h+yY/r8Lhawk8du3a2+xAEv/sDCq9Lneg2HaUG7fJfAGWyfldFGmSDIOSZnst+w==", "7875555555", false, "Two", "SMJSAWT2M63D7BYXQ7R2E3AA2GILPLBC", false, "admin@sta.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
