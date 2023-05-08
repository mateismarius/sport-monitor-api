using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class TestConfig : IEntityTypeConfiguration<PhysichalTest>
    {
        public void Configure(EntityTypeBuilder<PhysichalTest> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Unit).IsRequired();
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
        }
    }
}
