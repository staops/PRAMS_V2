using FluentResults;
using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Domain.Models.Forms;
using PRAMS.Domain.Models.SystemConfiguration;
using System;
using System.Drawing;
using System.Reflection.Metadata;

namespace PRAMS.Infraestructure.Data.SystemConfiguration
{
    public class AppConfigDbContext(DbContextOptions<AppConfigDbContext> options) : DbContext(options)
    {
        public DbSet<AdmParametroCategoria> AdmParamCategories { get; set; }

        public DbSet<AdmParametrosSeleccion> AdmParamSelections { get; set; }

        public DbSet<AdmMenuElements> AdmMenuElements { get; set; }

        public DbSet<AdmMenuRole> AdmMenuRoles { get; set; }

        public DbSet<AdmReports> AdmReports { get; set; }

        public DbSet<AdmReportsRole> AdmReportsRoles { get; set; }

        public DbSet<AdmFlujoFormulario> AdmFlujoFormularios { get; set; }

        public DbSet<AdmFlujoFormularioEtapa> AdmFlujoFormularioEtapas { get; set; }

        public DbSet<AdmFlujoFormularioEtapaAccion> AdmFlujoFormularioEtapaAcciones { get; set; }

        public DbSet<AdmFlujoFormularioNota> AdmFlujoFormularioNotas { get; set; }

        public DbSet<AdmFlujoPantallaUser> AdmFlujoPantallaUsers { get; set; }

        public DbSet<AdmFormularioEtapaAccioneCampo> AdmFormularioEtapaAccioneCampos { get; set; }

        public DbSet<FormFlujoPantalla> FormFlujoPantallas { get; set; }

        public DbSet<FormFormularioFirma> FormFormularioFirmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<FormFormularioFirma>().HasOne(f => f.AdmFlujoFormulario).WithMany(f => f.FormFormularioFirmas).HasForeignKey(f => f.FormularioFirmasId);

