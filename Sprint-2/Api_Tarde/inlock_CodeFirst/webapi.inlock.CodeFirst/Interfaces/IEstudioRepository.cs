using webapi.inlock.CodeFirst.Domains;

namespace webapi.inlock.CodeFirst.Interfaces
{
    public interface IEstudioRepository
    {
        List<EstudioDomain> listar();
        EstudioDomain BuscarPorId(Guid id);
        void Cadastrar(EstudioDomain estudio);
        void Atualizar(Guid id, EstudioDomain estudio);
        void Deletar(Guid id);
        List<EstudioDomain> ListarComJogos();
    }
}
