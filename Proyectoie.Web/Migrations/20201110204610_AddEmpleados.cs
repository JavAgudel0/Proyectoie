using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectoie.Web.Migrations
{
    public partial class AddEmpleados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpleadosEntidadId",
                table: "Sucursales",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cargo = table.Column<string>(nullable: false),
                    Departamento = table.Column<string>(nullable: false),
                    ExtensionTelefono = table.Column<int>(nullable: false),
                    LogoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_EmpleadosEntidadId",
                table: "Sucursales",
                column: "EmpleadosEntidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursales_Empleados_EmpleadosEntidadId",
                table: "Sucursales",
                column: "EmpleadosEntidadId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sucursales_Empleados_EmpleadosEntidadId",
                table: "Sucursales");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Sucursales_EmpleadosEntidadId",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "EmpleadosEntidadId",
                table: "Sucursales");
        }
    }
}
