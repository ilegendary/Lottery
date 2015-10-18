using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class ShareInfoMap : EntityTypeConfiguration<ShareInfo>
    {
        public ShareInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.SharedId);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.NickName)
                .HasMaxLength(100);

            this.Property(t => t.SharedTitle)
                .HasMaxLength(100);

            this.Property(t => t.LuckNum)
                .HasMaxLength(20);

            this.Property(t => t.ProductName)
                .HasMaxLength(100);

            this.Property(t => t.ActivityName)
                .HasMaxLength(100);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.SharedImgUrl)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ShareInfo");
            this.Property(t => t.SharedId).HasColumnName("SharedId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.SharedTitle).HasColumnName("SharedTitle");
            this.Property(t => t.LuckNum).HasColumnName("LuckNum");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.AcitvityId).HasColumnName("AcitvityId");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.SharedDate).HasColumnName("SharedDate");
            this.Property(t => t.IssueNo).HasColumnName("IssueNo");
            this.Property(t => t.NeedTimes).HasColumnName("NeedTimes");
            this.Property(t => t.ParticipateTimes).HasColumnName("ParticipateTimes");
            this.Property(t => t.RevealedDate).HasColumnName("RevealedDate");
            this.Property(t => t.IsRecommended).HasColumnName("IsRecommended");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.SharedImgUrl).HasColumnName("SharedImgUrl");
            this.Property(t => t.CheckedStates).HasColumnName("CheckedStates");
            this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");

            // Relationships
            this.HasRequired(t => t.UserInfo)
                .WithMany(t => t.ShareInfoes)
                .HasForeignKey(d => d.UserId);

        }
    }
}
