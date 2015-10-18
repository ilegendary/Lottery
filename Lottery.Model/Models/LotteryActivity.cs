using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class LotteryActivity
    {
        public LotteryActivity()
        {
            this.ActivityStates1 = new List<ActivityState>();
            this.ParticipateRecords = new List<ParticipateRecord>();
        }

        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public int NeedTimes { get; set; }
        public int IssueNo { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string NumA { get; set; }
        public string NumB { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public string LuckNum { get; set; }
        public Nullable<int> LimitTimes { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> RevealedTime { get; set; }
        public Nullable<int> LuckyUserId { get; set; }
        public string LuckyUserName { get; set; }
        public string ParticipateTimes { get; set; }
        public Nullable<int> ActivityStates { get; set; }
        public bool IsRecommend { get; set; }
        public int SortNum { get; set; }
        public Nullable<int> LotteryOpenRecordId { get; set; }
        public string Last55RecordsXML { get; set; }
        public bool IsNew { get; set; }
        public virtual ICollection<ActivityState> ActivityStates1 { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ParticipateRecord> ParticipateRecords { get; set; }
    }
}
