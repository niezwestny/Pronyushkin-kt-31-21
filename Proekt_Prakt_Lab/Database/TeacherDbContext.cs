using Microsoft.EntityFrameworkCore;
using Proekt_Prakt_Lab.Database.Configurations;
using Proekt_Prakt_Lab.Models;
namespace Proekt_Prakt_Lab.Database
{
    public class TeacherDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        DbSet<Degree> Degrees { get; set; }
        DbSet<Cafedra> Cafedras{ get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        DbSet<Position> Positions { get; set; }
        public DbSet<Load> Loads { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new DegreeConfiguration());
            modelBuilder.ApplyConfiguration(new CafedraConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new LoadConfiguration());
        }
        public TeacherDbContext(DbContextOptions<TeacherDbContext>options) : base(options) { }
    }
}
