namespace ProvaTodos.Domain
{
    public class UsuarioPerfil
    {
        public UsuarioPerfil (Perfil perfil, Usuario usuario)
        {
            Perfil = perfil;
            Usuario = usuario;
        }

        public int Id_Perfil { get; set; }
        public Perfil Perfil { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }

    }
}