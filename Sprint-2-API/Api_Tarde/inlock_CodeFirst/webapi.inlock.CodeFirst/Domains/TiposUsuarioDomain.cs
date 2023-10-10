using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.CodeFirst.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuarioDomain
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();   

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Titulo obrigatorio")]
        public string? Titulo { get; set; }
    }
}
