using Microsoft.EntityFrameworkCore;
using WebApiProfesorCourse.Models;

namespace WebApiProfesorCourse.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Course> Curso { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
    }
}
