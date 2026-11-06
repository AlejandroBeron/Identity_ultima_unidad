using ale_movi_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ale_movi_mvc.Data
{
    public class MoviDbContext : IdentityDbContext<Usuario>
    {
        public MoviDbContext(DbContextOptions<MoviDbContext> options): base(options)
        {
        }

        public DbSet<Pelicula> peliculas { get; set; }

        public DbSet<Plataforma> plataformas { get; set; }

        public DbSet<Genero> generos { get; set; }

        public DbSet<Reviow> reviow { get; set; }

        public DbSet<Favorito> favoritos { get; set; }
    }
}
