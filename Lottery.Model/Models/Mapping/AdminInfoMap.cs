using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class AdminInfoMap : EntityTypeConfiguration<AdminInfo>
    {
        public AdminInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.AdminUserId);

            // Properties
            this.Property(t => t.AdminLoginName)
                .HasMaxLength(50);

            this.Property(t => t.LoginPwd)
                .HasMaxLength(50);

            this.Property(t => t.RealName)
                .HasMaxLength(20);

            this.Property(t => t.PhoneNo)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdminInfo");
            this.Property(t => t.AdminUserId).HasColumnName("AdminUserId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.AdminLoginName).HasColumnName("AdminLoginName");
            this.Property(t => t.LoginPwd).HasColumnName("LoginPwd");
            this.Property(t => t.AdminLevel).HasColumnName("AdminLevel");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");

            // Relationships
            this.HasOptional(t => t.RoleInfo)
                .WithMany(t => t.AdminInfoes)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
