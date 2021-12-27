using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Viajes.Controllers
{
    public class Jefe_Tienda
    {
        [Key]
        public int idJefe_Tienda { get; set; }
        public int idEmpleado { get; set; }
    }
}
