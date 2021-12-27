using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Viajes.Models
{
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }
        public string code { get; set; }
        public int idPersona { get; set; }
        public int? idSucursal { get; set; }
    }
}
