using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class Reporte_PagoContext : DbContext
    {
        public Reporte_PagoContext (DbContextOptions<Reporte_PagoContext> options)
            : base(options)
        {
        }

        public DbSet<Viajes.Models.Reporte_Pago> Reporte_Pago { get; set; }
    }
}
