namespace SportMonitorAPI.Dtos
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string PlayerName { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CratedtAt { get; set; }
        public DateTime LastModified { get; set; }
        public string? BadgeNo { get; set; }
        public bool IsActive { get; set; }
        public double ActualHeight { get; set; }
        public double ActualWeight { get; set; }

    }
}
