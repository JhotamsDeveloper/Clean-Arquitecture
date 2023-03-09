using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Arquitecture.Infraestruture.Migrations
{
    public partial class mv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98136c78-aca2-4e6c-81ae-5dca4bbfaa79"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Create", "DocumentNumber", "DocumentType", "LastName", "Names", "SecondLastName", "Update" },
                values: new object[] { new Guid("e6bc9b19-b5bc-4c46-920d-fa62b19fdd5d"), new DateTime(1992, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1022095102", 1, "Muñoz", "Jhonatan Alejandro", "Serna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6bc9b19-b5bc-4c46-920d-fa62b19fdd5d"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Create", "DocumentNumber", "DocumentType", "LastName", "Names", "SecondLastName", "Update" },
                values: new object[] { new Guid("98136c78-aca2-4e6c-81ae-5dca4bbfaa79"), new DateTime(1992, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1022095102", 1, "Muñoz", "Jhonatan Alejandro", "Serna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
