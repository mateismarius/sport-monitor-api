namespace SportMonitorAPI.Entities
{
    public class Game : BaseEntity
    {
        public string Opponent { get; set; } = string.Empty;
        public string CityGame { get; set; } = string.Empty;
        public string SportHall { get; set; } = string.Empty;
        public DateTime GameDate { get; set; }
        public int TeamGoals { get; set; }
        public int OpponentGoals { get; set; }
    }
}
