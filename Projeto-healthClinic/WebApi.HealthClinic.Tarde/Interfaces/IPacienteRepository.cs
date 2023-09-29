using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IPacienteRepository
    {
        void cadastrar(Paciente paciente);

        void Deletar(Paciente paciente);

        void Atualizar(Paciente paciente, Guid id);

        Paciente BuscarPorCpf(string cpf);

    }
}
