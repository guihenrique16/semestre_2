using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Event_.Tarde.Domains
{
    [Table(nameof(Instituicao))]
    [Index(nameof(CNPJ),IsUnique = true)]
    public class Instituicao
    {
        [Key]
        public Guid IdInstituicao { get; set; } = Guid.NewGuid();

        [Column(TypeName ="CHAR(14)")]
        [Required(ErrorMessage = "CNPJ obrigatorio")]
        [StringLength(14)]
        public String? CNPJ { get; set; }

        [Column(TypeName ="VARCHAR(150)")]
        [Required(ErrorMessage ="Endereço obrigatorio")]
        public String? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome obrigatorio")]
        public String? NomeFantasia { get; set; }
    }
}
