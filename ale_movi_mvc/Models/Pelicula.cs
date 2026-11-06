using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ale_movi_mvc.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }
        [Required]

        [Range(1, 500)]
        public int MinutosDuracion { get; set; }
        [Required]
        [StringLength(500)]
        public  string  sinopsis { get; set; }
        [Url]
        [Required]
        public string PosterUrlPortada { get; set; }

        public int GeneroId { get; set; }

        public Genero? genero { get; set; }

        public int PlataformaId { get; set; }

        public Plataforma? plataforma { get; set; }

        [NotMapped]
        public int PromedioRating { get; set; }

        public  List<Reviow>? ListaReviow { get; set; }

        public List<Favorito>? UsuariosFavoritos { get; set; }
    }
}
