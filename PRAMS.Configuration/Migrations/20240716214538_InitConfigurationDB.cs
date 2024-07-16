using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Configuration.Migrations
{
    /// <inheritdoc />
    public partial class InitConfigurationDB : Migration
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
                    table.ForeignKey(
                        name: "FK_Adm_MenuElements_Adm_MenuElements_MenuElementParentId",
                        column: x => x.MenuElementParentId,
                        principalTable: "Adm_MenuElements",
                        principalColumn: "MenuElementId");
                });

            migrationBuilder.CreateTable(
                name: "Adm_ParametroCategoria",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TX_Filtro1_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro2_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro3_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro4_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro5_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro6_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro7_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro8_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro9_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_ParametroCategoria", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Adm_ReportAdmin",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_ReportAdmin", x => x.ReportId);
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

            migrationBuilder.CreateTable(
                name: "Adm_ParametrosSeleccion",
                columns: table => new
                {
                    ParamterosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    Parametro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TX_Filtro1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_Filtro9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_ParametrosSeleccion", x => x.ParamterosID);
                    table.ForeignKey(
                        name: "FK_Adm_ParametrosSeleccion_Adm_ParametroCategoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Adm_ParametroCategoria",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adm_ReportAdminRole",
                columns: table => new
                {
                    ReportRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_ReportAdminRole", x => x.ReportRoleId);
                    table.ForeignKey(
                        name: "FK_Adm_ReportAdminRole_Adm_ReportAdmin_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Adm_ReportAdmin",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 1, "Index", true, "Home", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2715), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-home", null, "Home", 1 },
                    { 2, "Index", true, "SystemConfiguration", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2719), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "System Configuration", 2 },
                    { 5, "Index", true, "Ajustes", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2726), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Ajustes", 3 },
                    { 17, "Index", true, "EliminarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2754), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Borrado lógico", 12 },
                    { 18, "Index", false, "EliminarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2756), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Elmento eliminado", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_ParametroCategoria",
                columns: new[] { "CategoriaID", "Activo", "Categoria", "CreateDate", "CreateUser", "Descripcion", "ModifiedDate", "ModifiedUser", "TX_Filtro1_Nombre", "TX_Filtro2_Nombre", "TX_Filtro3_Nombre", "TX_Filtro4_Nombre", "TX_Filtro5_Nombre", "TX_Filtro6_Nombre", "TX_Filtro7_Nombre", "TX_Filtro8_Nombre", "TX_Filtro9_Nombre" },
                values: new object[,]
                {
                    { 1, true, "Clasificacion Empleados", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2355), "03334448-73b4-438f-8fdf-784dbab58150", "Clasificaciones", null, null, null, null, null, null, null, null, null, null, null },
                    { 2, true, "Curso Aprobado", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2357), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 3, false, "Curso Aprobado Demo", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2359), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 4, true, "Tipo Impedimento", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2361), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 5, true, "Tipo Nombramiento", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2390), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 6, true, "Pueblos", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2393), "03334448-73b4-438f-8fdf-784dbab58150", "Def Pueblos con Dos Niveles de Filtros", null, null, "Estado", "Pais", null, null, null, null, null, null, null },
                    { 7, true, "Categoria Licencias", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2394), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 8, true, "Firmas", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2396), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, "Posición / Puesto", null, null, null, null, null, null, null, null },
                    { 9, true, "Acciones", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2398), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 10, true, "Genero", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2400), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 11, true, "Region", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2402), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 12, true, "Tipo Convocatoria", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2403), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 13, true, "Dependencias", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2405), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 14, false, "Dependencias2", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2406), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 15, false, "Dependencias3", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2408), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 16, true, "Entidades Municipio", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2410), "03334448-73b4-438f-8fdf-784dbab58150", "Def Municipios Tres Niveles Ejemplo", null, null, "Region", "Estado", "Pais", null, null, null, null, null, null },
                    { 17, true, "Cantidad Solicitudes", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2412), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 18, false, "Cantidad Solicitudes2", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2413), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 19, true, "Grados Academicos", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2415), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 20, true, "Tipo de Documentos", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2416), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 21, true, "Tipo Reportes", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2418), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 22, true, "RolesReportes", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2420), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 23, true, "RolesMenu", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2422), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Adm_ReportAdmin",
                columns: new[] { "ReportId", "Activo", "CreateDate", "CreateUser", "Orden", "ReportDescription", "ReportLink", "ReportName", "ReportParameters", "ReportType" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2875), "03334448-73b4-438f-8fdf-784dbab58150", 1, "Lista los RMS Pendientes Diariamente, selección por Fecha y agrupado por Región", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_GeneradosDiarios", "Listado de RMS Generados Diarios (por Región)", "Fecha", "Región" },
                    { 2, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2878), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Lista los RMS Completados por los Empleados por rango de fecha y por Región (Todos los Contestados)", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRange", "RMS Completados por Empleados rango de Fechas y por Región", "Fechas", "Región" },
                    { 3, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2880), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Lista los RMS Completados Validos por los Empleados por rango de fecha y por Región (Solo Validos)", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRangeValid", "RMS Completados por Fechas, Región y que son Validos", "Fechas, Region", "Región" },
                    { 4, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2882), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Reporte de RMS Completados Validos para reclamos, incluye Numero de RMS para uso en las Asistencias de los Empleados para los RMS Contestados.", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_ValidAssistance", "Reporte de RMS Validos Completados Listado para Asistencias de Empleados", "Fecha, Region", "Finanzas" },
                    { 5, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2884), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Resumen de los RMS enviados, completados, invalidos, seguimientos y validos con porcientos de completados", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRms_Statdistics_DateRangeRegion", "RMS Resumen Estadisticas Envíos por Rango Fecha y Región", "Fecha y Region", "Administración" },
                    { 6, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2886), "03334448-73b4-438f-8fdf-784dbab58150", 1, "Muestra el Formulario RMS según llenado por los Trabajadores Sociales", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_WorkDetailRange", "Formulario RMS llenados por Fecha ", "Fecha", "Administración" },
                    { 7, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2888), "03334448-73b4-438f-8fdf-784dbab58150", 4, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Diarios", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationDaily", "Cost Allocation Plan Reporte Diario", "Fecha", "Finanzas" },
                    { 8, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2890), "03334448-73b4-438f-8fdf-784dbab58150", 5, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant para el Mes seleccionado.", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationMonthly", "Cost Allocation Plan Reporte Mensual", "Fecha", "Finanzas" },
                    { 9, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2893), "03334448-73b4-438f-8fdf-784dbab58150", 7, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Trimestrales", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationQuarter", "Cost Allocation Plan Reporte Trimestral", "Fecha", "Finanzas" },
                    { 10, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2895), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Este Reporte muestra todas las Observaciones entradas por los usuarios en un rango de fechas con sus respectivos Títulos y Grants por rango de Fecha y selección de Validos o Invalidos para el CAP", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Submitted_DateRange", "Observaciones Completadas por Rango de Fecha (Selección Validas)", "Fechas", "Administración" },
                    { 11, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2897), "03334448-73b4-438f-8fdf-784dbab58150", 1, "RMS Matrix Distribution Report for the CAP Titile Distribution", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_Matrix", "RMS Matrix", "Fechas", "Finanzas" },
                    { 12, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2899), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Listado de RMS Validos para completar el Schedule D del CAP", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_ScheduleD", "Schedule D Listado RMS", "Fechas", "Finanzas" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 3, "Index", true, "Parametros", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2722), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Parametros", 1 },
                    { 4, "Index", true, "Categorias", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2724), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Categorias", 2 },
                    { 6, "Index", true, "Roles", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2728), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Roles", 4 },
                    { 7, "Index", true, "Usuarios", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2731), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Usuarios", 5 },
                    { 8, "Index", true, "Otro", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2733), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Otro", 6 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2790), "03334448-73b4-438f-8fdf-784dbab58150", 1, "SU" },
                    { 2, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2792), "03334448-73b4-438f-8fdf-784dbab58150", 2, "SU" },
                    { 5, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2824), "03334448-73b4-438f-8fdf-784dbab58150", 5, "SU" },
                    { 17, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2842), "03334448-73b4-438f-8fdf-784dbab58150", 17, "SU" },
                    { 18, false, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2844), "03334448-73b4-438f-8fdf-784dbab58150", 18, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Adm_ParametrosSeleccion",
                columns: new[] { "ParamterosID", "Activo", "CategoriaID", "CreateDate", "CreateUser", "Descripcion", "FechaEnd", "FechaStart", "ModifiedDate", "ModifiedUser", "Parametro", "TX_Filtro1", "TX_Filtro2", "TX_Filtro3", "TX_Filtro4", "TX_Filtro5", "TX_Filtro6", "TX_Filtro7", "TX_Filtro8", "TX_Filtro9" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2536), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado", null, null, null, null, null, null, null, null, null },
                    { 2, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2538), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado Temporal", null, null, null, null, null, null, null, null, null },
                    { 3, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2540), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado Contratado", null, null, null, null, null, null, null, null, null },
                    { 4, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2542), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado de Carrera", null, null, null, null, null, null, null, null, null },
                    { 5, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2543), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado de Confianza", null, null, null, null, null, null, null, null, null },
                    { 6, true, 1, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2545), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado de Base", null, null, null, null, null, null, null, null, null },
                    { 7, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2572), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "San Juan", "Area Metro", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 8, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2575), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Carolina", "Area Metro", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 9, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2576), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Arecibo", "Area Norte", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 10, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2578), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Ponce", "Area Sur", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 11, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2580), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Orange", "Central", "Florida", "Estados Unidos", null, null, null, null, null, null },
                    { 12, true, 16, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2582), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "New York City", "Greater City", "New York", "Estados Unidos", null, null, null, null, null, null },
                    { 13, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2645), "03334448-73b4-438f-8fdf-784dbab58150", "Bernardo Acevedo González", null, null, null, null, "BAG", "Analista de Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 14, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2647), "03334448-73b4-438f-8fdf-784dbab58150", "Carmín Rodríguez Negrón", null, null, null, null, "CRN", "Directora", null, null, null, null, null, null, null, null },
                    { 15, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2649), "03334448-73b4-438f-8fdf-784dbab58150", "Jannette López Falcón", null, null, null, null, "JLF", "Analista de Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 16, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2651), "03334448-73b4-438f-8fdf-784dbab58150", "Victor Maldonado Martínez", null, null, null, null, "VMM", "Director", null, null, null, null, null, null, null, null },
                    { 17, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2652), "03334448-73b4-438f-8fdf-784dbab58150", "Juan Perez Rodriguez", null, null, null, null, "JPR", "Analista ASUME", null, null, null, null, null, null, null, null },
                    { 18, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2654), "03334448-73b4-438f-8fdf-784dbab58150", "Nancy Calderon Alicea", null, null, null, null, "NCA", "Especialista Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 19, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2656), "03334448-73b4-438f-8fdf-784dbab58150", "Gabriel Otero Valentin", null, null, null, null, "GOV", "Analista ADSEF", null, null, null, null, null, null, null, null },
                    { 20, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2658), "03334448-73b4-438f-8fdf-784dbab58150", "Leslie Soto Matos", null, null, null, null, "LSM", "Analista AMSCA", null, null, null, null, null, null, null, null },
                    { 21, true, 8, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2660), "03334448-73b4-438f-8fdf-784dbab58150", "Secretaria Gerencia", null, null, null, null, "SEC-GME", "Administrador", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Adm_ReportAdminRole",
                columns: new[] { "ReportRoleId", "Activo", "CreateDate", "CreateUser", "ReportId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4074), "03334448-73b4-438f-8fdf-784dbab58150", 1, "SU" },
                    { 2, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4077), "03334448-73b4-438f-8fdf-784dbab58150", 2, "SU" },
                    { 3, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4079), "03334448-73b4-438f-8fdf-784dbab58150", 3, "SU" },
                    { 4, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4080), "03334448-73b4-438f-8fdf-784dbab58150", 4, "SU" },
                    { 5, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4082), "03334448-73b4-438f-8fdf-784dbab58150", 5, "SU" },
                    { 6, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4084), "03334448-73b4-438f-8fdf-784dbab58150", 6, "SU" },
                    { 7, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4085), "03334448-73b4-438f-8fdf-784dbab58150", 7, "SU" },
                    { 8, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4087), "03334448-73b4-438f-8fdf-784dbab58150", 8, "SU" },
                    { 9, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4089), "03334448-73b4-438f-8fdf-784dbab58150", 9, "SU" },
                    { 10, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4091), "03334448-73b4-438f-8fdf-784dbab58150", 10, "SU" },
                    { 11, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4092), "03334448-73b4-438f-8fdf-784dbab58150", 11, "SU" },
                    { 12, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(4094), "03334448-73b4-438f-8fdf-784dbab58150", 12, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 9, "Index", true, "AgregarRol", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2735), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Agregar", 7 },
                    { 10, "Index", true, "EditarRol", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2738), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Editar", 8 },
                    { 11, "Index", true, "EliminarRol", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2740), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Eliminar", 9 },
                    { 12, "Index", true, "AgregarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2743), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Agregar", 10 },
                    { 13, "Index", true, "EditarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2745), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Editar", 11 },
                    { 14, "Index", true, "EliminarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2748), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Eliminar", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 3, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2793), "03334448-73b4-438f-8fdf-784dbab58150", 3, "SU" },
                    { 4, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2823), "03334448-73b4-438f-8fdf-784dbab58150", 4, "SU" },
                    { 6, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2826), "03334448-73b4-438f-8fdf-784dbab58150", 6, "SU" },
                    { 7, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2827), "03334448-73b4-438f-8fdf-784dbab58150", 7, "SU" },
                    { 8, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2829), "03334448-73b4-438f-8fdf-784dbab58150", 8, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 15, "Index", true, "EliminarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2750), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado físico", 12 },
                    { 16, "Index", true, "EliminarUsuario", new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2752), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado lógico", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2830), "03334448-73b4-438f-8fdf-784dbab58150", 9, "SU" },
                    { 10, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2832), "03334448-73b4-438f-8fdf-784dbab58150", 10, "SU" },
                    { 11, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2833), "03334448-73b4-438f-8fdf-784dbab58150", 11, "SU" },
                    { 12, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2835), "03334448-73b4-438f-8fdf-784dbab58150", 12, "SU" },
                    { 13, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2836), "03334448-73b4-438f-8fdf-784dbab58150", 13, "SU" },
                    { 14, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2838), "03334448-73b4-438f-8fdf-784dbab58150", 14, "SU" },
                    { 15, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2839), "03334448-73b4-438f-8fdf-784dbab58150", 15, "SU" },
                    { 16, true, new DateTime(2024, 7, 16, 15, 45, 38, 747, DateTimeKind.Local).AddTicks(2841), "03334448-73b4-438f-8fdf-784dbab58150", 16, "SU" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adm_MenuElements_MenuElementParentId",
                table: "Adm_MenuElements",
                column: "MenuElementParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_MenuRole_MenuElementId",
                table: "Adm_MenuRole",
                column: "MenuElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_ParametrosSeleccion_CategoriaID",
                table: "Adm_ParametrosSeleccion",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_ReportAdminRole_ReportId",
                table: "Adm_ReportAdminRole",
                column: "ReportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm_MenuRole");

            migrationBuilder.DropTable(
                name: "Adm_ParametrosSeleccion");

            migrationBuilder.DropTable(
                name: "Adm_ReportAdminRole");

            migrationBuilder.DropTable(
                name: "Adm_MenuElements");

            migrationBuilder.DropTable(
                name: "Adm_ParametroCategoria");

            migrationBuilder.DropTable(
                name: "Adm_ReportAdmin");
        }
    }
}
