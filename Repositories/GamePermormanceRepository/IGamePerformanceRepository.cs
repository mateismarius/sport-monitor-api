using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.GamePermormanceRepository
{
    public interface IGamePerformanceRepository
    {
        Task<IReadOnlyList<GamePerformance>> GetGamesPerformances();
        Task<GamePerformance> GetGamePerformance(int id);
        Task UpdateGamePerformance(GamePerformance player);
        Task DeleteGamePerformance(int id);
        Task AddGamePerformance(GamePerformance player);
    }
}
