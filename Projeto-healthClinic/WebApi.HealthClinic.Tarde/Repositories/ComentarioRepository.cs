using Microsoft.EntityFrameworkCore;
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

        public void Deletar(Guid id)
        {
            try
            {
                Comentario ComentarioBuscado = ctx.Comentario.Find(id)!;

                if (ComentarioBuscado != null)
                {
                    ctx.Comentario.Remove(ComentarioBuscado);
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

        public Comentario BuscarPorConsulta(Guid id)
        {
            return ctx.Comentario.FirstOrDefault(c => c.Consulta!.IdConsulta == id)!;
        }
    }
}
