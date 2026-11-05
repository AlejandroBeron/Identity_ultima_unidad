namespace ale_movi_mvc.Models
{
    public class Reviow
    {
        public int Id { get; set; }

        public int PeliculaId { get; set; }

        public Pelicula? pelicula { get; set; }

        public string usuarioId { get; set; }
        public Usuario? usuario { get; set; }

        public int Rating { get; set; }

        public string Comentario { get; set; }

        public DateTime FechaReviow { get; set; }

    }
}
