﻿using System;
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
                name: "Adm_FlujoFormularioNotas",
                columns: table => new
                {
                    FormularioNotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioId = table.Column<int>(type: "int", nullable: false),
                    TX_NombreNota = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TX_Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TX_Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TX_Mensaje = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ID_TipoUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujoFormularioNotas", x => x.FormularioNotaId);
                });

            migrationBuilder.CreateTable(
                name: "Adm_FlujosFormularios",
                columns: table => new
                {
                    ID_Formulario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCaso = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Formulario = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TablaBase = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrdenFormulario = table.Column<int>(type: "int", nullable: false),
                    NivelCaso = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TX_Filtro1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TX_Filtro2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TX_Filtro3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujosFormularios", x => x.ID_Formulario);
                });

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
                name: "Form_Referidos",
                columns: table => new
                {
                    ID_Referido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RMO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ID_Caso = table.Column<int>(type: "int", nullable: true),
                    TipoReferido = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    FechaRecibo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoraRecibo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Accion_Tomada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NarrativaSituacion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ReferidoPor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    RelacionAdulto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ServicioSolicitado = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Servicio_FechaNotificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Antecedentes = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Determinacion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Determinacion_Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Determinacion_Razon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AsignacionRegion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    AsignacionOficina = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Clasificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrigenReferido = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    AsignacionReferido = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ID_Agencia = table.Column<int>(type: "int", nullable: true),
                    Agencia_SolicitadoPara = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Agencia_Solicitud = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_Supervisor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Fecha_Supervision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_ReferidoOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Referidos", x => x.ID_Referido);
                });

            migrationBuilder.CreateTable(
                name: "Adm_FlujosFormulariosEtapas",
                columns: table => new
                {
                    FormularioEtapaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioId = table.Column<int>(type: "int", nullable: false),
                    NombreEtapa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrdenEtapa = table.Column<int>(type: "int", nullable: false),
                    TipoEtapa = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ColorEtapa = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Completado = table.Column<bool>(type: "bit", nullable: false),
                    Concurrencia = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrenciaEtapa = table.Column<int>(type: "int", nullable: true),
                    NotaStartId = table.Column<int>(type: "int", nullable: true),
                    NotaEndId = table.Column<int>(type: "int", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujosFormulariosEtapas", x => x.FormularioEtapaId);
                    table.ForeignKey(
                        name: "FK_AdmFlujoFormularioNotaEnd",
                        column: x => x.NotaEndId,
                        principalTable: "Adm_FlujoFormularioNotas",
                        principalColumn: "FormularioNotaId");
                    table.ForeignKey(
                        name: "FK_AdmFlujoFormularioNotaStart",
                        column: x => x.NotaStartId,
                        principalTable: "Adm_FlujoFormularioNotas",
                        principalColumn: "FormularioNotaId");
                    table.ForeignKey(
                        name: "FK_Adm_FlujosFormulariosEtapas_Adm_FlujosFormularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Adm_FlujosFormularios",
                        principalColumn: "ID_Formulario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Form_FlujosPantallas",
                columns: table => new
                {
                    ID_FORM_FlujoPantalla = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Formulario = table.Column<int>(type: "int", nullable: false),
                    ID_Forma = table.Column<int>(type: "int", nullable: false),
                    OrdenEtapa = table.Column<int>(type: "int", nullable: false),
                    FlujoEtapa = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Fecha_Flujo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_User_Flujo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RMO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Numero_Caso = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Persona = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ID_User_Asigna = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ID_User_Asignado = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Flujo_Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comentarios = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    EtapaCompletada = table.Column<bool>(type: "bit", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Local = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_FlujosPantallas", x => x.ID_FORM_FlujoPantalla);
                    table.ForeignKey(
                        name: "FK_Form_FlujosPantallas_Adm_FlujosFormularios_ID_Formulario",
                        column: x => x.ID_Formulario,
                        principalTable: "Adm_FlujosFormularios",
                        principalColumn: "ID_Formulario",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Adm_FlujoPantallaUser",
                columns: table => new
                {
                    FlujoUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioEtapaId = table.Column<int>(type: "int", nullable: false),
                    Prioridad = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    GroupTypeId = table.Column<int>(type: "int", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujoPantallaUser", x => x.FlujoUserID);
                    table.ForeignKey(
                        name: "FK_Adm_FlujoPantallaUser_Adm_FlujosFormulariosEtapas_FormularioEtapaId",
                        column: x => x.FormularioEtapaId,
                        principalTable: "Adm_FlujosFormulariosEtapas",
                        principalColumn: "FormularioEtapaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adm_FlujosFormulariosEtapasAcciones",
                columns: table => new
                {
                    FormularioEtapaAccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioEtapaId = table.Column<int>(type: "int", nullable: false),
                    NombreAccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrdenAccion = table.Column<int>(type: "int", nullable: false),
                    TipoAccion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TipoProceso = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Completado = table.Column<bool>(type: "bit", nullable: false),
                    Concurrencia = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrenciaAccionId = table.Column<int>(type: "int", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujosFormulariosEtapasAcciones", x => x.FormularioEtapaAccionId);
                    table.ForeignKey(
                        name: "FK_Adm_FlujosFormulariosEtapasAcciones_Adm_FlujosFormulariosEtapas_FormularioEtapaId",
                        column: x => x.FormularioEtapaId,
                        principalTable: "Adm_FlujosFormulariosEtapas",
                        principalColumn: "FormularioEtapaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Form_FormulariosFirmas",
                columns: table => new
                {
                    ID_FormularioFirmas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Formulario = table.Column<int>(type: "int", nullable: false),
                    ID_FormularioEtapa = table.Column<int>(type: "int", nullable: false),
                    ID_Forma = table.Column<int>(type: "int", nullable: true),
                    RMO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Num_Caso = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ID_Usuario = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UserTypeID = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FechaFirma = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Local = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Comentarios = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Revertida = table.Column<bool>(type: "bit", nullable: false),
                    RevertidaFecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_Usuario_Revierte = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AdmFlujoFormularioFormularioId = table.Column<int>(type: "int", nullable: true),
                    ID_FormularioEtapa1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_FormulariosFirmas", x => x.ID_FormularioFirmas);
                    table.ForeignKey(
                        name: "FK_FormFormularioFirma",
                        column: x => x.ID_FormularioEtapa,
                        principalTable: "Adm_FlujosFormulariosEtapas",
                        principalColumn: "FormularioEtapaId");
                    table.ForeignKey(
                        name: "FK_Form_FormulariosFirmas_Adm_FlujosFormularios_AdmFlujoFormularioFormularioId",
                        column: x => x.AdmFlujoFormularioFormularioId,
                        principalTable: "Adm_FlujosFormularios",
                        principalColumn: "ID_Formulario");
                });

            migrationBuilder.CreateTable(
                name: "Adm_FlujosFormulariosEtapasAccionesCampos",
                columns: table => new
                {
                    FormularioEtapaAccionCampoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularioEtapaAccionId = table.Column<int>(type: "int", nullable: false),
                    OrdenAccion = table.Column<int>(type: "int", nullable: false),
                    CampoDB = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TablaBase = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CampoDBTipo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CampoDBLongitud = table.Column<int>(type: "int", nullable: false),
                    CampoDB_IDField = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TipoProcesoCampo = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_FlujosFormulariosEtapasAccionesCampos", x => x.FormularioEtapaAccionCampoId);
                    table.ForeignKey(
                        name: "FK_Adm_FlujosFormulariosEtapasAccionesCampos_Adm_FlujosFormulariosEtapasAcciones_FormularioEtapaAccionId",
                        column: x => x.FormularioEtapaAccionId,
                        principalTable: "Adm_FlujosFormulariosEtapasAcciones",
                        principalColumn: "FormularioEtapaAccionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adm_FlujoFormularioNotas",
                columns: new[] { "FormularioNotaId", "FormularioId", "TX_Descripcion", "TX_Mensaje", "TX_NombreNota", "TX_Subject", "ID_TipoUsuario" },
                values: new object[] { 1, 1, "Aviso Supervisor Firma Completada por Trabajador Social", "Mensaje Atado con Datos del Referido segun ID del Formulario", "Aviso Supervisor", "Para el Formulario de Referido se completo la firma de Trabajador Social", 14 });

            migrationBuilder.InsertData(
                table: "Adm_FlujosFormularios",
                columns: new[] { "ID_Formulario", "Descripcion", "Formulario", "NivelCaso", "OrdenFormulario", "TX_Filtro1", "TX_Filtro2", "TX_Filtro3", "TablaBase", "TipoCaso" },
                values: new object[,]
                {
                    { 1, null, "Referido Orientación", "Referido", 1, "Orientación de Clientes", null, null, "Form_Referidos", "Orientación" },
                    { 2, null, "Referido Orientación y Referimiento", "Orientación", 2, "Orientació y Referimiento de Clientes", null, null, "Form_Referidos", "Orientación y Referimiento" },
                    { 3, null, "Referido de Protección", "Referido", 1, "Evaluacion de Protección Social", null, null, "Form_Referidos", "Protección" },
                    { 4, null, "Estudio Social", "Protección", 2, "Servicio de Protección Estudio Social", null, null, "Form_Estudio_Social", "Servicios Proteccion" },
                    { 5, null, "Notas de Progreso", "Protección", 3, null, null, null, "Form_Notas_Progreso", "Servicios Proteccion" },
                    { 6, null, "Visitas al Hogar", "Protección", 3, null, null, null, "Form_Visita_Hogar", "Servicios Proteccion" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 1, "Index", true, "Home", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2061), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-home", null, "Home", 1 },
                    { 2, "Index", true, "SystemConfiguration", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2064), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "System Configuration", 2 },
                    { 5, "Index", true, "Ajustes", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2073), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Ajustes", 3 },
                    { 17, "Index", true, "EliminarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2108), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Borrado lógico", 12 },
                    { 18, "Index", false, "EliminarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2111), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", null, "Elmento eliminado", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_ParametroCategoria",
                columns: new[] { "CategoriaID", "Activo", "Categoria", "CreateDate", "CreateUser", "Descripcion", "ModifiedDate", "ModifiedUser", "TX_Filtro1_Nombre", "TX_Filtro2_Nombre", "TX_Filtro3_Nombre", "TX_Filtro4_Nombre", "TX_Filtro5_Nombre", "TX_Filtro6_Nombre", "TX_Filtro7_Nombre", "TX_Filtro8_Nombre", "TX_Filtro9_Nombre" },
                values: new object[,]
                {
                    { 1, true, "Clasificacion Empleados", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(78), "03334448-73b4-438f-8fdf-784dbab58150", "Clasificaciones", null, null, null, null, null, null, null, null, null, null, null },
                    { 2, true, "Curso Aprobado", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(83), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 4, true, "Tipo Impedimento", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(85), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 5, true, "Tipo Nombramiento", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(87), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 6, true, "Pueblos", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(88), "03334448-73b4-438f-8fdf-784dbab58150", "Def Pueblos con Dos Niveles de Filtros", null, null, "Estado", "Pais", null, null, null, null, null, null, null },
                    { 7, true, "Categoria Licencias", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(92), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 8, true, "Firmas", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(93), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, "Posición / Puesto", null, null, null, null, null, null, null, null },
                    { 9, true, "Acciones", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(95), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 10, true, "Genero", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(96), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 11, true, "Region", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(99), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 12, true, "Tipo Convocatoria", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(100), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 13, true, "Dependencias", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(102), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, null, null, null, null, null, null, null },
                    { 16, true, "Entidades Municipio", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(103), "03334448-73b4-438f-8fdf-784dbab58150", "Def Municipios Tres Niveles Ejemplo", null, null, "Region", "Estado", "Pais", null, null, null, null, null, null },
                    { 17, true, "Cantidad Solicitudes", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(105), "03334448-73b4-438f-8fdf-784dbab58150", "Numero de Solicitudes realizadas 2Segunda, etc.", null, null, null, null, null, null, null, null, null, null, null },
                    { 19, true, "Grados Academicos", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(106), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Grados Academicos", null, null, null, null, null, null, null, null, null, null, null },
                    { 20, true, "Tipo de Documentos", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(107), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Documentos para Cargas", null, null, null, null, null, null, null, null, null, null, null },
                    { 21, true, "Tipo Reportes", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(109), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Reportes para Tablas de Reportes Admin", null, null, null, null, null, null, null, null, null, null, null },
                    { 22, true, "RolesReportes", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(111), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Roles para Reportes", null, null, null, null, null, null, null, null, null, null, null },
                    { 23, true, "RolesMenu", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(112), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Roles para Menu Asignacion Roles", null, null, null, null, null, null, null, null, null, null, null },
                    { 24, true, "TipoCasos", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(114), "03334448-73b4-438f-8fdf-784dbab58150", "Tipo de Casos Flujos", null, null, "Formulario", "Nivel de Caso", null, null, null, null, null, null, null },
                    { 25, true, "TipoEtapa", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(115), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Etapas de Formularios", null, null, null, null, null, null, null, null, null, null, null },
                    { 26, true, "TipoAcciones", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(116), "03334448-73b4-438f-8fdf-784dbab58150", "Etapas de FLujo Acciones de Validadiones", null, null, null, null, null, null, null, null, null, null, null },
                    { 27, true, "TipoProceso", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(118), "03334448-73b4-438f-8fdf-784dbab58150", "Etapas Flujo Acciones Tipo de Proceso", null, null, null, null, null, null, null, null, null, null, null },
                    { 28, true, "CampoDBTipo", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(119), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Campos DB para Validaciones", null, null, null, null, null, null, null, null, null, null, null },
                    { 29, true, "TipoProcesoCampo", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(120), "03334448-73b4-438f-8fdf-784dbab58150", "Como se procesan las Acciones Campo de Validaciones", null, null, null, null, null, null, null, null, null, null, null },
                    { 30, true, "TipoUsuarios", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(122), "03334448-73b4-438f-8fdf-784dbab58150", "Tipo de Usuarios Sistema", null, null, "Rol ID", null, null, null, null, null, null, null, null },
                    { 31, true, "TipoPersonas", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(153), "03334448-73b4-438f-8fdf-784dbab58150", "Para Pantallas de Personas Link", null, null, null, null, null, null, null, null, null, null, null },
                    { 32, true, "Relaciones", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(155), "03334448-73b4-438f-8fdf-784dbab58150", "Para Pantalla de Personas Link Relacion", null, null, null, null, null, null, null, null, null, null, null },
                    { 33, true, "ServiciosSolicitados", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(157), "03334448-73b4-438f-8fdf-784dbab58150", "Servicios para los Referidos", null, null, "Tipo de Servicio", null, null, null, null, null, null, null, null },
                    { 34, true, "DeterminacionReferido", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(158), "03334448-73b4-438f-8fdf-784dbab58150", "Determinaciones de los Referidos", null, null, "Proxima Etapa", null, null, null, null, null, null, null, null },
                    { 35, true, "Antecedentes", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(159), "03334448-73b4-438f-8fdf-784dbab58150", "Antecedentes para los Referidos", null, null, null, null, null, null, null, null, null, null, null },
                    { 36, true, "ClasificacionReferido", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(161), "03334448-73b4-438f-8fdf-784dbab58150", "Nivel de prioridad del Referido", null, null, null, null, null, null, null, null, null, null, null },
                    { 37, true, "AsignacionLocalización", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(162), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, "Oficina / Local", "Num Local", "Num Region", null, null, null, null, null, null },
                    { 38, true, "AgenciaSolicitadoPara", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(165), "03334448-73b4-438f-8fdf-784dbab58150", "Para los Tipos de Solicitud de Agencia", null, null, null, null, null, null, null, null, null, null, null },
                    { 39, true, "OrigenReferido", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(166), "03334448-73b4-438f-8fdf-784dbab58150", "Referido Campo OrigenReferido", null, null, null, null, null, null, null, null, null, null, null },
                    { 40, true, "TipoAgencia", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(168), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Agencias ConfAgencias", null, null, null, null, null, null, null, null, null, null, null },
                    { 41, true, "LugarEntrevista", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(169), "03334448-73b4-438f-8fdf-784dbab58150", "Lugar de la Entrevista para Formulario de Entrevista Inicial", null, null, null, null, null, null, null, null, null, null, null },
                    { 42, true, "AntecedentesDependencias", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(170), "03334448-73b4-438f-8fdf-784dbab58150", "Dependencia", null, null, "Programa", null, null, null, null, null, null, null, null },
                    { 43, true, "GrupoBeneficio", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(172), "03334448-73b4-438f-8fdf-784dbab58150", "Estudio Inicial Grupo Beneficios", null, null, null, null, null, null, null, null, null, null, null },
                    { 44, true, "GrupoCategoria", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(173), "03334448-73b4-438f-8fdf-784dbab58150", "Tipos de Agencias ConfAgencias", null, null, null, null, null, null, null, null, null, null, null },
                    { 45, true, "RecomendacionEstudio", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(174), "03334448-73b4-438f-8fdf-784dbab58150", "Recoomendaciones del Estudio Iniicial", null, null, null, null, null, null, null, null, null, null, null },
                    { 46, true, "PlandeSalud", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(176), "03334448-73b4-438f-8fdf-784dbab58150", "Plan", null, null, null, null, null, null, null, null, null, null, null },
                    { 47, true, "TipoPlanSalud", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(177), "03334448-73b4-438f-8fdf-784dbab58150", "TipoPlanSalud", null, null, null, null, null, null, null, null, null, null, null },
                    { 48, true, "PlanMedico", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(178), "03334448-73b4-438f-8fdf-784dbab58150", "PlanMedico", null, null, null, null, null, null, null, null, null, null, null },
                    { 49, true, "Locales", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(180), "03334448-73b4-438f-8fdf-784dbab58150", "Recoomendaciones del Estudio Iniicial", null, null, null, null, null, null, null, null, null, null, null },
                    { 51, true, "EstadoEmpleo", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(181), "03334448-73b4-438f-8fdf-784dbab58150", "Para Referidos", null, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Adm_ReportAdmin",
                columns: new[] { "ReportId", "Activo", "CreateDate", "CreateUser", "Orden", "ReportDescription", "ReportLink", "ReportName", "ReportParameters", "ReportType" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2214), "03334448-73b4-438f-8fdf-784dbab58150", 1, "Lista los RMS Pendientes Diariamente, selección por Fecha y agrupado por Región", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_GeneradosDiarios", "Listado de RMS Generados Diarios (por Región)", "Fecha", "Región" },
                    { 2, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2218), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Lista los RMS Completados por los Empleados por rango de fecha y por Región (Todos los Contestados)", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRange", "RMS Completados por Empleados rango de Fechas y por Región", "Fechas", "Región" },
                    { 3, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2221), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Lista los RMS Completados Validos por los Empleados por rango de fecha y por Región (Solo Validos)", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRangeValid", "RMS Completados por Fechas, Región y que son Validos", "Fechas, Region", "Región" },
                    { 4, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2251), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Reporte de RMS Completados Validos para reclamos, incluye Numero de RMS para uso en las Asistencias de los Empleados para los RMS Contestados.", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_ValidAssistance", "Reporte de RMS Validos Completados Listado para Asistencias de Empleados", "Fecha, Region", "Finanzas" },
                    { 5, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2254), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Resumen de los RMS enviados, completados, invalidos, seguimientos y validos con porcientos de completados", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRms_Statdistics_DateRangeRegion", "RMS Resumen Estadisticas Envíos por Rango Fecha y Región", "Fecha y Region", "Administración" },
                    { 6, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2257), "03334448-73b4-438f-8fdf-784dbab58150", 1, "Muestra el Formulario RMS según llenado por los Trabajadores Sociales", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_WorkDetailRange", "Formulario RMS llenados por Fecha ", "Fecha", "Administración" },
                    { 7, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2259), "03334448-73b4-438f-8fdf-784dbab58150", 4, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Diarios", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationDaily", "Cost Allocation Plan Reporte Diario", "Fecha", "Finanzas" },
                    { 8, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2262), "03334448-73b4-438f-8fdf-784dbab58150", 5, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant para el Mes seleccionado.", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationMonthly", "Cost Allocation Plan Reporte Mensual", "Fecha", "Finanzas" },
                    { 9, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2264), "03334448-73b4-438f-8fdf-784dbab58150", 7, "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Trimestrales", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationQuarter", "Cost Allocation Plan Reporte Trimestral", "Fecha", "Finanzas" },
                    { 10, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2268), "03334448-73b4-438f-8fdf-784dbab58150", 3, "Este Reporte muestra todas las Observaciones entradas por los usuarios en un rango de fechas con sus respectivos Títulos y Grants por rango de Fecha y selección de Validos o Invalidos para el CAP", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Submitted_DateRange", "Observaciones Completadas por Rango de Fecha (Selección Validas)", "Fechas", "Administración" },
                    { 11, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2270), "03334448-73b4-438f-8fdf-784dbab58150", 1, "RMS Matrix Distribution Report for the CAP Titile Distribution", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_Matrix", "RMS Matrix", "Fechas", "Finanzas" },
                    { 12, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2273), "03334448-73b4-438f-8fdf-784dbab58150", 2, "Listado de RMS Validos para completar el Schedule D del CAP", "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_ScheduleD", "Schedule D Listado RMS", "Fechas", "Finanzas" }
                });

            migrationBuilder.InsertData(
                table: "Form_Referidos",
                columns: new[] { "ID_Referido", "Accion_Tomada", "Activo", "ID_Agencia", "Agencia_SolicitadoPara", "Agencia_Solicitud", "Antecedentes", "AsignacionOficina", "AsignacionReferido", "AsignacionRegion", "ID_Caso", "Clasificacion", "CreateDate", "CreateUser", "Determinacion", "Determinacion_Fecha", "Determinacion_Razon", "FechaRecibo", "Fecha_Supervision", "HoraRecibo", "ModifiedDate", "ModifiedUser", "NarrativaSituacion", "OrigenReferido", "RMO", "ID_ReferidoOrigen", "ReferidoPor", "RelacionAdulto", "Servicio_FechaNotificacion", "ServicioSolicitado", "ID_Supervisor", "TipoReferido" },
                values: new object[,]
                {
                    { 1, null, true, null, null, "Esta solicitud es para referir al Fondo el beneficiario", null, "Aguadilla I", null, "Aguadilla", null, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3629), "03334448-73b4-438f-8fdf-784dbab58150", "Coordinar Servicios", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3579), "Determinacion para Orientacion", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3578), null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3579), null, null, "Narrativa de Caso de Orientacion por el TS", null, "03-0301-0001", null, "03334448-73b4-438f-8fdf-784dbab58150", "Madre", null, null, null, "Orientación" },
                    { 2, null, true, 1, "El Adulto", "Esta solicitud es para referir al Fondo el beneficiario", null, "Bayamon ", null, "Bayamon", null, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3671), "03334448-73b4-438f-8fdf-784dbab58150", "Referido", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3594), "Determinacion para Referir a Agencia", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3593), null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3593), null, null, "Narrativa de Caso de Orientacion por el TS y Supervisro", null, "03-0301-0002", null, "03334448-73b4-438f-8fdf-784dbab58150", "Padre", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3594), "Visitas Medica", null, "Orientación y Referimiento" },
                    { 3, null, true, null, null, null, "Sin Antecedentes", "Bayamon ", "Personal Administrativo", "Bayamon", null, "Urgente", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3675), "03334448-73b4-438f-8fdf-784dbab58150", "Aceptado", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3598), "Determinacion para Referir a Agencia", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3597), null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3597), null, null, "Narrativa de Caso de Proteccion", "CAMPEA Aguas Buenas", "03-0301-0003", null, "03334448-73b4-438f-8fdf-784dbab58150", "Padre", null, null, null, "Protección" },
                    { 4, null, true, null, null, null, null, "Aguadilla I", null, "Aguadilla", null, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3678), "03334448-73b4-438f-8fdf-784dbab58150", "Coordinar Servicios", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3601), "Determinacion para Orientacion", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3600), null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3601), null, null, "Narrativa de Caso de Orientacion por el TS", null, "03-0301-0004", null, "03334448-73b4-438f-8fdf-784dbab58150", "Abuelo", null, null, null, "Orientación" }
                });

            migrationBuilder.InsertData(
                table: "Adm_FlujosFormulariosEtapas",
                columns: new[] { "FormularioEtapaId", "Activo", "ColorEtapa", "Completado", "Concurrencia", "ConcurrenciaEtapa", "CreateDate", "CreateUser", "FormularioId", "ModifiedDate", "ModifiedUser", "NombreEtapa", "NotaEndId", "NotaStartId", "OrdenEtapa", "TipoEtapa" },
                values: new object[,]
                {
                    { 1, true, "#f7f72f", false, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3212), "03334448-73b4-438f-8fdf-784dbab58150", 1, null, null, "Referido Nuevo", null, null, 1, "Comienzo Formulario" },
                    { 2, true, "#3c7efa", false, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3216), "03334448-73b4-438f-8fdf-784dbab58150", 1, null, null, "Referido Seguimiento", null, null, 2, "Seguimiento Formulario" },
                    { 3, true, "#8c57f7", false, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3218), "03334448-73b4-438f-8fdf-784dbab58150", 1, null, null, "Referido Firma TS", 1, null, 3, "Seguimiento Formulario" },
                    { 4, true, null, false, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3220), "03334448-73b4-438f-8fdf-784dbab58150", 1, null, null, "Referido Firma Sup", null, null, 4, "Completar Formulario" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 3, "Index", true, "Parametros", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2067), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Parametros", 1 },
                    { 4, "Index", true, "Categorias", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2070), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 2, "Categorias", 2 },
                    { 6, "Index", true, "Roles", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2075), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Roles", 4 },
                    { 7, "Index", true, "Usuarios", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2078), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Usuarios", 5 },
                    { 8, "Index", true, "Otro", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2081), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 5, "Otro", 6 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2144), "03334448-73b4-438f-8fdf-784dbab58150", 1, "SU" },
                    { 2, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2147), "03334448-73b4-438f-8fdf-784dbab58150", 2, "SU" },
                    { 5, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2152), "03334448-73b4-438f-8fdf-784dbab58150", 5, "SU" },
                    { 17, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2174), "03334448-73b4-438f-8fdf-784dbab58150", 17, "SU" },
                    { 18, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2176), "03334448-73b4-438f-8fdf-784dbab58150", 18, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Adm_ParametrosSeleccion",
                columns: new[] { "ParamterosID", "Activo", "CategoriaID", "CreateDate", "CreateUser", "Descripcion", "FechaEnd", "FechaStart", "ModifiedDate", "ModifiedUser", "Parametro", "TX_Filtro1", "TX_Filtro2", "TX_Filtro3", "TX_Filtro4", "TX_Filtro5", "TX_Filtro6", "TX_Filtro7", "TX_Filtro8", "TX_Filtro9" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(912), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Abogado", null, null, null, null, null, null, null, null, null },
                    { 2, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(915), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Abogado Principal", null, null, null, null, null, null, null, null, null },
                    { 3, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(917), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Abogado Senior", null, null, null, null, null, null, null, null, null },
                    { 4, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(919), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Administrador de Bases de Datos", null, null, null, null, null, null, null, null, null },
                    { 5, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(920), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Administrador de Sistemas de Oficina I", null, null, null, null, null, null, null, null, null },
                    { 6, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(922), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Administrador de Sistemas de Oficina II", null, null, null, null, null, null, null, null, null },
                    { 7, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(924), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Administrador de Sistemas de Oficina III", null, null, null, null, null, null, null, null, null },
                    { 8, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(925), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Agente Comprador", null, null, null, null, null, null, null, null, null },
                    { 9, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(926), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista de Presupuesto", null, null, null, null, null, null, null, null, null },
                    { 10, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(929), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Administracion de Recursos Humanos", null, null, null, null, null, null, null, null, null },
                    { 11, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(930), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Administracion de Recursos Humanos Senior", null, null, null, null, null, null, null, null, null },
                    { 12, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(932), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Administracion de Recursos Humanos y Relaciones Laborales", null, null, null, null, null, null, null, null, null },
                    { 13, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(933), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Determinacion de Incapacidad I", null, null, null, null, null, null, null, null, null },
                    { 14, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(934), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Determinacion de Incapacidad II", null, null, null, null, null, null, null, null, null },
                    { 15, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(935), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Determinacion de Incapacidad III", null, null, null, null, null, null, null, null, null },
                    { 16, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(936), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Determinacion de Incapacidad IV", null, null, null, null, null, null, null, null, null },
                    { 17, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(937), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Analista en Relaciones Laborales", null, null, null, null, null, null, null, null, null },
                    { 18, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(939), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Artista Grafico", null, null, null, null, null, null, null, null, null },
                    { 19, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(940), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Asistente de Analistas en Determinacion de Incapacidad", null, null, null, null, null, null, null, null, null },
                    { 20, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(942), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Asistente de Cuidado Diurno", null, null, null, null, null, null, null, null, null },
                    { 21, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(943), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Asistente de Programa Federal", null, null, null, null, null, null, null, null, null },
                    { 22, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(944), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Asistente de Servicios de Alimentos", null, null, null, null, null, null, null, null, null },
                    { 23, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(945), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Asistente de Servicios Sociales", null, null, null, null, null, null, null, null, null },
                    { 24, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(946), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auditor Programatico de Servicios Sociales", null, null, null, null, null, null, null, null, null },
                    { 25, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(983), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar Administrativo", null, null, null, null, null, null, null, null, null },
                    { 26, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(984), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar de Cocina", null, null, null, null, null, null, null, null, null },
                    { 27, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(986), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar de Compras", null, null, null, null, null, null, null, null, null },
                    { 28, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(987), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar en Contabilidad", null, null, null, null, null, null, null, null, null },
                    { 29, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(988), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar en Control de Asistencia", null, null, null, null, null, null, null, null, null },
                    { 30, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(990), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar en Nominas", null, null, null, null, null, null, null, null, null },
                    { 31, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(991), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar en Sistemas de Oficina", null, null, null, null, null, null, null, null, null },
                    { 32, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(993), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar Fiscal", null, null, null, null, null, null, null, null, null },
                    { 33, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(994), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Auxiliar Fiscal Principal", null, null, null, null, null, null, null, null, null },
                    { 34, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(996), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cocinero", null, null, null, null, null, null, null, null, null },
                    { 35, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(997), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Conductor de Vehiculos de Motor Liviano", null, null, null, null, null, null, null, null, null },
                    { 36, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(998), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Conductor de Vehiculos de Motor Pesado", null, null, null, null, null, null, null, null, null },
                    { 37, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(999), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Conserje", null, null, null, null, null, null, null, null, null },
                    { 38, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1000), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Contador", null, null, null, null, null, null, null, null, null },
                    { 39, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1002), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Contador Principal", null, null, null, null, null, null, null, null, null },
                    { 40, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1003), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Contador Senior", null, null, null, null, null, null, null, null, null },
                    { 41, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1004), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador Auxiliar en Cuidado y Desarrollo del Nino", null, null, null, null, null, null, null, null, null },
                    { 42, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1005), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Actividades con Padres de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 43, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1006), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Adiestramientos Programaticos de Servicios Sociales", null, null, null, null, null, null, null, null, null },
                    { 44, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1007), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Educacion de Head Start/Early Head Start ", null, null, null, null, null, null, null, null, null },
                    { 45, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1008), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Nutricion de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 46, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1009), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Salud Medico Dental de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 47, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1010), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador de Salud Mental de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 48, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1012), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador en Cuidado y Desarrollo del Nino", null, null, null, null, null, null, null, null, null },
                    { 49, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1013), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador Interagencial", null, null, null, null, null, null, null, null, null },
                    { 50, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1014), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinador para Asuntos de Retiro", null, null, null, null, null, null, null, null, null },
                    { 51, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1015), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Administrativo", null, null, null, null, null, null, null, null, null },
                    { 52, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1016), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Asociado de Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 53, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1017), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Asociado de Servicios Sociales a las Familias y las Comunidades", null, null, null, null, null, null, null, null, null },
                    { 54, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1018), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Asociado de Sustento de Menores", null, null, null, null, null, null, null, null, null },
                    { 55, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1019), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Auxiliar", null, null, null, null, null, null, null, null, null },
                    { 56, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1020), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Auxiliar del Programa de Determinacion de Incapacidad", null, null, null, null, null, null, null, null, null },
                    { 57, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1022), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director Auxiliar en Planificacion", null, null, null, null, null, null, null, null, null },
                    { 58, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1023), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Adiestramiento", null, null, null, null, null, null, null, null, null },
                    { 59, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1024), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Centro de Cuidado Diurno", null, null, null, null, null, null, null, null, null },
                    { 60, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1025), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Centro de Servicios Integrados", null, null, null, null, null, null, null, null, null },
                    { 61, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1026), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Finanzas", null, null, null, null, null, null, null, null, null },
                    { 62, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1027), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Hogar o Centro de Servicios", null, null, null, null, null, null, null, null, null },
                    { 63, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1065), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Monitoria Programatica de Sustento de Menores", null, null, null, null, null, null, null, null, null },
                    { 64, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1066), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Presupuesto", null, null, null, null, null, null, null, null, null },
                    { 65, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1068), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Programa de Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 66, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1070), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Servicios Auxiliares", null, null, null, null, null, null, null, null, null },
                    { 67, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1071), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director de Sistemas y Procedimientos", null, null, null, null, null, null, null, null, null },
                    { 68, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1072), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director del Programa Child Care", null, null, null, null, null, null, null, null, null },
                    { 69, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1073), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director del Programa Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 70, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1074), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Director del Registro Central de Sustento de Menores", null, null, null, null, null, null, null, null, null },
                    { 71, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1075), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Economista del Hogar", null, null, null, null, null, null, null, null, null },
                    { 72, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1077), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Encargado Auxiliar de la Propiedad", null, null, null, null, null, null, null, null, null },
                    { 73, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1078), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Encargado de la Propiedad", null, null, null, null, null, null, null, null, null },
                    { 74, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1079), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Enfermero Generalista", null, null, null, null, null, null, null, null, null },
                    { 75, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1080), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Enfermero Generalista II", null, null, null, null, null, null, null, null, null },
                    { 76, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1081), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Enfermero Practico Licenciado", null, null, null, null, null, null, null, null, null },
                    { 77, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1082), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 78, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1083), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Determinacion de Incapacidad", null, null, null, null, null, null, null, null, null },
                    { 79, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1084), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Evaluacion", null, null, null, null, null, null, null, null, null },
                    { 80, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1085), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Pensiones Alimentarias", null, null, null, null, null, null, null, null, null },
                    { 81, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1087), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Pensiones Alimentarias Principal", null, null, null, null, null, null, null, null, null },
                    { 82, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1088), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Pensiones Alimentarias Senior", null, null, null, null, null, null, null, null, null },
                    { 83, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1089), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Especialista en Servicios Sociales a las Familias y las Comunidades", null, null, null, null, null, null, null, null, null },
                    { 84, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1090), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Estadistico", null, null, null, null, null, null, null, null, null },
                    { 85, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1091), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Funcionario Administrativo", null, null, null, null, null, null, null, null, null },
                    { 86, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1092), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Gerente Auxiliar de Sistemas de Informacion", null, null, null, null, null, null, null, null, null },
                    { 87, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1093), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Gerente de Monitoreo", null, null, null, null, null, null, null, null, null },
                    { 88, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1094), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Gerente de Sistemas de Informacion", null, null, null, null, null, null, null, null, null },
                    { 89, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1095), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guardalmacen", null, null, null, null, null, null, null, null, null },
                    { 90, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1097), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Instructor del Programa Head Start", null, null, null, null, null, null, null, null, null },
                    { 91, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1098), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Investigador de Querellas Administrativas de Servicios Sociales", null, null, null, null, null, null, null, null, null },
                    { 92, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1099), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Lider Recreativo", null, null, null, null, null, null, null, null, null },
                    { 93, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1100), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Mensajero", null, null, null, null, null, null, null, null, null },
                    { 94, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1101), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Monitor Programatico de Sustento de Menores", null, null, null, null, null, null, null, null, null },
                    { 95, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1102), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Nutricionista", null, null, null, null, null, null, null, null, null },
                    { 96, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1103), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Administrativo", null, null, null, null, null, null, null, null, null },
                    { 97, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1104), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Administrativo Principal", null, null, null, null, null, null, null, null, null },
                    { 98, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1105), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Administrativo Senior", null, null, null, null, null, null, null, null, null },
                    { 99, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1134), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Asistencia y Licencias", null, null, null, null, null, null, null, null, null },
                    { 100, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1136), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Comunicaciones", null, null, null, null, null, null, null, null, null },
                    { 101, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1137), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Cuentas a Cobrar", null, null, null, null, null, null, null, null, null },
                    { 102, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1138), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Cuidado Diurno", null, null, null, null, null, null, null, null, null },
                    { 103, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1139), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Licenciamiento", null, null, null, null, null, null, null, null, null },
                    { 104, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1140), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Licenciamiento Senior", null, null, null, null, null, null, null, null, null },
                    { 105, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1141), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Nominas", null, null, null, null, null, null, null, null, null },
                    { 106, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1143), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Pensiones Alimentarias", null, null, null, null, null, null, null, null, null },
                    { 107, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1144), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial de Presupuesto", null, null, null, null, null, null, null, null, null },
                    { 108, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1145), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Ejecutivo", null, null, null, null, null, null, null, null, null },
                    { 109, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1146), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial en Administracion de Recursos Humanos", null, null, null, null, null, null, null, null, null },
                    { 110, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1147), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial en Administracion de Recursos Humanos Principal", null, null, null, null, null, null, null, null, null },
                    { 111, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1148), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial en Relaciones Laborales", null, null, null, null, null, null, null, null, null },
                    { 112, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1149), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Examinador", null, null, null, null, null, null, null, null, null },
                    { 113, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1151), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficial Examinador Licenciado", null, null, null, null, null, null, null, null, null },
                    { 114, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1152), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficinista de Contabilidad", null, null, null, null, null, null, null, null, null },
                    { 115, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1153), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficinista I", null, null, null, null, null, null, null, null, null },
                    { 116, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1154), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficinista II", null, null, null, null, null, null, null, null, null },
                    { 117, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1155), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Operador de Equipo de Procesar Datos", null, null, null, null, null, null, null, null, null },
                    { 118, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1156), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Operador de Maquina Duplicadora", null, null, null, null, null, null, null, null, null },
                    { 119, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1157), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Pagador Auxiliar", null, null, null, null, null, null, null, null, null },
                    { 120, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1158), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Pagador Oficial", null, null, null, null, null, null, null, null, null },
                    { 121, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1159), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Pagador Oficial Principal", null, null, null, null, null, null, null, null, null },
                    { 122, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1161), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Recaudador Auxiliar", null, null, null, null, null, null, null, null, null },
                    { 123, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1162), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Recaudador Oficial", null, null, null, null, null, null, null, null, null },
                    { 124, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1163), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Recepcionista Telefonista", null, null, null, null, null, null, null, null, null },
                    { 125, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1164), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Receptor Auxiliar", null, null, null, null, null, null, null, null, null },
                    { 126, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1165), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Receptor Oficial", null, null, null, null, null, null, null, null, null },
                    { 127, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1166), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Subdirector Administrativo del Programa de Determinacion de Incapacidad", null, null, null, null, null, null, null, null, null },
                    { 128, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1167), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Subdirector del Programa Child Care", null, null, null, null, null, null, null, null, null },
                    { 129, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1168), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Subdirector Regional", null, null, null, null, null, null, null, null, null },
                    { 130, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1197), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor", null, null, null, null, null, null, null, null, null },
                    { 131, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1198), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Actividades con Padres de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 132, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1199), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Actividades Recreativas y Deportivas", null, null, null, null, null, null, null, null, null },
                    { 133, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1201), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 134, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1202), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Asistencia Social y Familiar Principal", null, null, null, null, null, null, null, null, null },
                    { 135, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1203), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Asistencia y Licencias", null, null, null, null, null, null, null, null, null },
                    { 136, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1204), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Asistente de Analistas en Determinacion de Incapacidad", null, null, null, null, null, null, null, null, null },
                    { 137, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1205), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Compras", null, null, null, null, null, null, null, null, null },
                    { 138, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1206), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Conservacion y Mantenimiento", null, null, null, null, null, null, null, null, null },
                    { 139, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1207), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Educacion de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 140, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1209), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Licenciamiento", null, null, null, null, null, null, null, null, null },
                    { 141, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1210), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Nominas", null, null, null, null, null, null, null, null, null },
                    { 142, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1211), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Nutricion de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 143, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1212), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Oficiales de Pensiones Alimentarias", null, null, null, null, null, null, null, null, null },
                    { 144, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1213), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Salud Medico Dental de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 145, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1214), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Salud Mental de Head Start/Early Head Start", null, null, null, null, null, null, null, null, null },
                    { 146, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1215), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Servicios Sociales a las Familias y las Comunidades I", null, null, null, null, null, null, null, null, null },
                    { 147, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1216), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Servicios Sociales a las Familias y las Comunidades II", null, null, null, null, null, null, null, null, null },
                    { 148, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1217), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor de Transportacion", null, null, null, null, null, null, null, null, null },
                    { 149, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1219), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor en Cuidado y Desarrollo del Nino", null, null, null, null, null, null, null, null, null },
                    { 150, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1220), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor en Determinacion de Incapacidad I", null, null, null, null, null, null, null, null, null },
                    { 151, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1221), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor en Determinacion de Incapacidad II", null, null, null, null, null, null, null, null, null },
                    { 152, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1222), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 153, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1223), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Asistencia Social y Familiar Senior", null, null, null, null, null, null, null, null, null },
                    { 154, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1224), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Control de Calidad de Asistencia Social y Familiar", null, null, null, null, null, null, null, null, null },
                    { 155, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1225), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Elegibilidad", null, null, null, null, null, null, null, null, null },
                    { 156, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1226), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Servicios Sociales a las Familias y las Comunidades", null, null, null, null, null, null, null, null, null },
                    { 157, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1228), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico de Servicios Sociales a las Familias y las Comunidades Senior", null, null, null, null, null, null, null, null, null },
                    { 158, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1229), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico en Sistemas de Informacion", null, null, null, null, null, null, null, null, null },
                    { 159, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1230), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tecnico en Sistemas en Oficina", null, null, null, null, null, null, null, null, null },
                    { 160, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1231), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Trabajador de Conservacion", null, null, null, null, null, null, null, null, null },
                    { 161, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1232), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Trabajador de Servicios Generales", null, null, null, null, null, null, null, null, null },
                    { 162, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1233), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Trabajador Social", null, null, null, null, null, null, null, null, null },
                    { 163, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1234), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Trabajador Social Senior", null, null, null, null, null, null, null, null, null },
                    { 164, true, 1, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1235), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Traductor Interprete", null, null, null, null, null, null, null, null, null },
                    { 165, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1237), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "CursoAprobado", null, null, null, null, null, null, null, null, null },
                    { 166, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1238), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Dactilógrafo", null, null, null, null, null, null, null, null, null },
                    { 167, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1239), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "General", null, null, null, null, null, null, null, null, null },
                    { 168, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1240), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficinista", null, null, null, null, null, null, null, null, null },
                    { 169, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1241), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Oficinista de Contabilidad", null, null, null, null, null, null, null, null, null },
                    { 170, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1242), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Otro", null, null, null, null, null, null, null, null, null },
                    { 171, true, 2, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1267), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Secretarial", null, null, null, null, null, null, null, null, null },
                    { 172, true, 4, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1269), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ninguno", null, null, null, null, null, null, null, null, null },
                    { 173, true, 4, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1270), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "No Vidente", null, null, null, null, null, null, null, null, null },
                    { 174, true, 4, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1271), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Otro", null, null, null, null, null, null, null, null, null },
                    { 175, true, 4, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1272), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Sordo", null, null, null, null, null, null, null, null, null },
                    { 176, true, 4, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1273), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Uso de Silla de Rueda", null, null, null, null, null, null, null, null, null },
                    { 177, true, 5, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1275), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Jornada Parcial", null, null, null, null, null, null, null, null, null },
                    { 178, true, 5, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1276), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tiempo Completo", null, null, null, null, null, null, null, null, null },
                    { 179, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1277), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Adjuntas", "PR", "PR", null, null, null, null, null, null, null },
                    { 180, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1278), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguada", "PR", "PR", null, null, null, null, null, null, null },
                    { 181, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1279), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "PR", "PR", null, null, null, null, null, null, null },
                    { 182, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1280), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguas Buenas", "PR", "PR", null, null, null, null, null, null, null },
                    { 183, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1281), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguirre", "PR", "PR", null, null, null, null, null, null, null },
                    { 184, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1282), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aibonito", "PR", "PR", null, null, null, null, null, null, null },
                    { 185, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1283), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Añasco", "PR", "PR", null, null, null, null, null, null, null },
                    { 186, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1285), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "PR", "PR", null, null, null, null, null, null, null },
                    { 187, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1286), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arroyo", "PR", "PR", null, null, null, null, null, null, null },
                    { 188, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1287), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Barceloneta", "PR", "PR", null, null, null, null, null, null, null },
                    { 189, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1288), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Barranquitas", "PR", "PR", null, null, null, null, null, null, null },
                    { 190, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1289), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Bayamón", "PR", "PR", null, null, null, null, null, null, null },
                    { 191, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1290), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cabo Rojo", "PR", "PR", null, null, null, null, null, null, null },
                    { 192, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1291), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Caguas", "PR", "PR", null, null, null, null, null, null, null },
                    { 193, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1292), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Camuy", "PR", "PR", null, null, null, null, null, null, null },
                    { 194, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1293), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Carolina", "PR", "PR", null, null, null, null, null, null, null },
                    { 195, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1295), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cataño", "PR", "PR", null, null, null, null, null, null, null },
                    { 196, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1296), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cayey", "PR", "PR", null, null, null, null, null, null, null },
                    { 197, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1297), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ceiba", "PR", "PR", null, null, null, null, null, null, null },
                    { 198, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1298), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ciales", "PR", "PR", null, null, null, null, null, null, null },
                    { 199, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1299), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cidras", "PR", "PR", null, null, null, null, null, null, null },
                    { 200, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1300), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coamo", "PR", "PR", null, null, null, null, null, null, null },
                    { 201, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1301), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Comerio", "PR", "PR", null, null, null, null, null, null, null },
                    { 202, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1302), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Corozal", "PR", "PR", null, null, null, null, null, null, null },
                    { 203, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1303), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Culebras", "PR", "PR", null, null, null, null, null, null, null },
                    { 204, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1305), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Dorado", "PR", "PR", null, null, null, null, null, null, null },
                    { 205, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1306), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ensenada", "PR", "PR", null, null, null, null, null, null, null },
                    { 206, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1307), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Fajardo", "PR", "PR", null, null, null, null, null, null, null },
                    { 207, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1308), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Florida", "PR", "PR", null, null, null, null, null, null, null },
                    { 208, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1309), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guanica", "PR", "PR", null, null, null, null, null, null, null },
                    { 209, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1310), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guayama", "PR", "PR", null, null, null, null, null, null, null },
                    { 210, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1311), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guayanilla", "PR", "PR", null, null, null, null, null, null, null },
                    { 211, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1312), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guaynabo", "PR", "PR", null, null, null, null, null, null, null },
                    { 212, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1339), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Gurabo", "PR", "PR", null, null, null, null, null, null, null },
                    { 213, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1340), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Hatillo", "PR", "PR", null, null, null, null, null, null, null },
                    { 214, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1341), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Hato Rey", "PR", "PR", null, null, null, null, null, null, null },
                    { 215, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1343), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Hormigueros", "PR", "PR", null, null, null, null, null, null, null },
                    { 216, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1344), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Humacao", "PR", "PR", null, null, null, null, null, null, null },
                    { 217, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1345), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Isabela", "PR", "PR", null, null, null, null, null, null, null },
                    { 218, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1346), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Jayuya", "PR", "PR", null, null, null, null, null, null, null },
                    { 219, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1348), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Juana Diaz", "PR", "PR", null, null, null, null, null, null, null },
                    { 220, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1349), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Juncos", "PR", "PR", null, null, null, null, null, null, null },
                    { 221, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1350), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Lajas", "PR", "PR", null, null, null, null, null, null, null },
                    { 222, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1351), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Lares", "PR", "PR", null, null, null, null, null, null, null },
                    { 223, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1352), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Las Marias", "PR", "PR", null, null, null, null, null, null, null },
                    { 224, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1353), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Las Piedras", "PR", "PR", null, null, null, null, null, null, null },
                    { 225, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1354), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Loíza", "PR", "PR", null, null, null, null, null, null, null },
                    { 226, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1355), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Luquillo", "PR", "PR", null, null, null, null, null, null, null },
                    { 227, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1356), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Manatí", "PR", "PR", null, null, null, null, null, null, null },
                    { 228, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1358), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Maricao", "PR", "PR", null, null, null, null, null, null, null },
                    { 229, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1359), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Maunabo", "PR", "PR", null, null, null, null, null, null, null },
                    { 230, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1360), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Mayaguez", "PR", "PR", null, null, null, null, null, null, null },
                    { 231, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1361), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Moca", "PR", "PR", null, null, null, null, null, null, null },
                    { 232, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1362), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Morovis", "PR", "PR", null, null, null, null, null, null, null },
                    { 233, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1363), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Naguabo", "PR", "PR", null, null, null, null, null, null, null },
                    { 234, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1364), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Naranjito", "PR", "PR", null, null, null, null, null, null, null },
                    { 235, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1365), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Orocovis", "PR", "PR", null, null, null, null, null, null, null },
                    { 236, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1366), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Patillas", "PR", "PR", null, null, null, null, null, null, null },
                    { 237, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1368), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Peñuelas", "PR", "PR", null, null, null, null, null, null, null },
                    { 238, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1369), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ponce", "PR", "PR", null, null, null, null, null, null, null },
                    { 239, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1370), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Puerto Nuevo", "PR", "PR", null, null, null, null, null, null, null },
                    { 240, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1371), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Quebradillas", "PR", "PR", null, null, null, null, null, null, null },
                    { 241, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1372), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Rincón", "PR", "PR", null, null, null, null, null, null, null },
                    { 242, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1373), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Rio Grande", "PR", "PR", null, null, null, null, null, null, null },
                    { 243, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1374), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Rio Piedras", "PR", "PR", null, null, null, null, null, null, null },
                    { 244, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1375), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Sabana Grande", "PR", "PR", null, null, null, null, null, null, null },
                    { 245, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1376), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Salinas", "PR", "PR", null, null, null, null, null, null, null },
                    { 246, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1378), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Germán", "PR", "PR", null, null, null, null, null, null, null },
                    { 247, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1379), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Juan", "PR", "PR", null, null, null, null, null, null, null },
                    { 248, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1380), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Lorenzo", "PR", "PR", null, null, null, null, null, null, null },
                    { 249, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1381), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Sebastián", "PR", "PR", null, null, null, null, null, null, null },
                    { 250, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1382), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Santa Isabel", "PR", "PR", null, null, null, null, null, null, null },
                    { 251, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1383), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Santurce", "PR", "PR", null, null, null, null, null, null, null },
                    { 252, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1384), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Toa Alta", "PR", "PR", null, null, null, null, null, null, null },
                    { 253, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1410), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Toa Baja", "PR", "PR", null, null, null, null, null, null, null },
                    { 254, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1412), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Trujillo Alto", "PR", "PR", null, null, null, null, null, null, null },
                    { 255, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1413), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Utuado", "PR", "PR", null, null, null, null, null, null, null },
                    { 256, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1414), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Vega Alta", "PR", "PR", null, null, null, null, null, null, null },
                    { 257, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1416), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Vega Baja", "PR", "PR", null, null, null, null, null, null, null },
                    { 258, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1419), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Vieques", "PR", "PR", null, null, null, null, null, null, null },
                    { 259, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1420), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Villalba", "PR", "PR", null, null, null, null, null, null, null },
                    { 260, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1421), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Yabucoa", "PR", "PR", null, null, null, null, null, null, null },
                    { 261, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1422), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Yauco", "PR", "PR", null, null, null, null, null, null, null },
                    { 262, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1423), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Miami", "Florida", "USA", null, null, null, null, null, null, null },
                    { 263, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1425), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tampa", "Florida", "USA", null, null, null, null, null, null, null },
                    { 264, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1426), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Melbourne", "Florida", "USA", null, null, null, null, null, null, null },
                    { 265, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1427), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "New York", "New York", "USA", null, null, null, null, null, null, null },
                    { 266, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1428), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Buffalo", "New York", "USA", null, null, null, null, null, null, null },
                    { 267, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1429), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Canovanas", "PR", "PR", null, null, null, null, null, null, null },
                    { 268, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1430), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Jacksonville", "Florida", "USA", null, null, null, null, null, null, null },
                    { 269, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1431), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Orlando", "Florida", "USA", null, null, null, null, null, null, null },
                    { 270, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1432), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "FORT BUCHANAN", "PR", "PR", null, null, null, null, null, null, null },
                    { 271, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1433), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Levittown", "PR", "PR", null, null, null, null, null, null, null },
                    { 272, true, 6, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1435), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "COTO LAUREL", "PR", "PR", null, null, null, null, null, null, null },
                    { 273, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1450), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aprendizaje", null, null, null, null, null, null, null, null, null },
                    { 274, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1452), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Chofer", null, null, null, null, null, null, null, null, null },
                    { 275, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1453), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Conductor", null, null, null, null, null, null, null, null, null },
                    { 276, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1455), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Motocicleta", null, null, null, null, null, null, null, null, null },
                    { 277, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1456), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ninguna", null, null, null, null, null, null, null, null, null },
                    { 278, true, 7, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1457), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Vehículo Pesado", null, null, null, null, null, null, null, null, null },
                    { 279, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1458), "03334448-73b4-438f-8fdf-784dbab58150", "Bernardo Acevedo González", null, null, null, null, "BAG", "Analista de Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 280, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1460), "03334448-73b4-438f-8fdf-784dbab58150", "Carmín Rodríguez Negrón", null, null, null, null, "CRN", "Directora", null, null, null, null, null, null, null, null },
                    { 281, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1461), "03334448-73b4-438f-8fdf-784dbab58150", "Jannette López Falcón", null, null, null, null, "JLF", "Analista de Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 282, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1462), "03334448-73b4-438f-8fdf-784dbab58150", "Victor Maldonado Martínez", null, null, null, null, "VMM", "Director", null, null, null, null, null, null, null, null },
                    { 283, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1463), "03334448-73b4-438f-8fdf-784dbab58150", "Juan Perez Rodriguez", null, null, null, null, "JPR", "Analista ASUME", null, null, null, null, null, null, null, null },
                    { 284, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1464), "03334448-73b4-438f-8fdf-784dbab58150", "Nancy Calderon Alicea", null, null, null, null, "NCA", "Especialista Recursos Humanos", null, null, null, null, null, null, null, null },
                    { 285, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1466), "03334448-73b4-438f-8fdf-784dbab58150", "Gabriel Otero Valentin", null, null, null, null, "GOV", "Analista ADSEF", null, null, null, null, null, null, null, null },
                    { 286, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1467), "03334448-73b4-438f-8fdf-784dbab58150", "Leslie Soto Matos", null, null, null, null, "LSM", "Analista AMSCA", null, null, null, null, null, null, null, null },
                    { 287, true, 8, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1469), "03334448-73b4-438f-8fdf-784dbab58150", "Secretaria Gerencia", null, null, null, null, "SEC-GME", "Administrador", null, null, null, null, null, null, null, null },
                    { 288, true, 9, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1470), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aceptada", null, null, null, null, null, null, null, null, null },
                    { 289, true, 9, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1471), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Denegada", null, null, null, null, null, null, null, null, null },
                    { 290, true, 9, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1472), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Devuelta", null, null, null, null, null, null, null, null, null },
                    { 291, true, 10, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1475), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "M", null, null, null, null, null, null, null, null, null },
                    { 292, true, 10, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1484), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "F", null, null, null, null, null, null, null, null, null },
                    { 293, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1486), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", null, null, null, null, null, null, null, null, null },
                    { 294, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1487), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", null, null, null, null, null, null, null, null, null },
                    { 295, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1488), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Caguas", null, null, null, null, null, null, null, null, null },
                    { 296, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1489), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Carolina", null, null, null, null, null, null, null, null, null },
                    { 297, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1491), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Humacao", null, null, null, null, null, null, null, null, null },
                    { 298, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1492), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Bayamon", null, null, null, null, null, null, null, null, null },
                    { 299, true, 11, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1493), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Nivel Central", null, null, null, null, null, null, null, null, null },
                    { 300, true, 12, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1494), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Definicion Base", null, null, null, null, null, null, null, null, null },
                    { 301, true, 13, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1496), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Secretariado", null, null, null, null, null, null, null, null, null },
                    { 302, true, 13, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1497), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "ADFAN", null, null, null, null, null, null, null, null, null },
                    { 303, true, 13, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1498), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "ADSEF", null, null, null, null, null, null, null, null, null },
                    { 304, true, 13, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1499), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "ASUME", null, null, null, null, null, null, null, null, null },
                    { 305, true, 13, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1500), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "ACUDEN", null, null, null, null, null, null, null, null, null },
                    { 306, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1502), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Juan", "Area Metro", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 307, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1503), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Carolina", "Area Metro", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 308, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1504), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "Area Norte", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 309, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1506), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ponce", "Area Sur", "PR", "Puerto Rico", null, null, null, null, null, null },
                    { 310, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1507), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Orange", "Central", "Florida", "Estados Unidos", null, null, null, null, null, null },
                    { 311, true, 16, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1508), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "New York City", "Greater City", "New York", "Estados Unidos", null, null, null, null, null, null },
                    { 312, true, 17, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1509), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Segunda", null, null, null, null, null, null, null, null, null },
                    { 313, true, 17, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1542), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Primera", null, null, null, null, null, null, null, null, null },
                    { 314, true, 17, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1543), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tercera", null, null, null, null, null, null, null, null, null },
                    { 315, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1545), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Intermedio 8vo", null, null, null, null, null, null, null, null, null },
                    { 316, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1546), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Superior 12vo", null, null, null, null, null, null, null, null, null },
                    { 317, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1547), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Grado Asociado", null, null, null, null, null, null, null, null, null },
                    { 318, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1548), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Bachillerato", null, null, null, null, null, null, null, null, null },
                    { 319, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1550), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Maestria", null, null, null, null, null, null, null, null, null },
                    { 320, true, 19, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1551), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Doctorado", null, null, null, null, null, null, null, null, null },
                    { 321, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1552), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Experiencia Empleo", null, null, null, null, null, null, null, null, null },
                    { 322, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1553), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cursos o Adiestramiento", null, null, null, null, null, null, null, null, null },
                    { 323, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1555), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Identificacion", null, null, null, null, null, null, null, null, null },
                    { 324, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1556), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Licencia o Certificado", null, null, null, null, null, null, null, null, null },
                    { 325, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1557), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Referencia", null, null, null, null, null, null, null, null, null },
                    { 326, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1558), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Certificado de antecedentes penales", null, null, null, null, null, null, null, null, null },
                    { 327, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1559), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "TRANSCRIPCION DE CREDITOS", null, null, null, null, null, null, null, null, null },
                    { 328, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1560), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "RESUME", null, null, null, null, null, null, null, null, null },
                    { 329, true, 20, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1561), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "DIPLOMA UNIVERSITARIO", null, null, null, null, null, null, null, null, null },
                    { 330, true, 21, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1562), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Región", null, null, null, null, null, null, null, null, null },
                    { 331, true, 21, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1563), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Administración", null, null, null, null, null, null, null, null, null },
                    { 332, true, 21, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1564), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Finanzas", null, null, null, null, null, null, null, null, null },
                    { 333, true, 22, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1566), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Adminisrtrador", null, null, null, null, null, null, null, null, null },
                    { 334, true, 22, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1567), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "UsuarioRegion", null, null, null, null, null, null, null, null, null },
                    { 335, true, 22, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1568), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor", null, null, null, null, null, null, null, null, null },
                    { 336, true, 22, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1569), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "UsuarioLocal", null, null, null, null, null, null, null, null, null },
                    { 337, true, 22, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1570), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Finanzas", null, null, null, null, null, null, null, null, null },
                    { 338, true, 23, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1571), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Adminisrtrador", null, null, null, null, null, null, null, null, null },
                    { 339, true, 23, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1572), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Supervisor", null, null, null, null, null, null, null, null, null },
                    { 340, true, 23, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1573), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Usuarios", null, null, null, null, null, null, null, null, null },
                    { 341, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1574), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Orientación", "Form_Referidos", "Referido", null, null, null, null, null, null, null },
                    { 342, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1576), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Orientación y Referimiento", "Form_Referidos", "Referido", null, null, null, null, null, null, null },
                    { 343, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1577), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Protección", "Form_Referidos", "Referido", null, null, null, null, null, null, null },
                    { 344, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1578), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Servicio Protección", "Form_Estudio_Social", "Protección", null, null, null, null, null, null, null },
                    { 345, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1579), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Servicio Protección", "Form_Notas_Progreso", "Protección", null, null, null, null, null, null, null },
                    { 346, true, 24, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1580), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Servicio Protección", "Form_Visita_Hogar", "Protección", null, null, null, null, null, null, null },
                    { 347, true, 25, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1581), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Comienzo Formulario", null, null, null, null, null, null, null, null, null },
                    { 348, true, 25, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1582), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Seguimiento Formulario", null, null, null, null, null, null, null, null, null },
                    { 349, true, 25, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1583), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Completar Formulario", null, null, null, null, null, null, null, null, null },
                    { 350, true, 26, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1584), "03334448-73b4-438f-8fdf-784dbab58150", "Validaciones Campos Requeridos", null, null, null, null, "Validación Campos", null, null, null, null, null, null, null, null, null },
                    { 351, true, 26, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1586), "03334448-73b4-438f-8fdf-784dbab58150", "Validadcion de Segimiento cuando se completan todas se pasa proxima etapa", null, null, null, null, "Seguimiento Campos", null, null, null, null, null, null, null, null, null },
                    { 352, true, 26, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1587), "03334448-73b4-438f-8fdf-784dbab58150", "Proceso de Manejo de Firmas", null, null, null, null, "Firmas Personal", null, null, null, null, null, null, null, null, null },
                    { 353, true, 26, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1588), "03334448-73b4-438f-8fdf-784dbab58150", "Definicion que Permite Guardar y Seguir adelante, solo para pruebas", null, null, null, null, "Continuar", null, null, null, null, null, null, null, null, null },
                    { 354, true, 27, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1626), "03334448-73b4-438f-8fdf-784dbab58150", "Tipo de Accion campos Requeridos", null, null, null, null, "Requerido", null, null, null, null, null, null, null, null, null },
                    { 355, true, 27, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1627), "03334448-73b4-438f-8fdf-784dbab58150", "Tipo de Accion campos Opcionales, podrian ser marcados", null, null, null, null, "Opcionales", null, null, null, null, null, null, null, null, null },
                    { 356, true, 28, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1629), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Fecha", null, null, null, null, null, null, null, null, null },
                    { 357, true, 28, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1630), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Texto", null, null, null, null, null, null, null, null, null },
                    { 358, true, 28, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1631), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Integro", null, null, null, null, null, null, null, null, null },
                    { 359, true, 28, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1632), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Narrativa", null, null, null, null, null, null, null, null, null },
                    { 360, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1633), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "FirmaTS", "14", null, null, null, null, null, null, null, null },
                    { 361, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1634), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "FirmaSup", "20", null, null, null, null, null, null, null, null },
                    { 362, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1636), "03334448-73b4-438f-8fdf-784dbab58150", "Implementar Luego", null, null, null, null, "FirmaDir", null, null, null, null, null, null, null, null, null },
                    { 363, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1637), "03334448-73b4-438f-8fdf-784dbab58150", "Implementar Luego", null, null, null, null, "FirmaCliente", null, null, null, null, null, null, null, null, null },
                    { 364, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1638), "03334448-73b4-438f-8fdf-784dbab58150", "Implementar Luego", null, null, null, null, "FirmaRegion", null, null, null, null, null, null, null, null, null },
                    { 365, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1639), "03334448-73b4-438f-8fdf-784dbab58150", "Usar largo campo para determinar si cumple el tamano", null, null, null, null, "LargoMinimo", null, null, null, null, null, null, null, null, null },
                    { 366, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1640), "03334448-73b4-438f-8fdf-784dbab58150", "Verificar Existe valor, Not string.Empty", null, null, null, null, "TieneValor", null, null, null, null, null, null, null, null, null },
                    { 367, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1641), "03334448-73b4-438f-8fdf-784dbab58150", "Entrada de Fecha", null, null, null, null, "Fecha", null, null, null, null, null, null, null, null, null },
                    { 368, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1642), "03334448-73b4-438f-8fdf-784dbab58150", "Entrada de Hora", null, null, null, null, "Hora", null, null, null, null, null, null, null, null, null },
                    { 369, true, 29, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1643), "03334448-73b4-438f-8fdf-784dbab58150", "Validar Numero con Tope", null, null, null, null, "NumericoLargo", null, null, null, null, null, null, null, null, null },
                    { 370, true, 30, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1644), "03334448-73b4-438f-8fdf-784dbab58150", "Definicion de TS para Trabajos de este Nivel", null, null, null, null, "Trabajador Social", null, null, null, null, null, null, null, null, null },
                    { 371, true, 30, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1646), "03334448-73b4-438f-8fdf-784dbab58150", "Definicion de Supervisor para Casos", null, null, null, null, "Supervisor", null, null, null, null, null, null, null, null, null },
                    { 372, true, 31, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1647), "03334448-73b4-438f-8fdf-784dbab58150", "Adulto que es Referido", null, null, null, null, "Sujeto Referido", "Sujeto", null, null, null, null, null, null, null, null },
                    { 373, true, 31, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1648), "03334448-73b4-438f-8fdf-784dbab58150", "Persona que realiza Llamada o Refiere", null, null, null, null, "Refiere Adulto", "Refiere", null, null, null, null, null, null, null, null },
                    { 374, true, 31, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1649), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Contacto", null, null, null, null, null, null, null, null, null },
                    { 375, true, 31, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1650), "03334448-73b4-438f-8fdf-784dbab58150", "Familiares del Adulto", null, null, null, null, "Familiar", null, null, null, null, null, null, null, null, null },
                    { 376, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1651), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Abuelo/a", null, null, null, null, null, null, null, null, null },
                    { 377, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1652), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Padre", null, null, null, null, null, null, null, null, null },
                    { 378, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1653), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Madre", null, null, null, null, null, null, null, null, null },
                    { 379, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1654), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Hermano/a", null, null, null, null, null, null, null, null, null },
                    { 380, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1656), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Hijo/a", null, null, null, null, null, null, null, null, null },
                    { 381, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1657), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Nieto/a", null, null, null, null, null, null, null, null, null },
                    { 382, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1658), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Esposo/a", null, null, null, null, null, null, null, null, null },
                    { 383, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1659), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Primo/a", null, null, null, null, null, null, null, null, null },
                    { 384, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1660), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Tio/a", null, null, null, null, null, null, null, null, null },
                    { 385, true, 32, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1661), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Otro", null, null, null, null, null, null, null, null, null },
                    { 386, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1662), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ayuda del PAN", "Economica", null, null, null, null, null, null, null, null },
                    { 387, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1663), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ayuda de TANF", "Economica", null, null, null, null, null, null, null, null },
                    { 388, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1664), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ama de Llaves", "Hogar", null, null, null, null, null, null, null, null },
                    { 389, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1666), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Alimentacion", "Hogar", null, null, null, null, null, null, null, null },
                    { 390, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1667), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Terapias Fisica", "Hogar", null, null, null, null, null, null, null, null },
                    { 391, true, 33, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1668), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Visitas Medica", "Terapias", null, null, null, null, null, null, null, null },
                    { 392, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1669), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aceptado", "YES", null, null, null, null, null, null, null, null },
                    { 393, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1670), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Rechazado", "NO", null, null, null, null, null, null, null, null },
                    { 394, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1671), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Cliente no Acepto Servicio", "NO", null, null, null, null, null, null, null, null },
                    { 395, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1699), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Referido", "NO", null, null, null, null, null, null, null, null },
                    { 396, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1700), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Coordinar Servicios", "YES", null, null, null, null, null, null, null, null },
                    { 397, true, 34, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1701), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "En Proceso de Completar Informacion", "NO", null, null, null, null, null, null, null, null },
                    { 398, true, 35, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1702), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Sin Antecedentes", null, null, null, null, null, null, null, null, null },
                    { 399, true, 35, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1703), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Con Antecedentes", null, null, null, null, null, null, null, null, null },
                    { 400, true, 36, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1705), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Emergencia", null, null, null, null, null, null, null, null, null },
                    { 401, true, 36, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1707), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Urgente", null, null, null, null, null, null, null, null, null },
                    { 402, true, 36, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1708), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Periodo Reglamentario", null, null, null, null, null, null, null, null, null },
                    { 403, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1709), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Aguadilla I", "0301", "03", null, null, null, null, null, null },
                    { 404, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1710), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "Arecibo I", "0701", "07", null, null, null, null, null, null },
                    { 405, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1711), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Bayamon", "Bayamon I", "1101", "11", null, null, null, null, null, null },
                    { 406, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1712), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Caguas", "Caguas I", "1301", "13", null, null, null, null, null, null },
                    { 407, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1713), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Carolina", "Carolina I", "1601", "16", null, null, null, null, null, null },
                    { 408, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1714), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Guayama", "Guayama", "3101", "31", null, null, null, null, null, null },
                    { 409, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1715), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Humacao", "HUmacao", "3701", "37", null, null, null, null, null, null },
                    { 410, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1717), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Mayaguez", "Mayaguez I", "5101", "51", null, null, null, null, null, null },
                    { 411, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1718), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Ponce", "Ponce I", "5901", "59", null, null, null, null, null, null },
                    { 412, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1719), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Juan", "San Juan I", "6701", "67", null, null, null, null, null, null },
                    { 413, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1720), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "San Juan", "Guaynabo I", "3301", "67", null, null, null, null, null, null },
                    { 414, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1721), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Isabela", "3801", "03", null, null, null, null, null, null },
                    { 415, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1722), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Moca", "5201", "03", null, null, null, null, null, null },
                    { 416, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1723), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "San Sebastian", "7001", "03", null, null, null, null, null, null },
                    { 417, true, 38, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1724), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "El Adulto", null, null, null, null, null, null, null, null, null },
                    { 418, true, 38, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1725), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "La Familia", null, null, null, null, null, null, null, null, null },
                    { 419, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1727), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "CAMPEA Lares", null, null, null, null, null, null, null, null, null },
                    { 420, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1728), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "CAMPEA Caguas", null, null, null, null, null, null, null, null, null },
                    { 421, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1729), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Region Caguas", null, null, null, null, null, null, null, null, null },
                    { 422, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1730), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Region Aguadilla", null, null, null, null, null, null, null, null, null },
                    { 423, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1731), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Region Arecibo", null, null, null, null, null, null, null, null, null },
                    { 424, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1732), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Centro Integrado Morovis", null, null, null, null, null, null, null, null, null },
                    { 425, true, 39, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1733), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "CAMPEA Aguas Buenas", null, null, null, null, null, null, null, null, null },
                    { 426, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1734), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Aguada", "0201", "03", null, null, null, null, null, null },
                    { 427, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1735), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Aguadilla II", "0302", "03", null, null, null, null, null, null },
                    { 428, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1737), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Las Marias", "4401", "03", null, null, null, null, null, null },
                    { 429, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1738), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Aguadilla", "Rincon", "6101", "03", null, null, null, null, null, null },
                    { 430, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1739), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "Arecibo III", "0703", "07", null, null, null, null, null, null },
                    { 431, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1740), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "Barcloneta", "0901", "07", null, null, null, null, null, null },
                    { 432, true, 37, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1742), "03334448-73b4-438f-8fdf-784dbab58150", "", null, null, null, null, "Arecibo", "Camuy", "1401", "07", null, null, null, null, null, null },
                    { 433, true, 51, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1751), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Empleado", null, null, null, null, null, null, null, null, null },
                    { 434, true, 51, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(1754), "03334448-73b4-438f-8fdf-784dbab58150", null, null, null, null, null, "Desempleado", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Adm_ReportAdminRole",
                columns: new[] { "ReportRoleId", "Activo", "CreateDate", "CreateUser", "ReportId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3045), "03334448-73b4-438f-8fdf-784dbab58150", 1, "SU" },
                    { 2, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3048), "03334448-73b4-438f-8fdf-784dbab58150", 2, "SU" },
                    { 3, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3050), "03334448-73b4-438f-8fdf-784dbab58150", 3, "SU" },
                    { 4, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3052), "03334448-73b4-438f-8fdf-784dbab58150", 4, "SU" },
                    { 5, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3054), "03334448-73b4-438f-8fdf-784dbab58150", 5, "SU" },
                    { 6, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3056), "03334448-73b4-438f-8fdf-784dbab58150", 6, "SU" },
                    { 7, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3059), "03334448-73b4-438f-8fdf-784dbab58150", 7, "SU" },
                    { 8, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3061), "03334448-73b4-438f-8fdf-784dbab58150", 8, "SU" },
                    { 9, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3062), "03334448-73b4-438f-8fdf-784dbab58150", 9, "SU" },
                    { 10, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3065), "03334448-73b4-438f-8fdf-784dbab58150", 10, "SU" },
                    { 11, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3068), "03334448-73b4-438f-8fdf-784dbab58150", 11, "SU" },
                    { 12, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3069), "03334448-73b4-438f-8fdf-784dbab58150", 12, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Form_FlujosPantallas",
                columns: new[] { "ID_FORM_FlujoPantalla", "Comentarios", "EtapaCompletada", "Fecha_Flujo", "FlujoEtapa", "Flujo_Status", "ID_Forma", "ID_Formulario", "Local", "Notas", "Numero_Caso", "OrdenEtapa", "Persona", "RMO", "Region", "ID_User_Asigna", "ID_User_Asignado", "ID_User_Flujo" },
                values: new object[,]
                {
                    { 1, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3482), "Referido Nuevo", "Comienzo Formulario", 1, 1, "Aguadilla", null, null, 1, "Maria Santiago", "03-0301-0001", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 2, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3491), "Referido Seguimiento", "Seguimiento Formulario", 1, 1, "Aguadilla", null, null, 2, "Maria Santiago", "03-0301-0001", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 3, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3493), "Referido Seguimiento", "Seguimiento Formulario", 1, 1, "Aguadilla", null, null, 3, "Maria Santiago", "03-0301-0001", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 4, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3495), "Referido Nuevo", "Comienzo Formulario", 2, 2, "Bayamon", null, null, 1, "Manuel Torres", "03-0301-0002", "Bayamon", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 5, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3497), "Referido Seguimiento", "Seguimiento Formulario", 2, 2, "Bayamon", null, null, 2, "Manuel Torres", "03-0301-0002", "Bayamon", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 6, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3499), "Referido Nuevo", "Comienzo Formulario", 3, 3, "Bayamon", null, null, 1, "Jaime Sepulveda", "03-0301-0003", "Bayamon", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 7, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3500), "Referido Seguimiento", "Seguimiento Formulario", 3, 3, "Bayamon", null, null, 2, "Jaime Sepulveda", "03-0301-0003", "Bayamon", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 8, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3502), "Referido Firma TS", "Seguimiento Formulario", 3, 3, "Bayamon", null, null, 3, "Jaime Sepulveda", "03-0301-0003", "Bayamon", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 9, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3504), "Referido Nuevo", "Comienzo Formulario", 4, 1, "Aguadilla", null, null, 1, "John Martinez", "03-0301-0004", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 10, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3505), "Referido Seguimiento", "Seguimiento Formulario", 4, 1, "Aguadilla", null, null, 2, "John Martinez", "03-0301-0004", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 11, null, false, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3506), "Referido Firma TS", "Seguimiento Formulario", 4, 1, "Aguadilla", null, null, 3, "John Martinez", "03-0301-0004", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" },
                    { 12, null, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3508), "Referido Firma Sup", "Completar Formulario", 4, 1, "Aguadilla", null, null, 4, "John Martinez", "03-0301-0004", "Aguadilla", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "03334448-73b4-438f-8fdf-784dbab58150" }
                });

            migrationBuilder.InsertData(
                table: "Adm_FlujoPantallaUser",
                columns: new[] { "FlujoUserID", "Activo", "FechaFin", "FechaInicio", "FormularioEtapaId", "GroupTypeId", "Prioridad", "UserType" },
                values: new object[,]
                {
                    { 1, true, null, null, 1, 14, 1, "Trabajador Social" },
                    { 2, true, null, null, 2, 14, 1, "Trabajador Social" },
                    { 3, true, null, null, 3, 14, 1, "Trabajador Social" },
                    { 4, true, null, null, 4, 20, 1, "Supervidor" }
                });

            migrationBuilder.InsertData(
                table: "Adm_FlujosFormulariosEtapasAcciones",
                columns: new[] { "FormularioEtapaAccionId", "Activo", "Completado", "Concurrencia", "ConcurrenciaAccionId", "CreateDate", "CreateUser", "FormularioEtapaId", "ModifiedDate", "ModifiedUser", "NombreAccion", "OrdenAccion", "TipoAccion", "TipoProceso" },
                values: new object[,]
                {
                    { 1, true, true, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3345), "03334448-73b4-438f-8fdf-784dbab58150", 1, null, null, "Validacion Campos", 1, "Validación Campos", "Requerido" },
                    { 2, true, true, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3349), "03334448-73b4-438f-8fdf-784dbab58150", 2, null, null, "Determinacion Referido", 1, "Seguimiento Campos", "Requerido" },
                    { 3, true, true, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3352), "03334448-73b4-438f-8fdf-784dbab58150", 3, null, null, "Firmas Personal TS", 1, "Firmas Personal", "Requerido" },
                    { 4, true, true, false, null, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3355), "03334448-73b4-438f-8fdf-784dbab58150", 4, null, null, "Firmas Personal Supervisor", 1, "Firmas Personal", "Requerido" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 9, "Index", true, "AgregarRol", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2083), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Agregar", 7 },
                    { 10, "Index", true, "EditarRol", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2086), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Editar", 8 },
                    { 11, "Index", true, "EliminarRol", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2089), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 6, "Eliminar", 9 },
                    { 12, "Index", true, "AgregarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2092), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Agregar", 10 },
                    { 13, "Index", true, "EditarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2096), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Editar", 11 },
                    { 14, "Index", true, "EliminarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2101), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 7, "Eliminar", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 3, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2149), "03334448-73b4-438f-8fdf-784dbab58150", 3, "SU" },
                    { 4, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2151), "03334448-73b4-438f-8fdf-784dbab58150", 4, "SU" },
                    { 6, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2154), "03334448-73b4-438f-8fdf-784dbab58150", 6, "SU" },
                    { 7, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2156), "03334448-73b4-438f-8fdf-784dbab58150", 7, "SU" },
                    { 8, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2158), "03334448-73b4-438f-8fdf-784dbab58150", 8, "SU" }
                });

            migrationBuilder.InsertData(
                table: "Form_FormulariosFirmas",
                columns: new[] { "ID_FormularioFirmas", "AdmFlujoFormularioFormularioId", "Comentarios", "FechaFirma", "ID_Forma", "ID_FormularioEtapa", "ID_Formulario", "ID_FormularioEtapa1", "ID_Usuario", "Local", "Num_Caso", "Region", "Revertida", "RevertidaFecha", "RMO", "UserTypeID", "ID_Usuario_Revierte" },
                values: new object[,]
                {
                    { 1, null, "Ninguno", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3703), 3, 3, 3, null, "03334448-73b4-438f-8fdf-784dbab58150", "Bayamon", "", "Bayamon", false, null, "03-0301-0003", "69e6dd63-c624-4c4a-8bf4-c910148367ad", null },
                    { 2, null, "Comntario de TS", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3710), 4, 3, 4, null, "03334448-73b4-438f-8fdf-784dbab58150", null, "", null, false, null, "03-0301-0004", "69e6dd63-c624-4c4a-8bf4-c910148367ad", null },
                    { 3, null, "Comentario Supervisor", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(3712), 4, 4, 4, null, "03334448-73b4-438f-8fdf-784dbab58150", null, "", null, false, null, "03-0301-0004", "69e6dd63-c624-4c4a-8bf4-c910148367ad", null }
                });

            migrationBuilder.InsertData(
                table: "Adm_FlujosFormulariosEtapasAccionesCampos",
                columns: new[] { "FormularioEtapaAccionCampoId", "CampoDB", "CampoDB_IDField", "CampoDBLongitud", "CampoDBTipo", "Descripcion", "FormularioEtapaAccionId", "OrdenAccion", "Resultado", "TablaBase", "TipoProcesoCampo" },
                values: new object[,]
                {
                    { 1, "Fecha Referido", "FechaRecibo", 0, "Fecha", null, 1, 1, "Fecha del Referido es requerida para continuar.", "Form_Referidos", "TieneValor" },
                    { 2, "Hora Referido", "HoraRecibo", 0, "Fecha", null, 1, 2, "La Hora del Referido es requerida.", "Form_Referidos", "TieneValor" },
                    { 3, "Narrativa Situacion", "NarrativaSituacion", 40, "Texto", null, 1, 3, "La Narrativa de la Situacion debe ser al menos de 40 caracteres.", "Form_Referidos", "LargoMinimo" },
                    { 4, "Region", "Region", 0, "Texto", null, 1, 4, "La region es requerida para construir el RMO.", "Form_Referidos", "TieneValor" },
                    { 5, "Local", "Local", 0, "Texto", null, 1, 5, "El local es requerido para construir el RMO.", "Form_Referidos", "TieneValor" },
                    { 6, "Determinacion", "Determinacion", 0, "Texto", "La Determinacion aun no esta llena para continuar con el Referido.", 2, 1, "Debe Completar la Determinacion para Continuar con las Firmas", "Form_Referidos", "TieneValor" },
                    { 7, "Determinacion_Fecha", "DeterminacionFecha", 0, "Fecha", "La Fecha Determinacion aun no esta llena para continuar con el Referido.", 2, 2, "Debe Completar la Fecha de la Determinacion para Continuar con las Firmas", "Form_Referidos", "TieneValor" },
                    { 8, "Determinacion_Razon", "DeterminacionRazon", 0, "Texto", "La Razón Determinacion aun no esta llena para continuar con el Referido.", 2, 3, "Debe Completar la Razón de la Determinacion para poder Firmar", "Form_Referidos", "TieneValor" },
                    { 9, "Firma TS", "ID_Usuario", 0, "Texto", null, 3, 1, "La Firma del Trabajador Social debe estar Completada", "Form_FormulariosFirmas", "FirmaTS" },
                    { 10, "Firma TS", "UserTypeID", 0, "Texto", null, 3, 1, "Validacion Principal para Busqueda de Usuario Firmo", "Form_FormulariosFirmas", "FirmaTS" },
                    { 11, "Firma TS", "RMO", 0, "Texto", null, 3, 1, "La Firma del Supervisor de Trabajador Social debe estar Completada", "Form_FormulariosFirmas", "FirmaTS" },
                    { 12, "Firma Supervisor", "UserTypeID", 0, "Integro", null, 4, 1, "La Firma del Supervisor de Trabajador Social debe estar Completada", "Form_FormulariosFirmas", "FirmaSup" }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuElements",
                columns: new[] { "MenuElementId", "Accion", "Activo", "Controlador", "CreateDate", "CreateUser", "Icono", "MenuElementParentId", "Nombre", "Orden" },
                values: new object[,]
                {
                    { 15, "Index", true, "EliminarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2103), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado físico", 12 },
                    { 16, "Index", true, "EliminarUsuario", new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2106), "03334448-73b4-438f-8fdf-784dbab58150", "fas fa-cogs", 14, "Borrado lógico", 12 }
                });

            migrationBuilder.InsertData(
                table: "Adm_MenuRole",
                columns: new[] { "MenuRoleId", "Activo", "CreateDate", "CreateUser", "MenuElementId", "RoleId" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2160), "03334448-73b4-438f-8fdf-784dbab58150", 9, "SU" },
                    { 10, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2161), "03334448-73b4-438f-8fdf-784dbab58150", 10, "SU" },
                    { 11, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2163), "03334448-73b4-438f-8fdf-784dbab58150", 11, "SU" },
                    { 12, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2165), "03334448-73b4-438f-8fdf-784dbab58150", 12, "SU" },
                    { 13, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2167), "03334448-73b4-438f-8fdf-784dbab58150", 13, "SU" },
                    { 14, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2169), "03334448-73b4-438f-8fdf-784dbab58150", 14, "SU" },
                    { 15, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2170), "03334448-73b4-438f-8fdf-784dbab58150", 15, "SU" },
                    { 16, true, new DateTime(2024, 12, 3, 18, 1, 58, 720, DateTimeKind.Local).AddTicks(2172), "03334448-73b4-438f-8fdf-784dbab58150", 16, "SU" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujoPantallaUser_FormularioEtapaId",
                table: "Adm_FlujoPantallaUser",
                column: "FormularioEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujosFormulariosEtapas_FormularioId",
                table: "Adm_FlujosFormulariosEtapas",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujosFormulariosEtapas_NotaEndId",
                table: "Adm_FlujosFormulariosEtapas",
                column: "NotaEndId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujosFormulariosEtapas_NotaStartId",
                table: "Adm_FlujosFormulariosEtapas",
                column: "NotaStartId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujosFormulariosEtapasAcciones_FormularioEtapaId",
                table: "Adm_FlujosFormulariosEtapasAcciones",
                column: "FormularioEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_FlujosFormulariosEtapasAccionesCampos_FormularioEtapaAccionId",
                table: "Adm_FlujosFormulariosEtapasAccionesCampos",
                column: "FormularioEtapaAccionId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Form_FlujosPantallas_ID_Formulario",
                table: "Form_FlujosPantallas",
                column: "ID_Formulario");

            migrationBuilder.CreateIndex(
                name: "IX_Form_FormulariosFirmas_AdmFlujoFormularioFormularioId",
                table: "Form_FormulariosFirmas",
                column: "AdmFlujoFormularioFormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_FormulariosFirmas_ID_FormularioEtapa",
                table: "Form_FormulariosFirmas",
                column: "ID_FormularioEtapa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm_FlujoPantallaUser");

            migrationBuilder.DropTable(
                name: "Adm_FlujosFormulariosEtapasAccionesCampos");

            migrationBuilder.DropTable(
                name: "Adm_MenuRole");

            migrationBuilder.DropTable(
                name: "Adm_ParametrosSeleccion");

            migrationBuilder.DropTable(
                name: "Adm_ReportAdminRole");

            migrationBuilder.DropTable(
                name: "Form_FlujosPantallas");

            migrationBuilder.DropTable(
                name: "Form_FormulariosFirmas");

            migrationBuilder.DropTable(
                name: "Form_Referidos");

            migrationBuilder.DropTable(
                name: "Adm_FlujosFormulariosEtapasAcciones");

            migrationBuilder.DropTable(
                name: "Adm_MenuElements");

            migrationBuilder.DropTable(
                name: "Adm_ParametroCategoria");

            migrationBuilder.DropTable(
                name: "Adm_ReportAdmin");

            migrationBuilder.DropTable(
                name: "Adm_FlujosFormulariosEtapas");

            migrationBuilder.DropTable(
                name: "Adm_FlujoFormularioNotas");

            migrationBuilder.DropTable(
                name: "Adm_FlujosFormularios");
        }
    }
}
