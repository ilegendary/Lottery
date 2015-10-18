using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ParticipateRecord
    {
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public string NickName { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> ParticipateDate { get; set; }
        public string DateNum { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string LotteryNum { get; set; }
        public string IP { get; set; }
        public string Location { get; set; }
        public virtual LotteryActivity LotteryActivity { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
