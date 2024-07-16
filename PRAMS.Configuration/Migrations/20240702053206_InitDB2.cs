using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class InitDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adm_ReportAdminRole_Adm_ReportAdmin_AdmReportsReportId",
                table: "Adm_ReportAdminRole");

            migrationBuilder.DropIndex(
                name: "IX_Adm_ReportAdminRole_AdmReportsReportId",
                table: "Adm_ReportAdminRole");

            migrationBuilder.DropColumn(
                name: "AdmReportsReportId",
                table: "Adm_ReportAdminRole");

            migrationBuilder.CreateTable(
                name: "AdmReportsAdmReportsRole",
                columns: table => new
                {
                    AdmReportsReportId = table.Column<int>(type: "int", nullable: false),
                    AdmReportsRolesReportRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmReportsAdmReportsRole", x => new { x.AdmReportsReportId, x.AdmReportsRolesReportRoleId });
                    table.ForeignKey(
                        name: "FK_AdmReportsAdmReportsRole_Adm_ReportAdminRole_AdmReportsRolesReportRoleId",
                        column: x => x.AdmReportsRolesReportRoleId,
                        principalTable: "Adm_ReportAdminRole",
                        principalColumn: "ReportRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdmReportsAdmReportsRole_Adm_ReportAdmin_AdmReportsReportId",
                        column: x => x.AdmReportsReportId,
                        principalTable: "Adm_ReportAdmin",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 908, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 32, 5, 911, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.CreateIndex(
                name: "IX_AdmReportsAdmReportsRole_AdmReportsRolesReportRoleId",
                table: "AdmReportsAdmReportsRole",
                column: "AdmReportsRolesReportRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmReportsAdmReportsRole");

            migrationBuilder.AddColumn<int>(
                name: "AdmReportsReportId",
                table: "Adm_ReportAdminRole",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 7, 1, 23, 4, 38, 753, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                columns: new[] { "AdmReportsReportId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 1, 23, 4, 38, 755, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.CreateIndex(
                name: "IX_Adm_ReportAdminRole_AdmReportsReportId",
                table: "Adm_ReportAdminRole",
                column: "AdmReportsReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_ReportAdminRole_Adm_ReportAdmin_AdmReportsReportId",
                table: "Adm_ReportAdminRole",
                column: "AdmReportsReportId",
                principalTable: "Adm_ReportAdmin",
                principalColumn: "ReportId");
        }
    }
}
