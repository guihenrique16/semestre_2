using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface ITipoEventoRepository
    {
        void Cadastrar(TipoEvento tipoEvento);
        void Deletar(Guid id);
        List<TipoEvento> Listar();
        TipoEvento BuscarPorId();
        void Atualizar(Guid id, TipoEvento tipoEvento);
    }
}
