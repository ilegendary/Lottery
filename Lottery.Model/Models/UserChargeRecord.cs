using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class UserChargeRecord
    {
        public int ChargeRecordId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string TradeNo { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime ChargeDate { get; set; }
        public int ChargeStates { get; set; }
        public decimal Gained { get; set; }
        public int ChargeChannel { get; set; }
    }
}
