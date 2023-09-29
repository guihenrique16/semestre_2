using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Paciente))]
    [Index(nameof(CPF), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? CPF { get; set; }

        [Column(TypeName = "VARCHAR(8)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? CEP { get; set; }

        [Column(TypeName = "VARCHAR(9)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? RG { get; set; }

        //ref. tabela Usuario
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
