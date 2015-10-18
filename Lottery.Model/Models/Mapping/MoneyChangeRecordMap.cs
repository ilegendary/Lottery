using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class MoneyChangeRecordMap : EntityTypeConfiguration<MoneyChangeRecord>
    {
        public MoneyChangeRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordId);

            // Properties
            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MoneyChangeRecord");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.MoneyType).HasColumnName("MoneyType");
            this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.UserInfo)
                .WithMany(t => t.MoneyChangeRecords)
                .HasForeignKey(d => d.UserId);

        }
    }
}
