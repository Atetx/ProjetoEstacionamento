using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class Inferno2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capital_social",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cnpj",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Fantasia",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioCNPJId",
                table: "Estacionamento",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsuarioCNPJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital_social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCNPJ", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamento_UsuarioCNPJId",
                table: "Estacionamento",
                column: "UsuarioCNPJId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_UsuarioCNPJ_UsuarioCNPJId",
                table: "Estacionamento",
                column: "UsuarioCNPJId",
                principalTable: "UsuarioCNPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_UsuarioCNPJ_UsuarioCNPJId",
                table: "Estacionamento");

            migrationBuilder.DropTable(
                name: "UsuarioCNPJ");

            migrationBuilder.DropIndex(
                name: "IX_Estacionamento_UsuarioCNPJId",
                table: "Estacionamento");

            migrationBuilder.DropColumn(
                name: "UsuarioCNPJId",
                table: "Estacionamento");

            migrationBuilder.AddColumn<string>(
                name: "Capital_social",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cnpj",
                table: "Usuario",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fantasia",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
