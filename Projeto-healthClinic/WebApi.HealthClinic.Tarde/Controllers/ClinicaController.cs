using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;
using WebApi.HealthClinic.Tarde.Repositories;

namespace WebApi.HealthClinic.Tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClinicaController : ControllerBase
    {
        private readonly IClinicaRepository _clinicaRepositpry;
        public ClinicaController()
        {
            _clinicaRepositpry = new ClinicaRepository();   
        }

        [HttpPost]
        public IActionResult Post(Clinica clinica) 
        {
            try
            {
                _clinicaRepositpry.Cadastar(clinica);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);   
            }
        }
    }
}
