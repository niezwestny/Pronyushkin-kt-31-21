using Microsoft.EntityFrameworkCore;
namespace Proekt_Prakt_Lab.Database
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext>options) : base(options) { }
    }
}
