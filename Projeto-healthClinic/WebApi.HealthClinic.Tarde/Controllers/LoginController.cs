using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebApi.HealthClinic.Tarde.Domains;
using WebApi.HealthClinic.Tarde.Interfaces;
using WebApi.HealthClinic.Tarde.Repositories;
using WebApi.HealthClinic.Tarde.ViewModels;

namespace WebApi.HealthClinic.Tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(usuario.Email, usuario.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("Usuário não encontrado, verifique se o email e a senha estão digitados corretamente e tente novamente.");

                }
                else
                {
                    //criação do token

                    //1 - Definir as Claims/Informações que serão passadas para o token (Payloads)
                    var claims = new[]
                    {
                        //instancia a claim de Id - Jti
                        new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),

                        //instancia a claim de email
                        new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),

                        //instancia a claim de permissão para autorização posteriormente
                        new Claim(ClaimTypes.Role, usuarioBuscado.TipoUsuario.Titulo.ToString())
                    };

                    //2 - Definir a chave de acesso ao token
                    //instancia a chave simétrica de decodificação
                    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Projeto-HealthClinic-Tarde-chave-autenticacao-autorizacao-webApi"));

                    //3 - Definir as credenciais do token (Header)
                    //instancia que será uma chave e qual o tipo de algorítimo da mesma
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    //4 - Geração do token
                    //instancia o token do tipo JWT
                    var token = new JwtSecurityToken
                    (
                        //emissor do token - quem está enviando
                        issuer: "WebApi.HealthClinic.Tarde",

                        //destinatário do token - quem está recebendo
                        audience: "WebApi.HealthClinic.Tarde",

                        //quais as claims do token (Payloads)
                        claims: claims,

                        //tempo de expiração do token
                        expires: DateTime.Now.AddMinutes(20),

                        //quais as credenciais do token
                        signingCredentials: creds
                    );

                    //5- Retornar o token criado
                    return Ok
                    (
                        new
                        {
                            //criação do mainupador para gerar o token
                            token = new JwtSecurityTokenHandler().WriteToken(token)
                        }
                    );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
