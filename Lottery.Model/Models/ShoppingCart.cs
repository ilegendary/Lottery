using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string TempUserId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CataegoryId { get; set; }
        public string CataegoryName { get; set; }
        public Nullable<int> ParticipateTimes { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> IssueNo { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
