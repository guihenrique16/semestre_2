using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastar(Clinica clinica);

        List<Clinica> ListarClinica();
    }
}
