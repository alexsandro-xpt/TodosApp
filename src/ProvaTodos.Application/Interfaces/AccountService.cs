using System.Collections.Generic;
using ProvaTodos.Domain;

namespace ProvaTodos.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Usuario> ListarTodosUsuario();
        Usuario CriarUsuario(string nome, string email, string login, string senha);
        void EditarUsuario(int id, string nome, string email, string login, string senha);
        void ExcluirUsuario(int id);
    }
}