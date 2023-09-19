using webapi.Event_.Tarde.Domains;

namespace webapi.Event_.Tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        public void Cadastrar(Usuario usuario);
        Usuario BuscarPorId(Guid id);
        Usuario BuscarPorEmailSenha(string Email, string Senha);
    }
}
