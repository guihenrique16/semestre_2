using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Prontuário { get; set; }

        [Column(TypeName = "DATETIME")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public DateTime? DataConsulta { get; set; }


        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public TimeOnly? HorarioConsulta { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "campo obrigatorio")]
        public bool? Situacao { get; set; }

        //ref. tabela Clinica
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }

        //ref. tabela Medico
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }

        //ref. tabela Paciente
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }


    }
}
