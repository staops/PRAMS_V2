using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adm_MenuElements",
                columns: table => new
                {
                    MenuElementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Controlador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuElementParentId = table.Column<int>(type: "int", nullable: true),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_MenuElements", x => x.MenuElementId);
                });

            migrationBuilder.CreateTable(
                name: "Adm_MenuRole",
                columns: table => new
                {
                    MenuRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuElementId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_MenuRole", x => x.MenuRoleId);
                    table.ForeignKey(
                        name: "FK_Adm_MenuRole_Adm_MenuElements_MenuElementId",
                        column: x => x.MenuElementId,
                        principalTable: "Adm_MenuElements",
                        principalColumn: "MenuElementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 1, "Index", true, "Home", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8944), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-home", null, "Home", 1 },
                    { 2, "Index", true, "SystemConfiguration", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8947), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "System Configuration", 2 },
                    { 3, "Index", true, "Parametros", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8949), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Parametros", 1 },
                    { 4, "Index", true, "Categorias", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8950), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Categorias", 2 },
                    { 5, "Index", true, "Ajustes", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8985), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Ajustes", 3 },
                    { 6, "Index", true, "Roles", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8987), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Roles", 4 },
                    { 7, "Index", true, "Usuarios", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8989), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Usuarios", 5 },
                    { 8, "Index", true, "Otro", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8990), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Otro", 6 },
                    { 9, "Index", true, "AgregarRol", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8992), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Agregar", 7 },
                    { 10, "Index", true, "EditarRol", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8994), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Editar", 8 },
                    { 11, "Index", true, "EliminarRol", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8996), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Eliminar", 9 },
                    { 12, "Index", true, "AgregarUsuario", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8997), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Agregar", 10 },
                    { 13, "Index", true, "EditarUsuario", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(8999), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Editar", 11 },
                    { 14, "Index", true, "EliminarUsuario", new DateTime(2024, 6, 26, 0, 3, 23, 768, DateTimeKind.Local).AddTicks(9001), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Eliminar", 12 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Adm_MenuRole_MenuElementId",
                table: "Adm_MenuRole",
                column: "MenuElementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm_MenuRole");

            migrationBuilder.DropTable(
                name: "Adm_MenuElements");

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Adm_ParametroCategoria",
                keyColumn: "CategoriaID",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Adm_ParametrosSeleccion",
                keyColumn: "ParamterosID",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 6, 25, 23, 14, 43, 947, DateTimeKind.Local).AddTicks(3774));
        }
    }
}
