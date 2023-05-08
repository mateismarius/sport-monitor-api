using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.GameRepository;

namespace SportMonitorAPI.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpPost("add-game")]
        public async Task<IActionResult> AddTest([FromBody] Game game)
        {
            if (game != null)
            {
                await _gameRepository.AddGame(game);
            }
            return Ok(new ApiResponse(200, "Datele au fost inregistrate cu succes"));
        }

        [HttpGet("get-games")]
        public async Task<IActionResult> GetTestList()
        {
            var tests = await _gameRepository.GetGames();
            if (tests == null)
                return NotFound(new ApiResponse(404));
            return Ok(tests);
        }
        [HttpGet("get-games/{id}")]
        public async Task<IActionResult> GetTest(int id)
        {
            var game = await _gameRepository.GetGame(id);
            if (game == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(game);
        }
        [HttpPut("update-game/{id}")]
        public async Task<IActionResult> UpdatePlayer([FromBody]Game game)
        {
            if (game == null)
            {
                return NotFound(new ApiResponse(404));
            }
            await _gameRepository.UpdateGame(game);
            return Ok(game);
        }
        [HttpDelete("delete-game/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            await _gameRepository.DeleteGame(id);
            return Ok();
        }
    }
}
