

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Juego>
    {
        public void Configure(EntityTypeBuilder<Juego> builder)
        {

            builder.Property(P => P.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(P => P.Descripcion).IsRequired().HasMaxLength(180);
            builder.Property(P => P.Imagen).IsRequired();
        }
    }
}


