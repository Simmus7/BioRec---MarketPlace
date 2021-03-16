using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioRec___MarketPlace.Migrations
{
    public partial class basedatos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    idPais = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.idPais);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departamento = table.Column<string>(nullable: false),
                    idPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.idDepartamento);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_idPais",
                        column: x => x.idPais,
                        principalTable: "Pais",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiudadDepPais",
                columns: table => new
                {
                    idCiudadDepPais = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ciudad = table.Column<string>(nullable: false),
                    idDepartamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadDepPais", x => x.idCiudadDepPais);
                    table.ForeignKey(
                        name: "FK_CiudadDepPais_Departamento_idDepartamento",
                        column: x => x.idDepartamento,
                        principalTable: "Departamento",
                        principalColumn: "idDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    idDireccion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoVia = table.Column<string>(nullable: false),
                    NumeroVia = table.Column<string>(nullable: false),
                    NumeroViaSecundario = table.Column<string>(nullable: false),
                    NumeroCasa = table.Column<int>(nullable: false),
                    TipoInmueble = table.Column<string>(nullable: false),
                    NumeroInmueble = table.Column<int>(nullable: false),
                    idCiudadDepPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.idDireccion);
                    table.ForeignKey(
                        name: "FK_Direccion_CiudadDepPais_idCiudadDepPais",
                        column: x => x.idCiudadDepPais,
                        principalTable: "CiudadDepPais",
                        principalColumn: "idCiudadDepPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    fechanacimiento = table.Column<DateTime>(nullable: false),
                    edad = table.Column<int>(nullable: false),
                    correo = table.Column<string>(nullable: false),
                    contraseña = table.Column<string>(nullable: false),
                    rol = table.Column<int>(nullable: false),
                    idDireccion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Direccion_idDireccion",
                        column: x => x.idDireccion,
                        principalTable: "Direccion",
                        principalColumn: "idDireccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    idVenta = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fechaYHoraVenta = table.Column<DateTime>(nullable: false),
                    idUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_Venta_Usuario_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CiudadDepPais_idDepartamento",
                table: "CiudadDepPais",
                column: "idDepartamento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_idPais",
                table: "Departamento",
                column: "idPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_idCiudadDepPais",
                table: "Direccion",
                column: "idCiudadDepPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idDireccion",
                table: "Usuario",
                column: "idDireccion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_idUsuario",
                table: "Venta",
                column: "idUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "CiudadDepPais");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
