using InLock.Domain;
using InLock.Interface;
using InLock.Repositores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace InLock.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository= new EstudioRepository();
        }

        [HttpPost]
        [Authorize(Roles = "2")]
        public IActionResult Post(EstudioDomain novoEstudio)
        {
            try
            {
                _estudioRepository.Cadastrar(novoEstudio);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet]
        [Authorize(Roles = "1,2")]
        public IActionResult Get()
        {
            try
            {
                List<EstudioDomain> listaestudios = _estudioRepository.ListarEstudios();
                return Ok(listaestudios);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "2")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _estudioRepository.Deletar(Id);

                return StatusCode(200);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
