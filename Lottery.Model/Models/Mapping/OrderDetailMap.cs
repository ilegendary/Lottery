using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailId);

            // Properties
            this.Property(t => t.OrderSn)
                .HasMaxLength(50);

            this.Property(t => t.ActivityName)
                .HasMaxLength(100);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderDetail");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.OrderSn).HasColumnName("OrderSn");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.UesrId).HasColumnName("UesrId");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasOptional(t => t.OrderMain)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderSn);

        }
    }
}
