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
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository  _estudiorepository { get; set; }

        public EstudioController()
        {
            _estudiorepository = new EstudioRepository();
        }

        /// <summary>
        /// Endpoint que acessa o metodo de cadastrar Estudios
        /// </summary>
        /// <param name = "NovoEstudio" >objeto recebido na aquisicao</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post(EstudioDomain NovoEstudio)
        {
            try
            {
                _estudiorepository.Cadastrar(NovoEstudio);

                return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }


        /// <summary>
        /// Endpoint que acessa o metodo de listar estudios
        /// </summary>
        /// <returns> lista de estudios e um status code </returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Cria a lista para receber os generos
                List<EstudioDomain> ListaEstudio = _estudiorepository.ListarTodos();

                // retorna o status code 200 ok e a lista de estudios formato JSON
                return StatusCode(200, ListaEstudio);
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
