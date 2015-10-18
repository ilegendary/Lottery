using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class RoleRightMap : EntityTypeConfiguration<RoleRight>
    {
        public RoleRightMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleRightsId);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoleRights");
            this.Property(t => t.RoleRightsId).HasColumnName("RoleRightsId");
            this.Property(t => t.RightId).HasColumnName("RightId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");

            // Relationships
            this.HasOptional(t => t.RightsInfo)
                .WithMany(t => t.RoleRights)
                .HasForeignKey(d => d.RightId);
            this.HasOptional(t => t.RoleInfo)
                .WithMany(t => t.RoleRights)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
