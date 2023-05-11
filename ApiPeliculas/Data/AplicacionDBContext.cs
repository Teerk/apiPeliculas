using ApiPeliculas.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data
{
    public class AplicacionDBContext:DbContext 
    {
        public AplicacionDBContext(DbContextOptions<AplicacionDBContext> options) : base(options)
        {

        }

        //agregar los modelos aqui

        public DbSet<Categoria> Categorias { get; set; }

    }
}
