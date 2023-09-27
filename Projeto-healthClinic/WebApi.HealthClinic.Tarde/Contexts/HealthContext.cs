using Microsoft.EntityFrameworkCore;
using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Contexts
{
    public class HealthContext :DbContext
    {
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<Medico> Medico { get; set; } 
        public DbSet<Paciente> Paciente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE08-S14; Database= Projeto_HealthClinic_Tarde; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
