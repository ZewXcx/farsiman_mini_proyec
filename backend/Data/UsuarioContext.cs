using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext (DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
