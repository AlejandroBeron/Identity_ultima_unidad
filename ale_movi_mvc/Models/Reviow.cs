using System.ComponentModel.DataAnnotations;

namespace ale_movi_mvc.Models
{
    public class Reviow
    {
        public int Id { get; set; }

        public int PeliculaId { get; set; }

        public Pelicula? pelicula { get; set; }

        public string usuarioId { get; set; }
        public Usuario? usuario { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReviow { get; set; }

        [Timestamp]

        public byte [] RowVersion { get; set;

    }
}
    }
