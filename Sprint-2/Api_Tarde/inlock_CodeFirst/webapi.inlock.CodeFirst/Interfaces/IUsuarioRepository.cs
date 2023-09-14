using webapi.inlock.CodeFirst.Domains;

namespace webapi.inlock.CodeFirst.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioDomain BuscarUsuario(string email, string senha);
        void CadastrarUsuario(UsuarioDomain Usuario);
    }
}
