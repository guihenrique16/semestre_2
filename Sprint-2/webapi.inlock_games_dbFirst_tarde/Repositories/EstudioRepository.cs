using Microsoft.EntityFrameworkCore;
using webapi.inlock_games_dbFirst_tarde.Contexts;
using webapi.inlock_games_dbFirst_tarde.Domains;
using webapi.inlock_games_dbFirst_tarde.Interface;

namespace webapi.inlock_games_dbFirst_tarde.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();    
        public void Atualizar(Guid id, Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public Estudio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Estudio> listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            List<Estudio> estudios = ctx.Estudios.ToList();
            return ctx.Include<Estudio>Jogo.ToList();
        }
    }
}
