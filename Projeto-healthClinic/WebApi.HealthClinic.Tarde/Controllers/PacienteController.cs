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
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        [HttpGet]
        public IActionResult GetByCpf(string cpf)
        {
            try
            {
                return Ok(_pacienteRepository.BuscarPorCpf(cpf));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            try
            {
                _pacienteRepository.cadastrar(paciente);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);    
            }
        }

        [HttpDelete] 
        public IActionResult Delete(Guid id)
        {
            try
            {
                _pacienteRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Paciente paciente, Guid id)
        {
            try
            {
                _pacienteRepository.Atualizar(paciente, id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
