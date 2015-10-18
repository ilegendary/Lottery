using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class RightsInfoMap : EntityTypeConfiguration<RightsInfo>
    {
        public RightsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.RightId);

            // Properties
            this.Property(t => t.RightName)
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .HasMaxLength(200);

            this.Property(t => t.RightDesc)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RightsInfo");
            this.Property(t => t.RightId).HasColumnName("RightId");
            this.Property(t => t.RightName).HasColumnName("RightName");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.RightDesc).HasColumnName("RightDesc");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
        }
    }
}
