namespace SportMonitorAPI.Dtos
{
    public class TestTakenDto
    {
            public int Id { get; set; }
            public string? Player { get; set; }
            public string? Test { get; set; }
            public double Result { get; set; }
            public DateTime TakenAt { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime LastModified { get; set; }
        
    }
}
