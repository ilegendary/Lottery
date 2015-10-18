using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class InvitedRecordMap : EntityTypeConfiguration<InvitedRecord>
    {
        public InvitedRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("InvitedRecord");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.InvitiedDate).HasColumnName("InvitiedDate");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.States).HasColumnName("States");

            // Relationships
            this.HasRequired(t => t.UserInfo)
                .WithMany(t => t.InvitedRecords)
                .HasForeignKey(d => d.UserId);

        }
    }
}
