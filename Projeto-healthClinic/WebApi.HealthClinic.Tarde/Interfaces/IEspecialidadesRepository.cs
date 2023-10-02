using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IEspecialidadesRepository
    {
        void cadastrar(Especialidades especialidades);

        void Deletar(Guid id);

        List<Especialidades> GetAll();
    }
}
