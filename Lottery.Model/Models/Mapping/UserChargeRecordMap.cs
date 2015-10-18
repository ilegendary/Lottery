using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class UserChargeRecordMap : EntityTypeConfiguration<UserChargeRecord>
    {
        public UserChargeRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ChargeRecordId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TradeNo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserChargeRecord");
            this.Property(t => t.ChargeRecordId).HasColumnName("ChargeRecordId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.TradeNo).HasColumnName("TradeNo");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ChargeDate).HasColumnName("ChargeDate");
            this.Property(t => t.ChargeStates).HasColumnName("ChargeStates");
            this.Property(t => t.Gained).HasColumnName("Gained");
            this.Property(t => t.ChargeChannel).HasColumnName("ChargeChannel");
        }
    }
}
