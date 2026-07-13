using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalonDeBelleza.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "EmpleadoId", "NombreUsuario", "Password", "Rol" },
                values: new object[] { 1, null, "admin", "123", "Administrador" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1);
        }
    }
}
