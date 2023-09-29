using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(TipoUsuario))]
    [Index(nameof(Titulo), IsUnique = true)]
    public class TipoUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Titulo { get; set; }
    }
}
