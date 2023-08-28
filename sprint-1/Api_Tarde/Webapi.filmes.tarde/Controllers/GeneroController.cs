using Microsoft.AspNetCore.Mvc;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;
using Webapi.filmes.tarde.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Webapi.filmes.tarde.Controllers
{
    /// <summary>
    /// Route: define que a rota de uma requisição será no seguinte formato: dominio/api/nomeController
    /// Ex: http://Localhost:5000/api/genero
    /// </summary>
    [Route("api/[controller]")]

    /// <summary>
    /// ApiController: Define que é um controlador de api
    /// </summary>
    [ApiController]

    /// <summary>
    /// Route: Define que o tipo de resposta da api é JSON
    /// </summary>
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        /// <summary>
        /// Objeto que ira receber os metodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia do objeto _generoRepository para que haja referencia aos metodos do repositorios
        /// </summary>
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Endpoint que acessa o metodo de listar generos
        /// </summary>
        /// <returns> lista de generos e um status code </returns>
        [HttpGet]
        public  IActionResult Get() 
        {
            try
            {  
                //Cria a lista para receber os generos
                 List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

                // retorna o status code 200 ok e a lista de generos no formato JSON
                return StatusCode(200, ListaGeneros);
                //return Ok(ListaGeneros);

            }
            catch (Exception erro )
            {
                // retorna uma status code 400 - badRequest e a mensagem de erro 
                return BadRequest(erro.Message);
            }

        }

        /// <summary>
        /// Endpoint que acessa o metodo de cadastrar generos
        /// </summary>
        /// <param name="NovoGenero">objeto recebido na aquisicao</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post(GeneroDomain NovoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(NovoGenero);

                return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }

        /// <summary>
        /// Endpoint que acessa o metodo de Excluir generos
        /// </summary>
        /// <param name="Id"> objeto que sera excluido </param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public IActionResult delete(int Id) 
        {
            try
            {
                _generoRepository.Deletar(Id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }

        /// <summary>
        /// Endpoint que acessa o metodo de buscar generos por Id
        /// </summary>
        /// <param name="Id"> objeto que sera buscado </param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id) 
        {
            try
            {
                GeneroDomain BuscarGenero = _generoRepository.BuscarPorId(Id);

                if (BuscarGenero.IdGenero == 0)
                {
                    return NotFound("Genero nao encontrado");  
                }

                return StatusCode(200,BuscarGenero);

            
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }
    }
}
