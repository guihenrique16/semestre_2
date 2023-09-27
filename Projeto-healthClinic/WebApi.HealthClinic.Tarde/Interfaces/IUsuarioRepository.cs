using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        void cadastrar(Usuario usuario);

        void Deletar(Usuario usuario);

        List<Usuario> GetAll();
    }
}
