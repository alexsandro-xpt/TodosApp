using ProvaTodos.Domain.Interfaces;

namespace ProvaTodos.Domain.Service
{
    public class UsuarioService : IDomainService
    {
        private readonly IUsuarioRepository _repositoryUsuario;
        public UsuarioService (IContext context, IUsuarioRepository repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;

        }
    }
}