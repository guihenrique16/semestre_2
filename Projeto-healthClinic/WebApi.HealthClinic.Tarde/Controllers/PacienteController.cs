using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
