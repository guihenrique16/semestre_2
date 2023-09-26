using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Inscricao(PresencaEvento presenca);
        void CancelarInscricao(Guid id);
        List<PresencaEvento> ListaPresencas();
    }
}
