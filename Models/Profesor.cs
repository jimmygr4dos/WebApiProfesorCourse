using System.ComponentModel.DataAnnotations;

namespace WebApiProfesorCourse.Models
{
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }
        public required string Apellidos { get; set; }
        public required string Nombres { get; set; }
        public string Tipo { get; set; } = "";
        public byte Estado { get; set; }
    }
}
