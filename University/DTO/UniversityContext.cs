using Microsoft.EntityFrameworkCore;

namespace University.DTO
{
    public class UniversityContext : DbContext
    {
        public DbSet<StudentDTO> Students { get; set; }
        public DbSet<SubjectDTO> Subjects { get; set; }
        public DbSet<TeacherDTO> Teachers {get;set;}

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
