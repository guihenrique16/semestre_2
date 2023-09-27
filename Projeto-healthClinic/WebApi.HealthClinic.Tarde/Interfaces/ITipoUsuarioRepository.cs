using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void cadastrar(TipoUsuario tipoUsuario);

        List<TipoUsuario> GetAll();
    }
}
