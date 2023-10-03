using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IConsultaRepository
    {
        void Atualizar(Guid id, Consulta consulta);

        void cadastrar(Consulta consulta);

        void Deletar(Guid id);

        Consulta BuscarPorId(Guid id);

        List<Consulta> GetAll();

        List<Consulta> BuscarMinhas(Guid id);
    }
}
