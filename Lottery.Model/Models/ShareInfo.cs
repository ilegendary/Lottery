using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ShareInfo
    {
        public int SharedId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string SharedTitle { get; set; }
        public string LuckNum { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> AcitvityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> SharedDate { get; set; }
        public Nullable<int> IssueNo { get; set; }
        public Nullable<int> NeedTimes { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<System.DateTime> RevealedDate { get; set; }
        public Nullable<bool> IsRecommended { get; set; }
        public Nullable<int> SortNum { get; set; }
        public string SharedImgUrl { get; set; }
        public Nullable<int> CheckedStates { get; set; }
        public int DeleteMark { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
