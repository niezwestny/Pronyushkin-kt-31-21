using Proekt_Prakt_Lab.Database;
using Proekt_Prakt_Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace Proekt_Prakt_Lab.Interfaces.LoadInterfaces
{
    public interface ILoadService
    {
        public Task<Load[]> GetLoadsAsync(CancellationToken cancellationToken);
        public Task<Load> GetLoadAsync(int id, CancellationToken cancellationToken);    
        public Task AddNewLoadAsync(Load load, CancellationToken cancellationToken);    
        public Task UpdateLoadAsync(Load load, CancellationToken cancellationToken);

    }
    public class LoadService : ILoadService
    {
        public readonly TeacherDbContext _dbContext;
        public LoadService(TeacherDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Load[]> GetLoadsAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loads.ToArrayAsync();
        }
        public async Task<Load> GetLoadAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Loads.FindAsync(id);
        }

        public async Task AddNewLoadAsync(Load load, CancellationToken cancellationToken = default)
        { 
            _dbContext.Loads.Add(load);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateLoadAsync(Load load, CancellationToken cancellationToken = default)
        {
            _dbContext.Loads.Update(load);
            await _dbContext.SaveChangesAsync();
        }
    }

}
