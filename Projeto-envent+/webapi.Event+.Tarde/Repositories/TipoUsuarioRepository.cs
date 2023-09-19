using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;

namespace webapi.Event_.Tarde.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EventContext ctx;
        public TipoUsuarioRepository()
        {
            ctx = new EventContext();
        }
        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TipoUsuario BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                ctx.TipoUsuario.Add(tipoUsuario);

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

        public List<TipoUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
