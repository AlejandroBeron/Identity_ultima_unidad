namespace ale_movi_mvc.Models
{
    public class Usuario : Identity
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string UrlPerfil { get; set; }

        public List<Favorito>? PeliculasFavoritas { get; set; }
    }
}
