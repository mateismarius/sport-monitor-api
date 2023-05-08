using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.TestRepository
{
    public interface ITestRepository
    {
        Task<IReadOnlyList<PhysichalTest>> GetTests();
        Task<PhysichalTest> GetTest(int id);
        Task UpdateTest(PhysichalTest test);
        Task DeleteTest(int id);
        Task AddTest(PhysichalTest test);
    }
}
