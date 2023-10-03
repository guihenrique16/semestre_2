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

        public void Atualizar(Guid id, Consulta consulta)
        {
            try
            {
                Consulta consultaBuscada = this.BuscarPorId(id);

                consultaBuscada.DataConsulta = consulta.DataConsulta;
                consultaBuscada.Situacao = consulta.Situacao;
                consultaBuscada.IdPaciente = consulta.IdPaciente;
                consultaBuscada.IdMedico = consulta.IdMedico;

                ctx.Consulta.Update(consultaBuscada);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Consulta> BuscarMinhas(Guid id)
        {
            try
            { 
                return ctx.Consulta.Include(c => c.Paciente).Include(c => c.Medico).Where(c => (c.Paciente!.IdUsuario == id) || (c.Medico!.IdUsuario == id)).ToList();
 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Consulta BuscarPorId(Guid id)
        {
            try
            {
                Consulta consultaBuscada = ctx.Consulta.Include(c => c.Clinica).Include(c => c.Paciente).Include(c => c.Medico)
                    .FirstOrDefault(c => c.IdConsulta == id)!;

                if (consultaBuscada == null)
                {
                    return null;
                }

                return consultaBuscada;
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

        public void Deletar(Guid id)
        {
            try
            {
                Consulta ConsultaBuscada = ctx.Consulta.Find(id)!;

                if (ConsultaBuscada != null)
                {
                    ctx.Consulta.Remove(ConsultaBuscada);
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
