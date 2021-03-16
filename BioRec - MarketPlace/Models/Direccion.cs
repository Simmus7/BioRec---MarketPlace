using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BioRec___MarketPlace.Models
{
    [Table("Direccion")]
    public class Direccion
    {
        [Key]
        public int idDireccion { get; set; }
        [Required]
        public String tipoVia { get; set; }

        [Required]
        public String NumeroVia { get; set; }

        [Required]
        public String NumeroViaSecundario{ get; set; }

        [Required]
        public int NumeroCasa { get; set; }

        [Required]
        public String TipoInmueble { get; set; }

        public int NumeroInmueble { get; set; }

        [InverseProperty("Direccion")]
        public virtual Usuario Usuario { get; set; }


        [ForeignKey("CiudadDepPais")]
        public int idCiudadDepPais { get; set; }
        public virtual CiudadDepPais CiudadDepPais{ get; set; }
    }
}
