using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class AddThirdMenuLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 15, "Index", true, "EliminarUsuario", new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4775), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado físico", 12 },
                    { 16, "Index", true, "EliminarUsuario", new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4777), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado lógico", 12 },
                    { 17, "Index", true, "EliminarUsuario", new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4779), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Borrado lógico", 12 },
                    { 18, "Index", false, "EliminarUsuario", new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4780), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Elmento eliminado", 12 }
                });

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 23, 28, 29, 433, DateTimeKind.Local).AddTicks(4663));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 21, 58, 23, 436, DateTimeKind.Local).AddTicks(7679));
        }
    }
}
