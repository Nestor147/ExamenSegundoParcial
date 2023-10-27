using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class Musica
    {
        [Key]
        public int idMusica { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public int numeroReproducciones  { get; set; }
        public int idDisco { get; set; }
    }
}
