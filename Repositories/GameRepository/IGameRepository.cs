using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.GameRepository
{
    public interface IGameRepository
    {
        Task<IReadOnlyList<Game>> GetGames();
        Task<Game> GetGame(int id);
        Task UpdateGame(Game game);
        Task DeleteGame(int id);
        Task AddGame(Game game);
    }
}
