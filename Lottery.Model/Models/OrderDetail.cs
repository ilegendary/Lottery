using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class OrderDetail
    {
        public int DetailId { get; set; }
        public string OrderSn { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<int> UesrId { get; set; }
        public string UserName { get; set; }
        public virtual OrderMain OrderMain { get; set; }
    }
}
