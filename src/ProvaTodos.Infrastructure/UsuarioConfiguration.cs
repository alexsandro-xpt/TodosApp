using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
  public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id_Usuario);
            builder.Property(c => c.Login).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Senha).IsRequired().HasMaxLength(100);
        }
    }
}