using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(14)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public TimeOnly? HoraDeInicio { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public TimeOnly? HoraDeEncerramento { get; set; }
    }
}