            modelBuilder.Entity<AdmFlujoFormularioEtapa>()
                .HasOne(f => f.AdmFlujoFormularioNotaStart)
                .WithMany(p => p.AdmFlujoFormularioEtapasStart)
                .HasForeignKey(f => f.NotaStartId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_AdmFlujoFormularioNotaStart");

            modelBuilder.Entity<AdmFlujoFormularioEtapa>()
                .HasOne(f => f.AdmFlujoFormularioNotaEnd)
                .WithMany(p => p.AdmFlujoFormularioEtapasEnd)
                .HasForeignKey(f => f.NotaEndId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_AdmFlujoFormularioNotaEnd");

            PouplateParametroCategoria(modelBuilder);
            PopulateAdmMenuElements(modelBuilder);
            PouplateReportsCategoria(modelBuilder);
        }

        private static void PouplateParametroCategoria(ModelBuilder modelBuilder)
        {

            IDictionary<string, IList<object?>> valuePairsParamCategoria = new Dictionary<string, IList<object?>>()
            {
                ["Clasificacion Empleados"] = ["Clasificaciones", null, null, null],
                ["Curso Aprobado"] = [null, null, null, null],
                ["Curso Aprobado Demo"] = [null, null, null, null],
                ["Tipo Impedimento"] = [null, null, null, null],
                ["Tipo Nombramiento"] = [null, null, null, null],
                ["Pueblos"] = ["Def Pueblos con Dos Niveles de Filtros", "Estado", "Pais", null],
                ["Categoria Licencias"] = [null, null, null, null],
                ["Firmas"] = [null, "Posición/Puesto", null, null],
                ["Acciones"] = [null, null, null, null],
                ["Genero"] = [null, null, null, null],
                ["Region"] = [null, null, null, null],
                ["Tipo Convocatoria"] = [null, null, null, null],
                ["Dependencias"] = [null, null, null, null],
                ["Entidades Municipio"] = ["Def Municipios Tres Niveles Ejemplo", "Region", "Estado", "Pais"],
                ["Cantidad Solicitudes"] = ["Numero de Solicitudes realizadas 2Segunda, etc.", null, null, null],
                ["Grados Academicos"] = ["Grados Academicos", "Region", "Estado", "Pais"],
                ["Tipo de Documentos"] = ["Tipos de Documentos para Cargas", null, null, null],
                ["Tipo Reportes"] = ["Tipos de Reportes para Tablas de Reportes Admin", null, null, null],
                ["RolesReportes"] = ["Tipos de Roles para Reportes", null, null, null],
                ["RolesMenu"] = ["Tipos de Roles para Menu Asignacion Roles", null, null, null],
                ["TipoCasos"] = ["Tipo de Casos Flujos", "Formulario", "Nivel de Caso", null],
                ["TipoEtapa"] = ["Tipos de Etapas de Formularios", null, null, null],
                ["TipoAcciones"] = ["Etapas de FLujo Acciones de Validadiones", null, null, null],
                ["TipoProceso"] = ["Etapas Flujo Acciones Tipo de Proceso", null, null, null],
                ["CampoDBTipo"] = ["Tipos de Campos DB para Validaciones", null, null, null],
                ["TipoProcesoCampo"] = ["Como se procesan las Acciones Campo de Validaciones", null, null, null],
                ["TipoUsuarios"] = ["Tipo de Usuarios Sistema", "Rol ID", null, null],
            };
            IList<AdmParametroCategoria> admParametros = valuePairsParamCategoria.Select((x, i) => new AdmParametroCategoria
            {
                CategoriaID = i + 1,
                Categoria = x.Key,
                Descripcion = (string?)x.Value?[0] ?? string.Empty,
                TX_Filtro1_Nombre = (string?)x.Value?[1],
                TX_Filtro2_Nombre = (string?)x.Value?[2],
                TX_Filtro3_Nombre = (string?)x.Value?[3],
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now,
                Activo = true
            }).ToList();
            modelBuilder.Entity<AdmParametroCategoria>().HasData(admParametros);


            // Clasificacion Empleados
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionClasificacionEmpleados =
            [
                new(1, "Conserje II", null, null, null, null),
                new(1, "Reparador(a) Equipo de Oficina", null, null, null, null),
                new(1, "Carpintero(a)", null, null, null, null),
                new(1, "Plomero", null, null, null, null),
                new(1, "Ebanista", null, null, null, null),
                new(1, "Abogado", null, null, null, null),
                new(1, "Abogado Principal", null, null, null, null),
                new(1, "Abogado Senior", null, null, null, null),
                new(1, "Administrador de Bases de Datos", null, null, null, null),
                new(1, "Administrador de Sistemas de Oficina I", null, null, null, null),
                new(1, "Administrador de Sistemas de Oficina II", null, null, null, null),
                new(1, "Administrador de Sistemas de Oficina III", null, null, null, null),
                new(1, "Agente Comprador", null, null, null, null),
                new(1, "Analista de Presupuesto", null, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos", null, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos Senior", null, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos y Relaciones Laborales", null, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad I", null, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad II", null, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad III", null, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad IV", null, null, null, null),
                new(1, "Analista en Relaciones Laborales", null, null, null, null),
                new(1, "Artista Grafico", null, null, null, null),
                new(1, "Asistente de Analistas en Determinacion de Incapacidad", null, null, null, null),
                new(1, "Asistente de Cuidado Diurno", null, null, null, null),
                new(1, "Asistente de Programa Federal", null, null, null, null),
                new(1, "Asistente de Servicios de Alimentos", null, null, null, null),
                new(1, "Asistente de Servicios Sociales", null, null, null, null),
                new(1, "Auditor Programatico de Servicios Sociales", null, null, null, null),
                new(1, "Auxiliar Administrativo", null, null, null, null),
                new(1, "Auxiliar de Cocina", null, null, null, null),
                new(1, "Auxiliar de Compras", null, null, null, null),
                new(1, "Auxiliar en Contabilidad", null, null, null, null),
                new(1, "Auxiliar en Control de Asistencia", null, null, null, null),
                new(1, "Auxiliar en Nominas", null, null, null, null),
                new(1, "Auxiliar en Sistemas de Oficina", null, null, null, null),
                new(1, "Auxiliar Fiscal", null, null, null, null),
                new(1, "Auxiliar Fiscal Principal", null, null, null, null),
                new(1, "Cocinero", null, null, null, null),
                new(1, "Conductor de Vehiculos de Motor Liviano", null, null, null, null),
                new(1, "Conductor de Vehiculos de Motor Pesado", null, null, null, null),
                new(1, "Conserje", null, null, null, null),
                new(1, "Contador", null, null, null, null),
                new(1, "Contador Principal", null, null, null, null),
                new(1, "Contador Senior", null, null, null, null),
                new(1, "Coordinador Auxiliar en Cuidado y Desarrollo del Nino", null, null, null, null),
                new(1, "Coordinador de Actividades con Padres de Head Start/Early Head Start", null, null, null, null),
                new(1, "Coordinador de Adiestramientos Programaticos de Servicios Sociales", null, null, null, null),
                new(1, "Coordinador de Educacion de Head Start/Early Head Start ", null, null, null, null),
                new(1, "Coordinador de Nutricion de Head Start/Early Head Start", null, null, null, null),
                new(1, "Coordinador de Salud Medico Dental de Head Start/Early Head Start", null, null, null, null),
                new(1, "Coordinador de Salud Mental de Head Start/Early Head Start", null, null, null, null),
                new(1, "Coordinador en Cuidado y Desarrollo del Nino", null, null, null, null),
                new(1, "Coordinador Interagencial", null, null, null, null),
                new(1, "Coordinador para Asuntos de Retiro", null, null, null, null),
                new(1, "Director Administrativo", null, null, null, null),
                new(1, "Director Asociado de Asistencia Social y Familiar", null, null, null, null),
                new(1, "Director Asociado de Servicios Sociales a las Familias y las Comunidades", null, null, null, null),
                new(1, "Director Asociado de Sustento de Menores", null, null, null, null),
                new(1, "Director Auxiliar", null, null, null, null),
                new(1, "Director Auxiliar del Programa de Determinacion de Incapacidad", null, null, null, null),
                new(1, "Director Auxiliar en Planificacion", null, null, null, null),
                new(1, "Director de Adiestramiento", null, null, null, null),
                new(1, "Director de Centro de Cuidado Diurno", null, null, null, null),
                new(1, "Director de Centro de Servicios Integrados", null, null, null, null),
                new(1, "Director de Finanzas", null, null, null, null),
                new(1, "Director de Hogar o Centro de Servicios", null, null, null, null),
                new(1, "Director de Monitoria Programatica de Sustento de Menores", null, null, null, null),
                new(1, "Director de Presupuesto", null, null, null, null),
                new(1, "Director de Programa de Asistencia Social y Familiar", null, null, null, null),
                new(1, "Director de Servicios Auxiliares", null, null, null, null),
                new(1, "Director de Sistemas y Procedimientos", null, null, null, null),
                new(1, "Director del Programa Child Care", null, null, null, null),
                new(1, "Director del Programa Head Start/Early Head Start", null, null, null, null),
                new(1, "Director del Registro Central de Sustento de Menores", null, null, null, null),
                new(1, "Economista del Hogar", null, null, null, null),
                new(1, "Encargado Auxiliar de la Propiedad", null, null, null, null),
                new(1, "Encargado de la Propiedad", null, null, null, null),
                new(1, "Enfermero Generalista", null, null, null, null),
                new(1, "Enfermero Generalista II", null, null, null, null),
                new(1, "Enfermero Practico Licenciado", null, null, null, null),
                new(1, "Especialista en Asistencia Social y Familiar", null, null, null, null),
                new(1, "Especialista en Determinacion de Incapacidad", null, null, null, null),
                new(1, "Especialista en Evaluacion", null, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias", null, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias Principal", null, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias Senior", null, null, null, null),
                new(1, "Especialista en Servicios Sociales a las Familias y las Comunidades", null, null, null, null),
                new(1, "Estadistico", null, null, null, null),
                new(1, "Funcionario Administrativo", null, null, null, null),
                new(1, "Gerente Auxiliar de Sistemas de Informacion", null, null, null, null),
                new(1, "Gerente de Monitoreo", null, null, null, null),
                new(1, "Gerente de Sistemas de Informacion", null, null, null, null),
                new(1, "Guardalmacen", null, null, null, null),
                new(1, "Instructor del Programa Head Start", null, null, null, null),
                new(1, "Investigador de Querellas Administrativas de Servicios Sociales", null, null, null, null),
                new(1, "Lider Recreativo", null, null, null, null),
                new(1, "Mensajero", null, null, null, null),
                new(1, "Monitor Programatico de Sustento de Menores", null, null, null, null),
                new(1, "Nutricionista", null, null, null, null),
                new(1, "Oficial Administrativo", null, null, null, null),
                new(1, "Oficial Administrativo Principal", null, null, null, null),
                new(1, "Oficial Administrativo Senior", null, null, null, null),
                new(1, "Oficial de Asistencia y Licencias", null, null, null, null),
                new(1, "Oficial de Comunicaciones", null, null, null, null),
                new(1, "Oficial de Cuentas a Cobrar", null, null, null, null),
                new(1, "Oficial de Cuidado Diurno", null, null, null, null),
                new(1, "Oficial de Licenciamiento", null, null, null, null),
                new(1, "Oficial de Licenciamiento Senior", null, null, null, null),
                new(1, "Oficial de Nominas", null, null, null, null),
                new(1, "Oficial de Pensiones Alimentarias", null, null, null, null),
                new(1, "Oficial de Presupuesto", null, null, null, null),
                new(1, "Oficial Ejecutivo", null, null, null, null),
                new(1, "Oficial en Administracion de Recursos Humanos", null, null, null, null),
                new(1, "Oficial en Administracion de Recursos Humanos Principal", null, null, null, null),
                new(1, "Oficial en Relaciones Laborales", null, null, null, null),
                new(1, "Oficial Examinador", null, null, null, null),
                new(1, "Oficial Examinador Licenciado", null, null, null, null),
                new(1, "Oficinista de Contabilidad", null, null, null, null),
                new(1, "Oficinista I", null, null, null, null),
                new(1, "Oficinista II", null, null, null, null),
                new(1, "Operador de Equipo de Procesar Datos", null, null, null, null),
                new(1, "Operador de Maquina Duplicadora", null, null, null, null),
                new(1, "Pagador Auxiliar", null, null, null, null),
                new(1, "Pagador Oficial", null, null, null, null),
                new(1, "Pagador Oficial Principal", null, null, null, null),
                new(1, "Recaudador Auxiliar", null, null, null, null),
                new(1, "Recaudador Oficial", null, null, null, null),
                new(1, "Recepcionista Telefonista", null, null, null, null),
                new(1, "Receptor Auxiliar", null, null, null, null),
                new(1, "Receptor Oficial", null, null, null, null),
                new(1, "Subdirector Administrativo del Programa de Determinacion de Incapacidad", null, null, null, null),
                new(1, "Subdirector del Programa Child Care", null, null, null, null),
                new(1, "Subdirector Regional", null, null, null, null),
                new(1, "Supervisor", null, null, null, null),
                new(1, "Supervisor de Actividades con Padres de Head Start/Early Head Start", null, null, null, null),
                new(1, "Supervisor de Actividades Recreativas y Deportivas", null, null, null, null),
                new(1, "Supervisor de Asistencia Social y Familiar", null, null, null, null),
                new(1, "Supervisor de Asistencia Social y Familiar Principal", null, null, null, null),
                new(1, "Supervisor de Asistencia y Licencias", null, null, null, null),
                new(1, "Supervisor de Asistente de Analistas en Determinacion de Incapacidad", null, null, null, null),
                new(1, "Supervisor de Compras", null, null, null, null),
                new(1, "Supervisor de Conservacion y Mantenimiento", null, null, null, null),
                new(1, "Supervisor de Educacion de Head Start/Early Head Start", null, null, null, null),
                new(1, "Supervisor de Licenciamiento", null, null, null, null),
                new(1, "Supervisor de Nominas", null, null, null, null),
                new(1, "Supervisor de Nutricion de Head Start/Early Head Start", null, null, null, null),
                new(1, "Supervisor de Oficiales de Pensiones Alimentarias", null, null, null, null),
                new(1, "Supervisor de Salud Medico Dental de Head Start/Early Head Start", null, null, null, null),
                new(1, "Supervisor de Salud Mental de Head Start/Early Head Start", null, null, null, null),
                new(1, "Supervisor de Servicios Sociales a las Familias y las Comunidades I", null, null, null, null),
                new(1, "Supervisor de Servicios Sociales a las Familias y las Comunidades II", null, null, null, null),
                new(1, "Supervisor de Transportacion", null, null, null, null),
                new(1, "Supervisor en Cuidado y Desarrollo del Nino", null, null, null, null),
                new(1, "Supervisor en Determinacion de Incapacidad I", null, null, null, null),
                new(1, "Supervisor en Determinacion de Incapacidad II", null, null, null, null),
                new(1, "Tecnico de Asistencia Social y Familiar", null, null, null, null),
                new(1, "Tecnico de Asistencia Social y Familiar Senior", null, null, null, null),
                new(1, "Tecnico de Control de Calidad de Asistencia Social y Familiar", null, null, null, null),
                new(1, "Tecnico de Elegibilidad", null, null, null, null),
                new(1, "Tecnico de Servicios Sociales a las Familias y las Comunidades", null, null, null, null),
                new(1, "Tecnico de Servicios Sociales a las Familias y las Comunidades Senior", null, null, null, null),
                new(1, "Tecnico en Sistemas de Informacion", null, null, null, null),
                new(1, "Tecnico en Sistemas en Oficina", null, null, null, null),
                new(1, "Trabajador de Conservacion", null, null, null, null),
                new(1, "Trabajador de Servicios Generales", null, null, null, null),
                new(1, "Trabajador Social", null, null, null, null),
                new(1, "Trabajador Social Senior", null, null, null, null),
                new(1, "Traductor Interprete", null, null, null, null),
            ];
            //// Curso Aprobado
            //ICollection<string> listCursoAprobado = ["CursoAprobado", "Dactilógrafo", "General", "Oficinista", "Oficinista de Contabilidad", "Otro", "Secretarial"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSelecciontCursoAprobado =
            [
                new(2, "CursoAprobado", null, null, null, null),
                new(2, "Dactilógrafo", null, null, null, null),
                new(2, "General", null, null, null, null),
                new(2, "Oficinista", null, null, null, null),
                new(2, "Oficinista de Contabilidad", null, null, null, null),
                new(2, "Otro", null, null, null, null),
                new(2, "Secretarial", null, null, null, null),
            ];
            //// Curso Aprobado Demo
            //// Emtpty List
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionCursoAprobadoDemo = [];

            //// Tipo Impedimento
            //ICollection<string> listTipoImpedimento = ["Ninguno", "No Vidente", "Otro", "Sordo", "Uso de Silla de Rueda"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoImpedimento =
            [
                new(4, "Ninguno", null, null, null, null),
                new(4, "No Vidente", null, null, null, null),
                new(4, "Otro", null, null, null, null),
                new(4, "Sordo", null, null, null, null),
                new(4, "Uso de Silla de Rueda", null, null, null, null),
            ];

            //// Tipo Nombramiento
            //ICollection<string> listTipoNombramiento = ["Jornada Parcial", "Tiempo Completo"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoNombramiento =
            [
                new(5, "Jornada Parcial", null, null, null, null),
                new(5, "Tiempo Completo", null, null, null, null),
            ];

            //// Pueblos
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionPueblos =
            [
                new(6, "Canovanas", null, "PR", "PR", null),
                new(6, "FORT BUCHANAN", null, "PR", "PR", null),
                new(6, "Levittown", null, "PR", "PR", null),
                new(6, "Adjuntas", null, "PR", "PR", null),
                new(6, "Aguada", null, "PR", "PR", null),
                new(6, "Aguadilla", null, "PR", "PR", null),
                new(6, "Aguas Buenas", null, "PR", "PR", null),
                new(6, "Aguirre", null, "PR", "PR", null),
                new(6, "Aibonito", null, "PR", "PR", null),
                new(6, "Añasco", null, "PR", "PR", null),
                new(6, "Arecibo", null, "PR", "PR", null),
                new(6, "Arroyo", null, "PR", "PR", null),
                new(6, "Barceloneta", null, "PR", "PR", null),
                new(6, "Barranquitas", null, "PR", "PR", null),
                new(6, "Bayamón", null, "PR", "PR", null),
                new(6, "Cabo Rojo", null, "PR", "PR", null),
                new(6, "Caguas", null, "PR", "PR", null),
                new(6, "Camuy", null, "PR", "PR", null),
                new(6, "Carolina", null, "PR", "PR", null),
                new(6, "Cataño", null, "PR", "PR", null),
                new(6, "Cayey", null, "PR", "PR", null),
                new(6, "Ceiba", null, "PR", "PR", null),
                new(6, "Ciales", null, "PR", "PR", null),
                new(6, "Cidras", null, "PR", "PR", null),
                new(6, "Coamo", null, "PR", "PR", null),
                new(6, "Comerio", null, "PR", "PR", null),
                new(6, "Corozal", null, "PR", "PR", null),
                new(6, "Culebras", null, "PR", "PR", null),
                new(6, "Dorado", null, "PR", "PR", null),
                new(6, "Ensenada", null, "PR", "PR", null),
                new(6, "Fajardo", null, "PR", "PR", null),
                new(6, "Florida", null, "PR", "PR", null),
                new(6, "Guanica", null, "PR", "PR", null),
                new(6, "Guayama", null, "PR", "PR", null),
                new(6, "Guayanilla", null, "PR", "PR", null),
                new(6, "Guaynabo", null, "PR", "PR", null),
                new(6, "Gurabo", null, "PR", "PR", null),
                new(6, "Hatillo", null, "PR", "PR", null),
                new(6, "Hato Rey", null, "PR", "PR", null),
                new(6, "Hormigueros", null, "PR", "PR", null),
                new(6, "Humacao", null, "PR", "PR", null),
                new(6, "Isabela", null, "PR", "PR", null),
                new(6, "Jayuya", null, "PR", "PR", null),
                new(6, "Juana Diaz", null, "PR", "PR", null),
                new(6, "Juncos", null, "PR", "PR", null),
                new(6, "Lajas", null, "PR", "PR", null),
                new(6, "Lares", null, "PR", "PR", null),
                new(6, "Las Marias", null, "PR", "PR", null),
                new(6, "Las Piedras", null, "PR", "PR", null),
                new(6, "Loíza", null, "PR", "PR", null),
                new(6, "Luquillo", null, "PR", "PR", null),
                new(6, "Manatí", null, "PR", "PR", null),
                new(6, "Maricao", null, "PR", "PR", null),
                new(6, "Maunabo", null, "PR", "PR", null),
                new(6, "Mayaguez", null, "PR", "PR", null),
                new(6, "Moca", null, "PR", "PR", null),
                new(6, "Morovis", null, "PR", "PR", null),
                new(6, "Naguabo", null, "PR", "PR", null),
                new(6, "Naranjito", null, "PR", "PR", null),
                new(6, "Orocovis", null, "PR", "PR", null),
                new(6, "Patillas", null, "PR", "PR", null),
                new(6, "Peñuelas", null, "PR", "PR", null),
                new(6, "Ponce", null, "PR", "PR", null),
                new(6, "Puerto Nuevo", null, "PR", "PR", null),
                new(6, "Quebradillas", null, "PR", "PR", null),
                new(6, "Rincón", null, "PR", "PR", null),
                new(6, "Rio Grande", null, "PR", "PR", null),
                new(6, "Rio Piedras", null, "PR", "PR", null),
                new(6, "Sabana Grande", null, "PR", "PR", null),
                new(6, "Salinas", null, "PR", "PR", null),
                new(6, "San Germán", null, "PR", "PR", null),
                new(6, "San Juan", null, "PR", "PR", null),
                new(6, "San Lorenzo", null, "PR", "PR", null),
                new(6, "San Sebastián", null, "PR", "PR", null),
                new(6, "Santa Isabel", null, "PR", "PR", null),
                new(6, "Santurce", null, "PR", "PR", null),
                new(6, "Toa Alta", null, "PR", "PR", null),
                new(6, "Toa Baja", null, "PR", "PR", null),
                new(6, "Trujillo Alto", null, "PR", "PR", null),
                new(6, "Utuado", null, "PR", "PR", null),
                new(6, "Vega Alta", null, "PR", "PR", null),
                new(6, "Vega Baja", null, "PR", "PR", null),
                new(6, "Vieques", null, "PR", "PR", null),
                new(6, "Villalba", null, "PR", "PR", null),
                new(6, "Yabucoa", null, "PR", "PR", null),
                new(6, "Yauco", null, "PR", "PR", null),
                new(6, "Jacksonville", null, "Florida", "USA", null),
                new(6, "Orlando", null, "Florida", "USA", null),
                new(6, "Miami", null, "Florida", "USA", null),
                new(6, "Tampa", null, "Florida", "USA", null),
                new(6, "Melbourne", null, "Florida", "USA", null),
                new(6, "New York", null, "New York", "USA", null),
                new(6, "Buffalo", null, "New York", "USA", null),
            ];

            //// Categoria Licencias
            //ICollection<string> listCategoriaLicencias = ["Aprendizaje", "Chofer", "Conductor", "Motocicleta", "Ninguna", "Vehículo Pesado"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionCategoriaLicencias =
            [
                new(7, "Aprendizaje", null, null, null, null),
                new(7, "Chofer", null, null, null, null),
                new(7, "Conductor", null, null, null, null),
                new(7, "Motocicleta", null, null, null, null),
                new(7, "Ninguna", null, null, null, null),
                new(7, "Vehículo Pesado", null, null, null, null),
            ];

            //// Firmas
            //IDictionary<string, IList<string>> valuePairsFirmas = new Dictionary<string, IList<string>>
            //{
            //    ["SEC-GME"] = ["Secretaria Gerencia", "Administrador"],
            //    ["GOV"] = ["Gabriel Otero Valentin", "Analista ADSEF"],
            //    ["LSM"] = ["Leslie Soto Matos", "Analista AMSCA"],
            //    ["JPR"] = ["Juan Perez Rodriguez", "Analista ASUME"],
            //    ["BAG"] = ["Bernardo Acevedo González", "Analista de Recursos Humanos"],
            //    ["JLF"] = ["Jannette López Falcón", "Analista de Recursos Humanos"],
            //    ["VMM"] = ["Victor Maldonado Martínez", "Director"],
            //    ["CRN"] = ["Carmín Rodríguez Negrón", "Directora"],
            //    ["NCA"] = ["Nancy Calderon Alicea", "Especialista Recursos Humanos"],
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionFirmas =
            [
                new(8, "SEC-GME", "Secretaria Gerencia", "Administrador", null, null),
                new(8, "GOV", "Gabriel Otero Valentin", "Analista ADSEF", null, null),
                new(8, "LSM", "Leslie Soto Matos", "Analista AMSCA", null, null),
                new(8, "JPR", "Juan Perez Rodriguez", "Analista ASUME", null, null),
                new(8, "BAG", "Bernardo Acevedo González", "Analista de Recursos Humanos", null, null),
                new(8, "JLF", "Jannette López Falcón", "Analista de Recursos Humanos", null, null),
                new(8, "VMM", "Victor Maldonado Martínez", "Director", null, null),
                new(8, "CRN", "Carmín Rodríguez Negrón", "Directora", null, null),
                new(8, "NCA", "Nancy Calderon Alicea", "Especialista Recursos Humanos", null, null),
            ];

            //// Acciones
            //IList<string> listAcciones = ["Aceptada", "Denegada", "Devuelta"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionAcciones =
            [
                new(9, "Aceptada", null, null, null, null),
                new(9, "Denegada", null, null, null, null),
                new(9, "Devuelta", null, null, null, null),
            ];

            //// Genero
            //IList<string> listGenero = ["Femenino", "Masculino"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionGenero =
            [
                new(10, "Femenino", null, null, null, null),
                new(10, "Masculino", null, null, null, null),
            ];

            //// Region
            //IList<string> listRegion = ["Aguadilla", "Arecibo", "Bayamon", "Nivel Central", "Caguas", "Carolina", "Humacao"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionRegion =
            [
                new(11, "Aguadilla", null, null, null, null),
                new(11, "Arecibo", null, null, null, null),
                new(11, "Bayamon", null, null, null, null),
                new(11, "Nivel Central", null, null, null, null),
                new(11, "Caguas", null, null, null, null),
                new(11, "Carolina", null, null, null, null),
                new(11, "Humacao", null, null, null, null),
            ];

            //// Tipo Convocatoria
            //IList<string> listTipoConvocatoria = ["Definicion Base"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoConvocatoria =
            [
                new(12, "Definicion Base", null, null, null, null),
            ];

            //// Dependencias
            //IList<string> listDependencias = ["ADFAN", "ADSEF", "ASUME", "ACUDEN", "Secretariado"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionDependencias =
            [
                new(13, "ADFAN", null, null, null, null),
                new(13, "ADSEF", null, null, null, null),
                new(13, "ASUME", null, null, null, null),
                new(13, "ACUDEN", null, null, null, null),
                new(13, "Secretariado", null, null, null, null),
            ];

            //// Entidades Municipio
            //IDictionary<string, IList<string>> valuePairsEntidadesMunicipio = new Dictionary<string, IList<string>>
            //{
            //    ["San Juan"] = ["Area Metro", "PR", "Puerto Rico"],
            //    ["Carolina"] = ["Area Metro", "PR", "Puerto Rico"],
            //    ["Arecibo"] = ["Area Norte", "PR", "Puerto Rico"],
            //    ["Ponce"] = ["Area Sur", "PR", "Puerto Rico"],
            //    ["Orange"] = ["Central", "Florida", "Estados Unidos"],
            //    ["New York City"] = ["Greater City", "New York", "Estados Unidos"],
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionEntidadesMunicipio =
            [
                new(14, "San Juan", null, "Area Metro", "PR", "Puerto Rico"),
                new(14, "Carolina", null, "Area Metro", "PR", "Puerto Rico"),
                new(14, "Arecibo", null, "Area Norte", "PR", "Puerto Rico"),
                new(14, "Ponce", null, "Area Sur", "PR", "Puerto Rico"),
                new(14, "Orange", null, "Central", "Florida", "Estados Unidos"),
                new(14, "New York City", null, "Greater City", "New York", "Estados Unidos"),
            ];

            //// Cantidad Solicitudes
            //IList<string> listCantidadSolicitudes = ["Primera", "Segunda", "Tercera"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionCantidadSolicitudes =
            [
                new(15, "Primera", null, null, null, null),
                new(15, "Segunda", null, null, null, null),
                new(15, "Tercera", null, null, null, null),
            ];

            //// Grados Academicos
            //IList<string> listGradosAcademicos = ["Intermedio 8vo", "Superior 12vo", "Grado Asociado", "Bachillerato", "Maestria", "Doctorado"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionGradosAcademicos =
            [
                new(16, "Intermedio 8vo", null, null, null, null),
                new(16, "Superior 12vo", null, null, null, null),
                new(16, "Grado Asociado", null, null, null, null),
                new(16, "Bachillerato", null, null, null, null),
                new(16, "Maestria", null, null, null, null),
                new(16, "Doctorado", null, null, null, null),
            ];

            //// Tipo de Documentos
            //IList<string> listTipoDocumentos = ["Experiencia Empleo", "Cursos o Adiestramiento", "Identificacion", "Licencia o Certificado", "Referencia", "Certificado de antecedentes penales", "TRANSCRIPCION DE CREDITOS", "RESUME", "RESUME", "DIPLOMA UNIVERSITARIO"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoDocumentos =
            [
                new(17, "Experiencia Empleo", null, null, null, null),
                new(17, "Cursos o Adiestramiento", null, null, null, null),
                new(17, "Identificacion", null, null, null, null),
                new(17, "Licencia o Certificado", null, null, null, null),
                new(17, "Referencia", null, null, null, null),
                new(17, "Certificado de antecedentes penales", null, null, null, null),
                new(17, "TRANSCRIPCION DE CREDITOS", null, null, null, null),
                new(17, "RESUME", null, null, null, null),
                new(17, "RESUME", null, null, null, null),
                new(17, "DIPLOMA UNIVERSITARIO", null, null, null, null),
            ];

            //// Tipo Reportes
            //IList<string> listTipoReportes = ["Región", "Administración", "Finanzas"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoReportes =
            [
                new(18,"Región", null, null, null, null),
                new(18,"Administración", null, null, null, null),
                new(18,"Finanzas", null, null, null, null),
            ];

            //// RolesReportes
            //IList<string> listRolesReportes = ["Adminisrtrador", "UsuarioRegion", "Supervisor", "UsuarioLocal", "Finanzas"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionRolesReportes =
            [
                new(19, "Adminisrtrador", null, null, null, null),
                new(19, "UsuarioRegion", null, null, null, null),
                new(19, "Supervisor", null, null, null, null),
                new(19, "UsuarioLocal", null, null, null, null),
                new(19, "Finanzas", null, null, null, null),
            ];

            //// RolesMenu
            //IList<string> listRolesMenu = ["Adminisrtrador", "Supervisor", "Usuarios"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionRolesMenu =
            [
                new(20, "Adminisrtrador", null, null, null, null),
                new(20, "Supervisor", null, null, null, null),
                new(20, "Usuarios", null, null, null, null),
            ];

            //// TipoCasos
            //IDictionary<string, IList<string>> valuePairsTipoCasos = new Dictionary<string, IList<string>>
            //{
            //    ["Servicio Protección"] = ["Form_Estudio_Social", "Protección"],
            //    ["Servicio Protección"] = ["Form_Notas_Progreso", "Protección"],
            //    ["Orientación"] = ["Form_Referidos", "Referido"],
            //    ["Orientación y Referimiento"] = ["Form_Referidos", "Referido"],
            //    ["Protección"] = ["Form_Referidos", "Referido"],
            //    ["Servicio Protección"] = ["Form_Visita_Hogar ", "Protección"]
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoCasos =
            [
                new(21,"Servicio Protección", "Form_Estudio_Social", "Protección", null, null),
                new(21,"Servicio Protección", "Form_Notas_Progreso", "Protección", null, null),
                new(21,"Orientación", "Form_Referidos", "Referido", null, null),
                new(21,"Orientación y Referimiento", "Form_Referidos", "Referido", null, null),
                new(21,"Protección", "Form_Referidos", "Referido", null, null),
                new(21,"Servicio Protección", "Form_Visita_Hogar ", "Protección", null, null),
            ];

            //// TipoEtapa
            //IList<string> listTipoEtapa = ["Comienzo Formulario", "Seguimiento Formulario", "Completar Formulario"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoEtapa =
            [
                new(22, "Comienzo Formulario", null, null, null, null),
                new(22, "Seguimiento Formulario", null, null, null, null),
                new(22, "Completar Formulario", null, null, null, null),
            ];

            //// TipoAcciones
            //IDictionary<string, IList<string>> listTipoAcciones = new Dictionary<string, IList<string>>
            //{
            //    ["Validación Campos"] = ["Validaciones Campos Requeridos"],
            //    ["Seguimiento Campos"] = ["Validadcion de Segimiento cuando se completan todas se pasa proxima etapa"],
            //    ["Firmas Personal"] = ["Proceso de Manejo de Firmas"],
            //    ["Continuar"] = ["Definicion que Permite Guardar y Seguir adelante, solo para pruebas"],
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoAcciones =
            [
                new(23, "Validación Campos", "Validaciones Campos Requeridos", null, null, null),
                new(23, "Seguimiento Campos", "Validadcion de Segimiento cuando se completan todas se pasa proxima etapa", null, null, null),
                new(23, "Firmas Personal", "Proceso de Manejo de Firmas", null, null, null),
                new(23, "Continuar", "Definicion que Permite Guardar y Seguir adelante, solo para pruebas", null, null, null),
            ];

            //// TipoProceso
            //IDictionary<string, IList<string>> listTipoProceso = new Dictionary<string, IList<string>>
            //{
            //    ["Requerido"] = ["Tipo de Accion campos Requeridos"],
            //    ["Opcionales"] = ["Tipo de Accion campos Opcionales, podrian ser marcados"]
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoProceso =
            [
                new(24, "Requerido", "Tipo de Accion campos Requeridos", null, null, null),
                new(24, "Opcionales", "Tipo de Accion campos Opcionales, podrian ser marcados", null, null, null),
            ];

            //// CampoDBTipo
            //IList<string> listCampoDBTipo = ["Fecha", "Texto", "Integro", "Narrativa", "FirmaDir"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionCampoDBTipo =
            [
                new(25, "Fecha", null, null, null, null),
                new(25, "Texto", null, null, null, null),
                new(25, "Integro", null, null, null, null),
                new(25, "Narrativa", null, null, null, null),
                new(25, "FirmaDir", null, null, null, null),
            ];

            //// TipoProcesoCampo
            //IDictionary<string, IList<object?>> listTipoProcesoCampo = new Dictionary<string, IList<object?>>
            //{
            //    ["FirmaDir"] = ["Implementar Luego", null],
            //    ["FirmaCliente"] = ["Implementar Luego", null],
            //    ["FirmaRegion"] = ["Implementar Luego", null],
            //    ["LargoMinimo"] = ["Usar largo campo para determinar si cumple el tamano", null],
            //    ["TieneValor"] = ["Verificar Existe valor, Not Null", null],
            //    ["Fecha"] = ["Entrada de Fecha", null],
            //    ["Hora"] = ["Entrada de Hora", null],
            //    ["NumericoLargo"] = ["Validar Numero con Tope", null],
            //    ["FirmaTS"] = ["", "14"],
            //    ["FirmaSup"] = ["", "20"],
            //};
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoProcesoCampo =
            [
                new(26, "FirmaDir", "Implementar Luego", null, null, null),
                new(26, "FirmaCliente", "Implementar Luego", null, null, null),
                new(26, "FirmaRegion", "Implementar Luego", null, null, null),
                new(26, "LargoMinimo", "Usar largo campo para determinar si cumple el tamano", null, null, null),
                new(26, "TieneValor", "Verificar Existe valor, Not Null", null, null, null),
                new(26, "Fecha", "Entrada de Fecha", null, null, null),
                new(26, "Hora", "Entrada de Hora", null, null, null),
                new(26, "NumericoLargo", "Validar Numero con Tope", null, null, null),
                new(26, "FirmaTS", "", "14", null, null),
                new(26, "FirmaSup", "", "20", null, null),
            ];

            //// TipoUsuarios
            //IList<string> listTipoUsuarios = ["Trabajador Social", "Supervisor"];
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionTipoUsuarios =
            [
                new(27, "Trabajador Social", null, null, null, null),
                new(27, "Supervisor", null, null, null, null),
            ];




            // Join the dictionaries
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccion = [
                .. valuePairsParamAdmParametrosSeleccionClasificacionEmpleados,
                .. valuePairsParamAdmParametrosSelecciontCursoAprobado,
                .. valuePairsParamAdmParametrosSeleccionCursoAprobadoDemo,
                .. valuePairsParamAdmParametrosSeleccionTipoImpedimento,
                .. valuePairsParamAdmParametrosSeleccionTipoNombramiento,
                .. valuePairsParamAdmParametrosSeleccionPueblos,
                .. valuePairsParamAdmParametrosSeleccionCategoriaLicencias,
                .. valuePairsParamAdmParametrosSeleccionFirmas,
                .. valuePairsParamAdmParametrosSeleccionAcciones,
                .. valuePairsParamAdmParametrosSeleccionGenero,
                .. valuePairsParamAdmParametrosSeleccionRegion,
                .. valuePairsParamAdmParametrosSeleccionTipoConvocatoria,
                .. valuePairsParamAdmParametrosSeleccionDependencias,
                .. valuePairsParamAdmParametrosSeleccionEntidadesMunicipio,
                .. valuePairsParamAdmParametrosSeleccionCantidadSolicitudes,
                .. valuePairsParamAdmParametrosSeleccionGradosAcademicos,
                .. valuePairsParamAdmParametrosSeleccionTipoDocumentos,
                .. valuePairsParamAdmParametrosSeleccionTipoReportes,
                .. valuePairsParamAdmParametrosSeleccionRolesReportes,
                .. valuePairsParamAdmParametrosSeleccionRolesMenu,
                .. valuePairsParamAdmParametrosSeleccionTipoCasos,
                .. valuePairsParamAdmParametrosSeleccionTipoEtapa,
                .. valuePairsParamAdmParametrosSeleccionTipoAcciones,
                .. valuePairsParamAdmParametrosSeleccionTipoProceso,
                .. valuePairsParamAdmParametrosSeleccionCampoDBTipo,
                .. valuePairsParamAdmParametrosSeleccionTipoProcesoCampo,
                .. valuePairsParamAdmParametrosSeleccionTipoUsuarios,
            ];

            IList<AdmParametrosSeleccion> admParametrosSeleccion = valuePairsParamAdmParametrosSeleccion.Select((x, i) => new AdmParametrosSeleccion
            {
                ParamterosID = i + 1,
                CategoriaID = x.CategoriaID,
                Parametro = x.Parametro,
                Descripcion = x.Descripcion,
                TX_Filtro1 = x.TX_Filtro1,
                TX_Filtro2 = x.TX_Filtro2,
                TX_Filtro3 = x.TX_Filtro3,
                CreateUser = x.CreateUser,
                CreateDate = x.CreateDate,
                Activo = x.Activo
            }).ToList();
            modelBuilder.Entity<AdmParametrosSeleccion>().HasData(admParametrosSeleccion);


        }

        private static void PopulateAdmMenuElements(ModelBuilder modelBuilder)
        {
            IList<AdmMenuElements> admMenuElements = [
                new(){
                    MenuElementId = 1,
                    Nombre = "Home",
                    Controlador = "Home",
                    Accion = "Index",
                    Icono = "fas fa-home",
                    Orden = 1,
                    MenuElementParentId = null,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 2,
                    Nombre = "System Configuration",
                    Controlador = "SystemConfiguration",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 2,
                    MenuElementParentId = null,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 3,
                    Nombre = "Parametros",
                    Controlador = "Parametros",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 1,
                    MenuElementParentId = 2,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 4,
                    Nombre = "Categorias",
                    Controlador = "Categorias",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 2,
                    MenuElementParentId = 2,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 5,
                    Nombre = "Ajustes",
                    Controlador = "Ajustes",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 3,
                    MenuElementParentId = null,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 6,
                    Nombre = "Roles",
                    Controlador = "Roles",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 4,
                    MenuElementParentId = 5,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 7,
                    Nombre = "Usuarios",
                    Controlador = "Usuarios",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 5,
                    MenuElementParentId = 5,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 8,
                    Nombre = "Otro",
                    Controlador = "Otro",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 6,
                    MenuElementParentId = 5,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 9,
                    Nombre = "Agregar",
                    Controlador = "AgregarRol",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 7,
                    MenuElementParentId = 6,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 10,
                    Nombre = "Editar",
                    Controlador = "EditarRol",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 8,
                    MenuElementParentId = 6,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 11,
                    Nombre = "Eliminar",
                    Controlador = "EliminarRol",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 9,
                    MenuElementParentId = 6,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 12,
                    Nombre = "Agregar",
                    Controlador = "AgregarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 10,
                    MenuElementParentId = 7,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 13,
                    Nombre = "Editar",
                    Controlador = "EditarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 11,
                    MenuElementParentId = 7,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 14,
                    Nombre = "Eliminar",
                    Controlador = "EliminarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 12,
                    MenuElementParentId = 7,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 15,
                    Nombre = "Borrado físico",
                    Controlador = "EliminarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 12,
                    MenuElementParentId = 14,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 16,
                    Nombre = "Borrado lógico",
                    Controlador = "EliminarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 12,
                    MenuElementParentId = 14,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 17,
                    Nombre = "Borrado lógico",
                    Controlador = "EliminarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 12,
                    MenuElementParentId = null,
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuElementId = 18,
                    Nombre = "Elmento eliminado",
                    Controlador = "EliminarUsuario",
                    Accion = "Index",
                    Icono = "fas fa-cogs",
                    Orden = 12,
                    MenuElementParentId = null,
                    Activo = false,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                }

            ];

            modelBuilder.Entity<AdmMenuElements>().HasData(admMenuElements);

            IList<AdmMenuRole> admMenuRoles = [
                new(){
                    MenuRoleId = 1,
                    MenuElementId = 1,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 2,
                    MenuElementId = 2,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 3,
                    MenuElementId = 3,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 4,
                    MenuElementId = 4,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 5,
                    MenuElementId = 5,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 6,
                    MenuElementId = 6,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 7,
                    MenuElementId = 7,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 8,
                    MenuElementId = 8,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 9,
                    MenuElementId = 9,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 10,
                    MenuElementId = 10,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 11,
                    MenuElementId = 11,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 12,
                    MenuElementId = 12,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 13,
                    MenuElementId = 13,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 14,
                    MenuElementId = 14,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 15,
                    MenuElementId = 15,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 16,
                    MenuElementId = 16,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 17,
                    MenuElementId = 17,
                    RoleId = "SU",
                    Activo = true,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                    MenuRoleId = 18,
                    MenuElementId = 18,
                    RoleId = "SU",
                    Activo = false,
                    CreateDate = DateTime.Now,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                }


            ];

            modelBuilder.Entity<AdmMenuRole>().HasData(admMenuRoles);
        }

        private static void PouplateReportsCategoria(ModelBuilder modelBuilder)
        {
            IList<AdmReports> admReportsParametros =
            [
                new(){
                  ReportId =  1,
                  ReportType = "Región",
                  ReportName =  "Listado de RMS Generados Diarios (por Región)",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_GeneradosDiarios",
                  ReportParameters =  "Fecha",
                  Activo = true,
                  ReportDescription =  "Lista los RMS Pendientes Diariamente, selección por Fecha y agrupado por Región",
                  Orden =  1,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  2,
                  ReportType = "Región",
                  ReportName =  "RMS Completados por Empleados rango de Fechas y por Región",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRange",
                  ReportParameters =  "Fechas",
                  Activo = true,
                  ReportDescription =  "Lista los RMS Completados por los Empleados por rango de fecha y por Región (Todos los Contestados)",
                  Orden =  3,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  3,
                  ReportType = "Región",
                  ReportName =  "RMS Completados por Fechas, Región y que son Validos",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_DateRangeValid",
                  ReportParameters =  "Fechas, Region",
                  Activo = true,
                  ReportDescription =  "Lista los RMS Completados Validos por los Empleados por rango de fecha y por Región (Solo Validos)",
                  Orden =  2,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  4,
                  ReportType = "Finanzas",
                  ReportName =  "Reporte de RMS Validos Completados Listado para Asistencias de Empleados",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Complete_ValidAssistance",
                  ReportParameters =  "Fecha, Region",
                  Activo = true,
                  ReportDescription =  "Reporte de RMS Completados Validos para reclamos, incluye Numero de RMS para uso en las Asistencias de los Empleados para los RMS Contestados.",
                  Orden =  3,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  5,
                  ReportType = "Administración",
                  ReportName =  "RMS Resumen Estadisticas Envíos por Rango Fecha y Región",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRms_Statdistics_DateRangeRegion",
                  ReportParameters =  "Fecha y Region",
                  Activo = true,
                  ReportDescription =  "Resumen de los RMS enviados, completados, invalidos, seguimientos y validos con porcientos de completados",
                  Orden =  2,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  6,
                  ReportType = "Administración",
                  ReportName =  "Formulario RMS llenados por Fecha ",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_WorkDetailRange",
                  ReportParameters =  "Fecha",
                  Activo = true,
                  ReportDescription =  "Muestra el Formulario RMS según llenado por los Trabajadores Sociales",
                  Orden =  1,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  7,
                  ReportType = "Finanzas",
                  ReportName =  "Cost Allocation Plan Reporte Diario",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationDaily",
                  ReportParameters =  "Fecha",
                  Activo = true,
                  ReportDescription =  "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Diarios",
                  Orden =  4,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  8,
                  ReportType = "Finanzas",
                  ReportName =  "Cost Allocation Plan Reporte Mensual",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationMonthly",
                  ReportParameters =  "Fecha",
                  Activo = true,
                  ReportDescription =  "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant para el Mes seleccionado.",
                  Orden =  5,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  9,
                  ReportType = "Finanzas",
                  ReportName =  "Cost Allocation Plan Reporte Trimestral",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CostAllocationQuarter",
                  ReportParameters =  "Fecha",
                  Activo = true,
                  ReportDescription =  "El reporte de Cost Allocation Plan resumen de los RMS entrados por Grant Trimestrales",
                  Orden =  7,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  10,
                  ReportType = "Administración",
                  ReportName =  "Observaciones Completadas por Rango de Fecha (Selección Validas)",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_Submitted_DateRange",
                  ReportParameters =  "Fechas",
                  Activo = true,
                  ReportDescription =  "Este Reporte muestra todas las Observaciones entradas por los usuarios en un rango de fechas con sus respectivos Títulos y Grants por rango de Fecha y selección de Validos o Invalidos para el CAP",
                  Orden =  3,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  11,
                  ReportType = "Finanzas",
                  ReportName =  "RMS Matrix",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_Matrix",
                  ReportParameters =  "Fechas",
                  Activo = true,
                  ReportDescription =  "RMS Matrix Distribution Report for the CAP Titile Distribution",
                  Orden =  1,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                },
                new(){
                  ReportId =  12,
                  ReportType = "Finanzas",
                  ReportName =  "Schedule D Listado RMS",
                  ReportLink =  "Reports/Pages/Report.aspx?ItemPath=%2fRMS+Reports%2fRMS_CAP_ScheduleD",
                  ReportParameters =  "Fechas",
                  Activo = true,
                  ReportDescription =  "Listado de RMS Validos para completar el Schedule D del CAP",
                  Orden =  2,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                  CreateDate = DateTime.Now
                }
            ];
            modelBuilder.Entity<AdmReports>().HasMany(x => x.AdmReportsRoles).WithOne(x => x.AdmReports).HasForeignKey(x => x.ReportId);
            modelBuilder.Entity<AdmReports>().HasData(admReportsParametros);

            IList<AdmReportsRole> admReportsRole = [
                new(){
                  ReportRoleId = 1,
                  ReportId = 1,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 2,
                  ReportId = 2,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 3,
                  ReportId = 3,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 4,
                  ReportId = 4,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 5,
                  ReportId = 5,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 6,
                  ReportId = 6,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 7,
                  ReportId = 7,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 8,
                  ReportId = 8,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 9,
                  ReportId = 9,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 10,
                  ReportId = 10,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 11,
                  ReportId = 11,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                },
                new(){
                  ReportRoleId = 12,
                  ReportId = 12,
                  RoleId = "SU",
                  Activo = true,
                  CreateDate = DateTime.Now,
                  CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                }
            ];

            modelBuilder.Entity<AdmReportsRole>().HasData(admReportsRole);
        }
    }
}
