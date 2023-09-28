using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;
        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Cadastrar(Comentario comentario)
        {
            try
            {
                ctx.Comentario.Add(comentario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Comentario comentario)
        {
            try
            {
                Comentario ComentarioBuscado = ctx.Comentario.Find(comentario)!;

                if (ComentarioBuscado != null)
                {
                    ctx.Comentario.Remove(comentario);
                }

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Comentario> GetAll()
        {
            return ctx.Comentario.ToList();
        }

        Comentario IComentarioRepository.BuscarPorConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
