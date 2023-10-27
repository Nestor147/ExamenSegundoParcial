using Microsoft.EntityFrameworkCore;
using Examen.Models;


namespace Examen.Context
{
    public class AplicacionContext: DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
       : base(options) { }
        public DbSet<Disco> Disco { get; set; }
        public DbSet<Musica> Musica { get; set; }
   

    }
}
