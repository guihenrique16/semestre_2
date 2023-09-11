using Webapi.InLock.tarde.Domains;

namespace Webapi.InLock.tarde.Interfaces
{
    public interface IJogoRepository
    {
        void cadastrar(JogoDomain NovoJogo);
        List<JogoDomain> ListarTodos(); 
    }
}
