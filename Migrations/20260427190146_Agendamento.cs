using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDocMais.Migrations
{
    /// <inheritdoc />
    public partial class Agendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "especialidadeMedico",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "nomeMedico",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "nomePaciente",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "telefonePaciente",
                table: "Agendamentos");

            migrationBuilder.AddColumn<string>(
                name: "medicocrm",
                table: "Agendamentos",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "pacientecpf",
                table: "Agendamentos",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_medicocrm",
                table: "Agendamentos",
                column: "medicocrm");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_pacientecpf",
                table: "Agendamentos",
                column: "pacientecpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Medicos_medicocrm",
                table: "Agendamentos",
                column: "medicocrm",
                principalTable: "Medicos",
                principalColumn: "crm");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Pacientes_pacientecpf",
                table: "Agendamentos",
                column: "pacientecpf",
                principalTable: "Pacientes",
                principalColumn: "cpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Medicos_medicocrm",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Pacientes_pacientecpf",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_medicocrm",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_pacientecpf",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "medicocrm",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "pacientecpf",
                table: "Agendamentos");

            migrationBuilder.AddColumn<string>(
                name: "especialidadeMedico",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nomeMedico",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nomePaciente",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "telefonePaciente",
                table: "Agendamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
