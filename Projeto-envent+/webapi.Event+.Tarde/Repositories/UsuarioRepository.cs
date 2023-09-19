using Microsoft.EntityFrameworkCore;
using webapi.Event_.Tarde.Contexts;
using webapi.Event_.Tarde.Domains;
using webapi.Event_.Tarde.Interfaces;
using webapi.Event_.Tarde.Utils;

namespace webapi.Event_.Tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext ctx;
        public UsuarioRepository()
        {
            ctx= new EventContext();
        }
        public Usuario BuscarPorEmailSenha(string Email, string Senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.Include(u => u.TipoUsuario).FirstOrDefault(u => u.Email == Email);
                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha);
                    if (confere)
                    {
                        return usuarioBuscado;  
                    }
               }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.Select(u => new Usuario
                {
                    IdUsuario = u.IdUsuario,
                    Nome = u.Nome,  
                    Email = u.Email,

                    TipoUsuario = new TipoUsuario
                    {
                        IdTipoUsuario = u.IdTipoUsuario,
                        Titulo = u.TipoUsuario!.Titulo
                    }
                }).FirstOrDefault(u => u.IdUsuario == id)!;

                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha);

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
