using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Models.SystemConfiguration;

namespace PRAMS.Infraestructure.Data.SystemConfiguration
{
    public class AppConfigDbContext(DbContextOptions<AppConfigDbContext> options) : DbContext(options)
    {
        public DbSet<AdmParametroCategoria> AdmParamCategories { get; set; }

        public DbSet<AdmParametrosSeleccion> AdmParamSelections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PouplateParametroCategoria(modelBuilder);
            PopulateAdmParametrosSeleccion(modelBuilder);
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
    }
}
