using System.Data.SqlClient;
using Webapi.filmes.tarde.Domains;
using Webapi.filmes.tarde.Interfaces;

namespace Webapi.filmes.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source = NOTE08-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        public UsuarioDomain Login(string Email, string Senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryLogin = "SELECT IdUsuario, Email, Permissao FROM Usuario WHERE Email = @Email AND Senha = @Senha";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    SqlDataReader rdr= cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                            Email = rdr["Email"].ToString(),
                            Permissao = rdr["Permissao"].ToString()
                        };
                        return usuario;
                    }
                    return null;

                }

            }
        }

        
    }
}
