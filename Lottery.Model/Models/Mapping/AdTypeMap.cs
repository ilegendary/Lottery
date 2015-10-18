using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class AdTypeMap : EntityTypeConfiguration<AdType>
    {
        public AdTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeId);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TypeDesc)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdType");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.TypeDesc).HasColumnName("TypeDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
        }
    }
}
