using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Viajes.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
    }
}
