using webapi.inlock_games_dbFirst_tarde.Domains;

namespace webapi.inlock_games_dbFirst_tarde.Interface
{
    public interface IEstudioRepository
    {
        List<Estudio> listar();
        Estudio BuscarPorId(Guid id);
        void Cadastrar(Estudio estudio);
        void Atualizar(Guid id, Estudio estudio);
        void Deletar(Guid id);
        List<Estudio> ListarComJogos();
    }
}
