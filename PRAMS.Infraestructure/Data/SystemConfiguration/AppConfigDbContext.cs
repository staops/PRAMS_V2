using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Models.SystemConfiguration;

namespace PRAMS.Infraestructure.Data.SystemConfiguration
{
    public class AppConfigDbContext(DbContextOptions<AppConfigDbContext> options) : DbContext(options)
    {
        public DbSet<AdmParametroCategoria> AdmParamCategories { get; set; }

        public DbSet<AdmParametrosSeleccion> AdmParamSelections { get; set; }

        public DbSet<AdmMenuElements> AdmMenuElements { get; set; }

        public DbSet<AdmMenuRole> AdmMenuRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PouplateParametroCategoria(modelBuilder);
            PopulateAdmParametrosSeleccion(modelBuilder);
            PopulateAdmMenuElements(modelBuilder);
            PopulateAdmMenuRole(modelBuilder);
        }

        private static void PouplateParametroCategoria(ModelBuilder modelBuilder)
        {

            IList<AdmParametroCategoria> admParametros =
            [
                new()
                {
                    CategoriaID = 1,
                    Categoria = "Clasificacion Empleados",
                    Descripcion = "Clasificaciones",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 2,
                    Categoria = "Curso Aprobado",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 3,
                    Categoria = "Curso Aprobado Demo",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = false
                },
                new ()
                {
                    CategoriaID = 4,
                    Categoria = "Tipo Impedimento",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    CategoriaID = 5,
                    Categoria = "Tipo Nombramiento",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    CategoriaID = 6,
                    Categoria = "Pueblos",
                    Descripcion = "Def Pueblos con Dos Niveles de Filtros",
                    TX_Filtro1_Nombre = "Estado",
                    TX_Filtro2_Nombre = "Pais",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 7,
                    Categoria = "Categoria Licencias",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 8,
                    Categoria = "Firmas",
                    Descripcion = string.Empty,
                    TX_Filtro1_Nombre = "Posición / Puesto",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 9,
                    Categoria = "Acciones",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 10,
                    Categoria = "Genero",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 11,
                    Categoria = "Region",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 12,
                    Categoria = "Tipo Convocatoria",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 13,
                    Categoria = "Dependencias",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 14,
                    Categoria = "Dependencias2",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = false
                },
                new()
                {
                    CategoriaID = 15,
                    Categoria = "Dependencias3",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = false
                },
                new()
                {
                    CategoriaID = 16,
                    Categoria = "Entidades Municipio",
                    Descripcion = "Def Municipios Tres Niveles Ejemplo",
                    TX_Filtro1_Nombre = "Region",
                    TX_Filtro2_Nombre = "Estado",
                    TX_Filtro3_Nombre = "Pais",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 17,
                    Categoria = "Cantidad Solicitudes",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 18,
                    Categoria = "Cantidad Solicitudes2",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = false
                },
                new()
                {
                    CategoriaID = 19,
                    Categoria = "Grados Academicos",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 20,
                    Categoria = "Tipo de Documentos",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 21,
                    Categoria = "Tipo Reportes",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 22,
                    Categoria = "RolesReportes",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    CategoriaID = 23,
                    Categoria = "RolesMenu",
                    Descripcion = string.Empty,
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                }

            ];


            modelBuilder.Entity<AdmParametroCategoria>().HasData(admParametros);


        }

