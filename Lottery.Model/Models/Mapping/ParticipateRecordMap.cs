using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ParticipateRecordMap : EntityTypeConfiguration<ParticipateRecord>
    {
        public ParticipateRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordId);

            // Properties
            this.Property(t => t.NickName)
                .HasMaxLength(50);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.DateNum)
                .HasMaxLength(20);

            this.Property(t => t.ActivityName)
                .HasMaxLength(100);

            this.Property(t => t.IP)
                .HasMaxLength(20);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ParticipateRecord");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ParticipateDate).HasColumnName("ParticipateDate");
            this.Property(t => t.DateNum).HasColumnName("DateNum");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.LotteryNum).HasColumnName("LotteryNum");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Location).HasColumnName("Location");

            // Relationships
            this.HasOptional(t => t.LotteryActivity)
                .WithMany(t => t.ParticipateRecords)
                .HasForeignKey(d => d.ActivityId);
            this.HasRequired(t => t.UserInfo)
                .WithMany(t => t.ParticipateRecords)
                .HasForeignKey(d => d.UserId);

        }
    }
}
