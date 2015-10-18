using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class OrderMain
    {
        public OrderMain()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public string OrderSn { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> OrderStates { get; set; }
        public Nullable<int> PayMethod { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public Nullable<decimal> OrderTotalPrice { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string PayMethodName { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
