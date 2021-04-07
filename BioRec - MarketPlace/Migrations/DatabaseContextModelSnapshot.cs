﻿// <auto-generated />
using System;
using BioRec___MarketPlace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BioRec___MarketPlace.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BioRec___MarketPlace.Models.CiudadDepPais", b =>
                {
                    b.Property<int>("idCiudadDepPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("idDepartamento")
                        .HasColumnType("int");

                    b.HasKey("idCiudadDepPais");

                    b.HasIndex("idDepartamento")
                        .IsUnique();

                    b.ToTable("CiudadDepPais");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Departamento", b =>
                {
                    b.Property<int>("idDepartamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("departamento")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("idPais")
                        .HasColumnType("int");

                    b.HasKey("idDepartamento");

                    b.HasIndex("idPais")
                        .IsUnique();

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Pais", b =>
                {
                    b.Property<int>("idPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idPais");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidadTotal")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idProducto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Producto_Venta", b =>
                {
                    b.Property<int>("idProducto_Venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidadProducto")
                        .HasColumnType("int");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<int>("idVenta")
                        .HasColumnType("int");

                    b.Property<int>("precioTotalProducto")
                        .HasColumnType("int");

                    b.Property<int>("precioUnidad")
                        .HasColumnType("int");

                    b.HasKey("idProducto_Venta");

                    b.HasIndex("idProducto");

                    b.HasIndex("idVenta");

                    b.ToTable("Producto_Venta");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Proveedor", b =>
                {
                    b.Property<int>("idProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("direccionBodega")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("idCiudadDepPais")
                        .HasColumnType("int");

                    b.Property<string>("nombreProveedor")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroCasa")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroInmueble")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroVia")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroViaSecundario")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tipoInmueble")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tipoVia")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idProveedor");

                    b.HasIndex("idCiudadDepPais")
                        .IsUnique();

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Proveedor_Producto", b =>
                {
                    b.Property<int>("idProveedor_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidadTotal")
                        .HasColumnType("int");

                    b.Property<int>("costoPorUnidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<int>("idProveedor")
                        .HasColumnType("int");

                    b.HasKey("idProveedor_Producto");

                    b.HasIndex("idProducto");

                    b.HasIndex("idProveedor");

                    b.ToTable("Proveedor_Producto");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Telefono", b =>
                {
                    b.Property<int>("idTelefono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idProveedor")
                        .HasColumnType("int");

                    b.HasKey("idTelefono");

                    b.HasIndex("idProveedor")
                        .IsUnique();

                    b.ToTable("Telefono");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechanacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("idCiudadDepPais")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroCasa")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroInmueble")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroVia")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("numeroViaSecundario")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("rol")
                        .HasColumnType("int");

                    b.Property<string>("tipoInmueble")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tipoVia")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idUsuario");

                    b.HasIndex("idCiudadDepPais")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Venta", b =>
                {
                    b.Property<int>("idVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaYHoraVenta")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("idVenta");

                    b.HasIndex("idUsuario");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.CiudadDepPais", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Departamento", "Departamento")
                        .WithOne("CiudadDepPais")
                        .HasForeignKey("BioRec___MarketPlace.Models.CiudadDepPais", "idDepartamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Departamento", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Pais", "Pais")
                        .WithOne("Departamento")
                        .HasForeignKey("BioRec___MarketPlace.Models.Departamento", "idPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Producto_Venta", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Producto", "Producto")
                        .WithMany("Producto_Ventas")
                        .HasForeignKey("idProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioRec___MarketPlace.Models.Venta", "Venta")
                        .WithMany("Producto_Ventas")
                        .HasForeignKey("idVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Proveedor", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.CiudadDepPais", "CiudadDepPais")
                        .WithOne("Proveedor")
                        .HasForeignKey("BioRec___MarketPlace.Models.Proveedor", "idCiudadDepPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Proveedor_Producto", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Producto", "Producto")
                        .WithMany("Proveedor_Producto")
                        .HasForeignKey("idProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioRec___MarketPlace.Models.Proveedor", "Proveedor")
                        .WithMany("Proveedor_Producto")
                        .HasForeignKey("idProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Telefono", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Proveedor", "Proveedor")
                        .WithOne("Telefono")
                        .HasForeignKey("BioRec___MarketPlace.Models.Telefono", "idProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Usuario", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.CiudadDepPais", "CiudadDepPais")
                        .WithOne("Usuario")
                        .HasForeignKey("BioRec___MarketPlace.Models.Usuario", "idCiudadDepPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BioRec___MarketPlace.Models.Venta", b =>
                {
                    b.HasOne("BioRec___MarketPlace.Models.Usuario", "Usuario")
                        .WithMany("Ventas")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
