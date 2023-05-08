using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.TestRepository;

namespace SportMonitorAPI.Controllers
{
    public class TestController : BaseApiController
    {
        private readonly ITestRepository _testRepository;
        public TestController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        [HttpPost("add-test")]
        public async Task<IActionResult> AddTest([FromBody] PhysichalTest test)
        {
            if (test != null)
            {
                await _testRepository.AddTest(test);
            }
            return Ok(new ApiResponse(200, "Un nou test a fost introdus in baza de date"));
        }

        [HttpGet("get-tests")]
        public async Task<IActionResult> GetTestList()
        {
            var tests = await _testRepository.GetTests();
            if (tests == null)
                return NotFound(new ApiResponse(404));
            return Ok(tests);
        }
        [HttpGet("get-tests/{id}")]
        public async Task<IActionResult> GetTest(int id)
        {
            var test = await _testRepository.GetTest(id);
            if (test == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(test);
        }
        [HttpPut("update-test/{id}")]
        public async Task<IActionResult> UpdatePlayer([FromBody] PhysichalTest test)
        {
            if (test == null)
            {
                return NotFound(new ApiResponse(404));
            }
            await _testRepository.UpdateTest(test);
            return Ok(test);
        }
        [HttpDelete("delete-test/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            await _testRepository.DeleteTest(id);
            return Ok();
        }
    }
}
