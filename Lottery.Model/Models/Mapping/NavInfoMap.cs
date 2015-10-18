using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class NavInfoMap : EntityTypeConfiguration<NavInfo>
    {
        public NavInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.NavInfoId);

            // Properties
            this.Property(t => t.NavName)
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("NavInfo");
            this.Property(t => t.NavInfoId).HasColumnName("NavInfoId");
            this.Property(t => t.NavName).HasColumnName("NavName");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.IsNav).HasColumnName("IsNav");
            this.Property(t => t.DeleteStates).HasColumnName("DeleteStates");
        }
    }
}
