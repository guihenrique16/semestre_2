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
            throw new NotImplementedException();
        }

        public List<Especialidades> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
