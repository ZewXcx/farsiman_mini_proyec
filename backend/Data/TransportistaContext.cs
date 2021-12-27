using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class TransportistaContext : DbContext
    {
        public TransportistaContext (DbContextOptions<TransportistaContext> options)
            : base(options)
        {
        }

        public DbSet<Viajes.Models.Transportista> Transportista { get; set; }
    }
}
