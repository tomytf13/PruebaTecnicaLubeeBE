using APIColegio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace APIColegio.Repositories
{
    public class DataBaseContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedido>().HasKey(pedido=>pedido.Id);
            modelBuilder.Entity<Contrato>().HasKey(contrato => contrato.Id);
            modelBuilder.Entity<Item>().HasKey(item => item.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EOQQD8; Database=Colegio; MultipleActiveResultSets=True; Trusted_Connection=True; TrustServerCertificate=true;").UseLazyLoadingProxies()
                .ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
           


        }
        public DbSet<Item> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
    }
}
