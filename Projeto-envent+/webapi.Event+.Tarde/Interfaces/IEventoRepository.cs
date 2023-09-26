using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface IEventoRepository
    {
        void cadastrarEvento(Evento evento);

        List<Evento> ListarEvento();

    }
}
