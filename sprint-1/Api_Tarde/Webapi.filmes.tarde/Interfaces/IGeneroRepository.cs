using Webapi.filmes.tarde.Domains;

namespace Webapi.filmes.tarde.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio GeneroRepository
    /// Define os metodos que serao implementados pelo repositorio
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD
        //Tipo de retorno NomeMetodo (TipoParametro NomeParametro)
        
        /// <summary>
        /// Cadastrar um novo genero 
        /// </summary>
        /// <param name="NovoGenero"> Objeto que sera cadastrado </param>
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// Retornar todos os generos cadastrados
        /// </summary>
        /// <returns> Uma lista generos </returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Buscar um objeto atraves do seu id
        /// </summary>
        /// <param name="id"> id do objeto que sera buscado </param>
        /// <returns> objeto que foi buscado </returns>
        GeneroDomain BuscarPorId(int id);

        /// <summary>
        /// Atualizar o genero existente passando o id pelo corpo da requisicao 
        /// </summary>
        /// <param name="genero"> Objeto com as novas informacoes </param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atualizar o genero existente passando o id pela Url da requisicao
        /// </summary>
        /// <param name="Id"> id do objeto a ser atualizado </param>
        /// <param name="genero"> objeto com as novas informacoes </param>
        void AtualizarIdUrl(int Id,GeneroDomain genero);

        /// <summary>
        /// Deletar um gênero existente
        /// </summary>
        /// <param name="id"> ID do objeto a ser deletado </param>
        void Deletar(int id);

    }
}
