using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            this.Property(t => t.ProductName)
                .HasMaxLength(100);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.PorductCategoryId).HasColumnName("PorductCategoryId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ProductPrice).HasColumnName("ProductPrice");
            this.Property(t => t.NeedTimes).HasColumnName("NeedTimes");
            this.Property(t => t.IsAuto).HasColumnName("IsAuto");
            this.Property(t => t.CurrentIssue).HasColumnName("CurrentIssue");
            this.Property(t => t.RemainedIssue).HasColumnName("RemainedIssue");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");

            // Relationships
            this.HasOptional(t => t.ProductCategroy)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.PorductCategoryId);

        }
    }
}
