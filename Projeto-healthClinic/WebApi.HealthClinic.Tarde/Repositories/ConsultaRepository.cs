using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{

    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;
        public ConsultaRepository()
        {
            ctx = new HealthContext();  
        }

        public List<Consulta> BuscarPorMedico()
        {
            throw new NotImplementedException();
        }

        public List<Consulta> BuscarPorPaciente()
        {
            throw new NotImplementedException();
        }

        public void cadastrar(Consulta consulta)
        {
            try
            {
                ctx.Consulta.Add(consulta);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Consulta consulta)
        {
            try
            {
                Consulta ConsultaBuscada = ctx.Consulta.Find(consulta)!;

                if (ConsultaBuscada != null)
                {
                    ctx.Consulta.Remove(consulta);
                }

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
