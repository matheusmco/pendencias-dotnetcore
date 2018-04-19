using Microsoft.EntityFrameworkCore;

namespace WAPendencia.Models
{
    public class PendenciaContext : DbContext
    {
        public PendenciaContext(DbContextOptions<PendenciaContext> options) : base(options)
        {
        }

        public DbSet<PendenciaModel> Pendencias { get; set; }
    }
}