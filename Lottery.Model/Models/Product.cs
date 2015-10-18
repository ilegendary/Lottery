using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class Product
    {
        public Product()
        {
            this.LotteryActivities = new List<LotteryActivity>();
            this.ProductImages = new List<ProductImage>();
        }

        public int ProductId { get; set; }
        public Nullable<int> PorductCategoryId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public Nullable<int> NeedTimes { get; set; }
        public Nullable<bool> IsAuto { get; set; }
        public Nullable<int> CurrentIssue { get; set; }
        public Nullable<int> RemainedIssue { get; set; }
        public int DeleteMark { get; set; }
        public virtual ICollection<LotteryActivity> LotteryActivities { get; set; }
        public virtual ProductCategroy ProductCategroy { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
