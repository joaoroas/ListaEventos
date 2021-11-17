using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaEventos.Data.Migrations
{
    public partial class Status2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Privado",
                table: "Eventos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Privado",
                table: "Eventos");
        }
    }
}
