using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrosAPI.Migrations
{
    public partial class AjusteCarroIdid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Carros",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carros",
                newName: "CarroId");
        }
    }
}
