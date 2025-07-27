using Microsoft.EntityFrameworkCore;

namespace IZUMU.Clientes.Infrastructure
{
    public class DatosPersonalesDbContext : DbContext
    {
        public DatosPersonalesDbContext(DbContextOptions<DatosPersonalesDbContext> options)
            : base(options) { }

        public DbSet<Entities.DatosPersonalesEntity> DatosPersonales { get; set; }
    }
}
