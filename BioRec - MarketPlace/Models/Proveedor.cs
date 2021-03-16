using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
namespace BioRec___MarketPlace.Models
{
    [Table("Proveedor")]
    public class Proveedor
    {
        [Key]
        public int idProveedor { get; set; }
    }
}
