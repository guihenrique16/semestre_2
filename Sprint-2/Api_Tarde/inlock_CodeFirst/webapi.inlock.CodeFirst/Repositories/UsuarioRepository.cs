using webapi.inlock.CodeFirst.Contexts;
using webapi.inlock.CodeFirst.Domains;
using webapi.inlock.CodeFirst.Interfaces;
using webapi.inlock.CodeFirst.Utils;

namespace webapi.inlock.CodeFirst.Repositories
{
    
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly InLockContext ctx;
        public UsuarioRepository()
        {
            ctx = new InLockContext();
        }

        public UsuarioDomain BuscarUsuario(string email, string senha)
        {
            try
            {
                var usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Email == email);

                if (usuarioBuscado == null)
                {
                    bool confere = Criptografia.CampararHash(senha, usuarioBuscado!.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CadastrarUsuario(UsuarioDomain usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Usuario.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
