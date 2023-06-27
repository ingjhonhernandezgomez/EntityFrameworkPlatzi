using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e8c"), null, "Actividades personales", 50 },
                    { new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e9c"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "tarea",
                columns: new[] { "TareaID", "CategoriaID", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e6c"), new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e8c"), null, new DateTime(2023, 6, 27, 16, 29, 57, 356, DateTimeKind.Local).AddTicks(4997), 0, "Terminar serie en netflix" },
                    { new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e7c"), new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e9c"), null, new DateTime(2023, 6, 27, 16, 29, 57, 356, DateTimeKind.Local).AddTicks(4986), 1, "Pago de servicios publicos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaID",
                keyValue: new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e6c"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "TareaID",
                keyValue: new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e7c"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e8c"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("1ebc42cb-da81-46c1-93cb-8291f5442e9c"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
