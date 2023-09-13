using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace webapi.inlock.CodeFirst.Domains
{
    [Table("Jogo")]
    public class JogoDomain
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "Nome obrigatorio ")]
        public string? Nome { get; set; }

        [Column(TypeName ="TEXT")]
        [Required(ErrorMessage ="Descricao do jogo obrigatorio")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="Data de lancamento obrigatoria")]
        public DateTime Datalancamento { get; set; }

        [Column(TypeName ="DECIMAL(4,2")]
        [Required(ErrorMessage ="Preco do jogo obrigatorio")]
        public decimal preco { get; set; }

        //ref. a tabela estudio - FK
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public EstudioDomain? Estudio { get; set; }
    }
}
