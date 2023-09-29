﻿using Microsoft.EntityFrameworkCore;
using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;
        public MedicoRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Medico medico, Guid id)
        {
            try
            {
                Medico m = ctx.Medico.Find(id)!;
                if (m != null)
                {
                    m.CRM = m.CRM;
                    m.IdUsuario = m.IdUsuario;
                    m.IdEspecialidades = m.IdEspecialidades;
                }
                ctx.Medico.Update(m!);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medico> BuscarPorEspecialidades(string titulo)
        {
            List<Medico> lista = ctx.Medico.Include(x => x.Especialidades).Where(c => c.Especialidades!.Titulo == titulo).ToList();
            return lista;
        }

        public void cadastrar(Medico medico)
        {
            try
            {
                ctx.Medico.Add(medico);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Medico medico)
        {
            try
            {
                Medico MedicoBuscada = ctx.Medico.Find(medico)!;

                if (MedicoBuscada != null)
                {
                    ctx.Medico.Remove(medico);
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
