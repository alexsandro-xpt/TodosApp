using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
  public class UsuarioPerfilConfiguration : IEntityTypeConfiguration<UsuarioPerfil>
    {
        public void Configure(EntityTypeBuilder<UsuarioPerfil> builder)
        {
            builder.HasKey(c => new { c.Id_Usuario, c.Id_Perfil });
            builder.HasOne(c => c.Usuario).WithMany(c => c.Perfis).HasForeignKey(c => c.Id_Usuario);
            builder.HasOne(c => c.Perfil).WithMany(c => c.Usuarios).HasForeignKey(c => c.Id_Perfil);
        }
    }
}