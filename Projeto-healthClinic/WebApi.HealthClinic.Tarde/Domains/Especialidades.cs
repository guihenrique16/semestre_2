using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Especialidades))]
    [Index(nameof(Titulo), IsUnique = true)]
    public class Especialidades
    {
        [Key]
        public Guid IdEspecialidades { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Titulo { get; set; }
    }
}
