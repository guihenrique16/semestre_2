using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IConsultaRepository
    {
        void cadastrar(Consulta consulta);

        void Deletar(Consulta consulta);

        List<Consulta> BuscarPorPaciente();

        List<Consulta> BuscarPorMedico();
    }
}
