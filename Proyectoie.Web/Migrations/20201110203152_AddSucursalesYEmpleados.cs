using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectoie.Web.Migrations
{
    public partial class AddSucursalesYEmpleados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Sucursales",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Sucursales",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Sucursales");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Sucursales",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
