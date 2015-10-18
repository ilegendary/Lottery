using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class LotteryOpenRecordMap : EntityTypeConfiguration<LotteryOpenRecord>
    {
        public LotteryOpenRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.LotteryRecordId);

            // Properties
            this.Property(t => t.OpenCode)
                .HasMaxLength(50);

            this.Property(t => t.OpenExpect)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LotteryOpenRecord");
            this.Property(t => t.LotteryRecordId).HasColumnName("LotteryRecordId");
            this.Property(t => t.OpenCode).HasColumnName("OpenCode");
            this.Property(t => t.OpenExpect).HasColumnName("OpenExpect");
            this.Property(t => t.OpenTime).HasColumnName("OpenTime");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
