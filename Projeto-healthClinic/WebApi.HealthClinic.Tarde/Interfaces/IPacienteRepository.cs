using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IPacienteRepository
    {
        void cadastrar(Paciente paciente);

        void Deletar(Paciente paciente);

        void Atualizar(Paciente p, Guid id);

        Paciente BuscarPorCpf();

    }
}
