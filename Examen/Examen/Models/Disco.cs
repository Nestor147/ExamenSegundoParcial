using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class Disco
    {
        [Key]
        public int idDisco { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anio  { get; set; }
    }
}
