namespace ale_movi_mvc.Models
{
    public class Favorito
    {
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public Usuario? usuario { get; set; }

        public int PeliculaId { get; set; }

        public Pelicula? pelicula { get; set; }

        public  DateTime Fecha { get; set; }
    }
}
