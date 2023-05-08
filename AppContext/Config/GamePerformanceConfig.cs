using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class GamePerformanceConfig : IEntityTypeConfiguration<GamePerformance>
    {
        public void Configure(EntityTypeBuilder<GamePerformance> builder)
        {
            builder.Property(p => p.PlayerId).IsRequired();
            builder.HasOne(p => p.Player).WithMany()
                .HasForeignKey(p => p.PlayerId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.GameId).IsRequired();
            builder.HasOne(p => p.Game).WithMany()
                .HasForeignKey(p => p.GameId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(p => p.TotalScores).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.TotalSuspension).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.RedCards).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.Overrall).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
        }
    }
}
