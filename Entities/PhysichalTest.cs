namespace SportMonitorAPI.Entities
{
    public class PhysichalTest : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public bool CompareRuleAscending { get; set; }
    }
}
