using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProvaTodos.Application.Interfaces;
using ProvaTodos.Domain.Interfaces;

namespace ProvaTodos.Api.Features
{
    [Route("api/[Controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _serviceAccount;
        public AccountController(IAccountService serviceAccount)
        {
            _serviceAccount = serviceAccount;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _serviceAccount.ListarTodosUsuario();
            return new OkObjectResult(usuarios);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioModel model)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            var usuario = _serviceAccount.CriarUsuario(model.Nome, model.Email, model.Login, model.Senha);


            return CreatedAtAction("Get", usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UsuarioModel model)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            _serviceAccount.EditarUsuario(id, model.Nome, model.Email, model.Login, model.Senha);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceAccount.ExcluirUsuario(id);
            
            return Ok();
        }
    }
}