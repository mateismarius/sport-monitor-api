using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.MeasurementRepository;
using SportMonitorAPI.Repositories.TestRepository;

namespace SportMonitorAPI.Controllers
{
    public class MeasurementController : BaseApiController
    {
        private readonly IMeasurementRepository _measurementRepository;
        public MeasurementController(IMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }
        [HttpPost("add-measurement")]
        public async Task<IActionResult> AddMeasurement([FromBody] Measurement measurement)
        {
            if (measurement != null)
            {
                await _measurementRepository.AddMeasurement(measurement);
            }
            return Ok(new ApiResponse(200, "Datele au fost inregistrate cu succes"));
        }

        [HttpGet("get-measurements")]
        public async Task<IActionResult> GetTestList()
        {
            var tests = await _measurementRepository.GetMeasurementList();
            if (tests == null)
                return NotFound(new ApiResponse(404));
            return Ok(tests);
        }
        [HttpGet("get-measurement/{id}")]
        public async Task<IActionResult> GetTest( int id)
        {
            var measurement = await _measurementRepository.GetMeasurement(id);
            if (measurement == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(measurement);
        }
        [HttpPut("update-measurement/{id}")]
        public async Task<IActionResult> UpdatePlayer([FromBody] Measurement measurement)
        {
            if (measurement == null)
            {
                return NotFound(new ApiResponse(404));
            }
            
            await _measurementRepository.UpdateMeasurement(measurement);
            return Ok(measurement);
        }
        [HttpDelete("delete-measurement/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            await _measurementRepository.DeleteMeasurement(id);
            return Ok();
        }
    }
}
