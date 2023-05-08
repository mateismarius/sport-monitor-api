namespace SportMonitorAPI.Dtos
{
    public class TestPerformanceDto
    {
        public string? TestName { get; set; }
        public List<TestResultDto>? TestResults { get; set; }

    }

    public class TestResultDto
    {
        public DateTime TakenAt { get; set; }
        public double Evolution { get; set; }
    }
}
