using Microsoft.EntityFrameworkCore;
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

        public List<Consulta> BuscarPorMedico(Guid id)
        {
            try
            {
                List<Consulta> consultaPorM = new List<Consulta>();
                foreach (Consulta c in ctx.Consulta)
                {
                    if (c.IdMedico == id)
                    {
                        consultaPorM.Add(c);
                    }
                }
                return consultaPorM;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Consulta> BuscarPorPaciente(Guid id)
        {
            try
            {
                List<Consulta> consultaPorP = new List<Consulta>();
                foreach (Consulta c in ctx.Consulta)
                {
                    if (c.IdPaciente == id)
                    {
                        consultaPorP.Add(c);
                    }
                }
                return consultaPorP;
            }
            catch (Exception)
            {

                throw;
            }
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

        public List<Consulta> GetAll()
        {
            return ctx.Consulta.ToList();
        }
    }
}
