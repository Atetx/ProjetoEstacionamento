using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamentoWeb.Migrations
{
    public partial class Inferno3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_Usuario_UsuarioId",
                table: "Estacionamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_UsuarioCNPJ_UsuarioCNPJId",
                table: "Estacionamento");

            migrationBuilder.DropIndex(
                name: "IX_Estacionamento_UsuarioId",
                table: "Estacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioCNPJ",
                table: "UsuarioCNPJ");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Estacionamento");

            migrationBuilder.RenameTable(
                name: "UsuarioCNPJ",
                newName: "UsuariosCnpj");

            migrationBuilder.RenameColumn(
                name: "UsuarioCNPJId",
                table: "Estacionamento",
                newName: "UsuarioCnpjId");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamento_UsuarioCNPJId",
                table: "Estacionamento",
                newName: "IX_Estacionamento_UsuarioCnpjId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioCnpjId",
                table: "Estacionamento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosCnpj",
                table: "UsuariosCnpj",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_UsuariosCnpj_UsuarioCnpjId",
                table: "Estacionamento",
                column: "UsuarioCnpjId",
                principalTable: "UsuariosCnpj",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_UsuariosCnpj_UsuarioCnpjId",
                table: "Estacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosCnpj",
                table: "UsuariosCnpj");

            migrationBuilder.RenameTable(
                name: "UsuariosCnpj",
                newName: "UsuarioCNPJ");

            migrationBuilder.RenameColumn(
                name: "UsuarioCnpjId",
                table: "Estacionamento",
                newName: "UsuarioCNPJId");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamento_UsuarioCnpjId",
                table: "Estacionamento",
                newName: "IX_Estacionamento_UsuarioCNPJId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioCNPJId",
                table: "Estacionamento",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Estacionamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioCNPJ",
                table: "UsuarioCNPJ",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamento_UsuarioId",
                table: "Estacionamento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_Usuario_UsuarioId",
                table: "Estacionamento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_UsuarioCNPJ_UsuarioCNPJId",
                table: "Estacionamento",
                column: "UsuarioCNPJId",
                principalTable: "UsuarioCNPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
