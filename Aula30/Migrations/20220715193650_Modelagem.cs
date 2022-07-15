using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula30.Migrations
{
    public partial class Modelagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Instituicoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instituicoes_AlunoId",
                table: "Instituicoes",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicoes_Alunos_AlunoId",
                table: "Instituicoes",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicoes_Alunos_AlunoId",
                table: "Instituicoes");

            migrationBuilder.DropIndex(
                name: "IX_Instituicoes_AlunoId",
                table: "Instituicoes");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Instituicoes");
        }
    }
}
