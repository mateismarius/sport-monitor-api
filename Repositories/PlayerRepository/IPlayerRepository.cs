using SportMonitorAPI.Entities;
using System.Collections.Generic;

namespace SportMonitorAPI.Repositories.PlayerRepository
{
    public interface IPlayerRepository
    {
        Task<IReadOnlyList<Player>> GetPlayers();
        Task<Player> GetPlayer(int id);
        Task UpdatePlayer(Player player);
        Task DeletePlayer(int id);
        Task AddPlayer(Player player);
    }
}
