using Microsoft.EntityFrameworkCore;
using AcademicMVC.Models;

namespace AcademicMVC.Data
{
    public class AcademicDB_Context:DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }

        
        public AcademicDB_Context(DbContextOptions<AcademicDB_Context> options ) : base(options)
        {
        }
    }
}