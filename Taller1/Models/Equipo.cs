using System.ComponentModel.DataAnnotations;

namespace Taller1.Models
{
    public class Equipo
    {
       

        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Ciudad { get; set; }
        public string Titulos { get; set; }
        
        public bool AceptaExtranjeros { get; set; }
    }
}
