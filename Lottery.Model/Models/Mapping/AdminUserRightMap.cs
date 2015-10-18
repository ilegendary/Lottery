using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class AdminUserRightMap : EntityTypeConfiguration<AdminUserRight>
    {
        public AdminUserRightMap()
        {
            // Primary Key
            this.HasKey(t => t.RightId);

            // Properties
            this.Property(t => t.RightName)
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .HasMaxLength(200);

            this.Property(t => t.AdminUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdminUserRights");
            this.Property(t => t.RightId).HasColumnName("RightId");
            this.Property(t => t.RightName).HasColumnName("RightName");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.AdminUserId).HasColumnName("AdminUserId");
            this.Property(t => t.AdminUserName).HasColumnName("AdminUserName");

            // Relationships
            this.HasOptional(t => t.AdminInfo)
                .WithMany(t => t.AdminUserRights)
                .HasForeignKey(d => d.AdminUserId);

        }
    }
}
