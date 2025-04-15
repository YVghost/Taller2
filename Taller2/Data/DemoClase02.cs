using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller2.Models;

    public class DemoClase02 : DbContext
    {
        public DemoClase02 (DbContextOptions<DemoClase02> options)
            : base(options)
        {
        }

        public DbSet<Taller2.Models.Facultad> Facultad { get; set; } = default!;

public DbSet<Taller2.Models.Carrera> Carrera { get; set; } = default!;

public DbSet<Taller2.Models.Estudiante> Estudiante { get; set; } = default!;
    }
