using Microsoft.EntityFrameworkCore.Migrations;

namespace BioRec___MarketPlace.Migrations
{
    public partial class M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "numeroCasa",
                table: "Proveedor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "numeroInmueble",
                table: "Proveedor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numeroInmueble",
                table: "Proveedor");

            migrationBuilder.AlterColumn<int>(
                name: "numeroCasa",
                table: "Proveedor",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
