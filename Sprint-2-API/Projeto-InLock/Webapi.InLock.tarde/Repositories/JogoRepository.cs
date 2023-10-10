using System.Data.SqlClient;
using System.Drawing;
using Webapi.InLock.tarde.Domains;
using Webapi.InLock.tarde.Interfaces;

namespace Webapi.InLock.tarde.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexao = "Data Source = NOTE08-S14; Initial Catalog = inlock_games_Tarde; User Id = sa; Pwd = Senai@134";
        //private string StringConexao = "Data Source = DESKTOP-91GF6I9\\SQLEXPRESS; Initial Catalog = inlock_games_Tarde; Integrated Security=True; TrustServerCertificate=true";

        public void Cadastrar(JogoDomain NovoJogo)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryCadastro = "INSERT INTO Jogo VALUES (@IdEstudio,@Nome,@Descricao,@DataLancamento,@Valor)";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(QueryCadastro,con))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", NovoJogo.IdEstudio);
                    cmd.Parameters.AddWithValue("@Nome", NovoJogo.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", NovoJogo.Descricao);
                    cmd.Parameters.AddWithValue("@DataLancamento", NovoJogo.DataLancamento);
                    cmd.Parameters.AddWithValue("@Valor", NovoJogo.Valor);

                    cmd.ExecuteNonQuery();  

                }
            }
        }

        public List<JogoDomain> ListarTodos()
        {
            List<JogoDomain> listaJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelectAll = "Select IdEstudio,Nome,Descricao,DataLancamento,Valor FROM Jogo";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read()) 
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr[0]),
                            Nome = Convert.ToString(rdr[1]),
                            Descricao = Convert.ToString(rdr[2]),
                            DataLancamento = Convert.ToDateTime(rdr[3]),
                            Valor = Convert.ToDecimal(rdr[4])
                        };
                        listaJogos.Add(jogo);
                    }
                    
                }

            }
            return listaJogos;  
        }
    }
}
