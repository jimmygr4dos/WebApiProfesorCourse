using System.ComponentModel.DataAnnotations;

namespace WebApiProfesorCourse.Models
{
    public class Course
    {
        [Key]
        public int IdCurso { get; set; }
        public required string Nombre { get; set; }
        public int Duracion { get; set; }
        public required string Descripcion { get; set; }
    }
}
