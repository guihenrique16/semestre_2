using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;
        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }
        public void Cadastar(Clinica clinica)
        {
            try
            {
                ctx.Clinica.Add(clinica);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Clinica> ListarClinica()
        {
            return ctx.Clinica.ToList();
        }
    }
}
