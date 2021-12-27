using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Viajes.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        
        public string user { get; set; }

        public string pass { get; set; }
        
        public int idEmpleado { get; set; }
 
    }
}
