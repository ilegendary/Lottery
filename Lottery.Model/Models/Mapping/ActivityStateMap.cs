using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ActivityStateMap : EntityTypeConfiguration<ActivityState>
    {
        public ActivityStateMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActivityStates");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.LuckyNumPool).HasColumnName("LuckyNumPool");
            this.Property(t => t.RemainedTimes).HasColumnName("RemainedTimes");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.NeedTimes).HasColumnName("NeedTimes");

            // Relationships
            this.HasOptional(t => t.LotteryActivity)
                .WithMany(t => t.ActivityStates1)
                .HasForeignKey(d => d.ActivityId);

        }
    }
}
