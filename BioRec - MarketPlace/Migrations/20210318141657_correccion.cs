using Microsoft.EntityFrameworkCore.Migrations;

namespace BioRec___MarketPlace.Migrations
{
    public partial class correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "numeroCasa",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "numeroInmueble",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numeroInmueble",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "numeroCasa",
                table: "Usuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
