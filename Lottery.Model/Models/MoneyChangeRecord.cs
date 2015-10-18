using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class MoneyChangeRecord
    {
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public int MoneyType { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public string Note { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
