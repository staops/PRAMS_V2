using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class Update_Form_Referidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Externo",
                table: "Form_Referidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TipoInvestigacion",
                table: "Form_Referidos",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 102,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 103,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 104,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 105,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 106,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 107,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 108,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 109,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 110,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 111,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 112,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 113,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 114,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 115,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 116,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 117,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 118,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 119,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 120,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 121,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 122,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 123,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 124,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 125,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 126,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 127,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 128,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 129,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 130,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 131,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 132,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 133,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 134,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 135,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 136,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 137,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 138,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 139,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 140,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 141,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 142,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 143,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 144,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 145,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 146,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 147,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 148,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 149,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 150,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 151,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 152,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 153,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 154,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 155,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 156,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 157,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 158,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 159,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 160,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 161,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 162,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 163,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 164,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 165,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 166,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 167,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 168,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 169,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 170,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 171,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 172,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 173,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 174,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 175,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 176,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 177,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 178,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 179,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 180,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 181,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 182,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 183,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 184,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 185,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 186,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 187,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 188,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 189,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 190,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 191,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 192,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 193,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 194,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 195,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 196,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 197,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 198,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 199,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 200,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 201,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 202,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 203,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 204,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 205,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 206,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 207,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 208,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 209,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 210,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 211,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 212,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 213,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 214,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 215,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 216,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 217,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 218,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 219,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 220,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 221,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 222,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 223,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 224,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 225,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 226,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 227,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 228,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 229,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 230,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 231,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 232,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 233,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 234,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 235,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 236,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 237,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 238,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 239,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 240,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 241,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 242,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 243,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 244,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 245,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 246,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 247,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 248,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 249,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 250,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 251,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 252,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 253,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 254,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 255,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 256,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 257,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 258,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 259,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 260,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 261,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 262,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 263,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 264,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 265,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 266,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 267,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 268,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 269,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 270,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 271,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 272,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 273,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 274,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 275,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 276,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 277,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 278,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 279,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 280,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 281,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 282,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 283,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 284,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 285,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 286,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 287,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 288,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 289,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 290,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 291,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 292,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 293,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 294,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 295,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 296,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 297,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 298,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 299,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 300,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 301,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 302,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 303,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 304,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 305,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 306,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 307,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 308,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 309,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 310,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 311,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 312,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 313,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 314,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 315,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 316,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 317,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 318,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 319,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 320,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 321,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 322,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 323,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 324,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 325,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 326,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 327,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 328,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 329,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 330,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 331,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 332,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 333,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 334,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 335,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 336,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 337,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 338,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 339,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 340,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 341,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 342,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 343,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 344,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 345,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 346,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 347,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 348,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 349,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 350,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 351,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 352,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 353,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 354,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 355,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 356,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 357,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 358,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 359,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 360,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 361,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 362,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 363,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 364,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 365,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 366,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 367,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 368,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 369,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 370,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 371,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 372,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 373,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 374,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 375,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 376,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 377,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 378,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 379,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 380,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 381,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 382,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 383,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 384,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 385,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 386,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 387,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 388,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 389,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 390,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 391,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 392,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 393,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 394,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 395,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 396,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 397,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 398,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 399,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 400,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 401,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 402,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 403,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 404,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 405,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 406,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 407,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 408,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 409,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 410,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 411,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 412,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 413,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 414,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 415,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 416,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 417,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 418,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 419,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 420,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 421,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 422,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 423,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 424,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 425,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 426,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 427,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 428,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 429,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 430,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 431,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 432,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 433,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 434,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 1,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 2,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 3,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 4,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 5,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 6,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 7,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 8,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 9,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 10,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 11,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 12,
                column: "Fecha_Flujo",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 1,
                column: "FechaFirma",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 2,
                column: "FechaFirma",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 3,
                column: "FechaFirma",
                value: new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 1,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "Externo", "FechaRecibo", "HoraRecibo", "TipoInvestigacion" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7516), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7468), false, new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7467), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7468), null });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 2,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "Externo", "FechaRecibo", "HoraRecibo", "Servicio_FechaNotificacion", "TipoInvestigacion" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7521), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7483), false, new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7481), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7482), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7482), null });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 3,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "Externo", "FechaRecibo", "HoraRecibo", "TipoInvestigacion" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7486), false, new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7485), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7486), null });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 4,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "Externo", "FechaRecibo", "HoraRecibo", "TipoInvestigacion" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7528), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7489), false, new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7488), new DateTime(2025, 2, 10, 23, 30, 15, 767, DateTimeKind.Local).AddTicks(7489), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Externo",
                table: "Form_Referidos");

            migrationBuilder.DropColumn(
                name: "TipoInvestigacion",
                table: "Form_Referidos");

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
        }
    }
}
