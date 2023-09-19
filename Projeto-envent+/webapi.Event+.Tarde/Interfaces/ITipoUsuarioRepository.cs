using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TipoUsuario tipoUsuario);
        void Deletar(Guid id);
        List<TipoUsuario> Listar();
        TipoUsuario BuscarPorId();
        void Atualizar(Guid id, TipoUsuario tipoUsuario);
    }
}
