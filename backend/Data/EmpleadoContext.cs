using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext (DbContextOptions<EmpleadoContext> options)
            : base(options)
        {
        }

        public DbSet<Viajes.Models.Empleado> Empleado { get; set; }
    }
}
