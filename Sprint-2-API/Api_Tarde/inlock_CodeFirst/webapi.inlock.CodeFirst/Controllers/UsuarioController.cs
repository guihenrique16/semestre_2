using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.inlock.CodeFirst.Domains;
using webapi.inlock.CodeFirst.Interfaces;
using webapi.inlock.CodeFirst.Repositories;

namespace webapi.inlock.CodeFirst.Controllers
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost("usuario")]
        [Authorize("DAA161CE-7AC1-4309-ABCA-C5874FFA6A7D")]
        public IActionResult Cadastrar(UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.CadastrarUsuario(usuario);
                return StatusCode(200, usuario);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
