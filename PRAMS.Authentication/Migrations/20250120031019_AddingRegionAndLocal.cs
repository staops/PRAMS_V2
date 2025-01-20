using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRAMS.Authentication.Migrations
{
    /// <inheritdoc />
    public partial class AddingRegionAndLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23119a6b-ce86-43ea-b292-fc6aba327306");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c614cc4-18bf-4f7f-afc4-d8c9a895bcee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b3a99f2-d240-4dd0-bf06-59d21ae37469");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f2aeece-a234-42cb-a8e6-cf5ae105f7d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c424a5-f0e8-4d8e-812b-2933d9cdbff1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cf26328-f1e0-48ef-9618-a969fc762136");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89bc12fd-c1b0-44dc-9d7b-aa1c08ed938b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9072c61f-c994-4602-a975-7c4799a32c24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5ec2f90-f06b-4388-a597-119ee5173360");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a96d4963-584d-4ab4-8cf0-bea6c3bb5de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae38c61c-eb79-4f0d-9dc7-f7f0756867f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c5ab97-e957-44b1-a060-c791c2a6c600");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d345e149-a42a-4535-b62f-75554c00326b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8f77203-1535-4c43-a170-e6add93f53d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f37bfa85-c44c-4bfc-a6c4-37b4b2621031");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feb8594f-e247-4840-95fb-d061a8b0eec4");

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07ef7db1-8abd-4c7b-8653-62c684644d49", null, "Director Asociado", "DIRECTOR ASOCIADO" },
                    { "18470a63-1b63-40e6-b12b-c71ee53117ee", null, "Trabajador Social", "TRABAJADOR SOCIAL" },
                    { "1f1d862b-e5b6-4879-8bf2-65a2b432f93c", null, "Tecnico de Servicios a la Familia", "TECNICO DE SERVICIOS A LA FAMILIA" },
                    { "22fbbfc1-a247-4243-bfc0-b2cf9f857a8a", null, "Supervisor Regional", "SUPERVISOR REGIONAL" },
                    { "37d7fb1d-3900-45e4-8620-ffa76ca2f25b", null, "Asistente de Servicio", "ASISTENTE DE SERVICIO" },
                    { "4e444391-f152-46ba-ad12-afb179024c10", null, "Oficial Administrativo", "OFICIAL ADMINISTRATIVO" },
                    { "59330252-3523-4240-ad4b-cf4e8ea94e91", null, "Administrador Auxiliar", "ADMINISTRADOR AUXILIAR" },
                    { "666befca-44af-4ef4-94fa-9bde851a73fc", null, "Supervisor de oficina local", "SUPERVISOR DE OFICINA LOCAL" },
                    { "798d23fd-c025-4d2c-ad11-d962aea62181", null, "Especialista Trabajador Social", "ESPECIALISTA TRABAJADOR SOCIAL" },
                    { "86918a67-0f87-4f67-b27d-1e242e92f041", null, "Supervisor UIE", "SUPERVISOR UIE" },
                    { "93730b3e-9023-4891-943e-6787cb1b7bce", null, "Investigadores UIE", "INVESTIGADORES UIE" },
                    { "ccea7ca5-173b-48b9-b57d-e0b43b184569", null, "Director de Programa", "DIRECTOR DE PROGRAMA" },
                    { "d333d13c-661a-414d-906e-dd2fbe7918fd", null, "Director Regional", "DIRECTOR REGIONAL" },
                    { "d9ace2b5-71a4-4a36-96fc-aa3a9cc52908", null, "SU", "SU" },
                    { "e97c238d-a721-4cb8-bfcc-dd5d80561c03", null, "Sub-Administrador", "SUB-ADMINISTRADOR" },
                    { "f7b90627-10d6-4e1e-a53e-22107b6ebc8e", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03334448-73b4-438f-8fdf-784dbab58150",
                columns: new[] { "Local", "Region" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118fb076-affa-4fda-8617-e6c39b7e53c2",
                columns: new[] { "Local", "Region" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e6dd63-c624-4c4a-8bf4-c910148367ad",
                columns: new[] { "Local", "Region" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4cbb14e-bb75-4143-b530-ec5d8bad55f7",
                columns: new[] { "Local", "Region" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07ef7db1-8abd-4c7b-8653-62c684644d49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18470a63-1b63-40e6-b12b-c71ee53117ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f1d862b-e5b6-4879-8bf2-65a2b432f93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22fbbfc1-a247-4243-bfc0-b2cf9f857a8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37d7fb1d-3900-45e4-8620-ffa76ca2f25b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e444391-f152-46ba-ad12-afb179024c10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59330252-3523-4240-ad4b-cf4e8ea94e91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "666befca-44af-4ef4-94fa-9bde851a73fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "798d23fd-c025-4d2c-ad11-d962aea62181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86918a67-0f87-4f67-b27d-1e242e92f041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93730b3e-9023-4891-943e-6787cb1b7bce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccea7ca5-173b-48b9-b57d-e0b43b184569");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d333d13c-661a-414d-906e-dd2fbe7918fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ace2b5-71a4-4a36-96fc-aa3a9cc52908");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97c238d-a721-4cb8-bfcc-dd5d80561c03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7b90627-10d6-4e1e-a53e-22107b6ebc8e");

            migrationBuilder.DropColumn(
                name: "Local",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23119a6b-ce86-43ea-b292-fc6aba327306", null, "Asistente de Servicio", "ASISTENTE DE SERVICIO" },
                    { "2c614cc4-18bf-4f7f-afc4-d8c9a895bcee", null, "Investigadores UIE", "INVESTIGADORES UIE" },
                    { "3b3a99f2-d240-4dd0-bf06-59d21ae37469", null, "Supervisor de oficina local", "SUPERVISOR DE OFICINA LOCAL" },
                    { "6f2aeece-a234-42cb-a8e6-cf5ae105f7d6", null, "Director de Programa", "DIRECTOR DE PROGRAMA" },
                    { "71c424a5-f0e8-4d8e-812b-2933d9cdbff1", null, "Director Regional", "DIRECTOR REGIONAL" },
                    { "7cf26328-f1e0-48ef-9618-a969fc762136", null, "Administrador", "ADMINISTRADOR" },
                    { "89bc12fd-c1b0-44dc-9d7b-aa1c08ed938b", null, "Trabajador Social", "TRABAJADOR SOCIAL" },
                    { "9072c61f-c994-4602-a975-7c4799a32c24", null, "Tecnico de Servicios a la Familia", "TECNICO DE SERVICIOS A LA FAMILIA" },
                    { "a5ec2f90-f06b-4388-a597-119ee5173360", null, "Sub-Administrador", "SUB-ADMINISTRADOR" },
                    { "a96d4963-584d-4ab4-8cf0-bea6c3bb5de7", null, "Supervisor UIE", "SUPERVISOR UIE" },
                    { "ae38c61c-eb79-4f0d-9dc7-f7f0756867f2", null, "Administrador Auxiliar", "ADMINISTRADOR AUXILIAR" },
                    { "d0c5ab97-e957-44b1-a060-c791c2a6c600", null, "SU", "SU" },
                    { "d345e149-a42a-4535-b62f-75554c00326b", null, "Director Asociado", "DIRECTOR ASOCIADO" },
                    { "d8f77203-1535-4c43-a170-e6add93f53d7", null, "Supervisor Regional", "SUPERVISOR REGIONAL" },
                    { "f37bfa85-c44c-4bfc-a6c4-37b4b2621031", null, "Especialista Trabajador Social", "ESPECIALISTA TRABAJADOR SOCIAL" },
                    { "feb8594f-e247-4840-95fb-d061a8b0eec4", null, "Oficial Administrativo", "OFICIAL ADMINISTRATIVO" }
                });
        }
    }
}
