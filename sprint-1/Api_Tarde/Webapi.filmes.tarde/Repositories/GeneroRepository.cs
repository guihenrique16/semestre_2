using System.Data.SqlClient;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;

namespace Webapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        //Utilizada para conectar ao banco de dados
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source: nome do servidor do banco
        /// Initial catalog: Nome do BD
        /// Autenticação:
        /// -Windows: Integrated Security = True
        /// SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE08-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //DECLARA A QUERY QUE SERA EXECUTADA
                string queryPut = "INSERT INTO Genero(Nome) VALUES (@Nome)";


                // DECLARA O SQLCOMMAND PASSANDO A QUERY QUE SERA EXECUTADA E A CONEXAO COM O BD 
                using (SqlCommand cmd = new SqlCommand(queryPut, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", );

                    // ABRE A CONEXAO COM O BD
                    con.Open();

                    //EXECUTA A QUERY
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void AtualizarIdUrl(int Id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// cadastrar um novo genero
        /// </summary>
        /// <param name="NovoGenero"> objeto com as informacoes que serao cadastradas </param>
        /// <exception cref="NotImplementedException"></exception>
        public void Cadastrar(GeneroDomain NovoGenero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //DECLARA A QUERY QUE SERA EXECUTADA
                string queryInsert = "INSERT INTO Genero(Nome) VALUES (@Nome)";

                
                // DECLARA O SQLCOMMAND PASSANDO A QUERY QUE SERA EXECUTADA E A CONEXAO COM O BD 
                using (SqlCommand cmd = new SqlCommand(queryInsert,con))
                {
                    cmd.Parameters.AddWithValue("@Nome", NovoGenero.Nome);

                    // ABRE A CONEXAO COM O BD
                    con.Open();

                    //EXECUTA A QUERY
                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

        public void Deletar(int Id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = $"DELETE FROM Genero WHERE {Id} = Genero.IdGenero";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                }
            }
        }


        /// <summary>
        /// Listar todos os objetos do tipo genero
        /// </summary>
        /// <returns>Lista de objetos do tipo gênero</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de generos onde serão armazenados os generos
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();


            //Declara a SqlConnection, passando a string de conexão como parâmetro. É o objeto que faz a conexão com o BD
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrução a ser executada, no caso, é o select
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";


                //Abre a conexão com o BD
                con.Open();

                //Declara o SqlDataReader para percorrer/ler a tabela no BD
                SqlDataReader rdr;


                //Declara o SqlCommand passando a query que será executada e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //executa a query e armazena os dados na rdr
                    rdr = cmd.ExecuteReader();


                    //Enquanto houver registros a serem lidos no rdr, o laço se repetirá
                    while (rdr.Read())
                    {
                        GeneroDomain gennero = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero ao valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //Atribui a propriedade nome ao valor da coluna nome
                            Nome = Convert.ToString(rdr[1])

                            //ou: NomeGenero = rdr["Nome"].ToString()

                        };

                        //Adiciona o objeto criado dentro da lista
                        ListaGeneros.Add(gennero);


                    }
                }
            }

            //Retorna a lista de generos
            return ListaGeneros;
        }
    }
}
