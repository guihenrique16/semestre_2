using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface IInstituicaoRepository
    {
        void cadatrar(Instituicao instituicao);
        void Deletar(Guid id);
    }
}
