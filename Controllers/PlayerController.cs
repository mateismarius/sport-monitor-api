using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Dtos;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.MeasurementTakenRepository;
using SportMonitorAPI.Repositories.PlayerRepository;

namespace SportMonitorAPI.Controllers
{
    [Authorize]
    public class PlayerController : BaseApiController
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMeasurementTakenRepository _measurementTakenRepository;
        public PlayerController(IPlayerRepository playerRepository, IMeasurementTakenRepository measurementTakenRepository)
        {
            _playerRepository = playerRepository;
            _measurementTakenRepository = measurementTakenRepository;
        }

        [HttpPost("add-player")]
        public async Task<IActionResult> AddPlayer([FromBody] Player player)
        {
            if (player != null)
            {
               await _playerRepository.AddPlayer(player);
            }
            return Ok(new ApiResponse(200, "O noua jucatoare a fost inregistrata cu succes"));
        }

        [HttpGet("get-players")]
        public async Task<IActionResult> GetPlayerList()
        {
            var players = await _playerRepository.GetPlayers();
            var measurements = await _measurementTakenRepository.GetMeasurementList();
            var playerList = new List<PlayerDto>();
            foreach (var player in players)
            {
                PlayerDto playerDto = new PlayerDto();
                playerDto.Id = player.Id;
                playerDto.PlayerName = player.PlayerName;
                playerDto.Genre = player.Genre;
                playerDto.DateOfBirth = player.DateOfBirth;
                playerDto.StartDate = player.StartDate;
                playerDto.CratedtAt = player.CreatedAt;
                playerDto.LastModified = player.LastModified;
                playerDto.BadgeNo = player.BadgeNo;
                playerDto.IsActive = player.IsActive;
                var measurementList = measurements.Select(x => x).Where(p => p.PlayerId == player.Id && 
                                    (p.Measurement.Name.ToLower() == "inaltime" || p.Measurement.Name.ToLower() == "greutate"));
                foreach (var measurement in measurementList)
                {
                    if(measurement.PlayerId == player.Id )
                    {
                        var heightList = measurements.Select(x => x).Where(x => x.Measurement.Name.ToLower() == "inaltime").OrderByDescending(x => x.TakenAt).FirstOrDefault();
                        var weightList = measurements.Select(x => x).Where(x => x.Measurement.Name.ToLower() == "greutate").OrderByDescending(x => x.TakenAt).FirstOrDefault();
                        playerDto.ActualHeight = heightList.Result;
                        playerDto.ActualWeight = weightList.Result;
                    }
                }
                playerList.Add(playerDto);
            }
            return Ok(playerList);
        }
        [HttpGet("get-players/{id}")]
        public async Task<IActionResult> GetPlayer( int id)
        {
            var player = await _playerRepository.GetPlayer(id);
            if (player == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(player);
        }
        [HttpPut("update-player/{id}")]
        public async Task<IActionResult> UpdatePlayer([FromBody] Player player)
        {
            if (player == null)
            {
                return NotFound(new ApiResponse(404));
            }
            await _playerRepository.UpdatePlayer(player);
            return Ok(player);
        }
        [HttpDelete("delete-player/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            try
            {
                var playerToDelete = await _playerRepository.GetPlayer(id);

                if (playerToDelete== null)
                {
                    return NotFound(new ApiResponse(404, "Nu s-a gasit nici o inregistrare in baza de date"));
                }

                await _playerRepository.DeletePlayer(id);
            }
            catch (Exception)
            {
                return BadRequest(new ApiResponse(500));
            }
            await _playerRepository.DeletePlayer(id);
            return Ok(new ApiResponse(204));
        }
        [HttpGet("check-name/{name}")]
        public async Task<IActionResult> CheckIfPlayerExists(string name)
        {
            var players = await _playerRepository.GetPlayers();
            var playerName = players.Select(p => p.PlayerName).Where(p => p.Trim().ToLower() == name.Trim().ToLower()).ToList();
            var result = playerName.Count > 0 || playerName == null;
            return Ok(result);
        }
    }
}
