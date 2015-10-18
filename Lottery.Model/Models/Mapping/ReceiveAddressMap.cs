using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ReceiveAddressMap : EntityTypeConfiguration<ReceiveAddress>
    {
        public ReceiveAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ProvinceName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CityName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CountyName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DetailAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ReceiveRealName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PostCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ReceiveAddress");
            this.Property(t => t.AddressId).HasColumnName("AddressId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.CountyId).HasColumnName("CountyId");
            this.Property(t => t.ProvinceName).HasColumnName("ProvinceName");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.CountyName).HasColumnName("CountyName");
            this.Property(t => t.DetailAddress).HasColumnName("DetailAddress");
            this.Property(t => t.ReceiveRealName).HasColumnName("ReceiveRealName");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");

            // Relationships
            this.HasRequired(t => t.UserInfo)
                .WithMany(t => t.ReceiveAddresses)
                .HasForeignKey(d => d.UserId);

        }
    }
}
