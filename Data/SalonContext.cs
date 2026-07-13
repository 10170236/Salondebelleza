using Microsoft.EntityFrameworkCore;
using SalonDeBelleza.Models;

namespace SalonDeBelleza.Data
{
    public class SalonContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Empleado> Empleados { get; set; } = null!;
        public DbSet<Servicio> Servicios { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Cita> Citas { get; set; } = null!;
        public DbSet<DetalleCita> DetallesCitas { get; set; } = null!;
        public DbSet<Pago> Pagos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // NOTA: Conectando a tu instancia de SQL Server (DESKTOP-GLJR0B3)
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GLJR0B3;Database=SalonBellezaDB;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales de Fluent API si es necesario
            // Por ejemplo, para evitar borrado en cascada cíclico

            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Cliente)
                .WithMany(cl => cl.Citas)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Empleado)
                .WithMany(e => e.Citas)
                .HasForeignKey(c => c.EmpleadoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed initial data
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { IdUsuario = 1, NombreUsuario = "admin", Password = "123", Rol = "Administrador" }
            );
        }
    }
}
