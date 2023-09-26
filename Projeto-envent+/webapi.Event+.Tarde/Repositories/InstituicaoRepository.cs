using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;

namespace webapi.Event_.Tarde.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly EventContext ctx;
        public InstituicaoRepository()
        {
            ctx= new EventContext();
        }

        public void cadatrar(Instituicao instituicao)
        {
            try
            {
                ctx.Instituicao.Add(instituicao);

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
    }
}
