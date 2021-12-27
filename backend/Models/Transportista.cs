using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Models
{
    public class Transportista
    {   
        [Key]
        public int idTransportista { get; set; }
        public float tarifa_KM { get; set; }
        public int idPersona { get; set; }
    }
}
