using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly HealthContext ctx;
        public TipoUsuarioRepository()
        {
            ctx = new HealthContext();  
        }
        public void cadastrar(TipoUsuario tipoUsuario)
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

        public List<TipoUsuario> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
