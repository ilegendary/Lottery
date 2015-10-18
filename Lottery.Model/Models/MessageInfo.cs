using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class MessageInfo
    {
        public int MessageId { get; set; }
        public Nullable<int> MessageType { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public string MessageContent { get; set; }
        public Nullable<int> SenderId { get; set; }
        public string SenderUserName { get; set; }
        public Nullable<int> ReceiveUserId { get; set; }
        public string ReceiveUserName { get; set; }
    }
}
