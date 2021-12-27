using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class ViajeContext : DbContext
    {
        public ViajeContext (DbContextOptions<ViajeContext> options)
            : base(options)
        {
        }

        public DbSet<Viajes.Models.Viaje> Viaje { get; set; }
    }
}
