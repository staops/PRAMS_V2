using Microsoft.EntityFrameworkCore;
using PRAMS.Domain.Models.Agencies;
using PRAMS.Domain.Models.People;

namespace PRAMS.Infraestructure.Data.People
{
    public class AppPeopleDbContext(DbContextOptions<AppPeopleDbContext> options) : DbContext(options)
    {
        // List of random names
        private static readonly IList<string> names = new List<string> { "Juan", "Maria", "Pedro", "Jose", "Luis", "Ana", "Rosa", "Carlos", "Jorge", "Ricardo", "Fernando", "Miguel", "Raul", "Sofia", "Laura", "Diana", "Elena", "Lorena", "Luisa", "Rosa", "Carmen", "Rocio", "Rosa", "Luz", "Lourdes", "Liliana", "Leticia", "Liz", "Lidia", "Lilia", "Liliana", "Lorena", "Lourdes", "Luz", "Luz Maria", "Luz Elena" };
        // List of random last names
        private static readonly IList<string> lastNames = new List<string> { "Perez", "Gonzalez", "Lopez", "Hernandez", "Garcia", "Martinez", "Gomez", "Jimenez", "Torres", "Diaz", "Reyes", "Ramirez", "Vazquez", "Rojas", "Santos", "Suarez", "Silva", "Salazar", "Soto", "Sosa", "Serrano", "Santana", "Sandoval", "Saucedo", "Santillan", "Santibañez", "Santacruz", "Santana", "Santamaria", "Santana", "Santillana", "Santoyo", "Santos" };
        // List of random cities of PR
        private static readonly IList<string> cities = new List<string> { "San Juan", "Bayamon", "Carolina", "Ponce", "Caguas", "Guaynabo", "Mayaguez", "Trujillo Alto", "Arecibo", "Fajardo", "Vega Alta", "Vega Baja", "Toa Baja", "Toa Alta", "Dorado", "Cataño", "Cidra", "Cayey", "Aguadilla", "Aguada", "Aguas Buenas", "Aibonito", "Anasco", "Arroyo", "Barceloneta", "Barranquitas", "Cabo Rojo", "Caguas", "Camuy", "Canovanas", "Carolina", "Catano", "Cayey", "Ceiba", "Ciales", "Cidra", "Coamo", "Comerio", "Corozal", "Culebra", "Dorado", "Fajardo", "Florida", "Guanica", "Guayama", "Guayanilla", "Guaynabo", "Gurabo", "Hatillo", "Hormigueros", "Humacao", "Isabela", "Jayuya", "Juana Diaz", "Juncos", "Lajas", "Lares", "Las Marias", "Las Piedras" };
        // List of random genders
        private static readonly IList<string> genders = new List<string> { "Masculino", "Femenino", "Otro" };
        // List of random marital status
        private static readonly IList<string> maritalStatus = new List<string> { "Soltero", "Casado", "Divorciado", "Viudo" };
        // List of random religions
        private static readonly IList<string> religions = new List<string> { "Catolica", "Cristiana", "Testigo de Jehova", "Mormon", "Ateo", "Agnostico", "Otro" };
        // List of random relationship
        private static readonly IList<string> relationships = new List<string> { "Padre", "Madre", "Hijo", "Hija", "Abuelo", "Abuela", "Tio", "Tia", "Primo", "Prima", "Sobrino", "Sobrina", "Hermano", "Hermana", "Esposo", "Esposa", "Novio", "Novia", "Amigo", "Amiga", "Conocido", "Conocida", "Vecino", "Vecina", "Compañero", "Compañera", "Jefe", "Jefa", "Empleado", "Empleada", "Cliente", "Cliente", "Proveedor", "Proveedor", "Doctor", "Doctora", "Enfermero", "Enfermera", "Paciente", "Paciente", "Estudiante", "Estudiante", "Maestro", "Maestra", "Director", "Directora", "Gerente", "Gerente", "Dueño", "Dueña", "Inquilino", "Inquilina", "Arrendador", "Arrendadora", "Arrendatario", "Arrendataria", "Propietario", "Propietaria", "Otro" };
        // List of random ocupations
        private static readonly IList<string> ocupations = new List<string> { "Empleado", "Ama de casa", "Estudiante", "Desempleado", "Jubilado", "Otro" };
        // List of random escolarities
        private static readonly IList<string> escolarities = new List<string> { "Primaria", "Secundaria", "Preparatoria", "Licenciatura", "Maestria", "Doctorado", "Otro" };
        // List of random raza
        private static readonly IList<string> razas = new List<string> { "Blanca", "Negra", "Morena", "Amarilla", "Otra" };
        // List of random etnias
        private static readonly IList<string> etnias = new List<string> { "Mexicana", "Estadounidense", "Canadiense", "Europea", "Asiatica", "Africana", "Otra" };
        // List of random tipos de ingresos
        private static readonly IList<string> tiposIngresos = new List<string> { "Salario", "Comision", "Bonos", "Otro" };
        // List of random tipos de direcciones
        private static readonly IList<string> tiposDirecciones = new List<string> { "Casa", "Trabajo", "Otro" };
        // List of random titles
        private static readonly IList<string> titles = new List<string> { "Sr.", "Sra.", "Dr.", "Lic.", "Ing.", "Arq.", "C.P.", "Mtro.", "Mtra.", "Dra" };



