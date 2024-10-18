using System.ComponentModel.DataAnnotations;

namespace Taller1.Models
{
    public class Jugadores

    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public string Equipo { get; set; }
    }
}
