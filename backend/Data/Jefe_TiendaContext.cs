using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Controllers;

namespace Viajes.Data
{
    public class Jefe_TiendaContext : DbContext
    {
        public Jefe_TiendaContext (DbContextOptions<Jefe_TiendaContext> options)
            : base(options)
        {
        }

        public DbSet<Jefe_Tienda> Jefe_Tienda { get; set; }
    }
}
