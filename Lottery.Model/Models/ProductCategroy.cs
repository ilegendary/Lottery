using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ProductCategroy
    {
        public ProductCategroy()
        {
            this.Products = new List<Product>();
        }

        public int PorductCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> SortNum { get; set; }
        public Nullable<int> DeleteMark { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
