using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Viajes.Models;

namespace Viajes.Data
{
    public class PersonaContext : DbContext
    {
        public PersonaContext (DbContextOptions<PersonaContext> options)
            : base(options)
        {
        }

        public DbSet<Viajes.Models.Persona> Persona { get; set; }
    }
}
