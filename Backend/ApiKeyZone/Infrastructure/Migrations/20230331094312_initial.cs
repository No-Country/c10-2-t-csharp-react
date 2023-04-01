using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequisitosMin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SO = table.Column<string>(nullable: true),
                    Procesador = table.Column<string>(nullable: true),
                    Memoria = table.Column<string>(nullable: true),
                    Graficos = table.Column<string>(nullable: true),
                    Almacenamiento = table.Column<string>(nullable: true),
                    Directx = table.Column<string>(nullable: true),
                    Red = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitosMin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequisitosRec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SO = table.Column<string>(nullable: true),
                    Procesador = table.Column<string>(nullable: true),
                    Memoria = table.Column<string>(nullable: true),
                    Graficos = table.Column<string>(nullable: true),
                    Almacenamiento = table.Column<string>(nullable: true),
                    Directx = table.Column<string>(nullable: true),
                    Red = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitosRec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 180, nullable: false),
                    Imagen = table.Column<string>(nullable: false),
                    FechaLanzamiento = table.Column<DateTime>(nullable: false),
                    Desarrollador = table.Column<string>(nullable: true),
                    RequisitosMinId = table.Column<int>(nullable: false),
                    RequisitosRecId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Juegos_RequisitosMin_RequisitosMinId",
                        column: x => x.RequisitosMinId,
                        principalTable: "RequisitosMin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Juegos_RequisitosRec_RequisitosRecId",
                        column: x => x.RequisitosRecId,
                        principalTable: "RequisitosRec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JuegosPlataformas",
                columns: table => new
                {
                    IdJuego = table.Column<int>(nullable: false),
                    IdPlataforma = table.Column<int>(nullable: false),
                    Stock = table.Column<string>(nullable: true),
                    Precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuegosPlataformas", x => new { x.IdJuego, x.IdPlataforma });
                    table.ForeignKey(
                        name: "FK_JuegosPlataformas_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JuegosPlataformas_Plataformas_IdPlataforma",
                        column: x => x.IdPlataforma,
                        principalTable: "Plataformas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_RequisitosMinId",
                table: "Juegos",
                column: "RequisitosMinId");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_RequisitosRecId",
                table: "Juegos",
                column: "RequisitosRecId");

            migrationBuilder.CreateIndex(
                name: "IX_JuegosPlataformas_IdPlataforma",
                table: "JuegosPlataformas",
                column: "IdPlataforma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JuegosPlataformas");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Plataformas");

            migrationBuilder.DropTable(
                name: "RequisitosMin");

            migrationBuilder.DropTable(
                name: "RequisitosRec");
        }
    }
}
