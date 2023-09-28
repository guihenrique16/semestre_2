using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class EspecialidadesRepository : IEspecialidadesRepository
    {
        private readonly HealthContext ctx;
        public EspecialidadesRepository()
        {
            ctx = new HealthContext();
        }

        public void cadastrar(Especialidades especialidades)
        {
            try
            {
                ctx.Especialidades.Add(especialidades);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Especialidades especialidades)
        {
            try
            {
                Especialidades EspecialidadeBuscada = ctx.Especialidades.Find(especialidades)!;

                if (EspecialidadeBuscada != null)
                {
                    ctx.Especialidades.Remove(especialidades);
                }

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Especialidades> GetAll()
        {
            return ctx.Especialidades.ToList();
        }
    }
}
