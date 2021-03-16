using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioRec___MarketPlace.Migrations
{
    public partial class BDCompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: false),
                    cantidadTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    idProveedor = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreProveedor = table.Column<string>(nullable: false),
                    direccionBodega = table.Column<string>(nullable: false),
                    idDireccion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.idProveedor);
                    table.ForeignKey(
                        name: "FK_Proveedor_Direccion_idDireccion",
                        column: x => x.idDireccion,
                        principalTable: "Direccion",
                        principalColumn: "idDireccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto_Venta",
                columns: table => new
                {
                    idProducto_Venta = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    precioTotalProducto = table.Column<int>(nullable: false),
                    cantidadProducto = table.Column<int>(nullable: false),
                    precioUnidad = table.Column<int>(nullable: false),
                    idVenta = table.Column<int>(nullable: false),
                    idProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto_Venta", x => x.idProducto_Venta);
                    table.ForeignKey(
                        name: "FK_Producto_Venta_Producto_idProducto",
                        column: x => x.idProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Venta_Venta_idVenta",
                        column: x => x.idVenta,
                        principalTable: "Venta",
                        principalColumn: "idVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor_Producto",
                columns: table => new
                {
                    idProveedor_Producto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    cantidadTotal = table.Column<int>(nullable: false),
                    costoPorUnidad = table.Column<int>(nullable: false),
                    idProducto = table.Column<int>(nullable: false),
                    idProveedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor_Producto", x => x.idProveedor_Producto);
                    table.ForeignKey(
                        name: "FK_Proveedor_Producto_Producto_idProducto",
                        column: x => x.idProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Producto_Proveedor_idProveedor",
                        column: x => x.idProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    idTelefono = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idProveedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.idTelefono);
                    table.ForeignKey(
                        name: "FK_Telefono_Proveedor_idProveedor",
                        column: x => x.idProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Venta_idProducto",
                table: "Producto_Venta",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Venta_idVenta",
                table: "Producto_Venta",
                column: "idVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_idDireccion",
                table: "Proveedor",
                column: "idDireccion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_Producto_idProducto",
                table: "Proveedor_Producto",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_Producto_idProveedor",
                table: "Proveedor_Producto",
                column: "idProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_idProveedor",
                table: "Telefono",
                column: "idProveedor",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto_Venta");

            migrationBuilder.DropTable(
                name: "Proveedor_Producto");

            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}
