using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ale_movi_mvc.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string UrlPerfil { get; set; }

        public List<Favorito>? PeliculasFavoritas { get; set; }

        public List<Reviow>? ReviowUsuario { get; set; }
    }
}
