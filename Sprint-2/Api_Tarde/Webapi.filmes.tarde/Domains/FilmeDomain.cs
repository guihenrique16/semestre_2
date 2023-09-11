using System.ComponentModel.DataAnnotations;

namespace Webapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe que representa a entidade ou tabela Filme
    /// </summary>
    public class FilmeDomain
    {
        public int IdFilme { get; set; }
        [Required(ErrorMessage ="O titulo do filme é obrigatorio")]
        public String? Titulo { get; set; }
        public int IdGenero { get; set; }

        //Referencia para a classe Genero
        public GeneroDomain? Genero { get; set; }
    }
}