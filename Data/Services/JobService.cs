using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group4_VISUALPROGRAMMING_PROJECT.Data

{
    public class JobService
    {
        private readonly ApplicationDbContext _dbContext;

        // Dependency Injection pulls the DbContext into our Business Layer
        public JobService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // 1. READ Operation: Fetch all jobs from MySQL
       // 1. READ Operation: Fetch all jobs from MySQL
public async Task<List<Job>> GetAllJobsAsync()
{
    return await _dbContext.Jobs.Include(j => j.Department).ToListAsync();
}
        // 2. DELETE Operation: Remove a job from MySQL
        public async Task<bool> DeleteJobAsync(int jobId)
        {
            var targetJob = await _dbContext.Jobs.FindAsync(jobId);
            if (targetJob != null)
            {
                _dbContext.Jobs.Remove(targetJob);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}