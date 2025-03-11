using Microsoft.EntityFrameworkCore;

namespace PracticasEmilyCodeFirts.Models
{
    public class MiDbContext : DbContext {
     public MiDbContext (DbContextOptions<MiDbContext> options) : base(options) { }
       public DbSet<Empleado> Empleados { get; set; }
       public DbSet<Alumno> Alumnos { get; set; }

    }
}
