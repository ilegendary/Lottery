using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ProductImage
    {
        public int ImageId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageSize { get; set; }
        public Nullable<int> DeleteMark { get; set; }
        public Nullable<bool> IsMain { get; set; }
        public Nullable<int> SortNum { get; set; }
        public virtual Product Product { get; set; }
    }
}
