using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class chengeNameCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomePaciente",
                table: "tb_agendamento",
                newName: "nomePaciente");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "tb_agendamento",
                newName: "horario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_agendamento",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nomePaciente",
                table: "tb_agendamento",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nomePaciente",
                table: "tb_agendamento",
                newName: "NomePaciente");

            migrationBuilder.RenameColumn(
                name: "horario",
                table: "tb_agendamento",
                newName: "Horario");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tb_agendamento",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "NomePaciente",
                table: "tb_agendamento",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
