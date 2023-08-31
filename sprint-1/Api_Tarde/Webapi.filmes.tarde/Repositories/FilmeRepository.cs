using System.Data.SqlClient;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;

namespace Webapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string StringConexao = "Data Source = NOTE08-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// buscar um filme pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FilmeDomain BuscarPorId(int id)
        {
            FilmeDomain BuscarFilme;

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                String QueryBuscar = "SELECT Filme.IdFilme,Filme.IdGenero,Filme.Titulo,Genero.IdGenero, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero = Genero.IdGenero WHERE Filme.IdFilme = @IdFilme";
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(QueryBuscar,con))
                {
                    cmd.Parameters.AddWithValue("Idfilme", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        BuscarFilme = new FilmeDomain()
                        {
                             IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                             IdGenero= Convert.ToInt32(rdr["IdGenero"]), 
                             Titulo = rdr["Titulo"].ToString(), 
                             
                             Genero = new GeneroDomain() 
                             {
                                 IdGenero= Convert.ToInt32(rdr["IdGenero"]),
                                 Nome = rdr["Nome"].ToString(),
                             }
                        }; 

                        return BuscarFilme;
                    }

                   
                }
            }
            return null;
        }

        /// <summary>
        /// cadastrar um novo Filme
        /// </summary>
        /// <param name="NovoFilme"></param>
        public void Cadastrar(FilmeDomain NovoFilme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryInsert = "INSERT INTO Filme (IdGenero,Titulo) VALUES (@IdGenero, @Titulo)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", NovoFilme.IdGenero);
                    cmd.Parameters.AddWithValue("@Titulo", NovoFilme.Titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// excluir um filme 
        /// </summary>
        /// <param name="id"></param>
        public void ExcuirPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                String QueryExluir = "DELETE FROM Filme WHERE Filme.IdFilme = @IdFilme";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryExluir,con) )
                {
                    cmd.Parameters.AddWithValue("@IdFilme",id);

                    cmd.ExecuteNonQuery() ; 
                }
            }
        }

        /// <summary>
        /// listar todos os filmes
        /// </summary>
        /// <returns></returns>
        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> ListaFilmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT Filme.IdFilme, Filme.Titulo, Filme.IdGenero , Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),
                            Titulo = Convert.ToString(rdr["Titulo"]),
                            Genero = new GeneroDomain()
                            {
                                Nome = Convert.ToString(rdr["Nome"])
                            }

                        };

                        ListaFilmes.Add(filme);
                    }
                }
            }
            return ListaFilmes;
        }
    }
}

