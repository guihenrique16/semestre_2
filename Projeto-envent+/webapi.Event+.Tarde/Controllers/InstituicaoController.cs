using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;
using webapi.Event_.Tarde.Repositories;

namespace webapi.Event_.Tarde.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository;
        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpPost]
        [Authorize(Roles = "ADM")]
        public IActionResult Post(Instituicao instituicao)
        {
            try
            {
                _instituicaoRepository.cadatrar(instituicao);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
