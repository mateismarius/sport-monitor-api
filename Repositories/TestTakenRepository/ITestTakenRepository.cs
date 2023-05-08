using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.TestTakenRepository
{
    public interface ITestTakenRepository
    {
        Task<IReadOnlyList<TestTaken>> GetTestList();
        Task<TestTaken> GetTest(int id);
        Task UpdateTest(TestTaken test);
        Task DeleteTest(int id);
        Task AddTest(TestTaken test);
        Task<IReadOnlyList<TestTaken>> GetTestByPlayer(int id);
        Task<IReadOnlyList<TestTaken>> GetAllTestsById(int id);
    }
}
