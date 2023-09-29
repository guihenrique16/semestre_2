using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.HealthClinic.Tarde.Interfaces;
using WebApi.HealthClinic.Tarde.Repositories;

namespace WebApi.HealthClinic.Tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRepository;
        public EspecialidadesController()
        {
            _especialidadesRepository = new EspecialidadesRepository();
        }
    }
 }
