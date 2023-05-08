using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace SportMonitorAPI.Repositories.TestRepository
{
    public class TestRepository : ITestRepository
    {
        private readonly ApplicationContext _context;
        public TestRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddTest(PhysichalTest test)
        {
            await _context.PhysichalTests.AddAsync(test);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTest(int id)
        {
            var test = await _context.PhysichalTests.FindAsync(id);
            if (test != null)
                _context.PhysichalTests.Remove(test);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<PhysichalTest>> GetTests()
        {
            return await _context.PhysichalTests.ToListAsync();
        }

        public async Task<PhysichalTest> GetTest(int id)
        {
            return await _context.PhysichalTests.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateTest(PhysichalTest test)
        {
            var dbObj = await _context.PhysichalTests.FirstOrDefaultAsync(p => p.Id == test.Id);
            if (dbObj != null)
            {
                dbObj.Description = test.Description;
                dbObj.Name = test.Name;
                dbObj.Unit = test.Unit;
                await _context.SaveChangesAsync();
            }
        }
    }
}
