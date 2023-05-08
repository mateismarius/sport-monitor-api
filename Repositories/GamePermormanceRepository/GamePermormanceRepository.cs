using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.GamePermormanceRepository
{
    public class GamePermormanceRepository : IGamePerformanceRepository
    {
        public Task AddGamePerformance(GamePerformance player)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGamePerformance(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GamePerformance> GetGamePerformance(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<GamePerformance>> GetGamesPerformances()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGamePerformance(GamePerformance player)
        {
            throw new NotImplementedException();
        }
    }
}
