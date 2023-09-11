namespace Webapi.InLock.tarde.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public int IdEstudio { get; set; }
        public EstudioDomain? Estudio { get; set; }
        public String? Nome { get; set; }
        public String? Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }

    }
}
