using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class manyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_Especialidade_EspecialidadeId",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_Paciente_PacienteId",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_Profissional_ProfissionalId",
                table: "tb_consulta");

            migrationBuilder.DropTable(
                name: "EspecialidadeProfissional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissional",
                table: "Profissional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidade",
                table: "Especialidade");

            migrationBuilder.RenameTable(
                name: "Profissional",
                newName: "tb_profissional");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "tb_paciente");

            migrationBuilder.RenameTable(
                name: "Especialidade",
                newName: "tb_especialidade");

            migrationBuilder.RenameColumn(
                name: "ProfissionalId",
                table: "tb_consulta",
                newName: "id_profissional");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "tb_consulta",
                newName: "id_paciente");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "tb_consulta",
                newName: "id_especialidade");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_ProfissionalId",
                table: "tb_consulta",
                newName: "IX_tb_consulta_id_profissional");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_PacienteId",
                table: "tb_consulta",
                newName: "IX_tb_consulta_id_paciente");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_EspecialidadeId",
                table: "tb_consulta",
                newName: "IX_tb_consulta_id_especialidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_profissional",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "tb_profissional",
                newName: "ativo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_profissional",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_paciente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_paciente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "tb_paciente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "tb_paciente",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_paciente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_especialidade",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Ativa",
                table: "tb_especialidade",
                newName: "ativa");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_especialidade",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "tb_consulta",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "tb_profissional",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "tb_paciente",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tb_paciente",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "tb_paciente",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "tb_paciente",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "tb_especialidade",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_profissional",
                table: "tb_profissional",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_paciente",
                table: "tb_paciente",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_especialidade",
                table: "tb_especialidade",
                column: "id");

            migrationBuilder.CreateTable(
                name: "tb_profissional_especialidade",
                columns: table => new
                {
                    id_profissional = table.Column<int>(type: "INTEGER", nullable: false),
                    id_especialidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_profissional_especialidade", x => new { x.id_especialidade, x.id_profissional });
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_especialidade_id_especialidade",
                        column: x => x.id_especialidade,
                        principalTable: "tb_especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_profissional_id_profissional",
                        column: x => x.id_profissional,
                        principalTable: "tb_profissional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_profissional_especialidade_id_profissional",
                table: "tb_profissional_especialidade",
                column: "id_profissional");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta",
                column: "id_especialidade",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_paciente_id_paciente",
                table: "tb_consulta",
                column: "id_paciente",
                principalTable: "tb_paciente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta",
                column: "id_profissional",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_paciente_id_paciente",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta");

            migrationBuilder.DropTable(
                name: "tb_profissional_especialidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_profissional",
                table: "tb_profissional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_paciente",
                table: "tb_paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_especialidade",
                table: "tb_especialidade");

            migrationBuilder.RenameTable(
                name: "tb_profissional",
                newName: "Profissional");

            migrationBuilder.RenameTable(
                name: "tb_paciente",
                newName: "Paciente");

            migrationBuilder.RenameTable(
                name: "tb_especialidade",
                newName: "Especialidade");

            migrationBuilder.RenameColumn(
                name: "id_profissional",
                table: "tb_consulta",
                newName: "ProfissionalId");

            migrationBuilder.RenameColumn(
                name: "id_paciente",
                table: "tb_consulta",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "id_especialidade",
                table: "tb_consulta",
                newName: "EspecialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_id_profissional",
                table: "tb_consulta",
                newName: "IX_tb_consulta_ProfissionalId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_id_paciente",
                table: "tb_consulta",
                newName: "IX_tb_consulta_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_id_especialidade",
                table: "tb_consulta",
                newName: "IX_tb_consulta_EspecialidadeId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Profissional",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ativo",
                table: "Profissional",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Profissional",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Paciente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Paciente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Paciente",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Paciente",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Paciente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Especialidade",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ativa",
                table: "Especialidade",
                newName: "Ativa");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Especialidade",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "tb_consulta",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Profissional",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Paciente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Paciente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Paciente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Especialidade",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissional",
                table: "Profissional",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidade",
                table: "Especialidade",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EspecialidadeProfissional",
                columns: table => new
                {
                    EspecialidadesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfissionaisId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeProfissional", x => new { x.EspecialidadesId, x.ProfissionaisId });
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_Especialidade_EspecialidadesId",
                        column: x => x.EspecialidadesId,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_Profissional_ProfissionaisId",
                        column: x => x.ProfissionaisId,
                        principalTable: "Profissional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeProfissional_ProfissionaisId",
                table: "EspecialidadeProfissional",
                column: "ProfissionaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_Especialidade_EspecialidadeId",
                table: "tb_consulta",
                column: "EspecialidadeId",
                principalTable: "Especialidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_Paciente_PacienteId",
                table: "tb_consulta",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_Profissional_ProfissionalId",
                table: "tb_consulta",
                column: "ProfissionalId",
                principalTable: "Profissional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
