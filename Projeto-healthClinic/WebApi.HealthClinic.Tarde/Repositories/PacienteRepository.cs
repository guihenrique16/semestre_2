using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public void Atualizar(Paciente p, Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> BuscarPorCpf()
        {
            throw new NotImplementedException();
        }

        public void cadastrar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        Paciente IPacienteRepository.BuscarPorCpf()
        {
            throw new NotImplementedException();
        }
    }
}
