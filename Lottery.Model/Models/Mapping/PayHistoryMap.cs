using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class PayHistoryMap : EntityTypeConfiguration<PayHistory>
    {
        public PayHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.PayRecordId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayNo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PayHistory");
            this.Property(t => t.PayRecordId).HasColumnName("PayRecordId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.PayNo).HasColumnName("PayNo");
            this.Property(t => t.PayMethod).HasColumnName("PayMethod");
            this.Property(t => t.PayAmount).HasColumnName("PayAmount");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
        }
    }
}
