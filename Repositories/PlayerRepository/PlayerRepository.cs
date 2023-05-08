using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using System.Diagnostics.Metrics;

namespace SportMonitorAPI.Repositories.PlayerRepository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationContext _context;
        public PlayerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddPlayer( Player player)
        {
            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync();

        }

        public async Task DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player != null)
            {
                _context.Players.Remove(player);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IReadOnlyList<Player>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player> GetPlayer(int id)
        {
            return await _context.Players.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdatePlayer(Player player)
        {
            var dbObj = await _context.Players.FirstOrDefaultAsync(p => p.Id == player.Id);
            if (dbObj != null)
            {
                dbObj.PlayerName = player.PlayerName;
                dbObj.StartDate = player.StartDate;
                dbObj.DateOfBirth = player.DateOfBirth;
                dbObj.BadgeNo = player.BadgeNo;
                dbObj.Genre = player.Genre;
                await _context.SaveChangesAsync();
            }
        }
    }
}
