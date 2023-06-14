using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoExercitoMVC.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigração : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companhia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companhia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Militar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataIngresso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Graduacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanhiaId = table.Column<int>(type: "int", nullable: false),
                    FuncaoExercida = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Militar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Militar_Companhia_CompanhiaId",
                        column: x => x.CompanhiaId,
                        principalTable: "Companhia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Militar_CompanhiaId",
                table: "Militar",
                column: "CompanhiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Militar");

            migrationBuilder.DropTable(
                name: "Companhia");
        }
    }
}
