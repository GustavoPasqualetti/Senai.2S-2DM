using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppInLock.CodeFirst.Interface;
using WebAppInLock.CodeFirst.Repositories;
using WebAppInLock.CodeFirst.ViewModels;

namespace WebAppInLock.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
         
        }

    }
}
