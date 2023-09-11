using Webapi.InLock.tarde.Domains;

namespace Webapi.InLock.tarde.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain NovoEstudio);
        List<EstudioDomain> ListarTodos();
    }
}
