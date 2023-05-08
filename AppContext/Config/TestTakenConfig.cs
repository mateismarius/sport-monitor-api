using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class TestTakenConfig : IEntityTypeConfiguration<TestTaken>
    {
        public void Configure(EntityTypeBuilder<TestTaken> builder)
        {
            builder.Property(p => p.PlayerId).IsRequired();
            builder.HasOne(p => p.Player).WithMany()
                .HasForeignKey(p => p.PlayerId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.TestId).IsRequired();
            builder.HasOne(p => p.Test).WithMany()
                .HasForeignKey(p => p.TestId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
        }
    }
}
