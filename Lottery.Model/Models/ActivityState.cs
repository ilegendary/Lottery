using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ActivityState
    {
        public int RecordId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string LuckyNumPool { get; set; }
        public Nullable<int> RemainedTimes { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<int> NeedTimes { get; set; }
        public virtual LotteryActivity LotteryActivity { get; set; }
    }
}
