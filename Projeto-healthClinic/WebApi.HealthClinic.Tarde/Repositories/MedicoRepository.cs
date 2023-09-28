using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public void Atualizar(Medico m, Guid id)
        {
            throw new NotImplementedException();
        }

        public void cadastrar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Medico medico)
        {
            throw new NotImplementedException();
        }

        Medico IMedicoRepository.BuscarPorEspecialidades()
        {
            throw new NotImplementedException();
        }
    }
}
