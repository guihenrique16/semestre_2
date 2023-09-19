using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Event_.Tarde.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Nome obrigatorio")]
        public String? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatorio")]
        public String? Email  { get; set; }

        [Column(TypeName ="CHAR(60)")]
        [Required(ErrorMessage ="Senha obrigatoria")]
        [StringLength(60,MinimumLength =6, ErrorMessage ="Senha deve conter entre 6 a 60 caracteres")]
        public String? Senha { get; set; }

        //ref. tabela tipoUsuario
        [Required(ErrorMessage = " tipo de Usuario é obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