        public DbSet<Persona> personas { get; set; }
        public DbSet<PersonasIngreso> personasIngreso { get; set; }
        public DbSet<PersonasIngresosDetalle> personasIngresoDetalle { get; set; }
        public DbSet<PersonasDireccion> personasDirecciones { get; set; }
        public DbSet<PersonasLink> personasLinks { get; set; }
        public DbSet<Agencia> agencias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Persona>().HasMany(p => p.PersonasDirecciones).WithOne(d => d.Persona).HasForeignKey(d => d.PersonaId);
            modelBuilder.Entity<Persona>().HasMany(p => p.PersonasLinks).WithOne(l => l.Persona).HasForeignKey(l => l.PersonaId);
            modelBuilder.Entity<Persona>().HasOne(p => p.PersonasIngresos).WithOne(i => i.Persona).HasForeignKey<PersonasIngreso>(i => i.PersonaId);
            modelBuilder.Entity<PersonasIngreso>().HasMany(i => i.PersonasIngresosDetalle).WithOne(d => d.PersonasIngreso).HasForeignKey(d => d.PersonaIngresoId);

            PouplatePersonas(modelBuilder);
            PouplateAgencias(modelBuilder);
        }

        private static void PouplatePersonas(ModelBuilder modelBuilder)
        {

            // Number of records to create
            int records = 100;

            IList<Persona> personas = [];

            for (int i = 0; i < records; i++)
            {
                personas.Add(
                    new Persona
                    {
                        PersonaId = i + 1,
                        SeguroSocial = new Random().Next(100000000, 999999999).ToString(),
                        Titulo = titles[new Random().Next(0, titles.Count)],
                        ApellidoPaterno = lastNames[new Random().Next(0, lastNames.Count)],
                        ApellidoMaterno = lastNames[new Random().Next(0, lastNames.Count)],
                        Nombre = names[new Random().Next(0, names.Count)],
                        Inicial = names[new Random().Next(0, names.Count)].Substring(0, 1),
                        Genero = genders[new Random().Next(0, genders.Count)],
                        Raza = razas[new Random().Next(0, razas.Count)],
                        Etnia = etnias[new Random().Next(0, etnias.Count)],
                        Ocupacion = ocupations[new Random().Next(0, ocupations.Count)],
                        EstadoCivil = maritalStatus[new Random().Next(0, maritalStatus.Count)],
                        Escolaridad = escolarities[new Random().Next(0, escolarities.Count)],
                        FechaNacimiento = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        LugarNacePueplo = cities[new Random().Next(0, cities.Count)],
                        LugarNaceEstado = "PR",
                        LugarNacePais = "Estados Unidos",
                        TelefonoResidencia = new Random().Next(100000000, 999999999).ToString(),
                        TelefonoCelular = new Random().Next(100000000, 999999999).ToString(),
                        GradAcademico = escolarities[new Random().Next(0, escolarities.Count)],
                        Religion = religions[new Random().Next(0, religions.Count)],
                        CreateDate = DateTime.Now,
                        CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                    });
            }

            modelBuilder.Entity<Persona>().HasData(personas);

            // List of random tipos de ingresos
            IList<PersonasIngreso> personasIngresos = [];

            for (int i = 0; i < records; i++)
            {
                personasIngresos.Add(
                    new PersonasIngreso
                    {
                        PersonaIngresoId = i + 1,
                        PersonaId = i + 1,
                        FechaInicio = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        FechaFin = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        IngresoTotal = new Random().Next(10000, 100000),
                        Retencion = new Random().Next(1000, 10000),
                        Aportacion = new Random().Next(1000, 10000),
                        Activo = true
                    });
            }


            modelBuilder.Entity<PersonasIngreso>().HasData(personasIngresos);

            // List of random tipos de ingresos
            IList<PersonasIngresosDetalle> personasIngresosDetalles = [];

            for (int i = 0; i < records; i++)
            {
                personasIngresosDetalles.Add(
                    new PersonasIngresosDetalle
                    {
                        PersonaIngresoDetalleId = i + 1,
                        PersonaIngresoId = i + 1,
                        TipoIngreso = tiposIngresos[new Random().Next(0, tiposIngresos.Count)],
                        Cantidad = new Random().Next(1000, 10000),
                        Comentario = tiposIngresos[new Random().Next(0, tiposIngresos.Count)],
                        Ingresos = $"Salario {new Random().Next(1000, 10000)}",
                    });
            }

            modelBuilder.Entity<PersonasIngresosDetalle>().HasData(personasIngresosDetalles);

            // List of random tipos de direcciones
            IList<PersonasDireccion> personasDireccions = [];

            for (int i = 0; i < records; i++)
            {
                personasDireccions.Add(
                    new PersonasDireccion
                    {
                        DireccionId = i + 1,
                        PersonaId = i + 1,
                        TipoDireccion = tiposDirecciones[new Random().Next(0, tiposDirecciones.Count)],
                        Direccion = "Calle " + new Random().Next(1, 100),
                        Direccion2 = "Calle " + new Random().Next(1, 100),
                        Ciudad = cities[new Random().Next(0, cities.Count)],
                        Estado = "PR",
                        Pais = "Estados Unidos",
                        CodigoPostal = new Random().Next(10000, 99999).ToString(),
                        FechaInicio = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        FechaFin = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                        CreateDate = DateTime.Now,
                        Activo = true
                    });
            }


            modelBuilder.Entity<PersonasDireccion>().HasData(personasDireccions);

            // List of random tipos de direcciones
            IList<PersonasLink> personasLinks = [];

            for (int i = 0; i < records; i++)
            {
                personasLinks.Add(
                    new PersonasLink
                    {
                        LinkId = i + 1,
                        PersonaId = i + 1,
                        TipoLink = relationships[new Random().Next(0, relationships.Count)],
                        EstadoEmpleo = "Activo",
                        JefeDeFamilia = new Random().Next(0, 1) == 1,
                        Pensionado = new Random().Next(0, 1) == 1,
                        Relacion = relationships[new Random().Next(0, relationships.Count)],
                        RMO = new Random().Next(100000000, 999999999).ToString(),
                        ViveEnElHogar = new Random().Next(0, 1) == 1
                    });
            }


            modelBuilder.Entity<PersonasLink>().HasData(personasLinks);

        }

