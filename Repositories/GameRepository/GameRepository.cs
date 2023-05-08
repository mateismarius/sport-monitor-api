using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using System.Diagnostics.Metrics;

namespace SportMonitorAPI.Repositories.GameRepository
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationContext _context;
        public GameRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddGame(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
                _context.Games.Remove(game);
            await _context.SaveChangesAsync();
        }

        public async Task<Game> GetGame(int id)
        {
            return await _context.Games.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Game>> GetGames()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task UpdateGame(Game game)
        {
            var dbObj = await _context.Games.FirstOrDefaultAsync(p => p.Id == game.Id);
            if (dbObj != null)
            {
                dbObj.Opponent = game.Opponent;
                dbObj.OpponentGoals = game.OpponentGoals;
                dbObj.CityGame = game.CityGame;
                dbObj.SportHall = game.SportHall;
                dbObj.GameDate = game.GameDate;
                dbObj.TeamGoals = game.TeamGoals;
                await _context.SaveChangesAsync();
            }
        }
    }
}
