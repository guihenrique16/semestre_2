using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;

namespace webapi.Event_.Tarde.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext ctx;
        public EventoRepository()
        {
            ctx= new EventContext();    
        }

        public void cadastrarEvento(Evento evento)
        {
            try
            {
                ctx.Evento.Add(evento);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Evento> ListarEvento()
        {
            try
            {
                List<Evento> listaDeEventos = ctx.Evento.ToList();
                return listaDeEventos;  
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
