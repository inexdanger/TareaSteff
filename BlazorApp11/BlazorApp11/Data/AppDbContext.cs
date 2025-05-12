using Microsoft.EntityFrameworkCore;
using BlazorApp11.Models;  // Asegúrate de importar el espacio de nombres de los modelos

namespace BlazorApp11.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets que representan las tablas en la base de datos
        public DbSet<Nodo> Nodos { get; set; }
        public DbSet<Via> Vias { get; set; }
        public DbSet<Semaforo> Semaforos { get; set; }
        public DbSet<VehiculosEnEspera> VehiculosEnEspera { get; set; }
        public DbSet<TiempoTransito> TiempoTransito { get; set; }
        public DbSet<EstadoNodo> EstadosNodos { get; set; }
        public DbSet<Flujo> Flujos { get; set; }
        public DbSet<TiempoEstimado> TiemposEstimados { get; set; }

        // Configuración adicional (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración personalizada de las tablas si es necesario
            modelBuilder.Entity<Via>().ToTable("Vias");
            modelBuilder.Entity<Semaforo>().ToTable("Semaforos");
            modelBuilder.Entity<VehiculosEnEspera>().ToTable("VehiculosEnEspera");
            modelBuilder.Entity<TiempoTransito>().ToTable("TiempoTransito");
        }
    }
}
