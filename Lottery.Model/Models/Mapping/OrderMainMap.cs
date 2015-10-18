using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class OrderMainMap : EntityTypeConfiguration<OrderMain>
    {
        public OrderMainMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderSn);

            // Properties
            this.Property(t => t.OrderSn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.PayMethodName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("OrderMain");
            this.Property(t => t.OrderSn).HasColumnName("OrderSn");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.OrderStates).HasColumnName("OrderStates");
            this.Property(t => t.PayMethod).HasColumnName("PayMethod");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.OrderTotalPrice).HasColumnName("OrderTotalPrice");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.PayMethodName).HasColumnName("PayMethodName");
            this.Property(t => t.PayAmount).HasColumnName("PayAmount");

            // Relationships
            this.HasOptional(t => t.UserInfo)
                .WithMany(t => t.OrderMains)
                .HasForeignKey(d => d.UserId);

        }
    }
}
