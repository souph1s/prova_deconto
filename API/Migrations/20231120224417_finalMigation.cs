using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class finalMigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 19, 44, 16, 697, DateTimeKind.Local).AddTicks(9390));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 19, 15, 15, 532, DateTimeKind.Local).AddTicks(1430));
        }
    }
}
