using Webapi.filmes.tarde.Domains;

namespace Webapi.filmes.tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// metodo que busca um usario por email e senha 
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Senha"></param>
        /// <returns> objeto que sera buscado </returns>
        UsuarioDomain Login(string Email, string Senha);
    }
}
