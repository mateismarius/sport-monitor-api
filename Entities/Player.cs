namespace SportMonitorAPI.Entities
{
    public class Player : BaseEntity
    {
        public string PlayerName { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public string? BadgeNo { get; set; }
        public bool IsActive { get; set; }
    }
}