        private static void PopulateAdmParametrosSeleccion(ModelBuilder modelBuilder)
        {
            IList<AdmParametrosSeleccion> admParametrosSeleccions =
            [
                new()
                {
                    ParamterosID = 1,
                    CategoriaID = 1,
                    Parametro = "Empleado",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 2,
                    CategoriaID = 1,
                    Parametro = "Empleado Temporal",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 3,
                    CategoriaID = 1,
                    Parametro = "Empleado Contratado",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 4,
                    CategoriaID = 1,
                    Parametro = "Empleado de Carrera",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 5,
                    CategoriaID = 1,
                    Parametro = "Empleado de Confianza",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 6,
                    CategoriaID = 1,
                    Parametro = "Empleado de Base",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                }
            ];

            modelBuilder.Entity<AdmParametrosSeleccion>().HasData(admParametrosSeleccions);

            IList<AdmParametrosSeleccion> entdParametrosSeleccions =
            [
                new()
                {
                    ParamterosID = 7,
                    CategoriaID = 16,
                    Parametro = "San Juan",
                    TX_Filtro1 = "Area Metro",
                    TX_Filtro2 = "PR",
                    TX_Filtro3 = "Puerto Rico",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 8,
                    CategoriaID = 16,
                    Parametro = "Carolina",
                    TX_Filtro1 = "Area Metro",
                    TX_Filtro2 = "PR",
                    TX_Filtro3 = "Puerto Rico",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 9,
                    CategoriaID = 16,
                    Parametro = "Arecibo",
                    TX_Filtro1 = "Area Norte",
                    TX_Filtro2 = "PR",
                    TX_Filtro3 = "Puerto Rico",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new()
                {
                    ParamterosID = 10,
                    CategoriaID = 16,
                    Parametro = "Ponce",
                    TX_Filtro1 = "Area Sur",
                    TX_Filtro2 = "PR",
                    TX_Filtro3 = "Puerto Rico",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 11,
                    CategoriaID = 16,
                    Parametro = "Orange",
                    TX_Filtro1 = "Central",
                    TX_Filtro2 = "Florida",
                    TX_Filtro3 = "Estados Unidos",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 12,
                    CategoriaID = 16,
                    Parametro = "New York City",
                    TX_Filtro1 = "Greater City",
                    TX_Filtro2 = "New York",
                    TX_Filtro3 = "Estados Unidos",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
            ];

            modelBuilder.Entity<AdmParametrosSeleccion>().HasData(entdParametrosSeleccions);

            IList<AdmParametrosSeleccion> firmasParametrosSeleccions =
            [
                new ()
                {
                    ParamterosID = 13,
                    CategoriaID = 8,
                    Parametro = "BAG",
                    Descripcion = "Bernardo Acevedo González",
                    TX_Filtro1 = "Analista de Recursos Humanos",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 14,
                    CategoriaID = 8,
                    Parametro = "CRN",
                    Descripcion = "Carmín Rodríguez Negrón",
                    TX_Filtro1 = "Directora",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 15,
                    CategoriaID = 8,
                    Parametro = "JLF",
                    Descripcion = "Jannette López Falcón",
                    TX_Filtro1 = "Analista de Recursos Humanos",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 16,
                    CategoriaID = 8,
                    Parametro = "VMM",
                    Descripcion = "Victor Maldonado Martínez",
                    TX_Filtro1 = "Director",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 17,
                    CategoriaID = 8,
                    Parametro = "JPR",
                    Descripcion = "Juan Perez Rodriguez",
                    TX_Filtro1 = "Analista ASUME",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 18,
                    CategoriaID = 8,
                    Parametro = "NCA",
                    Descripcion = "Nancy Calderon Alicea",
                    TX_Filtro1 = "Especialista Recursos Humanos",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 19,
                    CategoriaID = 8,
                    Parametro = "GOV",
                    Descripcion = "Gabriel Otero Valentin",
                    TX_Filtro1 = "Analista ADSEF",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 20,
                    CategoriaID = 8,
                    Parametro = "LSM",
                    Descripcion = "Leslie Soto Matos",
                    TX_Filtro1 = "Analista AMSCA",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },
                new ()
                {
                    ParamterosID = 21,
                    CategoriaID = 8,
                    Parametro = "SEC-GME",
                    Descripcion = "Secretaria Gerencia",
                    TX_Filtro1 = "Administrador",
                    CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    CreateDate = DateTime.Now,
                    Activo = true
                },

            ];

            modelBuilder.Entity<AdmParametrosSeleccion>().HasData(firmasParametrosSeleccions);
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
                }

            ];

            modelBuilder.Entity<AdmMenuElements>().HasData(admMenuElements);

        }

        private static void PopulateAdmMenuRole(ModelBuilder modelBuilder)
        {
            IList<AdmMenuRole> admMenuElements = [
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
                }

            ];

            modelBuilder.Entity<AdmMenuRole>().HasData(admMenuElements);
        }
    }
}
