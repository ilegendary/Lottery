using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class SiteBaseInfoMap : EntityTypeConfiguration<SiteBaseInfo>
    {
        public SiteBaseInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteInfoId);

            // Properties
            this.Property(t => t.SiteName)
                .HasMaxLength(100);

            this.Property(t => t.SEO)
                .HasMaxLength(100);

            this.Property(t => t.Copyright)
                .HasMaxLength(200);

            this.Property(t => t.SiteDesc)
                .HasMaxLength(200);

            this.Property(t => t.SiteUrl)
                .HasMaxLength(200);

            this.Property(t => t.Tel_1)
                .HasMaxLength(20);

            this.Property(t => t.Tel_2)
                .HasMaxLength(20);

            this.Property(t => t.QQ_1)
                .HasMaxLength(20);

            this.Property(t => t.QQ_2)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.CompanyAddress)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SiteBaseInfo");
            this.Property(t => t.SiteInfoId).HasColumnName("SiteInfoId");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.SEO).HasColumnName("SEO");
            this.Property(t => t.Copyright).HasColumnName("Copyright");
            this.Property(t => t.SiteDesc).HasColumnName("SiteDesc");
            this.Property(t => t.SiteUrl).HasColumnName("SiteUrl");
            this.Property(t => t.Tel_1).HasColumnName("Tel_1");
            this.Property(t => t.Tel_2).HasColumnName("Tel_2");
            this.Property(t => t.QQ_1).HasColumnName("QQ_1");
            this.Property(t => t.QQ_2).HasColumnName("QQ_2");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyAddress).HasColumnName("CompanyAddress");
        }
    }
}
