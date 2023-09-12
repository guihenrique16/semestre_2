using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.inlock_games_dbFirst_tarde.Interface;
using webapi.inlock_games_dbFirst_tarde.Repositories;

namespace webapi.inlock_games_dbFirst_tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("aplication/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estudioRepository.listar());
            }
            catch (Exception)
            {

                throw new Exception("Deu ruim!");
            }
        }

        [HttpGet]
        public IActionResult Get() 
        {

        }
    }
}
