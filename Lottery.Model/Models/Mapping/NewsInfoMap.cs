using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class NewsInfoMap : EntityTypeConfiguration<NewsInfo>
    {
        public NewsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.NewsId);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NewsContent)
                .IsRequired();

            this.Property(t => t.NewsTitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NewsAuthor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NewsInfo");
            this.Property(t => t.NewsId).HasColumnName("NewsId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.NewsContent).HasColumnName("NewsContent");
            this.Property(t => t.NewsTitle).HasColumnName("NewsTitle");
            this.Property(t => t.NewsAuthor).HasColumnName("NewsAuthor");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");

            // Relationships
            this.HasOptional(t => t.NewsType)
                .WithMany(t => t.NewsInfoes)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
