using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using System.Diagnostics.Metrics;

namespace SportMonitorAPI.Repositories.TestTakenRepository
{
    public class TestTakenRepository : ITestTakenRepository
    {
        private readonly ApplicationContext _context;

        public TestTakenRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddTest(TestTaken test)
        {
            Player pl = await _context.Players.SingleOrDefaultAsync(x => x.Id == test.PlayerId);
            PhysichalTest tst = await _context.PhysichalTests.SingleOrDefaultAsync(x => x.Id == test.TestId);
            test.Test = tst;
            test.Player = pl;
            await _context.TestTakens.AddAsync(test);
            await _context.SaveChangesAsync();
        }
      

        public async Task DeleteTest(int id)
        {
            var test = await _context.TestTakens.FindAsync(id);
            if (test != null)
                _context.TestTakens.Remove(test);
            await _context.SaveChangesAsync();
        }

        public async Task<TestTaken> GetTest(int id)
        {
            return await _context.TestTakens.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<TestTaken>> GetTestList()
        {
            return await _context.TestTakens.Include(x => x.Player).Include(x => x.Test).ToListAsync();
        }

        public async Task UpdateTest(TestTaken test)
        {
            var dbObj = await _context.TestTakens.FirstOrDefaultAsync(p => p.Id == test.Id);
            if (dbObj != null)
            {
                dbObj.TestId = test.Id;
                dbObj.PlayerId = test.PlayerId;
                dbObj.Result = test.Result;
                dbObj.TakenAt = test.TakenAt;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IReadOnlyList<TestTaken>> GetTestByPlayer(int id)
        {
            return await _context.TestTakens.Where(t => t.PlayerId == id)
                .Include(t => t.Player)
                .Include(t => t.Test)
                .OrderBy(t => t.Test.Name).ThenByDescending(t => t.TakenAt)
                .ToListAsync();
        }
        public async Task<IReadOnlyList<TestTaken>> GetAllTestsById(int id)
        {
            return await _context.TestTakens.Where(t => t.TestId == id)
                .Include(t => t.Player)
                .Include(t => t.Test)
                .OrderBy(t => t.TakenAt).ThenBy(t => t.Test.Name)
                .ToListAsync();
        }
    }
}
