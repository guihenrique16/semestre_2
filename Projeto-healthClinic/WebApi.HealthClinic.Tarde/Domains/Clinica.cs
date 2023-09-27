using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Clinica))]
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
        [NotMapped]
        public TimeSpan HoraDeInicio { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [NotMapped]
        public TimeSpan HoraDeEncerramento { get; set; }
    }
}
