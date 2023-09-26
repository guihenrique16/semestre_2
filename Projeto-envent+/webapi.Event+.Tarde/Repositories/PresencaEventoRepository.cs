using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;

namespace webapi.Event_.Tarde.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext ctx;
        public PresencaEventoRepository()
        {
            ctx = new EventContext();
        }

        public void CancelarInscricao(Guid id)
        {
            try
            {
                PresencaEvento presencaBuscado = ctx.PresencaEvento.Find(id)!;

                if (presencaBuscado != null)
                {
                    ctx.PresencaEvento.Remove(presencaBuscado);
                }

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Inscricao(PresencaEvento presenca)
        {
            try
            {
                ctx.PresencaEvento.Add(presenca);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PresencaEvento> ListaPresencas()
        {
            try
            {
                List<PresencaEvento> listaDePresenca = ctx.PresencaEvento.ToList();
                return listaDePresenca;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
