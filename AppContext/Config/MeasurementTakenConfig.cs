using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.AppContext.Config
{
    public class MeasurementTakenConfig : IEntityTypeConfiguration<MeasurementTaken>
    {
        public void Configure(EntityTypeBuilder<MeasurementTaken> builder)
        {
            builder.Property(p => p.PlayerId).IsRequired();
            builder.HasOne(p => p.Player).WithMany()
                .HasForeignKey(p => p.PlayerId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.MeasurementId).IsRequired();
            builder.HasOne(p => p.Measurement).WithMany()
                .HasForeignKey(p => p.MeasurementId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.LastModified).HasColumnType("datetime2").HasDefaultValue(DateTime.Now);
        }
    }
}
