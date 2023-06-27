using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "tarea",
                columns: table => new
                {
                    TareaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrioridadTarea = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarea", x => x.TareaID);
                    table.ForeignKey(
                        name: "FK_tarea_categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tarea_CategoriaID",
                table: "tarea",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tarea");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
