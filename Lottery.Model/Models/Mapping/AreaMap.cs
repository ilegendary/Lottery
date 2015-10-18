using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaId);

            // Properties
            this.Property(t => t.AreaName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Area");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
        }
    }
}
