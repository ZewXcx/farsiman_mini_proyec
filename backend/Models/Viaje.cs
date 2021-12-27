using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Models
{
    public class Viaje
    {
        [Key]
        public int idViaje { get; set; } 
        public DateTime fecha{ get; set; }
        public int km_inicial { get; set; }
        public int km_final { get; set; }
        public int idTransportista { get; set; }
        public int idReporte_Pago { get; set; }
        public int idEmpleado { get; set; }
        public float tarifa { get; set; }
    }
}
