using Microsoft.EntityFrameworkCore;
using ProvaTodos.Domain;
using ProvaTodos.Domain.Interfaces;

namespace ProvaTodos.Infrastructure.Repository
{
    public class UsuarioRepository : BaseRelacionalRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context) { }
    }
}