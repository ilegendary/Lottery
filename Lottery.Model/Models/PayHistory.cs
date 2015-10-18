using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class PayHistory
    {
        public int PayRecordId { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string PayNo { get; set; }
        public int PayMethod { get; set; }
        public decimal PayAmount { get; set; }
        public System.DateTime PayDate { get; set; }
    }
}
