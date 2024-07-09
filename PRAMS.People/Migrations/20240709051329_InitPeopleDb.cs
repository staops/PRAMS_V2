using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.People.Migrations
{
    /// <inheritdoc />
    public partial class InitPeopleDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conf_Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeguroSocial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inicial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Etnia = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Escolaridad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LugarNacePueplo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    LugarNaceEstado = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    LugarNacePais = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TelefonoResidencia = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TelefonoCelular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TelefonoFamiliar = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Discapacidad = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Impedimentos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PretVeterano = table.Column<bool>(type: "bit", nullable: false),
                    GradAcademico = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Merged = table.Column<bool>(type: "bit", nullable: false),
                    MergedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MergedUser = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    MergedPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conf_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Conf_Personas_Direcciones",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TipoDireccion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Direccion2 = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conf_Personas_Direcciones", x => x.DireccionId);
                    table.ForeignKey(
                        name: "FK_Conf_Personas_Direcciones_Conf_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Conf_Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conf_Personas_Ingresos",
                columns: table => new
                {
                    PersonaIngresoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IngresoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Retencion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aportacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conf_Personas_Ingresos", x => x.PersonaIngresoId);
                    table.ForeignKey(
                        name: "FK_Conf_Personas_Ingresos_Conf_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Conf_Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conf_Personas_Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    RMO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TipoLink = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Relacion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ViveEnElHogar = table.Column<bool>(type: "bit", nullable: false),
                    JefeDeFamilia = table.Column<bool>(type: "bit", nullable: false),
                    EstadoEmpleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pensionado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conf_Personas_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Conf_Personas_Links_Conf_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Conf_Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conf_Personas_Ingresos_Detalle",
                columns: table => new
                {
                    PersonaIngresoDetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaIngresoId = table.Column<int>(type: "int", nullable: false),
                    TipoIngreso = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Ingresos = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conf_Personas_Ingresos_Detalle", x => x.PersonaIngresoDetalleId);
                    table.ForeignKey(
                        name: "FK_Conf_Personas_Ingresos_Detalle_Conf_Personas_Ingresos_PersonaIngresoId",
                        column: x => x.PersonaIngresoId,
                        principalTable: "Conf_Personas_Ingresos",
                        principalColumn: "PersonaIngresoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conf_Personas_Direcciones_PersonaId",
                table: "Conf_Personas_Direcciones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conf_Personas_Ingresos_PersonaId",
                table: "Conf_Personas_Ingresos",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conf_Personas_Ingresos_Detalle_PersonaIngresoId",
                table: "Conf_Personas_Ingresos_Detalle",
                column: "PersonaIngresoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conf_Personas_Links_PersonaId",
                table: "Conf_Personas_Links",
                column: "PersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conf_Personas_Direcciones");

            migrationBuilder.DropTable(
                name: "Conf_Personas_Ingresos_Detalle");

            migrationBuilder.DropTable(
                name: "Conf_Personas_Links");

            migrationBuilder.DropTable(
                name: "Conf_Personas_Ingresos");

            migrationBuilder.DropTable(
                name: "Conf_Personas");
        }
    }
}
