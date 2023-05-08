namespace SportMonitorAPI.Entities
{
    public class MeasurementTaken : BaseEntity
    {
        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; } = new Measurement();
        public int PlayerId { get; set; }
        public Player Player { get; set; } = new Player();
        public double Result { get; set; }
        public DateTime TakenAt { get; set; }
    }
}
