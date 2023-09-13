using System.ComponentModel.DataAnnotations;

namespace Webapi.InLock.tarde.Domains
{
    public class UsuarioDomain
    {
         public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O tipo de usuário é obrigatório")]
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O email de usuário é obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha de usuário é obrigatória")]
        public string? Senha { get; set; }


        //Referência à classe TiposUsuárioDomain
        public TiposUsuarioDomain? TipoUsuario { get; set; }
    }
}
