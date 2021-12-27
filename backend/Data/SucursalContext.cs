using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class SucursalContext : DbContext
    {
        public SucursalContext (DbContextOptions<SucursalContext> options)
            : base(options)
        {
        }

        public DbSet<Sucursal> Sucursal { get; set; }
    }
}
