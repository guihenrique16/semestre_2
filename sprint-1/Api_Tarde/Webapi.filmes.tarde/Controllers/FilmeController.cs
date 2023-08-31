using Microsoft.AspNetCore.Mvc;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;
using Webapi.filmes.tarde.Repositories;

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
    public class FilmeController : Controller
    {
        /// <summary>
        /// Objeto que ira receber os metodos definidos na interface
        /// </summary>
        private IFilmeRepository _filmeRepository { get; set; }

        /// <summary>
        /// Instancia do objeto _filmeRepository para que haja referencia aos metodos do repositorios
        /// </summary>
        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
        }

        /// <summary>
        /// Endpoint que acessa o metodo de cadastrar Filmes
        /// </summary>
        /// <param name="NovoFilme">objeto recebido na aquisicao</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post(FilmeDomain NovoFilme)
        {
            try
            {
                _filmeRepository.Cadastrar(NovoFilme);

                return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }

        /// <summary>
        /// Endpoint que acessa o metodo de listar Filmes
        /// </summary>
        /// <returns> lista de filmes e um status code </returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<FilmeDomain> ListaFilmes = _filmeRepository.ListarTodos();

                return StatusCode(200, ListaFilmes);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }

        }

        /// <summary>
        /// Endpoint que acessa o metodo de buscar Filmes por id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public IActionResult Get(int Id) 
        {
            try
            {
                FilmeDomain Filmebuscado = _filmeRepository.BuscarPorId(Id);
                if (Filmebuscado != null)
                {
                       return StatusCode(200, Filmebuscado);
                }
                return StatusCode(404);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que acessa o metodo de excluir Filmes
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            try
            {
                FilmeDomain FilmeBuscado = _filmeRepository.BuscarPorId(Id);
                if (FilmeBuscado == null)
                {
                    return NotFound();
                }
                else
                {
                    _filmeRepository.ExcuirPorId(Id);

                    return StatusCode(204, Id);

                }
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);

                throw;
            }
        }

    }
}



