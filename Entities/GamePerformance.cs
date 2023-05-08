namespace SportMonitorAPI.Entities
{
    public class GamePerformance : BaseEntity
    {
        public int GameId { get; set; }
        public Game Game { get; set; } = new Game();
        public int PlayerId { get; set; }
        public Player Player { get; set; } = new Player();
        public int TotalScores { get; set; }
        public int TotalSuspension { get; set; }
        public int RedCards { get; set; }
        public double Overrall { get; set; }
    }
}
