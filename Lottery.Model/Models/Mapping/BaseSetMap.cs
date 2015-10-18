using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class BaseSetMap : EntityTypeConfiguration<BaseSet>
    {
        public BaseSetMap()
        {
            // Primary Key
            this.HasKey(t => t.SetId);

            // Properties
            this.Property(t => t.RegisterMsgTemplate)
                .HasMaxLength(200);

            this.Property(t => t.PaySucceedMsgTemplate)
                .HasMaxLength(200);

            this.Property(t => t.ChangePwdMsgTemplate)
                .HasMaxLength(200);

            this.Property(t => t.RegSucceedMsgTemplate)
                .HasMaxLength(200);

            this.Property(t => t.PayProcessMsgTemplate)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BaseSet");
            this.Property(t => t.SetId).HasColumnName("SetId");
            this.Property(t => t.AllowRegister).HasColumnName("AllowRegister");
            this.Property(t => t.InvitiedAmount).HasColumnName("InvitiedAmount");
            this.Property(t => t.RegisterAmount).HasColumnName("RegisterAmount");
            this.Property(t => t.ChargePresentAmount).HasColumnName("ChargePresentAmount");
            this.Property(t => t.SharedAccount).HasColumnName("SharedAccount");
            this.Property(t => t.SharedCheckedMethod).HasColumnName("SharedCheckedMethod");
            this.Property(t => t.OpenTime).HasColumnName("OpenTime");
            this.Property(t => t.RegisterMsgTemplate).HasColumnName("RegisterMsgTemplate");
            this.Property(t => t.PaySucceedMsgTemplate).HasColumnName("PaySucceedMsgTemplate");
            this.Property(t => t.ChangePwdMsgTemplate).HasColumnName("ChangePwdMsgTemplate");
            this.Property(t => t.RegSucceedMsgTemplate).HasColumnName("RegSucceedMsgTemplate");
            this.Property(t => t.PayProcessMsgTemplate).HasColumnName("PayProcessMsgTemplate");
        }
    }
}
