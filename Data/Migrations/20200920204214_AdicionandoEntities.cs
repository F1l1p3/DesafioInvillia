using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioDotNet.Data.Migrations
{
    public partial class AdicionandoEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeJogo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JogoEmprestado",
                columns: table => new
                {
                    IdJogoEmprestado = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdJogoId = table.Column<int>(nullable: true),
                    IdAmigoId = table.Column<int>(nullable: true),
                    DataEmprestimo = table.Column<DateTime>(nullable: false),
                    Devolvido = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoEmprestado", x => x.IdJogoEmprestado);
                    table.ForeignKey(
                        name: "FK_JogoEmprestado_Amigo_IdAmigoId",
                        column: x => x.IdAmigoId,
                        principalTable: "Amigo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JogoEmprestado_Jogo_IdJogoId",
                        column: x => x.IdJogoId,
                        principalTable: "Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JogoEmprestado_IdAmigoId",
                table: "JogoEmprestado",
                column: "IdAmigoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoEmprestado_IdJogoId",
                table: "JogoEmprestado",
                column: "IdJogoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JogoEmprestado");

            migrationBuilder.DropTable(
                name: "Amigo");

            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
