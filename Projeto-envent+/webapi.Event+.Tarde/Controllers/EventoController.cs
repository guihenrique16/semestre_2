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
    public class EventoController : ControllerBase
    {
        private IEventoRepository _eventoRepository;
        public EventoController()
        {
            _eventoRepository = new EventoRepository();
        }

        [HttpPost]
        [Authorize(Roles = "ADM")]
        public IActionResult Post(Evento evento)
        {
            try
            {
                _eventoRepository.cadastrarEvento(evento);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get() 
        {

            try
            {
                return Ok(_eventoRepository.ListarEvento());
            }
            catch (Exception)
            {

                throw new Exception("Deu ruim!");
            }
        }
    }
}
