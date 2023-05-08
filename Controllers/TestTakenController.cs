using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.Dtos;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Errors;
using SportMonitorAPI.Repositories.MeasurementRepository;
using SportMonitorAPI.Repositories.MeasurementTakenRepository;
using SportMonitorAPI.Repositories.PlayerRepository;
using SportMonitorAPI.Repositories.TestRepository;
using SportMonitorAPI.Repositories.TestTakenRepository;
using System.Collections.Generic;

namespace SportMonitorAPI.Controllers
{
    public class TestTakenController : BaseApiController
    {
        private readonly ITestTakenRepository _testTakenTakenRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly ITestRepository _testRepository;

        public TestTakenController(ITestTakenRepository testTakenRepository,
                ITestRepository testRepository, IPlayerRepository playerRepository)
        {
            _testTakenTakenRepository = testTakenRepository;
            _testRepository = testRepository;
            _playerRepository = playerRepository;
        }


        [HttpPost("add-test-taken")]
        public async Task<IActionResult> AddTest([FromBody] TestTakenDto testTk)
        {
            if (testTk != null)
            {
                var playerList = await _playerRepository.GetPlayers();
                var player = playerList.FirstOrDefault(p => p.PlayerName == testTk.Player);
                var msrList = await _testRepository.GetTests();
                var msr = msrList.FirstOrDefault(p => p.Name == testTk.Test);
                TestTaken testTkn = new();
                if (player != null && msr != null)
                {
                    testTkn.PlayerId = player.Id;
                    testTkn.TestId = msr.Id;
                    testTkn.Result = testTk.Result;
                    testTkn.TakenAt = testTk.TakenAt;
                    testTkn.CreatedAt = DateTime.Now;
                    testTkn.LastModified = DateTime.Now;
                }
                await _testTakenTakenRepository.AddTest(testTkn);
            }
            return Ok(new ApiResponse(200, "Datele au fost inregistrate cu succes"));
        }

        [HttpGet("get-test-taken")]
        public async Task<IActionResult> GetTestList()
        {
            var testTk = await _testTakenTakenRepository.GetTestList();
            if (testTk == null)
                return NotFound(new ApiResponse(404));
            return Ok(testTk);
        }

        [HttpGet("get-test-player/{id}")]
        public async Task<IActionResult> GetTestByPlayer(int id)
        {
            var testList =  await _testTakenTakenRepository.GetTestByPlayer(id);
            return Ok(testList);
        }
        [HttpGet("get-test-list/{id}")]
        public async Task<IActionResult> GetAllTestsById(int id)
        {
            var testList = await _testTakenTakenRepository.GetAllTestsById(id);
            return Ok(testList);
        }
        [HttpGet("get-test-evolution/{id}")]
        public async Task<IActionResult> GetEvolution(int id)
        {
            var testResults = await _testTakenTakenRepository.GetTestByPlayer(id);
            var testList = testResults.Select(t => t.Test.Name).Distinct();
            List<TestPerformanceDto> performanceList = new();
            foreach (var test in testList)
            {
                TestPerformanceDto evol = new()
                {
                    TestName = test,
                    TestResults = new List<TestResultDto>()
                };

                List<TestTaken> results = testResults.Select(t => t).Where(t => t.Test.Name == test).OrderBy(t => t.TakenAt).ToList();
                bool testCompare = testResults.Where(t => t.Test.Name == test).Select(t => t.Test.CompareRuleAscending).FirstOrDefault();
                double prevResult = results[0].Result;
                foreach(var performance in results)
                {
                    TestResultDto tempResult = new()
                    {
                        TakenAt = performance.TakenAt,
                        Evolution = testCompare ? Math.Round((performance.Result / prevResult) - 1, 2) : Math.Round((prevResult  / performance.Result) - 1, 2),
                    };
                    evol.TestResults.Add(tempResult);
                    prevResult = performance.Result;
                }
                performanceList.Add(evol);
            }
            return Ok(performanceList);
        } 
    }
}
