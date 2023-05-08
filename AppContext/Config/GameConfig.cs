using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(p => p.Opponent).IsRequired();
            builder.Property(p => p.CityGame).IsRequired();
            builder.Property(p => p.SportHall).IsRequired();
            builder.Property(p => p.TeamGoals).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.OpponentGoals).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.GameDate).HasColumnType("datetime2");
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
        }
    }

}

