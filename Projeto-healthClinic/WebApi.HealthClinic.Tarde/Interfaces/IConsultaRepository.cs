using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IConsultaRepository
    {
        void cadastrar(Consulta consulta);

        void Deletar(Consulta consulta);

        List<Consulta> GetAll();

        List<Consulta> BuscarPorMedico();//Somente medicos

        List<Consulta> BuscarPorPaciente();//Soemnte pacientes
    }
}
