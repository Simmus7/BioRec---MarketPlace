using BioRec___MarketPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioRec___MarketPlace.ViewModel
{
    public class RegistroUsuarioViewModel
    {
        public Usuario Usuario { get; set; }
        public Direccion Direccion {get; set; }
        public CiudadDepPais Ciudad { get; set; }
        public Departamento Departamento { get; set; }
        public Pais Pais { get; set; }
      

    }
}
