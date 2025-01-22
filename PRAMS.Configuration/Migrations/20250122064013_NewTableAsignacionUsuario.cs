using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class NewTableAsignacionUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form_AsignacionUsuarios",
                columns: table => new
                {
                    ID_AsignacionUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Refereido = table.Column<int>(type: "int", nullable: false),
                    RMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_Caso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NivelCaso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Usuario_Asigna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrincipalTS = table.Column<bool>(type: "bit", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormReferidoNavigationReferidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_AsignacionUsuarios", x => x.ID_AsignacionUsuario);
                    table.ForeignKey(
                        name: "FK_Form_AsignacionUsuarios_Form_Referidos_FormReferidoNavigationReferidoId",
                        column: x => x.FormReferidoNavigationReferidoId,
                        principalTable: "Form_Referidos",
                        principalColumn: "ID_Referido",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form_AsignacionUsuarios");

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapas",
                keyColumn: "FormularioEtapaId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                keyColumn: "FormularioEtapaAccionId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 101,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 102,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 103,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 104,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 105,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 106,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 107,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 108,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 109,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 110,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 111,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 112,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 113,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 114,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 115,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 116,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 117,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 118,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 119,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 120,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 121,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 122,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 123,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 124,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 125,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 126,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 127,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 128,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 129,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 130,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 131,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 132,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 133,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 134,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 135,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 136,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 137,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 138,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 139,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 140,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 141,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 142,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 143,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 144,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 145,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 146,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 147,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 148,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 149,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 150,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 151,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 152,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 153,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 154,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 155,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 156,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 157,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 158,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 159,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 160,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 161,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 162,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 163,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 164,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 165,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 166,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 167,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 168,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 169,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 170,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 171,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 172,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 173,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 174,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 175,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 176,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 177,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 178,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 179,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 180,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 181,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 182,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 183,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 184,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 185,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 186,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 187,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 188,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 189,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 190,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 191,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 192,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 193,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 194,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 195,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 196,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 197,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 198,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 199,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 200,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 201,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 202,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 203,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 204,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 205,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 206,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 207,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 208,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 209,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 210,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 211,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 212,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 213,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 214,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 215,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 216,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 217,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 218,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 219,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 220,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 221,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 222,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 223,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 224,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 225,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 226,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 227,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 228,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 229,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 230,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 231,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 232,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 233,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 234,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 235,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 236,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 237,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 238,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 239,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 240,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 241,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 242,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 243,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 244,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 245,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 246,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 247,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 248,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 249,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 250,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 251,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 252,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 253,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 254,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 255,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 256,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 257,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 258,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 259,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 260,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 261,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 262,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 263,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 264,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 265,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 266,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 267,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 268,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 269,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 270,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 271,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 272,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 273,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 274,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 275,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 276,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 277,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 278,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 279,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 280,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 281,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 282,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 283,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 284,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 285,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 286,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 287,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 288,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 289,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 290,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 291,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 292,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 293,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 294,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 295,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 296,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 297,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 298,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 299,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 300,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 301,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 302,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 303,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 304,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 305,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 306,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 307,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 308,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 309,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 310,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 311,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 312,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 313,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 314,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 315,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 316,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 317,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 318,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 319,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 320,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 321,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 322,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 323,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 324,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 325,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 326,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 327,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 328,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 329,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 330,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 331,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 332,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 333,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 334,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 335,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 336,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 337,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 338,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 339,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 340,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 341,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 342,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 343,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 344,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 345,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 346,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 347,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 348,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 349,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 350,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 351,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 352,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 353,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 354,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 355,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 356,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 357,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 358,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 359,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 360,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 361,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 362,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 363,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 364,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 365,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 366,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 367,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 368,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 369,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 370,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 371,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 372,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 373,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 374,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 375,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 376,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 377,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 378,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 379,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 380,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 381,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 382,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 383,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 384,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 385,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 386,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 387,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 388,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 389,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 390,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 391,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 392,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 393,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 394,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 395,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 396,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 397,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 398,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 399,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 400,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 401,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 402,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 403,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 404,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 405,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 406,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 407,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 408,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 409,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 410,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 411,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 412,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 413,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 414,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 415,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 416,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 417,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 418,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 419,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 420,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 421,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 422,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 423,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 424,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 425,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 426,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 427,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 428,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 429,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 430,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 431,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 432,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 433,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 434,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdmin",
                keyColumn: "ReportId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Adm_ReportAdminRole",
                keyColumn: "ReportRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 1,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 2,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 3,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 4,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 5,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 6,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 7,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 8,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 9,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 10,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 11,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Form_FlujosPantallas",
                keyColumn: "ID_FORM_FlujoPantalla",
                keyValue: 12,
                column: "Fecha_Flujo",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 1,
                column: "FechaFirma",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 2,
                column: "FechaFirma",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Form_FormulariosFirmas",
                keyColumn: "ID_FormularioFirmas",
                keyValue: 3,
                column: "FechaFirma",
                value: new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 1,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9804), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9803), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 2,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo", "Servicio_FechaNotificacion" },
                values: new object[] { new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9816), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 3,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9862), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9819), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Form_Referidos",
                keyColumn: "ID_Referido",
                keyValue: 4,
                columns: new[] { "CreateDate", "Determinacion_Fecha", "FechaRecibo", "HoraRecibo" },
                values: new object[] { new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 12, 13, 9, 59, 39, 361, DateTimeKind.Local).AddTicks(9823) });
        }
    }
}
