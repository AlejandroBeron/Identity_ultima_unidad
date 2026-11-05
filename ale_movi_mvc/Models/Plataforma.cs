namespace ale_movi_mvc.Models
{
    public class Plataforma
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Url { get; set; }

        public string Logourl { get; set; }

        public List<Pelicula>? PeliculasPlataforma { get; set; }
    }
}
