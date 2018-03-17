using System.Collections.Generic;

namespace ProvaTodos.Domain
{
    public class Perfil
    {
        public int Id_Perfil { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public ICollection<UsuarioPerfil> Usuarios { get; set; }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(new UsuarioPerfil(this, usuario) { Ativo = true });
        }
    }
}