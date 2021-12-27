using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Viajes.Models
{
    public class Reporte_Pago
    {
        [Key]
        public int idReporte_Pago { get; set; }
        public float total_pagar { get; set; }
        public DateTime fecha_pago { get; set; }
        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_final { get; set; }
    }
}
