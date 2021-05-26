using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BioRec___MarketPlace.Models;
using Microsoft.EntityFrameworkCore;

namespace BioRec___MarketPlace.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult LandingPage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> ListaProducto(int sw)
        {
            ViewBag.sw = sw;
            var listaPublicada = _context.ProductoPublicado.Include(pp=>pp.Producto).ToList();
            return View(listaPublicada);
        }
        public async Task<IActionResult> VentaProducto(int idProductoPublicado)
        {
            var productoCompra = _context.ProductoPublicado.Include(pp => pp.Producto).FirstOrDefault(pp => pp.id == idProductoPublicado);

            return View(productoCompra);
        }
        [HttpPost]
        public async Task<IActionResult> VentaProducto(int idProductoPublicado,int cantidad)
        {
            var productoCompra = _context.ProductoPublicado.Include(pp => pp.Producto).FirstOrDefault(pp => pp.id == idProductoPublicado);
            try
            {
               
                if (cantidad != 0)
                {
                    productoCompra.Producto.cantidadTotal -= cantidad;
                    if (productoCompra.Producto.cantidadTotal < 0)
                    {
                        ViewBag.sw = 3;
                        productoCompra.Producto.cantidadTotal += cantidad;
                        return View(productoCompra);
                    }
                    _context.Update(productoCompra.Producto);
                    var venta = new Venta {
                        idUsuario = 1,//mientras tanto por defecto va al usuario 1
                        fechaYHoraVenta=DateTime.Now
                    };
                    _context.Add(venta);
                    _context.SaveChanges();

                    var productoVenta = new Producto_Venta {
                        idProducto=productoCompra.Producto.idProducto,
                        idVenta=venta.idVenta,
                        precioUnidad=Convert.ToInt32(productoCompra.precio),
                        cantidadProducto= cantidad,
                        precioTotalProducto= Convert.ToInt32(productoCompra.precio)*cantidad
                    };
                    _context.Add(productoVenta);
                    _context.SaveChanges();

                    return RedirectToAction("ListaProducto");
                }
            }
            catch (Exception e)
            {
                ViewBag.sw = 4;
            }

            return View(productoCompra);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
