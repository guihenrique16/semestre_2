using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;

namespace webapi.Event_.Tarde.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventContext ctx;
        public TipoEventoRepository()
        {
            ctx = new EventContext();
        }
        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            throw new NotImplementedException();
        }

        public TipoEvento BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoEvento tipoEvento)
        {
            try
            {
                ctx.TipoEvento.Add(tipoEvento);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TipoEvento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
