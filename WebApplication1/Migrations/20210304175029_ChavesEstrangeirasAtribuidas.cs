using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ChavesEstrangeirasAtribuidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Repositorios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Notas",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Anotacao",
                table: "Notas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repositorios_UsuarioId",
                table: "Repositorios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_RepositorioId",
                table: "Notas",
                column: "RepositorioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Repositorios_RepositorioId",
                table: "Notas",
                column: "RepositorioId",
                principalTable: "Repositorios",
                principalColumn: "RepositorioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repositorios_Usuarios_UsuarioId",
                table: "Repositorios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Repositorios_RepositorioId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Repositorios_Usuarios_UsuarioId",
                table: "Repositorios");

            migrationBuilder.DropIndex(
                name: "IX_Repositorios_UsuarioId",
                table: "Repositorios");

            migrationBuilder.DropIndex(
                name: "IX_Notas_RepositorioId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Repositorios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Notas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Anotacao",
                table: "Notas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
