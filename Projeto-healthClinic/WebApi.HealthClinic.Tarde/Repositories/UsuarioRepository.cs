using Microsoft.EntityFrameworkCore;
using WebApi.HealthClinic.Tarde.Contexts;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;
using WebApi.HealthClinic.Tarde.Utils;

namespace WebApi.HealthClinic.Tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;
        public UsuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Usuario usuario)
        {
            throw new NotImplementedException();
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
                Usuario usuarioBuscado = ctx.Usuario
                .Select(x => new Usuario
                {
                    IdTipoUsuario = x.IdTipoUsuario,
                    Nome = x.Nome,
                    Email = x.Email,

                    TipoUsuario = new TipoUsuario
                    {
                        IdTipoUsuario = x.IdTipoUsuario,
                        Titulo = x.TipoUsuario!.Titulo
                    }
                }).FirstOrDefault(x => x.IdUsuario == id)!;

                return usuarioBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cadastrar(Usuario usuario)
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

        public void Deletar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.Find(id)!;
                if (usuarioBuscado != null)
                {
                    ctx.Remove(usuarioBuscado);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
