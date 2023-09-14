using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.CodeFirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email),IsUnique = true)]
    public class UsuarioDomain
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();    

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Email obrigatorio")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR(200)")]
        [Required(ErrorMessage ="Senha obrigatoria")]
        [StringLength(60,MinimumLength =6,ErrorMessage ="Senha deve conter de 6 a 20 caracteres")]
        public string? Senha { get; set; }

        //ref.tabela TiposUsuario
        [Required(ErrorMessage ="Tipo de Usuario obrigatorio")]
        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")] 
        public TiposUsuarioDomain? TipoUsuario { get; set; }
    }
}
