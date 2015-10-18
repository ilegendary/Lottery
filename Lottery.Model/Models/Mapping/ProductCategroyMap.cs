using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ProductCategroyMap : EntityTypeConfiguration<ProductCategroy>
    {
        public ProductCategroyMap()
        {
            // Primary Key
            this.HasKey(t => t.PorductCategoryId);

            // Properties
            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.CategoryDesc)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserId)
                .HasMaxLength(50);

            this.Property(t => t.CreateUserName)
                .HasMaxLength(50);

            this.Property(t => t.ModifyUserId)
                .HasMaxLength(50);

            this.Property(t => t.ModifyUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCategroy");
            this.Property(t => t.PorductCategoryId).HasColumnName("PorductCategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.CategoryDesc).HasColumnName("CategoryDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.ModifyUserId).HasColumnName("ModifyUserId");
            this.Property(t => t.ModifyUserName).HasColumnName("ModifyUserName");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
        }
    }
}
