using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Event_.Tarde.Domains
{
    [Table(nameof(Evento))]
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage ="Data obrigatoria")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome obrigatorio")]
        public String? NomeEvento { get; set; }

        [Column(TypeName ="TEXT")]
        [Required(ErrorMessage ="Descricao obrigatoria")]
        public String? Descricao { get; set; }

        //ref.tabela TipoEvento
        [Required(ErrorMessage ="Tipo do evento obrigatorio")]
        public Guid IdTipoEvento { get; set; }

        [ForeignKey(nameof(IdTipoEvento))]
        public TipoEvento? TipoEvento { get; set; }

        //ref.tabela Instituicao
        [Required(ErrorMessage = "Instituicao do evento obrigatorio")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao? Instituicao  { get; set; }

    }
}
