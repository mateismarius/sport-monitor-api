namespace SportMonitorAPI.Entities
{
    public class Measurement : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
    }
}
