using System.Data.SqlClient;
using Webapi.InLock.tarde.Domains;
using Webapi.InLock.tarde.Interfaces;

namespace Webapi.InLock.tarde.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private string StringConexao = "Data Source = NOTE08-S14; Initial Catalog = inlock_games_Tarde; User Id = sa; Pwd = Senai@134";
        //private string StringConexao = "Data Source = DESKTOP-91GF6I9\\SQLEXPRESS; Initial Catalog = inlock_games_Tarde; Integrated Security=True; TrustServerCertificate=true";
        public void Cadastrar(EstudioDomain NovoEstudio)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //DECLARA A QUERY QUE SERA EXECUTADA
                string queryInsert = "INSERT INTO Estudio(Nome) VALUES (@Nome)";

                // DECLARA O SQLCOMMAND PASSANDO A QUERY QUE SERA EXECUTADA E A CONEXAO COM O BD 
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", NovoEstudio.Nome);

                    // ABRE A CONEXAO COM O BD
                    con.Open();

                    //EXECUTA A QUERY
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public List<EstudioDomain> ListarTodos()
        {
            List<EstudioDomain> ListaEstudio = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT IdEstudio, Nome FROM Estudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll,con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr[0]),

                            Nome = Convert.ToString(rdr[1])
                        };
                        ListaEstudio.Add(estudio);
                    }

                }
            }
            return ListaEstudio;    
        }
    }
}
