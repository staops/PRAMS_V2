using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.People.Migrations
{
    /// <inheritdoc />
    public partial class Update_Conf_Personas_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CasoActivo",
                table: "Conf_Personas_Links",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Externo",
                table: "Conf_Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Montly_Income",
                table: "Conf_Personas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7332), "Calle 38", "Calle 4", "correo56@correo.com", new DateTime(1972, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Rosa Santoyo", "Toa Baja", "Calle 1", "Calle 58", "75005", "Region 4", "Tipo 9", "11311" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Camuy", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7389), "Calle 2", "Calle 47", "correo78@correo.com", new DateTime(1955, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Liz Perez", "Arroyo", "Calle 25", "Calle 74", "60740", "Region 5", "Tipo 8", "86352" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7411), "Calle 42", "Calle 45", "correo18@correo.com", new DateTime(1994, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Raul Santana", "Guaynabo", "Calle 48", "Calle 57", "11761", "Region 8", "Tipo 7", "49297" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7434), "Calle 41", "Calle 3", "correo15@correo.com", new DateTime(1984, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Diana Jimenez", "Fajardo", "Calle 94", "Calle 11", "53139", "Region 4", "Tipo 8", "89262" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7456), "Calle 31", "Calle 35", "correo7@correo.com", new DateTime(1982, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Jose Silva", "Aguadilla", "Calle 70", "Calle 36", "69982", "Region 8", "55936" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7523), "Calle 8", "Calle 1", "correo90@correo.com", new DateTime(1972, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liliana Lopez", "Comerio", "Calle 79", "Calle 27", "33505", "Region 5", "Tipo 1", "14298" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Las Piedras", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7545), "Calle 42", "Calle 40", "correo51@correo.com", new DateTime(1986, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luz Torres", "Arroyo", "Calle 32", "Calle 33", "34900", "Region 7", "83895" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Las Marias", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7566), "Calle 22", "Calle 27", "correo94@correo.com", new DateTime(1972, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Lorena Gomez", "Gurabo", "Calle 81", "Calle 74", "90644", "Region 8", "Tipo 3", "28054" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Coamo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7585), "Calle 49", "Calle 28", "correo75@correo.com", new DateTime(1959, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Rosa Reyes", "Hatillo", "Calle 27", "Calle 17", "52814", "Region 9", "Tipo 9", "88580" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7607), "Calle 7", "Calle 88", "correo77@correo.com", new DateTime(1995, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Lorena Serrano", "Guanica", "Calle 79", "Calle 38", "94893", "Region 8", "Tipo 8", "15104" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7658), "Calle 50", "Calle 83", "correo99@correo.com", new DateTime(1980, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Raul Santos", "Guaynabo", "Calle 29", "Calle 64", "12553", "Region 5", "Tipo 9", "41031" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guanica", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7679), "Calle 77", "Calle 80", "correo82@correo.com", new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Jorge Perez", "Caguas", "Calle 27", "Calle 42", "38897", "Region 1", "Tipo 2", "72493" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Gurabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7699), "Calle 15", "Calle 84", "correo31@correo.com", new DateTime(1978, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Fernando Santos", "Cidra", "Calle 72", "Calle 62", "73523", "Region 7", "Tipo 1", "84063" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7720), "Calle 4", "Calle 26", "correo95@correo.com", new DateTime(1998, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Liz Perez", "Carolina", "Calle 2", "Calle 23", "91467", "Region 8", "Tipo 1", "31078" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CreateDate", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7769), "Calle 56", "correo92@correo.com", new DateTime(1978, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Lidia Jimenez", "Calle 15", "Calle 16", "94096", "Region 9", "Tipo 2", "14508" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Vega Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7790), "Calle 31", "Calle 52", "correo4@correo.com", new DateTime(1989, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Fernando Serrano", "Trujillo Alto", "Calle 82", "Calle 79", "86536", "Region 3", "66281" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Barranquitas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7811), "Calle 74", "Calle 55", "correo35@correo.com", new DateTime(1964, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Luz Serrano", "Florida", "Calle 85", "Calle 39", "59277", "Region 4", "Tipo 1", "50000" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Humacao", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7832), "Calle 40", "Calle 43", "correo60@correo.com", new DateTime(1964, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Laura Gonzalez", "San Juan", "Calle 63", "Calle 87", "50690", "Region 6", "Tipo 5", "99342" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7881), "Calle 53", "Calle 44", "correo67@correo.com", new DateTime(1983, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Jorge Jimenez", "Barranquitas", "Calle 96", "Calle 11", "32743", "Region 9", "Tipo 5", "82665" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7902), "Calle 96", "Calle 7", "correo15@correo.com", new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Maria Garcia", "Anasco", "Calle 1", "Calle 17", "92922", "Region 9", "Tipo 8", "67830" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ciales", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7921), "Calle 65", "Calle 2", "correo33@correo.com", new DateTime(1991, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Fernando Torres", "San Juan", "Calle 19", "Calle 10", "52159", "Region 7", "Tipo 8", "41299" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guanica", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7940), "Calle 10", "Calle 90", "correo57@correo.com", new DateTime(1984, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Leticia Reyes", "Cabo Rojo", "Calle 60", "Calle 65", "25424", "Region 7", "Tipo 1", "55184" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(7988), "Calle 35", "Calle 54", "correo89@correo.com", new DateTime(1959, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Jorge Ramirez", "Ceiba", "Calle 24", "Calle 23", "83362", "Region 3", "Tipo 3", "34794" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8010), "Calle 54", "Calle 56", "correo37@correo.com", new DateTime(1990, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Rosa Rojas", "Aguadilla", "Calle 22", "Calle 48", "71899", "Region 9", "Tipo 7", "76768" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8029), "Calle 8", "Calle 80", "correo51@correo.com", new DateTime(1986, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Sofia Sandoval", "Cayey", "Calle 73", "Calle 27", "77320", "Region 8", "Tipo 1", "24940" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ceiba", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8048), "Calle 51", "Calle 10", "correo99@correo.com", new DateTime(1967, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Lidia Santillan", "Ponce", "Calle 94", "Calle 7", "38880", "Region 2", "Tipo 8", "43880" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CreateDate", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Corozal", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8068), "Calle 22", "correo5@correo.com", new DateTime(1976, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Luz Elena Santana", "Cidra", "Calle 6", "Calle 80", "56185", "Tipo 6", "92382" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8131), "Calle 40", "Calle 70", "correo29@correo.com", new DateTime(1966, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lorena Santacruz", "Mayaguez", "Calle 78", "Calle 90", "30782", "Tipo 9", "87675" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8151), "Calle 53", "Calle 60", "correo49@correo.com", new DateTime(1984, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana Saucedo", "Juncos", "Calle 27", "Calle 15", "30826", "Region 1", "Tipo 8", "56261" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8171), "Calle 83", "Calle 7", "correo59@correo.com", new DateTime(1952, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Carlos Santos", "Coamo", "Calle 32", "Calle 33", "18939", "Region 4", "Tipo 8", "59759" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8190), "Calle 49", "Calle 16", "correo45@correo.com", new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Rosa Vazquez", "Cidra", "Calle 96", "Calle 28", "76164", "Region 7", "Tipo 9", "95841" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8250), "Calle 18", "Calle 96", "correo65@correo.com", new DateTime(1967, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Luz Maria Vazquez", "Calle 20", "Calle 81", "36659", "Region 9", "Tipo 9", "60496" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Coamo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8269), "Calle 87", "Calle 10", "correo53@correo.com", new DateTime(1995, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Laura Santacruz", "Calle 67", "Calle 61", "96012", "Region 4", "Tipo 2", "63711" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Canovanas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8290), "Calle 93", "Calle 20", "correo99@correo.com", new DateTime(1966, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Lilia Jimenez", "Juana Diaz", "Calle 61", "Calle 22", "62639", "Region 7", "Tipo 3", "16608" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8309), "Calle 2", "Calle 13", "correo28@correo.com", new DateTime(1964, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Juan Santana", "Fajardo", "Calle 17", "89064", "Region 6", "Tipo 2", "71765" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Humacao", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8372), "Calle 88", "Calle 56", "correo44@correo.com", new DateTime(1972, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Rocio Garcia", "Canovanas", "Calle 82", "Calle 20", "36413", "Region 1", "Tipo 4", "53723" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8392), "Calle 16", "Calle 41", "correo79@correo.com", new DateTime(1974, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Rosa Santana", "Cabo Rojo", "Calle 59", "Calle 10", "41556", "Tipo 6", "67991" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Juncos", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8411), "Calle 28", "Calle 11", "correo54@correo.com", new DateTime(1967, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Liliana Gonzalez", "Guaynabo", "Calle 87", "Calle 80", "16727", "Region 7", "Tipo 1", "21531" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8431), "Calle 40", "Calle 55", "correo30@correo.com", new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luz Maria Santamaria", "Toa Alta", "Calle 12", "Calle 32", "69442", "Region 5", "Tipo 5", "37273" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Baja", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8482), "Calle 16", "Calle 34", "correo69@correo.com", new DateTime(1988, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Liliana Rojas", "Carolina", "Calle 18", "Calle 75", "66886", "Region 8", "Tipo 7", "12323" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cayey", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8501), "Calle 93", "Calle 79", "correo17@correo.com", new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo Serrano", "Juana Diaz", "Calle 91", "Calle 26", "45345", "Region 5", "Tipo 8", "96365" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8521), "Calle 96", "Calle 25", "correo66@correo.com", new DateTime(1970, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Luis Santana", "Comerio", "Calle 6", "Calle 72", "99415", "Region 5", "90827" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8541), "Calle 15", "Calle 44", "correo18@correo.com", new DateTime(1958, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Maria Santillan", "Anasco", "Calle 50", "Calle 30", "46519", "Region 4", "Tipo 7", "18474" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Baja", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8614), "Calle 24", "Calle 91", "correo17@correo.com", new DateTime(1963, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Jorge Sandoval", "Carolina", "Calle 60", "Calle 47", "36483", "Region 1", "Tipo 2", "65703" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "ZipCode" },
                values: new object[] { "Catano", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8633), "Calle 25", "Calle 71", "correo50@correo.com", new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Liliana Perez", "Cabo Rojo", "Calle 71", "Calle 25", "26768", "76029" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8652), "Calle 97", "Calle 90", "correo91@correo.com", new DateTime(1985, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Laura Hernandez", "Cayey", "Calle 59", "Calle 63", "21008", "Region 5", "Tipo 5", "49687" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayanilla", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8672), "Calle 15", "Calle 2", "correo76@correo.com", new DateTime(1996, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Leticia Santos", "Vega Alta", "Calle 46", "Calle 72", "34001", "Region 2", "Tipo 5", "52952" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8693), "Calle 68", "Calle 27", "correo95@correo.com", new DateTime(1995, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Lorena Suarez", "Fajardo", "Calle 27", "Calle 60", "38193", "Tipo 4", "17324" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Coamo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8744), "Calle 35", "Calle 29", "correo61@correo.com", new DateTime(1970, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Elena Rojas", "Guayama", "Calle 16", "Calle 6", "95115", "Region 6", "Tipo 6", "20350" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(8763), "Calle 70", "Calle 11", "correo2@correo.com", new DateTime(1964, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Luisa Silva", "Caguas", "Calle 11", "Calle 70", "94248", "Region 4", "Tipo 7", "13459" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 1,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Silva", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9007), "Preparatoria", "Soltero", false, new DateTime(1969, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "Toa Baja", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(8891), null, "Liliana", "Otra", "Ateo", "461917432", "408325642", "949799642", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 2,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santoyo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9032), "Primaria", false, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "C", "Aguada", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9011), null, "Lorena", "Estudiante", "Ateo", "354806935", "638805771", "595251966", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 3,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Salazar", "Saucedo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9057), "Doctorado", "Viudo", "Europea", false, new DateTime(1992, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Corozal", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9034), null, "Luz Maria", "Otro", "Catolica", "124424004", "711940840", "975937683" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 4,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Torres", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9111), "Doctorado", "Casado", "Estadounidense", false, new DateTime(1967, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "J", "Isabela", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9058), null, "Luz Elena", "Ama de casa", "Blanca", "Testigo de Jehova", "201269646", "688476607", "665738332", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 5,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Sandoval", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9134), "Doctorado", "Viudo", "Europea", false, new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "L", "Jayuya", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9112), null, "Estudiante", "Mormon", "370258188", "608235377", "422375997", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 6,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9159), "Viudo", "Otra", false, new DateTime(1984, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Comerio", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9137), null, "Lilia", "Empleado", "Morena", "Catolica", "347232740", "334141551", "316741525", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 7,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santana", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9182), "Licenciatura", "Estadounidense", false, new DateTime(1967, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "R", "Trujillo Alto", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9160), null, "Luz Elena", "Jubilado", "Otra", "Mormon", "558574467", "837196699", "947117902", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 8,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Martinez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9233), "Licenciatura", "Divorciado", "Otra", false, new DateTime(1982, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "E", "Caguas", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9183), null, "Luz Elena", "Blanca", "Mormon", "850063550", "293861871", "743782797", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 9,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9256), "Licenciatura", "Asiatica", false, new DateTime(1982, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "R", "Guanica", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9234), null, "Desempleado", "Otra", "Catolica", "208198772", "989787683", "317758711", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 10,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Suarez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9280), "Otro", "Asiatica", false, new DateTime(1982, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9258), null, "Luz", "Desempleado", "Blanca", "Ateo", "821288960", "989720950", "880223007", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 11,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9301), false, new DateTime(1970, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "L", "Barceloneta", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9281), null, "Carlos", "Otra", "885549222", "187090715", "262618534", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 12,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9355), "Doctorado", "Viudo", false, new DateTime(1959, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Cataño", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9302), null, "Jose", "Otro", "Otra", "Cristiana", "647428983", "424533298", "552538782", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 13,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Vazquez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9377), "Doctorado", "Divorciado", "Africana", false, new DateTime(1967, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "Anasco", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9356), null, "Lourdes", "Empleado", "Amarilla", "Agnostico", "114128710", "928704770", "606336429", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 14,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9400), "Preparatoria", "Europea", false, new DateTime(1960, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9378), null, "Fernando", "Otro", "Blanca", "Otro", "571381031", "501403816", "600784731", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 15,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Saucedo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9422), "Licenciatura", "Soltero", "Mexicana", false, new DateTime(1982, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "L", "Arecibo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9401), null, "Rosa", "Morena", "Cristiana", "990310680", "630868944", "537354764", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 16,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Vazquez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9474), "Primaria", "Casado", false, new DateTime(1957, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Maestria", "L", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9423), null, "Liliana", "Estudiante", "Blanca", "822622924", "542199176", "237304803", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 17,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Ramirez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9496), "Otro", "Estadounidense", false, new DateTime(1987, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "R", "Aibonito", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9475), null, "Juan", "Empleado", "Negra", "Ateo", "595521667", "476890040", "187640793", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 18,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9520), "Maestria", "Divorciado", "Africana", false, new DateTime(1965, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9499), null, "Ana", "Otra", "Ateo", "801567140", "220564248", "309708952", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 19,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Diaz", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9543), "Otro", "Casado", "Europea", false, new DateTime(1958, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "C", "Culebra", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9521), null, "Rosa", "Desempleado", "Negra", "Catolica", "346426819", "950476772", "508480322", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 20,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Martinez", "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9591), "Preparatoria", "Divorciado", "Asiatica", false, new DateTime(1990, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "Aguadilla", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9544), null, "Elena", "Jubilado", "Blanca", "Ateo", "811791712", "770629681", "872130049" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 21,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Reyes", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9613), "Soltero", "Estadounidense", false, new DateTime(1968, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "C", "Ciales", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9592), null, "Liliana", "Agnostico", "787646829", "354962196", "672215421", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 22,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Vazquez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9635), "Maestria", "Divorciado", false, new DateTime(1955, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "Aguadilla", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9614), null, "Carmen", "Otro", "Otra", "Mormon", "366603972", "262762467", "437929363", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 23,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Reyes", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9741), "Europea", false, new DateTime(1959, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "C", "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9636), null, "Carmen", "Empleado", "Blanca", "Agnostico", "472280764", "301597815", "141682144", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 24,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9765), "Otro", "Soltero", false, new DateTime(1964, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "L", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9742), null, "Juan", "Testigo de Jehova", "138693514", "571439982", "691482919", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 25,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Soto", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9787), "Divorciado", "Canadiense", false, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Barceloneta", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9766), null, "Lorena", "Negra", "Otro", "167924233", "123640732", "492983286", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 26,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Santoyo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9809), "Secundaria", "Soltero", false, new DateTime(1963, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "R", "Aguadilla", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9788), null, "Miguel", "Empleado", "Otro", "504279709", "591857366", "709020635", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 27,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Suarez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9875), "Maestria", "Divorciado", "Estadounidense", false, new DateTime(1977, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Bayamon", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9810), null, "Sofia", "Ama de casa", "Negra", "Catolica", "586937525", "642479751", "992509694", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 28,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Soto", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9898), "Primaria", "Soltero", "Canadiense", false, new DateTime(1957, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "J", "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9876), null, "Elena", "Otro", "Amarilla", "Mormon", "423474551", "358864554", "608162144", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 29,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Garcia", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9920), "Maestria", "Canadiense", false, new DateTime(1972, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "R", "Guayanilla", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9899), null, "Luisa", "Otro", "Negra", "Mormon", "185346070", "789783505", "471063804", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 30,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9942), "Estadounidense", false, new DateTime(1953, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "Juncos", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9921), null, "Diana", "Desempleado", "Amarilla", "Testigo de Jehova", "353052756", "655034869", "620931987", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 31,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Hernandez", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9994), "Maestria", "Soltero", "Otra", false, new DateTime(1957, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Primaria", "L", "Hatillo", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9943), null, "Sofia", "Ama de casa", "Blanca", "Testigo de Jehova", "384976498", "366462604", "687111621", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 32,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Santamaria", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(16), "Licenciatura", "Otra", false, new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 986, DateTimeKind.Local).AddTicks(9995), null, "Carmen", "Otro", "Cristiana", "552661432", "550171548", "414802269", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 33,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Santana", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(39), "Licenciatura", "Viudo", "Canadiense", false, new DateTime(1954, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "R", "Barranquitas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(17), null, "Lorena", "Estudiante", "Testigo de Jehova", "957467404", "500089774", "471672623", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 34,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santillana", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(63), "Primaria", "Casado", "Asiatica", false, new DateTime(1971, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "M", "Barranquitas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(42), null, "Rosa", "Desempleado", "Amarilla", "Catolica", "473953555", "210727707", "502743245", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 35,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(116), "Primaria", "Viudo", "Europea", false, new DateTime(1951, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Arecibo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(64), null, "Rosa", "Empleado", "Negra", "Ateo", "863659690", "994442101", "415281901", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 36,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Jimenez", "Soto", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(138), "Otro", "Estadounidense", false, new DateTime(1983, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "L", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(117), null, "Jose", "Estudiante", "Amarilla", "Ateo", "528821248", "620650394", "162500102" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 37,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Silva", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(159), "Preparatoria", false, new DateTime(1988, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Ceiba", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(139), null, "Elena", "Jubilado", "Mormon", "836571485", "752046498", "434168090", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 38,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(181), "Otro", "Viudo", "Asiatica", false, new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "R", "Guayama", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(160), null, "Desempleado", "Morena", "Agnostico", "458514340", "900365525", "484122341", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 39,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Reyes", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(233), "Doctorado", "Viudo", false, new DateTime(1963, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "L", "Vega Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(210), null, "Sofia", "Ama de casa", "Otra", "Agnostico", "944623306", "608772940", "279764329", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 40,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Vazquez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(255), "Secundaria", "Soltero", "Otra", false, new DateTime(1986, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "C", "Arroyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(234), null, "Elena", "Otro", "Negra", "Testigo de Jehova", "259531617", "704533067", "942002343", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 41,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Garcia", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(276), "Primaria", "Casado", "Asiatica", false, new DateTime(1952, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "A", "Las Marias", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(256), null, "Juan", "Blanca", "Ateo", "217925240", "379311595", "752296795", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 42,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Santoyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(298), "Otro", "Soltero", "Estadounidense", false, new DateTime(1971, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "M", "Coamo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(277), null, "Sofia", "Estudiante", "Otra", "Otro", "994598996", "903852804", "960973341", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 43,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Rojas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(377), "Licenciatura", "Casado", "Otra", false, new DateTime(1994, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "M", "Barranquitas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(353), null, "Liliana", "Empleado", "Otro", "271098325", "716623940", "447088338", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 44,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santibañez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(399), "Doctorado", "Asiatica", false, new DateTime(1974, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Primaria", "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(378), null, "Jose", "Desempleado", "Otro", "370081349", "286572149", "278170605", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 45,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santacruz", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(421), "Licenciatura", "Casado", "Otra", false, new DateTime(1976, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "L", "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(400), null, "Liliana", "Estudiante", "Testigo de Jehova", "659166813", "103318179", "156276624", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 46,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Silva", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(471), "Preparatoria", "Divorciado", "Africana", false, new DateTime(1975, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "Cayey", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(422), null, "Fernando", "Ama de casa", "Morena", "976648028", "114604815", "256947842", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 47,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Lopez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(494), "Secundaria", "Divorciado", "Asiatica", false, new DateTime(1999, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "J", "Catano", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(472), null, "Jose", "Ama de casa", "Morena", "Mormon", "217139065", "900966359", "238345310", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 48,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Lopez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(516), "Maestria", "Viudo", false, new DateTime(1991, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Guanica", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(495), null, "Diana", "Estudiante", "339992878", "208332185", "129927055", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 49,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Salazar", "Serrano", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(538), "Soltero", "Europea", false, new DateTime(1973, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "C", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(517), null, "Lorena", "Otro", "Morena", "Testigo de Jehova", "252879369", "121938587", "963446453" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 50,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(598), "Soltero", "Otra", false, new DateTime(1976, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "C", "Culebra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(539), null, "Juan", "Desempleado", "Amarilla", "918643593", "169199880", "573679865", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 51,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Hernandez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(620), "Otro", "Soltero", "Africana", false, new DateTime(1982, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "R", "Toa Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(598), null, "Lourdes", "Desempleado", "Amarilla", "Agnostico", "218956373", "453261657", "226084709", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 52,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Jimenez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(644), "Secundaria", "Divorciado", false, new DateTime(1957, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(621), null, "Sofia", "Negra", "Catolica", "743639227", "487111414", "435640883", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 53,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santana", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(666), "Licenciatura", "Soltero", "Asiatica", false, new DateTime(1970, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "L", "Toa Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(645), null, "Luz Maria", "Amarilla", "Testigo de Jehova", "181377876", "194756538", "455883860", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 54,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Jimenez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(727), "Preparatoria", "Divorciado", "Asiatica", false, new DateTime(1993, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "M", "San Juan", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(667), null, "Lorena", "Agnostico", "197610553", "404604504", "276311430", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 55,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santos", "Gomez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(749), "Preparatoria", "Soltero", "Europea", false, new DateTime(1954, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Aguadilla", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(728), null, "Luz", "Blanca", "198611994", "115969008", "258166919" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 56,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Sosa", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(771), "Licenciatura", "Viudo", "Europea", false, new DateTime(1992, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "R", "Lares", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(749), null, "Luz Maria", "Jubilado", "Negra", "Agnostico", "457798774", "577385983", "454307479", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 57,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Rojas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(793), "Secundaria", "Soltero", "Europea", false, new DateTime(1955, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "R", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(772), null, "Luz", "Desempleado", "Otra", "Catolica", "731229719", "795709148", "547097715", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 58,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(856), "Soltero", "Asiatica", false, new DateTime(1980, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "S", "Carolina", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(794), null, "Carmen", "Estudiante", "Blanca", "Testigo de Jehova", "216291479", "660786848", "832963078", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 59,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santana", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(878), "Primaria", "Viudo", "Estadounidense", false, new DateTime(1995, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "L", "Barceloneta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(857), null, "Liliana", "Jubilado", "Morena", "Mormon", "296599308", "181404493", "270757824", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 60,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Santoyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(901), "Mexicana", false, new DateTime(1969, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "A", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(879), null, "Jose", "Desempleado", "851504807", "265181154", "773412215", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 61,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(923), false, new DateTime(1988, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "L", "Mayaguez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(902), null, "Lourdes", "Ama de casa", "Amarilla", "Mormon", "342729243", "982804140", "625773022", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 62,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Suarez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(975), "Otro", "Viudo", "Asiatica", false, new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "L", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(924), null, "Pedro", "Jubilado", "Morena", "Otro", "790150848", "663100811", "312589111", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 63,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Rojas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(996), "Otro", "Divorciado", "Canadiense", false, new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "R", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(976), null, "Liliana", "Jubilado", "Negra", "Mormon", "168651509", "637260725", "120179210", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 64,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Sandoval", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1018), "Licenciatura", "Estadounidense", false, new DateTime(1980, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "Comerio", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(997), null, "Luz", "Desempleado", "Cristiana", "942224272", "704957921", "629765992", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 65,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1040), "Secundaria", "Casado", false, new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "S", "Anasco", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1019), null, "Ricardo", "Negra", "Catolica", "598071667", "427054113", "909758447", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 66,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Santamaria", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1117), "Secundaria", "Viudo", "Estadounidense", false, new DateTime(1967, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Guaynabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1093), null, "Carmen", "Estudiante", "Otra", "Mormon", "801428957", "227951884", "391442355", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 67,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Jimenez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1139), "Licenciatura", "Divorciado", "Otra", false, new DateTime(1991, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "San Juan", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1117), null, "Luz", "Otro", "Negra", "Ateo", "521642482", "542532180", "487008512", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 68,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Torres", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1161), "Maestria", "Casado", "Asiatica", false, new DateTime(1985, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "L", "Toa Alta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1140), null, "Leticia", "Desempleado", "Morena", "Mormon", "898237840", "731997661", "181158638", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 69,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Soto", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1213), "Secundaria", "Divorciado", "Asiatica", false, new DateTime(1960, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Guaynabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1161), null, "Jorge", "Otra", "Testigo de Jehova", "636727778", "115307861", "280171119", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 70,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Lopez", "Sosa", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1235), "Otro", "Viudo", "Asiatica", false, new DateTime(1966, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "R", "Lares", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1214), null, "Lourdes", "Negra", "Ateo", "514938913", "635594805", "903690503" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 71,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Santamaria", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1257), "Maestria", "Casado", "Asiatica", false, new DateTime(1955, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "P", "Fajardo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1236), null, "Luz Elena", "Estudiante", "Ateo", "878274354", "706656188", "444497882", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 72,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Silva", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1280), "Licenciatura", "Viudo", "Otra", false, new DateTime(1968, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "L", "Ponce", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1258), null, "Liliana", "Estudiante", "Blanca", "Testigo de Jehova", "777316982", "481734072", "836502010", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 73,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Soto", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1332), "Casado", "Otra", false, new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "Canovanas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1281), null, "Juan", "Estudiante", "Otra", "Ateo", "969142323", "583916958", "193518796", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 74,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Santillan", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1355), "Licenciatura", "Casado", false, new DateTime(1962, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "S", "Las Marias", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1333), null, "Maria", "Otro", "Otra", "238056072", "147021029", "871733910", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 75,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1378), "Licenciatura", "Casado", "Europea", false, new DateTime(1995, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "Guaynabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1356), null, "Elena", "Mormon", "336119914", "812536892", "107460083", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 76,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Vazquez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1399), "Doctorado", "Soltero", "Canadiense", false, new DateTime(1955, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1379), null, "Maria", "Jubilado", "Blanca", "Catolica", "770949765", "637585180", "967945349", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 77,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Hernandez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1471), "Primaria", "Casado", "Estadounidense", false, new DateTime(1955, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", "Dorado", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1400), null, "Laura", "Ama de casa", "Agnostico", "163489882", "972885033", "652355121", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 78,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Torres", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1493), "Preparatoria", "Divorciado", "Asiatica", false, new DateTime(1958, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "F", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1472), null, "Elena", "Empleado", "Negra", "Otro", "955288258", "661482650", "314782034", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 79,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santillana", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1514), "Secundaria", false, new DateTime(1998, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "Cataño", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1494), null, "Luz", "Otro", "Mormon", "352436222", "494019900", "726938333", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 80,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1536), "Licenciatura", "Viudo", "Mexicana", false, new DateTime(1983, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "A", "Arroyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1515), null, "Ana", "Desempleado", "Negra", "616786499", "437720410", "635027775", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 81,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Ramirez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1579), "Preparatoria", "Viudo", "Asiatica", false, new DateTime(1956, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "L", "Las Marias", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1556), null, "Luisa", "Ama de casa", "Negra", "Cristiana", "286999802", "698679497", "721281370", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 82,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1601), "Otro", "Viudo", "Otra", false, new DateTime(1951, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "M", "Humacao", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1580), null, "Sofia", "Estudiante", "Negra", "Cristiana", "416423800", "535839262", "267323740", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 83,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Sandoval", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1623), "Secundaria", "Viudo", "Canadiense", false, new DateTime(1962, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Primaria", "R", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1602), null, "Lorena", "Ateo", "978857503", "734721540", "436540410", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 84,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Hernandez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1700), "Soltero", "Mexicana", false, new DateTime(1983, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "L", "Arroyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1624), null, "Jubilado", "Blanca", "Testigo de Jehova", "325996515", "220656626", "558950648", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 85,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Suarez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1722), false, new DateTime(1959, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "Aguas Buenas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1701), null, "Luisa", "Desempleado", "Negra", "Mormon", "684771589", "643266704", "393263600", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 86,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Gonzalez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1743), "Licenciatura", "Divorciado", false, new DateTime(1990, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1723), null, "Luis", "Morena", "720016018", "590544450", "948939908", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 87,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1765), "Maestria", "Casado", "Canadiense", false, new DateTime(1977, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "R", "Gurabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1744), null, "Elena", "Jubilado", "Amarilla", "726875344", "385082194", "357030445", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 88,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "Externo", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1828), "Otro", false, new DateTime(1960, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "L", "Isabela", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1766), null, "Carmen", "Estudiante", "Amarilla", "Mormon", "432047935", "624131578", "548665151", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 89,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Santoyo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1851), "Divorciado", "Otra", false, new DateTime(1960, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", "Cabo Rojo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1829), null, "Estudiante", "Negra", "Ateo", "866039913", "742119164", "281170915", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 90,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Torres", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1873), "Divorciado", "Europea", false, new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Ciales", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1852), null, "Maria", "Ateo", "331230481", "169244558", "270887272", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 91,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santos", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1894), "Preparatoria", "Divorciado", "Asiatica", false, new DateTime(1987, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Gurabo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1874), null, "Lorena", "Ama de casa", "Otra", "Catolica", "670994004", "813136955", "693565699", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 92,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Rojas", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1945), "Primaria", "Europea", false, new DateTime(1996, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "San Juan", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1895), null, "Carmen", "Otro", "Amarilla", "Otro", "116289345", "944092312", "676480423", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 93,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Saucedo", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1967), "Casado", "Mexicana", false, new DateTime(1964, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "M", "Comerio", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1946), null, "Liz", "Jubilado", "Ateo", "591936355", "435881249", "545948443", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 94,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Perez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1990), "Primaria", "Casado", "Otra", false, new DateTime(1991, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "Aibonito", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1968), null, "Jorge", "Ama de casa", "Negra", "Catolica", "996835523", "955072140", "178440181", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 95,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Reyes", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2012), "Maestria", "Divorciado", "Europea", false, new DateTime(1964, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "R", "Cidra", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(1991), null, "Lorena", "Morena", "Ateo", "279693489", "561947983", "727870014", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 96,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santillan", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2061), "Secundaria", "Soltero", "Asiatica", false, new DateTime(1991, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "J", "Barceloneta", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2012), null, "Fernando", "Estudiante", "Otra", "Otro", "894057798", "393167666", "510882231", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 97,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Salazar", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2083), "Primaria", "Viudo", "Africana", false, new DateTime(1981, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "Guayama", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2062), null, "Luz Elena", "Otro", "Otra", "Mormon", "742239968", "821168590", "521450172", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 98,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Martinez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2105), "Primaria", false, new DateTime(1993, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "C", "Cayey", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2084), null, "Jorge", "Jubilado", "Amarilla", "Catolica", "532881865", "840536606", "521565664", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 99,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Sandoval", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2126), "Otro", "Soltero", "Estadounidense", false, new DateTime(1965, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "Bayamon", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2106), null, "Leticia", "Ama de casa", "Morena", "Ateo", "714832713", "673547608", "799943587", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 100,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "Externo", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Montly_Income", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Lopez", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2177), "Preparatoria", "Mexicana", false, new DateTime(1967, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "R", "Guayama", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(2127), null, "Luz", "Otro", "Morena", "713161940", "430549306", "319267579", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "44153", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4523), "Calle 39", "Calle 60", new DateTime(1955, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "San Juan", "60299", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4541), "Calle 84", "Calle 92", new DateTime(1992, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cataño", "51057", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4555), "Calle 37", "Calle 52", new DateTime(1982, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "91127", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4570), "Calle 61", "Calle 36", new DateTime(1964, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "89696", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4583), "Calle 8", "Calle 1", new DateTime(1988, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "74083", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4598), "Calle 61", "Calle 90", new DateTime(1982, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guayanilla", "35528", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4611), "Calle 88", "Calle 26", new DateTime(1956, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguadilla", "42078", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4625), "Calle 42", "Calle 23", new DateTime(1975, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguada", "93649", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4691), "Calle 73", "Calle 88", new DateTime(1987, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aibonito", "88592", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4706), "Calle 93", "Calle 44", new DateTime(1990, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Vega Baja", "89385", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4720), "Calle 49", "Calle 98", new DateTime(1965, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguadilla", "23104", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4733), "Calle 94", "Calle 39", new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "San Juan", "56686", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4744), "Calle 45", "Calle 84", new DateTime(1974, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "15836", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4758), "Calle 94", "Calle 86", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "47719", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4772), "Calle 7", "Calle 77", new DateTime(1966, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cayey", "10605", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4785), "Calle 56", "Calle 60", new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "48718", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4853), "Calle 61", "Calle 54", new DateTime(1961, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Isabela", "64511", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4868), "Calle 6", "Calle 7", new DateTime(1963, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Isabela", "43878", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4882), "Calle 70", "Calle 13", new DateTime(1959, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "45547", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4896), "Calle 82", "Calle 2", new DateTime(1966, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "33106", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4908), "Calle 74", "Calle 94", new DateTime(1954, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "69416", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4921), "Calle 6", "Calle 27", new DateTime(1965, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "58948", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4933), "Calle 73", "Calle 77", new DateTime(1971, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "12437", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4976), "Calle 76", "Calle 71", new DateTime(1989, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cidra", "50783", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(4989), "Calle 83", new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "16942", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5003), "Calle 4", "Calle 50", new DateTime(1964, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ceiba", "73269", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5017), "Calle 97", "Calle 9", new DateTime(1970, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "95301", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5029), "Calle 50", "Calle 6", new DateTime(1967, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aibonito", "69441", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5041), "Calle 75", "Calle 95", new DateTime(1958, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "82242", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5054), "Calle 23", "Calle 35", new DateTime(1953, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "85604", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5066), "Calle 36", "Calle 35", new DateTime(1978, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arecibo", "20934", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5109), "Calle 55", "Calle 73", new DateTime(1950, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guayanilla", "19692", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5121), "Calle 57", "Calle 82", new DateTime(1967, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ponce", "66464", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5136), "Calle 72", "Calle 23", new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cataño", "91266", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5150), "Calle 17", "Calle 89", new DateTime(1970, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aguada", "26252", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5165), "Calle 67", "Calle 85", new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "82145", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5177), "Calle 64", "Calle 52", new DateTime(1967, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Trujillo Alto", "91340", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5189), "Calle 93", "Calle 12", new DateTime(1984, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Coamo", "70286", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5233), "Calle 68", "Calle 48", new DateTime(1968, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "18005", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5246), "Calle 60", "Calle 14", new DateTime(1957, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "44511", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5257), "Calle 60", "Calle 86", new DateTime(1962, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayama", "51721", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5269), "Calle 20", "Calle 82", new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "49303", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5282), "Calle 8", "Calle 98", new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "88340", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5295), "Calle 84", "Calle 32", new DateTime(1960, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Lares", "32724", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5306), "Calle 67", "Calle 93", new DateTime(1981, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayanilla", "81527", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5319), "Calle 87", "Calle 64", new DateTime(1982, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "12268", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5364), "Calle 62", "Calle 37", new DateTime(1966, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "72730", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5378), "Calle 35", "Calle 15", new DateTime(1969, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguas Buenas", "20444", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5390), "Calle 33", "Calle 85", new DateTime(1962, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cataño", "49450", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5403), "Calle 7", "Calle 98", new DateTime(1957, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 51,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio" },
                values: new object[] { "Hormigueros", "26816", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5416), "Calle 43", new DateTime(1969, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 52,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "82934", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5428), "Calle 13", "Calle 41", new DateTime(1962, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 53,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Dorado", "22438", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5439), "Calle 46", "Calle 4", new DateTime(1998, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 54,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "84040", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5451), "Calle 15", "Calle 85", new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 55,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Trujillo Alto", "61050", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5494), "Calle 55", "Calle 51", new DateTime(1974, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 56,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "49543", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5507), "Calle 40", "Calle 82", new DateTime(1967, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 57,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "39294", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5518), "Calle 19", "Calle 92", new DateTime(1997, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 58,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ponce", "50861", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5531), "Calle 32", "Calle 47", new DateTime(1976, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 59,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Dorado", "96694", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5543), "Calle 14", "Calle 98", new DateTime(1963, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 60,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guayama", "68980", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5555), "Calle 89", "Calle 86", new DateTime(1954, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 61,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Vega Alta", "47487", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5566), "Calle 46", "Calle 46", new DateTime(1990, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 62,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "35367", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5579), "Calle 41", "Calle 34", new DateTime(1976, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 63,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aguada", "76934", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5610), "Calle 1", "Calle 26", new DateTime(1973, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 64,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Isabela", "15651", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5622), "Calle 27", "Calle 62", new DateTime(1996, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 65,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "84560", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5634), "Calle 9", "Calle 5", new DateTime(1967, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 66,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "17200", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5649), "Calle 71", "Calle 91", new DateTime(1961, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 67,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "60697", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5662), "Calle 40", "Calle 16", new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 68,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "73902", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5675), "Calle 92", "Calle 92", new DateTime(1976, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 69,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "21882", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5720), "Calle 93", "Calle 38", new DateTime(1961, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 70,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barranquitas", "59411", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5733), "Calle 20", "Calle 91", new DateTime(1980, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 71,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aibonito", "44348", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5745), "Calle 76", "Calle 10", new DateTime(1971, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 72,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "90464", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5757), "Calle 72", "Calle 35", new DateTime(1991, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 73,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hormigueros", "76539", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5768), "Calle 27", "Calle 75", new DateTime(1950, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 74,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "93418", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5780), "Calle 4", "Calle 49", new DateTime(1994, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 75,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "82076", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5794), "Calle 66", "Calle 62", new DateTime(1961, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 76,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "26451", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5806), "Calle 9", "Calle 40", new DateTime(1971, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 77,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "61891", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5858), "Calle 13", "Calle 36", new DateTime(1971, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 78,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "43572", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5870), "Calle 66", "Calle 16", new DateTime(1978, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 79,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguas Buenas", "38782", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5884), "Calle 55", "Calle 22", new DateTime(1957, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 80,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "28415", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5897), "Calle 79", "Calle 15", new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 81,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguas Buenas", "13724", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5908), "Calle 81", "Calle 60", new DateTime(1997, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 82,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "28960", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5921), "Calle 35", "Calle 70", new DateTime(1966, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 83,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Coamo", "82634", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5934), "Calle 85", "Calle 69", new DateTime(1981, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 84,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "92574", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5948), "Calle 12", "Calle 96", new DateTime(1993, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 85,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Caguas", "86032", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(5989), "Calle 63", "Calle 16", new DateTime(1981, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 86,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "81483", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6001), "Calle 15", "Calle 37", new DateTime(1964, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 87,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "44512", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6014), "Calle 74", "Calle 69", new DateTime(1996, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 88,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Lares", "57461", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6026), "Calle 23", "Calle 73", new DateTime(1961, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 89,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Lajas", "80549", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6037), "Calle 51", "Calle 8", new DateTime(1968, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 90,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Arecibo", "50731", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6049), "Calle 63", "Calle 91", new DateTime(1980, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 91,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "45753", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6061), "Calle 90", "Calle 41", new DateTime(1981, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 92,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "74442", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6073), "Calle 79", "Calle 76", new DateTime(1973, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 93,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "24149", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6135), "Calle 94", "Calle 84", new DateTime(1972, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 94,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "58280", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6148), "Calle 87", "Calle 17", new DateTime(1999, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 95,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "34726", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6161), "Calle 84", "Calle 28", new DateTime(1981, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 96,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "87102", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6175), "Calle 59", "Calle 1", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 97,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Camuy", "94669", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6185), "Calle 58", "Calle 40", new DateTime(1987, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 98,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayama", "55699", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6198), "Calle 39", "Calle 98", new DateTime(1992, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 99,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "74924", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6211), "Calle 49", "Calle 62", new DateTime(1993, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 100,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "44563", new DateTime(2025, 2, 10, 23, 29, 15, 987, DateTimeKind.Local).AddTicks(6223), "Calle 7", "Calle 26", new DateTime(1969, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 1,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4200m, new DateTime(1983, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 85152m, 8839m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 2,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2626m, new DateTime(1984, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30395m, 9771m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 3,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7275m, new DateTime(1967, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10030m, 7729m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 4,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2487m, new DateTime(1975, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14694m, 1003m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 5,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9985m, new DateTime(1959, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 78383m, 1110m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 6,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6358m, new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 88744m, 5553m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 7,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4286m, new DateTime(1973, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 78777m, 2543m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 8,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2385m, new DateTime(1972, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 60412m, 5203m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 9,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9717m, new DateTime(1953, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 78743m, 4852m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 10,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1309m, new DateTime(1978, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 15837m, 9852m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 11,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9041m, new DateTime(1953, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 73151m, 4120m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 12,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1158m, new DateTime(1951, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 94928m, 7080m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 13,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4251m, new DateTime(1980, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 68683m, 9369m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 14,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7127m, new DateTime(1987, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 26921m, 6128m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 15,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9357m, new DateTime(1969, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 70576m, 2840m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 16,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1059m, new DateTime(1989, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 33671m, 5838m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 17,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4516m, new DateTime(1952, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 52967m, 4478m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 18,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3070m, new DateTime(1953, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43703m, 5908m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 19,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3609m, new DateTime(1973, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13254m, 8357m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 20,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8309m, new DateTime(1997, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16545m, 3089m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 21,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4074m, new DateTime(1999, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 62652m, 3125m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 22,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7483m, new DateTime(1979, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 62071m, 2066m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 23,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6576m, new DateTime(1957, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 34014m, 4399m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 24,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7709m, new DateTime(1958, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 39208m, 4985m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 25,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8685m, new DateTime(1988, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 26079m, 2826m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 26,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4149m, new DateTime(1978, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 90893m, 1337m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 27,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4261m, new DateTime(1983, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19566m, 1101m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 28,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4358m, new DateTime(1970, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43173m, 5384m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 29,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5784m, new DateTime(1974, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87304m, 8803m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 30,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2992m, new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 56589m, 8091m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 31,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4413m, new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11613m, 8989m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 32,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8207m, new DateTime(1981, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 46242m, 3047m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 33,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1147m, new DateTime(1950, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 17253m, 8860m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 34,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8764m, new DateTime(1975, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32082m, 3695m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 35,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4635m, new DateTime(1976, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 64935m, 7075m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 36,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2443m, new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 91731m, 8121m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 37,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7678m, new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 46198m, 5413m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 38,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8412m, new DateTime(1952, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 91965m, 4388m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 39,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3266m, new DateTime(1956, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30197m, 7346m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 40,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9064m, new DateTime(1973, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 66239m, 5711m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 41,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9050m, new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23886m, 5106m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 42,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8978m, new DateTime(1980, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32311m, 6720m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 43,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5910m, new DateTime(1966, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 32300m, 1376m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 44,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4378m, new DateTime(1971, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 38522m, 9337m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 45,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8827m, new DateTime(1956, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 56335m, 6080m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 46,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2470m, new DateTime(1973, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 66339m, 2537m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 47,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6833m, new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 89030m, 9159m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 48,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4734m, new DateTime(1959, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 78445m, 2576m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 49,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6340m, new DateTime(1996, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 62906m, 3418m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 50,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2181m, new DateTime(1987, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 89988m, 5001m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 51,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2282m, new DateTime(1986, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 29417m, 6259m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 52,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5220m, new DateTime(1986, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13790m, 2468m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 53,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3713m, new DateTime(1997, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 91220m, 8760m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 54,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1756m, new DateTime(1953, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 18267m, 6962m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 55,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4712m, new DateTime(1967, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 64091m, 2413m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 56,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5667m, new DateTime(1975, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 95812m, 8171m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 57,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5501m, new DateTime(1960, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 66976m, 3214m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 58,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9117m, new DateTime(1952, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22252m, 9947m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 59,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6108m, new DateTime(1960, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 38441m, 2745m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 60,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8045m, new DateTime(1987, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71303m, 2582m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 61,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4956m, new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 51503m, 1201m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 62,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4937m, new DateTime(1952, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 93610m, 9430m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 63,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4766m, new DateTime(1964, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 88305m, 6711m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 64,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5410m, new DateTime(1977, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70139m, 6398m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 65,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4130m, new DateTime(1956, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 85649m, 5673m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 66,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3455m, new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13261m, 7951m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 67,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3496m, new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 69052m, 9789m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 68,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2203m, new DateTime(1985, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25472m, 1723m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 69,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1704m, new DateTime(1975, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 96101m, 2067m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 70,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4958m, new DateTime(1979, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37442m, 1596m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 71,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7303m, new DateTime(1962, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 99767m, 2085m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 72,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6368m, new DateTime(1978, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 47592m, 1696m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 73,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4051m, new DateTime(1964, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26861m, 5114m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 74,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7058m, new DateTime(1966, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 94351m, 3579m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 75,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5943m, new DateTime(1953, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 74455m, 6349m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 76,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5378m, new DateTime(1972, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 29046m, 6057m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 77,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4626m, new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 85825m, 4389m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 78,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5723m, new DateTime(1957, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37820m, 9447m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 79,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9651m, new DateTime(1968, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 56315m, 3709m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 80,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2079m, new DateTime(1977, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32921m, 8166m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 81,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4235m, new DateTime(1957, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 95054m, 7758m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 82,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6234m, new DateTime(1954, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19167m, 8779m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 83,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5290m, new DateTime(1971, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 27039m, 5415m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 84,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7218m, new DateTime(1999, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 40787m, 8240m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 85,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6843m, new DateTime(1985, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35812m, 9365m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 86,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6364m, new DateTime(1962, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 90247m, 2684m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 87,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7072m, new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 55755m, 9798m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 88,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3242m, new DateTime(1951, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 58564m, 9271m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 89,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8790m, new DateTime(1988, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 85901m, 1391m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 90,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1349m, new DateTime(1950, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24542m, 7982m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 91,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3760m, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 79213m, 7855m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 92,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4634m, new DateTime(1978, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 75084m, 8083m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 93,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9137m, new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 66090m, 8980m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 94,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1514m, new DateTime(1972, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13170m, 8815m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 95,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7158m, new DateTime(1992, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 40408m, 3030m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 96,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7662m, new DateTime(1993, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 99582m, 4860m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 97,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9788m, new DateTime(1978, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36935m, 2759m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 98,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3955m, new DateTime(1952, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26585m, 4633m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 99,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9886m, new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15870m, 2104m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 100,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4759m, new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25542m, 5969m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 1,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 5504m, "Salario 2169" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 2,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3237m, "Salario 7957", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 3,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5387m, "Comision", "Salario 9918", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 4,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9997m, "Salario 5284", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 5,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3343m, "Otro", "Salario 8186", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 6,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8182m, "Salario", "Salario 1837", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 7,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5116m, "Bonos", "Salario 3030", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 8,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7343m, "Bonos", "Salario 9843", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 9,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9799m, "Salario 2943", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 10,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6810m, "Comision", "Salario 9949", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 11,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1167m, "Otro", "Salario 1076", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 12,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1161m, "Salario", "Salario 9846", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 13,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5814m, "Salario 4494", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 14,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3360m, "Otro", "Salario 8597", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 15,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9999m, "Comision", "Salario 2045", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 16,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3814m, "Otro", "Salario 6437", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 17,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2910m, "Bonos", "Salario 5285" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 18,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2488m, "Salario", "Salario 9464", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 19,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7069m, "Salario 4758", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 20,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1228m, "Otro", "Salario 4329", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 21,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7301m, "Salario 4850", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 22,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9709m, "Salario", "Salario 2052", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 23,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 4560m, "Otro", "Salario 3375" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 24,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1467m, "Bonos", "Salario 9727", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 25,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8356m, "Salario", "Salario 7570" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 26,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2483m, "Bonos", "Salario 1882", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 27,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6781m, "Salario 7216", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 28,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3656m, "Otro", "Salario 5489", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 29,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8805m, "Comision", "Salario 9329" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 30,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1104m, "Bonos", "Salario 5258", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 31,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2097m, "Comision", "Salario 8903" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 32,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6104m, "Salario", "Salario 1111", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 33,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3683m, "Bonos", "Salario 2384", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 34,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2988m, "Otro", "Salario 3343", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 35,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 4652m, "Salario 8464" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 36,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8482m, "Comision", "Salario 4452" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 37,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1663m, "Salario", "Salario 6895", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 38,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7195m, "Salario", "Salario 7108", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 39,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 9193m, "Salario 1091" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 40,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3281m, "Bonos", "Salario 1810", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 41,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8838m, "Bonos", "Salario 4164", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 42,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6088m, "Otro", "Salario 8093", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 43,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1996m, "Otro", "Salario 4716", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 44,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3363m, "Salario", "Salario 8562", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 45,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7278m, "Salario", "Salario 6826", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 46,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1527m, "Bonos", "Salario 6736" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 47,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4081m, "Bonos", "Salario 3317", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 48,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1376m, "Salario 9054", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 49,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2445m, "Bonos", "Salario 4690", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 50,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6573m, "Salario", "Salario 9977", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 51,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1593m, "Bonos", "Salario 1981", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 52,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4645m, "Salario", "Salario 7418", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 53,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1303m, "Comision", "Salario 9773", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 54,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2449m, "Otro", "Salario 1291" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 55,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2221m, "Bonos", "Salario 5893", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 56,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5206m, "Comision", "Salario 9616", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 57,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5993m, "Bonos", "Salario 7842", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 58,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5764m, "Comision", "Salario 9158", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 59,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9640m, "Bonos", "Salario 2263", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 60,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8163m, "Otro", "Salario 5545", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 61,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7163m, "Bonos", "Salario 1599", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 62,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7505m, "Comision", "Salario 9275", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 63,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 7413m, "Otro", "Salario 8562" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 64,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9677m, "Otro", "Salario 5925", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 65,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9386m, "Salario", "Salario 3053", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 66,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 6588m, "Bonos", "Salario 1801" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 67,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8414m, "Otro", "Salario 3944", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 68,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9119m, "Salario 2695", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 69,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7568m, "Otro", "Salario 3591", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 70,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8404m, "Otro", "Salario 7396", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 71,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3550m, "Bonos", "Salario 7218", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 72,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8086m, "Otro", "Salario 6875", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 73,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9988m, "Salario 9299", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 74,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3848m, "Bonos", "Salario 1777", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 75,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2421m, "Comision", "Salario 5730", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 76,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3686m, "Salario", "Salario 8440", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 77,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6582m, "Comision", "Salario 5031", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 78,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8887m, "Salario 4575", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 79,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9343m, "Salario", "Salario 4068", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 80,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1655m, "Salario 1786", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 81,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1805m, "Salario 5375", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 82,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3661m, "Salario", "Salario 2497", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 83,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1251m, "Bonos", "Salario 8299", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 84,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2895m, "Salario 7529", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 85,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1589m, "Salario 9562", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 86,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 6741m, "Salario 4476" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 87,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6865m, "Salario 4928", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 88,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6609m, "Bonos", "Salario 9510", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 89,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3744m, "Comision", "Salario 4628" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 90,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2567m, "Otro", "Salario 5887", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 91,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1951m, "Salario 5600", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 92,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3358m, "Salario", "Salario 8914", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 93,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6644m, "Salario", "Salario 9706", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 94,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7553m, "Bonos", "Salario 2945", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 95,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4130m, "Salario 4555", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 96,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4950m, "Comision", "Salario 9155", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 97,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5881m, "Salario 2161", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 98,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3552m, "Salario 9929", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 99,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1954m, "Salario 1097", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 100,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8964m, "Salario 4712", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 1,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "847566108", "Arrendataria", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 2,
                columns: new[] { "CasoActivo", "RMO", "TipoLink" },
                values: new object[] { true, "159099671", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 3,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "948890603", "Empleado", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 4,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "105438942", "Estudiante", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 5,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "913915850", "Maestra", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 6,
                columns: new[] { "CasoActivo", "RMO", "TipoLink" },
                values: new object[] { true, "278067445", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 7,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "400788253", "Sobrina", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 8,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "861977352", "Maestra", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 9,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "258814869", "Sobrina", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 10,
                columns: new[] { "CasoActivo", "RMO", "TipoLink" },
                values: new object[] { true, "574120078", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 11,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "991177235", "Otro", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 12,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "910739694", "Abuela", "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 13,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "879600810", "Enfermera", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 14,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "129145379", "Arrendador", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 15,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "471094878", "Tio", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 16,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "589262249", "Conocido", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 17,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "148326342", "Vecino", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 18,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "922034444", "Maestro", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 19,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "149178284", "Dueño", "Dueña" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 20,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "628198304", "Maestro", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 21,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "579902075", "Otro", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 22,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "144587356", "Inquilina", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 23,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "404452313", "Estudiante", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 24,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "261814878", "Madre", "Director" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 25,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "518593413", "Propietaria", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 26,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "613480382", "Novia", "Padre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 27,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "876115687", "Proveedor", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 28,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "864915444", "Estudiante", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 29,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "826744446", "Estudiante", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 30,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "123377447", "Estudiante", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 31,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "714623609", "Maestro", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 32,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "752600705", "Conocido", "Arrendatario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 33,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "848912567", "Sobrina", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 34,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "164115671", "Gerente", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 35,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "669966043", "Otro", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 36,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "712379220", "Arrendador", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 37,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "680411345", "Esposo", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 38,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "476629323", "Novia", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 39,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "646137909", "Compañero", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 40,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "787580199", "Compañero", "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 41,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "125443481", "Arrendataria", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 42,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "363319026", "Abuela", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 43,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "205145923", "Propietario", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 44,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "109854852", "Paciente", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 45,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "866323090", "Abuelo", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 46,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "778341383", "Enfermero", "Padre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 47,
                columns: new[] { "CasoActivo", "RMO", "Relacion" },
                values: new object[] { true, "183884481", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 48,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "472213025", "Empleado", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 49,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "590200976", "Empleada", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 50,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "158103594", "Proveedor", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 51,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "443910623", "Primo", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 52,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "808793851", "Prima", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 53,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "191234097", "Tio", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 54,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "538359864", "Hija", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 55,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "992400388", "Doctora", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 56,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "552490376", "Tio", "Arrendadora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 57,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "201402010", "Arrendadora", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 58,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "247662353", "Estudiante", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 59,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "346892812", "Tia", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 60,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "143572788", "Inquilina", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 61,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "517719081", "Conocida", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 62,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "857266925", "Jefe", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 63,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "536054806", "Dueña", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 64,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "305548444", "Sobrina", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 65,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "697981489", "Esposa", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 66,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "937284672", "Dueño", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 67,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "276812408", "Propietaria", "Propietario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 68,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "506868280", "Padre", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 69,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "914671053", "Novia", "Jefa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 70,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "953566509", "Amiga", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 71,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "154957647", "Paciente", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 72,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "751488997", "Director", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 73,
                columns: new[] { "CasoActivo", "RMO", "Relacion" },
                values: new object[] { true, "341575041", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 74,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "268084130", "Maestra", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 75,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "539488786", "Hija", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 76,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "901333050", "Empleada", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 77,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "529680493", "Esposo", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 78,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "544719711", "Hijo", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 79,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "536409171", "Proveedor", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 80,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "100678986", "Arrendador", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 81,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "380205819", "Hermana", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 82,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "579769048", "Estudiante", "Enfermero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 83,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "252322988", "Enfermera", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 84,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "668649758", "Gerente", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 85,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "291932985", "Vecino", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 86,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "644621640", "Jefa", "Jefa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 87,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "372759990", "Sobrino", "Propietario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 88,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "902340877", "Paciente", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 89,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "406475245", "Dueño", "Jefa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 90,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "645907829", "Dueña", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 91,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "210448990", "Abuela", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 92,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "216473130", "Esposa", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 93,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "948736877", "Proveedor", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 94,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "951163556", "Sobrino", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 95,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "593532366", "Jefa", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 96,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "965120501", "Enfermero", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 97,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "564546310", "Propietaria", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 98,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "566274816", "Padre", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 99,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "797807907", "Proveedor", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 100,
                columns: new[] { "CasoActivo", "RMO", "Relacion", "TipoLink" },
                values: new object[] { true, "107929304", "Primo", "Paciente" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CasoActivo",
                table: "Conf_Personas_Links");

            migrationBuilder.DropColumn(
                name: "Externo",
                table: "Conf_Personas");

            migrationBuilder.DropColumn(
                name: "Montly_Income",
                table: "Conf_Personas");

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4335), "Calle 47", "Calle 20", "correo74@correo.com", new DateTime(1991, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Lorena Ramirez", "Cayey", "Calle 63", "Calle 66", "46522", "Region 3", "Tipo 7", "83289" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Mayaguez", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4359), "Calle 22", "Calle 6", "correo6@correo.com", new DateTime(1953, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Jose Soto", "Juncos", "Calle 37", "Calle 2", "37308", "Region 9", "Tipo 4", "88957" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Barceloneta", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4381), "Calle 50", "Calle 83", "correo90@correo.com", new DateTime(1974, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Liliana Santoyo", "Anasco", "Calle 73", "Calle 3", "21398", "Region 5", "Tipo 2", "19787" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4402), "Calle 55", "Calle 90", "correo22@correo.com", new DateTime(1957, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Carlos Vazquez", "Juncos", "Calle 76", "Calle 35", "60397", "Region 8", "Tipo 5", "61637" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Barceloneta", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4473), "Calle 50", "Calle 4", "correo44@correo.com", new DateTime(1958, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Pedro Santillan", "Ciales", "Calle 51", "Calle 28", "51481", "Region 3", "80850" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayanilla", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4493), "Calle 29", "Calle 22", "correo58@correo.com", new DateTime(1967, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura Gonzalez", "Aguada", "Calle 58", "Calle 85", "57898", "Region 3", "Tipo 9", "41394" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Las Marias", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4513), "Calle 83", "Calle 27", "correo28@correo.com", new DateTime(1973, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa Ramirez", "Corozal", "Calle 74", "Calle 90", "70902", "Region 8", "38346" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4532), "Calle 30", "Calle 84", "correo7@correo.com", new DateTime(1977, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Rocio Santoyo", "Cayey", "Calle 18", "Calle 93", "96603", "Region 5", "Tipo 9", "47139" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayanilla", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4581), "Calle 43", "Calle 55", "correo62@correo.com", new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Pedro Santana", "Caguas", "Calle 5", "Calle 52", "11106", "Region 5", "Tipo 6", "56255" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4602), "Calle 91", "Calle 17", "correo32@correo.com", new DateTime(1955, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lorena Hernandez", "Catano", "Calle 12", "Calle 94", "35379", "Region 9", "Tipo 2", "24846" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Anasco", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4622), "Calle 55", "Calle 36", "correo35@correo.com", new DateTime(1972, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Jose Saucedo", "Vega Alta", "Calle 50", "Calle 74", "41789", "Region 4", "Tipo 1", "69074" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4640), "Calle 99", "Calle 85", "correo5@correo.com", new DateTime(1993, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Luis Jimenez", "Gurabo", "Calle 94", "Calle 26", "14363", "Region 3", "Tipo 9", "17604" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Anasco", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4661), "Calle 77", "Calle 10", "correo85@correo.com", new DateTime(1990, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Lorena Gomez", "Barceloneta", "Calle 79", "Calle 56", "75243", "Region 6", "Tipo 4", "42984" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4710), "Calle 49", "Calle 74", "correo50@correo.com", new DateTime(1956, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Laura Santana", "Fajardo", "Calle 77", "Calle 39", "70224", "Region 1", "Tipo 4", "71182" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CreateDate", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Jayuya", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4729), "Calle 20", "correo27@correo.com", new DateTime(1972, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Lourdes Santacruz", "Calle 90", "Calle 85", "51823", "Region 5", "Tipo 5", "15194" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Canovanas", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4748), "Calle 24", "Calle 62", "correo59@correo.com", new DateTime(1952, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Juan Santana", "Las Marias", "Calle 53", "Calle 19", "31007", "Region 4", "96299" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4769), "Calle 50", "Calle 28", "correo41@correo.com", new DateTime(1968, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Leticia Sosa", "Las Marias", "Calle 49", "Calle 97", "86902", "Region 5", "Tipo 9", "69992" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "San Juan", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4825), "Calle 78", "Calle 84", "correo38@correo.com", new DateTime(1982, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Luz Gonzalez", "Cataño", "Calle 32", "Calle 17", "63344", "Region 3", "Tipo 3", "52578" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4844), "Calle 25", "Calle 84", "correo91@correo.com", new DateTime(1999, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Luisa Reyes", "Guayanilla", "Calle 52", "Calle 40", "76598", "Region 7", "Tipo 9", "13318" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Florida", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4865), "Calle 47", "Calle 6", "correo22@correo.com", new DateTime(1979, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lourdes Santacruz", "Corozal", "Calle 93", "Calle 69", "88877", "Region 5", "Tipo 9", "95291" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Canovanas", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4887), "Calle 76", "Calle 61", "correo90@correo.com", new DateTime(1969, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Luis Torres", "Catano", "Calle 66", "Calle 28", "39061", "Region 8", "Tipo 6", "41033" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Anasco", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4932), "Calle 61", "Calle 5", "correo9@correo.com", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Rocio Santillan", "Barranquitas", "Calle 24", "Calle 88", "40875", "Region 5", "Tipo 7", "30224" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Coamo", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4950), "Calle 65", "Calle 85", "correo95@correo.com", new DateTime(1989, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Lilia Vazquez", "Vega Baja", "Calle 40", "Calle 48", "41854", "Region 8", "Tipo 2", "50930" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4969), "Calle 36", "Calle 29", "correo50@correo.com", new DateTime(1969, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Rocio Sosa", "Coamo", "Calle 98", "Calle 66", "68546", "Region 8", "Tipo 4", "75094" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(4990), "Calle 29", "Calle 15", "correo69@correo.com", new DateTime(1989, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Luisa Salazar", "Cataño", "Calle 85", "Calle 25", "59055", "Region 1", "Tipo 5", "10761" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5028), "Calle 64", "Calle 25", "correo38@correo.com", new DateTime(1989, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Juan Sosa", "Hatillo", "Calle 76", "Calle 15", "54043", "Region 4", "Tipo 7", "16174" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CreateDate", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5049), "Calle 48", "correo38@correo.com", new DateTime(1961, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Lorena Soto", "Toa Baja", "Calle 95", "Calle 23", "17366", "Tipo 3", "25910" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5080), "Calle 21", "Calle 74", "correo43@correo.com", new DateTime(1953, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Lidia Rojas", "Arroyo", "Calle 52", "Calle 62", "22757", "Tipo 4", "92406" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguada", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5113), "Calle 15", "Calle 22", "correo4@correo.com", new DateTime(1966, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leticia Sosa", "Catano", "Calle 12", "Calle 88", "37225", "Region 9", "Tipo 5", "94483" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Juncos", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5145), "Calle 69", "Calle 19", "correo93@correo.com", new DateTime(1952, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Lourdes Diaz", "Dorado", "Calle 13", "Calle 61", "67610", "Region 5", "Tipo 4", "46882" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5213), "Calle 13", "Calle 98", "correo68@correo.com", new DateTime(1960, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Luz Rojas", "Fajardo", "Calle 28", "Calle 39", "61905", "Region 6", "Tipo 8", "71975" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5239), "Calle 26", "Calle 84", "correo14@correo.com", new DateTime(1954, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Leticia Santacruz", "Calle 33", "Calle 52", "12047", "Region 7", "Tipo 8", "88406" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5267), "Calle 97", "Calle 47", "correo20@correo.com", new DateTime(1977, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Liz Santos", "Calle 2", "Calle 46", "46299", "Region 9", "Tipo 6", "84540" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Barceloneta", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5296), "Calle 32", "Calle 73", "correo95@correo.com", new DateTime(1955, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Diana Hernandez", "Lajas", "Calle 20", "Calle 17", "44795", "Region 4", "Tipo 1", "85872" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Las Marias", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5387), "Calle 44", "Calle 44", "correo86@correo.com", new DateTime(1957, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Pedro Rojas", "Florida", "Calle 26", "20003", "Region 7", "Tipo 7", "93350" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5415), "Calle 24", "Calle 97", "correo19@correo.com", new DateTime(1984, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Ricardo Gomez", "Guayanilla", "Calle 53", "Calle 87", "97570", "Region 8", "Tipo 7", "59663" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guanica", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5442), "Calle 69", "Calle 64", "correo46@correo.com", new DateTime(1950, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Maria Perez", "Toa Baja", "Calle 84", "Calle 78", "41702", "Tipo 9", "18421" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Trujillo Alto", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5469), "Calle 72", "Calle 68", "correo67@correo.com", new DateTime(1980, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Lorena Salazar", "Cidra", "Calle 81", "Calle 63", "16630", "Region 3", "Tipo 2", "17145" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5526), "Calle 3", "Calle 82", "correo16@correo.com", new DateTime(1953, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilia Santos", "Barranquitas", "Calle 33", "Calle 81", "98375", "Region 7", "Tipo 9", "64594" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayama", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5552), "Calle 83", "Calle 21", "correo75@correo.com", new DateTime(1953, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lidia Vazquez", "Dorado", "Calle 37", "Calle 48", "90914", "Region 6", "Tipo 2", "33724" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ponce", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5584), "Calle 94", "Calle 63", "correo37@correo.com", new DateTime(1950, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel Santana", "Aguadilla", "Calle 65", "Calle 53", "93513", "Region 1", "Tipo 2", "70413" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Camuy", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5610), "Calle 68", "Calle 7", "correo95@correo.com", new DateTime(1999, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Rosa Santibañez", "Toa Baja", "Calle 73", "Calle 35", "62605", "Region 1", "64550" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5671), "Calle 21", "Calle 51", "correo90@correo.com", new DateTime(1968, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Luisa Salazar", "Catano", "Calle 31", "Calle 60", "92847", "Region 6", "Tipo 3", "56918" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Caguas", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5697), "Calle 33", "Calle 57", "correo37@correo.com", new DateTime(1987, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Lidia Serrano", "Cataño", "Calle 50", "Calle 98", "25078", "Region 8", "Tipo 6", "48251" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "ZipCode" },
                values: new object[] { "Guanica", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5724), "Calle 39", "Calle 65", "correo22@correo.com", new DateTime(1982, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Pedro Santacruz", "Ceiba", "Calle 32", "Calle 44", "32677", "69213" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Baja", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5751), "Calle 67", "Calle 33", "correo46@correo.com", new DateTime(1950, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Liz Santacruz", "Fajardo", "Calle 42", "Calle 67", "78536", "Region 4", "Tipo 2", "33726" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Las Marias", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5807), "Calle 28", "Calle 65", "correo64@correo.com", new DateTime(1983, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Laura Santana", "Coamo", "Calle 99", "Calle 10", "30485", "Region 4", "Tipo 6", "67004" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5835), "Calle 20", "Calle 54", "correo21@correo.com", new DateTime(1997, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Lorena Lopez", "Coamo", "Calle 10", "Calle 26", "74759", "Tipo 5", "82635" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Fajardo", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5864), "Calle 21", "Calle 77", "correo95@correo.com", new DateTime(1962, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Rosa Hernandez", "Cayey", "Calle 14", "Calle 61", "39465", "Region 9", "Tipo 1", "10347" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "San Juan", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(5893), "Calle 30", "Calle 18", "correo95@correo.com", new DateTime(1965, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Rosa Santillan", "Cayey", "Calle 93", "Calle 52", "21811", "Region 7", "Tipo 5", "82993" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 1,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Martinez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6594), "Maestria", "Divorciado", new DateTime(1961, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Juncos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6457), "Maria", "Blanca", "Cristiana", "140451906", "939230124", "474653345", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 2,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Saucedo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6620), "Maestria", new DateTime(1986, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "M", "Anasco", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6597), "Jose", "Empleado", "Otro", "971487630", "898825997", "895660403", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 3,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Serrano", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6671), "Primaria", "Casado", "Africana", new DateTime(1951, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "L", "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6621), "Rocio", "Desempleado", "Otro", "251902082", "534648432", "754612694" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 4,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6692), "Secundaria", "Viudo", "Asiatica", new DateTime(1978, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "L", "Vega Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6672), "Elena", "Desempleado", "Amarilla", "Ateo", "606930767", "247054234", "693823807", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 5,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Santibañez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6714), "Preparatoria", "Soltero", "Mexicana", new DateTime(1988, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Maestria", "S", "Guayanilla", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6693), "Desempleado", "Cristiana", "656561831", "494759738", "504681740", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 6,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Santacruz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6737), "Divorciado", "Canadiense", new DateTime(1962, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Toa Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6717), "Lourdes", "Desempleado", "Amarilla", "Otro", "791136731", "565861824", "427971247", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 7,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Santos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6785), "Maestria", "Mexicana", new DateTime(1981, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "A", "Carolina", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6763), "Lidia", "Desempleado", "Morena", "Otro", "386339069", "647878218", "636782526", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 8,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6807), "Otro", "Soltero", "Canadiense", new DateTime(1957, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "Cidra", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6787), "Rosa", "Negra", "Agnostico", "111974763", "944253387", "117391455", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 9,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Santillana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6828), "Secundaria", "Otra", new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "L", "Fajardo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6808), "Ama de casa", "Blanca", "Testigo de Jehova", "287364133", "123356668", "892945719", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 10,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Rojas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6881), "Preparatoria", "Africana", new DateTime(1999, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Guanica", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6830), "Rosa", "Otro", "Negra", "Mormon", "185167574", "938238768", "404311965", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 11,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6903), new DateTime(1953, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "R", "Canovanas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6882), "Laura", "Blanca", "128138371", "445918497", "259092955", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 12,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Gonzalez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6925), "Otro", "Casado", new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6904), "Lourdes", "Empleado", "Morena", "Mormon", "745516532", "176304279", "143899921", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 13,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Ramirez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6946), "Primaria", "Casado", "Mexicana", new DateTime(1983, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "Las Marias", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6926), "Jorge", "Estudiante", "Blanca", "Testigo de Jehova", "711109535", "859095842", "284931548", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 14,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Santillan", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6997), "Doctorado", "Africana", new DateTime(1986, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6948), "Liliana", "Ama de casa", "Amarilla", "Catolica", "498657352", "302854726", "909010293", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 15,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7019), "Preparatoria", "Divorciado", "Africana", new DateTime(1990, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "J", "Florida", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(6998), "Maria", "Amarilla", "Agnostico", "950849466", "552182040", "553169796", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 16,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Gomez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7040), "Doctorado", "Soltero", new DateTime(1989, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "R", "Arecibo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7020), "Lidia", "Empleado", "Amarilla", "603998805", "412023187", "628073406", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 17,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Martinez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7062), "Preparatoria", "Otra", new DateTime(1981, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Maestria", "L", "Lajas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7041), "Luz", "Ama de casa", "Morena", "Agnostico", "129182254", "367867600", "192311354", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 18,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7105), "Primaria", "Soltero", "Europea", new DateTime(1982, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "Ciales", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7064), "Fernando", "Amarilla", "Testigo de Jehova", "353504020", "654120068", "155197518", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 19,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Sandoval", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7128), "Secundaria", "Divorciado", "Otra", new DateTime(1955, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "D", "Toa Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7106), "Luis", "Empleado", "Amarilla", "Cristiana", "323901384", "379321633", "906780234", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 20,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Perez", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7149), "Secundaria", "Viudo", "Estadounidense", new DateTime(1979, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7129), "Lorena", "Otro", "Amarilla", "Catolica", "436519417", "679722027", "134868136" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 21,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Santos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7170), "Divorciado", "Mexicana", new DateTime(1962, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "L", "Camuy", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7150), "Luz", "Catolica", "677473719", "126810475", "507732338", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 22,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Martinez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7227), "Doctorado", "Casado", new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7171), "Juan", "Desempleado", "Negra", "Testigo de Jehova", "286290993", "595013278", "678198818", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 23,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Santoyo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7249), "Canadiense", new DateTime(1983, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "L", "Cabo Rojo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7228), "Rosa", "Jubilado", "Morena", "Testigo de Jehova", "620073677", "269207093", "302132159", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 24,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Santoyo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7270), "Maestria", "Viudo", new DateTime(1983, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Primaria", "D", "Cabo Rojo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7250), "Ana", "Cristiana", "870969019", "691794693", "131740060", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 25,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Rojas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7292), "Soltero", "Mexicana", new DateTime(1954, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "Cayey", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7271), "Laura", "Otra", "Agnostico", "129012064", "560303219", "997960250", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 26,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santibañez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7350), "Otro", "Divorciado", new DateTime(1957, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "L", "Toa Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7293), "Rosa", "Estudiante", "Cristiana", "542697974", "386305162", "548686891", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 27,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Perez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7372), "Otro", "Soltero", "Asiatica", new DateTime(1970, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Toa Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7351), "Juan", "Otro", "Amarilla", "Otro", "860857063", "808367478", "902167061", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 28,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Ramirez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7393), "Secundaria", "Viudo", "Africana", new DateTime(1993, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "L", "Juana Diaz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7373), "Luz Elena", "Ama de casa", "Blanca", "Cristiana", "170158119", "655808667", "486545052", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 29,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7415), "Licenciatura", "Mexicana", new DateTime(1975, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "L", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7394), "Lorena", "Jubilado", "Blanca", "Cristiana", "924955818", "697686077", "364158808", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 30,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Diaz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7465), "Africana", new DateTime(1951, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "R", "Carolina", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7443), "Rosa", "Jubilado", "Morena", "Agnostico", "618230895", "545498364", "260201264", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 31,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Torres", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7486), "Secundaria", "Viudo", "Africana", new DateTime(1955, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "E", "Arecibo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7466), "Pedro", "Estudiante", "Negra", "Otro", "497285551", "396234722", "920992191", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 32,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7507), "Secundaria", "Africana", new DateTime(1954, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "J", "Caguas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7487), "Liliana", "Estudiante", "Catolica", "550979448", "484191027", "764859308", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 33,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7529), "Preparatoria", "Casado", "Asiatica", new DateTime(1994, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "L", "Cayey", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7508), "Miguel", "Jubilado", "Catolica", "476034604", "105237286", "803416379", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 34,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Soto", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7579), "Secundaria", "Viudo", "Mexicana", new DateTime(1981, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "R", "Gurabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7557), "Elena", "Estudiante", "Morena", "Testigo de Jehova", "339622935", "321734919", "518063678", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 35,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7600), "Licenciatura", "Divorciado", "Otra", new DateTime(1978, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Cataño", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7580), "Luz Elena", "Jubilado", "Blanca", "Cristiana", "858376676", "727951872", "812563712", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 36,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Saucedo", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7622), "Preparatoria", "Canadiense", new DateTime(1958, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "R", "Toa Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7601), "Lourdes", "Desempleado", "Negra", "Catolica", "495093862", "885147413", "181331018" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 37,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Santillana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7668), "Secundaria", new DateTime(1952, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Caguas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7623), "Pedro", "Ama de casa", "Catolica", "972539646", "900994455", "144592784", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 38,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Gomez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7690), "Preparatoria", "Soltero", "Otra", new DateTime(1950, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "L", "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7669), "Ama de casa", "Negra", "Mormon", "315377028", "203243264", "148952069", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 39,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7711), "Maestria", "Divorciado", new DateTime(1960, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "C", "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7691), "Luz", "Otro", "Amarilla", "Mormon", "353761149", "477854363", "139429207", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 40,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Torres", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7733), "Maestria", "Casado", "Canadiense", new DateTime(1991, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "F", "Carolina", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7712), "Carmen", "Jubilado", "Morena", "Cristiana", "164695075", "802600955", "369334971", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 41,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7780), "Preparatoria", "Divorciado", "Africana", new DateTime(1965, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "J", "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7734), "Liliana", "Otra", "Otro", "728142135", "303019148", "292398916", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 42,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7801), "Secundaria", "Divorciado", "Mexicana", new DateTime(1962, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "L", "Dorado", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7781), "Jorge", "Otro", "Negra", "Mormon", "256351412", "751268534", "620867030", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 43,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7823), "Primaria", "Soltero", "Canadiense", new DateTime(1965, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "L", "Mayaguez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7802), "Carmen", "Desempleado", "Testigo de Jehova", "114770603", "792557279", "583426567", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 44,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Sandoval", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7844), "Secundaria", "Mexicana", new DateTime(1972, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "Arroyo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7824), "Pedro", "Ama de casa", "Testigo de Jehova", "999679518", "403768613", "973441960", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 45,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Sosa", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7890), "Secundaria", "Viudo", "Africana", new DateTime(1963, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "M", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7845), "Carmen", "Desempleado", "Cristiana", "460215520", "707458701", "911022607", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 46,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Santos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7911), "Otro", "Casado", "Europea", new DateTime(1993, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "Aguadilla", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7891), "Rosa", "Desempleado", "Blanca", "115057485", "766217313", "514074009", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 47,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Santillan", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7933), "Maestria", "Soltero", "Europea", new DateTime(1957, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7912), "Luz Maria", "Estudiante", "Blanca", "Ateo", "141663308", "828464689", "832733276", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 48,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7955), "Licenciatura", "Soltero", new DateTime(1993, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7934), "Leticia", "Ama de casa", "497986678", "976290098", "217279672", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 49,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santacruz", "Sandoval", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7994), "Casado", "Mexicana", new DateTime(1959, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "M", "Cataño", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7956), "Liz", "Empleado", "Amarilla", "Agnostico", "773023612", "914837792", "637040453" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 50,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Gonzalez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8015), "Divorciado", "Estadounidense", new DateTime(1962, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(7995), "Maria", "Empleado", "Negra", "567982609", "187338725", "879247952", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 51,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Salazar", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8037), "Licenciatura", "Divorciado", "Estadounidense", new DateTime(1969, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "S", "Florida", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8016), "Luz", "Estudiante", "Blanca", "Mormon", "604278556", "660586014", "276674191", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 52,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Sosa", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8060), "Primaria", "Soltero", new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "P", "Toa Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8038), "Leticia", "Amarilla", "Mormon", "771270583", "482340701", "310519635", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 53,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Hernandez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8114), "Primaria", "Casado", "Africana", new DateTime(1991, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "J", "Coamo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8091), "Liliana", "Morena", "Cristiana", "303776576", "306393615", "176801510", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 54,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santillana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8134), "Maestria", "Viudo", "Estadounidense", new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "R", "Aguadilla", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8115), "Raul", "Testigo de Jehova", "888594075", "243832766", "597231372", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 55,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Garcia", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8156), "Secundaria", "Casado", "Africana", new DateTime(1970, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Guayama", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8135), "Liliana", "Otra", "706844700", "457958977", "779221653" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 56,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8178), "Maestria", "Divorciado", "Mexicana", new DateTime(1986, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "M", "Barceloneta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8157), "Carlos", "Empleado", "Otra", "Otro", "236728616", "919251291", "890287165", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 57,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Reyes", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8236), "Otro", "Viudo", "Canadiense", new DateTime(1962, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "J", "Guayanilla", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8215), "Pedro", "Empleado", "Negra", "Mormon", "244497804", "221209968", "528384373", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 58,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Torres", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8257), "Divorciado", "Mexicana", new DateTime(1957, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "R", "Toa Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8237), "Sofia", "Desempleado", "Otra", "Agnostico", "590874449", "722141927", "354877191", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 59,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Suarez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8278), "Maestria", "Soltero", "Canadiense", new DateTime(1967, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "R", "Cataño", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8258), "Carmen", "Desempleado", "Amarilla", "Agnostico", "187205729", "110443354", "604896916", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 60,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Saucedo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8325), "Europea", new DateTime(1972, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "J", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8279), "Liliana", "Ama de casa", "102806543", "506246280", "230679728", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 61,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Saucedo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8347), new DateTime(1958, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "J", "Guanica", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8326), "Lilia", "Otro", "Negra", "Ateo", "950175458", "326832214", "334485530", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 62,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Gomez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8369), "Secundaria", "Casado", "Africana", new DateTime(1959, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "M", "Arecibo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8348), "Diana", "Empleado", "Otra", "Mormon", "813666906", "241750805", "363309096", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 63,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Garcia", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8390), "Maestria", "Viudo", "Estadounidense", new DateTime(1993, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Maestria", "L", "Hormigueros", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8370), "Carmen", "Desempleado", "Blanca", "Ateo", "964127727", "529696489", "716271706", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 64,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Rojas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8459), "Maestria", "Asiatica", new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "Florida", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8391), "Luisa", "Jubilado", "Testigo de Jehova", "978641607", "996329766", "496438943", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 65,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Lopez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8481), "Preparatoria", "Divorciado", new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "Juncos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8460), "Sofia", "Morena", "Cristiana", "810581218", "609914444", "965524483", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 66,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Lopez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8505), "Maestria", "Soltero", "Otra", new DateTime(1958, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Caguas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8484), "Liliana", "Desempleado", "Negra", "Cristiana", "318834447", "227935855", "211571059", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 67,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Serrano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8526), "Doctorado", "Soltero", "Africana", new DateTime(1955, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "R", "Catano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8506), "Ricardo", "Ama de casa", "Amarilla", "Testigo de Jehova", "900780548", "641533726", "456460172", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 68,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Salazar", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8577), "Secundaria", "Soltero", "Mexicana", new DateTime(1952, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "R", "Juana Diaz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8527), "Rocio", "Jubilado", "Negra", "Cristiana", "103832596", "305849591", "201116923", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 69,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Reyes", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8598), "Maestria", "Soltero", "Europea", new DateTime(1977, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "San Juan", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8577), "Sofia", "Blanca", "Ateo", "942276137", "433047300", "118568138", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 70,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santillan", "Saucedo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8619), "Secundaria", "Soltero", "Africana", new DateTime(1986, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "L", "Trujillo Alto", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8599), "Juan", "Morena", "Testigo de Jehova", "422847886", "424463018", "715002179" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 71,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8640), "Doctorado", "Viudo", "Mexicana", new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Catano", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8620), "Sofia", "Jubilado", "Mormon", "412072024", "676698225", "683371943", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 72,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Salazar", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8703), "Primaria", "Casado", "Mexicana", new DateTime(1995, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "M", "Corozal", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8679), "Lidia", "Empleado", "Amarilla", "Agnostico", "314477144", "129430474", "854764522", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 73,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Sosa", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8724), "Divorciado", "Africana", new DateTime(1950, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "Aguas Buenas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8704), "Raul", "Jubilado", "Amarilla", "Otro", "974369842", "163312928", "390748355", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 74,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Salazar", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8746), "Primaria", "Divorciado", new DateTime(1950, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "M", "Canovanas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8725), "Luisa", "Desempleado", "Amarilla", "780370707", "748298079", "647157225", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 75,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Santibañez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8794), "Doctorado", "Soltero", "Africana", new DateTime(1979, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "Gurabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8747), "Luz Elena", "Catolica", "190200308", "873259663", "653282874", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 76,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Soto", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8815), "Secundaria", "Divorciado", "Africana", new DateTime(1981, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "E", "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8795), "Lilia", "Ama de casa", "Otra", "Testigo de Jehova", "606510249", "464333996", "286246310", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 77,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Diaz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8837), "Secundaria", "Soltero", "Canadiense", new DateTime(1989, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "L", "Cayey", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8816), "Lorena", "Empleado", "Mormon", "823781594", "981162781", "330640242", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 78,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Gomez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8859), "Maestria", "Casado", "Europea", new DateTime(1974, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "R", "Toa Alta", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8838), "Laura", "Jubilado", "Amarilla", "Catolica", "959714619", "621268454", "950697681", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 79,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Ramirez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8905), "Maestria", new DateTime(1973, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8859), "Miguel", "Ama de casa", "Agnostico", "493095921", "755660705", "497396945", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 80,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8928), "Preparatoria", "Casado", "Africana", new DateTime(1984, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "M", "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8906), "Lourdes", "Jubilado", "Morena", "986103986", "685852428", "998511350", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 81,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8949), "Licenciatura", "Divorciado", "Africana", new DateTime(1952, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "C", "Florida", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8929), "Lourdes", "Jubilado", "Morena", "Ateo", "296619171", "172768234", "739268061", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 82,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Santos", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8970), "Doctorado", "Casado", "Estadounidense", new DateTime(1951, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "D", "Caguas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8950), "Raul", "Desempleado", "Morena", "Mormon", "136991980", "198661298", "683488894", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 83,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Santoyo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9009), "Otro", "Divorciado", "Europea", new DateTime(1968, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "L", "Trujillo Alto", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(8971), "Liliana", "Catolica", "831599865", "884479837", "929566797", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 84,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9030), "Viudo", "Canadiense", new DateTime(1988, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "C", "Barranquitas", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9010), "Otro", "Otra", "Otro", "313072734", "190782447", "238492745", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 85,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Saucedo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9052), new DateTime(1953, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "Cidra", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9031), "Sofia", "Ama de casa", "Otra", "Agnostico", "775321088", "594277661", "522241136", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 86,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Suarez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9073), "Doctorado", "Soltero", new DateTime(1988, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9053), "Fernando", "Blanca", "880971627", "880898026", "834686526", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 87,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Santacruz", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9130), "Primaria", "Divorciado", "Europea", new DateTime(1978, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9074), "Luis", "Desempleado", "Otra", "138519625", "711876117", "242776908", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 88,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9151), "Secundaria", new DateTime(1961, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "J", "Culebra", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9131), "Rosa", "Ama de casa", "Negra", "Catolica", "547837361", "238236295", "254115890", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 89,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Sosa", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9173), "Casado", "Canadiense", new DateTime(1955, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "L", "Fajardo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9152), "Desempleado", "Amarilla", "Testigo de Jehova", "860699574", "793391247", "879088529", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 90,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Gonzalez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9194), "Soltero", "Mexicana", new DateTime(1953, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "Aibonito", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9174), "Luz", "Cristiana", "905903722", "490089368", "571218101", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 91,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Gonzalez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9251), "Licenciatura", "Casado", "Otra", new DateTime(1972, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "R", "Bayamon", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9195), "Luz Elena", "Estudiante", "Morena", "Otro", "541244960", "202087035", "492508455", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 92,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Hernandez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9272), "Otro", "Asiatica", new DateTime(1999, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "Cidra", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9252), "Liz", "Jubilado", "Negra", "Ateo", "741363124", "253925633", "633186923", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 93,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Silva", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9294), "Viudo", "Estadounidense", new DateTime(1999, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", "Ciales", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9273), "Luz Elena", "Ama de casa", "Agnostico", "809169195", "156799582", "159023484", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 94,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Lopez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9315), "Preparatoria", "Viudo", "Africana", new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "Vega Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9295), "Rosa", "Estudiante", "Morena", "Mormon", "449493535", "273806927", "919396181", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 95,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Santibañez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9364), "Secundaria", "Casado", "Otra", new DateTime(1999, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "San Juan", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9316), "Elena", "Negra", "Testigo de Jehova", "834833412", "108707395", "304370257", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 96,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Santoyo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9385), "Licenciatura", "Viudo", "Mexicana", new DateTime(1976, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Guaynabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9365), "Luz Maria", "Desempleado", "Blanca", "Mormon", "223100804", "458000327", "624478549", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 97,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9407), "Otro", "Casado", "Otra", new DateTime(1985, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "Arecibo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9386), "Maria", "Desempleado", "Morena", "Cristiana", "550918322", "870142855", "223786976", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 98,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Gonzalez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9427), "Secundaria", new DateTime(1950, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "P", "Toa Baja", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9408), "Leticia", "Desempleado", "Blanca", "Testigo de Jehova", "467587475", "424538446", "128455127", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 99,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Hernandez", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9474), "Secundaria", "Divorciado", "Mexicana", new DateTime(1954, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "R", "Guanica", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9428), "Luisa", "Otro", "Blanca", "Testigo de Jehova", "482664957", "400039311", "226849711", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 100,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Santana", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9497), "Licenciatura", "Canadiense", new DateTime(1968, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "L", "Gurabo", new DateTime(2024, 12, 3, 18, 2, 48, 921, DateTimeKind.Local).AddTicks(9475), "Liz", "Estudiante", "Blanca", "899826651", "682240135", "766785453", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "22968", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1666), "Calle 84", "Calle 56", new DateTime(1974, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hormigueros", "32249", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1684), "Calle 52", "Calle 93", new DateTime(1989, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "89979", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1699), "Calle 67", "Calle 71", new DateTime(1981, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Florida", "22670", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1715), "Calle 51", "Calle 54", new DateTime(1982, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguadilla", "98737", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1729), "Calle 46", "Calle 55", new DateTime(1957, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Isabela", "31044", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1744), "Calle 8", "Calle 55", new DateTime(1964, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Hormigueros", "14184", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1785), "Calle 60", "Calle 75", new DateTime(1976, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "73419", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1798), "Calle 53", "Calle 57", new DateTime(1997, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barranquitas", "45024", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1811), "Calle 84", "Calle 8", new DateTime(1986, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "98905", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1826), "Calle 63", "Calle 70", new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Toa Baja", "30445", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1839), "Calle 75", "Calle 47", new DateTime(1955, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "67820", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1851), "Calle 21", "Calle 54", new DateTime(1977, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "73945", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1864), "Calle 64", "Calle 54", new DateTime(1974, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "44509", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1876), "Calle 46", "Calle 53", new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lares", "14848", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1916), "Calle 22", "Calle 86", new DateTime(1999, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Caguas", "52965", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1929), "Calle 11", "Calle 37", new DateTime(1986, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "73247", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1943), "Calle 59", "Calle 24", new DateTime(1986, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "49884", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1957), "Calle 90", "Calle 1", new DateTime(1988, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cidra", "72573", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1970), "Calle 36", "Calle 36", new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "12539", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1982), "Calle 65", "Calle 70", new DateTime(1964, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguas Buenas", "32490", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(1996), "Calle 82", "Calle 49", new DateTime(1959, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arecibo", "61742", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2025), "Calle 9", "Calle 34", new DateTime(1980, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "12008", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2038), "Calle 82", "Calle 81", new DateTime(1982, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hormigueros", "17025", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2053), "Calle 6", "Calle 5", new DateTime(1973, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Camuy", "64099", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2065), "Calle 54", new DateTime(1966, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "98519", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2078), "Calle 93", "Calle 37", new DateTime(1974, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "37847", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2090), "Calle 63", "Calle 90", new DateTime(1968, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "72973", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2104), "Calle 61", "Calle 48", new DateTime(1976, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "34811", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2118), "Calle 96", "Calle 83", new DateTime(1997, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "58164", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2164), "Calle 52", "Calle 91", new DateTime(1969, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barceloneta", "61748", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2177), "Calle 49", "Calle 23", new DateTime(1978, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Marias", "52601", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2188), "Calle 85", "Calle 19", new DateTime(1980, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Bayamon", "40467", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2200), "Calle 51", "Calle 22", new DateTime(1982, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "63340", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2216), "Calle 81", "Calle 79", new DateTime(1957, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hatillo", "98962", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2230), "Calle 99", "Calle 18", new DateTime(1954, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cayey", "46104", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2243), "Calle 17", "Calle 72", new DateTime(1952, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Anasco", "58309", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2296), "Calle 12", "Calle 13", new DateTime(1971, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Corozal", "42726", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2311), "Calle 69", "Calle 92", new DateTime(1975, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "47815", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2325), "Calle 3", "Calle 8", new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hormigueros", "48983", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2337), "Calle 40", "Calle 70", new DateTime(1996, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "54604", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2349), "Calle 77", "Calle 60", new DateTime(1983, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "50029", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2361), "Calle 54", "Calle 63", new DateTime(1965, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Anasco", "15391", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2373), "Calle 79", "Calle 52", new DateTime(1990, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "98171", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2384), "Calle 73", "Calle 49", new DateTime(1990, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Coamo", "51753", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2423), "Calle 97", "Calle 96", new DateTime(1965, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "22334", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2436), "Calle 35", "Calle 3", new DateTime(1973, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cataño", "91781", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2449), "Calle 26", "Calle 26", new DateTime(1965, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "18024", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2460), "Calle 68", "Calle 94", new DateTime(1951, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "23659", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2473), "Calle 80", "Calle 14", new DateTime(1982, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Las Piedras", "97359", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2485), "Calle 35", "Calle 57", new DateTime(1998, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 51,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio" },
                values: new object[] { "Culebra", "81422", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2497), "Calle 94", new DateTime(1952, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 52,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "69063", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2508), "Calle 56", "Calle 9", new DateTime(1951, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 53,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Canovanas", "32235", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2546), "Calle 57", "Calle 13", new DateTime(1958, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 54,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arecibo", "71738", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2560), "Calle 98", "Calle 87", new DateTime(1989, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 55,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "83118", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2572), "Calle 65", "Calle 70", new DateTime(1967, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 56,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "10339", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2582), "Calle 56", "Calle 97", new DateTime(1987, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 57,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barranquitas", "20045", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2595), "Calle 50", "Calle 91", new DateTime(1985, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 58,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "58218", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2609), "Calle 31", "Calle 96", new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 59,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "26536", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2621), "Calle 82", "Calle 84", new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 60,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Bayamon", "77514", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2662), "Calle 22", "Calle 17", new DateTime(1968, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 61,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Florida", "71913", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2676), "Calle 10", "Calle 47", new DateTime(1961, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 62,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "80067", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2689), "Calle 76", "Calle 98", new DateTime(1980, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 63,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Gurabo", "97456", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2701), "Calle 47", "Calle 94", new DateTime(1955, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 64,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aibonito", "38608", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2712), "Calle 42", "Calle 79", new DateTime(1958, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 65,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barceloneta", "44152", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2724), "Calle 49", "Calle 51", new DateTime(1960, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 66,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Canovanas", "14570", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2737), "Calle 83", "Calle 76", new DateTime(1963, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 67,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "61977", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2773), "Calle 8", "Calle 70", new DateTime(1983, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 68,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "90757", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2785), "Calle 6", "Calle 4", new DateTime(1996, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 69,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Trujillo Alto", "36715", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2797), "Calle 29", "Calle 75", new DateTime(1977, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 70,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "93647", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2810), "Calle 62", "Calle 4", new DateTime(1959, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 71,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Mayaguez", "66561", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2822), "Calle 32", "Calle 72", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 72,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "74982", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2833), "Calle 82", "Calle 19", new DateTime(1995, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 73,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguadilla", "90799", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2846), "Calle 9", "Calle 65", new DateTime(1954, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 74,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "34408", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2858), "Calle 72", "Calle 26", new DateTime(1981, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 75,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cataño", "72433", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2893), "Calle 36", "Calle 80", new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 76,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "18474", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2907), "Calle 7", "Calle 27", new DateTime(1954, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 77,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "50090", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2919), "Calle 30", "Calle 83", new DateTime(1953, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 78,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "11462", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2932), "Calle 89", "Calle 17", new DateTime(1994, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 79,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "85397", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2946), "Calle 48", "Calle 2", new DateTime(1951, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 80,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Culebra", "92821", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2957), "Calle 82", "Calle 4", new DateTime(1968, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 81,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayanilla", "92192", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2969), "Calle 95", "Calle 48", new DateTime(1986, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 82,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "62948", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(2985), "Calle 41", "Calle 78", new DateTime(1968, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 83,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "79029", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3013), "Calle 1", "Calle 78", new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 84,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Fajardo", "11246", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3025), "Calle 63", "Calle 46", new DateTime(1964, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 85,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Arecibo", "71457", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3036), "Calle 41", "Calle 72", new DateTime(1957, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 86,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayanilla", "30842", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3049), "Calle 8", "Calle 84", new DateTime(1955, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 87,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "43186", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3061), "Calle 63", "Calle 49", new DateTime(1953, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 88,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cabo Rojo", "25523", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3073), "Calle 18", "Calle 85", new DateTime(1970, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 89,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guaynabo", "20721", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3087), "Calle 43", "Calle 58", new DateTime(1977, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 90,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Corozal", "28001", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3099), "Calle 62", "Calle 52", new DateTime(1977, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 91,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "87126", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3143), "Calle 25", "Calle 66", new DateTime(1988, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 92,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Alta", "71396", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3155), "Calle 40", "Calle 73", new DateTime(1984, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 93,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Mayaguez", "60379", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3167), "Calle 27", "Calle 26", new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 94,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Isabela", "70540", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3180), "Calle 58", "Calle 76", new DateTime(1995, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 95,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "68267", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3192), "Calle 24", "Calle 37", new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 96,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ceiba", "35240", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3205), "Calle 82", "Calle 44", new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 97,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Juncos", "13739", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3217), "Calle 86", "Calle 54", new DateTime(1986, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 98,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "50656", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3263), "Calle 93", "Calle 70", new DateTime(1964, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 99,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aibonito", "52064", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3276), "Calle 56", "Calle 35", new DateTime(1995, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 100,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "72301", new DateTime(2024, 12, 3, 18, 2, 48, 922, DateTimeKind.Local).AddTicks(3287), "Calle 29", "Calle 87", new DateTime(1973, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 1,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9782m, new DateTime(1970, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32247m, 9193m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 2,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5388m, new DateTime(1983, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20530m, 4477m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 3,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5733m, new DateTime(1952, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22096m, 9211m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 4,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1349m, new DateTime(1951, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21487m, 5759m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 5,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4034m, new DateTime(1978, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20732m, 1702m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 6,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6443m, new DateTime(1987, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 78198m, 8367m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 7,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4120m, new DateTime(1977, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 48013m, 4483m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 8,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7830m, new DateTime(1995, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 52032m, 5538m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 9,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8483m, new DateTime(1988, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 79373m, 8211m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 10,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2595m, new DateTime(1992, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20634m, 8843m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 11,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8400m, new DateTime(1971, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 86706m, 1321m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 12,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5541m, new DateTime(1970, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37652m, 4283m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 13,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1772m, new DateTime(1966, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 67932m, 7152m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 14,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9558m, new DateTime(1979, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 45087m, 3811m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 15,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6680m, new DateTime(1950, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35857m, 1973m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 16,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6634m, new DateTime(1965, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 32595m, 3361m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 17,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6069m, new DateTime(1961, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 42217m, 5627m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 18,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8460m, new DateTime(1999, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 77322m, 4511m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 19,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2340m, new DateTime(1982, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93561m, 4218m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 20,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8455m, new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70177m, 9141m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 21,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2981m, new DateTime(1999, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46288m, 3673m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 22,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3447m, new DateTime(1955, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26022m, 5116m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 23,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7448m, new DateTime(1967, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32923m, 6138m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 24,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1370m, new DateTime(1983, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 77067m, 5702m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 25,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9209m, new DateTime(1973, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 23218m, 1622m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 26,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8085m, new DateTime(1979, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27621m, 4965m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 27,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5670m, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24822m, 2300m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 28,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5066m, new DateTime(1982, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 69963m, 1441m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 29,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1532m, new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 73017m, 2607m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 30,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3190m, new DateTime(1985, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 37328m, 5393m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 31,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3614m, new DateTime(1954, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20252m, 4137m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 32,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8919m, new DateTime(1993, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 28157m, 6431m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 33,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9065m, new DateTime(1992, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 99197m, 8484m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 34,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4734m, new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 49675m, 7652m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 35,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3637m, new DateTime(1965, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 52474m, 4196m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 36,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5568m, new DateTime(1967, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28558m, 6280m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 37,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4745m, new DateTime(1975, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11342m, 7438m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 38,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8606m, new DateTime(1984, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 75493m, 7549m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 39,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3709m, new DateTime(1979, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 56978m, 8147m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 40,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9958m, new DateTime(1992, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16491m, 4748m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 41,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2967m, new DateTime(1982, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95906m, 9197m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 42,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2100m, new DateTime(1986, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23409m, 2910m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 43,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8743m, new DateTime(1976, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 44288m, 9259m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 44,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6128m, new DateTime(1988, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 98798m, 3940m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 45,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7130m, new DateTime(1958, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28046m, 7264m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 46,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7819m, new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 41576m, 2117m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 47,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8676m, new DateTime(1959, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 88781m, 8930m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 48,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4383m, new DateTime(1994, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 53984m, 3329m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 49,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3702m, new DateTime(1997, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 68115m, 8448m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 50,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9321m, new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 44032m, 9232m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 51,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1783m, new DateTime(1980, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48148m, 2412m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 52,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5789m, new DateTime(1993, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11658m, 6392m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 53,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2882m, new DateTime(1984, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24812m, 9541m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 54,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5643m, new DateTime(1994, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 53615m, 9290m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 55,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9633m, new DateTime(1985, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 54750m, 9441m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 56,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5917m, new DateTime(1961, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 39642m, 7386m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 57,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1103m, new DateTime(1978, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 96472m, 6983m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 58,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2349m, new DateTime(1956, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 46210m, 6803m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 59,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9437m, new DateTime(1955, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20765m, 3093m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 60,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4796m, new DateTime(1985, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 45350m, 7283m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 61,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2235m, new DateTime(1985, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 87279m, 9832m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 62,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2395m, new DateTime(1978, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49448m, 5530m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 63,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5403m, new DateTime(1993, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 70711m, 9909m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 64,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3927m, new DateTime(1960, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 92097m, 4988m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 65,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6519m, new DateTime(1979, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 98255m, 3229m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 66,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6780m, new DateTime(1992, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 76775m, 6910m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 67,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4718m, new DateTime(1957, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 69686m, 5487m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 68,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5308m, new DateTime(1966, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23225m, 4651m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 69,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6966m, new DateTime(1967, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10726m, 4505m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 70,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5643m, new DateTime(1967, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 49578m, 3318m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 71,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8320m, new DateTime(1986, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 85591m, 8802m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 72,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2623m, new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44449m, 6766m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 73,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2795m, new DateTime(1957, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95276m, 6480m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 74,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6337m, new DateTime(1992, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12429m, 3817m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 75,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9036m, new DateTime(1984, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40004m, 3338m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 76,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5319m, new DateTime(1953, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 83930m, 5707m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 77,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2042m, new DateTime(1980, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 47133m, 6589m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 78,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8370m, new DateTime(1967, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 57595m, 7570m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 79,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1181m, new DateTime(1978, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 42892m, 8633m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 80,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7854m, new DateTime(1953, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 65931m, 7196m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 81,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6737m, new DateTime(1985, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36730m, 9135m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 82,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6673m, new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14432m, 6016m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 83,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8151m, new DateTime(1970, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 75417m, 5905m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 84,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1059m, new DateTime(1978, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 91124m, 2223m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 85,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1013m, new DateTime(1963, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35920m, 5861m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 86,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9851m, new DateTime(1958, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 31287m, 3937m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 87,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3587m, new DateTime(1980, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 49066m, 2654m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 88,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5034m, new DateTime(1999, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 26085m, 1808m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 89,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5020m, new DateTime(1961, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 46721m, 1757m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 90,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3759m, new DateTime(1961, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 87053m, 1744m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 91,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7911m, new DateTime(1951, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 51727m, 2661m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 92,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4303m, new DateTime(1998, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 52858m, 5885m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 93,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3105m, new DateTime(1964, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32208m, 2198m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 94,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5669m, new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21108m, 7721m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 95,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3391m, new DateTime(1999, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 72478m, 6963m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 96,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7555m, new DateTime(1962, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 79812m, 7961m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 97,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3830m, new DateTime(1971, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 32060m, 2067m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 98,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9813m, new DateTime(1966, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26197m, 9189m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 99,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6995m, new DateTime(1971, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 57473m, 4275m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 100,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3992m, new DateTime(1974, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 72904m, 8545m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 1,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 9769m, "Salario 5820" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 2,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3478m, "Salario 4070", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 3,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4146m, "Salario", "Salario 5552", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 4,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8819m, "Salario 1485", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 5,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1185m, "Bonos", "Salario 2028", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 6,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7145m, "Otro", "Salario 9633", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 7,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6860m, "Salario", "Salario 6695", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 8,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4044m, "Comision", "Salario 9791", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 9,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1314m, "Salario 8812", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 10,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5389m, "Bonos", "Salario 7868", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 11,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6986m, "Salario", "Salario 1968", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 12,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6565m, "Comision", "Salario 1487", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 13,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1344m, "Salario 5358", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 14,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8239m, "Salario", "Salario 7337", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 15,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6226m, "Bonos", "Salario 1292", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 16,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5738m, "Comision", "Salario 5607", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 17,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8979m, "Comision", "Salario 8659" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 18,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6539m, "Bonos", "Salario 3379", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 19,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1617m, "Salario 3859", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 20,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8408m, "Salario", "Salario 9429", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 21,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2590m, "Salario 1713", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 22,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9376m, "Comision", "Salario 5718", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 23,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 9012m, "Bonos", "Salario 8776" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 24,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2189m, "Salario", "Salario 6406", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 25,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8674m, "Bonos", "Salario 4854" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 26,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5538m, "Comision", "Salario 3675", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 27,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1456m, "Salario 7449", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 28,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9721m, "Salario", "Salario 8815", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 29,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2067m, "Bonos", "Salario 1826" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 30,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4065m, "Comision", "Salario 4217", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 31,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2978m, "Bonos", "Salario 9343" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 32,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3633m, "Otro", "Salario 2488", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 33,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2384m, "Salario", "Salario 3228", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 34,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2273m, "Comision", "Salario 6424", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 35,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 1397m, "Salario 4357" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 36,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8401m, "Salario", "Salario 5706" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 37,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2783m, "Comision", "Salario 2613", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 38,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4758m, "Bonos", "Salario 4627", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 39,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 1630m, "Salario 6863" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 40,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1671m, "Otro", "Salario 4282", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 41,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7075m, "Comision", "Salario 6230", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 42,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6640m, "Salario", "Salario 6263", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 43,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7089m, "Salario", "Salario 6851", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 44,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5002m, "Otro", "Salario 1118", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 45,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6217m, "Otro", "Salario 2788", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 46,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3288m, "Salario", "Salario 7276" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 47,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7437m, "Salario", "Salario 9596", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 48,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7409m, "Salario 2703", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 49,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5427m, "Salario", "Salario 3115", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 50,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6236m, "Bonos", "Salario 4442", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 51,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5011m, "Comision", "Salario 9964", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 52,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5513m, "Otro", "Salario 8515", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 53,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4440m, "Salario", "Salario 6900", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 54,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 9502m, "Bonos", "Salario 6024" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 55,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7997m, "Salario", "Salario 6312", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 56,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4286m, "Otro", "Salario 8531", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 57,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2229m, "Salario", "Salario 9945", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 58,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6048m, "Bonos", "Salario 8640", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 59,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8409m, "Comision", "Salario 5448", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 60,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3199m, "Bonos", "Salario 4385", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 61,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3634m, "Otro", "Salario 7377", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 62,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9219m, "Otro", "Salario 1160", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 63,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 5506m, "Salario", "Salario 3020" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 64,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6509m, "Bonos", "Salario 5953", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 65,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9331m, "Bonos", "Salario 4548", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 66,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3103m, "Salario", "Salario 8644" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 67,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7246m, "Bonos", "Salario 4992", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 68,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8574m, "Salario 9035", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 69,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3752m, "Bonos", "Salario 8484", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 70,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6047m, "Salario", "Salario 3942", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 71,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2530m, "Comision", "Salario 4442", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 72,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5399m, "Comision", "Salario 9963", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 73,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4288m, "Salario 7845", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 74,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4964m, "Salario", "Salario 7752", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 75,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6931m, "Bonos", "Salario 5211", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 76,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2586m, "Comision", "Salario 5637", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 77,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6088m, "Salario", "Salario 7321", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 78,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4288m, "Salario 4286", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 79,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6884m, "Comision", "Salario 4376", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 80,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2909m, "Salario 3300", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 81,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7986m, "Salario 2048", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 82,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7045m, "Bonos", "Salario 2645", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 83,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5182m, "Salario", "Salario 5382", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 84,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3743m, "Salario 8051", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 85,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5969m, "Salario 4066", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 86,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 5946m, "Salario 5922" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 87,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3794m, "Salario 9283", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 88,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7708m, "Comision", "Salario 2792", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 89,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 9107m, "Otro", "Salario 9949" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 90,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3838m, "Comision", "Salario 8998", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 91,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9285m, "Salario 4287", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 92,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6232m, "Bonos", "Salario 3186", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 93,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6481m, "Otro", "Salario 6349", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 94,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9075m, "Comision", "Salario 1914", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 95,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3618m, "Salario 9653", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 96,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5355m, "Otro", "Salario 2194", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 97,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1026m, "Salario 6023", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 98,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7639m, "Salario 4711", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 99,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3101m, "Salario 3958", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 100,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1928m, "Salario 8033", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 1,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "670830341", "Conocido", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 2,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "418431453", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 3,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "139871422", "Amigo", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 4,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "869374447", "Maestra", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 5,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "640072808", "Cliente", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 6,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "925743134", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 7,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "308735822", "Vecino", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 8,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "897092552", "Madre", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 9,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "241190087", "Arrendador", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 10,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "439109636", "Hermano" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 11,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "315782779", "Maestra", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 12,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "280834209", "Paciente", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 13,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "410075485", "Propietario", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 14,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "582591060", "Padre", "Arrendadora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 15,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "371429580", "Amigo", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 16,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "196660157", "Gerente", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 17,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "675064931", "Hijo", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 18,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "699185396", "Amiga", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 19,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "580761740", "Tio", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 20,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "385329436", "Esposa", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 21,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "372530426", "Enfermera", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 22,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "396826847", "Dueño", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 23,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "243236923", "Propietaria", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 24,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "863138042", "Dueño", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 25,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "685330961", "Jefa", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 26,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "253172054", "Estudiante", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 27,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "354646006", "Hermano", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 28,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "521952842", "Paciente", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 29,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "468396606", "Otro", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 30,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "393797669", "Doctora", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 31,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "675927499", "Jefe", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 32,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "979893539", "Conocida", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 33,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "116701480", "Enfermera", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 34,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "896398689", "Directora", "Arrendatario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 35,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "114928982", "Doctor", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 36,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "378264660", "Madre", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 37,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "573155020", "Empleada", "Padre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 38,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "105336287", "Jefe", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 39,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "861056723", "Proveedor", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 40,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "185888178", "Maestra", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 41,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "812882331", "Cliente", "Jefa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 42,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "958749034", "Conocida", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 43,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "708482454", "Hija", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 44,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "720109294", "Esposa", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 45,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "516379249", "Maestro", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 46,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "162813440", "Director", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 47,
                columns: new[] { "RMO", "Relacion" },
                values: new object[] { "186025749", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 48,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "402911075", "Dueña", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 49,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "779249253", "Hermano", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 50,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "738319976", "Hijo", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 51,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "829678265", "Vecina", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 52,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "143020914", "Conocida", "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 53,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "950639337", "Sobrina", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 54,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "405165495", "Esposa", "Dueño" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 55,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "977656350", "Proveedor", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 56,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "430212304", "Tia", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 57,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "183597433", "Compañero", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 58,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "625600812", "Cliente", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 59,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "791307946", "Empleada", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 60,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "321038794", "Esposo", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 61,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "987657452", "Padre", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 62,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "963475485", "Inquilino", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 63,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "889170746", "Propietario", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 64,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "781909154", "Dueño", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 65,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "170216657", "Inquilina", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 66,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "971184939", "Amigo", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 67,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "220403377", "Conocida", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 68,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "474343934", "Enfermero", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 69,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "930589686", "Esposa", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 70,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "106071911", "Doctor", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 71,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "151108052", "Maestra", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 72,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "718401616", "Padre", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 73,
                columns: new[] { "RMO", "Relacion" },
                values: new object[] { "740190286", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 74,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "836213216", "Prima", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 75,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "669393481", "Padre", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 76,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "394171485", "Dueña", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 77,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "253362884", "Amiga", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 78,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "877107140", "Hija", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 79,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "259165668", "Cliente", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 80,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "742150381", "Inquilino", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 81,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "749662460", "Propietaria", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 82,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "115562460", "Empleado", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 83,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "609258321", "Amigo", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 84,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "543781449", "Proveedor", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 85,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "639603094", "Hijo", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 86,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "971380507", "Hija", "Hermano" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 87,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "187754864", "Vecino", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 88,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "525750706", "Jefe", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 89,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "722407927", "Propietario", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 90,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "356867652", "Esposa", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 91,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "396230550", "Novia", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 92,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "757888737", "Hermana", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 93,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "529646933", "Primo", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 94,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "336916949", "Cliente", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 95,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "517170908", "Novia", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 96,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "842572977", "Vecino", "Dueño" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 97,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "863035913", "Enfermera", "Madre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 98,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "929059852", "Esposa", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 99,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "974696319", "Paciente", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 100,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "468930967", "Director", "Inquilina" });
        }
    }
}
