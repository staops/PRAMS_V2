using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class AddRolMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8483), "03334448-73b4-438f-8fdf-784dbab58150", 1, "SU" },
                    { 2, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8484), "03334448-73b4-438f-8fdf-784dbab58150", 2, "SU" },
                    { 3, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8486), "03334448-73b4-438f-8fdf-784dbab58150", 3, "SU" },
                    { 4, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8487), "03334448-73b4-438f-8fdf-784dbab58150", 4, "SU" },
                    { 5, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8488), "03334448-73b4-438f-8fdf-784dbab58150", 5, "SU" },
                    { 6, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8490), "03334448-73b4-438f-8fdf-784dbab58150", 6, "SU" },
                    { 7, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8491), "03334448-73b4-438f-8fdf-784dbab58150", 7, "SU" },
                    { 8, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8492), "03334448-73b4-438f-8fdf-784dbab58150", 8, "SU" },
                    { 9, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8493), "03334448-73b4-438f-8fdf-784dbab58150", 9, "SU" },
                    { 10, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8495), "03334448-73b4-438f-8fdf-784dbab58150", 10, "SU" },
                    { 11, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8496), "03334448-73b4-438f-8fdf-784dbab58150", 11, "SU" },
                    { 12, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8497), "03334448-73b4-438f-8fdf-784dbab58150", 12, "SU" },
                    { 13, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8499), "03334448-73b4-438f-8fdf-784dbab58150", 13, "SU" },
                    { 14, true, new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8500), "03334448-73b4-438f-8fdf-784dbab58150", 14, "SU" }
                });

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 43, 12, 901, DateTimeKind.Local).AddTicks(8416));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Adm_MenuRole",
                keyColumn: "MenuRoleId",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Adm_MenuElements",
                keyColumn: "MenuElementId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8926));
        }
    }
}
