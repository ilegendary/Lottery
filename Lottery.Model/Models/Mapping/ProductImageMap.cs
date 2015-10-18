using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ProductImageMap : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ImageId);

            // Properties
            this.Property(t => t.ImageUrl)
                .HasMaxLength(200);

            this.Property(t => t.ImageSize)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProductImage");
            this.Property(t => t.ImageId).HasColumnName("ImageId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.ImageSize).HasColumnName("ImageSize");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
            this.Property(t => t.IsMain).HasColumnName("IsMain");
            this.Property(t => t.SortNum).HasColumnName("SortNum");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ProductImages)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
