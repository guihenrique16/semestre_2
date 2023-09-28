using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.HealthClinic.Tarde.Domains
{
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Nome { get; set; }  
        
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Telefone { get; set; } 
        
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "Senha obrigatoria")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter entre 6 a 60 caracteres")]
        public string? Senha { get; set; }

        //ref. tabela tipoUsuario
        [Required(ErrorMessage = "Campo obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuario? TipoUsuario { get; set; }




    }
}
