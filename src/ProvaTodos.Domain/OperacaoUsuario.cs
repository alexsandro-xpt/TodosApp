using System;

namespace ProvaTodos.Domain
{
  public class OperacaoUsuario
    {
        public int Id_Operacao_Acesso { get; set; }
        public DateTime Dt_Log { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}