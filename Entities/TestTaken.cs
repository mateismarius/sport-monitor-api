namespace SportMonitorAPI.Entities
{
    public class TestTaken : BaseEntity
    {
        public int TestId { get; set; }
        public PhysichalTest Test { get; set; } = new PhysichalTest();
        public int PlayerId { get; set; }
        public Player Player { get; set; } = new Player();
        public double Result { get; set; }
        public DateTime TakenAt { get; set; }
    }
}
