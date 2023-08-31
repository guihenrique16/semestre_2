using System.ComponentModel.DataAnnotations;

namespace Webapi.filmes.tarde.Domains
{

    /// <summary>
    /// classe que representa a entidade usuario
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatorio")]
        public string Email { get; set; }

        [StringLength(20,MinimumLength = 3,ErrorMessage ="O campo senha nessecita de no minimo 3 e no maximo 20 caracteres")]
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        public string Senha { get; set; }

        public string Permissao { get; set; }

    }
}
