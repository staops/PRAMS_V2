using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRAMS.People.Migrations
{
    /// <inheritdoc />
    public partial class PeopleReferidoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReferidoId",
                table: "Conf_Personas_Links",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lares", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8627), "Calle 8", "Calle 97", "correo23@correo.com", new DateTime(1970, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lourdes Martinez", "Las Marias", "Calle 79", "Calle 55", "90374", "Region 1", "Tipo 4", "78848" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8658), "Calle 90", "Calle 87", "correo9@correo.com", new DateTime(1960, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Carmen Torres", "Arecibo", "Calle 45", "Calle 88", "55325", "Region 7", "Tipo 1", "28754" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Gurabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8683), "Calle 78", "Calle 71", "correo65@correo.com", new DateTime(1995, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Liliana Gonzalez", "Aguada", "Calle 66", "Calle 82", "86355", "Tipo 6", "45278" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ceiba", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8740), "Calle 76", "Calle 26", "correo40@correo.com", new DateTime(1984, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lourdes Santamaria", "Hormigueros", "Calle 69", "Calle 4", "45949", "Region 7", "Tipo 3", "34325" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Trujillo Alto", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8765), "Calle 16", "Calle 98", "correo61@correo.com", new DateTime(1953, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Luz Maria Ramirez", "Guayama", "Calle 86", "Calle 93", "73449", "Region 3", "Tipo 8", "68386" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Jayuya", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8790), "Calle 61", "Calle 78", "correo80@correo.com", new DateTime(1993, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Elena Torres", "Guayama", "Calle 19", "Calle 23", "91811", "Tipo 5", "75241" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ceiba", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8813), "Calle 61", "Calle 17", "correo99@correo.com", new DateTime(1959, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Rosa Jimenez", "Aguas Buenas", "Calle 36", "Calle 88", "36685", "Region 7", "Tipo 8", "15661" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ceiba", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8836), "Calle 18", "Calle 45", "correo22@correo.com", new DateTime(1982, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Luz Elena Santamaria", "Cabo Rojo", "Calle 66", "Calle 7", "53916", "Region 6", "Tipo 9", "81216" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ciales", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8879), "Calle 64", "Calle 23", "correo61@correo.com", new DateTime(1977, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando Soto", "Cabo Rojo", "Calle 21", "Calle 27", "38556", "Region 9", "Tipo 2", "27297" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8903), "Calle 91", "Calle 88", "correo78@correo.com", new DateTime(1987, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Juan Santibañez", "Caguas", "Calle 9", "Calle 65", "71490", "Region 4", "Tipo 9", "45814" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Humacao", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8926), "Calle 47", "Calle 69", "correo93@correo.com", new DateTime(1964, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lilia Ramirez", "Lajas", "Calle 53", "Calle 93", "40761", "Region 2", "12102" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(8950), "Calle 62", "Calle 23", "correo77@correo.com", new DateTime(1970, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Maria Diaz", "Cabo Rojo", "Calle 58", "Calle 49", "18083", "Region 9", "Tipo 4", "99008" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9012), "Calle 45", "Calle 34", "correo47@correo.com", new DateTime(1979, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Lilia Santana", "Coamo", "Calle 85", "Calle 85", "84929", "Region 9", "22185" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9035), "Calle 66", "Calle 23", "correo11@correo.com", new DateTime(1968, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Liliana Gomez", "Guaynabo", "Calle 98", "Calle 20", "81208", "Region 3", "Tipo 1", "43718" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Juana Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9057), "Calle 89", "Calle 42", "correo21@correo.com", new DateTime(1963, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Fernando Diaz", "Jayuya", "Calle 1", "Calle 3", "12009", "Region 7", "85333" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9080), "Calle 91", "Calle 42", "correo37@correo.com", new DateTime(1983, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Fernando Garcia", "Cayey", "Calle 51", "Calle 55", "99425", "Region 3", "Tipo 7", "65598" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguada", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9141), "Calle 4", "Calle 55", "correo91@correo.com", new DateTime(1959, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Miguel Gomez", "Dorado", "Calle 51", "Calle 67", "66387", "Region 7", "Tipo 6", "80748" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Gurabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9165), "Calle 28", "Calle 44", "correo87@correo.com", new DateTime(1979, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Carlos Martinez", "Gurabo", "Calle 1", "Calle 40", "17562", "Region 2", "Tipo 2", "33678" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9187), "Calle 88", "Calle 33", "correo36@correo.com", new DateTime(1960, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Luz Elena Santacruz", "Carolina", "Calle 85", "Calle 65", "43449", "Region 7", "Tipo 4", "46453" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Coamo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9210), "Calle 17", "Calle 26", "correo11@correo.com", new DateTime(1996, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Rosa Silva", "Aibonito", "Calle 72", "Calle 30", "75684", "Region 9", "Tipo 9", "82941" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9260), "Calle 77", "Calle 25", "correo79@correo.com", new DateTime(1987, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Luz Maria Santillan", "Lares", "Calle 59", "Calle 25", "15116", "Region 7", "Tipo 2", "85565" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9283), "Calle 8", "Calle 4", "correo52@correo.com", new DateTime(1950, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos Jimenez", "San Juan", "Calle 60", "Calle 92", "89037", "Region 9", "Tipo 7", "18926" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayama", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9306), "Calle 22", "Calle 4", "correo4@correo.com", new DateTime(1952, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Ana Santillana", "Ciales", "Calle 87", "Calle 44", "99625", "Region 4", "Tipo 3", "14802" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9330), "Calle 46", "Calle 23", "correo35@correo.com", new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lidia Santana", "Guaynabo", "Calle 3", "Calle 71", "76877", "Tipo 7", "71295" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Florida", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9380), "Calle 24", "Calle 14", "correo36@correo.com", new DateTime(1984, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lorena Soto", "Guaynabo", "Calle 26", "Calle 8", "78861", "Region 9", "Tipo 6", "76363" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Isabela", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9403), "Calle 99", "correo12@correo.com", new DateTime(1978, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Rosa Martinez", "Las Marias", "Calle 47", "Calle 38", "30985", "Region 8", "Tipo 3", "70802" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Gurabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9424), "Calle 13", "Calle 42", "correo17@correo.com", new DateTime(1956, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Carlos Santoyo", "Toa Alta", "Calle 3", "Calle 7", "16780", "Region 1", "56838" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 28,
                columns: new[] { "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9447), "Calle 19", "Calle 36", "correo67@correo.com", new DateTime(1962, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Lourdes Sandoval", "Trujillo Alto", "Calle 43", "Calle 34", "33937", "Region 7", "Tipo 8", "65467" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9469), "Calle 10", "Calle 35", "correo41@correo.com", new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Luis Hernandez", "Barceloneta", "Calle 45", "Calle 97", "29375", "Region 1", "Tipo 8", "65933" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9519), "Calle 62", "Calle 2", "correo86@correo.com", new DateTime(1963, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luz Santibañez", "Juncos", "Calle 98", "Calle 84", "66633", "Region 5", "Tipo 9", "54550" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9541), "Calle 96", "Calle 35", "correo15@correo.com", new DateTime(1999, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Ricardo Santana", "Barceloneta", "Calle 71", "Calle 21", "77934", "Region 6", "Tipo 9", "34965" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9563), "Calle 42", "Calle 17", "correo98@correo.com", new DateTime(1955, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Liz Santos", "Comerio", "Calle 61", "Calle 62", "36327", "Region 3", "Tipo 2", "99346" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9585), "Calle 48", "Calle 28", "correo21@correo.com", new DateTime(1983, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Pedro Perez", "Juana Diaz", "Calle 90", "Calle 69", "11837", "Region 5", "Tipo 9", "71808" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9636), "Calle 4", "Calle 72", "correo89@correo.com", new DateTime(1967, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Liliana Jimenez", "Aguas Buenas", "Calle 15", "Calle 87", "33736", "Region 7", "Tipo 3", "75406" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Aguadilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9659), "Calle 52", "Calle 54", "correo32@correo.com", new DateTime(1994, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Luz Ramirez", "Arecibo", "Calle 97", "Calle 3", "45328", "Region 7", "19670" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Barranquitas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9681), "Calle 67", "Calle 45", "correo58@correo.com", new DateTime(1967, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Luis Sosa", "Comerio", "Calle 20", "Calle 98", "42467", "Region 8", "Tipo 9", "63651" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arroyo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9703), "Calle 25", "Calle 71", "correo30@correo.com", new DateTime(1979, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liz Martinez", "Carolina", "Calle 31", "Calle 99", "37673", "Region 9", "Tipo 5", "69536" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9755), "Calle 39", "Calle 37", "correo14@correo.com", new DateTime(1960, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Laura Rojas", "Barceloneta", "Calle 72", "Calle 36", "11174", "Tipo 2", "39210" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9776), "Calle 19", "Calle 29", "correo36@correo.com", new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Laura Perez", "Trujillo Alto", "Calle 37", "Calle 57", "48019", "Region 5", "Tipo 3", "82873" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguadilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9800), "Calle 83", "Calle 46", "correo37@correo.com", new DateTime(1967, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Juan Santibañez", "Aguada", "Calle 46", "Calle 89", "77761", "Region 8", "Tipo 4", "38671" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9822), "Calle 4", "Calle 5", "correo8@correo.com", new DateTime(1980, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Carmen Serrano", "Jayuya", "Calle 4", "Calle 99", "26741", "Region 7", "Tipo 6", "75091" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Catano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9862), "Calle 18", "Calle 6", "correo34@correo.com", new DateTime(1964, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Luz Elena Santoyo", "Guaynabo", "Calle 25", "Calle 16", "47202", "Region 5", "Tipo 9", "80295" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9883), "Calle 37", "Calle 71", new DateTime(1957, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Liliana Gomez", "Carolina", "Calle 92", "Calle 91", "77078", "Region 8", "Tipo 9", "24225" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guanica", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9905), "Calle 49", "Calle 55", "correo56@correo.com", new DateTime(1956, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Luz Elena Ramirez", "Humacao", "Calle 49", "Calle 19", "37680", "Region 1", "Tipo 7", "56665" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9926), "Calle 43", "Calle 14", "correo10@correo.com", new DateTime(1998, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Luisa Silva", "Caguas", "Calle 18", "Calle 23", "83483", "Region 4", "Tipo 9", "20627" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Florida", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(9986), "Calle 48", "Calle 45", "correo91@correo.com", new DateTime(1993, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Leticia Sosa", "Humacao", "Calle 53", "Calle 45", "89167", "Region 9", "15973" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2024, 11, 24, 12, 45, 21, 254, DateTimeKind.Local).AddTicks(9), "Calle 94", "Calle 16", "correo98@correo.com", new DateTime(1969, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Rosa Diaz", "Lajas", "Calle 29", "Calle 36", "32381", "Region 9", "54038" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 254, DateTimeKind.Local).AddTicks(32), "Calle 32", "Calle 44", "correo64@correo.com", new DateTime(1959, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lilia Gomez", "Vega Baja", "Calle 11", "Calle 28", "85648", "Region 7", "Tipo 7", "19062" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Barranquitas", new DateTime(2024, 11, 24, 12, 45, 21, 254, DateTimeKind.Local).AddTicks(54), "Calle 92", "Calle 57", "correo58@correo.com", new DateTime(1971, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lilia Santibañez", "Las Marias", "Calle 82", "Calle 82", "20406", "Region 5", "Tipo 8", "62803" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Juana Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 254, DateTimeKind.Local).AddTicks(75), "Calle 70", "Calle 59", "correo90@correo.com", new DateTime(1958, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Laura Torres", "Toa Alta", "Calle 47", "Calle 58", "18533", "Region 1", "68811" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 1,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Hernandez", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9556), "Secundaria", "Casado", "Asiatica", new DateTime(1962, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "S", "Caguas", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9448), "Maria", "Empleado", "Testigo de Jehova", "417086479", "599904370", "486622894", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 2,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9616), "Doctorado", "Soltero", "Mexicana", new DateTime(1964, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "E", "Gurabo", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9559), "Luisa", "Empleado", "Amarilla", "Mormon", "589953511", "442230661", "753472847", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 3,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillana", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9639), "Licenciatura", "Divorciado", "Africana", new DateTime(1995, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "Guayanilla", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9617), "Ama de casa", "Otro", "414703374", "794211924", "590982592", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 4,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Suarez", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9664), "Primaria", "Soltero", new DateTime(1993, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "J", "San Juan", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9640), "Liz", "Empleado", "Morena", "Ateo", "622704225", "281420423", "218413498", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 5,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9687), "Estadounidense", new DateTime(1981, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9665), "Luisa", "Ama de casa", "Otra", "Testigo de Jehova", "878798889", "332147071", "914786104", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 6,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillana", "Soto", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9741), "Doctorado", "Casado", "Canadiense", new DateTime(1993, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "Culebra", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9690), "Luz", "Otro", "Morena", "Catolica", "605465753", "485945975", "343833209", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 7,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Soto", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9766), "Licenciatura", "Soltero", "Mexicana", new DateTime(1996, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Cataño", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9743), "Rosa", "Estudiante", "Negra", "Testigo de Jehova", "202122188", "691163599", "339210483", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 8,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santos", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9789), "Maestria", "Soltero", "Estadounidense", new DateTime(1950, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "Guayanilla", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9767), "Raul", "Estudiante", "Amarilla", "Ateo", "558150696", "744617144", "221049550" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 9,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santacruz", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9811), "Primaria", "Soltero", "Asiatica", new DateTime(1956, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "M", "Las Marias", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9790), "Luz", "Estudiante", "Morena", "Mormon", "402101726", "742309549", "368059973", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 10,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Torres", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9853), "Licenciatura", "Soltero", "Asiatica", new DateTime(1987, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Fajardo", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9813), "Lourdes", "Desempleado", "Morena", "705172491", "343394756", "507111563", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 11,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9876), "Otro", "Casado", "Mexicana", new DateTime(1957, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "Hormigueros", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9854), "Ricardo", "Otro", "Blanca", "Testigo de Jehova", "126157607", "707984008", "664635396", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 12,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Santibañez", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9898), "Otra", new DateTime(1952, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Primaria", "Dorado", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9877), "Raul", "Estudiante", "Morena", "Agnostico", "363992152", "439114338", "836563102", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 13,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Silva", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9990), "Preparatoria", "Divorciado", "Asiatica", new DateTime(1955, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9899), "Lorena", "Desempleado", "Amarilla", "Catolica", "261262725", "413716139", "217796667", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 14,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Serrano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(16), "Otro", "Divorciado", "Europea", new DateTime(1954, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Caguas", new DateTime(2024, 11, 24, 12, 45, 21, 252, DateTimeKind.Local).AddTicks(9991), "Luz", "Ama de casa", "Cristiana", "245088969", "742518666", "705945325", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 15,
                columns: new[] { "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(39), "Casado", "Estadounidense", new DateTime(1966, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "C", "Carolina", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(17), "Luz", "Ama de casa", "Negra", "Ateo", "677860955", "490519322", "704545568", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 16,
                columns: new[] { "ApellidoMaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(62), "Licenciatura", "Viudo", "Africana", new DateTime(1968, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "R", "Aguas Buenas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(40), "Luz Maria", "Negra", "Mormon", "495777985", "570300707", "546692232", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 17,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Santamaria", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(122), "Doctorado", "Viudo", "Otra", new DateTime(1950, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "L", "Fajardo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(63), "Sofia", "Empleado", "Negra", "298436832", "420747989", "368598877", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 18,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Lopez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(146), "Soltero", "Mexicana", new DateTime(1989, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "R", "Aguas Buenas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(124), "Carmen", "Morena", "Agnostico", "122316473", "120949147", "190925438", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 19,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Silva", "Perez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(169), "Viudo", new DateTime(1951, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(147), "Lorena", "Blanca", "Ateo", "902305153", "571759747", "253729570" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 20,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(191), "Primaria", "Soltero", "Asiatica", new DateTime(1958, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "P", "Guayanilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(170), "Luz Maria", "Otro", "977899259", "894553021", "420386325", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 21,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Serrano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(244), "Secundaria", "Asiatica", new DateTime(1972, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "M", "Las Piedras", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(192), "Luz Maria", "Otra", "Agnostico", "803338045", "716737092", "276003540", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 22,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(266), "Licenciatura", "Estadounidense", new DateTime(1984, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "San Juan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(245), "Lidia", "Otro", "Blanca", "115771379", "623757728", "456478655", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 23,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(290), "Maestria", "Canadiense", new DateTime(1998, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "M", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(268), "Lilia", "Desempleado", "Amarilla", "Mormon", "971384734", "815164464", "431173384", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 24,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(313), "Maestria", "Soltero", "Otra", new DateTime(1951, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "Culebra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(291), "Ama de casa", "Morena", "281284617", "822856865", "110415349", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 25,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santoyo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(365), "Otro", "Canadiense", new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "C", "Isabela", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(314), "Maria", "Otro", "Morena", "Cristiana", "842155484", "400232513", "943167016", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 26,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Soto", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(388), "Primaria", "Asiatica", new DateTime(1968, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "R", "Corozal", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(366), "Lilia", "Negra", "Cristiana", "599759285", "530329792", "640218348", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 27,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Garcia", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(410), "Otro", "Otra", new DateTime(1981, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "Vega Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(388), "Lilia", "Negra", "342387459", "656765672", "274449839", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 28,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Martinez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(432), "Maestria", "Viudo", "Canadiense", new DateTime(1974, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "Cabo Rojo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(410), "Luz", "Estudiante", "Negra", "Agnostico", "217969955", "411715233", "783792955", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 29,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Reyes", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(483), "Asiatica", new DateTime(1998, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "L", "Guanica", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(433), "Carmen", "Desempleado", "Negra", "Agnostico", "617839079", "698805799", "246594863", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 30,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Jimenez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(506), "Secundaria", "Casado", "Europea", new DateTime(1955, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "R", "Cabo Rojo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(484), "Lidia", "Jubilado", "Negra", "Ateo", "809508554", "308508317", "974235210", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 31,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Garcia", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(529), "Otro", "Europea", new DateTime(1966, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "R", "Carolina", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(507), "Leticia", "Otro", "Catolica", "725670384", "805736236", "496199826", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 32,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Santoyo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(551), "Maestria", "Asiatica", new DateTime(1979, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "J", "Catano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(530), "Morena", "Catolica", "669577996", "729715423", "319211542", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 33,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Gomez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(602), "Doctorado", "Divorciado", "Africana", new DateTime(1979, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "J", "Guaynabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(552), "Luz", "Jubilado", "Otra", "Ateo", "243637917", "994819634", "903510440", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 34,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(628), "Otro", "Soltero", "Otra", new DateTime(1976, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "A", "Catano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(605), "Ricardo", "Empleado", "904456596", "549947329", "580368663", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 35,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(651), "Maestria", "Mexicana", new DateTime(1978, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "R", "Toa Baja", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(629), "Ricardo", "Empleado", "Otra", "Cristiana", "783885142", "872119940", "976490421", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 36,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(701), "Primaria", "Soltero", "Estadounidense", new DateTime(1978, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "R", "Trujillo Alto", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(652), "Jorge", "Otra", "Ateo", "937505486", "136619105", "153587288", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 37,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Santamaria", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(724), "Otra", new DateTime(1980, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "S", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(702), "Elena", "Desempleado", "Morena", "Catolica", "880251426", "535416697", "543650060", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 38,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santillana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(746), "Secundaria", "Soltero", new DateTime(1963, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "F", "Toa Baja", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(725), "Luz", "Estudiante", "Otra", "Catolica", "382199598", "600656646", "913517214", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 39,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Sandoval", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(768), "Otro", "Casado", "Europea", new DateTime(1975, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "L", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(747), "Lilia", "Estudiante", "Amarilla", "469395507", "590685052", "482160889", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 40,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Garcia", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(810), "Licenciatura", "Otra", new DateTime(1985, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "L", "Humacao", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(769), "Pedro", "Estudiante", "Otro", "446035879", "694240244", "885273058", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 41,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Gomez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(834), "Casado", "Asiatica", new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "F", "Ciales", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(811), "Lorena", "Otro", "732406761", "612826621", "562809516", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 42,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Santillana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(856), "Maestria", "Soltero", "Asiatica", new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Canovanas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(835), "Lourdes", "Jubilado", "Morena", "Mormon", "486374218", "724893146", "186674521", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 43,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(879), "Doctorado", "Viudo", "Europea", new DateTime(1968, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "F", "Jayuya", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(857), "Carlos", "Desempleado", "Blanca", "Testigo de Jehova", "959665580", "971015466", "987981431", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 44,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(937), "Casado", "Africana", new DateTime(1992, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "L", "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(879), "Elena", "Ama de casa", "Blanca", "Mormon", "639062873", "717210924", "789182173", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 45,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(960), "Otro", "Asiatica", new DateTime(1977, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "Dorado", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(938), "Jorge", "Desempleado", "Blanca", "Ateo", "210401726", "402440712", "368323783", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 46,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(983), "Licenciatura", "Casado", "Estadounidense", new DateTime(1965, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "Lajas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(961), "Rosa", "Otro", "Ateo", "283967660", "995009631", "757383519", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 47,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Perez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1006), "Preparatoria", "Soltero", "Europea", new DateTime(1966, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "J", "Guayama", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(983), "Liliana", "Desempleado", "Testigo de Jehova", "816443189", "867324895", "813711847", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 48,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Sandoval", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1066), "Primaria", "Africana", new DateTime(1962, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "M", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1007), "Lourdes", "Empleado", "Morena", "Agnostico", "622239275", "542731100", "508491792", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 49,
                columns: new[] { "ApellidoMaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1090), "Secundaria", "Soltero", new DateTime(1952, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "Aguadilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1067), "Luisa", "Desempleado", "Morena", "Mormon", "631863378", "730368360", "130010167", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 50,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santana", "Santoyo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1112), "Licenciatura", "Divorciado", "Africana", new DateTime(1957, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "J", "Lares", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1091), "Laura", "Desempleado", "Morena", "Cristiana", "484824299", "321963219", "593002198" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 51,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Soto", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1135), "Primaria", "Otra", new DateTime(1975, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "R", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1112), "Rosa", "Ama de casa", "Otra", "Cristiana", "784584224", "522560521", "861883904", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 52,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Sandoval", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1185), "Estadounidense", new DateTime(1959, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "P", "Guaynabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1136), "Empleado", "Amarilla", "Mormon", "753018135", "436387593", "134106960", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 53,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1208), "Preparatoria", "Casado", "Canadiense", new DateTime(1952, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Vega Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1186), "Lorena", "Jubilado", "Amarilla", "Ateo", "431132165", "919194166", "828151981", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 54,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Vazquez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1231), "Licenciatura", "Viudo", "Canadiense", new DateTime(1988, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "L", "Coamo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1209), "Carlos", "Otro", "Negra", "Mormon", "155294470", "642256021", "672085241", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 55,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1254), "Otro", "Divorciado", "Estadounidense", new DateTime(1983, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "M", "Gurabo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1232), "Liliana", "Otro", "Morena", "Otro", "908505960", "100225995", "577351463", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 56,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Jimenez", "Gomez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1303), "Doctorado", "Casado", "Canadiense", new DateTime(1965, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "R", "Juncos", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1255), "Luz", "Empleado", "541897124", "802972678", "897804953" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 57,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Jimenez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1325), "Secundaria", "Estadounidense", new DateTime(1969, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1304), "Liz", "Jubilado", "Otro", "983234252", "366517954", "626458942", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 58,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Sosa", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1348), "Soltero", "Africana", new DateTime(1969, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "L", "Cabo Rojo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1326), "Luz Maria", "Empleado", "Blanca", "Mormon", "396026692", "346246696", "621622782", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 59,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Torres", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1370), "Licenciatura", "Casado", "Asiatica", new DateTime(1987, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "Aguas Buenas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1349), "Carmen", "Empleado", "Morena", "623940454", "867241392", "510690667", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 60,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Sosa", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1419), "Primaria", "Estadounidense", new DateTime(1989, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Culebra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1371), "Raul", "Otro", "Amarilla", "Testigo de Jehova", "323897125", "247196955", "253669228", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 61,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Santos", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1441), "Maestria", "Europea", new DateTime(1956, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Doctorado", "D", "Florida", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1420), "Luz", "Estudiante", "Amarilla", "Catolica", "268910039", "992972494", "994641749", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 62,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santana", "Salazar", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1464), "Secundaria", "Asiatica", new DateTime(1961, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "L", "Las Marias", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1442), "Rocio", "Estudiante", "Amarilla", "Agnostico", "368977828", "972933064", "622679722" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 63,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Martinez", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1486), "Primaria", "Viudo", "Asiatica", new DateTime(1993, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Barranquitas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1465), "Sofia", "Estudiante", "Testigo de Jehova", "684057625", "562655066", "844303208", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 64,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Torres", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1537), "Divorciado", new DateTime(1989, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1514), "Liz", "Otro", "Negra", "Testigo de Jehova", "252544351", "772802785", "137578705", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 65,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Gonzalez", "Serrano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1561), "Maestria", "Divorciado", "Asiatica", new DateTime(1982, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "L", "Anasco", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1538), "Luz Elena", "Empleado", "Amarilla", "Ateo", "975177497", "498365659", "847546859" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 66,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1585), "Otro", "Soltero", "Mexicana", new DateTime(1977, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "R", "Ponce", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1563), "Rocio", "Empleado", "Amarilla", "Catolica", "980673635", "297677238", "611059162", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 67,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Ramirez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1636), "Maestria", "Casado", "Estadounidense", new DateTime(1980, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "R", "Guayanilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1586), "Carmen", "Ama de casa", "Amarilla", "Ateo", "907401638", "112767534", "208988940", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 68,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Perez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1659), "Maestria", "Divorciado", "Otra", new DateTime(1958, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1637), "Pedro", "Otro", "Morena", "Testigo de Jehova", "940892179", "610214022", "433348524", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 69,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1682), "Maestria", "Viudo", "Africana", new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "Caguas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1660), "Luz Maria", "Empleado", "Otra", "Mormon", "586695270", "209061918", "538861293" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 70,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Jimenez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1704), "Secundaria", "Canadiense", new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1683), "Luz", "Ama de casa", "908842413", "739105721", "869688736", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 71,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1743), "Doctorado", "Divorciado", "Estadounidense", new DateTime(1984, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Anasco", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1705), "Jose", "Ama de casa", "Blanca", "Cristiana", "120329525", "996139788", "226364995", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 72,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Garcia", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1765), "Soltero", "Europea", new DateTime(1975, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "D", "Barranquitas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1744), "Miguel", "Estudiante", "Morena", "740237140", "945274835", "725035719", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 73,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Salazar", "Suarez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1788), "Secundaria", "Canadiense", new DateTime(1970, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "L", "Hatillo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1766), "Ana", "Estudiante", "Otra", "Otro", "943645567", "443626590", "526256161" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 74,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Saucedo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1810), "Doctorado", "Viudo", "Africana", new DateTime(1959, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "L", "Lajas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1789), "Juan", "Empleado", "Cristiana", "781180011", "707754738", "268756404", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 75,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1867), "Maestria", "Soltero", new DateTime(1961, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "L", "Las Piedras", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1811), "Ana", "Amarilla", "Otro", "112794505", "723291668", "435509132", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 76,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Sandoval", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1890), "Primaria", "Soltero", new DateTime(1968, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "J", "Aguada", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1868), "Carlos", "Empleado", "Negra", "Mormon", "213019126", "734561815", "245014541", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 77,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1913), "Maestria", "Divorciado", new DateTime(1961, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Ceiba", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1891), "Ana", "Jubilado", "Blanca", "Testigo de Jehova", "754334075", "339917293", "822644918", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 78,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Soto", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1936), "Maestria", "Viudo", "Canadiense", new DateTime(1986, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "E", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1914), "Maria", "Ateo", "152880892", "561550186", "798253210", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 79,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santillan", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1996), "Secundaria", "Viudo", "Europea", new DateTime(1983, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Las Marias", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1974), "Fernando", "Desempleado", "581127814", "696083753", "613817323", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 80,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Hernandez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2019), "Doctorado", "Casado", "Estadounidense", new DateTime(1961, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "Toa Baja", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(1997), "Carlos", "Jubilado", "854387907", "449761311", "684123928", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 81,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Silva", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2042), "Secundaria", "Viudo", "Otra", new DateTime(1978, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "L", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2020), "Juan", "Estudiante", "Morena", "913329047", "224122805", "377940861", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 82,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Santos", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2204), "Otra", new DateTime(1995, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "A", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2043), "Liz", "Otro", "Blanca", "Testigo de Jehova", "612115266", "540874485", "539328534", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 83,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Diaz", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2369), "Licenciatura", "Soltero", "Africana", new DateTime(1981, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "R", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2314), "Otro", "Negra", "Agnostico", "498584184", "660042943", "670672201", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 84,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Torres", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2394), "Primaria", "Divorciado", "Africana", new DateTime(1989, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "J", "Hormigueros", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2370), "Carlos", "Ama de casa", "Blanca", "Catolica", "309160681", "158414606", "861792447", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 85,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2417), "Secundaria", "Viudo", new DateTime(1959, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "Cidra", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2395), "Leticia", "Otro", "Morena", "Otro", "362071487", "660447813", "520516731", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 86,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Gonzalez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2458), "Licenciatura", "Viudo", "Canadiense", new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "Barranquitas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2418), "Ana", "Otra", "Otro", "257634039", "625765406", "341618902", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 87,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Santibañez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2484), "Viudo", "Canadiense", new DateTime(1960, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "C", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2459), "Rosa", "Empleado", "Amarilla", "Mormon", "523723139", "580540858", "175380633", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 88,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Lopez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2509), "Maestria", "Casado", new DateTime(1956, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "R", "Aibonito", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2485), "Liz", "Empleado", "Amarilla", "Cristiana", "278569971", "793366766", "916838961", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 89,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Santamaria", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2533), "Primaria", "Divorciado", "Asiatica", new DateTime(1964, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "Cabo Rojo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2510), "Carlos", "Empleado", "Negra", "Ateo", "511662133", "545651589", "397676429", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 90,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Rojas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2604), "Doctorado", "Soltero", "Mexicana", new DateTime(1954, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "L", "Mayaguez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2534), "Carlos", "Ama de casa", "Otra", "Ateo", "780338135", "168227294", "246948453", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 91,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santos", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2627), "Doctorado", "Viudo", "Africana", new DateTime(1976, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "L", "Carolina", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2605), "Pedro", "Ama de casa", "Otra", "Ateo", "531569610", "993894927", "875935369", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 92,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Garcia", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2651), "Primaria", "Soltero", "Otra", new DateTime(1983, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "J", "Cayey", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2628), "Pedro", "Ama de casa", "Amarilla", "668959119", "178116741", "465664453", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 93,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Santana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2675), "Secundaria", "Casado", "Canadiense", new DateTime(1991, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Bayamon", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2652), "Luisa", "Estudiante", "Negra", "Catolica", "765767000", "120667031", "327521618", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 94,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Torres", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2736), "Licenciatura", "Soltero", "Africana", new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "E", "Toa Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2676), "Lilia", "Ama de casa", "Otra", "Mormon", "845867603", "523391607", "475974218", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 95,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Santos", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2759), "Viudo", "Africana", new DateTime(1982, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "S", "Cabo Rojo", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2737), "Rosa", "Estudiante", "Amarilla", "632854022", "124698076", "150102278", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 96,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2784), "Maestria", "Viudo", "Mexicana", new DateTime(1960, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "L", "Caguas", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2761), "Carmen", "Ama de casa", "Otra", "Testigo de Jehova", "172039562", "697367729", "462884640", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 97,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Santillana", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2807), "Secundaria", "Europea", new DateTime(1957, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "L", "Toa Alta", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2785), "Juan", "Empleado", "Cristiana", "532277572", "699593732", "690033465", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 98,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Hernandez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2857), "Licenciatura", "Soltero", "Canadiense", new DateTime(1991, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "Aguadilla", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2808), "Laura", "Desempleado", "Negra", "Testigo de Jehova", "966117314", "299663907", "531142124", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 99,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Martinez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2879), "Secundaria", "Divorciado", "Otra", new DateTime(1995, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", "Cataño", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2858), "Lourdes", "Negra", "566512690", "594102558", "986416616", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 100,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Gomez", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2902), "Primaria", "Casado", "Europea", new DateTime(1967, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "M", "Comerio", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(2880), "Raul", "Jubilado", "246315325", "598107502", "719497388", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "36204", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5483), "Calle 12", "Calle 39", new DateTime(1950, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Trujillo Alto", "87387", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5501), "Calle 69", "Calle 37", new DateTime(1969, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "34914", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5519), "Calle 85", "Calle 18", new DateTime(1962, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "37747", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5535), "Calle 72", "Calle 11", new DateTime(1966, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Barceloneta", "10142", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5550), "Calle 71", "Calle 28", new DateTime(1976, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Jayuya", "34131", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5594), "Calle 42", "Calle 65", new DateTime(1970, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "44800", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5610), "Calle 20", "Calle 62", new DateTime(1993, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Isabela", "21187", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5624), "Calle 90", "Calle 33", new DateTime(1976, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "99988", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5640), "Calle 40", "Calle 78", new DateTime(1982, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "23024", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5654), "Calle 46", "Calle 24", new DateTime(1965, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cayey", "64860", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5668), "Calle 3", "Calle 65", new DateTime(1967, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "78202", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5683), "Calle 31", "Calle 25", new DateTime(1983, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barceloneta", "51358", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5725), "Calle 77", "Calle 47", new DateTime(1964, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Humacao", "97901", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5740), "Calle 54", "Calle 23", new DateTime(1972, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "55258", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5756), "Calle 11", new DateTime(1980, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Jayuya", "53480", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5771), "Calle 54", "Calle 19", new DateTime(1964, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 17,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "84869", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5787), "Calle 92", "Calle 94", new DateTime(1951, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Lajas", "90674", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5801), "Calle 68", "Calle 17", new DateTime(1992, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "69143", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5819), "Calle 87", "Calle 82", new DateTime(1959, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Alta", "33268", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5833), "Calle 31", "Calle 81", new DateTime(1950, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "San Juan", "82001", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5872), "Calle 65", "Calle 41", new DateTime(1971, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "59546", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5884), "Calle 82", "Calle 3", new DateTime(1966, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "45303", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5898), "Calle 75", "Calle 39", new DateTime(1958, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "20960", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5911), "Calle 39", "Calle 18", new DateTime(1970, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Trujillo Alto", "16327", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5927), "Calle 5", "Calle 91", new DateTime(1952, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "82720", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5940), "Calle 89", new DateTime(1964, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Isabela", "40455", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5954), "Calle 85", "Calle 25", new DateTime(1972, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cataño", "44702", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(5967), "Calle 5", "Calle 19", new DateTime(1985, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "86909", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6001), "Calle 96", "Calle 66", new DateTime(1958, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "14565", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6014), "Calle 77", "Calle 26", new DateTime(1952, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguas Buenas", "39598", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6029), "Calle 14", "Calle 45", new DateTime(1993, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayama", "62657", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6043), "Calle 47", "Calle 37", new DateTime(1951, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "70610", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6056), "Calle 33", "Calle 25", new DateTime(1951, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Jayuya", "99781", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6070), "Calle 3", "Calle 56", new DateTime(1954, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Trujillo Alto", "18351", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6084), "Calle 48", "Calle 79", new DateTime(1994, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "72147", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6131), "Calle 25", "Calle 48", new DateTime(1992, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "85519", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6147), "Calle 2", "Calle 29", new DateTime(1974, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "36596", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6159), "Calle 36", "Calle 89", new DateTime(1968, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "75393", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6175), "Calle 99", "Calle 16", new DateTime(1951, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Caguas", "63695", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6188), "Calle 81", "Calle 94", new DateTime(1977, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "71594", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6203), "Calle 83", "Calle 6", new DateTime(1960, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Vega Alta", "20294", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6216), "Calle 88", "Calle 48", new DateTime(1966, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 43,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "98406", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6268), "Calle 59", "Calle 60", new DateTime(1961, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "65726", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6283), "Calle 37", "Calle 98", new DateTime(1973, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Hormigueros", "53116", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6297), "Calle 34", "Calle 68", new DateTime(1988, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Dorado", "84539", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6309), "Calle 75", "Calle 83", new DateTime(1986, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lares", "90050", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6323), "Calle 2", "Calle 53", new DateTime(1982, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Juncos", "36820", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6338), "Calle 6", "Calle 27", new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "62969", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6351), "Calle 71", "Calle 19", new DateTime(1971, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "11180", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6364), "Calle 4", "Calle 56", new DateTime(1970, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 51,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "77413", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6398), "Calle 67", "Calle 94", new DateTime(1969, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 52,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Ciales", "72332", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6412), "Calle 64", "Calle 95", new DateTime(1969, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 53,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Anasco", "11842", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6426), "Calle 13", "Calle 77", new DateTime(1968, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 54,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Juana Diaz", "53695", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6438), "Calle 51", "Calle 40", new DateTime(1984, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 55,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cayey", "51377", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6451), "Calle 45", "Calle 69", new DateTime(1959, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 56,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Ponce", "79400", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6465), "Calle 82", "Calle 3", new DateTime(1959, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 57,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Comerio", "78214", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6478), "Calle 72", "Calle 64", new DateTime(1981, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 58,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "52475", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6490), "Calle 34", "Calle 49", new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 59,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "42222", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6536), "Calle 49", "Calle 64", new DateTime(1961, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 60,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lares", "79763", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6550), "Calle 49", "Calle 55", new DateTime(1980, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 61,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "46576", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6565), "Calle 8", new DateTime(1951, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 62,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "21551", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6576), "Calle 13", "Calle 64", new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 63,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Mayaguez", "42158", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6591), "Calle 10", "Calle 30", new DateTime(1992, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 64,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "32998", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6604), "Calle 79", new DateTime(1964, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 65,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ponce", "10815", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6618), "Calle 33", "Calle 96", new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 66,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Catano", "85588", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6671), "Calle 52", "Calle 7", new DateTime(1964, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 67,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "86148", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6685), "Calle 76", "Calle 9", new DateTime(1961, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 68,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Jayuya", "34997", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6698), "Calle 90", "Calle 85", new DateTime(1955, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 69,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Jayuya", "70419", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6711), "Calle 22", "Calle 30", new DateTime(1958, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 70,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Isabela", "16215", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6722), "Calle 11", "Calle 29", new DateTime(1971, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 71,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cataño", "82958", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6734), "Calle 37", "Calle 25", new DateTime(1970, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 72,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "59192", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6748), "Calle 77", "Calle 13", new DateTime(1951, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 73,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "21247", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6790), "Calle 26", "Calle 42", new DateTime(1985, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 74,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Marias", "39862", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6802), "Calle 97", "Calle 16", new DateTime(1995, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 75,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "89571", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6815), "Calle 5", "Calle 42", new DateTime(1966, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 76,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "41222", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6829), "Calle 81", "Calle 75", new DateTime(1964, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 77,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguada", "58730", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6844), "Calle 12", "Calle 93", new DateTime(1972, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 78,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Ceiba", "92317", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6858), "Calle 84", "Calle 3", new DateTime(1998, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 79,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Barranquitas", "78587", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6872), "Calle 44", "Calle 43", new DateTime(1960, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 80,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aguadilla", "18744", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6886), "Calle 75", "Calle 44", new DateTime(1950, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 81,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Ceiba", "71439", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6926), "Calle 19", "Calle 43", new DateTime(1985, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 82,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Camuy", "35950", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6938), "Calle 77", "Calle 3", new DateTime(1957, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 83,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "36981", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6951), "Calle 96", "Calle 14", new DateTime(1997, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 84,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "65565", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6964), "Calle 91", "Calle 5", new DateTime(1968, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 85,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "99631", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6978), "Calle 39", "Calle 20", new DateTime(1983, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 86,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "49130", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(6989), "Calle 57", new DateTime(1976, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 87,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Coamo", "32872", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7002), "Calle 57", "Calle 7", new DateTime(1967, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 88,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Carolina", "14367", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7015), "Calle 22", "Calle 28", new DateTime(1973, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 89,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Isabela", "76851", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7058), "Calle 90", "Calle 15", new DateTime(1962, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 90,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "53284", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7070), "Calle 62", "Calle 59", new DateTime(1975, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 91,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "31197", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7085), "Calle 63", "Calle 84", new DateTime(1971, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 92,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Canovanas", "76152", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7099), "Calle 88", "Calle 23", new DateTime(1965, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 93,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Culebra", "98699", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7112), "Calle 24", "Calle 97", new DateTime(1986, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 94,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "24421", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7124), "Calle 91", "Calle 19", new DateTime(1994, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 95,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "96823", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7138), "Calle 3", "Calle 69", new DateTime(1992, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 96,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "19894", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7151), "Calle 76", "Calle 85", new DateTime(1987, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 97,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "56310", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7192), "Calle 6", "Calle 3", new DateTime(1980, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 98,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Vega Baja", "63012", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7204), "Calle 3", "Calle 99", new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 99,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "12289", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7218), "Calle 5", "Calle 72", new DateTime(1953, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 100,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "61461", new DateTime(2024, 11, 24, 12, 45, 21, 253, DateTimeKind.Local).AddTicks(7231), "Calle 47", "Calle 12", new DateTime(1951, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 1,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5510m, new DateTime(1951, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 85165m, 4701m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 2,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3789m, new DateTime(1980, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42649m, 7100m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 3,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3580m, new DateTime(1983, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 51520m, 4554m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 4,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3566m, new DateTime(1973, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12012m, 8995m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 5,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2019m, new DateTime(1953, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 95400m, 9211m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 6,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4968m, new DateTime(1979, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 79406m, 3555m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 7,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2802m, new DateTime(1950, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16186m, 9282m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 8,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3462m, new DateTime(1995, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 97260m, 1861m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 9,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8787m, new DateTime(1988, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 44353m, 9164m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 10,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3630m, new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48731m, 4513m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 11,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7539m, new DateTime(1950, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87465m, 4592m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 12,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8754m, new DateTime(1969, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 28148m, 4222m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 13,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4991m, new DateTime(1988, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 89773m, 6400m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 14,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8478m, new DateTime(1981, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50777m, 9951m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 15,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7861m, new DateTime(1958, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 83597m, 1757m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 16,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8965m, new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18035m, 7329m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 17,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4250m, new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 92057m, 7079m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 18,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1096m, new DateTime(1988, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 83845m, 9341m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 19,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8001m, new DateTime(1967, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 57135m, 2088m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 20,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2522m, new DateTime(1975, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 58931m, 1898m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 21,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4104m, new DateTime(1987, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70050m, 8879m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 22,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8028m, new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 25139m, 2958m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 23,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5727m, new DateTime(1975, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19582m, 3165m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 24,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9857m, new DateTime(1977, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 92496m, 6714m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 25,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7594m, new DateTime(1991, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 38569m, 3211m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 26,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9244m, new DateTime(1995, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 44117m, 5124m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 27,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8304m, new DateTime(1954, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 52766m, 8855m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 28,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3112m, new DateTime(1959, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 94639m, 7512m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 29,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3615m, new DateTime(1975, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 59616m, 7683m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 30,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1946m, new DateTime(1968, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 33404m, 4109m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 31,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3773m, new DateTime(1976, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 89355m, 8520m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 32,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6893m, new DateTime(1983, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40623m, 7899m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 33,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7242m, new DateTime(1999, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 66938m, 1239m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 34,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9125m, new DateTime(1956, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 76083m, 6288m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 35,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7184m, new DateTime(1952, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 67179m, 6910m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 36,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4597m, new DateTime(1952, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50555m, 4473m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 37,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3078m, new DateTime(1958, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 27842m, 5447m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 38,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5780m, new DateTime(1965, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 75238m, 4048m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 39,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5514m, new DateTime(1960, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 55304m, 2566m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 40,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8428m, new DateTime(1976, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28840m, 1954m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 41,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4453m, new DateTime(1963, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90855m, 4121m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 42,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4314m, new DateTime(1962, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87959m, 1947m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 43,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7010m, new DateTime(1984, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 78299m, 1835m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 44,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4518m, new DateTime(1955, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 90277m, 5314m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 45,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3594m, new DateTime(1951, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39053m, 4318m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 46,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9292m, new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12340m, 7008m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 47,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7299m, new DateTime(1977, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 43381m, 3241m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 48,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2972m, new DateTime(1967, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 83152m, 8988m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 49,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1031m, new DateTime(1953, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 89310m, 3869m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 50,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8967m, new DateTime(1994, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 67367m, 4227m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 51,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9416m, new DateTime(1995, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 45882m, 9466m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 52,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8778m, new DateTime(1969, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 48802m, 8998m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 53,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5200m, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 79709m, 4543m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 54,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8664m, new DateTime(1975, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 58001m, 7764m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 55,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3609m, new DateTime(1952, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 32389m, 3988m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 56,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7265m, new DateTime(1965, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 98224m, 4079m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 57,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5816m, new DateTime(1963, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 77974m, 7911m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 58,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7304m, new DateTime(1965, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 52745m, 5785m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 59,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8167m, new DateTime(1973, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35065m, 6501m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 60,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5628m, new DateTime(1983, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 20785m, 3219m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 61,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8768m, new DateTime(1954, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 48057m, 8506m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 62,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7376m, new DateTime(1961, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 31036m, 4574m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 63,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8122m, new DateTime(1957, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25777m, 6666m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 64,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3725m, new DateTime(1978, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 62875m, 2120m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 65,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3736m, new DateTime(1967, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 99344m, 2834m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 66,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9057m, new DateTime(1960, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34849m, 1723m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 67,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1313m, new DateTime(1954, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28992m, 6265m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 68,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3404m, new DateTime(1964, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 62108m, 8102m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 69,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2540m, new DateTime(1980, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17774m, 5828m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 70,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2161m, new DateTime(1958, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 41260m, 4813m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 71,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8007m, new DateTime(1965, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 99704m, 1219m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 72,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8608m, new DateTime(1988, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 94228m, 4794m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 73,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3624m, new DateTime(1997, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 51931m, 9607m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 74,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9944m, new DateTime(1979, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41875m, 7722m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 75,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1031m, new DateTime(1979, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 69697m, 8272m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 76,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6478m, new DateTime(1951, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15184m, 6504m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 77,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1169m, new DateTime(1953, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 61393m, 7594m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 78,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3546m, new DateTime(1956, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34614m, 8300m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 79,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4031m, new DateTime(1966, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25810m, 1169m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 80,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7074m, new DateTime(1993, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 90825m, 8958m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 81,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4068m, new DateTime(1978, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19347m, 3672m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 82,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1352m, new DateTime(1993, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21061m, 5063m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 83,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2191m, new DateTime(1966, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 27691m, 7188m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 84,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9181m, new DateTime(1998, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20648m, 7837m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 85,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8886m, new DateTime(1983, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 99732m, 1835m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 86,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6049m, new DateTime(1983, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 58727m, 6244m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 87,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1766m, new DateTime(1964, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35193m, 2716m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 88,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2307m, new DateTime(1957, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 34365m, 9324m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 89,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5340m, new DateTime(1994, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 31506m, 9415m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 90,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4860m, new DateTime(1973, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 89032m, 6955m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 91,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3266m, new DateTime(1973, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 63469m, 2012m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 92,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3902m, new DateTime(1959, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 53147m, 4180m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 93,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6829m, new DateTime(1958, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 44426m, 3638m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 94,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4472m, new DateTime(1950, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 26348m, 7262m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 95,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8356m, new DateTime(1975, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44933m, 7369m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 96,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8545m, new DateTime(1993, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 57986m, 8672m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 97,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7463m, new DateTime(1972, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 88237m, 2401m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 98,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7968m, new DateTime(1968, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 93658m, 6414m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 99,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7658m, new DateTime(1959, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 82215m, 1689m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 100,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4375m, new DateTime(1966, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 48191m, 2628m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 1,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1811m, "Salario 2044", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 2,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2772m, "Otro", "Salario 4772" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 3,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5118m, "Salario", "Salario 1340", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 4,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2373m, "Salario", "Salario 2022" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 5,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 7781m, "Salario 1072" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 6,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8635m, "Salario 2367", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 7,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8585m, "Salario 9628", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 8,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8294m, "Salario 2640", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 9,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 6476m, "Comision", "Salario 2735" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 10,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2974m, "Salario 8126", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 11,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5561m, "Otro", "Salario 9249", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 12,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3857m, "Otro", "Salario 9069", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 13,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6863m, "Otro", "Salario 2378", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 14,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2413m, "Bonos", "Salario 5311" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 15,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3923m, "Bonos", "Salario 6109" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 16,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9152m, "Salario 9925", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 17,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1221m, "Otro", "Salario 1496", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 18,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 1738m, "Salario 6321" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 19,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8892m, "Salario 6179", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 20,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4814m, "Otro", "Salario 5962", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 21,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 7932m, "Salario", "Salario 9626" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 22,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6418m, "Otro", "Salario 1410", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 23,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3945m, "Comision", "Salario 3634" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 24,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7440m, "Salario", "Salario 9250", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 25,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3670m, "Salario", "Salario 4978" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 26,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6912m, "Salario 7325", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 27,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9618m, "Bonos", "Salario 8198", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 28,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8511m, "Bonos", "Salario 6582", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 29,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5064m, "Otro", "Salario 9669", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 30,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4794m, "Salario 4009", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 31,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8711m, "Salario", "Salario 7780" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 32,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8586m, "Comision", "Salario 7956" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 33,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1977m, "Comision", "Salario 8097", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 34,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6728m, "Salario", "Salario 3285", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 35,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2345m, "Bonos", "Salario 5929", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 36,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 5229m, "Salario 9553" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 37,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4853m, "Otro", "Salario 1328", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 38,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3662m, "Otro", "Salario 9822", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 39,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2215m, "Salario", "Salario 9364", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 40,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8622m, "Otro", "Salario 2195", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 41,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2707m, "Salario 4538", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 42,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3333m, "Salario 3182", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 43,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1624m, "Salario 3442", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 44,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1963m, "Bonos", "Salario 8978", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 45,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6187m, "Salario", "Salario 9973", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 46,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8788m, "Bonos", "Salario 5941" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 47,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9802m, "Salario 8358", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 48,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1427m, "Otro", "Salario 8654" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 49,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2115m, "Bonos", "Salario 9853", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 50,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 1419m, "Salario 5040" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 51,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9142m, "Comision", "Salario 1881", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 52,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1648m, "Salario", "Salario 8637", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 53,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6247m, "Comision", "Salario 5829", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 54,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 5786m, "Comision", "Salario 4374" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 55,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7266m, "Bonos", "Salario 6184", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 56,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3550m, "Salario 1158", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 57,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7420m, "Bonos", "Salario 7984", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 58,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7698m, "Salario", "Salario 1095", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 59,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7850m, "Bonos", "Salario 7637", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 60,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7907m, "Bonos", "Salario 6155", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 61,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8789m, "Salario 2604", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 62,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3686m, "Salario 8615", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 63,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 8680m, "Salario 7443" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 64,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1656m, "Bonos", "Salario 1729", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 65,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8534m, "Bonos", "Salario 2852" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 66,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6411m, "Comision", "Salario 4035", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 67,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7547m, "Bonos", "Salario 1725", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 68,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4093m, "Bonos", "Salario 6070", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 69,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6086m, "Comision", "Salario 8089", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 70,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9781m, "Otro", "Salario 5180", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 71,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5707m, "Salario", "Salario 8149", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 72,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 5170m, "Bonos", "Salario 5571" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 73,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3969m, "Salario", "Salario 3683", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 74,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8208m, "Otro", "Salario 3664", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 75,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7211m, "Salario 2673", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 76,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5836m, "Salario", "Salario 5566", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 77,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6244m, "Bonos", "Salario 5936", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 78,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6829m, "Salario 9715", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 79,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 3646m, "Salario 9247", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 80,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5464m, "Otro", "Salario 3609", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 81,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4358m, "Comision", "Salario 9966", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 82,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8918m, "Salario", "Salario 2753", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 83,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6592m, "Salario 6799", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 84,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 9240m, "Salario 8510" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 85,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 6729m, "Salario 4795" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 86,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1832m, "Salario 1788", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 87,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6941m, "Salario 3129", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 88,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8304m, "Salario 9574", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 89,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9175m, "Salario", "Salario 4445", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 90,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 7246m, "Otro", "Salario 2408" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 91,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1804m, "Salario", "Salario 4818", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 92,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2736m, "Salario 9590", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 93,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1571m, "Salario", "Salario 7523" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 94,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8111m, "Salario 4937", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 95,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8509m, "Bonos", "Salario 3419", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 96,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 5851m, "Otro", "Salario 7917" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 97,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4010m, "Salario", "Salario 8063", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 98,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5934m, "Salario", "Salario 3577", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 99,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9626m, "Salario", "Salario 3500", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 100,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3985m, "Comision", "Salario 2818", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 1,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "106532108", null, "Paciente", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 2,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "717320197", null, "Padre", "Enfermero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 3,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "354464567", null, "Hermano", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 4,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "714811571", null, "Propietaria", "Arrendador" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 5,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "752982230", null, "Sobrino", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 6,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "541130465", null, "Hijo", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 7,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "295096125", null, "Compañera", "Director" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 8,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "857594498", null, "Madre", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 9,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "917989527", null, "Estudiante", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 10,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "497726061", null, "Proveedor", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 11,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "947491830", null, "Esposo", "Dueña" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 12,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "847909265", null, "Amigo", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 13,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "424657531", null, "Hija", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 14,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "257600553", null, "Doctor", "Hermano" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 15,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "199642082", null, "Empleada", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 16,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "994035501", null, "Arrendador", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 17,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "968049164", null, "Madre", "Propietario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 18,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "113531950", null, "Jefe", "Arrendatario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 19,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "993120786", null, "Estudiante", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 20,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "212265301", null, "Estudiante", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 21,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "622010773", null, "Dueño", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 22,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "741380577", null, "Primo", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 23,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "338477792", null, "Empleado", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 24,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "845648888", null, "Hijo", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 25,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "484423014", null, "Conocida", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 26,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "818367211", null, "Jefa", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 27,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "456074717", null, "Vecina", "Primo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 28,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "176066756", null, "Empleado", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 29,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "806925581", null, "Enfermero", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 30,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "208038281", null, "Jefa", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 31,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "349432912", null, "Esposa", "Enfermero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 32,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "190707819", null, "Tia", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 33,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "142537392", null, "Padre", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 34,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "366568905", null, "Padre", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 35,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "428827445", null, "Empleado", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 36,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "547576810", null, "Cliente", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 37,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "966407296", null, "Hija", "Director" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 38,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "160904164", null, "Abuelo", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 39,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "310960322", null, "Novia", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 40,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "211074100", null, "Estudiante", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 41,
                columns: new[] { "RMO", "ReferidoId", "TipoLink" },
                values: new object[] { "818085125", null, "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 42,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "523948300", null, "Hermano", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 43,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "168210357", null, "Inquilina", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 44,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "642485912", null, "Tio", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 45,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "881499424", null, "Directora", "Arrendatario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 46,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "103048010", null, "Madre", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 47,
                columns: new[] { "RMO", "ReferidoId", "Relacion" },
                values: new object[] { "785504656", null, "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 48,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "783830807", null, "Arrendador", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 49,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "694620968", null, "Conocida", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 50,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "392786725", null, "Inquilino", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 51,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "737591754", null, "Hermana", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 52,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "375020980", null, "Vecino", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 53,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "793427661", null, "Abuela", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 54,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "593689529", null, "Arrendataria", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 55,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "349515868", null, "Empleado", "Arrendadora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 56,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "425133594", null, "Dueño", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 57,
                columns: new[] { "RMO", "ReferidoId", "TipoLink" },
                values: new object[] { "949597002", null, "Madre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 58,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "280653882", null, "Cliente", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 59,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "909145037", null, "Sobrino", "Enfermero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 60,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "804790634", null, "Arrendataria", "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 61,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "112361189", null, "Conocido", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 62,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "495829616", null, "Arrendadora", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 63,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "819044518", null, "Hija", "Compañera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 64,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "940475799", null, "Arrendatario", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 65,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "491549373", null, "Dueña", "Arrendador" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 66,
                columns: new[] { "RMO", "ReferidoId", "Relacion" },
                values: new object[] { "971999063", null, "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 67,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "112213575", null, "Jefa", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 68,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "884692267", null, "Hija", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 69,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "791840986", null, "Jefe", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 70,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "997761975", null, "Gerente", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 71,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "470557381", null, "Abuelo", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 72,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "804989086", null, "Sobrino", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 73,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "501815646", null, "Estudiante", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 74,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "225182144", null, "Proveedor", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 75,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "562091713", null, "Amigo", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 76,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "401511740", null, "Tia", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 77,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "104087439", null, "Gerente", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 78,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "407282530", null, "Esposo", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 79,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "448739075", null, "Proveedor", "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 80,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "200878238", null, "Padre", "Dueña" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 81,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "645529534", null, "Esposa", "Tia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 82,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "167167424", null, "Empleado", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 83,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "569768561", null, "Proveedor", "Director" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 84,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "685167669", null, "Proveedor", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 85,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "406674081", null, "Paciente", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 86,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "285008244", null, "Esposo", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 87,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "543700363", null, "Maestro", "Dueño" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 88,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "120814431", null, "Cliente", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 89,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "954751207", null, "Paciente", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 90,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "109891811", null, "Empleada", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 91,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "228556714", null, "Arrendador", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 92,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "878110136", null, "Tia", "Arrendador" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 93,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "423718117", null, "Gerente", "Arrendador" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 94,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "697881934", null, "Inquilina", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 95,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "188347037", null, "Compañera", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 96,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "186710635", null, "Sobrino", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 97,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "108029669", null, "Doctor", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 98,
                columns: new[] { "RMO", "ReferidoId", "TipoLink" },
                values: new object[] { "969963525", null, "Conocido" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 99,
                columns: new[] { "RMO", "ReferidoId", "Relacion", "TipoLink" },
                values: new object[] { "445045176", null, "Prima", "Propietario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 100,
                columns: new[] { "RMO", "ReferidoId", "Relacion" },
                values: new object[] { "534130647", null, "Enfermera" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferidoId",
                table: "Conf_Personas_Links");

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Canovanas", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4106), "Calle 19", "Calle 81", "correo84@correo.com", new DateTime(1967, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Luz Elena Diaz", "Lares", "Calle 83", "Calle 60", "43964", "Region 5", "Tipo 6", "22907" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Corozal", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4130), "Calle 30", "Calle 9", "correo5@correo.com", new DateTime(1996, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Elena Hernandez", "Vega Baja", "Calle 13", "Calle 5", "39830", "Region 4", "Tipo 8", "87876" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Catano", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4148), "Calle 64", "Calle 51", "correo91@correo.com", new DateTime(1967, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Lorena Silva", "Carolina", "Calle 39", "Calle 77", "88589", "Tipo 7", "64434" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4164), "Calle 68", "Calle 52", "correo30@correo.com", new DateTime(1977, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Jorge Santana", "Guayama", "Calle 53", "Calle 47", "36760", "Region 2", "Tipo 9", "78085" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Catano", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4179), "Calle 2", "Calle 20", "correo60@correo.com", new DateTime(1951, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Lilia Martinez", "Arroyo", "Calle 10", "Calle 39", "67857", "Region 1", "Tipo 2", "68006" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Arecibo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4222), "Calle 82", "Calle 97", "correo14@correo.com", new DateTime(1991, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lourdes Soto", "Juncos", "Calle 17", "Calle 29", "47061", "Tipo 7", "19075" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Juana Diaz", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4238), "Calle 21", "Calle 88", "correo18@correo.com", new DateTime(1962, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Maria Santillan", "Fajardo", "Calle 92", "Calle 7", "61229", "Region 8", "Tipo 5", "86860" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Hatillo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4253), "Calle 23", "Calle 1", "correo92@correo.com", new DateTime(1952, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Lorena Ramirez", "Vega Baja", "Calle 58", "Calle 34", "62253", "Region 8", "Tipo 5", "91315" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4269), "Calle 83", "Calle 47", "correo13@correo.com", new DateTime(1981, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa Sandoval", "Carolina", "Calle 9", "Calle 92", "68304", "Region 4", "Tipo 3", "32153" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Las Marias", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4302), "Calle 33", "Calle 6", "correo65@correo.com", new DateTime(1954, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lidia Gomez", "Trujillo Alto", "Calle 71", "Calle 43", "20627", "Region 3", "Tipo 6", "76504" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Florida", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4317), "Calle 79", "Calle 13", "correo99@correo.com", new DateTime(1991, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Rocio Sandoval", "Las Piedras", "Calle 55", "Calle 44", "47003", "Region 9", "87400" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cayey", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4331), "Calle 15", "Calle 92", "correo90@correo.com", new DateTime(1961, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Juan Torres", "Aguas Buenas", "Calle 59", "Calle 92", "75479", "Region 7", "Tipo 7", "48893" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4346), "Calle 74", "Calle 52", "correo67@correo.com", new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Fernando Santana", "Jayuya", "Calle 52", "Calle 1", "77829", "Region 3", "83273" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Isabela", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4393), "Calle 21", "Calle 72", "correo81@correo.com", new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lourdes Lopez", "Aguas Buenas", "Calle 83", "Calle 8", "74133", "Region 7", "Tipo 9", "12713" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Lares", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4409), "Calle 48", "Calle 4", "correo89@correo.com", new DateTime(1979, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Luz Saucedo", "Lares", "Calle 44", "Calle 26", "85151", "Region 8", "46772" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguada", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4424), "Calle 57", "Calle 21", "correo92@correo.com", new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Sofia Suarez", "Lajas", "Calle 77", "Calle 25", "45432", "Region 8", "Tipo 9", "15151" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 17,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Camuy", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4439), "Calle 3", "Calle 48", "correo38@correo.com", new DateTime(1977, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Liz Santillana", "Cayey", "Calle 65", "Calle 59", "32426", "Region 5", "Tipo 5", "93204" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aibonito", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4488), "Calle 61", "Calle 23", "correo29@correo.com", new DateTime(1972, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Leticia Lopez", "San Juan", "Calle 22", "Calle 81", "18032", "Region 9", "Tipo 9", "67817" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ponce", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4503), "Calle 89", "Calle 64", "correo80@correo.com", new DateTime(1960, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Pedro Garcia", "San Juan", "Calle 58", "Calle 97", "27269", "Region 2", "Tipo 1", "19113" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4518), "Calle 60", "Calle 37", "correo95@correo.com", new DateTime(1967, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Luis Lopez", "Hormigueros", "Calle 22", "Calle 39", "95615", "Region 5", "Tipo 6", "45185" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4533), "Calle 13", "Calle 65", "correo72@correo.com", new DateTime(1955, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Pedro Diaz", "Cidra", "Calle 34", "Calle 45", "21682", "Region 4", "Tipo 3", "45508" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4567), "Calle 74", "Calle 56", "correo78@correo.com", new DateTime(1978, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo Santamaria", "Culebra", "Calle 51", "Calle 97", "33029", "Region 3", "Tipo 5", "96150" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguada", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4584), "Calle 27", "Calle 97", "correo32@correo.com", new DateTime(1988, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Sofia Ramirez", "Arroyo", "Calle 60", "Calle 43", "83238", "Region 6", "Tipo 1", "70892" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Toa Alta", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4599), "Calle 19", "Calle 41", "correo71@correo.com", new DateTime(1966, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorena Sosa", "Barceloneta", "Calle 42", "Calle 56", "96721", "Tipo 5", "41800" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4615), "Calle 37", "Calle 70", "correo21@correo.com", new DateTime(1954, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Rocio Saucedo", "Lajas", "Calle 85", "Calle 93", "33257", "Region 8", "Tipo 4", "92767" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4631), "Calle 29", "correo87@correo.com", new DateTime(1951, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Jorge Diaz", "Guayanilla", "Calle 88", "Calle 16", "46103", "Region 3", "Tipo 1", "33700" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Juncos", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4669), "Calle 55", "Calle 98", "correo6@correo.com", new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lorena Lopez", "Cataño", "Calle 51", "Calle 10", "46568", "Region 4", "63575" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 28,
                columns: new[] { "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4686), "Calle 42", "Calle 49", "correo3@correo.com", new DateTime(1998, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Jose Santacruz", "Cataño", "Calle 19", "Calle 8", "62546", "Region 4", "Tipo 3", "59715" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Ceiba", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4701), "Calle 44", "Calle 86", "correo1@correo.com", new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Fernando Garcia", "Isabela", "Calle 34", "Calle 42", "93855", "Region 2", "Tipo 7", "21280" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Juncos", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4717), "Calle 57", "Calle 82", "correo36@correo.com", new DateTime(1992, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luz Vazquez", "Dorado", "Calle 8", "Calle 66", "11808", "Region 3", "Tipo 4", "57736" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "San Juan", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4774), "Calle 85", "Calle 64", "correo32@correo.com", new DateTime(1989, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Liliana Ramirez", "Caguas", "Calle 64", "Calle 68", "67446", "Region 7", "Tipo 5", "96270" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lajas", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4789), "Calle 45", "Calle 19", "correo38@correo.com", new DateTime(1978, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 6", "Lourdes Rojas", "Gurabo", "Calle 34", "Calle 96", "37775", "Region 4", "Tipo 7", "45727" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4804), "Calle 94", "Calle 77", "correo60@correo.com", new DateTime(1981, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Lourdes Garcia", "Caguas", "Calle 89", "Calle 83", "53027", "Region 9", "Tipo 3", "29987" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Humacao", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4822), "Calle 37", "Calle 36", "correo98@correo.com", new DateTime(1998, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Luz Lopez", "Camuy", "Calle 77", "Calle 82", "40314", "Region 6", "Tipo 2", "60085" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4864), "Calle 66", "Calle 38", "correo30@correo.com", new DateTime(1982, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 7", "Liliana Serrano", "Lajas", "Calle 38", "Calle 83", "62066", "Region 9", "14068" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4880), "Calle 7", "Calle 13", "correo78@correo.com", new DateTime(1967, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Luz Perez", "Jayuya", "Calle 9", "Calle 54", "67455", "Region 5", "Tipo 3", "85987" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Humacao", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4895), "Calle 27", "Calle 47", "correo37@correo.com", new DateTime(1977, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa Lopez", "Ciales", "Calle 56", "Calle 35", "98839", "Region 2", "Tipo 6", "86427" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4910), "Calle 72", "Calle 88", "correo21@correo.com", new DateTime(1957, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Luz Santillan", "Aguada", "Calle 46", "Calle 11", "56277", "Tipo 8", "66793" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4946), "Calle 3", "Calle 27", "correo15@correo.com", new DateTime(1977, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 4", "Carlos Reyes", "Florida", "Calle 73", "Calle 67", "95142", "Region 3", "Tipo 7", "34843" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Dorado", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4961), "Calle 72", "Calle 24", "correo59@correo.com", new DateTime(1995, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Luisa Santana", "Lajas", "Calle 38", "Calle 41", "65047", "Region 2", "Tipo 8", "57327" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Carolina", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4977), "Calle 2", "Calle 87", "correo32@correo.com", new DateTime(1950, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 5", "Ana Silva", "Cayey", "Calle 13", "Calle 93", "79332", "Region 5", "Tipo 1", "82920" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Lares", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(4992), "Calle 94", "Calle 52", "correo67@correo.com", new DateTime(1998, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Carmen Gomez", "Caguas", "Calle 89", "Calle 91", "38046", "Region 9", "Tipo 6", "41814" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 43,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5026), "Calle 50", "Calle 21", new DateTime(1977, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Rosa Saucedo", "Cidra", "Calle 64", "Calle 27", "19222", "Region 2", "Tipo 6", "19779" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5042), "Calle 70", "Calle 79", "correo74@correo.com", new DateTime(1962, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 2", "Juan Garcia", "Barranquitas", "Calle 10", "Calle 40", "36326", "Region 7", "Tipo 4", "79246" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Culebra", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5057), "Calle 90", "Calle 29", "correo37@correo.com", new DateTime(1970, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 8", "Carlos Santos", "Trujillo Alto", "Calle 70", "Calle 92", "49511", "Region 9", "Tipo 6", "93021" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5073), "Calle 86", "Calle 18", "correo58@correo.com", new DateTime(1982, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 1", "Ana Vazquez", "Lares", "Calle 47", "Calle 38", "38800", "Region 3", "73810" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Canovanas", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5088), "Calle 18", "Calle 34", "correo71@correo.com", new DateTime(1963, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 3", "Rosa Jimenez", "Carolina", "Calle 94", "Calle 46", "34603", "Region 5", "50539" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Aguada", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5121), "Calle 1", "Calle 64", "correo73@correo.com", new DateTime(1957, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Diana Soto", "Carolina", "Calle 26", "Calle 42", "59059", "Region 5", "Tipo 1", "33963" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "TipoAgencia", "ZipCode" },
                values: new object[] { "Cataño", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5137), "Calle 14", "Calle 12", "correo2@correo.com", new DateTime(1964, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Luz Gonzalez", "Hatillo", "Calle 98", "Calle 59", "30363", "Region 3", "Tipo 2", "26274" });

            migrationBuilder.UpdateData(
                table: "Conf_Agencias",
                keyColumn: "AgenciaId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CreateDate", "Direccion1", "Direccion2", "EmailContacto", "FechaInicio", "NombreAgencia", "PersonaContacto", "PostalCiudad", "PostalDireccion1", "PostalDireccion2", "PostalZipCode", "Region", "ZipCode" },
                values: new object[] { "Florida", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(5153), "Calle 83", "Calle 98", "correo48@correo.com", new DateTime(1964, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agencia 9", "Ricardo Diaz", "Arroyo", "Calle 15", "Calle 72", "20468", "Region 4", "98180" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 1,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Rojas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7476), "Doctorado", "Soltero", "Canadiense", new DateTime(1987, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "C", "Guayanilla", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7368), "Rocio", "Jubilado", "Otro", "948017859", "745013595", "163545017", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 2,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7498), "Secundaria", "Divorciado", "Europea", new DateTime(1977, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "L", "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7478), "Liz", "Ama de casa", "Morena", "Cristiana", "855788884", "790168865", "723930861", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 3,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Santamaria", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7541), "Otro", "Casado", "Asiatica", new DateTime(1962, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "Guanica", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7521), "Desempleado", "Agnostico", "110740617", "986500528", "709719594", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 4,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Torres", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7561), "Preparatoria", "Viudo", new DateTime(1966, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "L", "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7542), "Lourdes", "Estudiante", "Otra", "Mormon", "688861358", "704354963", "596943851", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 5,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Saucedo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7580), "Mexicana", new DateTime(1961, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7561), "Rosa", "Jubilado", "Negra", "Mormon", "173931047", "722480266", "379891237", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 6,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Rojas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7613), "Secundaria", "Viudo", "Otra", new DateTime(1983, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "San Juan", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7581), "Lidia", "Jubilado", "Otra", "Otro", "503903225", "286739013", "415498603", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 7,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Santoyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7636), "Otro", "Divorciado", "Europea", new DateTime(1968, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "L", "Guaynabo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7614), "Jorge", "Empleado", "Otra", "Agnostico", "131815935", "559961755", "159952547", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 8,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Ramirez", "Salazar", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7655), "Doctorado", "Viudo", "Canadiense", new DateTime(1986, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "F", "Isabela", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7636), "Maria", "Desempleado", "Otra", "Mormon", "367117847", "223168657", "181844561" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 9,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7673), "Licenciatura", "Casado", "Estadounidense", new DateTime(1987, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Hatillo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7655), "Fernando", "Jubilado", "Otra", "Testigo de Jehova", "194143852", "163059686", "453579106", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 10,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7743), "Doctorado", "Casado", "Mexicana", new DateTime(1974, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7674), "Carlos", "Jubilado", "Amarilla", "289417540", "881167725", "815682410", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 11,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Garcia", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7763), "Preparatoria", "Viudo", "Africana", new DateTime(1957, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "Arroyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7743), "Carmen", "Empleado", "Otra", "Mormon", "995231584", "983670469", "439711598", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 12,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Jimenez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7782), "Mexicana", new DateTime(1981, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "Canovanas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7763), "Sofia", "Otro", "Otra", "Mormon", "284547784", "685083326", "606760568", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 13,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", "Lopez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7801), "Doctorado", "Viudo", "Canadiense", new DateTime(1993, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "R", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7783), "Lilia", "Estudiante", "Negra", "Cristiana", "120837889", "564346029", "687375080", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 14,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Santos", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7850), "Primaria", "Casado", "Canadiense", new DateTime(1953, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "J", "Catano", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7802), "Luisa", "Empleado", "Ateo", "860882350", "221283194", "637919438", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 15,
                columns: new[] { "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7869), "Viudo", "Asiatica", new DateTime(1965, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "L", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7850), "Ana", "Estudiante", "Morena", "Catolica", "300491184", "124397240", "184597451", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 16,
                columns: new[] { "ApellidoMaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7887), "Preparatoria", "Casado", "Estadounidense", new DateTime(1986, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "D", "Caguas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7870), "Maria", "Amarilla", "Cristiana", "865695546", "636683622", "832215565", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 17,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Santoyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7906), "Licenciatura", "Soltero", "Europea", new DateTime(1950, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "A", "Ciales", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7888), "Rosa", "Desempleado", "Morena", "919473436", "575458935", "759772350", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 18,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7958), "Viudo", "Asiatica", new DateTime(1971, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "L", "Corozal", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7907), "Liz", "Negra", "Catolica", "950386501", "966391599", "975847348", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 19,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Garcia", "Santamaria", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7977), "Divorciado", new DateTime(1986, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", "Corozal", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7959), "Ricardo", "Amarilla", "Mormon", "130209991", "962029016", "887786828" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 20,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Diaz", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7996), "Licenciatura", "Casado", "Canadiense", new DateTime(1952, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "J", "Ciales", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7978), "Miguel", "Catolica", "414841268", "639718351", "758090473", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 21,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillana", "Garcia", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8015), "Preparatoria", "Estadounidense", new DateTime(1980, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "L", "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(7997), "Luz", "Negra", "Mormon", "661987181", "766438228", "296258469", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 22,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Lopez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8060), "Maestria", "Europea", new DateTime(1964, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "Guaynabo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8016), "Liz", "Empleado", "Morena", "556542507", "191916542", "280673459", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 23,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santoyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8079), "Secundaria", "Estadounidense", new DateTime(1951, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "R", "Guanica", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8060), "Lourdes", "Estudiante", "Negra", "Cristiana", "290935040", "731590936", "667106182", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 24,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Santos", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8098), "Primaria", "Casado", "Canadiense", new DateTime(1960, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "Comerio", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8080), "Empleado", "Otra", "517022450", "968741099", "727691517", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 25,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Torres", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8117), "Doctorado", "Estadounidense", new DateTime(1961, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "L", "Juncos", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8099), "Leticia", "Desempleado", "Blanca", "Agnostico", "446545917", "125864808", "458842701", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 26,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Perez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8161), "Secundaria", "Mexicana", new DateTime(1973, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "E", "Barceloneta", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8141), "Liliana", "Amarilla", "Catolica", "611726689", "254991878", "129798177", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 27,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Torres", "Gonzalez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8180), "Licenciatura", "Canadiense", new DateTime(1979, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Guaynabo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8162), "Lorena", "Morena", "754616333", "526236419", "179983016", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 28,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Hernandez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8198), "Otro", "Divorciado", "Mexicana", new DateTime(1976, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8180), "Rosa", "Ama de casa", "Blanca", "Catolica", "277218504", "745124631", "367338969", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 29,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8252), "Otra", new DateTime(1971, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "R", "Vega Baja", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8199), "Raul", "Jubilado", "Blanca", "Mormon", "713121576", "941842230", "280005928", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 30,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Garcia", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8273), "Primaria", "Divorciado", "Mexicana", new DateTime(1995, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "M", "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8253), "Luz Maria", "Otro", "Amarilla", "Otro", "753233441", "345138476", "846234798", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 31,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Jimenez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8291), "Secundaria", "Estadounidense", new DateTime(1984, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "C", "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8273), "Carmen", "Estudiante", "Agnostico", "482802292", "669488044", "875821989", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 32,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Suarez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8310), "Preparatoria", "Estadounidense", new DateTime(1970, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "R", "Cayey", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8292), "Otra", "Mormon", "583920115", "568453138", "438619735", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 33,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Sandoval", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8352), "Secundaria", "Soltero", "Europea", new DateTime(1961, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "M", "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8310), "Lorena", "Empleado", "Amarilla", "Mormon", "341456467", "968602561", "293577119", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 34,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santamaria", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8373), "Maestria", "Casado", "Europea", new DateTime(1965, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "L", "Dorado", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8354), "Luz", "Estudiante", "721411840", "237783237", "730833656", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 35,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Reyes", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8392), "Secundaria", "Canadiense", new DateTime(1950, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "L", "Caguas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8374), "Luz", "Ama de casa", "Amarilla", "Otro", "691862769", "334396918", "118621668", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 36,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Rojas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8411), "Otro", "Casado", "Canadiense", new DateTime(1982, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8393), "Carlos", "Morena", "Otro", "713379082", "431740589", "668872187", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 37,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Suarez", "Serrano", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8451), "Canadiense", new DateTime(1953, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "F", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8412), "Lourdes", "Otro", "Amarilla", "Mormon", "783412267", "532853523", "420208800", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 38,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Hernandez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8471), "Licenciatura", "Viudo", new DateTime(1959, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "Guanica", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8452), "Luis", "Empleado", "Morena", "Ateo", "285967697", "250481351", "961203408", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 39,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Santillana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8489), "Licenciatura", "Divorciado", "Estadounidense", new DateTime(1987, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "J", "Jayuya", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8471), "Diana", "Ama de casa", "Blanca", "605320692", "192537829", "143306925", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 40,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Saucedo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8507), "Secundaria", "Europea", new DateTime(1976, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "A", "Arroyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8490), "Lourdes", "Empleado", "Testigo de Jehova", "490622243", "713005707", "468381493", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 41,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Sosa", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8555), "Viudo", "Africana", new DateTime(1961, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "A", "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8508), "Lourdes", "Catolica", "144900639", "625154718", "808251856", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 42,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Ramirez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8574), "Doctorado", "Viudo", "Mexicana", new DateTime(1972, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8556), "Rosa", "Empleado", "Negra", "Otro", "916829714", "377647119", "414956650", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 43,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Saucedo", "Santibañez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8593), "Maestria", "Soltero", "Mexicana", new DateTime(1982, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "L", "Guaynabo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8575), "Lourdes", "Empleado", "Otra", "Agnostico", "498257968", "689270983", "612254007", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 44,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Santillan", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8612), "Divorciado", "Canadiense", new DateTime(1950, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "M", "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8593), "Lorena", "Otro", "Otra", "Testigo de Jehova", "932287726", "593118510", "784660705", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 45,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Salazar", "Soto", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8661), "Licenciatura", "Africana", new DateTime(1976, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secundaria", "Cayey", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8612), "Miguel", "Ama de casa", "Morena", "Cristiana", "716781745", "360077290", "434023020", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 46,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8679), "Doctorado", "Divorciado", "Otra", new DateTime(1995, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "Toa Baja", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8662), "Elena", "Jubilado", "Catolica", "260525307", "162898338", "335861793", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 47,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Vazquez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8698), "Primaria", "Casado", "Otra", new DateTime(1966, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "L", "Hatillo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8680), "Luz", "Empleado", "Mormon", "996404439", "218806373", "515921766", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 48,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Reyes", "Santillana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8717), "Maestria", "Estadounidense", new DateTime(1982, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Otro", "L", "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8699), "Miguel", "Estudiante", "Amarilla", "Mormon", "826582538", "600631737", "933792943", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 49,
                columns: new[] { "ApellidoMaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8759), "Doctorado", "Divorciado", new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Primaria", "Canovanas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8739), "Luz", "Empleado", "Negra", "Agnostico", "789734718", "623126182", "728709490", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 50,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Jimenez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8778), "Primaria", "Soltero", "Canadiense", new DateTime(1979, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Doctorado", "L", "Las Piedras", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8760), "Sofia", "Ama de casa", "Blanca", "Otro", "518805339", "211125085", "213411435" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 51,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillan", "Rojas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8797), "Doctorado", "Estadounidense", new DateTime(1993, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Aguas Buenas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8779), "Laura", "Desempleado", "Blanca", "Mormon", "567295818", "128806020", "988996911", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 52,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Sosa", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8878), "Mexicana", new DateTime(1998, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8797), "Jubilado", "Blanca", "Ateo", "940603688", "844431748", "157540834", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 53,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Garcia", "Sosa", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8936), "Maestria", "Soltero", "Africana", new DateTime(1988, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8879), "Raul", "Estudiante", "Negra", "Otro", "962906794", "425844590", "311789845", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 54,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Reyes", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8956), "Primaria", "Casado", "Asiatica", new DateTime(1985, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "M", "Lajas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8936), "Lorena", "Estudiante", "Amarilla", "Cristiana", "538981339", "846582765", "882003813", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 55,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sandoval", "Serrano", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8975), "Maestria", "Viudo", "Otra", new DateTime(1984, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Juana Diaz", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8957), "Luz Elena", "Jubilado", "Otra", "Cristiana", "517783262", "960677954", "569349347", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 56,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Soto", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9017), "Secundaria", "Viudo", "Estadounidense", new DateTime(1992, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "P", "Dorado", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(8976), "Pedro", "Otro", "797899810", "709941319", "292757857" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 57,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Soto", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9037), "Primaria", "Africana", new DateTime(1997, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Secundaria", "Cayey", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9017), "Pedro", "Estudiante", "Catolica", "403190059", "131671588", "500521800", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 58,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santamaria", "Suarez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9056), "Viudo", "Mexicana", new DateTime(1971, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "D", "Jayuya", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9037), "Jorge", "Estudiante", "Amarilla", "Ateo", "215024202", "247713350", "747130964", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 59,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Diaz", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9074), "Otro", "Soltero", "Otra", new DateTime(1960, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Licenciatura", "Caguas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9056), "Laura", "Estudiante", "Blanca", "772374739", "409808316", "365429465", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 60,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Soto", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9115), "Doctorado", "Otra", new DateTime(1964, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9074), "Rosa", "Desempleado", "Negra", "Ateo", "340630407", "812395893", "408845190", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 61,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Ramirez", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9135), "Preparatoria", "Canadiense", new DateTime(1965, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "L", "Camuy", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9116), "Ricardo", "Desempleado", "Negra", "Ateo", "280563145", "978286873", "579750503", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 62,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Jimenez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9154), "Maestria", "Canadiense", new DateTime(1967, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Doctorado", "J", "Corozal", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9136), "Laura", "Desempleado", "Negra", "Ateo", "782246858", "693817380", "860671163" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 63,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Torres", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9172), "Otro", "Divorciado", "Canadiense", new DateTime(1961, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "Ceiba", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9155), "Lourdes", "Jubilado", "Agnostico", "410066569", "777866843", "176198053", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 64,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Saucedo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9211), "Casado", new DateTime(1951, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "F", "Carolina", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9173), "Carmen", "Desempleado", "Amarilla", "Cristiana", "822577766", "102995400", "336174788", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 65,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Torres", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9231), "Doctorado", "Soltero", "Mexicana", new DateTime(1992, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "J", "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9212), "Lilia", "Ama de casa", "Morena", "Agnostico", "473739358", "278309444", "397630149" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 66,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Sosa", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9250), "Preparatoria", "Casado", "Europea", new DateTime(1981, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Maestria", "L", "Camuy", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9232), "Liliana", "Jubilado", "Negra", "Otro", "419405442", "355496286", "939500052", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 67,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santacruz", "Saucedo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9268), "Doctorado", "Divorciado", "Mexicana", new DateTime(1992, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Preparatoria", "L", "Barranquitas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9251), "Rocio", "Otro", "Otra", "Catolica", "860870418", "487521436", "753064421", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 68,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9301), "Secundaria", "Viudo", "Mexicana", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "Barranquitas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9282), "Diana", "Ama de casa", "Blanca", "Mormon", "604998814", "746808909", "488912822", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 69,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Rojas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9320), "Primaria", "Divorciado", "Estadounidense", new DateTime(1994, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Otro", "Vega Baja", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9302), "Jose", "Desempleado", "Negra", "Ateo", "652073852", "331935915", "213915466" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 70,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Sosa", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9339), "Licenciatura", "Europea", new DateTime(1957, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "Trujillo Alto", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9321), "Luz Maria", "Otro", "874952213", "825847143", "730883320", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 71,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Perez", "Suarez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9384), "Maestria", "Viudo", "Africana", new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9339), "Lilia", "Jubilado", "Morena", "Otro", "395080968", "104246201", "800865227", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 72,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Santos", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9404), "Viudo", "Canadiense", new DateTime(1968, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "A", "Jayuya", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9384), "Luis", "Empleado", "Negra", "563993288", "712778810", "341510170", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 73,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia" },
                values: new object[] { "Santillan", "Reyes", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9423), "Maestria", "Mexicana", new DateTime(1977, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "J", "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9405), "Lourdes", "Ama de casa", "Negra", "Ateo", "726566059", "371735345", "369604093" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 74,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9442), "Secundaria", "Casado", "Europea", new DateTime(1994, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Secundaria", "M", "Humacao", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9424), "Luz Maria", "Ama de casa", "Catolica", "423071869", "941392797", "232080485", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 75,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9491), "Preparatoria", "Viudo", new DateTime(1962, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "C", "Jayuya", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9442), "Laura", "Negra", "Cristiana", "364906512", "731441346", "974594629", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 76,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillana", "Hernandez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9511), "Secundaria", "Viudo", new DateTime(1986, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "L", "Aguas Buenas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9492), "Lorena", "Jubilado", "Amarilla", "Ateo", "502466497", "933467921", "908515591", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 77,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gonzalez", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9530), "Primaria", "Casado", new DateTime(1988, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "C", "Vega Alta", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9512), "Lourdes", "Otro", "Amarilla", "Agnostico", "372896216", "996904030", "565211781", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 78,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Saucedo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9548), "Otro", "Divorciado", "Europea", new DateTime(1957, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "Carolina", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9530), "Luz Elena", "Testigo de Jehova", "443683105", "162286750", "918929622", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 79,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Soto", "Santillana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9588), "Otro", "Divorciado", "Asiatica", new DateTime(1961, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "Corozal", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9549), "Juan", "Estudiante", "501268836", "548233583", "837385598", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 80,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Rojas", "Santos", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9607), "Licenciatura", "Viudo", "Otra", new DateTime(1989, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Primaria", "Guayama", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9588), "Luis", "Otro", "487303836", "665241816", "371660122", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 81,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Gonzalez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9625), "Maestria", "Soltero", "Estadounidense", new DateTime(1964, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "R", "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9608), "Carmen", "Jubilado", "Blanca", "825614486", "801061465", "595733789", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 82,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Etnia", "FechaNacimiento", "Genero", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santillana", "Jimenez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9644), "Africana", new DateTime(1967, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "L", "Culebra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9626), "Maria", "Desempleado", "Amarilla", "Ateo", "987753512", "477085522", "510747113", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 83,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Salazar", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9684), "Secundaria", "Divorciado", "Canadiense", new DateTime(1973, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "C", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9645), "Empleado", "Blanca", "Cristiana", "814212465", "614789380", "953167965", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 84,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Gomez", "Suarez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9704), "Doctorado", "Casado", "Canadiense", new DateTime(1984, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "L", "Ciales", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9684), "Luz", "Empleado", "Otra", "Ateo", "916879218", "177600847", "983649992", "Arq." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 85,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9722), "Preparatoria", "Casado", new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Barranquitas", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9704), "Sofia", "Jubilado", "Amarilla", "Ateo", "315527525", "700044473", "731341458", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 86,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Torres", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9741), "Secundaria", "Casado", "Africana", new DateTime(1979, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "Cidra", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9723), "Rosa", "Morena", "Agnostico", "992204105", "772841299", "127229914", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 87,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Hernandez", "Torres", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9797), "Divorciado", "Estadounidense", new DateTime(1995, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "R", "Humacao", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9742), "Lorena", "Otro", "Blanca", "Cristiana", "851490909", "266864993", "790673154", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 88,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Diaz", "Garcia", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9816), "Secundaria", "Viudo", new DateTime(1983, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Preparatoria", "M", "Ceiba", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9797), "Jorge", "Ama de casa", "Blanca", "Ateo", "146686485", "260277249", "539065981", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 89,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Suarez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9835), "Licenciatura", "Soltero", "Canadiense", new DateTime(1980, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Licenciatura", "Cayey", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9817), "Liz", "Otro", "Amarilla", "Mormon", "489928528", "199427548", "819116524", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 90,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Serrano", "Santoyo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9853), "Secundaria", "Divorciado", "Canadiense", new DateTime(1997, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primaria", "D", "Isabela", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9835), "Jorge", "Empleado", "Amarilla", "Testigo de Jehova", "452843932", "615713709", "980805753", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 91,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Silva", "Vazquez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9893), "Preparatoria", "Casado", "Canadiense", new DateTime(1976, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "C", "Ciales", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9854), "Liz", "Desempleado", "Amarilla", "Testigo de Jehova", "846680593", "644112724", "372812634", "Ing." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 92,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santana", "Ramirez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9912), "Preparatoria", "Casado", "Canadiense", new DateTime(1977, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Maestria", "L", "San Juan", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9894), "Miguel", "Empleado", "Negra", "499430887", "506612448", "903927962", "Mtra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 93,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Jimenez", "Vazquez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9931), "Licenciatura", "Soltero", "Estadounidense", new DateTime(1971, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctorado", "Coamo", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9913), "Rosa", "Otro", "Amarilla", "Testigo de Jehova", "419121061", "509103337", "753673093", "C.P." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 94,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Lopez", "Lopez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9950), "Primaria", "Divorciado", "Otra", new DateTime(1962, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciatura", "L", "Hormigueros", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9932), "Carmen", "Jubilado", "Morena", "Otro", "788390736", "798003547", "687963428", "Sr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 95,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Gomez", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9991), "Casado", "Asiatica", new DateTime(1996, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Preparatoria", "L", "Bayamon", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9951), "Luisa", "Empleado", "Negra", "824942461", "666928332", "463580761", "Sra." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 96,
                columns: new[] { "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(10), "Preparatoria", "Soltero", "Asiatica", new DateTime(1978, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maestria", "J", "Trujillo Alto", new DateTime(2024, 7, 22, 0, 44, 31, 112, DateTimeKind.Local).AddTicks(9991), "Miguel", "Jubilado", "Amarilla", "Agnostico", "525995452", "474552132", "608124088", "Dr." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 97,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Vazquez", "Silva", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(29), "Preparatoria", "Mexicana", new DateTime(1969, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Secundaria", "R", "Hatillo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(10), "Jorge", "Otro", "Catolica", "393446052", "357454588", "332007982", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 98,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "Raza", "Religion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santos", "Serrano", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(48), "Doctorado", "Viudo", "Estadounidense", new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro", "Otro", "Gurabo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(29), "Lorena", "Ama de casa", "Amarilla", "Agnostico", "380197418", "418396446", "172035566", "Mtro." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 99,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Raza", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santibañez", "Santillan", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(93), "Preparatoria", "Soltero", "Mexicana", new DateTime(1981, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparatoria", "F", "Fajardo", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(73), "Rosa", "Otra", "279975853", "579839368", "970777423", "Dra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas",
                keyColumn: "PersonaId",
                keyValue: 100,
                columns: new[] { "ApellidoMaterno", "ApellidoPaterno", "CreateDate", "Escolaridad", "EstadoCivil", "Etnia", "FechaNacimiento", "Genero", "GradAcademico", "Inicial", "LugarNacePueplo", "ModifiedDate", "Nombre", "Ocupacion", "SeguroSocial", "TelefonoCelular", "TelefonoResidencia", "Titulo" },
                values: new object[] { "Santoyo", "Santana", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(112), "Maestria", "Soltero", "Mexicana", new DateTime(1974, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Licenciatura", "J", "Camuy", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(94), "Carlos", "Desempleado", "496270264", "790731168", "313051968", "Lic." });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 1,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ponce", "83154", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(1954), "Calle 3", "Calle 38", new DateTime(1971, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 2,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "89786", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(1968), "Calle 79", "Calle 71", new DateTime(1993, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 3,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cabo Rojo", "99062", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(1978), "Calle 47", "Calle 78", new DateTime(1984, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 4,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Hatillo", "79341", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(1990), "Calle 69", "Calle 24", new DateTime(1957, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 5,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Comerio", "92424", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2001), "Calle 41", "Calle 50", new DateTime(1999, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 6,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Las Marias", "19661", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2016), "Calle 80", "Calle 32", new DateTime(1984, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 7,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "67370", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2056), "Calle 2", "Calle 53", new DateTime(1972, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 8,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "87654", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2067), "Calle 8", "Calle 64", new DateTime(1973, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 9,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Caguas", "62430", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2078), "Calle 60", "Calle 60", new DateTime(1955, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 10,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aibonito", "38983", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2090), "Calle 21", "Calle 45", new DateTime(1953, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 11,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guanica", "71474", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2100), "Calle 97", "Calle 31", new DateTime(1968, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 12,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Barceloneta", "19263", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2110), "Calle 95", "Calle 28", new DateTime(1990, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 13,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "11981", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2122), "Calle 92", "Calle 36", new DateTime(1998, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 14,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aguadilla", "20545", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2156), "Calle 60", "Calle 91", new DateTime(1955, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 15,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ceiba", "97356", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2167), "Calle 92", new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 16,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "29946", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2178), "Calle 18", "Calle 29", new DateTime(1954, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 17,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "73172", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2190), "Calle 15", "Calle 20", new DateTime(1999, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 18,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Ponce", "70632", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2200), "Calle 10", "Calle 58", new DateTime(1980, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 19,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Humacao", "23295", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2210), "Calle 35", "Calle 91", new DateTime(1950, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 20,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "58868", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2220), "Calle 53", "Calle 21", new DateTime(1987, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 21,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "12863", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2231), "Calle 82", "Calle 30", new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 22,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "32630", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2261), "Calle 8", "Calle 60", new DateTime(1954, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 23,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Fajardo", "93267", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2270), "Calle 82", "Calle 24", new DateTime(1983, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 24,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "41032", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2281), "Calle 23", "Calle 99", new DateTime(1951, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 25,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guanica", "42379", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2292), "Calle 81", "Calle 93", new DateTime(1959, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 26,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "77471", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2303), "Calle 12", new DateTime(1960, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 27,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hatillo", "11788", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2313), "Calle 33", "Calle 47", new DateTime(1953, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 28,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Aguadilla", "13303", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2324), "Calle 57", "Calle 70", new DateTime(1974, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 29,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ponce", "66371", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2335), "Calle 86", "Calle 60", new DateTime(1956, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 30,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayanilla", "51135", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2366), "Calle 56", "Calle 85", new DateTime(1985, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 31,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Camuy", "63071", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2376), "Calle 61", "Calle 21", new DateTime(1956, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 32,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Coamo", "59413", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2386), "Calle 55", "Calle 15", new DateTime(1972, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 33,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "55990", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2396), "Calle 71", "Calle 61", new DateTime(1961, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 34,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "50277", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2407), "Calle 42", "Calle 42", new DateTime(1975, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 35,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Culebra", "69876", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2418), "Calle 5", "Calle 65", new DateTime(1981, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 36,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "70664", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2428), "Calle 12", "Calle 46", new DateTime(1952, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 37,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "30060", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2460), "Calle 27", "Calle 23", new DateTime(1996, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 38,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Mayaguez", "84437", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2470), "Calle 68", "Calle 23", new DateTime(1986, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 39,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "97151", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2479), "Calle 83", "Calle 59", new DateTime(1978, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 40,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Dorado", "43500", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2490), "Calle 40", "Calle 26", new DateTime(1968, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 41,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guayanilla", "13442", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2500), "Calle 6", "Calle 68", new DateTime(1953, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 42,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Catano", "95940", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2509), "Calle 86", "Calle 56", new DateTime(1960, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 43,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "60909", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2519), "Calle 80", "Calle 75", new DateTime(1966, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 44,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "96225", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2528), "Calle 93", "Calle 31", new DateTime(1957, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 45,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Canovanas", "84960", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2561), "Calle 41", "Calle 29", new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 46,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Catano", "12462", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2572), "Calle 16", "Calle 87", new DateTime(1966, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 47,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ceiba", "54989", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2581), "Calle 78", "Calle 77", new DateTime(1964, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 48,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Caguas", "14992", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2591), "Calle 30", "Calle 37", new DateTime(1979, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 49,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "24289", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2601), "Calle 70", "Calle 79", new DateTime(1991, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 50,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "97718", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2611), "Calle 43", "Calle 30", new DateTime(1964, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 51,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guaynabo", "76086", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2620), "Calle 50", "Calle 47", new DateTime(1950, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 52,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Anasco", "10331", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2630), "Calle 83", "Calle 67", new DateTime(1970, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 53,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Aibonito", "66618", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2652), "Calle 27", "Calle 37", new DateTime(1989, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 54,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Trujillo Alto", "64219", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2663), "Calle 14", "Calle 74", new DateTime(1984, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 55,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Barranquitas", "22382", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2672), "Calle 60", "Calle 33", new DateTime(1971, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 56,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Catano", "61279", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2682), "Calle 56", "Calle 38", new DateTime(1989, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 57,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Carolina", "80452", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2692), "Calle 71", "Calle 78", new DateTime(1974, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 58,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guanica", "11510", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2702), "Calle 22", "Calle 79", new DateTime(1961, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 59,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Carolina", "16458", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2711), "Calle 10", "Calle 44", new DateTime(1990, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 60,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Gurabo", "27661", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2747), "Calle 23", "Calle 64", new DateTime(1954, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 61,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arecibo", "32113", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2757), "Calle 69", new DateTime(1983, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 62,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Ciales", "25479", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2767), "Calle 58", "Calle 60", new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 63,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "99396", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2775), "Calle 44", "Calle 45", new DateTime(1959, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 64,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "95809", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2786), "Calle 96", new DateTime(1974, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 65,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "13876", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2796), "Calle 14", "Calle 52", new DateTime(1992, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 66,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cataño", "54880", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2808), "Calle 58", "Calle 63", new DateTime(1958, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1971, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 67,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Vega Baja", "83076", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2845), "Calle 30", "Calle 12", new DateTime(1971, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 68,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "40533", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2855), "Calle 98", "Calle 50", new DateTime(1965, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 69,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Bayamon", "29128", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2864), "Calle 18", "Calle 52", new DateTime(1985, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 70,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cidra", "55499", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2874), "Calle 6", "Calle 82", new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 71,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Trujillo Alto", "22552", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2883), "Calle 67", "Calle 75", new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 72,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Florida", "74892", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2892), "Calle 78", "Calle 78", new DateTime(1953, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 73,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "61629", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2902), "Calle 52", "Calle 89", new DateTime(1951, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 74,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Hatillo", "19032", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2912), "Calle 16", "Calle 93", new DateTime(1959, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 75,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Corozal", "18319", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2945), "Calle 31", "Calle 30", new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 76,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Arroyo", "71362", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2955), "Calle 33", "Calle 50", new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 77,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Guaynabo", "70596", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2964), "Calle 46", "Calle 29", new DateTime(1950, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 78,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Canovanas", "24089", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2974), "Calle 78", "Calle 22", new DateTime(1952, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 79,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Cidra", "77053", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2983), "Calle 71", "Calle 37", new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 80,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Florida", "29312", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(2993), "Calle 40", "Calle 15", new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 81,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Isabela", "81799", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3003), "Calle 71", "Calle 90", new DateTime(1967, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 82,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Corozal", "50720", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3013), "Calle 73", "Calle 44", new DateTime(1954, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 83,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juana Diaz", "12845", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3048), "Calle 53", "Calle 31", new DateTime(1982, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 84,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Las Piedras", "75251", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3058), "Calle 72", "Calle 58", new DateTime(1963, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 85,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cabo Rojo", "55991", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3068), "Calle 10", "Calle 11", new DateTime(1968, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 86,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Toa Baja", "30042", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3079), "Calle 36", new DateTime(1974, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 87,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Barceloneta", "83468", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3087), "Calle 31", "Calle 19", new DateTime(1986, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 88,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Guanica", "35350", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3098), "Calle 12", "Calle 35", new DateTime(1973, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 89,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Vega Baja", "99644", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3108), "Calle 50", "Calle 51", new DateTime(1954, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 90,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cidra", "76649", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3142), "Calle 93", "Calle 15", new DateTime(1985, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 91,
                columns: new[] { "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "35097", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3151), "Calle 50", "Calle 74", new DateTime(1956, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 92,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Juncos", "50594", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3161), "Calle 79", "Calle 95", new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 93,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Comerio", "97993", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3171), "Calle 3", "Calle 37", new DateTime(1995, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 94,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Lajas", "99456", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3181), "Calle 76", "Calle 37", new DateTime(1972, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabajo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 95,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "88634", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3189), "Calle 61", "Calle 65", new DateTime(1960, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 96,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cabo Rojo", "61426", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3199), "Calle 82", "Calle 34", new DateTime(1970, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 97,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Cayey", "89633", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3209), "Calle 43", "Calle 37", new DateTime(1979, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 98,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio" },
                values: new object[] { "Juana Diaz", "42140", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3256), "Calle 68", "Calle 82", new DateTime(1997, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 99,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Carolina", "17613", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3265), "Calle 15", "Calle 45", new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Direcciones",
                keyColumn: "DireccionId",
                keyValue: 100,
                columns: new[] { "Ciudad", "CodigoPostal", "CreateDate", "Direccion", "Direccion2", "FechaFin", "FechaInicio", "TipoDireccion" },
                values: new object[] { "Culebra", "92185", new DateTime(2024, 7, 22, 0, 44, 31, 113, DateTimeKind.Local).AddTicks(3274), "Calle 12", "Calle 24", new DateTime(1983, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 1,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5375m, new DateTime(1965, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28802m, 6929m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 2,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2277m, new DateTime(1955, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 44647m, 8089m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 3,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6653m, new DateTime(1982, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 52305m, 1436m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 4,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3835m, new DateTime(1970, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10672m, 7910m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 5,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7408m, new DateTime(1978, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 53591m, 7727m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 6,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9145m, new DateTime(1992, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 98986m, 1955m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 7,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8661m, new DateTime(1976, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27677m, 6290m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 8,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9700m, new DateTime(1959, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 86727m, 2889m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 9,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7193m, new DateTime(1988, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 81297m, 5253m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 10,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7415m, new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70361m, 7896m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 11,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4863m, new DateTime(1963, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50884m, 6355m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 12,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3757m, new DateTime(1972, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 96344m, 7403m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 13,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5495m, new DateTime(1951, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 80236m, 5839m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 14,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8447m, new DateTime(1976, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 92299m, 8535m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 15,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5350m, new DateTime(1980, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 52439m, 4410m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 16,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8090m, new DateTime(1970, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26817m, 1569m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 17,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3377m, new DateTime(1999, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 92911m, 8821m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 18,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9586m, new DateTime(1971, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 38866m, 5860m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 19,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3242m, new DateTime(1960, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 80513m, 5437m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 20,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9028m, new DateTime(1957, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17605m, 8025m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 21,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9020m, new DateTime(1961, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 89358m, 7677m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 22,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5727m, new DateTime(1964, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 49863m, 3726m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 23,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6434m, new DateTime(1982, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 24939m, 6261m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 24,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2634m, new DateTime(1958, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 91585m, 9456m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 25,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9328m, new DateTime(1956, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1951, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 42451m, 1038m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 26,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2689m, new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 89351m, 8298m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 27,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7352m, new DateTime(1954, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39722m, 8437m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 28,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5225m, new DateTime(1965, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 92278m, 3983m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 29,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9116m, new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 56577m, 1011m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 30,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5755m, new DateTime(1955, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 64070m, 8703m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 31,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8929m, new DateTime(1990, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15354m, 7512m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 32,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8637m, new DateTime(1974, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 77880m, 5163m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 33,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8075m, new DateTime(1957, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 96086m, 7819m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 34,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4231m, new DateTime(1966, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 64359m, 6975m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 35,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4943m, new DateTime(1972, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10592m, 9771m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 36,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7023m, new DateTime(1971, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 54174m, 5779m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 37,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3103m, new DateTime(1994, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 80872m, 5460m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 38,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2419m, new DateTime(1971, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 86087m, 7583m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 39,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9163m, new DateTime(1968, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 64784m, 5443m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 40,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3031m, new DateTime(1962, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40904m, 2660m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 41,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8794m, new DateTime(1962, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19001m, 4181m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 42,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2023m, new DateTime(1977, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 87749m, 8093m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 43,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7809m, new DateTime(1976, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 63230m, 6620m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 44,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3574m, new DateTime(1951, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1958, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 78497m, 8659m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 45,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8588m, new DateTime(1959, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12696m, 2673m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 46,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6452m, new DateTime(1985, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 69707m, 3858m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 47,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2359m, new DateTime(1995, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 67990m, 4190m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 48,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8304m, new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 45757m, 4076m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 49,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5612m, new DateTime(1984, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30012m, 7491m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 50,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6609m, new DateTime(1958, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 72687m, 6382m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 51,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2600m, new DateTime(1952, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42633m, 1692m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 52,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4077m, new DateTime(1987, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21719m, 8218m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 53,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8403m, new DateTime(1993, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 93862m, 8316m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 54,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1864m, new DateTime(1975, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11540m, 5977m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 55,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9559m, new DateTime(1981, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11270m, 4165m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 56,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9108m, new DateTime(1951, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24257m, 2461m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 57,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6450m, new DateTime(1955, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 19714m, 8922m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 58,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3315m, new DateTime(1967, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 81555m, 6108m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 59,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3509m, new DateTime(1957, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 68835m, 1079m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 60,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4870m, new DateTime(1956, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 11285m, 9958m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 61,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5717m, new DateTime(1955, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 48712m, 5959m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 62,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7656m, new DateTime(1989, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 74835m, 1571m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 63,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9991m, new DateTime(1955, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14434m, 9265m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 64,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6857m, new DateTime(1981, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 48536m, 2519m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 65,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4677m, new DateTime(1972, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 80761m, 3053m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 66,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4458m, new DateTime(1981, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 42192m, 9732m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 67,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9726m, new DateTime(1986, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 99777m, 9108m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 68,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6962m, new DateTime(1979, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10556m, 5341m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 69,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6539m, new DateTime(1967, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 41390m, 7434m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 70,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4570m, new DateTime(1950, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 46028m, 3401m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 71,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3851m, new DateTime(1954, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 60105m, 7265m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 72,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3183m, new DateTime(1973, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 47478m, 7969m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 73,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2314m, new DateTime(1958, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 58795m, 5580m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 74,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3300m, new DateTime(1987, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25365m, 2760m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 75,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6990m, new DateTime(1968, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47290m, 2709m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 76,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7278m, new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 71370m, 2079m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 77,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6670m, new DateTime(1959, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 91523m, 2529m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 78,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9706m, new DateTime(1964, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98114m, 8286m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 79,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1536m, new DateTime(1993, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1953, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 44679m, 2078m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 80,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7218m, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19327m, 7540m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 81,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6228m, new DateTime(1972, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27140m, 2113m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 82,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8983m, new DateTime(1955, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 83408m, 4609m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 83,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7950m, new DateTime(1957, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 84777m, 6827m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 84,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9223m, new DateTime(1953, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 79268m, 3455m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 85,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2093m, new DateTime(1989, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21876m, 8755m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 86,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7193m, new DateTime(1975, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80765m, 4073m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 87,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9821m, new DateTime(1968, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26430m, 8799m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 88,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5128m, new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 64279m, 5850m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 89,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 8878m, new DateTime(1980, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 31033m, 4365m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 90,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 1281m, new DateTime(1985, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 64473m, 1650m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 91,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9618m, new DateTime(1978, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1960, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29200m, 5431m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 92,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 4500m, new DateTime(1978, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 98946m, 2837m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 93,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5292m, new DateTime(1967, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10235m, 4425m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 94,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 5811m, new DateTime(1979, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 94279m, 3050m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 95,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 6355m, new DateTime(1963, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11103m, 1533m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 96,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7798m, new DateTime(1982, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 99375m, 9389m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 97,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 7723m, new DateTime(1959, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12690m, 6593m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 98,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 2803m, new DateTime(1994, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 62277m, 7080m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 99,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 9085m, new DateTime(1965, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 59688m, 1248m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos",
                keyColumn: "PersonaIngresoId",
                keyValue: 100,
                columns: new[] { "Aportacion", "FechaFin", "FechaInicio", "IngresoTotal", "Retencion" },
                values: new object[] { 3988m, new DateTime(1982, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 95827m, 8600m });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 1,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4326m, "Salario 1654", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 2,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8764m, "Bonos", "Salario 7667" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 3,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1689m, "Otro", "Salario 7685", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 4,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 7565m, "Comision", "Salario 3133" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 5,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 7807m, "Salario 6502" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 6,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9445m, "Salario 9716", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 7,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9908m, "Salario 6509", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 8,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9188m, "Salario 3341", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 9,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3603m, "Otro", "Salario 9261" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 10,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2079m, "Salario 8694", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 11,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3126m, "Comision", "Salario 8906", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 12,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4915m, "Salario", "Salario 9961", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 13,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6899m, "Bonos", "Salario 8751", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 14,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8236m, "Otro", "Salario 1610" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 15,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2491m, "Otro", "Salario 1814" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 16,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5039m, "Salario 6878", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 17,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9987m, "Bonos", "Salario 2381", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 18,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 3471m, "Salario 4140" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 19,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2532m, "Salario 9332", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 20,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5637m, "Bonos", "Salario 1501", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 21,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 9182m, "Comision", "Salario 9180" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 22,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9173m, "Bonos", "Salario 7791", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 23,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1212m, "Bonos", "Salario 5528" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 24,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5569m, "Bonos", "Salario 3621", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 25,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 7425m, "Bonos", "Salario 6580" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 26,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6100m, "Salario 5306", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 27,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4911m, "Otro", "Salario 5663", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 28,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8499m, "Otro", "Salario 2855", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 29,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7436m, "Bonos", "Salario 4425", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 30,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 8815m, "Salario 6088", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 31,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1824m, "Bonos", "Salario 1537" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 32,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 1106m, "Salario", "Salario 9351" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 33,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9072m, "Otro", "Salario 6151", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 34,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5509m, "Comision", "Salario 4654", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 35,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3729m, "Comision", "Salario 6243", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 36,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 8959m, "Salario 3309" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 37,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1610m, "Salario", "Salario 9688", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 38,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1352m, "Bonos", "Salario 7770", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 39,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8211m, "Bonos", "Salario 2832", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 40,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6162m, "Salario", "Salario 1040", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 41,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7934m, "Salario 2611", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 42,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 9886m, "Salario 8132", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 43,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4226m, "Salario 6571", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 44,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7391m, "Salario", "Salario 1322", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 45,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2975m, "Comision", "Salario 6679", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 46,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8315m, "Salario", "Salario 8268" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 47,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1049m, "Salario 4068", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 48,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2749m, "Bonos", "Salario 3059" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 49,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7905m, "Comision", "Salario 1244", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 50,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 3159m, "Salario 5611" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 51,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3305m, "Bonos", "Salario 2210", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 52,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6731m, "Bonos", "Salario 4587", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 53,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5750m, "Bonos", "Salario 7958", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 54,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 5898m, "Bonos", "Salario 3796" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 55,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4860m, "Salario", "Salario 9053", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 56,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5145m, "Salario 9880", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 57,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 2137m, "Comision", "Salario 7826", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 58,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8290m, "Otro", "Salario 5432", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 59,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9394m, "Otro", "Salario 1465", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 60,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 8879m, "Otro", "Salario 9089", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 61,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4692m, "Salario 6202", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 62,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 2673m, "Salario 4707", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 63,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 4291m, "Salario 2536" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 64,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9725m, "Otro", "Salario 3490", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 65,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2134m, "Otro", "Salario 9482" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 66,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6365m, "Otro", "Salario 3660", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 67,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3265m, "Salario", "Salario 8607", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 68,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1620m, "Otro", "Salario 4541", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 69,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1217m, "Otro", "Salario 2995", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 70,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5231m, "Comision", "Salario 6828", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 71,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1712m, "Otro", "Salario 2190", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 72,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 3535m, "Comision", "Salario 6303" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 73,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5037m, "Bonos", "Salario 6103", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 74,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7658m, "Comision", "Salario 8796", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 75,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 7940m, "Salario 5155", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 76,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 6901m, "Bonos", "Salario 3743", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 77,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 1369m, "Otro", "Salario 4390", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 78,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6561m, "Salario 4840", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 79,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4918m, "Salario 6894", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 80,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5195m, "Salario", "Salario 3752", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 81,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9979m, "Salario", "Salario 1848", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 82,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5239m, "Comision", "Salario 3591", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 83,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4698m, "Salario 5142", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 84,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 6008m, "Salario 9465" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 85,
                columns: new[] { "Cantidad", "Ingresos" },
                values: new object[] { 5789m, "Salario 9603" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 86,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 5095m, "Salario 6254", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 87,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 6236m, "Salario 7842", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 88,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1853m, "Salario 3170", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 89,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 3566m, "Comision", "Salario 1897", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 90,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 2969m, "Comision", "Salario 4087" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 91,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5699m, "Bonos", "Salario 9104", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 92,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 4931m, "Salario 9627", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 93,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8252m, "Comision", "Salario 6766" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 94,
                columns: new[] { "Cantidad", "Ingresos", "TipoIngreso" },
                values: new object[] { 1953m, "Salario 4301", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 95,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 7556m, "Otro", "Salario 3142", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 96,
                columns: new[] { "Cantidad", "Comentario", "Ingresos" },
                values: new object[] { 8937m, "Bonos", "Salario 9060" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 97,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4387m, "Otro", "Salario 8430", "Bonos" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 98,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 9269m, "Bonos", "Salario 8280", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 99,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 5953m, "Otro", "Salario 1636", "Comision" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Ingresos_Detalle",
                keyColumn: "PersonaIngresoDetalleId",
                keyValue: 100,
                columns: new[] { "Cantidad", "Comentario", "Ingresos", "TipoIngreso" },
                values: new object[] { 4120m, "Bonos", "Salario 7746", "Salario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 1,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "245401457", "Jefe", "Novia" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 2,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "986531126", "Propietario", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 3,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "669619587", "Inquilina", "Propietario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 4,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "331653718", "Arrendataria", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 5,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "801837636", "Padre", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 6,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "700968958", "Prima", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 7,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "985675735", "Compañero", "Propietaria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 8,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "472917630", "Amiga", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 9,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "770619048", "Conocida", "Esposa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 10,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "510307511", "Estudiante", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 11,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "724216940", "Hijo", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 12,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "310735220", "Hija", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 13,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "181155351", "Sobrino", "Amigo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 14,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "191365602", "Jefe", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 15,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "197283791", "Prima", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 16,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "987985901", "Director", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 17,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "511200179", "Amiga", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 18,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "184288721", "Gerente", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 19,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "305783748", "Maestro", "Hermano" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 20,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "652308170", "Hermana", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 21,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "394100705", "Conocido", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 22,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "824149251", "Abuelo", "Madre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 23,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "911236838", "Directora", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 24,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "722077381", "Dueña", "Otro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 25,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "267715983", "Amigo", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 26,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "421001847", "Tio", "Enfermera" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 27,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "619406084", "Directora", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 28,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "228050115", "Gerente", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 29,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "838356005", "Propietario", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 30,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "309612736", "Compañero", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 31,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "624987942", "Amigo", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 32,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "273107021", "Hijo", "Compañero" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 33,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "999971336", "Empleado", "Hija" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 34,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "334147321", "Empleada", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 35,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "202960011", "Sobrina", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 36,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "173311757", "Conocido", "Arrendador" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 37,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "506705533", "Cliente", "Paciente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 38,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "594600099", "Inquilino", "Jefa" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 39,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "499907910", "Abuelo", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 40,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "438926353", "Hija", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 41,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "548970821", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 42,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "172043322", "Abuela", "Hermana" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 43,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "654116808", "Hijo", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 44,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "190691259", "Doctor", "Sobrina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 45,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "593766992", "Estudiante", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 46,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "328573584", "Arrendador", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 47,
                columns: new[] { "RMO", "Relacion" },
                values: new object[] { "493893724", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 48,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "202442171", "Jefa", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 49,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "137811662", "Gerente", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 50,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "522374584", "Tio", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 51,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "868880068", "Arrendatario", "Padre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 52,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "995718896", "Abuelo", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 53,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "354008129", "Compañera", "Vecina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 54,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "632335309", "Esposo", "Empleado" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 55,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "859248257", "Amiga", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 56,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "168246998", "Dueña", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 57,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "552455391", "Hijo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 58,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "343897426", "Arrendadora", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 59,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "519503707", "Paciente", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 60,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "843069965", "Proveedor", "Abuelo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 61,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "791831196", "Maestra", "Esposo" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 62,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "325537127", "Hijo", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 63,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "260547145", "Gerente", "Inquilina" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 64,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "906506675", "Compañero", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 65,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "886689228", "Propietaria", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 66,
                columns: new[] { "RMO", "Relacion" },
                values: new object[] { "183030796", "Sobrino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 67,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "720819531", "Empleado", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 68,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "338566088", "Cliente", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 69,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "686321986", "Compañera", "Tio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 70,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "658158251", "Arrendador", "Arrendatario" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 71,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "449337479", "Compañero", "Directora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 72,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "439375973", "Propietaria", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 73,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "348369306", "Vecino", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 74,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "941712293", "Prima", "Estudiante" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 75,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "900075079", "Hijo", "Doctora" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 76,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "589861274", "Novio", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 77,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "186830163", "Inquilino", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 78,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "328547070", "Maestra", "Proveedor" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 79,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "596376486", "Amiga", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 80,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "139115072", "Proveedor", "Arrendataria" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 81,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "700259241", "Tia", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 82,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "694744127", "Arrendataria", "Abuela" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 83,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "106545990", "Otro", "Vecino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 84,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "977779633", "Arrendadora", "Cliente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 85,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "739205555", "Empleada", "Amiga" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 86,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "936100842", "Doctora", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 87,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "218312243", "Tio", "Inquilino" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 88,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "917240659", "Arrendatario", "Gerente" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 89,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "495950972", "Doctor", "Maestro" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 90,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "283820606", "Paciente", "Novio" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 91,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "584135253", "Hermano", "Padre" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 92,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "304517395", "Sobrino", "Prima" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 93,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "605375324", "Doctora", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 94,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "152769372", "Novia", "Director" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 95,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "352878560", "Primo", "Jefe" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 96,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "163271444", "Sobrina", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 97,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "912193955", "Compañero", "Maestra" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 98,
                columns: new[] { "RMO", "TipoLink" },
                values: new object[] { "860246497", "Conocida" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 99,
                columns: new[] { "RMO", "Relacion", "TipoLink" },
                values: new object[] { "391274452", "Esposa", "Empleada" });

            migrationBuilder.UpdateData(
                table: "Conf_Personas_Links",
                keyColumn: "LinkId",
                keyValue: 100,
                columns: new[] { "RMO", "Relacion" },
                values: new object[] { "585026822", "Sobrina" });
        }
    }
}
