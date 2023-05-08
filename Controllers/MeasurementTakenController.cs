using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Dtos;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.MeasurementRepository;
using SportMonitorAPI.Repositories.MeasurementTakenRepository;
using SportMonitorAPI.Repositories.PlayerRepository;

namespace SportMonitorAPI.Controllers
{
    public class MeasurementTakenController : BaseApiController
    {
        private readonly IMeasurementTakenRepository _measurementTakenRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IMeasurementRepository _measurementRepository;

        public MeasurementTakenController(IMeasurementTakenRepository measurementTakenRepository, 
                IMeasurementRepository measurementRepository, IPlayerRepository playerRepository)
        {
            _measurementTakenRepository = measurementTakenRepository;
            _measurementRepository = measurementRepository;
            _playerRepository = playerRepository;
        }


        [HttpPost("add-measurement-taken")]
        public async Task<IActionResult> AddTest([FromBody] MeasurementTakenDto msrTk)
        {
            if (msrTk != null)
            {
                var playerList = await _playerRepository.GetPlayers();
                var player = playerList.FirstOrDefault(p => p.PlayerName == msrTk.Player);
                var msrList = await _measurementRepository.GetMeasurementList();
                var msr = msrList.FirstOrDefault(p => p.Name == msrTk.Measurement);
                MeasurementTaken msrTkn = new();
                if (player != null && msr != null)
                {
                    msrTkn.PlayerId = player.Id;
                    msrTkn.MeasurementId = msr.Id;
                    msrTkn.Result = msrTk.Result;
                    msrTkn.TakenAt = msrTk.TakenAt;
                    msrTkn.CreatedAt = DateTime.Now;
                    msrTkn.LastModified = DateTime.Now;
                }
                await _measurementTakenRepository.AddMeasurement(msrTkn);
            }
            return Ok(new ApiResponse(200, "Datele au fost inregistrate cu succes"));
        }

        [HttpGet("get-measurement-taken")]
        public async Task<IActionResult> GetTestList()
        {
            var msrTk = await _measurementTakenRepository.GetMeasurementList();
            if (msrTk == null)
                return NotFound(new ApiResponse(404));
            return Ok(msrTk);
        }
    }
}
