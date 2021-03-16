using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BioRec___MarketPlace.Models;
using BioRec___MarketPlace.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BioRec___MarketPlace.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly DatabaseContext _context;

        public UsuarioController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult InicioDeSesion()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registrar(RegistroUsuarioViewModel usuarioCompuesto)
        {
            if (ModelState.IsValid)
            {
                Usuario user = usuarioCompuesto.Usuario;
                Direccion dir = usuarioCompuesto.Direccion;
                CiudadDepPais ciudad = usuarioCompuesto.Ciudad;
                Departamento departamento = usuarioCompuesto.Departamento;
                Pais pais = usuarioCompuesto.Pais;

                departamento.idPais = pais.idPais;
                ciudad.idDepartamento = departamento.idDepartamento;
                dir.idCiudadDepPais = ciudad.idCiudadDepPais;
                user.idDireccion = dir.idDireccion;
                user.rol = 1;

                _context.Usuario.Add(user);
                await _context.SaveChangesAsync();
                _context.Direccion.Add(dir);
                await _context.SaveChangesAsync();
                _context.CiudadDepPais.Add(ciudad);
                await _context.SaveChangesAsync();
                _context.Departamentos.Add(departamento);
                await _context.SaveChangesAsync();
                _context.Pais.Add(pais);
                await _context.SaveChangesAsync();

            }
            return RedirectToAction("InicioDeSesion", "Usuario");


        }

    }
}
