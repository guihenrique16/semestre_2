using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;
using Webapi.filmes.tarde.Repositories;

namespace Webapi.filmes.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Senha)
        {
            try
            { 
                UsuarioDomain usuarioBuscado = _usuarioRepository.Login(Email, Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("Usuario nao encontrado"); 
                }
                return Ok(usuarioBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
           

        }


    }
}
