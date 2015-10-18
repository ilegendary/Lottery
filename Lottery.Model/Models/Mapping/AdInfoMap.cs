using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class AdInfoMap : EntityTypeConfiguration<AdInfo>
    {
        public AdInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.AdId);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ImgUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreatetUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdInfo");
            this.Property(t => t.AdId).HasColumnName("AdId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.ImgUrl).HasColumnName("ImgUrl");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreatetUserName).HasColumnName("CreatetUserName");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");

            // Relationships
            this.HasRequired(t => t.AdType)
                .WithMany(t => t.AdInfoes)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
