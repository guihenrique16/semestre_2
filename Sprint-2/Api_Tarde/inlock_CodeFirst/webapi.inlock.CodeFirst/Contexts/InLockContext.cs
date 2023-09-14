using Microsoft.EntityFrameworkCore;
using webapi.inlock.CodeFirst.Domains;

namespace webapi.inlock.CodeFirst.Contexts
{
    public class InLockContext : DbContext
    {
        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }
        public DbSet<UsuarioDomain> Usuario { get; set; }
        public DbSet<EstudioDomain> Estudio { get; set; }
        public DbSet<JogoDomain> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE08-S14; Database=inlock_games_codeFirst_Tarde; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
