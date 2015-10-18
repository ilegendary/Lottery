using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class OpeateLog
    {
        public int RecordId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> OperateType { get; set; }
        public Nullable<System.DateTime> OperateDate { get; set; }
        public string IP { get; set; }
        public Nullable<int> OperateStates { get; set; }
        public string Note { get; set; }
    }
}
