using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class InvitedRecord
    {
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public System.DateTime InvitiedDate { get; set; }
        public string LinkUrl { get; set; }
        public int States { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
