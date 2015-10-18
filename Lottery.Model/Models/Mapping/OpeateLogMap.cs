using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class OpeateLogMap : EntityTypeConfiguration<OpeateLog>
    {
        public OpeateLogMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordId);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(20);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OpeateLog");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.OperateType).HasColumnName("OperateType");
            this.Property(t => t.OperateDate).HasColumnName("OperateDate");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.OperateStates).HasColumnName("OperateStates");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
