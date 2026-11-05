namespace ale_movi_mvc.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaLanzamiento { get; set; }

        public int MinutosDuracion { get; set; }

        public  string  sinopsis { get; set; }

        public string PosterUrlPortada { get; set; }

        public int GeneroId { get; set; }

        public Genero? genero { get; set; }

        public int PlataformaId { get; set; }

        public Plataforma? plataforma { get; set; }

        public int PromedioRating { get; set; }

        public  List<Reviow>? ListaReviow { get; set; }

        public List<Favorito>? UsuariosFavoritos { get; set; }
    }
}
