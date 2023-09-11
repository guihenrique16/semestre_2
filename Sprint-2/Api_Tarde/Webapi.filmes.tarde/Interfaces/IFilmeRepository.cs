using Webapi.filmes.tarde.Domains;

namespace Webapi.filmes.tarde.Interfaces
{
    public interface IFilmeRepository
    {
        //CRUD

        /// <summary>
        /// Método para cadastrar um novo filme
        /// </summary>
        /// <param name="NovoFilme">Objeto com as informações dos filmes a serem cadastrados</param>
        void Cadastrar(FilmeDomain NovoFilme);

        /// <summary>
        /// Método para listar todos os filmes
        /// </summary>
        /// <returns>A lista com todos os filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Método para retornar um único filme por seu id
        /// </summary>
        /// <param name="Id">Id do filme a ser buscado</param>
        /// <returns>Os dados do filme com o id especificado</returns>
        FilmeDomain BuscarPorId(int Id);

        /// <summary>
        /// Método para alterar um filme pelo corpo da requisição
        /// </summary>
        /// <param name="FilmeAtualizado">O objeto com as novas informações do filme</param>
        void AtualizarIdCorpo(FilmeDomain FilmeAtualizado);

        /// <summary>
        /// Método para alterar um filme pelo id passado pela url
        /// </summary>
        /// <param name="Id">Id do filme a ser alterado</param>
        /// <param name="FilmeAtualizado">O objeto com as novas informações do filme</param>
        void AtualizarIdUrl(int Id, FilmeDomain FilmeAtualizado);

        /// <summary>
        /// Método para deltar um filme do banco de dados
        /// </summary>
        /// <param name="Id">Id do filme a ser deletado</param>
        void ExcuirPorId(int Id);
    }
}
