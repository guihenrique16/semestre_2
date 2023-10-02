using Webapi.InLock.tarde.Domains;

namespace Webapi.InLock.tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioDomain Login(string email, string senha);
    }
}
