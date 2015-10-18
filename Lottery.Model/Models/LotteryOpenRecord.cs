using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class LotteryOpenRecord
    {
        public int LotteryRecordId { get; set; }
        public string OpenCode { get; set; }
        public string OpenExpect { get; set; }
        public Nullable<System.DateTime> OpenTime { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
