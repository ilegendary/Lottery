using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lottery.Model.Mapping
{
    public class MessageInfoMap : EntityTypeConfiguration<MessageInfo>
    {
        public MessageInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageId);

            // Properties
            this.Property(t => t.SenderUserName)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MessageInfo");
            this.Property(t => t.MessageId).HasColumnName("MessageId");
            this.Property(t => t.MessageType).HasColumnName("MessageType");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.MessageContent).HasColumnName("MessageContent");
            this.Property(t => t.SenderId).HasColumnName("SenderId");
            this.Property(t => t.SenderUserName).HasColumnName("SenderUserName");
            this.Property(t => t.ReceiveUserId).HasColumnName("ReceiveUserId");
            this.Property(t => t.ReceiveUserName).HasColumnName("ReceiveUserName");
        }
    }
}
