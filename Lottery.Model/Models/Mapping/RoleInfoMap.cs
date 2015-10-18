using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class RoleInfoMap : EntityTypeConfiguration<RoleInfo>
    {
        public RoleInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleId);

            // Properties
            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoleDesc)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RoleInfo");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.RoleDesc).HasColumnName("RoleDesc");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
        }
    }
}
