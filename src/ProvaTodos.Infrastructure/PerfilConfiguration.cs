using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
  public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.HasKey(c => c.Id_Perfil);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        }
    }
}