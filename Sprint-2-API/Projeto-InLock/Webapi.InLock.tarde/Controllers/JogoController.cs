using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi.InLock.tarde.Domains;
using Webapi.InLock.tarde.Interfaces;
using Webapi.InLock.tarde.Repositories;

namespace Webapi.InLock.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoreporitory { get; set; }

        public JogoController()
        {
            _jogoreporitory = new JogoRepository();
        }

        [HttpPost]
        public IActionResult post(JogoDomain NovoJogo)
        {
            try
            {
                _jogoreporitory.Cadastrar(NovoJogo);

                return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Cria a lista para receber os generos
                List<JogoDomain> listaJogos = _jogoreporitory.ListarTodos();

                // retorna o status code 200 ok e a lista de estudios formato JSON
                return StatusCode(200, listaJogos);
                //return Ok(ListaGeneros);

            }
            catch (Exception erro)
            {
                // retorna uma status code 400 - badRequest e a mensagem de erro 
                return BadRequest(erro.Message);
            }

        }
    }
}
