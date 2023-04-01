using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace Infrastructure.Data
{
    public class KeyZoneContext : DbContext
    {
        public KeyZoneContext(DbContextOptions<KeyZoneContext> options) : base
        (options)
        {
        }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<RequisitosMin> RequisitosMin { get; set; }
        public DbSet<RequisitosRec> RequisitosRec { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<JuegoPlataforma> JuegosPlataformas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<JuegoPlataforma>()
          .HasKey(jp => new { jp.IdJuego, jp.IdPlataforma });

               modelbuilder.Entity<JuegoPlataforma>()
                   .HasOne(jp => jp.juego)
                   .WithMany(g => g.JuegosPlataforma)
                   .HasForeignKey(jp => jp.IdJuego);

               modelbuilder.Entity<JuegoPlataforma>()
                   .HasOne(jp => jp.plataforma)
                   .WithMany(p => p.JuegosPlataformas)
                   .HasForeignKey(jp => jp.IdPlataforma)
                   .OnDelete(DeleteBehavior.Cascade);

            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelbuilder);
        }
    }
}


