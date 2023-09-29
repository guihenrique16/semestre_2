using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(CRM),IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(15)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? CRM { get; set; }

        //ref. tabela Usuario
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //ref. tabela Especialidades
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdEspecialidades { get; set; }

        [ForeignKey(nameof(IdEspecialidades))]
        public Especialidades? Especialidades { get; set; }
    }
}
