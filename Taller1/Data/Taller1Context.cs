using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1.Models;

namespace Taller1.Data
{
    public class Taller1Context : DbContext
    {
        public Taller1Context (DbContextOptions<Taller1Context> options)
            : base(options)
        {
        }

        public DbSet<Taller1.Models.Jugadores> Jugadores { get; set; } = default!;
        public DbSet<Taller1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller1.Models.Estadio> Estadio { get; set; } = default!;
    }
}
