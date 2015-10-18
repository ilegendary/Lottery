using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class LotteryActivityMap : EntityTypeConfiguration<LotteryActivity>
    {
        public LotteryActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.ActivityId);

            // Properties
            this.Property(t => t.ActivityName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NumA)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NumB)
                .HasMaxLength(20);

            this.Property(t => t.LuckNum)
                .HasMaxLength(20);

            this.Property(t => t.LuckyUserName)
                .HasMaxLength(50);

            this.Property(t => t.ParticipateTimes)
                .HasMaxLength(50);

            this.Property(t => t.Last55RecordsXML)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("LotteryActivity");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.NeedTimes).HasColumnName("NeedTimes");
            this.Property(t => t.IssueNo).HasColumnName("IssueNo");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.NumA).HasColumnName("NumA");
            this.Property(t => t.NumB).HasColumnName("NumB");
            this.Property(t => t.OpenDate).HasColumnName("OpenDate");
            this.Property(t => t.LuckNum).HasColumnName("LuckNum");
            this.Property(t => t.LimitTimes).HasColumnName("LimitTimes");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.RevealedTime).HasColumnName("RevealedTime");
            this.Property(t => t.LuckyUserId).HasColumnName("LuckyUserId");
            this.Property(t => t.LuckyUserName).HasColumnName("LuckyUserName");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.ActivityStates).HasColumnName("ActivityStates");
            this.Property(t => t.IsRecommend).HasColumnName("IsRecommend");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.LotteryOpenRecordId).HasColumnName("LotteryOpenRecordId");
            this.Property(t => t.Last55RecordsXML).HasColumnName("Last55RecordsXML");
            this.Property(t => t.IsNew).HasColumnName("IsNew");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.LotteryActivities)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
