using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
  public class OperacaoUsuarioConfiguration : IEntityTypeConfiguration<OperacaoUsuario>
    {
        public void Configure(EntityTypeBuilder<OperacaoUsuario> builder)
        {
            builder.HasKey(c => new { c.Id_Usuario, c.Id_Operacao_Acesso });
            builder.HasOne(c => c.Usuario).WithMany().HasForeignKey(c => c.Id_Usuario);

        }
    }
}