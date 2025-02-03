using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableAsignacionUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form_AsignacionUsuarios_Form_Referidos_FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_Form_AsignacionUsuarios_FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios");

            migrationBuilder.DropColumn(
                name: "FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios");

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 102,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 103,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 104,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 105,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 106,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 107,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 108,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 109,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 110,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 111,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 112,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 113,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 114,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 115,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 116,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 117,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 118,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 119,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 120,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 121,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 122,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 123,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 124,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 125,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 126,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 127,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 128,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 129,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 130,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 131,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 132,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 133,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 134,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 135,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 136,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 137,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 138,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 139,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 140,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 141,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 142,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 143,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 144,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 145,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 146,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 147,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 148,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 149,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 150,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 151,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 152,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 153,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 154,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 155,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 156,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 157,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 158,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 159,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 160,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 161,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 162,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 163,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 164,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 165,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 166,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 167,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 168,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 169,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 170,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 171,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 172,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 173,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 174,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 175,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 176,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 177,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 178,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 179,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 180,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 181,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 182,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 183,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 184,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 185,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 186,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 187,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 188,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 189,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 190,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 191,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 192,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 193,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 194,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 195,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 196,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 197,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 198,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 199,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 200,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 201,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 202,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 203,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 204,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 205,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 206,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 207,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 208,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 209,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 210,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 211,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 212,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 213,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 214,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 215,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 216,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 217,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 218,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 219,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 220,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 221,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 222,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 223,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 224,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 225,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 226,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 227,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 228,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 229,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 230,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 231,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 232,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 233,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 234,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 235,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 236,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 237,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 238,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 239,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 240,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 241,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 242,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 243,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 244,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 245,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 246,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 247,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 248,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 249,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 250,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 251,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 252,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 253,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 254,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 255,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 256,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 257,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 258,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 259,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 260,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 261,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 262,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 263,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 264,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 265,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 266,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 267,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 268,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 269,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 270,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 271,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 272,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 273,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 274,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 275,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 276,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 277,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 278,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 279,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 280,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 281,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 282,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 283,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 284,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 285,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 286,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 287,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 288,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 289,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 290,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 291,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 292,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 293,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 294,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 295,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 296,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 297,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 298,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 299,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 300,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 301,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 302,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 303,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 304,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 305,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 306,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 307,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 308,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 309,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 310,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 311,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 312,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 313,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 314,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 315,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 316,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 317,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 318,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 319,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 320,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 321,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 322,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 323,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 324,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 325,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 326,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 327,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 328,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 329,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 330,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 331,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 332,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 333,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 334,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 335,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 336,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 337,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 338,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 339,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 340,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 341,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 342,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 343,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 344,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 345,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 346,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 347,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 348,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 349,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 350,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 351,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 352,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 353,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 354,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 355,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 356,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 357,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 358,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 359,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 360,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 361,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 362,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 363,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 364,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 365,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 366,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 367,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 368,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 369,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 370,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 371,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 372,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 373,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 374,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 375,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 376,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 377,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 378,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 379,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 380,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 381,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 382,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 383,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 384,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 385,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 386,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 387,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 388,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 389,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 390,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 391,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 392,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 393,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 394,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 395,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 396,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 397,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 398,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 399,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 400,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 401,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 402,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 403,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 404,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 405,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 406,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 407,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 408,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 409,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 410,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 411,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 412,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 413,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 414,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 415,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 416,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 417,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 418,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 419,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 420,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 421,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 422,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 423,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 424,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 425,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 426,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 427,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 428,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 429,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 430,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 431,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 432,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 433,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 434,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 1,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 2,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 3,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 4,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 5,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 6,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 7,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 8,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 9,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 10,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 11,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 12,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 1,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 2,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 3,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 1,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5308), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5234), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 2,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo", "Servicio_FechaNotificacion" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5315), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5259), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 3,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5319), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5264), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5263), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 4,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5322), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 1, 22, 1, 3, 14, 331, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.CreateIndex(
                name: "IX_Form_AsignacionUsuarios_ID_Refereido",
                table: "Form_AsignacionUsuarios",
                column: "ID_Refereido");

            migrationBuilder.AddForeignKey(
                name: "FK_Form_AsignacionUsuarios_Form_Referidos_ID_Refereido",
                table: "Form_AsignacionUsuarios",
                column: "ID_Refereido",
                principalTable: "Form_Referidos",
                principalColumn: "ID_Referido",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form_AsignacionUsuarios_Form_Referidos_ID_Refereido",
                table: "Form_AsignacionUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_Form_AsignacionUsuarios_ID_Refereido",
                table: "Form_AsignacionUsuarios");

            migrationBuilder.AddColumn<int>(
                name: "FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 102,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 103,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 104,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 105,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 106,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 107,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 108,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 109,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 110,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 111,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 112,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 113,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 114,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 115,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 116,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 117,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 118,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 119,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 120,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 121,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 122,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 123,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 124,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 125,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 126,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 127,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 128,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 129,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 130,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 131,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 132,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 133,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 134,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 135,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 136,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 137,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 138,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 139,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 140,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 141,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 142,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 143,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 144,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 145,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 146,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 147,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 148,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 149,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 150,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 151,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 152,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 153,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 154,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 155,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 156,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 157,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 158,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 159,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 160,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 161,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 162,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 163,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 164,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 165,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 166,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 167,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 168,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 169,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 170,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 171,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 172,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 173,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 174,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 175,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 176,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 177,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 178,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 179,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 180,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 181,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 182,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 183,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 184,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 185,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 186,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 187,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 188,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 189,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 190,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 191,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 192,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 193,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 194,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 195,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 196,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 197,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 198,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 199,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 200,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 201,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 202,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 203,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 204,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 205,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 206,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 207,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 208,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 209,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 210,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 211,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 212,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 213,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 214,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 215,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 216,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 217,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 218,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 219,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 220,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 221,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 222,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 223,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 224,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 225,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 226,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 227,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 228,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 229,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 230,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 231,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 232,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 233,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 234,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 235,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 236,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 237,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 238,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 239,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 240,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 241,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 242,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 243,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 244,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 245,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 246,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 247,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 248,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 249,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 250,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 251,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 252,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 253,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 254,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 255,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 256,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 257,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 258,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 259,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 260,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 261,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 262,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 263,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 264,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 265,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 266,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 267,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 268,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 269,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 270,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 271,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 272,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 273,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 274,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 275,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 276,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 277,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 278,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 279,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 280,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 281,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 282,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 283,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 284,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 285,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 286,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 287,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 288,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 289,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 290,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 291,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 292,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 293,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 294,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 295,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 296,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 297,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 298,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 299,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 300,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 301,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 302,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 303,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 304,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 305,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 306,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 307,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 308,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 309,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 310,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 311,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 312,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 313,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 314,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 315,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 316,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 317,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 318,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 319,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 320,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 321,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 322,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 323,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 324,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 325,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 326,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 327,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 328,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 329,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 330,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 331,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 332,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 333,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 334,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 335,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 336,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 337,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 338,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 339,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 340,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 341,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 342,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 343,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 344,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 345,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 346,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 347,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 348,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 349,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 350,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 351,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 352,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 353,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 354,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 355,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 356,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 357,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 358,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 359,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 360,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 361,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 362,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 363,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 364,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 365,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 366,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 367,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 368,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 369,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 370,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 371,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 372,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 373,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 374,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 375,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 376,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 377,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 378,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 379,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 380,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 381,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 382,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 383,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 384,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 385,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 386,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 387,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 388,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 389,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 390,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 391,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 392,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 393,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 394,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 395,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 396,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 397,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 398,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 399,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 400,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 401,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 402,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 403,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 404,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 405,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 406,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 407,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 408,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 409,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 410,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 411,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 412,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 413,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 414,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 415,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 416,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 417,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 418,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 419,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 420,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 421,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 422,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 423,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 424,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 425,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 426,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 427,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 428,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 429,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 430,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 431,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 432,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 433,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 434,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 1,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 2,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 3,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 4,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 5,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 6,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 7,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 8,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 9,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 10,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 11,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 12,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 1,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 2,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 3,
                column: "FechaFirma",
                value: new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 1,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7320), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7318), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 2,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo", "Servicio_FechaNotificacion" },
                values: new object[] { new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7832), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7613), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7601), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7612), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 3,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7626), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 4,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7840), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7630), new DateTime(2025, 1, 22, 0, 40, 9, 816, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.CreateIndex(
                name: "IX_Form_AsignacionUsuarios_FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios",
                column: "FormReferidoNavigationReferidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Form_AsignacionUsuarios_Form_Referidos_FormReferidoNavigationReferidoId",
                table: "Form_AsignacionUsuarios",
                column: "FormReferidoNavigationReferidoId",
                principalTable: "Form_Referidos",
                principalColumn: "ID_Referido",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
