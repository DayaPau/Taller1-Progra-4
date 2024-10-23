using System.ComponentModel.DataAnnotations;

namespace Taller1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]

        public string Direccion { get; set; }
            
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
