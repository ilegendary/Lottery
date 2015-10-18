using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class BaseSet
    {
        public int SetId { get; set; }
        public Nullable<bool> AllowRegister { get; set; }
        public Nullable<decimal> InvitiedAmount { get; set; }
        public Nullable<decimal> RegisterAmount { get; set; }
        public Nullable<decimal> ChargePresentAmount { get; set; }
        public Nullable<decimal> SharedAccount { get; set; }
        public Nullable<int> SharedCheckedMethod { get; set; }
        public Nullable<System.DateTime> OpenTime { get; set; }
        public string RegisterMsgTemplate { get; set; }
        public string PaySucceedMsgTemplate { get; set; }
        public string ChangePwdMsgTemplate { get; set; }
        public string RegSucceedMsgTemplate { get; set; }
        public string PayProcessMsgTemplate { get; set; }
    }
}
