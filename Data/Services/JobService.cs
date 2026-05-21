using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Group4_VISUALPROGRAMMING_PROJECT.Data
{
    public class JobService
    {
        private readonly ApplicationDbContext _dbContext;

        public JobService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // 1. READ Operation: Fetch all jobs from MySQL with their Departments
        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _dbContext.Jobs.Include(j => j.Department).ToListAsync();
        }

        // 2. CREATE Operation: Add a new job to MySQL
        public async Task<bool> AddJobAsync(Job newJob)
        {
            try
            {
                _dbContext.Jobs.Add(newJob);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 3. DELETE Operation: Remove a job from MySQL
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