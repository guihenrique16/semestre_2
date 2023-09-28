using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        void cadastrar(Usuario usuario);

        void Deletar(Guid id);

        void Atualizar(Guid id, Usuario usuario);

        Usuario BuscarPorEmailSenha(string Email, string Senha);

        Usuario BuscarPorId(Guid id);
    }
}
