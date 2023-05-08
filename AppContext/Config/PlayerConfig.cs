using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Net;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(p => p.PlayerName).IsRequired();
            builder.Property(p => p.Genre).IsRequired().HasDefaultValue("Feminin");
            builder.Property(p => p.BadgeNo).IsRequired().HasDefaultValue("Nu este legitimat");
            builder.Property(p => p.DateOfBirth).HasColumnType("datetime2");
            builder.Property(p => p.StartDate).HasColumnType("datetime2");
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
            builder.Property(p => p.IsActive).IsRequired();
        }
    }
}
