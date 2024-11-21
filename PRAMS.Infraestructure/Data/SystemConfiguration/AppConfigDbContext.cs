using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Domain.Models.Forms;
using PRAMS.Domain.Models.SystemConfiguration;

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

        public DbSet<FormReferido> FormReferidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AdmFlujoFormularioEtapa>()
                .HasMany(f => f.FormFormularioFirmas)
                .WithOne(p => p.AdmFlujoFormularioEtapa)
                .HasConstraintName("FK_FormFormularioFirma_AdmFlujoFormularioEtapa")
                .HasForeignKey(f => f.FormularioEtapaId);

            modelBuilder.Entity<FormFormularioFirma>()
                .HasOne(f => f.AdmFlujoFormularioEtapa)
                .WithMany(p => p.FormFormularioFirmas)
                .HasForeignKey(f => f.FormularioEtapaId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_FormFormularioFirma");

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
            PouplateFlujosFormularios(modelBuilder);

            DummyFlujoPantallas(modelBuilder);
        }

        private static void PouplateParametroCategoria(ModelBuilder modelBuilder)
        {

            IList<AdmParametroCategoriaInsertIDDto> admParametroCategoriaInsertDto =
            [
                new(1, "Clasificacion Empleados", "Clasificaciones", null, null, null, null, null, null, null, null, null),
                new(2, "Curso Aprobado", string.Empty, null, null, null, null, null, null, null, null, null),
                new(4, "Tipo Impedimento", string.Empty, null, null, null, null, null, null, null, null, null),
                new(5, "Tipo Nombramiento", string.Empty, null, null, null, null, null, null, null, null, null),
                new(6, "Pueblos", "Def Pueblos con Dos Niveles de Filtros", "Estado", "Pais", null, null, null, null, null, null, null),
                new(7, "Categoria Licencias", string.Empty, null, null, null, null, null, null, null, null, null),
                new(8, "Firmas", string.Empty, "Posición / Puesto", null, null, null, null, null, null, null, null),
                new(9, "Acciones", string.Empty, null, null, null, null, null, null, null, null, null),
                new(10, "Genero", string.Empty, null, null, null, null, null, null, null, null, null),
                new(11, "Region", string.Empty, null, null, null, null, null, null, null, null, null),
                new(12, "Tipo Convocatoria", string.Empty, null, null, null, null, null, null, null, null, null),
                new(13, "Dependencias", string.Empty, null, null, null, null, null, null, null, null, null),
                new(16, "Entidades Municipio", "Def Municipios Tres Niveles Ejemplo", "Region", "Estado", "Pais", null, null, null, null, null, null),
                new(17, "Cantidad Solicitudes", "Numero de Solicitudes realizadas 2Segunda, etc.", null, null, null, null, null, null, null, null, null),
                new(19, "Grados Academicos", "Tipos de Grados Academicos", null, null, null, null, null, null, null, null, null),
                new(20, "Tipo de Documentos", "Tipos de Documentos para Cargas", null, null, null, null, null, null, null, null, null),
                new(21, "Tipo Reportes", "Tipos de Reportes para Tablas de Reportes Admin", null, null, null, null, null, null, null, null, null),
                new(22, "RolesReportes", "Tipos de Roles para Reportes", null, null, null, null, null, null, null, null, null),
                new(23, "RolesMenu", "Tipos de Roles para Menu Asignacion Roles", null, null, null, null, null, null, null, null, null),
                new(24, "TipoCasos", "Tipo de Casos Flujos", "Formulario", "Nivel de Caso", null, null, null, null, null, null, null),
                new(25, "TipoEtapa", "Tipos de Etapas de Formularios", null, null, null, null, null, null, null, null, null),
                new(26, "TipoAcciones", "Etapas de FLujo Acciones de Validadiones", null, null, null, null, null, null, null, null, null),
                new(27, "TipoProceso", "Etapas Flujo Acciones Tipo de Proceso", null, null, null, null, null, null, null, null, null),
                new(28, "CampoDBTipo", "Tipos de Campos DB para Validaciones", null, null, null, null, null, null, null, null, null),
                new(29, "TipoProcesoCampo", "Como se procesan las Acciones Campo de Validaciones", null, null, null, null, null, null, null, null, null),
                new(30, "TipoUsuarios", "Tipo de Usuarios Sistema", "Rol ID", null, null, null, null, null, null, null, null),
                new(31, "TipoPersonas", "Para Pantallas de Personas Link", null, null, null, null, null, null, null, null, null),
                new(32, "Relaciones", "Para Pantalla de Personas Link Relacion", null, null, null, null, null, null, null, null, null),
                new(33, "ServiciosSolicitados", "Servicios para los Referidos", "Tipo de Servicio", null, null, null, null, null, null, null, null),
                new(34, "DeterminacionReferido", "Determinaciones de los Referidos", "Proxima Etapa", null, null, null, null, null, null, null, null),
                new(35, "Antecedentes", "Antecedentes para los Referidos", null, null, null, null, null, null, null, null, null),
                new(36, "ClasificacionReferido", "Nivel de prioridad del Referido", null, null, null, null, null, null, null, null, null),
                new(37, "AsignacionLocalizacioon", string.Empty, "Oficina / Local", null, null, null, null, null, null, null, null),
                new(38, "AgenciaSolicitadoPara", "Para los Tipos de Solicitud de Agencia", null, null, null, null, null, null, null, null, null),
                new(39, "OrigenReferido", "Referido Campo OrigenReferido", null, null, null, null, null, null, null, null, null),
            ];

            IList<AdmParametroCategoria> admParametros = admParametroCategoriaInsertDto.Select((x, i) => new AdmParametroCategoria
            {
                CategoriaID = x.CategoriaID,
                Categoria = x.Categoria,
                Descripcion = x.Descripcion,
                TX_Filtro1_Nombre = x.TX_Filtro1_Nombre,
                TX_Filtro2_Nombre = x.TX_Filtro2_Nombre,
                TX_Filtro3_Nombre = x.TX_Filtro3_Nombre,
                Activo = true,
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now,
            }).ToList();
            modelBuilder.Entity<AdmParametroCategoria>().HasData(admParametros);

            // Clasificacion Empleados
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccionClasificacionEmpleados =
            [
                new(1, "Abogado", string.Empty, null, null, null),
                new(1, "Abogado Principal", string.Empty, null, null, null),
                new(1, "Abogado Senior", string.Empty, null, null, null),
                new(1, "Administrador de Bases de Datos", string.Empty, null, null, null),
                new(1, "Administrador de Sistemas de Oficina I", string.Empty, null, null, null),
                new(1, "Administrador de Sistemas de Oficina II", string.Empty, null, null, null),
                new(1, "Administrador de Sistemas de Oficina III", string.Empty, null, null, null),
                new(1, "Agente Comprador", string.Empty, null, null, null),
                new(1, "Analista de Presupuesto", string.Empty, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos", string.Empty, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos Senior", string.Empty, null, null, null),
                new(1, "Analista en Administracion de Recursos Humanos y Relaciones Laborales", string.Empty, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad I", string.Empty, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad II", string.Empty, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad III", string.Empty, null, null, null),
                new(1, "Analista en Determinacion de Incapacidad IV", string.Empty, null, null, null),
                new(1, "Analista en Relaciones Laborales", string.Empty, null, null, null),
                new(1, "Artista Grafico", string.Empty, null, null, null),
                new(1, "Asistente de Analistas en Determinacion de Incapacidad", string.Empty, null, null, null),
                new(1, "Asistente de Cuidado Diurno", string.Empty, null, null, null),
                new(1, "Asistente de Programa Federal", string.Empty, null, null, null),
                new(1, "Asistente de Servicios de Alimentos", string.Empty, null, null, null),
                new(1, "Asistente de Servicios Sociales", string.Empty, null, null, null),
                new(1, "Auditor Programatico de Servicios Sociales", string.Empty, null, null, null),
                new(1, "Auxiliar Administrativo", string.Empty, null, null, null),
                new(1, "Auxiliar de Cocina", string.Empty, null, null, null),
                new(1, "Auxiliar de Compras", string.Empty, null, null, null),
                new(1, "Auxiliar en Contabilidad", string.Empty, null, null, null),
                new(1, "Auxiliar en Control de Asistencia", string.Empty, null, null, null),
                new(1, "Auxiliar en Nominas", string.Empty, null, null, null),
                new(1, "Auxiliar en Sistemas de Oficina", string.Empty, null, null, null),
                new(1, "Auxiliar Fiscal", string.Empty, null, null, null),
                new(1, "Auxiliar Fiscal Principal", string.Empty, null, null, null),
                new(1, "Cocinero", string.Empty, null, null, null),
                new(1, "Conductor de Vehiculos de Motor Liviano", string.Empty, null, null, null),
                new(1, "Conductor de Vehiculos de Motor Pesado", string.Empty, null, null, null),
                new(1, "Conserje", string.Empty, null, null, null),
                new(1, "Contador", string.Empty, null, null, null),
                new(1, "Contador Principal", string.Empty, null, null, null),
                new(1, "Contador Senior", string.Empty, null, null, null),
                new(1, "Coordinador Auxiliar en Cuidado y Desarrollo del Nino", string.Empty, null, null, null),
                new(1, "Coordinador de Actividades con Padres de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Coordinador de Adiestramientos Programaticos de Servicios Sociales", string.Empty, null, null, null),
                new(1, "Coordinador de Educacion de Head Start/Early Head Start ", string.Empty, null, null, null),
                new(1, "Coordinador de Nutricion de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Coordinador de Salud Medico Dental de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Coordinador de Salud Mental de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Coordinador en Cuidado y Desarrollo del Nino", string.Empty, null, null, null),
                new(1, "Coordinador Interagencial", string.Empty, null, null, null),
                new(1, "Coordinador para Asuntos de Retiro", string.Empty, null, null, null),
                new(1, "Director Administrativo", string.Empty, null, null, null),
                new(1, "Director Asociado de Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Director Asociado de Servicios Sociales a las Familias y las Comunidades", string.Empty, null, null, null),
                new(1, "Director Asociado de Sustento de Menores", string.Empty, null, null, null),
                new(1, "Director Auxiliar", string.Empty, null, null, null),
                new(1, "Director Auxiliar del Programa de Determinacion de Incapacidad", string.Empty, null, null, null),
                new(1, "Director Auxiliar en Planificacion", string.Empty, null, null, null),
                new(1, "Director de Adiestramiento", string.Empty, null, null, null),
                new(1, "Director de Centro de Cuidado Diurno", string.Empty, null, null, null),
                new(1, "Director de Centro de Servicios Integrados", string.Empty, null, null, null),
                new(1, "Director de Finanzas", string.Empty, null, null, null),
                new(1, "Director de Hogar o Centro de Servicios", string.Empty, null, null, null),
                new(1, "Director de Monitoria Programatica de Sustento de Menores", string.Empty, null, null, null),
                new(1, "Director de Presupuesto", string.Empty, null, null, null),
                new(1, "Director de Programa de Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Director de Servicios Auxiliares", string.Empty, null, null, null),
                new(1, "Director de Sistemas y Procedimientos", string.Empty, null, null, null),
                new(1, "Director del Programa Child Care", string.Empty, null, null, null),
                new(1, "Director del Programa Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Director del Registro Central de Sustento de Menores", string.Empty, null, null, null),
                new(1, "Economista del Hogar", string.Empty, null, null, null),
                new(1, "Encargado Auxiliar de la Propiedad", string.Empty, null, null, null),
                new(1, "Encargado de la Propiedad", string.Empty, null, null, null),
                new(1, "Enfermero Generalista", string.Empty, null, null, null),
                new(1, "Enfermero Generalista II", string.Empty, null, null, null),
                new(1, "Enfermero Practico Licenciado", string.Empty, null, null, null),
                new(1, "Especialista en Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Especialista en Determinacion de Incapacidad", string.Empty, null, null, null),
                new(1, "Especialista en Evaluacion", string.Empty, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias", string.Empty, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias Principal", string.Empty, null, null, null),
                new(1, "Especialista en Pensiones Alimentarias Senior", string.Empty, null, null, null),
                new(1, "Especialista en Servicios Sociales a las Familias y las Comunidades", string.Empty, null, null, null),
                new(1, "Estadistico", string.Empty, null, null, null),
                new(1, "Funcionario Administrativo", string.Empty, null, null, null),
                new(1, "Gerente Auxiliar de Sistemas de Informacion", string.Empty, null, null, null),
                new(1, "Gerente de Monitoreo", string.Empty, null, null, null),
                new(1, "Gerente de Sistemas de Informacion", string.Empty, null, null, null),
                new(1, "Guardalmacen", string.Empty, null, null, null),
                new(1, "Instructor del Programa Head Start", string.Empty, null, null, null),
                new(1, "Investigador de Querellas Administrativas de Servicios Sociales", string.Empty, null, null, null),
                new(1, "Lider Recreativo", string.Empty, null, null, null),
                new(1, "Mensajero", string.Empty, null, null, null),
                new(1, "Monitor Programatico de Sustento de Menores", string.Empty, null, null, null),
                new(1, "Nutricionista", string.Empty, null, null, null),
                new(1, "Oficial Administrativo", string.Empty, null, null, null),
                new(1, "Oficial Administrativo Principal", string.Empty, null, null, null),
                new(1, "Oficial Administrativo Senior", string.Empty, null, null, null),
                new(1, "Oficial de Asistencia y Licencias", string.Empty, null, null, null),
                new(1, "Oficial de Comunicaciones", string.Empty, null, null, null),
                new(1, "Oficial de Cuentas a Cobrar", string.Empty, null, null, null),
                new(1, "Oficial de Cuidado Diurno", string.Empty, null, null, null),
                new(1, "Oficial de Licenciamiento", string.Empty, null, null, null),
                new(1, "Oficial de Licenciamiento Senior", string.Empty, null, null, null),
                new(1, "Oficial de Nominas", string.Empty, null, null, null),
                new(1, "Oficial de Pensiones Alimentarias", string.Empty, null, null, null),
                new(1, "Oficial de Presupuesto", string.Empty, null, null, null),
                new(1, "Oficial Ejecutivo", string.Empty, null, null, null),
                new(1, "Oficial en Administracion de Recursos Humanos", string.Empty, null, null, null),
                new(1, "Oficial en Administracion de Recursos Humanos Principal", string.Empty, null, null, null),
                new(1, "Oficial en Relaciones Laborales", string.Empty, null, null, null),
                new(1, "Oficial Examinador", string.Empty, null, null, null),
                new(1, "Oficial Examinador Licenciado", string.Empty, null, null, null),
                new(1, "Oficinista de Contabilidad", string.Empty, null, null, null),
                new(1, "Oficinista I", string.Empty, null, null, null),
                new(1, "Oficinista II", string.Empty, null, null, null),
                new(1, "Operador de Equipo de Procesar Datos", string.Empty, null, null, null),
                new(1, "Operador de Maquina Duplicadora", string.Empty, null, null, null),
                new(1, "Pagador Auxiliar", string.Empty, null, null, null),
                new(1, "Pagador Oficial", string.Empty, null, null, null),
                new(1, "Pagador Oficial Principal", string.Empty, null, null, null),
                new(1, "Recaudador Auxiliar", string.Empty, null, null, null),
                new(1, "Recaudador Oficial", string.Empty, null, null, null),
                new(1, "Recepcionista Telefonista", string.Empty, null, null, null),
                new(1, "Receptor Auxiliar", string.Empty, null, null, null),
                new(1, "Receptor Oficial", string.Empty, null, null, null),
                new(1, "Subdirector Administrativo del Programa de Determinacion de Incapacidad", string.Empty, null, null, null),
                new(1, "Subdirector del Programa Child Care", string.Empty, null, null, null),
                new(1, "Subdirector Regional", string.Empty, null, null, null),
                new(1, "Supervisor", string.Empty, null, null, null),
                new(1, "Supervisor de Actividades con Padres de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Supervisor de Actividades Recreativas y Deportivas", string.Empty, null, null, null),
                new(1, "Supervisor de Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Supervisor de Asistencia Social y Familiar Principal", string.Empty, null, null, null),
                new(1, "Supervisor de Asistencia y Licencias", string.Empty, null, null, null),
                new(1, "Supervisor de Asistente de Analistas en Determinacion de Incapacidad", string.Empty, null, null, null),
                new(1, "Supervisor de Compras", string.Empty, null, null, null),
                new(1, "Supervisor de Conservacion y Mantenimiento", string.Empty, null, null, null),
                new(1, "Supervisor de Educacion de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Supervisor de Licenciamiento", string.Empty, null, null, null),
                new(1, "Supervisor de Nominas", string.Empty, null, null, null),
                new(1, "Supervisor de Nutricion de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Supervisor de Oficiales de Pensiones Alimentarias", string.Empty, null, null, null),
                new(1, "Supervisor de Salud Medico Dental de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Supervisor de Salud Mental de Head Start/Early Head Start", string.Empty, null, null, null),
                new(1, "Supervisor de Servicios Sociales a las Familias y las Comunidades I", string.Empty, null, null, null),
                new(1, "Supervisor de Servicios Sociales a las Familias y las Comunidades II", string.Empty, null, null, null),
                new(1, "Supervisor de Transportacion", string.Empty, null, null, null),
                new(1, "Supervisor en Cuidado y Desarrollo del Nino", string.Empty, null, null, null),
                new(1, "Supervisor en Determinacion de Incapacidad I", string.Empty, null, null, null),
                new(1, "Supervisor en Determinacion de Incapacidad II", string.Empty, null, null, null),
                new(1, "Tecnico de Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Tecnico de Asistencia Social y Familiar Senior", string.Empty, null, null, null),
                new(1, "Tecnico de Control de Calidad de Asistencia Social y Familiar", string.Empty, null, null, null),
                new(1, "Tecnico de Elegibilidad", string.Empty, null, null, null),
                new(1, "Tecnico de Servicios Sociales a las Familias y las Comunidades", string.Empty, null, null, null),
                new(1, "Tecnico de Servicios Sociales a las Familias y las Comunidades Senior", string.Empty, null, null, null),
                new(1, "Tecnico en Sistemas de Informacion", string.Empty, null, null, null),
                new(1, "Tecnico en Sistemas en Oficina", string.Empty, null, null, null),
                new(1, "Trabajador de Conservacion", string.Empty, null, null, null),
                new(1, "Trabajador de Servicios Generales", string.Empty, null, null, null),
                new(1, "Trabajador Social", string.Empty, null, null, null),
                new(1, "Trabajador Social Senior", string.Empty, null, null, null),
                new(1, "Traductor Interprete", string.Empty, null, null, null),
                new(2, "CursoAprobado", string.Empty, null, null, null),
                new(2, "Dactilógrafo", string.Empty, null, null, null),
                new(2, "General", string.Empty, null, null, null),
                new(2, "Oficinista", string.Empty, null, null, null),
                new(2, "Oficinista de Contabilidad", string.Empty, null, null, null),
                new(2, "Otro", string.Empty, null, null, null),
                new(2, "Secretarial", string.Empty, null, null, null),
                new(4, "Ninguno", string.Empty, null, null, null),
                new(4, "No Vidente", string.Empty, null, null, null),
                new(4, "Otro", string.Empty, null, null, null),
                new(4, "Sordo", string.Empty, null, null, null),
                new(4, "Uso de Silla de Rueda", string.Empty, null, null, null),
                new(5, "Jornada Parcial", string.Empty, null, null, null),
                new(5, "Tiempo Completo", string.Empty, null, null, null),
                new(6, "Adjuntas", string.Empty, "PR", "PR", null),
                new(6, "Aguada", string.Empty, "PR", "PR", null),
                new(6, "Aguadilla", string.Empty, "PR", "PR", null),
                new(6, "Aguas Buenas", string.Empty, "PR", "PR", null),
                new(6, "Aguirre", string.Empty, "PR", "PR", null),
                new(6, "Aibonito", string.Empty, "PR", "PR", null),
                new(6, "Añasco", string.Empty, "PR", "PR", null),
                new(6, "Arecibo", string.Empty, "PR", "PR", null),
                new(6, "Arroyo", string.Empty, "PR", "PR", null),
                new(6, "Barceloneta", string.Empty, "PR", "PR", null),
                new(6, "Barranquitas", string.Empty, "PR", "PR", null),
                new(6, "Bayamón", string.Empty, "PR", "PR", null),
                new(6, "Cabo Rojo", string.Empty, "PR", "PR", null),
                new(6, "Caguas", string.Empty, "PR", "PR", null),
                new(6, "Camuy", string.Empty, "PR", "PR", null),
                new(6, "Carolina", string.Empty, "PR", "PR", null),
                new(6, "Cataño", string.Empty, "PR", "PR", null),
                new(6, "Cayey", string.Empty, "PR", "PR", null),
                new(6, "Ceiba", string.Empty, "PR", "PR", null),
                new(6, "Ciales", string.Empty, "PR", "PR", null),
                new(6, "Cidras", string.Empty, "PR", "PR", null),
                new(6, "Coamo", string.Empty, "PR", "PR", null),
                new(6, "Comerio", string.Empty, "PR", "PR", null),
                new(6, "Corozal", string.Empty, "PR", "PR", null),
                new(6, "Culebras", string.Empty, "PR", "PR", null),
                new(6, "Dorado", string.Empty, "PR", "PR", null),
                new(6, "Ensenada", string.Empty, "PR", "PR", null),
                new(6, "Fajardo", string.Empty, "PR", "PR", null),
                new(6, "Florida", string.Empty, "PR", "PR", null),
                new(6, "Guanica", string.Empty, "PR", "PR", null),
                new(6, "Guayama", string.Empty, "PR", "PR", null),
                new(6, "Guayanilla", string.Empty, "PR", "PR", null),
                new(6, "Guaynabo", string.Empty, "PR", "PR", null),
                new(6, "Gurabo", string.Empty, "PR", "PR", null),
                new(6, "Hatillo", string.Empty, "PR", "PR", null),
                new(6, "Hato Rey", string.Empty, "PR", "PR", null),
                new(6, "Hormigueros", string.Empty, "PR", "PR", null),
                new(6, "Humacao", string.Empty, "PR", "PR", null),
                new(6, "Isabela", string.Empty, "PR", "PR", null),
                new(6, "Jayuya", string.Empty, "PR", "PR", null),
                new(6, "Juana Diaz", string.Empty, "PR", "PR", null),
                new(6, "Juncos", string.Empty, "PR", "PR", null),
                new(6, "Lajas", string.Empty, "PR", "PR", null),
                new(6, "Lares", string.Empty, "PR", "PR", null),
                new(6, "Las Marias", string.Empty, "PR", "PR", null),
                new(6, "Las Piedras", string.Empty, "PR", "PR", null),
                new(6, "Loíza", string.Empty, "PR", "PR", null),
                new(6, "Luquillo", string.Empty, "PR", "PR", null),
                new(6, "Manatí", string.Empty, "PR", "PR", null),
                new(6, "Maricao", string.Empty, "PR", "PR", null),
                new(6, "Maunabo", string.Empty, "PR", "PR", null),
                new(6, "Mayaguez", string.Empty, "PR", "PR", null),
                new(6, "Moca", string.Empty, "PR", "PR", null),
                new(6, "Morovis", string.Empty, "PR", "PR", null),
                new(6, "Naguabo", string.Empty, "PR", "PR", null),
                new(6, "Naranjito", string.Empty, "PR", "PR", null),
                new(6, "Orocovis", string.Empty, "PR", "PR", null),
                new(6, "Patillas", string.Empty, "PR", "PR", null),
                new(6, "Peñuelas", string.Empty, "PR", "PR", null),
                new(6, "Ponce", string.Empty, "PR", "PR", null),
                new(6, "Puerto Nuevo", string.Empty, "PR", "PR", null),
                new(6, "Quebradillas", string.Empty, "PR", "PR", null),
                new(6, "Rincón", string.Empty, "PR", "PR", null),
                new(6, "Rio Grande", string.Empty, "PR", "PR", null),
                new(6, "Rio Piedras", string.Empty, "PR", "PR", null),
                new(6, "Sabana Grande", string.Empty, "PR", "PR", null),
                new(6, "Salinas", string.Empty, "PR", "PR", null),
                new(6, "San Germán", string.Empty, "PR", "PR", null),
                new(6, "San Juan", string.Empty, "PR", "PR", null),
                new(6, "San Lorenzo", string.Empty, "PR", "PR", null),
                new(6, "San Sebastián", string.Empty, "PR", "PR", null),
                new(6, "Santa Isabel", string.Empty, "PR", "PR", null),
                new(6, "Santurce", string.Empty, "PR", "PR", null),
                new(6, "Toa Alta", string.Empty, "PR", "PR", null),
                new(6, "Toa Baja", string.Empty, "PR", "PR", null),
                new(6, "Trujillo Alto", string.Empty, "PR", "PR", null),
                new(6, "Utuado", string.Empty, "PR", "PR", null),
                new(6, "Vega Alta", string.Empty, "PR", "PR", null),
                new(6, "Vega Baja", string.Empty, "PR", "PR", null),
                new(6, "Vieques", string.Empty, "PR", "PR", null),
                new(6, "Villalba", string.Empty, "PR", "PR", null),
                new(6, "Yabucoa", string.Empty, "PR", "PR", null),
                new(6, "Yauco", string.Empty, "PR", "PR", null),
                new(6, "Miami", string.Empty, "Florida", "USA", null),
                new(6, "Tampa", string.Empty, "Florida", "USA", null),
                new(6, "Melbourne", string.Empty, "Florida", "USA", null),
                new(6, "New York", string.Empty, "New York", "USA", null),
                new(6, "Buffalo", string.Empty, "New York", "USA", null),
                new(6, "Canovanas", string.Empty, "PR", "PR", null),
                new(6, "Jacksonville", string.Empty, "Florida", "USA", null),
                new(6, "Orlando", string.Empty, "Florida", "USA", null),
                new(6, "FORT BUCHANAN", string.Empty, "PR", "PR", null),
                new(6, "Levittown", string.Empty, "PR", "PR", null),
                new(6, "COTO LAUREL", string.Empty, "PR", "PR", null),
                new(7, "Aprendizaje", string.Empty, null, null, null),
                new(7, "Chofer", string.Empty, null, null, null),
                new(7, "Conductor", string.Empty, null, null, null),
                new(7, "Motocicleta", string.Empty, null, null, null),
                new(7, "Ninguna", string.Empty, null, null, null),
                new(7, "Vehículo Pesado", string.Empty, null, null, null),
                new(8, "BAG", "Bernardo Acevedo González", "Analista de Recursos Humanos", null, null),
                new(8, "CRN", "Carmín Rodríguez Negrón", "Directora", null, null),
                new(8, "JLF", "Jannette López Falcón", "Analista de Recursos Humanos", null, null),
                new(8, "VMM", "Victor Maldonado Martínez", "Director", null, null),
                new(8, "JPR", "Juan Perez Rodriguez", "Analista ASUME", null, null),
                new(8, "NCA", "Nancy Calderon Alicea", "Especialista Recursos Humanos", null, null),
                new(8, "GOV", "Gabriel Otero Valentin", "Analista ADSEF", null, null),
                new(8, "LSM", "Leslie Soto Matos", "Analista AMSCA", null, null),
                new(8, "SEC-GME", "Secretaria Gerencia", "Administrador", null, null),
                new(9, "Aceptada", string.Empty, null, null, null),
                new(9, "Denegada", string.Empty, null, null, null),
                new(9, "Devuelta", string.Empty, null, null, null),
                new(10, "M", string.Empty, null, null, null),
                new(10, "F", string.Empty, null, null, null),
                new(11, "Aguadilla", string.Empty, null, null, null),
                new(11, "Arecibo", string.Empty, null, null, null),
                new(11, "Caguas", string.Empty, null, null, null),
                new(11, "Carolina", string.Empty, null, null, null),
                new(11, "Humacao", string.Empty, null, null, null),
                new(11, "Bayamon", string.Empty, null, null, null),
                new(11, "Nivel Central", string.Empty, null, null, null),
                new(12, "Definicion Base", string.Empty, null, null, null),
                new(13, "Secretariado", string.Empty, null, null, null),
                new(13, "ADFAN", string.Empty, null, null, null),
                new(13, "ADSEF", string.Empty, null, null, null),
                new(13, "ASUME", string.Empty, null, null, null),
                new(13, "ACUDEN", string.Empty, null, null, null),
                new(16, "San Juan", string.Empty, "Area Metro", "PR", "Puerto Rico"),
                new(16, "Carolina", string.Empty, "Area Metro", "PR", "Puerto Rico"),
                new(16, "Arecibo", string.Empty, "Area Norte", "PR", "Puerto Rico"),
                new(16, "Ponce", string.Empty, "Area Sur", "PR", "Puerto Rico"),
                new(16, "Orange", string.Empty, "Central", "Florida", "Estados Unidos"),
                new(16, "New York City", string.Empty, "Greater City", "New York", "Estados Unidos"),
                new(17, "Segunda", string.Empty, null, null, null),
                new(17, "Primera", string.Empty, null, null, null),
                new(17, "Tercera", string.Empty, null, null, null),
                new(19, "Intermedio 8vo", string.Empty, null, null, null),
                new(19, "Superior 12vo", string.Empty, null, null, null),
                new(19, "Grado Asociado", string.Empty, null, null, null),
                new(19, "Bachillerato", string.Empty, null, null, null),
                new(19, "Maestria", string.Empty, null, null, null),
                new(19, "Doctorado", string.Empty, null, null, null),
                new(20, "Experiencia Empleo", string.Empty, null, null, null),
                new(20, "Cursos o Adiestramiento", string.Empty, null, null, null),
                new(20, "Identificacion", string.Empty, null, null, null),
                new(20, "Licencia o Certificado", string.Empty, null, null, null),
                new(20, "Referencia", string.Empty, null, null, null),
                new(20, "Certificado de antecedentes penales", string.Empty, null, null, null),
                new(20, "TRANSCRIPCION DE CREDITOS", string.Empty, null, null, null),
                new(20, "RESUME", string.Empty, null, null, null),
                new(20, "DIPLOMA UNIVERSITARIO", string.Empty, null, null, null),
                new(21, "Región", string.Empty, null, null, null),
                new(21, "Administración", string.Empty, null, null, null),
                new(21, "Finanzas", string.Empty, null, null, null),
                new(22, "Adminisrtrador", string.Empty, null, null, null),
                new(22, "UsuarioRegion", string.Empty, null, null, null),
                new(22, "Supervisor", string.Empty, null, null, null),
                new(22, "UsuarioLocal", string.Empty, null, null, null),
                new(22, "Finanzas", string.Empty, null, null, null),
                new(23, "Adminisrtrador", string.Empty, null, null, null),
                new(23, "Supervisor", string.Empty, null, null, null),
                new(23, "Usuarios", string.Empty, null, null, null),
                new(24, "Orientación", string.Empty, "Form_Referidos", "Referido", null),
                new(24, "Orientación y Referimiento", string.Empty, "Form_Referidos", "Referido", null),
                new(24, "Protección", string.Empty, "Form_Referidos", "Referido", null),
                new(24, "Servicio Protección", string.Empty, "Form_Estudio_Social", "Protección", null),
                new(24, "Servicio Protección", string.Empty, "Form_Notas_Progreso", "Protección", null),
                new(24, "Servicio Protección", string.Empty, "Form_Visita_Hogar", "Protección", null),
                new(25, "Comienzo Formulario", string.Empty, null, null, null),
                new(25, "Seguimiento Formulario", string.Empty, null, null, null),
                new(25, "Completar Formulario", string.Empty, null, null, null),
                new(26, "Validación Campos", "Validaciones Campos Requeridos", null, null, null),
                new(26, "Seguimiento Campos", "Validadcion de Segimiento cuando se completan todas se pasa proxima etapa", null, null, null),
                new(26, "Firmas Personal", "Proceso de Manejo de Firmas", null, null, null),
                new(26, "Continuar", "Definicion que Permite Guardar y Seguir adelante, solo para pruebas", null, null, null),
                new(27, "Requerido", "Tipo de Accion campos Requeridos", null, null, null),
                new(27, "Opcionales", "Tipo de Accion campos Opcionales, podrian ser marcados", null, null, null),
                new(28, "Fecha", string.Empty, null, null, null),
                new(28, "Texto", string.Empty, null, null, null),
                new(28, "Integro", string.Empty, null, null, null),
                new(28, "Narrativa", string.Empty, null, null, null),
                new(29, "FirmaTS", string.Empty, "14", null, null),
                new(29, "FirmaSup", string.Empty, "20", null, null),
                new(29, "FirmaDir", "Implementar Luego", null, null, null),
                new(29, "FirmaCliente", "Implementar Luego", null, null, null),
                new(29, "FirmaRegion", "Implementar Luego", null, null, null),
                new(29, "LargoMinimo", "Usar largo campo para determinar si cumple el tamano", null, null, null),
                new(29, "TieneValor", "Verificar Existe valor, Not string.Empty", null, null, null),
                new(29, "Fecha", "Entrada de Fecha", null, null, null),
                new(29, "Hora", "Entrada de Hora", null, null, null),
                new(29, "NumericoLargo", "Validar Numero con Tope", null, null, null),
                new(30, "Trabajador Social", "Definicion de TS para Trabajos de este Nivel", null, null, null),
                new(30, "Supervisor", "Definicion de Supervisor para Casos", null, null, null),
                new(31, "Sujeto Referido", "Adulto que es Referido", "Sujeto", null, null),
                new(31, "Refiere Adulto", "Persona que realiza Llamada o Refiere", null, null, null),
                new(31, "Contacto", string.Empty, null, null, null),
                new(31, "Familiar", "Familiares del Adulto", null, null, null),
                new(32, "Abuelo/a", string.Empty, null, null, null),
                new(32, "Padre", string.Empty, null, null, null),
                new(32, "Madre", string.Empty, null, null, null),
                new(32, "Hermano/a", string.Empty, null, null, null),
                new(32, "Hijo/a", string.Empty, null, null, null),
                new(32, "Nieto/a", string.Empty, null, null, null),
                new(32, "Esposo/a", string.Empty, null, null, null),
                new(32, "Primo/a", string.Empty, null, null, null),
                new(32, "Tio/a", string.Empty, null, null, null),
                new(32, "Otro", string.Empty, null, null, null),
                new(33, "Ayuda del PAN", string.Empty, "Economica", null, null),
                new(33, "Ayuda de TANF", string.Empty, "Economica", null, null),
                new(33, "Ama de Llaves", string.Empty, "Hogar", null, null),
                new(33, "Alimentacion", string.Empty, "Hogar", null, null),
                new(33, "Terapias Fisica", string.Empty, "Hogar", null, null),
                new(33, "Visitas Medica", string.Empty, "Terapias", null, null),
                new(34, "Aceptado", string.Empty, "YES", null, null),
                new(34, "Rechazado", string.Empty, "NO", null, null),
                new(34, "Cliente no Acepto Servicio", string.Empty, "NO", null, null),
                new(34, "Referido", string.Empty, "NO", null, null),
                new(34, "Coordinar Servicios", string.Empty, "YES", null, null),
                new(34, "En Proceso de Completar Informacion", string.Empty, "NO", null, null),
                new(35, "Sin Antecedentes", string.Empty, null, null, null),
                new(35, "Con Antecedentes", string.Empty, null, null, null),
                new(36, "Emergencia", string.Empty, null, null, null),
                new(36, "Urgente", string.Empty, null, null, null),
                new(36, "Periodo Reglamentario", string.Empty, null, null, null),
                new(37, "Aguadilla", string.Empty, "Aguadilla I", null, null),
                new(37, "Arecibo", string.Empty, "Arecibo", null, null),
                new(37, "Bayamon", string.Empty, "Bayamon I", null, null),
                new(37, "Caguas", string.Empty, "Caguas I", null, null),
                new(37, "Carolina", string.Empty, "Carolina I", null, null),
                new(37, "Guayama", string.Empty, "Guayama", null, null),
                new(37, "Humacao", string.Empty, "HUmacao", null, null),
                new(37, "Mayaguez", string.Empty, "Mayaguez", null, null),
                new(37, "Ponce", string.Empty, "Ponce", null, null),
                new(37, "San Juan", string.Empty, "San Juan I", null, null),
                new(37, "San Juan", string.Empty, "Guaynabo", null, null),
                new(37, "Aguadilla", string.Empty, "Isabela", null, null),
                new(37, "Aguadilla", string.Empty, "Moca", null, null),
                new(37, "Aguadilla", string.Empty, "San Sebastian", null, null),
                new(38, "El Adulto", string.Empty, null, null, null),
                new(38, "La Familia", string.Empty, null, null, null),
                new(39, "CAMPEA Lares", string.Empty, null, null, null),
                new(39, "CAMPEA Caguas", string.Empty, null, null, null),
                new(39, "Region Caguas", string.Empty, null, null, null),
                new(39, "Region Aguadilla", string.Empty, null, null, null),
                new(39, "Region Arecibo", string.Empty, null, null, null),
                new(39, "Centro Integrado Morovis", string.Empty, null, null, null),
                new(39, "CAMPEA Aguas Buenas", string.Empty, null, null, null),
            ];

            // Join the dictionaries
            IList<AdmParametrosSeleccionInsertDto> valuePairsParamAdmParametrosSeleccion = [
                .. valuePairsParamAdmParametrosSeleccionClasificacionEmpleados,
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
                Activo = true,
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now,
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

        private static void PouplateFlujosFormularios(ModelBuilder modelBuilder)
        {

            IList<AdmFlujoFormularioInsertDto> admFlujoFormularios = [
                new ("Orientación", "Referido Orientación", "Form_Referidos", 1, "Referido", null, "Orientación de Clientes", null, null),
                new ("Orientación y Referimiento", "Referido Orientación y Referimiento", "Form_Referidos", 2, "Orientación", null, "Orientació y Referimiento de Clientes", null, null),
                new ("Protección", "Referido de Protección", "Form_Referidos", 1, "Referido", null, "Evaluacion de Protección Social", null, null),
                new ("Servicios Proteccion", "Estudio Social", "Form_Estudio_Social", 2, "Protección", null, "Servicio de Protección Estudio Social", null, null),
                new ("Servicios Proteccion", "Notas de Progreso", "Form_Notas_Progreso", 3, "Protección", null, null, null, null),
                new ("Servicios Proteccion", "Visitas al Hogar", "Form_Visita_Hogar", 3, "Protección", null, null, null, null),
            ];

            IList<AdmFlujoFormulario> admFlujos = admFlujoFormularios.Select((x, i) => new AdmFlujoFormulario
            {
                FormularioId = i + 1,
                TipoCaso = x.TipoCaso,
                Formulario = x.Formulario,
                TablaBase = x.TablaBase,
                Descripcion = x.Descripcion,
                OrdenFormulario = x.OrdenFormulario,
                NivelCaso = x.NivelCaso,
                TXFiltro1 = x.TXFiltro1,
                TXFiltro2 = x.TXFiltro2,
                TXFiltro3 = x.TXFiltro3
            }).ToList();
            modelBuilder.Entity<AdmFlujoFormulario>().HasData(admFlujos);

            IList<AdmFlujoFormularioEtapaInsertDto> admFlujoFormularioEtapas = [
                new(1,"Referido Nuevo",1,"Comienzo Formulario","#f7f72f", false,false, null, null, null),
                new(1,"Referido Seguimiento",2,"Seguimiento Formulario","#3c7efa", false,false, null, null, null),
                new(1,"Referido Firma TS",3,"Seguimiento Formulario","#8c57f7", false,false, null, null, 1),
                new(1,"Referido Firma Sup",4,"Completar Formulario",null, false,false, null, null, null),
            ];

            IList<AdmFlujoFormularioEtapa> admFlujoFormularioEtapa = admFlujoFormularioEtapas.Select((x, i) => new AdmFlujoFormularioEtapa
            {
                FormularioEtapaId = i + 1,
                FormularioId = x.FormularioId,
                NombreEtapa = x.NombreEtapa,
                OrdenEtapa = x.OrdenEtapa,
                TipoEtapa = x.TipoEtapa,
                ColorEtapa = x.ColorEtapa,
                Completado = x.Completado,
                Concurrencia = x.Concurrencia,
                ConcurrenciaEtapa = x.ConcurrenciaEtapa,
                NotaStartId = x.NotaStartId,
                NotaEndId = x.NotaEndId,
                Activo = true,
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now,
            }).ToList();
            modelBuilder.Entity<AdmFlujoFormularioEtapa>().HasData(admFlujoFormularioEtapa);

            IList<AdmFlujoFormularioNotaInsertDto> admFlujoFormularioNotas = [
                new(1, "Aviso Supervisor", "Aviso Supervisor Firma Completada por Trabajador Social", "Para el Formulario de Referido se completo la firma de Trabajador Social", "Mensaje Atado con Datos del Referido segun ID del Formulario", 14)
            ];

            IList<AdmFlujoFormularioNota> admFlujoFormularioNota = admFlujoFormularioNotas.Select((x, i) => new AdmFlujoFormularioNota
            {
                FormularioNotaId = i + 1,
                FormularioId = x.FormularioId,
                TXNombreNota = x.TXNombreNota,
                TXDescripcion = x.TXDescripcion,
                TXSubject = x.TXSubject,
                TXMensaje = x.TXMensaje,
                TipoUsuarioId = x.TipoUsuarioId,
            }).ToList();
            modelBuilder.Entity<AdmFlujoFormularioNota>().HasData(admFlujoFormularioNota);

            IList<AdmFlujoPantallaUserInsertDto> admFlujoPantallaUsers = [
                new(1, 1, "Trabajador Social", 14, DateTime.Now, null),
                new(2, 1, "Trabajador Social", 14, DateTime.Now, null),
                new(3, 1, "Trabajador Social", 14, DateTime.Now, null),
                new(4, 1, "Supervidor", 20, DateTime.Now, null),
            ];

            IList<AdmFlujoPantallaUser> admFlujoPantallaUser = admFlujoPantallaUsers.Select((x, i) => new AdmFlujoPantallaUser
            {
                FlujoUserID = i + 1,
                FormularioEtapaId = x.FormularioEtapaId,
                Prioridad = x.Prioridad,
                UserType = x.UserType,
                GroupTypeId = x.GroupTypeId,
                FechaFin = x.FechaFin,
            }).ToList();
            modelBuilder.Entity<AdmFlujoPantallaUser>().HasData(admFlujoPantallaUser);

            IList<AdmFlujoFormularioEtapaAccionInsertDto> admFlujoFormularioEtapaAccions = [
                new(1, "Validacion Campos", 1, "Validación Campos", "Requerido", true, false, null),
                new(2, "Determinacion Referido", 1, "Seguimiento Campos", "Requerido", true, false, null),
                new(3, "Firmas Personal TS", 1, "Firmas Personal", "Requerido", true, false, null),
                new(4, "Firmas Personal Supervisor", 1, "Firmas Personal", "Requerido", true, false, null),
            ];

            IList<AdmFlujoFormularioEtapaAccion> admFlujoFormularioEtapaAccion = admFlujoFormularioEtapaAccions.Select((x, i) => new AdmFlujoFormularioEtapaAccion
            {
                FormularioEtapaAccionId = i + 1,
                FormularioEtapaId = x.FormularioEtapaId,
                NombreAccion = x.NombreAccion,
                OrdenAccion = x.OrdenAccion,
                TipoAccion = x.TipoAccion,
                TipoProceso = x.TipoProceso,
                Completado = x.Completado,
                Concurrencia = x.Concurrencia,
                ConcurrenciaAccionId = x.ConcurrenciaAccionId,
                Activo = true,
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now,
            }).ToList();
            modelBuilder.Entity<AdmFlujoFormularioEtapaAccion>().HasData(admFlujoFormularioEtapaAccion);

            IList<AdmFlujoFormularioEtapaAccionCampoInsertDto> admFlujoFormularioEtapaAccionCampos = [
                new(1, 1, "Fecha Referido", "Form_Referidos", "Fecha", 0, "FechaRecibo", "TieneValor", "Fecha del Referido es requerida para continuar.", null),
                new(1, 2, "Hora Referido", "Form_Referidos", "Fecha", 0, "HoraRecibo", "TieneValor", "La Hora del Referido es requerida.", null),
                new(1, 3, "Narrativa Situacion", "Form_Referidos", "Texto", 40, "NarrativaSituacion", "LargoMinimo", "La Narrativa de la Situacion debe ser al menos de 40 caracteres.", null),
                new(1, 4, "Region", "Form_Referidos", "Texto", 0, "Region", "TieneValor", "La region es requerida para construir el RMO.", null),
                new(1, 5, "Local", "Form_Referidos", "Texto", 0, "Local", "TieneValor", "El local es requerido para construir el RMO.", null),

                new(2, 1, "Determinacion", "Form_Referidos", "Texto", 0, "Determinacion", "TieneValor", "Debe Completar la Determinacion para Continuar con las Firmas", "La Determinacion aun no esta llena para continuar con el Referido."),
                new(2, 2, "Determinacion_Fecha", "Form_Referidos", "Fecha", 0, "DeterminacionFecha", "TieneValor", "Debe Completar la Fecha de la Determinacion para Continuar con las Firmas", "La Fecha Determinacion aun no esta llena para continuar con el Referido."),
                new(2, 3, "Determinacion_Razon", "Form_Referidos", "Texto", 0, "DeterminacionRazon", "TieneValor", "Debe Completar la Razón de la Determinacion para poder Firmar", "La Razón Determinacion aun no esta llena para continuar con el Referido."),

                new(3, 1, "Firma TS", "Form_FormulariosFirmas", "Texto", 0, "UsuarioId", "FirmaTS", "La Firma del Trabajador Social debe estar Completada", null),
                new(3, 1, "Firma TS", "Form_FormulariosFirmas", "Texto", 0, "UserTypeID", "FirmaTS", "Validacion Principal para Busqueda de Usuario Firmo", null),
                new(3, 1, "Firma TS", "Form_FormulariosFirmas", "Texto", 0, "RMO", "FirmaTS", "La Firma del Supervisor de Trabajador Social debe estar Completada", null),
                //new(3, 1, "RMO", "Form_Referidos", "Texto", 0, "RMO", "TieneValor", "Rmo es requerido", null),

                new(4, 1, "Firma Supervisor", "Form_FormulariosFirmas", "Integro", 0, "UserTypeID", "FirmaSup", "La Firma del Supervisor de Trabajador Social debe estar Completada", null),
            ];

            IList<AdmFormularioEtapaAccioneCampo> admFlujoFormularioEtapaAccionCampo = admFlujoFormularioEtapaAccionCampos.Select((x, i) => new AdmFormularioEtapaAccioneCampo
            {
                FormularioEtapaAccionCampoId = i + 1,
                FormularioEtapaAccionId = x.FormularioEtapaAccionId,
                OrdenAccion = x.OrdenAccion,
                CampoDB = x.CampoDB,
                TablaBase = x.TablaBase,
                CampoDBTipo = x.CampoDBTipo,
                CampoDBLongitud = x.CampoDBLongitud,
                CampoDBIDField = x.CampoDBIDField,
                TipoProcesoCampo = x.TipoProcesoCampo,
                Resultado = x.Resultado,
                Descripcion = x.Descripcion,
            }).ToList();
            modelBuilder.Entity<AdmFormularioEtapaAccioneCampo>().HasData(admFlujoFormularioEtapaAccionCampo);

        }

        private static void DummyFlujoPantallas(ModelBuilder modelBuilder)
        {
            IList<FormFlujoPantallaInsertDto> formFlujoPantallas = [
                new(1,1,1,"Referido Nuevo", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0001", null, "Maria Santiago", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Comienzo Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(1,1,2,"Referido Seguimiento", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0001", null, "Maria Santiago", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(1,1,3,"Referido Seguimiento", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0001", null, "Maria Santiago", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(2,2,1,"Referido Nuevo", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0002", null, "Manuel Torres", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Comienzo Formulario", null, null, false, "Bayamon", "Bayamon"),
                new(2,2,2,"Referido Seguimiento", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0002", null, "Manuel Torres", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Bayamon", "Bayamon"),
                new(3,3,1,"Referido Nuevo", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0003", null, "Jaime Sepulveda", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Comienzo Formulario", null, null, false, "Bayamon", "Bayamon"),
                new(3,3,2,"Referido Seguimiento", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0003", null, "Jaime Sepulveda", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Bayamon", "Bayamon"),
                new(3,3,3,"Referido Firma TS", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0003", null, "Jaime Sepulveda", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Bayamon", "Bayamon"),
                new(1,4,1,"Referido Nuevo", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0004", null, "John Martinez", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Comienzo Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(1,4,2,"Referido Seguimiento", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0004", null, "John Martinez", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(1,4,3,"Referido Firma TS", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0004", null, "John Martinez", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Seguimiento Formulario", null, null, false, "Aguadilla", "Aguadilla"),
                new(1,4,4,"Referido Firma Sup", DateTime.Now, "03334448-73b4-438f-8fdf-784dbab58150", "03-0301-0004", null, "John Martinez", "03334448-73b4-438f-8fdf-784dbab58150", "03334448-73b4-438f-8fdf-784dbab58151", "Completar Formulario", null, null, true, "Aguadilla", "Aguadilla"),
            ];

            IList<FormFlujoPantalla> formFlujoPantalla = formFlujoPantallas.Select((x, i) => new FormFlujoPantalla
            {
                FlujoPantallaId = i + 1,
                FormularioId = x.FormularioId,
                FormaId = x.FormaId,
                OrdenEtapa = x.OrdenEtapa,
                FlujoEtapa = x.FlujoEtapa,
                FechaFlujo = x.FechaFlujo,
                UsuarioFlujoId = x.UsuarioFlujoId,
                RMO = x.RMO,
                NumeroCaso = x.NumeroCaso,
                Persona = x.Persona,
                UsuarioAsignaId = x.UsuarioAsignaId,
                UsuarioAsignadoId = x.UsuarioAsignadoId,
                FlujoStatus = x.FlujoStatus,
                Notas = x.Notas,
                Comentarios = x.Comentarios,
                EtapaCompletada = x.EtapaCompletada,
                Region = x.Region,
                Local = x.Local,
            }).ToList();

            modelBuilder.Entity<FormFlujoPantalla>().HasData(formFlujoPantalla);


            IList<FormReferidoInsertDto> formReferidos = [
                new("03-0301-0001", null, "Orientación", DateTime.Now, DateTime.Now, null, "Narrativa de Caso de Orientacion por el TS", "03334448-73b4-438f-8fdf-784dbab58150", "Madre", null, null, null, "Coordinar Servicios", DateTime.Now, "Determinacion para Orientacion", "Aguadilla", "Aguadilla I", null, null, null, null, null, "Esta solicitud es para referir al Fondo el beneficiario", null),
                new("03-0301-0002", null, "Orientación y Referimiento", DateTime.Now, DateTime.Now, null, "Narrativa de Caso de Orientacion por el TS y Supervisro", "03334448-73b4-438f-8fdf-784dbab58150", "Padre", "Visitas Medica", DateTime.Now, null, "Referido", DateTime.Now, "Determinacion para Referir a Agencia", "Bayamon", "Bayamon ", null, null, null, 1, "El Adulto", "Esta solicitud es para referir al Fondo el beneficiario", null),
                new("03-0301-0003", null, "Protección", DateTime.Now, DateTime.Now, null, "Narrativa de Caso de Proteccion", "03334448-73b4-438f-8fdf-784dbab58150", "Padre", null, null, "Sin Antecedentes", "Aceptado", DateTime.Now, "Determinacion para Referir a Agencia", "Bayamon", "Bayamon ", "Urgente", "CAMPEA Aguas Buenas", "Personal Administrativo", null, null, null, null),
                new("03-0301-0004", null, "Orientación", DateTime.Now, DateTime.Now, null, "Narrativa de Caso de Orientacion por el TS", "03334448-73b4-438f-8fdf-784dbab58150", "Abuelo", null, null, null, "Coordinar Servicios", DateTime.Now, "Determinacion para Orientacion", "Aguadilla", "Aguadilla I", null, null, null, null, null, null, null),
            ];

            IList<FormReferido> formReferido = formReferidos.Select((x, i) => new FormReferido
            {
                ReferidoId = i + 1,
                RMO = x.RMO,
                CasoId = x.CasoId,
                TipoReferido = x.TipoReferido,
                FechaRecibo = x.FechaRecibo,
                HoraRecibo = x.HoraRecibo,
                AccionTomada = x.AccionTomada,
                NarrativaSituacion = x.NarrativaSituacion,
                ReferidoPor = x.ReferidoPor,
                RelacionAdulto = x.RelacionAdulto,
                ServicioSolicitado = x.ServicioSolicitado,
                ServicioFechaNotificacion = x.ServicioFechaNotificacion,
                Antecedentes = x.Antecedentes,
                Determinacion = x.Determinacion,
                DeterminacionFecha = x.DeterminacionFecha,
                DeterminacionRazon = x.DeterminacionRazon,
                AsignacionRegion = x.AsignacionRegion,
                AsignacionOficina = x.AsignacionOficina,
                Clasificacion = x.Clasificacion,
                OrigenReferido = x.OrigenReferido,
                AsignacionReferido = x.AsignacionReferido,
                AgenciaId = x.AgenciaId,
                AgenciaSolicitadoPara = x.AgenciaSolicitadoPara,
                AgenciaSolicitud = x.AgenciaSolicitud,
                ReferidoOrgenId = x.ReferidoOrgenId,
                CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                CreateDate = DateTime.Now
            }).ToList();

            modelBuilder.Entity<FormReferido>().HasData(formReferido);

            IList<FormFormularioFirmaInsertDto> formFormularioFirmas = [
                new (3,3,3,"03-0301-0003", null, "03334448-73b4-438f-8fdf-784dbab58150", "69e6dd63-c624-4c4a-8bf4-c910148367ad", DateTime.Now, "Bayamon", "Bayamon", "Ninguno", false, null,null),
                new (4,3,4,"03-0301-0004", null, "03334448-73b4-438f-8fdf-784dbab58150", "69e6dd63-c624-4c4a-8bf4-c910148367ad", DateTime.Now, null, null, "Comntario de TS", false, null,null),
                new (4,4,4,"03-0301-0004", null, "03334448-73b4-438f-8fdf-784dbab58150", "69e6dd63-c624-4c4a-8bf4-c910148367ad", DateTime.Now, null, null, "Comentario Supervisor", false, null,null),
            ];

            IList<FormFormularioFirma> formFormularioFirmas1 = formFormularioFirmas.Select((x, i) => new FormFormularioFirma
            {
                FormularioFirmasId = i + 1,
                FormularioId = x.FormularioId,
                FormularioEtapaId = x.FormularioEtapaId,
                FormaId = x.FormaId,
                Rmo = x.Rmo,
                NumCaso = x.NumCaso,
                UsuarioId = x.UsuarioId,
                UserTypeID = x.UserTypeID,
                FechaFirma = x.FechaFirma,
                Region = x.Region,
                Local = x.Local,
                Comentarios = x.Comentarios,
                Revertida = x.Revertida,
                RevertidaFecha = x.RevertidaFecha,
                UsuarioRevierteId = x.UsuarioRevierteId,
            }).ToList();

            modelBuilder.Entity<FormFormularioFirma>().HasData(formFormularioFirmas1);

        }
    }
}
