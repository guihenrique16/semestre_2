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
    public class PresencaEventoController : ControllerBase
    {
        private IPresencaEventoRepository _presencaEventoRepository;
        public PresencaEventoController()
        {
            _presencaEventoRepository= new PresencaEventoRepository();
        }

        [HttpPost]
        public IActionResult Post(PresencaEvento presenca)
        {
            try
            {
                _presencaEventoRepository.Inscricao(presenca);
                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _presencaEventoRepository.CancelarInscricao(id);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_presencaEventoRepository.ListaPresencas());
            }
            catch (Exception)
            {

                throw new Exception("Deu ruim!");
            }
        }
    }
}