        private static void PouplateAgencias(ModelBuilder modelBuilder)
        {
            IList<Agencia> agencias = [];

            for (int i = 0; i < 50; i++)
            {
                agencias.Add(
                    new Agencia
                    {
                        AgenciaId = i + 1,
                        TipoAgencia = "Tipo " + new Random().Next(1, 10),
                        NombreAgencia = "Agencia " + new Random().Next(1, 10),
                        Region = "Region " + new Random().Next(1, 10),
                        Direccion1 = "Calle " + new Random().Next(1, 100),
                        Direccion2 = "Calle " + new Random().Next(1, 100),
                        Ciudad = cities[new Random().Next(0, cities.Count)],
                        Estado = "PR",
                        Pais = "Estados Unidos",
                        ZipCode = new Random().Next(10000, 99999).ToString(),
                        PostalDireccion1 = "Calle " + new Random().Next(1, 100),
                        PostalDireccion2 = "Calle " + new Random().Next(1, 100),
                        PostalCiudad = cities[new Random().Next(0, cities.Count)],
                        PostalEstado = "PR",
                        PostalPais = "Estados Unidos",
                        EmailContacto = $"correo{new Random().Next(1, 100)}@correo.com",
                        PersonaContacto = $"{names[new Random().Next(0, names.Count)]} {lastNames[new Random().Next(0, lastNames.Count)]}",
                        PostalZipCode = new Random().Next(10000, 99999).ToString(),
                        FechaInicio = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
                        FechaFin = null,
                        CreateDate = DateTime.Now,
                        CreateUser = "03334448-73b4-438f-8fdf-784dbab58150",
                        Activo = true
                    });
            }

            modelBuilder.Entity<Agencia>().HasData(agencias);
        }
    }
}
