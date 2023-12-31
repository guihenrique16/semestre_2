﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Event_.Tarde.Domains
{
    [Table(nameof(PresencaEvento))] 
    public class PresencaEvento
    {
        [Key]
        public Guid IdPresencaEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName ="BIT")]
        [Required(ErrorMessage ="Situacao obrigatoria")]
        public bool Situacao { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage ="Usuario obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //ref.tabela evento
        [Required(ErrorMessage ="Evento obrigatorio")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]  
        public Evento? Evento { get; set; }
    }
}
