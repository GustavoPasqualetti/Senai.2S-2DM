using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppInLock.CodeFirst.Domain;
using WebAppInLock.CodeFirst.Interface;
using WebAppInLock.CodeFirst.Repositories;

namespace WebAppInLock.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
