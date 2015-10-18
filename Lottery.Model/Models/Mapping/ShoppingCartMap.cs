using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ShoppingCartMap : EntityTypeConfiguration<ShoppingCart>
    {
        public ShoppingCartMap()
        {
            // Primary Key
            this.HasKey(t => t.ShoppingCartId);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.TempUserId)
                .HasMaxLength(50);

            this.Property(t => t.ProductName)
                .HasMaxLength(100);

            this.Property(t => t.CataegoryName)
                .HasMaxLength(50);

            this.Property(t => t.ActivityName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ShoppingCart");
            this.Property(t => t.ShoppingCartId).HasColumnName("ShoppingCartId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.TempUserId).HasColumnName("TempUserId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CataegoryId).HasColumnName("CataegoryId");
            this.Property(t => t.CataegoryName).HasColumnName("CataegoryName");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.IssueNo).HasColumnName("IssueNo");

            // Relationships
            this.HasOptional(t => t.UserInfo)
                .WithMany(t => t.ShoppingCarts)
                .HasForeignKey(d => d.UserId);

        }
    }
}
