using Microsoft.EntityFrameworkCore;
using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;
        public PacienteRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Paciente paciente, Guid id)
        {
            try
            {
                Paciente p = ctx.Paciente.Find(id)!; 
                if (p != null)
                {
                    p.CPF = p.CPF;
                    p.IdUsuario = p.IdUsuario;
                }
                ctx.Paciente.Update(p!);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Paciente BuscarPorCpf(string cpf)
        {
            return ctx.Paciente.FirstOrDefault(c => c.CPF! == cpf)!;
        }

        public void cadastrar(Paciente paciente)
        {
            try
            {
                ctx.Paciente.Add(paciente);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Paciente paciente)
        {
            try
            {
                Paciente PacienteBuscada = ctx.Paciente.Find(paciente)!;

                if (PacienteBuscada != null)
                {
                    ctx.Paciente.Remove(paciente);
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
