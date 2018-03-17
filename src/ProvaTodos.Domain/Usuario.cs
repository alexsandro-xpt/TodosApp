using System;
using System.Collections.Generic;

namespace ProvaTodos.Domain
{
    public class Usuario: BaseEntity
    {
        public int Id_Usuario { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public ICollection<UsuarioPerfil> Perfis { get; set; }

        private Usuario()
        {
        }

        public static Usuario CriarNovoUsuario(string nome, string email, string login, string senha)
        {
            return new Usuario { Nome = nome, Email = email, Login = login, Senha = senha, Dt_Inclusao = DateTime.Now, Ativo = true };
        }

        public void AdicionarPerfil (Perfil perfil)
        {
            Perfis.Add (new UsuarioPerfil (perfil, this) { Ativo = true });
        }
    }
}