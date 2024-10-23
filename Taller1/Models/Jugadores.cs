using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller1.Models
{
    public class Jugadores

    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public string Equipo { get; set; }

        public Equipo equipo { get; set; }
        [ForeignKey("Equipo")]

        public string Edad { get; set; }

    }
}
