using System.Collections.Generic;
using ProvaTodos.Application.Interfaces;
using ProvaTodos.Domain;
using ProvaTodos.Domain.Interfaces;
using ProvaTodos.Infrastructure;

namespace ProvaTodos.Application
{
    public class AccountService : IAccountService
    {
        private readonly IUsuarioRepository _repositoryRepository;
        private readonly Context _context;
        
        public AccountService(IUsuarioRepository repositoryRepository, Context context)
        {
            _repositoryRepository = repositoryRepository;
            _context = context;
        }

        public Usuario CriarUsuario(string nome, string email, string login, string senha)
        {
            var usuario = Usuario.CriarNovoUsuario(nome, email, login, senha);
            _repositoryRepository.Add(usuario);
            _context.Commit();

            return usuario;
        }

        public void EditarUsuario(int id, string nome, string email, string login, string senha)
        {
            var usuario = _repositoryRepository.GetById(id);

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Login = login;
            usuario.Senha = senha;

            _repositoryRepository.Edit(usuario);

            _context.Commit();
            
        }

        public void ExcluirUsuario(int id)
        {
            _repositoryRepository.RemoveById(id);
            _context.Commit();
        }

        public IEnumerable<Usuario> ListarTodosUsuario()
        {
            return _repositoryRepository.GetAll();
        }
    }
}