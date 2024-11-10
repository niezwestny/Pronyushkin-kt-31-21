using Proekt_Prakt_Lab.Filters;
using Proekt_Prakt_Lab.Database;
using Proekt_Prakt_Lab.Models;
using Microsoft.EntityFrameworkCore;
namespace Proekt_Prakt_Lab.Interfaces.DisciplineInterfaces
{
    public interface IDisciplineService
    {
        public Task<Discipline[]> GetDisciplinesByLoadAsync(DisciplineLoadFilter filter, CancellationToken cancellationToken);
        public Task<Discipline[]> GetDisciplinesByTeacherAsync(DisciplineTeacherFilter filter, CancellationToken cancellationToken);
    }
        public class DisciplineService : IDisciplineService
        {
            private readonly TeacherDbContext _dbContext;

            public DisciplineService(TeacherDbContext dbContext)
            {
                _dbContext = dbContext;
            }
            public Task<Discipline[]> GetDisciplinesByTeacherAsync(DisciplineTeacherFilter filter, CancellationToken cancellationToken = default)
            {
                var discipline = _dbContext.Set<Discipline>().Where(w => w.Discipline_Teacher_ID == filter.TeacherID).Select(w=>new Discipline
                {
                    Discipline_ID = w.Discipline_ID,
                    Discipline_Name = w.Discipline_Name,
                    Discipline_Load_Hours = w.Discipline_Load_Hours,
                    Discipline_Teacher_ID = w.Discipline_Teacher_ID
                }).ToArrayAsync(cancellationToken);
                return discipline;
            }
            public async Task<Discipline[]> GetDisciplinesByLoadAsync(DisciplineLoadFilter filter, CancellationToken cancellationToken = default)
            {
                var disciplineLoad = await _dbContext.Set<Discipline>().Where(d => d.Discipline_Load_Hours > filter.Min && d.Discipline_Load_Hours < filter.Max ).Select(d => new Discipline
                {
                    Discipline_ID = d.Discipline_ID,
                    Discipline_Name = d.Discipline_Name,
                    Discipline_Load_Hours = d.Discipline_Load_Hours,
                    Discipline_Teacher_ID = d.Discipline_Teacher_ID
                }).ToArrayAsync(cancellationToken);
                return disciplineLoad;
            }
        }
}



