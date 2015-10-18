using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class UserInfoMap : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LoginPwd)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NickName)
                .HasMaxLength(100);

            this.Property(t => t.LinkUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UserHeadImgUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PhoneNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayPwd)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WxOpenId)
                .HasMaxLength(50);

            this.Property(t => t.WxUserHeadImg)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("UserInfo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.LoginPwd).HasColumnName("LoginPwd");
            this.Property(t => t.VirtualMoney).HasColumnName("VirtualMoney");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.PresentMoney).HasColumnName("PresentMoney");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.LotteryScore).HasColumnName("LotteryScore");
            this.Property(t => t.UserHeadImgUrl).HasColumnName("UserHeadImgUrl");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.AdressCount).HasColumnName("AdressCount");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PayPwd).HasColumnName("PayPwd");
            this.Property(t => t.InvitiedCount).HasColumnName("InvitiedCount");
            this.Property(t => t.WxOpenId).HasColumnName("WxOpenId");
            this.Property(t => t.WxUserHeadImg).HasColumnName("WxUserHeadImg");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
        }
    }
}
