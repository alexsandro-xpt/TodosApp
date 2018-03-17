using System.ComponentModel.DataAnnotations;

namespace ProvaTodos.Api.Features
{
  public class UsuarioModel
  {
    [Required]
    public string Login { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Senha { get; set; }
  }
}